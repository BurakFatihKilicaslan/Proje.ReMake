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
    public class GunlukRaporBLL : ICRUD<GunlukRapor>
    {
        public GunlukRaporBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(GunlukRapor gunlukRapor)
        {
            dbContext.GunlukRaporlar.Add(gunlukRapor);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(GunlukRapor entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }
    }
}
