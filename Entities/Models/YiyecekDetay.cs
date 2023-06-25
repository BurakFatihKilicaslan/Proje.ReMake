using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class YiyecekDetay : Tablo
    {
        public string Icerik { get; set; }
        public byte[]? ResimYolu { get; set; }
        public double Kalori100gr { get; set; }
        public double Protein100gr { get; set; }
        public double Karbonhidrat100gr { get; set; }
        public double Yag100gr { get; set; }
        public int YiyecekID { get; set; }
        public Yiyecek Yiyecek { get; set; }
        public ICollection<BesinDegeri>? BesinDegerleri { get; set; }
    }
}
