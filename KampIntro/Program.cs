namespace KampIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - kendini tekrar etme
            // değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 254678;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }

            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");

            }



            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}