namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collections - Koleksiyonlar

            //string[] isimler = new string[] {"Engin", "Berk", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            ////Console.WriteLine(isimler[0]);


            Console.WriteLine("--------------Listeler------------");

            List<string> isimler2 = new List<string>{ "Engin", "Berk", "Halil"};
            //isimler2.Add("Engin");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);

            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }

        }
    }
}