using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AktiviteSeviyesi : Tablo
    {
        public string SeviyeBilgisi { get; set; }
        public double SeviyeDegeri { get; set; }
        public ICollection<Kullanici> Kullanicilar { get; set; }
    }
}
