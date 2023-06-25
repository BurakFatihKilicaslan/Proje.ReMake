using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TuketimGecmisi : Tablo
    {
        public int OgunID { get; set; }
        public int KategoriID { get; set; }
        public int YiyecekID { get; set; }
        public int BesinDegeriID { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
