using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp
{
    class Program
    {
        static void Main(string[] args)
        {
            AltSınıf altSınıf = new AltSınıf();

            altSınıf.Add(new Product
            {
                Id = 1,
                Name = "Mouse",
                UnitPrice = 200,
                StockAmount = 12
            });

            altSınıf.Delete(new Product
            {
                Id = 2,
                Name = "Pc",
                UnitPrice = 8000,
                StockAmount = 2
            });

            altSınıf.Update(new Product
            {
                Id = 3,
                Name = "Glasses",
                UnitPrice = 300,
                StockAmount = 5
            });       

            Console.ReadLine();
        }     
    }
}
