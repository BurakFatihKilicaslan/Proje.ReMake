using BLL.Interfaces;
using DAL.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class YiyecekBLL : ICRUD<Yiyecek>
    {
        public YiyecekBLL()
        {
            dbContext = new HubDbContext();
        }
        HubDbContext dbContext;
        public bool Ekle(Yiyecek yiyecek)
        {
           dbContext.Yiyecekler.Add(yiyecek);
            return dbContext.SaveChanges() > 0;
        }

        public bool KategoriyeEkle(Yiyecek yiyecek)
        {
            

            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(Yiyecek entity)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
        public List<Yiyecek> ButunYemekleriGetir()
        {
            return dbContext.Yiyecekler.ToList();
        }

        public List<Yiyecek> KategoriyeGoreYemekleriGetir(int id)
        {
            Yiyecek yiyecekler = new Yiyecek();
            yiyecekler = dbContext.Yiyecekler.Find(id);
            return dbContext.Yiyecekler.Where(a => a.YiyecekAd == yiyecekler.YiyecekAd).ToList();
        }

        public List<Yiyecek> KarakterAl(string karakter)
        {
            List<Yiyecek> yiyecekler = dbContext.Yiyecekler.Where(a => a.YiyecekAd.Contains(karakter)).ToList();
            return yiyecekler;
        }

        public List<Yiyecek> KarakterAl(string karakter , int id)
        {
            List<Yiyecek> yiyecekler = dbContext.Yiyecekler.Where(a => a.YiyecekAd.Contains(karakter) && a.KategoriID == id).ToList();
            return yiyecekler;
        }

        public List<Yiyecek> Filtrele(int id) // adını değiştir
        {
            Kategori kategori = new Kategori();
            kategori.ID = id;
            List<Yiyecek> yiyecekler = dbContext.Yiyecekler.Where(a => a.KategoriID == kategori.ID).ToList();
            return yiyecekler;
        }

        public Yiyecek IdGetir(int id)
        {
            Yiyecek yiyecek = new Yiyecek();

            yiyecek = dbContext.Yiyecekler.Find(id);
            return yiyecek;

        }

        public int YemekIdDön(Yiyecek yiyecek) // adına bak
        {
            
            var donenYemek = dbContext.Yiyecekler.FirstOrDefault(a => a.CreationDate.Minute == DateTime.Now.Minute);
            if (donenYemek != null)
            {
                return donenYemek.ID;
            }
            else 
            { 
                return 0; 
            }
        }
    }
}
