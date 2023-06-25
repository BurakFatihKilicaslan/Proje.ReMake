using Entities.Abstracts;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Kullanici : Kisi
    {
        public Kullanici()
        {
            KullaniciOgunleri = new List<KullaniciOgun>();
            GunlukRaporlar = new List<GunlukRapor>();
            KullaniciGecmisleri = new List<KullaniciGecmisi>();
            TuketimGecmisleri = new List<TuketimGecmisi>();
        }
        public Statu Statu { get; set; }
        public int AktiviteSeviyesiID { get; set; }
        public AktiviteSeviyesi AktiviteSeviyesi { get; set; }
        public ICollection<KullaniciGecmisi> KullaniciGecmisleri { get; set; }
        public ICollection<KullaniciOgun> KullaniciOgunleri { get; set; }
        public ICollection<GunlukRapor> GunlukRaporlar { get; set; }
        public ICollection<TuketimGecmisi> TuketimGecmisleri { get; set; }
    }
}
