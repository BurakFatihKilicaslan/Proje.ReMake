using BLL.BLL.Models;
using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPL.Helpers;

namespace WinPL.Forms
{
    public partial class KaydolForm : Form
    {
        public KaydolForm()
        {
            InitializeComponent();
            kullaniciBll = new KullaniciBLL();
            aktiviteSeviyesiBLL = new AktiviteSeviyesiBLL();
        }
        KullaniciBLL kullaniciBll;
        Kullanici kullanici;
		byte[] resimBytes;                                               //Resim yolu icin
		AktiviteSeviyesiBLL aktiviteSeviyesiBLL;

        private void KaydolForm_Load(object sender, EventArgs e)
        {
            cboxAktiviteSeviyesi.DisplayMember = "SeviyeBilgisi";
            cboxAktiviteSeviyesi.ValueMember = "ID";
            cboxAktiviteSeviyesi.DataSource = aktiviteSeviyesiBLL.DegerleriListele();
            cboxAktiviteSeviyesi.SelectedIndex = 0;

            rbErkek.Checked = true;
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

		private void btnSingInKayıtOl_Click(object sender, EventArgs e)
        {
            if (BilgiKontrol())
            {
				kullanici = new Kullanici();
				kullanici.Ad = txtAd.Text;
				kullanici.Soyad = txtSoyad.Text;
				kullanici.Cinsiyet = rbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadin;
				kullanici.DogumTarihi = dtpDogumTarihi.Value;
				kullanici.Boy = (double)nupdownBoy.Value;
				kullanici.Kilo = (double)nupdownKilo.Value;
				kullanici.AktiviteSeviyesiID = (int)cboxAktiviteSeviyesi.SelectedValue;
				kullanici.KullaniciAdi = txtKullaniciAdi.Text;
				kullanici.Statu = Entities.Enums.Statu.Musteri;
				kullanici.Sifre = kullaniciBll.ComputeSha256Hash(txtSifre.Text);
				kullanici.ResimYolu = resimBytes;
				kullanici.Statu = Entities.Enums.Statu.Musteri;
				if (rbErkek.Checked)
                {
                    kullanici.KaloriIhtiyacı = (10 * kullanici.Kilo + 6.25 * kullanici.Boy - 5 * (DateTime.Now.Year - kullanici.DogumTarihi.Year) + 5) * aktiviteSeviyesiBLL.DegerDondur((int)cboxAktiviteSeviyesi.SelectedValue);
                }
                else
                {
                    kullanici.KaloriIhtiyacı = (10 * kullanici.Kilo + 6.25 * kullanici.Boy - 5 * (DateTime.Now.Year - kullanici.DogumTarihi.Year) - 161) * aktiviteSeviyesiBLL.DegerDondur((int)cboxAktiviteSeviyesi.SelectedValue);
                }
                bool eklendiMi = kullaniciBll.Ekle(kullanici);
                if (eklendiMi)
                {
                    MessageBox.Show("Kaydınız Gerçekleştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sistemde Hata Meydana Gelmiştir. Sonra Tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Helper.FormuTemizle(this.Controls);
                }
            }
        }
		public bool SifreDogrulama(string password)
        {
            int minLength = 8; int minUpperCase = 2; int minLowerCase = 3; int minSpecialChars = 2;
            if (password.Length < minLength) { return false; }
            if (password.Count(char.IsUpper) < minUpperCase) { return false; }
            if (password.Count(char.IsLower) < minLowerCase) { return false; }
            if (password.Count(c => "!:+*".Contains(c)) < minSpecialChars) { return false; }
            return true;
        }

        public bool BilgiKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text) || nupdownBoy.Value == 0 || nupdownKilo.Value == 0)
            {
                MessageBox.Show("Gerekli Bilgileri Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (DateTime.Now.Year - dtpDogumTarihi.Value.Year < 13)
            {
                MessageBox.Show("13 Yaşından Büyük Olmalısınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtAd.Text.Length > 50)
            {
                MessageBox.Show("Adınız En Fazla 50 Karakter İçerebilir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSoyad.Text.Length > 20)
            {
                MessageBox.Show("Soyadınız En Fazla 20 Karakter İçerebilir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nupdownBoy.Value < 50)
            {
                MessageBox.Show("Boy Değerini Kabul Edilebilir Bir Değer Olarak Giriniz(cm Cinsinden)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nupdownKilo.Value < 30)
            {
                MessageBox.Show("Kilo Değerini Kabul Edilebilir Bir Değer Olarak Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string eposta = txtKullaniciAdi.Text;
            string model = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(eposta, model) && !eposta.EndsWith(".com"))
            {
                MessageBox.Show("Kullanıcı Adınızı Doğru Formatta Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor");
                return false;
            }
            else if (!SifreDogrulama(txtSifre.Text))
            {
                MessageBox.Show("Şifreler uygun kriterlere sahip değil\n---Kriterler---\n•En az 8 karakter uzunluğunda olmalıdır.\n• En az 2 büyük harf içermelidir.\n• En az 3 küçük harf içermelidir.\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (kullaniciBll.IsmeGoreGetir(txtKullaniciAdi.Text) is not null)
                {
                    MessageBox.Show("Bu İsimde Kullanıcı Mevcuttur", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
