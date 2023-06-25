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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            KarsilamaForm karsilamaForm = new KarsilamaForm(this);
            karsilamaForm.MdiParent = this;
            karsilamaForm.Dock = DockStyle.Fill;
            this.Width = karsilamaForm.Width + 20;
            this.Height = karsilamaForm.Height + 90;
            karsilamaForm.Show();
        }
    }
}
