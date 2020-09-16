using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int k;
                double a = 0;
                try
                {
                    Console.WriteLine("\tВведите k(k > 0) ");
                    k = int.Parse(Console.ReadLine());
                    while (k <= 0)
                    {
                        Console.WriteLine("Вы неверно ввели k! Попробуйте еще раз!");
                        k = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.WriteLine("Нажмите ENTER, чтобы продолжить!");
                    Console.ReadLine();
                    continue;
                }
                for (int n = 0; n <= k; n++)
                {
                    a += Math.Pow(k,2)/ (Math.Pow(-1, k) * Math.Pow(k, 2) + 5);
                }
                Console.WriteLine("Сумма ряду = " + a);
                Console.ReadLine();
            }

        }
    }
}
