using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11._11
{
    class Program
    {
        class Cognac
        {
             double price;
             int aged;
             string manufacturerCountry;
             string basedComponent;

            static List<Cognac> cognacList = new List<Cognac>();
           
            public Cognac(double price, int aged,string manufacturerCountry, string basedComponent)
            {
                this.price = price;
                this.aged = aged;
                this.manufacturerCountry = manufacturerCountry;
                this.basedComponent = basedComponent;
            }
            static public void AddCognac(Cognac Obj)
            {
                cognacList.Add(Obj);
            }
           
            static public void SearchPrice(double priceSearch)
            {
                
                foreach (Cognac x in cognacList)
                {
                    if (x.price == priceSearch)
                    {
                        Console.WriteLine("Цена - " + x.price + "\nВыдержка - " + x.aged + "\nСтрана производиетль - " + x.manufacturerCountry + "\nОсновной компонент -" + x.basedComponent);
                        Console.ReadLine();
                    }
                }

            }
            static public void SearchAged(int agedSearch)
            {

                foreach (Cognac x in cognacList)
                {
                    if (x.aged == agedSearch)
                    {
                        Console.WriteLine("Цена - " + x.price + "\nВыдержка - " + x.aged + "\nСтрана производиетль - " + x.manufacturerCountry + "\nОсновной компонент -" + x.basedComponent);
                        Console.ReadLine();
                    }
                }

            }
            static public void SearchCountry(string contrySearch)
            {

                foreach (Cognac x in cognacList)
                {
                    if (x.manufacturerCountry == contrySearch)
                    {
                        Console.WriteLine("Цена - " + x.price + "\nВыдержка - " + x.aged + "\nСтрана производиетль - " + x.manufacturerCountry + "\nОсновной компонент -" + x.basedComponent);
                        Console.ReadLine();
                    }
                }

            }
            static public void SearchComponent(string componentSearch)
            {

                foreach (Cognac x in cognacList)
                {
                    if (x.basedComponent == componentSearch)
                    {
                        Console.WriteLine("Цена - " + x.price + "\nВыдержка - " + x.aged + "\nСтрана производиетль - " + x.manufacturerCountry + "\nОсновной компонент -" + x.basedComponent);
                        Console.ReadLine();
                    }
                }

            }

        }
       
    
        static void Main(string[] args)
        {
            Cognac CamusCuvee = new Cognac(2500, 128, "Germany", "alcohol blend 41, 43, 44 years");
            Cognac DelamainLeVoyage = new Cognac(6500, 200, "Georgia", "infused alcohols for 150 years");
            Cognac HardyPerfectionFire = new Cognac(6700, 160, "France", "rare French Colombard grapes");
            Cognac LArtdeMartell = new Cognac(3630, 140, "Germany", "hints of currant and hazelnut flavor");
            Cognac HenriIVDudognon = new Cognac(2000000, 300, "Mexico", "The best 100 year old spirits");

            Cognac.AddCognac(CamusCuvee);
            Cognac.AddCognac(DelamainLeVoyage);
            Cognac.AddCognac(HardyPerfectionFire);
            Cognac.AddCognac(LArtdeMartell);
            Cognac.AddCognac(HenriIVDudognon);
            
            Console.WriteLine();
            Console.WriteLine("Выберете фильтр поиска: 1 - цена, 2 - выдержка, 3 - страна производитель, 4 - основной компонент");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите цену для поиска: ");
                    double priceSearch = Convert.ToDouble(Console.ReadLine());
                    Cognac.SearchPrice(priceSearch);
                    break;
                case 2:
                    Console.WriteLine("Введите выдержку для поиска: ");
                    int agedSearch = Convert.ToInt32(Console.ReadLine());
                    Cognac.SearchAged(agedSearch);
                    break;
                case 3:
                    Console.WriteLine("Введите страну для поиска: ");
                    string countrySearch = Console.ReadLine();
                    Cognac.SearchCountry(countrySearch);
                    break;
                case 4:
                    Console.WriteLine("Введите основной компонент для поиска: ");
                    string componentSearch = Console.ReadLine();
                    Cognac.SearchComponent(componentSearch);
                    break;
                default:
                    Console.WriteLine("Такого параметра не найдено! Нажмите ENTER чтобы завершить работу!");
                    break;
            }

        }
    }
}
