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
    public class TuketimGecmisiBLL : ICRUD<TuketimGecmisi>
    {
        public TuketimGecmisiBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(TuketimGecmisi tuketimGecmisi)
        {
            dbContext.TuketimGecmisleri.Add(tuketimGecmisi);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(TuketimGecmisi entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }
    }
}
