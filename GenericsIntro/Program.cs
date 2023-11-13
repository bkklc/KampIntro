namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            
            isimler.Add("Berk");

            Console.WriteLine(isimler.Length);

            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            


        }
    }
}