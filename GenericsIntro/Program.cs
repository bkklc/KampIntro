namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            Console.WriteLine();
            isimler.Add("Berk");

        }
    }
}