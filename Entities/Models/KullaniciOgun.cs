using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class KullaniciOgun : Tablo
    {
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int OgunID { get; set; }
        public Ogun Ogun { get; set; }
    }
}
