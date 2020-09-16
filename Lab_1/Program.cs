using System;
using System.Globalization;
using static System.Math;//для бібліотеки математики(краще вказувати напряму)
namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Обчислити період коливаннь маятника заданої довжини
            while (true) {
                Console.Clear();
                double T, l;
                double g = 9.8;
                Console.WriteLine("\tВведите длину вашего маятника(в см, через , )");
                Console.Write("l = ");
                l = double.Parse(Console.ReadLine());
                T = 2 * PI * Sqrt(l / g);
                Console.WriteLine("\tЧастота колебаний Вашего маятника = " + T);
                Console.ReadLine();
            }
        }
    }
}
