using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICRUD<T> where T : class
    {
        public bool Ekle(T entity);
        public bool Guncelle(T entity);
        public bool Sil(int id);
    }
}
