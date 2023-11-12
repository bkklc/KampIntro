using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        // encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi: " + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi: " + product.ProductName);
        }


         


    }
}
