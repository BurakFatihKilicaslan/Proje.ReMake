using BLL.BLL.Models;
using Entities.Abstracts;
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
using WinPL.Forms;

namespace WnPL.Forms
{
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
            kullaniciBLL = new KullaniciBLL();
            aktiviteSeviyesiBLL = new AktiviteSeviyesiBLL();
        }
        KullaniciBLL kullaniciBLL;
        AktiviteSeviyesiBLL aktiviteSeviyesiBLL;

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnMusteriDetay_Click(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItems.Count > 0)
            {
                this.Hide();
                Kisi kisi = (Kisi)lstMusteriler.FocusedItem.Tag;
                if (kisi.ID != null)
                {
                    ProfilBilgileri profilBilgileri = new ProfilBilgileri(kisi.ID);
                    profilBilgileri.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Kişi Seçtiğinizden Emin Olunuz", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnYemekYonetimi_Click(object sender, EventArgs e)
        {
            YemekEkleme yemekEkleme = new YemekEkleme();
            yemekEkleme.ShowDialog();
        }

        private void Listele()
        {
            lstMusteriler.Items.Clear();
            kullaniciBLL = new KullaniciBLL();
            List<Kullanici> kullanicilar = kullaniciBLL.KullanicilariGetir();
            foreach (Kullanici kullanici in kullanicilar)
            {
                ListViewItem lvi = new();

                lvi.Text = kullanici.Ad;
                lvi.SubItems.Add(kullanici.Soyad);
                lvi.SubItems.Add(kullanici.KullaniciAdi);
                lvi.SubItems.Add(aktiviteSeviyesiBLL.SeviyeAdiDon(kullanici.AktiviteSeviyesiID));
                lvi.Tag = kullanici;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                lstMusteriler.Items.Add(lvi);
            }
        }

    }
}
