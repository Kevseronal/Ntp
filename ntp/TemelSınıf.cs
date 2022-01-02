using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp
{
    class TemelSınıf
    {

        public virtual void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi : "+ product.Name);
        }

        public virtual void Delete(Product product)
        {
            Console.WriteLine("Ürün Silindi : "+ product.Name);
        }

        public virtual void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi : "+ product.Name);
        }
    }
}
