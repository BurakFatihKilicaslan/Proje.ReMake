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
using WinPL.Asssistant;

namespace WinPL.Forms
{
    public partial class AnaEkran : Form
    {
        public AnaEkran(int kullaniciID, MainForm mainForm)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.mainForm = mainForm;
            tuketimGecmisiBLL = new();
            besinDegeriBLL = new BesinDegeriBLL();
            yiyecekOgunBLL = new YiyecekOgunBLL();
        }

        Kullanici kullanici;
        MainForm mainForm;
        KullaniciBLL kullaniciBLL;
        KullaniciOgunBLL kullaniciOgunBLL;
        TuketimGecmisiBLL tuketimGecmisiBLL;
        BesinDegeriBLL besinDegeriBLL;
        YiyecekOgunBLL yiyecekOgunBLL;
        int kullaniciID;

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            kullaniciOgunBLL = new KullaniciOgunBLL();
            kullaniciBLL = new KullaniciBLL();
            kullanici = kullaniciBLL.IDGoreGetir(kullaniciID);

            pBargeriyeKalanKalori.Value = AnlikToplamKaloriYuzde();
            pBargeriyeKalanKalori.Style = ProgressBarStyle.Continuous;

            DegerleriGoster();
            OguneYemekGetir();
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            OgunYonetimi ogunYonetimi = new OgunYonetimi(kullaniciID, mainForm);
            ogunYonetimi.ShowDialog();
            Reloader.FormuYenidenYukle(kullaniciID, mainForm, this);
        }

        private void profilimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilBilgileri profilBilgileri = new ProfilBilgileri(kullaniciID);
            profilBilgileri.ShowDialog();

        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistirmeForm sifreDegistirmeForm = new SifreDegistirmeForm(kullaniciID);
            sifreDegistirmeForm.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KarsilamaForm karsilamaForm = new KarsilamaForm(mainForm);
            karsilamaForm.MdiParent = mainForm;
            karsilamaForm.Dock = DockStyle.Fill;
            this.Width = karsilamaForm.Width + 20;
            this.Height = karsilamaForm.Height + 90;
            karsilamaForm.Show();
            this.Close();
        }
        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new(kullaniciID, mainForm);
            raporForm.MdiParent = mainForm;
            raporForm.Dock = DockStyle.Fill;
            this.Width = raporForm.Width + 20;
            this.Height = raporForm.Height + 90;
            raporForm.Show();
            this.Close();
        }

        private void DegerleriGoster()
        {
            lblSabahKalori.Text = Convert.ToString(besinDegeriBLL.GunlukKaloriGetir(0 , kullaniciID));
            lblSabahKarbonhidrat.Text = Convert.ToString(besinDegeriBLL.GunlukKarbonhidratGetir(0, kullaniciID));
            label18.Text = Convert.ToString(besinDegeriBLL.GunlukProteinGetir(0, kullaniciID));
            lblSabahYag.Text = Convert.ToString(besinDegeriBLL.GunlukYagGetir(0, kullaniciID));

            lblOgleKalori.Text = Convert.ToString(besinDegeriBLL.GunlukKaloriGetir(1, kullaniciID));
            lblOgleKarbonhidrat.Text = Convert.ToString(besinDegeriBLL.GunlukKarbonhidratGetir(1, kullaniciID));
            lblOgleProtein.Text = Convert.ToString(besinDegeriBLL.GunlukProteinGetir(1, kullaniciID));
            lblOgleYag.Text = Convert.ToString(besinDegeriBLL.GunlukYagGetir(1, kullaniciID));

            lblAksamKalori.Text = Convert.ToString(besinDegeriBLL.GunlukKaloriGetir(2, kullaniciID));
            lblAksamKarbonhidrat.Text = Convert.ToString(besinDegeriBLL.GunlukKarbonhidratGetir(2, kullaniciID));
            lblAksamProtein.Text = Convert.ToString(besinDegeriBLL.GunlukProteinGetir(2, kullaniciID));
            lblAksamYag.Text = Convert.ToString(besinDegeriBLL.GunlukYagGetir(2, kullaniciID));

            lblAraToplamKalori.Text = Convert.ToString(besinDegeriBLL.GunlukKaloriGetir(3, kullaniciID));
            lblAraToplamKarbonhidrat.Text = Convert.ToString(besinDegeriBLL.GunlukKarbonhidratGetir(3, kullaniciID));
            lblAraToplamProtein.Text = Convert.ToString(besinDegeriBLL.GunlukProteinGetir(3, kullaniciID));
            lblAraToplamYag.Text = Convert.ToString(besinDegeriBLL.GunlukYagGetir(3, kullaniciID));
        }

        private void OguneYemekGetir()
        {
            lboxSabah.DataSource = yiyecekOgunBLL.YiyecekAdiDondur(1, kullaniciID);
            lboxOgle.DataSource = yiyecekOgunBLL.YiyecekAdiDondur(2, kullaniciID);
            lboxAksam.DataSource = yiyecekOgunBLL.YiyecekAdiDondur(3, kullaniciID);
            lboxToplamAraOgunler.DataSource = yiyecekOgunBLL.YiyecekAdiDondur(4, kullaniciID);
        }

        private int AnlikToplamKaloriYuzde()
        {
            double ans = besinDegeriBLL.GunlukKaloriGetir(1, kullaniciID) + besinDegeriBLL.GunlukKaloriGetir(2, kullaniciID) + besinDegeriBLL.GunlukKaloriGetir(3, kullaniciID) + besinDegeriBLL.GunlukKaloriGetir(4, kullaniciID);
            double yuzde = ans * 100 / kullanici.KaloriIhtiyacı;
            return (int)yuzde;
        }


        //ALT TARAFI DENEME
        private void lblSabahKalori_Click(object sender, EventArgs e)
        {

        }

        private void lblSabahKarbonhidrat_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lblSabahYag_Click(object sender, EventArgs e)
        {

        }

        private void lblOgleKalori_Click(object sender, EventArgs e)
        {

        }

        private void lblOgleKarbonhidrat_Click(object sender, EventArgs e)
        {

        }

        private void lblOgleProtein_Click(object sender, EventArgs e)
        {

        }

        private void lblOgleYag_Click(object sender, EventArgs e)
        {

        }

        private void lblAksamKalori_Click(object sender, EventArgs e)
        {

        }

        private void lblAksamKarbonhidrat_Click(object sender, EventArgs e)
        {

        }

        private void lblAksamProtein_Click(object sender, EventArgs e)
        {

        }

        private void lblAksamYag_Click(object sender, EventArgs e)
        {

        }

        private void lblAraToplamKalori_Click(object sender, EventArgs e)
        {

        }

        private void lblAraToplamKarbonhidrat_Click(object sender, EventArgs e)
        {

        }

        private void lblAraToplamProtein_Click(object sender, EventArgs e)
        {

        }

        private void lblAraToplamYag_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void lboxSabah_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lboxOgle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lboxAksam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lboxToplamAraOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
