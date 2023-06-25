using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Kategori : Tablo
    {
        public Kategori()
        {
            Yiyecekler = new List<Yiyecek>();
        }
        public string KategoriAd { get; set; }
        public ICollection<Yiyecek> Yiyecekler { get; set; }
    }
}
