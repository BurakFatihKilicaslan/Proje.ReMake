using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class BesinDegeri : Tablo
    {
        public double PorsiyonGramaji { get; set; }
        public double Kalori { get; set; }
        public double Protein { get; set; }
        public double Karbonhidrat { get; set; }
        public double Yag { get; set; }
        public int YiyecekOgunID { get; set; }
        public YiyecekOgun YiyecekOgun { get; set;}
    }
}
