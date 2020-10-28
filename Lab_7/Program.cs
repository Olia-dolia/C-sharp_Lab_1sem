using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В16 -> 4.Створити ліст інтових змінних, дозволити можливість заповнення з
                калвіатури.Вивести індекси змінних рівних перевірочній(теж ввести з
                клавіатури).Скопіювати ліст в масив.*/

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Введите размер вашего списка: ");
                int n = int.Parse(Console.ReadLine());
                while (n <= 0)
                {
                    Console.WriteLine("Введите целое положительное число: ");
                    n = int.Parse(Console.ReadLine());
                }

                List<int> variable = new List<int>();
                for (int i = 0; i < n; i++)//запис елементів в ліст
                {
                    Console.Write("Введите элемент {0}", (i + 1) + " = ");//нумерація елементів
                    try
                    {
                        variable.Add(int.Parse(Console.ReadLine()));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неверный формат числа");
                    }
                }
                foreach (int i in variable)
                {
                    Console.WriteLine($"{i} ");
                }

                Console.Write("Введите число, которое будем сравнивать: ");
                int verification = int.Parse(Console.ReadLine());

                while (verification <= 0)
                {
                    Console.WriteLine("Введите целое положительное число: ");
                    verification = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < variable.Count; i++)
                {
                    if (variable[i] == verification)
                    {
                        Console.WriteLine("Индекс: " + i);
                    }
                }
                Console.WriteLine();
                int[] arr = new int[variable.Count];
                variable.CopyTo(arr);
                Console.WriteLine("Массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                Console.ReadLine();
            }

        }
    }
}
