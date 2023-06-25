using BLL.BLL.Models;
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
    public partial class KarsilamaForm : Form
    {
        public KarsilamaForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainForm = mainform;
        }

        MainForm mainForm;
        public int kullaniciID;

        private void btnGiris_Click(object sender, EventArgs e)
        {

            GirisForm girisForm = new GirisForm();
            this.Hide();
            mainForm.Hide();
            girisForm.ShowDialog();
            mainForm.Show();
            this.Show();



            if (girisForm.kullaniciID != 0)
            {
                this.kullaniciID = girisForm.kullaniciID;
                AnaEkran anaEkran = new AnaEkran(kullaniciID, mainForm);
                anaEkran.MdiParent = mainForm;
                anaEkran.Dock = DockStyle.Fill;
                this.Width = anaEkran.Width + 20;
                this.Height = anaEkran.Height + 90;
                anaEkran.Show();
                this.Close();
            }
            else
            {
                mainForm.Show();
                this.Show();
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KaydolForm kaydol = new KaydolForm();
            this.Hide();
            mainForm.Hide();
            kaydol.ShowDialog();
            mainForm.Show();
            this.Show();
        }

        private void pboxWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hedefinize Ulaşmak İçin İdeal Yol Arkadaşınız: Kalori Takip Uygulamamız!\r\nSiz de sağlıklı bir yaşam tarzı benimsemek, ideal kilonuzu korumak veya kilo vermek için çaba sarf ediyor musunuz? Artık bu süreci daha kolay, eğlenceli ve etkili hale getirecek bir yol arkadaşıyla tanışmanın zamanı geldi! Kalori Takip Uygulamamız, sizi hedeflerinize ulaşmanız için güçlü bir araçla donatıyor.\r\nKalori Takip Uygulamamız, beslenme alışkanlıklarınızı daha iyi anlamanıza, yediğiniz yiyeceklerin kalori değerlerini takip etmenize ve sağlıklı bir beslenme planı oluşturmanıza yardımcı olur. Uygulama kullanıcı dostu arayüzü ve kapsamlı özellikleriyle size mükemmel bir deneyim sunar.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
