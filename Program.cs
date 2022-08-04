using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Создайте класс «Веб-сайт». Необходимо хранить в полях класса: 
     *  название сайта, 
     *  путь к сайту, 
     *  описание сайта, 
     *  ip адрес сайта. 
    Реализуйте методы класса для ввода данных, вывода данных, 
  реализуйте доступ к отдельным полям через методы класса.
 */

namespace Task4_3
{
    class Web_Site
    {
        string siteName = "";
        string siteAdress = "";
        string siteDiscription = "";
        string siteIP;

        public Web_Site()
        {
            this.siteName = "Компьютерная академия \"TOP\"";
            this.siteAdress = "https://brn.top-academy.ru/";
            this.siteDiscription = "  С 1999 года готовим программистов, дизайнеров и системных инженеров, которых\n нельзя заменить искусственным интеллектом. " +
                    "Для этого, кроме глубоких профильных знаний, учим\n понимать задачи, мыслить готовыми проектами и работать в команде.";
            this.siteIP = "46.148.233.24";
        }
        public Web_Site(string siteName, string siteAdress, string siteIP)
        {
            this.siteName = siteName;
            this.siteAdress = siteAdress;
            this.siteDiscription = "none";
            this.siteIP = siteIP;
        }

        public Web_Site(string siteName, string siteAdress, string siteDiscription, string siteIP)
        {
            this.siteName = siteName;
            this.siteAdress = siteAdress;
            this.siteDiscription = siteDiscription;
            this.siteIP = siteIP;
        }

        public void InsertDataSite()
        {
            Console.Write("\n\n Введите наименование сайта: ");
            siteName = Console.ReadLine();
            Console.Write(" Введите адрес сайта: ");
            siteAdress = Console.ReadLine();
            Console.Write(" Введите описание сайта: ");
            siteDiscription = Console.ReadLine();
            Console.Write(" Введите IP адрес сайта: ");
            siteIP = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"\n\n Наименование сайта: {siteName}\n" +
                                $" Адрес сайта: {siteAdress}\n" +
                                $" Описание сайта: {siteDiscription}\n" +
                                $" IP адрес сайа: {siteIP}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Web_Site siteNone = new Web_Site();
            siteNone.Print();

            Web_Site site1 = new Web_Site();
            site1.InsertDataSite();
            site1.Print();

            Web_Site site2 = new Web_Site("Яндекс", "https:\\yandex.ru", "77.88.55.77");
            site2.Print();

        }
    }
}
