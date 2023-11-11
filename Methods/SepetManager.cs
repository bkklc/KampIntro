using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete ürün eklendi: " + product.Name);
        }

        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi )
        {
            Console.WriteLine("Sepete ürün eklendi: " + urunAdi + ", " + aciklama);
        }
    }
}
