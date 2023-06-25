using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class GunlukRapor : Tablo
    {
        public double KaloriIhtiyaci { get; set; }
        public double TuketilenKalori { get; set; }
        public double Protein { get; set; }
        public double Karbonhidrat { get; set; }
        public double Yag { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
