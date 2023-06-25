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
    public class AktiviteSeviyesiBLL : ICRUD<AktiviteSeviyesi>
    {
        public AktiviteSeviyesiBLL()
        {
            dbContext = new HubDbContext();
        }

        HubDbContext dbContext;
        public bool Ekle(AktiviteSeviyesi entity)
        {
            return false;
        }

        public bool Guncelle(AktiviteSeviyesi entity)
        {
            return false;
        }

        public bool Sil(int id)
        {
            return false;
        }

        public List<AktiviteSeviyesi> DegerleriListele()
        {
            return dbContext.AktiviteSeviyeleri.ToList();
        }
        public double DegerDondur(int id)
        {
            AktiviteSeviyesi aktivite = new AktiviteSeviyesi();
            aktivite = dbContext.AktiviteSeviyeleri.Find(id);
            return aktivite.SeviyeDegeri;
        }

        public string SeviyeAdiDon(int id)
        {
            AktiviteSeviyesi aktiviteSeviyesi = dbContext.AktiviteSeviyeleri.Find(id);
            return aktiviteSeviyesi.SeviyeBilgisi;
        }
    }
}
