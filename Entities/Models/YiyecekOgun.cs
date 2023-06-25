using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class YiyecekOgun : Tablo
    {
        public YiyecekOgun()
        {
            BesinDegerleri = new List<BesinDegeri>();
        }
        public int OgunID { get; set; }
        public Ogun Ogun { get; set; }
        public int YiyecekID { get; set; }
        public Yiyecek Yiyecek { get; set; }
        public ICollection<BesinDegeri> BesinDegerleri { get; set; }
    }
}
