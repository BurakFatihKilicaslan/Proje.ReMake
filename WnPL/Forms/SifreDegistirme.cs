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
    public partial class SifreDegistirmeForm : Form
    {
        public SifreDegistirmeForm(int ID)
        {
            InitializeComponent();
            kullaniciBLL = new KullaniciBLL();
            this.kullaniciID = ID;
        }
        KullaniciBLL kullaniciBLL;
        Kullanici kullanici;
        int kullaniciID;
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            kullanici = new Kullanici();
            kullanici = kullaniciBLL.IDGoreGetir(kullaniciID);
            if (kullanici.Sifre == kullaniciBLL.ComputeSha256Hash(txtYeniSifre.Text))
            {
                MessageBox.Show("Son Girilen Şifreniz, Yeni Belirlemek İstediğiniz Şifre İle Aynı Olamaz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
        }
    }
}
