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
    public class YiyecekDetayBLL : ICRUD<YiyecekDetay>
    {
        public YiyecekDetayBLL()
        {
            dbContext = new HubDbContext();
            yiyecekDetay = new YiyecekDetay();
            yiyecekBLL = new YiyecekBLL();
        }
        HubDbContext dbContext;
        YiyecekDetay yiyecekDetay;
        YiyecekBLL yiyecekBLL;
        public bool Ekle(YiyecekDetay yiyecekDetay)
        {
            dbContext.YiyecekDetaylari.Add(yiyecekDetay);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(YiyecekDetay entity)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
        public List<YiyecekDetay> Listele()
        {
            return dbContext.YiyecekDetaylari.ToList();
        }
        public string YiyecekDetayBul(int id) //adına bak
        {
            yiyecekDetay = new YiyecekDetay();
            yiyecekDetay = dbContext.YiyecekDetaylari.Find(id);
            string detay = yiyecekDetay.Icerik;
            return detay;
        }

        public List<YiyecekDetay> YiyecekDetayGetir(int id)
        {
           
            return dbContext.YiyecekDetaylari.Where(a => a.YiyecekID == id).ToList(); 
          
        }

        public YiyecekDetay YiyecekDetayDöndür(int id)
        {
           return dbContext.YiyecekDetaylari.Find(id);
            
        }

    }
}
