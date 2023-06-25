using BLL.Interfaces;
using DAL.Context;
using Entities.Abstracts;
using Entities.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class KullaniciBLL : ICRUD<Kullanici>
    {
        public KullaniciBLL()
        {
            dbContext = new HubDbContext();
        }

        HubDbContext dbContext;
        Kullanici kullanici;

        public bool Ekle(Kullanici kullanici)
        {
            dbContext.Kullanicilar.Add(kullanici);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(Kullanici kullanici)
        {
            dbContext.Kullanicilar.Update(kullanici);
            return dbContext.SaveChanges() > 0;
        }

        public bool Sil(int id)
        {
            dbContext.Kullanicilar.Find(id);
            return dbContext.SaveChanges() > 0;
        }

        public Kullanici IsmeGoreGetir(string kullaniciAdi)
        {
            return dbContext.Kullanicilar.FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi);
        }

        public List<Kullanici> KullanicilariGetir()
        {
            return dbContext.Kullanicilar.Where(k => k.Statu == Entities.Enums.Statu.Musteri).ToList();
        }

        public string ComputeSha256Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public Kullanici IDGoreGetir(int id)
        {
            return dbContext.Kullanicilar.Find(id);
        }

        public string BilgiVer(int id)
        {
            kullanici = new Kullanici();
            kullanici = dbContext.Kullanicilar.Find(id);
            AktiviteSeviyesi aktiviteSeviyesi = dbContext.AktiviteSeviyeleri.FirstOrDefault(a => a.ID == kullanici.AktiviteSeviyesiID);
            return aktiviteSeviyesi.SeviyeBilgisi;
        }
    }
}
