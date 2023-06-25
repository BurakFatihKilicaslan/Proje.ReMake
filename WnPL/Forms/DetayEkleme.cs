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
using WinPL.Helpers;

namespace WinPL.Forms
{
	public partial class DetayEkleme : Form
	{
		public DetayEkleme(int ID)
		{
			InitializeComponent();
			this.id = ID;
			yiyecekBLL = new YiyecekBLL();
			yiyecek = new Yiyecek();
			yiyecekDetayBLL = new YiyecekDetayBLL();
		}
		int id;
		byte[]? resimBytes;
		YiyecekBLL yiyecekBLL;
		Yiyecek yiyecek;
		YiyecekDetayBLL yiyecekDetayBLL;
		YiyecekDetay yiyecekDetay;
		List<YiyecekDetay> yiyecekler;
		private void DetayEkleme_Load(object sender, EventArgs e)
		{
			yiyecekler = new List<YiyecekDetay>();
			yiyecek = yiyecekBLL.IdGetir(id);
			txtYemekAdı.Text = yiyecek.YiyecekAd;

			//if (yiyecekDetay.ResimYolu != null)
			//{
			//	byte[]? resimYolu = yiyecekDetay.ResimYolu;
			//	using (MemoryStream memoryStream = new MemoryStream(resimYolu))
			//	{
			//		memoryStream.Seek(0, SeekOrigin.Begin); // MemoryStream'i başlangıç konumuna getirdik

			//		try
			//		{
			//			Image resim = Image.FromStream(memoryStream);
			//			pboxDetayEkleme.Image = resim;
			//		}
			//		catch (ArgumentException ex)
			//		{
			//			// Geçersiz resim dosyası hatası
			//			Console.WriteLine("Hata: Geçersiz resim dosyası. " + ex.Message);
			//		}
			//	}
			//}
		}
		private void btnResimEkle_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
			openFileDialog.Title = "Resim Seç";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string resimYolu = openFileDialog.FileName;

				// Resmi PictureBox'a yükleme
				pboxDetayEkleme.Image = Image.FromFile(resimYolu);

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
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			yiyecekDetay = new YiyecekDetay();
			if (!string.IsNullOrWhiteSpace(txtIcerik.Text) && nupdownKalori.Value > 0 && nupdownKarbonhidrat.Value >= 0 && nupdownProtein.Value >= 0 && nupdownYag.Value >= 0)
			{
				yiyecekDetay.Icerik = txtIcerik.Text;
				yiyecekDetay.Kalori100gr = (double)nupdownKalori.Value;
				yiyecekDetay.Protein100gr = (double)nupdownProtein.Value;
				yiyecekDetay.Karbonhidrat100gr = (double)nupdownKarbonhidrat.Value;
				yiyecekDetay.Yag100gr = (double)nupdownYag.Value;
				yiyecekDetay.YiyecekID = id;
				yiyecekDetay.ResimYolu = resimBytes;
				bool eklendiMi = yiyecekDetayBLL.Ekle(yiyecekDetay);
				if (eklendiMi)
				{
					MessageBox.Show("Detay Ekleme İşleminiz Başarıyla Gerçekleştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Detay Ekleme İşleminiz Sırasında Bir Hata Meydana Gelmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
		}
	}
}
