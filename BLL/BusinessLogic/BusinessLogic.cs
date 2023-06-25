using BLL.BLL.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessLogic
{
    public class BusinessLogic
    {
        public BusinessLogic()
        {
            AktiviteSeviyeleri = new AktiviteSeviyesiBLL();
            BesinDegerleri = new BesinDegeriBLL();
            Kategoriler = new KategoriBLL();
            KategoriOgunleri = new YiyecekOgunBLL();
            Kullanicilar = new KullaniciBLL();
            KullaniciGecmisleri = new KullaniciGecmisiBLL();
            Ogunler = new OgunBLL();
            OgunDetaylari = new OgunDetayBLL();
            GunlukRaporlar = new GunlukRaporBLL();
            TuketimGecmisleri = new TuketimGecmisiBLL();
            Yiyecekler = new YiyecekBLL();
            YiyecekDetaylari = new YiyecekDetayBLL();
        }

        public AktiviteSeviyesiBLL AktiviteSeviyeleri { get; set; }
        public BesinDegeriBLL BesinDegerleri { get; set; }
        public KategoriBLL Kategoriler { get; set; }
        public YiyecekOgunBLL KategoriOgunleri { get; set; }
        public KullaniciBLL Kullanicilar { get; set; }
        public KullaniciGecmisiBLL KullaniciGecmisleri { get; set; }
        public OgunBLL Ogunler { get; set; }
        public OgunDetayBLL OgunDetaylari { get; set; }
        public GunlukRaporBLL GunlukRaporlar { get; set; }
        public TuketimGecmisiBLL TuketimGecmisleri { get; set; }
        public YiyecekBLL Yiyecekler { get; set; }
        public YiyecekDetayBLL YiyecekDetaylari { get; set; }
        public YiyecekOgunBLL YiyecekOgun { get; set; }
    }
}
