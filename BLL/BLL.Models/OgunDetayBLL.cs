using BLL.Interfaces;
using DAL.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class OgunDetayBLL : ICRUD<OgunDetay>
    {
        public OgunDetayBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(OgunDetay ogunDetay)
        {
            dbContext.OgunDetaylari.Add(ogunDetay);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(OgunDetay entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }
    }
}
