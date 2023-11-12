using System.Threading.Channels;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 250;
            product1.UnitsInStock = 5;

            Product product2 = new Product
            {
                Id = 1,
                CategoryId = 5,
                UnitsInStock = 4,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            // instance
            // PascalCase  // camelCase
            // case sensitive - küçük büyük harf duyarlılığı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            Console.WriteLine(product1.ProductName);


        }
    }
}