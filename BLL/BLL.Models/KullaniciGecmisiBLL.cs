using BLL.Interfaces;
using DAL.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class KullaniciGecmisiBLL : ICRUD<KullaniciGecmisi>
    {
        public KullaniciGecmisiBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;

        public bool Ekle(KullaniciGecmisi kullaniciGecmisi)
        {
            dbContext.KullaniciGecmisleri.Add(kullaniciGecmisi);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(KullaniciGecmisi kullaniciGecmisi)
        {
            dbContext.KullaniciGecmisleri.Update(kullaniciGecmisi);
            return dbContext.SaveChanges() > 0;
        }

        public bool Sil(int id)
        {
            dbContext.Kullanicilar.Find(id);
            return dbContext.SaveChanges() > 0;
        }
    }
}
