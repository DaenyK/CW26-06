using ConsoleApplication2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   string str = "test";
               string st = "привет как дела";
               Console.WriteLine(st.Contains("как")); //contains

               if (str == "fsfs")  //compareto
               {
                   Console.WriteLine("hello");
               }
               else if (str.CompareTo("test") == 0)
               {
                   Console.WriteLine("bye");
               }
               else if (string.CompareOrdinal(str, "test") == 0)
               {

               }


               string str2 = string.Concat("01", "02", "03", str); // concat
               str = "gjdfhgjfhjgk" + "   dfkjd";
               Console.WriteLine(str2);
               Console.WriteLine(str);



               if (st.StartsWith("прив")) // Starts with начинается ли с какой то подстроки
               {
                   Console.WriteLine("начинается с прив");
               }
               else Console.WriteLine("не начинается с прив");



               int sPos = st.IndexOf("в"); // возврат индекса 
               Console.WriteLine(sPos);

               Console.WriteLine(st.Substring(sPos)); // вывод с по


               string[] strAr = st.Split(' '); //разделение по указаному признаку

               st = string.Join("-", strAr);//склеивание

               //trim - с начала и конца удаляет, trimStart - только с начала, trim end только с конца


               // task1();
               // task2();
               // task8();
               // task6();

       */

            //  bigTask();



            string str = string.Format("{0:yyyymmdd}", DateTime.Now);
            Console.WriteLine(str);

            Console.WriteLine("{0:###.##}",542.1215);


            Person p = new Person();
        }
        static void task1()
        {
            //13.Дано натуральное число n(1 <= n <= 1188), определяющее возраст человека(в месяцах).
            //Выразить возраст в годах и месяцах, например, 21 год 10 месяцев, 52 года 1 месяц, 46 лет ровно и т. п

            Console.Write("введите год рождения: ");
            int y = 0;
            while (!int.TryParse(Console.ReadLine(), out y))
                Console.Write("введите корректный год рождения: ");

            Console.Write("введите месяц рождения: ");
            int m = 0;
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.Write("введите корректный месяц рождения: ");

            Console.Write("введите день рождения: ");
            int d = 0;
            while (!int.TryParse(Console.ReadLine(), out d))
                Console.Write("введите корректный день рождения: ");

            DateTime dob = new DateTime(y, m, d);
            DateTime now = DateTime.Now;

            double difY = (now.Year - dob.Year);
            double difM = (now.Month - dob.Month);
            double difD = (now.Day - dob.Day);


            Console.WriteLine("{0} лет {1} месяцев и {2} дня", difY, Math.Abs(difM), difD);

            Console.Write("введите кол-во месяцев: ");
            int cm = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddMonths(-cm));
        }
        static void task2()
        {
            //            9.Дата некоторого дня характеризуется двумя натуральными числами: m(порядковый номер месяца) и n (число).По заданным n и m определить:
            //a.дату предыдущего дня(принять, что n и m не характеризуют 1 января);
            //            b.дату следующего дня(принять, что n и m не характеризуют 31 декабря).
            Console.Write("введите год : ");
            int y = 0;
            while (!int.TryParse(Console.ReadLine(), out y))
                Console.Write("введите корректный год : ");

            Console.Write("введите месяц рождения: ");
            int m = 0;
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.Write("введите корректный месяц : ");

            Console.Write("введите день : ");
            int d = 0;
            while (!int.TryParse(Console.ReadLine(), out d))
                Console.Write("введите корректный день рождения: ");

            DateTime days = new DateTime(y, m, d);
            Console.WriteLine(days.AddDays(-1));
            Console.WriteLine(days.AddDays(1));

        }
        static void task8()
        {
            //  8.С начала 1990 года по некоторый день прошло n месяцев и 2 дня.Определить название месяца(январь, февраль и т.п.) этого дня

            Console.Write("введите кол-во месяц : ");
            int m = 0;
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.Write("введите корректный месяц : ");



            DateTime days = new DateTime(1990, 1, 1);

            days = days.AddDays(2).AddMonths(m);
            Console.WriteLine(days);

        }
        enum Weight
        {
            Light = 0,
            PreNormal,
            Normal
        }
        static void task6()
        {
            int w = 0;
            int.TryParse(Console.ReadLine(), out w);
            if (w <= 60)
            {
                w = 0;
                Console.WriteLine((Weight)w);
                Console.WriteLine(Weight.Light.ToString());
                Console.WriteLine((int)Weight.Light);
            }
            else if (w <= 64)
            {
                w = 1;
                Console.WriteLine((Weight)w);
                Console.WriteLine(Weight.PreNormal.ToString());
                Console.WriteLine((int)Weight.PreNormal);
            }
            else if (w <= 69)
            {
                w = 2;
                Console.WriteLine((Weight)w);
                Console.WriteLine(Weight.Normal.ToString());
                Console.WriteLine((int)Weight.Normal);
            }
        }
        static void bigTask()
        {
             string emex = "{'Details':[{'GroupId':-479,'PriceGroup':5,'MakeLogo':'94','MakeName':'autoSFEC','DetailNum':'AK001876','NewDetailNum':null,'DetailNameRus':'Опора  амортизатора','PriceLogo':'LONS','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':50,'DDPercent':42.0,'ADDays':11,'DeliverTimeGuaranteed':11,'ResultPrice':456.070000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'*Ч','MakeName':'Profit','DetailNum':'23140021','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТ. AUDI 100 AVANT 90-94 FRONT (L/R) БЕЗ','PriceLogo':'SMAR','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':2,'DDPercent':98.0,'ADDays':6,'DeliverTimeGuaranteed':6,'ResultPrice':474.360000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'FB','MakeName':'FEBI','DetailNum':'01876','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'SMAR','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':3,'DDPercent':98.0,'ADDays':6,'DeliverTimeGuaranteed':6,'ResultPrice':484.390000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'RU','MakeName':'Ruville','DetailNum':'825711','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'AMTS','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':1,'DDPercent':91.0,'ADDays':11,'DeliverTimeGuaranteed':11,'ResultPrice':1166.430000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'RU','MakeName':'Ruville','DetailNum':'825711','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1319.830000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'FB','MakeName':'FEBI','DetailNum':'01366','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':75.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1702.740000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'18','MakeName':'Vaico','DetailNum':'101209','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':564.630000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'ML','MakeName':'Meyle','DetailNum':'1004120007','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':29.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1204.780000},"
                        + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'09','MakeName':'SWAG','DetailNum':'30540009','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1102.120000},"
                        + "{'GroupId':-1220,'PriceGroup':5,'MakeLogo':'ML','MakeName':'Meyle','DetailNum':'1004120007','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':29.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1204.780000}"
                        + "],'IsSuccess':true,'ErrorMessage':null,'BlockDateEnd':null}";

            string sss = Console.ReadLine();

            emex = emex.Substring(emex.IndexOf('[')+1, emex.IndexOf(']') - emex.IndexOf('[')- 1);
            string [] Data = emex.TrimEnd ('}').Split('}');
            for (int i = 0; i < Data.Length; i++)
            {
                string[] tmp = Data[i].Split(',');
                Console.WriteLine (tmp[4].Trim('\'').Replace("':'",":"));
                    //   Console.WriteLine(tmp[4] + "\n" + tmp[15]);

            }

            //Console.WriteLine(emex);
        }
    }
}
