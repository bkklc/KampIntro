

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };
            */

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.UnitPrice = 15;
            product1.Description = "Amasya Elması";


            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.UnitPrice = 50;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name + " Fiyatı: " + product.UnitPrice);
            }


            Console.WriteLine("-----------------Metotlar-----------------------");

            // instance - örnek
            // encapsulation - kapsülleme - ayrı ayrı yazacağın, düzensiz yapıyı bir düzenin kapsülün içine alma olayı
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 45, 20);
            sepetManager.Add2("Elma", "Amasya Elması", 27, 15);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 80, 25);
        }
    }
}

// Dont repeat yourself - DRY - Best Practice