using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp
{
    class AltSınıf : TemelSınıf
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi(override): "+ product.Name);
           
        }

        public override void Delete(Product product)
        {
            Console.WriteLine("Ürün silindi(override): " + product.Name);

        }

        public override void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi(override) : " + product.Name);

        }
    }
}
