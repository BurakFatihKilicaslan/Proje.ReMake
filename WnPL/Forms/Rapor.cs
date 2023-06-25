using BLL.BLL.Models;
using DAL.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
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
    public partial class RaporForm : Form
    {
        public RaporForm(int kullaniciID, MainForm mainForm)
        {
            InitializeComponent();
            kullaniciBLL = new KullaniciBLL();
            kullaniciOgunBLL = new KullaniciOgunBLL();
            this.mainForm = mainForm;
            this.kullaniciID = kullaniciID;
            tuketimGecmisiBLL = new();
            dbContext = new HubDbContext();
        }

        KullaniciOgunBLL kullaniciOgunBLL;
        TuketimGecmisiBLL tuketimGecmisiBLL;
        KullaniciBLL kullaniciBLL;
        MainForm mainForm;
        int kullaniciID;
        HubDbContext dbContext;
        double kaloriSabah = 0;
        double kaloriOgle = 0;
        double kaloriAksam = 0;
        double kaloriAra = 0;
        ListViewItem lvi;

        private void RaporForm_Load(object sender, EventArgs e)
        {
            listView2.Hide();
            listView3.Hide();
            listView4.Hide();
            btnRaporAylik.Enabled = false;
            btnRaporKiyas.Enabled = false;
            btnRaporYemekCesidi.Enabled = false;
            btnRaporRastgeleGun.Enabled = false;
            btnRaporEnCokYenenYemek.Enabled = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran(kullaniciID, mainForm);
            anaEkran.MdiParent = mainForm;
            anaEkran.Dock = DockStyle.Fill;
            this.Width = anaEkran.Width + 20;
            this.Height = anaEkran.Height + 90;
            anaEkran.Show();
            this.Close();
        }


        private void btnRaporGunluk_Click(object sender, EventArgs e)
        {
            #region : Gunluk Veri Sorguları
            lvi = new();
            for (int i = 1; i <= 4; i++)
            {

                var kolon1 = dbContext.BesinDegerleri.Include(b => b.YiyecekOgun).ThenInclude(b => b.Ogun).ThenInclude(o => o.KullaniciOgunleri).ThenInclude(kolon1 => kolon1.Kullanici).Where(b => b.YiyecekOgun.OgunID == i && b.YiyecekOgun.CreationDate.Day == DateTime.Now.Day && b.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID)).ToList();

                ListViewItem lvi = new();
                foreach (var item in kolon1)
                {
                    if (item.YiyecekOgun.OgunID == 1)
                    {
                        kaloriSabah = 0;
                        kaloriSabah += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 2)
                    {
                        kaloriOgle = 0;
                        kaloriOgle += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 3)
                    {
                        kaloriAksam = 0;
                        kaloriAksam += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 4)
                    {
                        kaloriAra = 0;
                        kaloriAra += item.Kalori;
                    }
                }
            }
            lvi.Text = kullaniciID.ToString();
            lvi.SubItems.Add(kaloriSabah.ToString());
            lvi.SubItems.Add(kaloriOgle.ToString());
            lvi.SubItems.Add(kaloriAksam.ToString());
            lvi.SubItems.Add(kaloriAra.ToString());
            lvi.SubItems.Add((kaloriAksam + kaloriAra + kaloriSabah + kaloriOgle).ToString());
            listView1.Items.Add(lvi);
            #endregion
            btnRaporAylik.Enabled = true;
            btnRaporGunluk.Enabled = false;

        }

        private void btnRaporAylik_Click(object sender, EventArgs e)
        {
            lvi.SubItems.Clear();
            #region : Aylik Veri Sorguları
            lvi = new();
            for (int i = 1; i <= 4; i++)
            {

                var kolon1 = dbContext.BesinDegerleri.Include(b => b.YiyecekOgun).ThenInclude(b => b.Ogun).ThenInclude(o => o.KullaniciOgunleri).ThenInclude(kolon1 => kolon1.Kullanici).Where(b => b.YiyecekOgun.OgunID == i && b.YiyecekOgun.CreationDate.Month == DateTime.Now.Month && b.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID)).ToList();

                ListViewItem lvi = new();
                foreach (var item in kolon1)
                {
                    if (item.YiyecekOgun.OgunID == 1)
                    {
                        kaloriSabah = 0;
                        kaloriSabah += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 2)
                    {
                        kaloriOgle = 0;
                        kaloriOgle += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 3)
                    {
                        kaloriAksam = 0;
                        kaloriAksam += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 4)
                    {
                        kaloriAra = 0;
                        kaloriAra += item.Kalori;
                    }
                }
            }
            lvi.Text = kullaniciID.ToString();
            lvi.SubItems.Add(kaloriSabah.ToString());
            lvi.SubItems.Add(kaloriOgle.ToString());
            lvi.SubItems.Add(kaloriAksam.ToString());
            lvi.SubItems.Add(kaloriAra.ToString());
            lvi.SubItems.Add((kaloriAksam + kaloriAra + kaloriSabah + kaloriOgle).ToString());
            listView1.Items.Add(lvi);
            #endregion
            btnRaporKiyas.Enabled = true;
            btnRaporAylik.Enabled = false;
        }

        private void btnRaporKiyas_Click(object sender, EventArgs e)
        {
            listView1.Hide();
            listView2.Show();
            #region MyRegion : Kıyas Sorguları
            // DbContext'teki BesinDegerleri tablosundaki verileri yiyecek öğünleri, öğünler ve kullanıcılarla birlikte getirdik
            // Şu anki yıl ve aydaki verileri filtrelidik.

            var besinDegerleri = dbContext.BesinDegerleri.Include(b => b.YiyecekOgun).ThenInclude(b => b.Ogun).ThenInclude(o => o.KullaniciOgunleri).ThenInclude(k => k.Kullanici).Where(b => b.YiyecekOgun.CreationDate.Year == DateTime.Now.Year && b.YiyecekOgun.CreationDate.Month == DateTime.Now.Month).ToList();

            // Öğün ID'si ve öğün adıyla grupladığımız verileri seçiyoruz.
            // Toplam kaloriyi hesaplıyoruz.
            // Haftalık toplam kaloriyi son 7 gündeki verilerden hesaplıyoruz.
            // Aylık toplam kaloriyi son 1 aydaki verilerden hesaplıyoruz.
            // Kategoriyi verileri kategorilere ayırmak istiyorsanız bu kısmı düzenleyebiliriz

            DateTime now = DateTime.Now;
            DateTime aWeekAgo = now.AddDays(-7);
            DateTime aMonthAgo = now.AddMonths(-1);

            var haftalikToplamKalori = besinDegerleri
                .Where(b => b.YiyecekOgun.CreationDate >= aWeekAgo && b.YiyecekOgun.CreationDate <= now)
                .Sum(b => b.Kalori);

            var aylikToplamKalori = besinDegerleri
                .Where(b => b.YiyecekOgun.CreationDate >= aMonthAgo && b.YiyecekOgun.CreationDate <= now)
                .Sum(b => b.Kalori);

            var toplamKalori = besinDegerleri.Sum(b => b.Kalori);

            ListViewItem lvi = new ListViewItem("Haftalık Toplam Kalori");
            lvi.SubItems.Add(haftalikToplamKalori.ToString());
            listView2.Items.Add(lvi);

            lvi = new ListViewItem("Aylık Toplam Kalori");
            lvi.SubItems.Add(aylikToplamKalori.ToString());
            listView2.Items.Add(lvi);

            lvi = new ListViewItem("Toplam Kalori");
            lvi.SubItems.Add(toplamKalori.ToString());
            listView2.Items.Add(lvi);
            #endregion
            btnRaporKiyas.Enabled = false;
            btnRaporYemekCesidi.Enabled = true;
        }

        private void btnRaporYemekCesidi_Click(object sender, EventArgs e)
        {
            listView3.Hide();
            listView2.Hide();
            listView1.Hide();
            listView4.Show();
            DateTime now = DateTime.Now;
            DateTime aWeekAgo = now.AddDays(-7);
            DateTime aMonthAgo = now.AddMonths(-1);
            // Group the food values by meal and food name
            var rapor = dbContext.BesinDegerleri.GroupBy(b => new { b.YiyecekOgun.OgunID, b.YiyecekOgun.Ogun.OgunAd, b.ID, b.YiyecekOgun.Yiyecek.YiyecekAd })
                .Select(g => new
                {
                    YiyecekAdi = g.Key.YiyecekAd,
                    ToplamKalori = g.Sum(b => b.Kalori),
                    HaftalikToplamKalori = g.Where(b => b.YiyecekOgun.CreationDate >= aWeekAgo && b.YiyecekOgun.CreationDate <= now).Sum(b => b.Kalori),
                    AylikToplamKalori = g.Where(b => b.YiyecekOgun.CreationDate >= aMonthAgo && b.YiyecekOgun.CreationDate <= now).Sum(b => b.Kalori),
                }).ToList();

            // Clear the existing items in the listview
            listView1.Items.Clear();

            // Add the column headers
            listView1.Columns.Add("Yiyecek Adı");
            listView1.Columns.Add("Toplam Kalori");
            listView1.Columns.Add("Haftalık Toplam Kalori");
            listView1.Columns.Add("Aylık Toplam Kalori");

            // Add the items to the listview
            foreach (var item in rapor)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.YiyecekAdi;
                lvi.SubItems.Add(item.ToplamKalori.ToString());
                lvi.SubItems.Add(item.HaftalikToplamKalori.ToString());
                lvi.SubItems.Add(item.AylikToplamKalori.ToString());
                listView4.Items.Add(lvi);
            }
            btnRaporYemekCesidi.Enabled = false;
            btnRaporEnCokYenenYemek.Enabled = true;
        }

        private void btnRaporEnCokYenenYemek_Click(object sender, EventArgs e)
        {
            var mostFrequentYiyecek = dbContext.BesinDegerleri.Include(b => b.YiyecekOgun).ThenInclude(yo => yo.Yiyecek)
    .Where(b => b.YiyecekOgun.CreationDate.Year == DateTime.Now.Year && b.YiyecekOgun.CreationDate.Month == DateTime.Now.Month).GroupBy(b => b.YiyecekOgun.Yiyecek.YiyecekAd).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();

            MessageBox.Show(mostFrequentYiyecek, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRaporEnCokYenenYemek.Enabled = false;
            btnRaporRastgeleGun.Enabled = true;
        }

        private void btnRaporRastgeleGun_Click(object sender, EventArgs e)
        {
            listView4.Hide();
            listView3.Hide();
            listView2.Hide();
            listView1.Show();
            listView1.Items.Clear();
            lvi = new();
            for (int i = 1; i <= 4; i++)
            {

                var kolon1 = dbContext.BesinDegerleri.Include(b => b.YiyecekOgun).ThenInclude(b => b.Ogun).ThenInclude(o => o.KullaniciOgunleri).ThenInclude(kolon1 => kolon1.Kullanici).Where(b => b.YiyecekOgun.OgunID == i && b.YiyecekOgun.CreationDate.Day == dateTimePicker.Value.Day && b.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID)).ToList();

                ListViewItem lvi = new();
                foreach (var item in kolon1)
                {
                    if (item.YiyecekOgun.OgunID == 1)
                    {
                        kaloriSabah = 0;
                        kaloriSabah += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 2)
                    {
                        kaloriOgle = 0;
                        kaloriOgle += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 3)
                    {
                        kaloriAksam = 0;
                        kaloriAksam += item.Kalori;
                    }
                    else if (item.YiyecekOgun.OgunID == 4)
                    {
                        kaloriAra = 0;
                        kaloriAra += item.Kalori;
                    }
                }
            }
            lvi.Text = kullaniciID.ToString();
            lvi.SubItems.Add(kaloriSabah.ToString());
            lvi.SubItems.Add(kaloriOgle.ToString());
            lvi.SubItems.Add(kaloriAksam.ToString());
            lvi.SubItems.Add(kaloriAra.ToString());
            lvi.SubItems.Add((kaloriAksam + kaloriAra + kaloriSabah + kaloriOgle).ToString());
            listView1.Items.Add(lvi);

            btnRaporEnCokYenenYemek.Enabled = false;
            btnRaporRastgeleGun.Enabled = true;
        }
    }
}
