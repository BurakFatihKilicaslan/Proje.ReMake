using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstracts
{
    public abstract class Tablo
    {
        public Tablo()
        {
            CreationDate = DateTime.Now;     //Her yeni eklemede o anki tarih kaydedilmis olacak
        }
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
