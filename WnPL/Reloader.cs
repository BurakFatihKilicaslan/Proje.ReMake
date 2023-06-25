using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPL.Forms;

namespace WinPL.Asssistant
{
    internal static class Reloader
    {
        public static void FormuYenidenYukle(int kullaniciID, MainForm main, Form frm)
        {
            AnaEkran anaEkran = new(kullaniciID, main);
            anaEkran.MdiParent = main;
            anaEkran.Dock = DockStyle.Fill;
            main.Width = anaEkran.Width + 20;
            main.Height = anaEkran.Height + 90;
            anaEkran.Show();
            frm.Close();
        }
    }
}
