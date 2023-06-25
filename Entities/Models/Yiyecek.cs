using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Yiyecek : Tablo
    {
        public Yiyecek()
        {
            YiyecekDetaylari = new List<YiyecekDetay>();
        }
        public string YiyecekAd { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public ICollection<YiyecekDetay> YiyecekDetaylari { get; set; }
    }
}
