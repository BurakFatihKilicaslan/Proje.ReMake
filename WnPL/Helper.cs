using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace WinPL.Helpers
{
    public static class Helper
    {
        public static void FormuTemizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is PictureBox)
                {
                    ((PictureBox)control).ImageLocation = string.Empty;
                }
                else if (control is RadioButton)
                {
                    if (((RadioButton)control).Text == "Erkek")
                    {
                        ((RadioButton)control).Checked = true;
                    }
                }
                else if (control is GroupBox)
                {
                    FormuTemizle(controls);
                }
            }
        }
    }
}
