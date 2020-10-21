using System;
using System.Collections.Generic;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*16.Дана квадратна матриця порядку M. Замінити нулями елементи матриці, що лежать 
             * 1) нижче 
             * 2) вище 
             * 3) головної;*/
            const int n = 5;

            int[,] Mas1 = new int[n, n];
            int[,] Mas2 = new int[n, n];
            int[,] Mas3 = new int[n, n];
            Random rand = new Random();

            Console.WriteLine("\tMatrix 1");
            for (int j = 0; j < n; j++)//створення і заповнення матриці
            {
                for (int i = 0; i < n; i++)
                {
                    Mas1[i, j] = rand.Next(0, 10);
                    Console.Write($"{Mas1[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int i = 0; i < n - 1; i++){//нулі під главною діагоналлю

              for (int j = i + 1; j < n; j++)
              {
                    Mas1[i, j] = 0;
              }
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{Mas1[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\tMatrix 2");
            for (int j = 0; j < n; j++)//створення і заповнення матриці
            {
                for (int i = 0; i < n; i++)
                {
                    Mas2[i, j] = rand.Next(0, 10);
                    Console.Write($"{Mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for ( int i = 0; i < n; i++){//над головною діагоналлю
                for ( int j = 0; j < n; j++) {
                    if (i > j)
                    {
                        Mas2[i, j] = 0;
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{Mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\tMatrix 3");
            for (int i = 0; i < n; i++)//створення і заповнення матриці
            {
                for (int j = 0; j < n; j++)
                {
                    Mas3[i, j] = rand.Next(0, 10);
                    Console.Write($"{Mas3[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i < n; i++)
            {//нулі під побічною діагоналлю
                for (int j = (n - i); j < n; j++)
                {
                    Mas3[i, j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{Mas3[i, j]} \t");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
