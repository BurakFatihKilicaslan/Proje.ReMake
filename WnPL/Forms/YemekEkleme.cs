using BLL.BLL.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPL.Forms
{
    public partial class YemekEkleme : Form
    {
        public YemekEkleme()
        {
            InitializeComponent();
            kategori = new Kategori();
            kategoriBLL = new KategoriBLL();
            yiyecekBLL = new YiyecekBLL();
            yiyecekDetayBLL = new YiyecekDetayBLL();
            yiyecekDetay = new YiyecekDetay();
        }
		byte[] resimBytes;
		Kategori kategori;
        KategoriBLL kategoriBLL;
        YiyecekBLL yiyecekBLL;
        YiyecekDetayBLL yiyecekDetayBLL;
        YiyecekDetay yiyecekDetay;
        private void YemekEkleme_Load(object sender, EventArgs e)
        {
            cboxKategori.DisplayMember = "KategoriAd";
            cboxKategori.ValueMember = "ID";
            cboxKategori.DataSource = kategoriBLL.Listele();
			byte[]? resimYolu = yiyecekDetay.ResimYolu; // resimYolu byte[]? tipinde

			if (resimYolu != null)
			{
				using (MemoryStream memoryStream = new MemoryStream(resimYolu))
				{
					memoryStream.Seek(0, SeekOrigin.Begin); // MemoryStream'i başlangıç konumuna getirdik

					try
					{
						Image resim = Image.FromStream(memoryStream);
						pboxYemekResmi.Image = resim;
					}
					catch (ArgumentException ex)
					{
						// Geçersiz resim dosyası hatası
						Console.WriteLine("Hata: Geçersiz resim dosyası. " + ex.Message);
					}
				}
			}
		}

        private void btnYemekResmiEkle_Click(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
			openFileDialog.Title = "Resim Seç";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string resimYolu = openFileDialog.FileName;

				// Resmi PictureBox'a yükleme
				pboxYemekResmi.Image = Image.FromFile(resimYolu);

				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (FileStream fileStream = new FileStream(resimYolu, FileMode.Open, FileAccess.Read))
					{
						fileStream.CopyTo(memoryStream);
					}
					resimBytes = memoryStream.ToArray();
				}
			}
		}

        private void btnYemekKaydet_Click(object sender, EventArgs e)
        {
            if (cboxKategori.SelectedIndex != -1)
            {
                kategori = new Kategori();
                if (!string.IsNullOrWhiteSpace(txtYemekAdi.Text) && !string.IsNullOrWhiteSpace(txtIcerik.Text) && nupdownKalori.Value != 0 && nupdownProtein.Value != 0 && nupdownKarbonhidrat.Value != 0 && nupdownYag.Value != 0)
                {
                    Yiyecek yiyecek = new Yiyecek();
                    yiyecek.YiyecekAd = txtYemekAdi.Text;
                    yiyecek.KategoriID = (int)cboxKategori.SelectedValue;
                    yiyecek.CreationDate = DateTime.Now;
                    bool yemekEklendiMi = yiyecekBLL.Ekle(yiyecek);

                    if (yemekEklendiMi)
                    {
                        yiyecekDetay = new YiyecekDetay();
                        yiyecekDetay.Icerik = txtIcerik.Text;
                        yiyecekDetay.Kalori100gr = (double)nupdownKalori.Value;
                        yiyecekDetay.Protein100gr = (double)nupdownProtein.Value;
                        yiyecekDetay.Karbonhidrat100gr = (double)nupdownKarbonhidrat.Value;
                        yiyecekDetay.Yag100gr = (double)nupdownYag.Value;
						yiyecekDetay.ResimYolu = resimBytes;
						yiyecekDetay.YiyecekID = yiyecekBLL.YemekIdDön(yiyecek);
                        bool yiyecekDetayEklendiMi = yiyecekDetayBLL.Ekle(yiyecekDetay);
                        if (yiyecekDetayEklendiMi)
                        {
                            MessageBox.Show("Yemeğiniz Başarıyla Eklenmiştir.Afiyet Olsun.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Yemeğiniz Eklenirken Beklenmeyen Bir Hata Meydana Gelmiştir. Özür Dileriz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
