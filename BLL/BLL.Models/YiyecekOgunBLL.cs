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
    public class YiyecekOgunBLL : ICRUD<YiyecekOgun>
    {
        public YiyecekOgunBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(YiyecekOgun entity)
        {
            dbContext.YiyecekOgunler.Add(entity);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(YiyecekOgun entity)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> YiyecekAdiDondur(int ogunID, int kullaniciID)
        {
            var liste = dbContext.YiyecekOgunler.Include(yo => yo.Ogun).Where(yo => yo.OgunID == ogunID && yo.CreationDate.Day == DateTime.Now.Day && yo.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID)).Select(yo => yo.Yiyecek.YiyecekAd).ToList();


            return liste;
        }

     
    }
}
