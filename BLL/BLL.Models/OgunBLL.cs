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
    public class OgunBLL : ICRUD<Ogun>
    {
        public OgunBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(Ogun ogun)
        {
            dbContext.Ogunler.Add(ogun);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(Ogun entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }
        public List<Ogun> Listele()
        {
            return dbContext.Ogunler.ToList();
        }


    }
}
