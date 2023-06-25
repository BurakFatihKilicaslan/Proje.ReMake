using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Ogun : Tablo
    {
        public Ogun()
        {
            OgunDetaylari = new List<OgunDetay>();
            YiyecekOgunleri = new List<YiyecekOgun>();
            KullaniciOgunleri = new List<KullaniciOgun>();
        }

        public string OgunAd { get; set; }
        public ICollection<OgunDetay> OgunDetaylari { get; set; }
        public ICollection<KullaniciOgun> KullaniciOgunleri { get; set; }
        
        public ICollection<YiyecekOgun> YiyecekOgunleri { get; set; }
    }
}
