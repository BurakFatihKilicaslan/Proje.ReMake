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
    public class KullaniciOgunBLL : ICRUD<KullaniciOgun>
    {
        public KullaniciOgunBLL()
        {
            dbContext = new HubDbContext();
        }

        HubDbContext dbContext;

        public bool Ekle(KullaniciOgun kullaniciOgun)
        {
            dbContext.KullaniciOgunleri.Add(kullaniciOgun);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(KullaniciOgun entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }

        //public double GunlukKaloriDondur(int kullaniciID)
        //{
        //    var kalori = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.KullaniciID == kullaniciID && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Select(bd => bd.Kalori)
        //        .ToList();

        //    return kalori.Sum();
        //}

        //public double GunlukProteinDondur(int kullaniciID)
        //{
        //    var protein = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.KullaniciID == kullaniciID && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Select(bd => bd.Protein)
        //        .ToList();

        //    return protein.Sum();
        //}

        //public double GunlukKarbonhidratDondur(int kullaniciID)
        //{
        //    var karbonhidrat = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.KullaniciID == kullaniciID && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Select(bd => bd.Karbonhidrat)
        //        .ToList();

        //    return karbonhidrat.Sum();
        //}

        //public double GunlukYagDondur(int kullaniciID)
        //{
        //    var yag = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.KullaniciID == kullaniciID && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Select(bd => bd.Yag)
        //        .ToList();

        //    return yag.Sum();
        //}

        //public double OgunBazlıGunlukKaloriDondur(int kullaniciID, string ogunAdi)
        //{
        //    var ogunKalori = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.Ogun.OgunAd == ogunAdi && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Sum(b => b.Kalori);

        //    return ogunKalori;
        //}

        //public double OgunBazlıGunlukProteinDondur(int kullaniciID, string ogunAdi)
        //{
        //    var ogunProtein = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.Ogun.OgunAd == ogunAdi && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Sum(b => b.Protein);

        //    return ogunProtein;
        //}

        //public double OgunBazlıGunlukKarbonhidratDondur(int kullaniciID, string ogunAdi)
        //{
        //    var ogunKarbonhidrat = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.Ogun.OgunAd == ogunAdi && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Sum(b => b.Karbonhidrat);

        //    return ogunKarbonhidrat;
        //}

        //public double OgunBazlıGunlukYagDondur(int kullaniciID, string ogunAdi)
        //{
        //    var ogunYag = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.Ogun.OgunAd == ogunAdi && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .SelectMany(y => y.BesinDegerleri)
        //        .Sum(b => b.Yag);

        //    return ogunYag;
        //}

        //public List<Yiyecek> OgunAdinaGöreYemekleriGetir(int kullaniciID, string ogunAdi)
        //{
        //    var yemekler = dbContext.KullaniciOgunleri
        //        .Where(ko => ko.KullaniciID == kullaniciID && ko.CreationDate.Day == DateTime.Now.Day)
        //        .SelectMany(ko => ko.Ogun.KategoriOgunleri.SelectMany(ok => ok.Kategori.Yiyecekler))
        //        .ToList();

        //    return yemekler;
        //}

        //public BesinDegeri YiyecegeGoreBesinDegeriGetir(int yiyecekID)
        //{
        //    var besinDegeri = dbContext.BesinDegerleri.FirstOrDefault(bd => bd.YiyecekID == yiyecekID && bd.CreationDate.Day == DateTime.Now.Day);
        //    return besinDegeri;
        //}

        //public void GunSonuRaporu(int kullaniciID)
        //{
        //    var ogunlereGoreYemekler = from ko in dbContext.KullaniciOgunleri
        //                               join o in dbContext.Ogunler on ko.OgunID equals o.ID
        //                               join m in dbContext.KategoriOgunleri on o.ID equals m.OgunID
        //                               join ym in dbContext.Yiyecekler on m.KategoriID equals ym.KategoriID
        //                               join bd in dbContext.BesinDegerleri on ym.ID equals bd.YiyecekID
        //                               where ko.KullaniciID == kullaniciID && ko.CreationDate.Day == DateTime.Now.Day
        //                               select new
        //                               {
        //                                   OgunAdi = o.OgunAd,
        //                                   YemekAdi = ym.YiyecekAd,
        //                                   Kalori = bd.Kalori
        //                               };

        //    var toplamKal = from m in ogunlereGoreYemekler
        //                    group m by m.OgunAdi into g
        //                    select new
        //                    {
        //                        OgunAdi = g.Key,
        //                        ToplamKalori = g.Sum(x => x.Kalori)
        //                    };

        //    var data = from s in toplamKal
        //               join m in ogunlereGoreYemekler on s.OgunAdi equals m.OgunAdi into mealGroup
        //               select new
        //               {
        //                   OgunAdi = s.OgunAdi,
        //                   ToplamKalori = s.ToplamKalori,
        //                   Yemekler = mealGroup.Select(x => x.YemekAdi)
        //               };
        //}
    }
}
