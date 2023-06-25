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
	public partial class BilgiGuncelleme : Form
	{
		public BilgiGuncelleme(int kullaniciID)
		{
			InitializeComponent();
			kullaniciBLL = new KullaniciBLL();
			this.kullaniciID = kullaniciID;
			aktiviteSeviyesiBLL = new AktiviteSeviyesiBLL();
		}

		int kullaniciID;
		byte[]? resimBytes;
		KullaniciBLL kullaniciBLL;
		Kullanici kullanici;
		KullaniciGecmisi kullaniciGecmisi;
		KullaniciGecmisiBLL kullaniciGecmisiBLL;
		AktiviteSeviyesiBLL aktiviteSeviyesiBLL;

		private void BilgiGuncelleme_Load(object sender, EventArgs e)
		{
			kullanici = new Kullanici();
			kullanici = kullaniciBLL.IDGoreGetir(kullaniciID);
			//pboxProfilFotografi.Image = Image.FromFile(kullanici.ResimYolu);
			txtKilo.Text = kullanici.Kilo.ToString();
			txtBoy.Text = kullanici.Boy.ToString();
			cboxAktiviteSeviyesi.DisplayMember = "SeviyeBilgisi";
			cboxAktiviteSeviyesi.ValueMember = "ID";
			cboxAktiviteSeviyesi.DataSource = aktiviteSeviyesiBLL.DegerleriListele();
			byte[]? resimYolu = kullanici.ResimYolu; // resimYolu byte[]? tipinde

			if (resimYolu != null)
			{
				using (MemoryStream memoryStream = new MemoryStream(resimYolu))
				{
					memoryStream.Seek(0, SeekOrigin.Begin); // MemoryStream'i başlangıç konumuna getirdik

					try
					{
						Image resim = Image.FromStream(memoryStream);
						pboxProfilFotografi.Image = resim;
					}
					catch (ArgumentException ex)
					{
						// Geçersiz resim dosyası hatası
						Console.WriteLine("Hata: Geçersiz resim dosyası. " + ex.Message);
					}
				}
			}
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
				pboxProfilFotografi.Image = Image.FromFile(resimYolu);

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

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (kullanici is not null)
			{
				kullaniciGecmisi = new KullaniciGecmisi();
				kullaniciGecmisiBLL = new KullaniciGecmisiBLL();

				//Proje Gelistirilmek Istendiginde Ayri Bir Depolama Alanı Olusturularak Kullanıcı Silinmek Istense dahi Bilgileri Saklanacak!!

				//VeriDepolama(kullaniciGecmisi, kullanici);
				//if (kullaniciGecmisiBLL.Ekle(kullaniciGecmisi))
				//{
				//    MessageBox.Show("Eski Verileriniz Başarıyla Depolanmıştır");   //Testten Sonra Silinecek!!
				//}
				double kilo = Convert.ToDouble(txtKilo.Text);
				double boy = Convert.ToDouble(txtBoy.Text);
				kullanici.ResimYolu = resimBytes;
				if (kilo > 0 && boy >= 50)
				{
					kullanici.Kilo = Convert.ToDouble(txtKilo.Text);
					kullanici.Boy = Convert.ToDouble(txtBoy.Text);
					if (kullaniciBLL.Guncelle(kullanici))
					{
						MessageBox.Show("Bilgileriniz Başarılı Bir Şekilde Güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show("Güncelleme Sırasında Bir Hata Meydana GElmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Bilgilerinizi Kabul Edilebilecek Seviyelerde(Kilo > 30 || Boy > 50) Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Helper.FormuTemizle(this.Controls);
				}
			}
		}
		public void VeriDepolama(KullaniciGecmisi kullaniciGecmisi, Kullanici kullanici)
		{
			kullaniciGecmisi = new KullaniciGecmisi();
			kullaniciGecmisi.KullaniciID = kullanici.ID;
			kullaniciGecmisi.Ad = kullanici.Ad;
			kullaniciGecmisi.Soyad = kullanici.Soyad;
			kullaniciGecmisi.Sifre = kullanici.Sifre;
			kullaniciGecmisi.ResimYolu = kullanici.ResimYolu;
			kullaniciGecmisi.KullaniciAdi = kullanici.KullaniciAdi;
			kullaniciGecmisi.KisininAktiviteGecmisi = kullaniciBLL.BilgiVer(kullanici.ID);
			kullaniciGecmisi.Cinsiyet = kullanici.Cinsiyet;
			kullaniciGecmisi.DogumTarihi = kullanici.DogumTarihi;
			kullaniciGecmisi.KaloriIhtiyacı = kullanici.KaloriIhtiyacı;
			kullaniciGecmisi.Boy = kullanici.Boy;
			kullaniciGecmisi.Kilo = kullanici.Kilo;
		}
	}
}
