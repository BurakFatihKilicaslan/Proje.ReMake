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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
            kullaniciBLL = new KullaniciBLL();
        }
        KullaniciBLL kullaniciBLL;
        Kullanici kullanici;
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            kullanici = new Kullanici();
            kullanici = kullaniciBLL.IsmeGoreGetir(txtKullaniciAdi.Text);
            if (kullanici is not null)
            {
                if (txtAd.Text == kullanici.Ad && txtSoyad.Text == kullanici.Soyad && txtKullaniciAdi.Text == kullanici.KullaniciAdi)
                {
                    if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                    {
                        kullanici.Sifre = kullaniciBLL.ComputeSha256Hash(txtYeniSifre.Text);
                        if (kullaniciBLL.Guncelle(kullanici))
                        {
                            MessageBox.Show("Şifreniz Başarıyla Güncellenmştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Beklenmedik Bir Hata Oluştu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Helper.FormuTemizle(this.Controls);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girmiş Olduğunuz Şifreler Uyuşmamaktadır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.FormuTemizle(this.Controls);
                    }
                }
                else
                {
                    MessageBox.Show("Girmiş Olduğunuz Bilgiler Uyuşmamaktadır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Helper.FormuTemizle(this.Controls);
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunmamaktadır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helper.FormuTemizle(this.Controls);
            }
        }
    }
}
