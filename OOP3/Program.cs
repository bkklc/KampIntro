namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();  
            konutKrediManager.Hesapla();
            */
            /*
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            */

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>{new SmsLoggerService(), new DatabaseLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService()); 
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService); 
            //basvuruManager.BasvuruYap(esnafKrediManager,  new SmsLoggerService()); 
            //basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()}); 
            basvuruManager.BasvuruYap(esnafKrediManager, loggers); 



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            


        }
    }
}