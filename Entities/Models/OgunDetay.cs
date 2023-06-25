using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OgunDetay : Tablo
    {
        public int OgunID { get; set; }
        public Ogun Ogun { get; set; }
    }
}
