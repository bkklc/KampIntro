namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Berk";
            //musteri1.Soyadi = "Kılıç";
            //musteri1.Id = 1;
            //musteri1.MusteriNo = "123";
            //musteri1.TcNo = "111111111";
            //musteri1.SirketAdi = "?"; //hatalı 

            // Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Berk";
            musteri1.Soyadi = "Kılıç";
            musteri1.TcNo = "1111111111111";


            // Tüzel Müşteri
            // Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";
            


            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID


            Musteri musteri3 = new GercekMusteri(); // new sonraki bellekteki ref no
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);


        }
    }
}