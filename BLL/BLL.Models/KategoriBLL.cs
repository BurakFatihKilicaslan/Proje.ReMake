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
    public class KategoriBLL : ICRUD<Kategori>
    {
        public KategoriBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(Kategori kategori)
        {
            dbContext.Kategoriler.Add(kategori);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(Kategori entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }
        public List<Kategori> Listele()
        {
            return dbContext.Kategoriler.ToList();
        }

        //public int IDGetir()
        //{
        //   List<Kategori> kategoriler = dbContext.Kategoriler.OrderByDescending(t => t.CreationDate).Take(1).ToList();
        //    return kategoriler;
        //}
    }
}
