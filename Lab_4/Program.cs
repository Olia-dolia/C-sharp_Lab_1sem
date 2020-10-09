using System;
using System.Collections.Generic;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //16.Даний масив розміру N.Визначити кількість його проміжків монотонності(інтервалів індексів, для яких його елементи монотонно зростають(спадають)).
            while (true)
            {
                Console.Clear();
                int n = 0;
                int positiveInterval = 0;
                int negativeInterval = 0;
                int unchanged = 0;

                Console.WriteLine("Введите розмер вашего массива: ");
                n = int.Parse(Console.ReadLine());
                while (n <= 0)
                {
                    Console.WriteLine("Введите целое положительное число: ");
                    n = int.Parse(Console.ReadLine());
                }

                List<float> arr = new List<float>();//запис елементів в масив
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Введите элемент {0}", (i + 1) + " = ");//нумерація елементів
                        try
                        {
                            arr.Add(float.Parse(Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Неверный формат числа");
                        }
                    }

                    for (int i = 0; i < (n - 1); i++)
                    {
                        float diff = arr[i + 1] - arr[i];//визначення інтервалу зростання/спадання
                    if(diff < 0)
                    {
                        negativeInterval++;
                    }
                    else if(diff == 0)
                    {
                        unchanged++;
                    }
                    else if(diff > 0)
                    {
                        positiveInterval++;
                    }
                    diff = 0;
                    }
                Console.WriteLine("Положительных интервалов = " +  positiveInterval);
                Console.WriteLine("Отрицательных интервалов = " +negativeInterval);
                Console.WriteLine("Нажмите ENTER");
                Console.ReadLine();
            }

        }
    }
}
