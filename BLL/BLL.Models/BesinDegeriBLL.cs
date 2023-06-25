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
    public class BesinDegeriBLL : ICRUD<BesinDegeri>
    {
        public BesinDegeriBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(BesinDegeri besinDeger)
        {
            dbContext.BesinDegerleri.Add(besinDeger);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(BesinDegeri entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }

        public double GunlukKaloriGetir(int ogunID, int kullaniciID)
        {
            var kalori = dbContext.BesinDegerleri.Include(bd => bd.YiyecekOgun)
                .ThenInclude(yo => yo.Ogun).Where(bd => bd.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID) && bd.ID == ogunID && bd.CreationDate.Day == DateTime.Now.Day).Select(bd => bd.Kalori)
                .FirstOrDefault();


            return kalori;
        }

        public double GunlukProteinGetir(int ogunID, int kullaniciID)
        {
            var protein = dbContext.BesinDegerleri.Include(bd => bd.YiyecekOgun).ThenInclude(yo => yo.Ogun)
                .Where(bd => bd.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID) && bd.ID == ogunID && bd.CreationDate.Day == DateTime.Now.Day).Select(bd => bd.Protein).FirstOrDefault();


            return protein;
        }

        public double GunlukKarbonhidratGetir(int ogunID, int kullaniciID)
        {
            var karbonhidrat = dbContext.BesinDegerleri.Include(bd => bd.YiyecekOgun).ThenInclude(yo => yo.Ogun)
                .Where(bd => bd.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID) && bd.YiyecekOgun.OgunID == ogunID && bd.YiyecekOgun.CreationDate.Day == DateTime.Now.Day).Select(bd => bd.Karbonhidrat).FirstOrDefault();


            return karbonhidrat;
        }

        public double GunlukYagGetir(int ogunID, int kullaniciID)
        {
            var yag = dbContext.BesinDegerleri.Include(bd => bd.YiyecekOgun).ThenInclude(yo => yo.Ogun).Where(bd => bd.YiyecekOgun.Ogun.KullaniciOgunleri.Any(ko => ko.KullaniciID == kullaniciID) && bd.ID == ogunID && bd.CreationDate.Day == DateTime.Now.Day).Select(bd => bd.Yag).FirstOrDefault();


            return yag;
        }
    }
}
