using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        public class Garage : IEnumerable, IEnumerator
        {
            protected int size;
            protected int index;
            public AUTO[] carArray;
            private int pos = -1;

            public Garage()
            {
                carArray = new AUTO[0];
            }

            public void AddCar(string car, int sp, string col, int year)
            {
                Array.Resize(ref carArray, carArray.Length + 1);
                carArray[carArray.Length - 1] = new AUTO(car, sp, col, year);
            }
            
            public AUTO this[int index]
            {
                get { return carArray[index]; }
            }

            public int Count
            {
                get { return carArray.Length; }
            }

            #region Члены IEnumerable

            public IEnumerator GetEnumerator()
            {
                return carArray.GetEnumerator();
            }
            #endregion

            #region Члены IEnumerator
            public bool MoveNext()
            {
                if (pos < carArray.Length)
                {
                    pos++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                pos = 0;
            }

            public object Current
            {
                get { return carArray[pos]; }
            }

            #endregion


        }

        public class AUTO
        {
            private string model;
            private int speed;
            private string color;
            private int yearOfIssue;

            public AUTO(string model, int speed, string color, int yearOfIssue)
            {
                this.model = model;
                this.speed = speed;
                this.color = color;
                this.yearOfIssue = yearOfIssue;
            }

            public string Model
            {
                get { return this.model; }
            }

            public int Speed
            {
                get { return this.speed; }
            }
            public string Color
            {
                get { return this.color; }
            }
            public int YearOfIssue
            {
                get { return this.yearOfIssue; }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество машин в гараже: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Garage garage = new Garage();
            while (true)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Модель машины: ");
                    string car = Console.ReadLine();
                    Console.Write("Скорость машины: ");
                    int sp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Цвет машины: ");
                    string col = Console.ReadLine();
                    Console.Write("Год выпуска машины: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    garage.AddCar(car, sp, col, year);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Просмотр машин в гараже");

                foreach (AUTO car in garage)
                {
                    Console.WriteLine("Модель - {0}, Скорость - {1}, Цвет - {2}, Год выпуска - {3}", car.Model, car.Speed, car.Color, car.YearOfIssue);
                }
                Console.ReadLine();
                Console.Write("Если хотите добавить машину в гараж нажмите - 1: ");
                int choose = int.Parse(Console.ReadLine());
               if( choose == 1)
                {
                    {
                        Console.Write("Модель машины: ");
                        string car = Console.ReadLine();
                        Console.Write("Скорость машины: ");
                        int sp = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Цвет машины: ");
                        string col = Console.ReadLine();
                        Console.Write("Год выпуска машины: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        garage.AddCar(car, sp, col, year);
                    }
                    foreach (AUTO car in garage)
                    {
                        Console.WriteLine("Модель - {0}, Скорость - {1}, Цвет - {2}, Год выпуска - {3}", car.Model, car.Speed, car.Color, car.YearOfIssue);
                    }
                }
                else
                {
                    continue;
                }
                Console.ReadLine();



            }
        }
    }
}
