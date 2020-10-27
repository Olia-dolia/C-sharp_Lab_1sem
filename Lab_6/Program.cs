using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static int Num_Revers(int number_1) //1.Виводить на екран введене число з клавіатури в зворотному порядку (1234-&gt;4321)
        {
            try //проверка на input
            {
                number_1 = int.Parse(Console.ReadLine());
                while (number_1 <= 0)
                {
                    Console.WriteLine("Вы неверно ввели число! Попробуйте еще раз!");
                    number_1 = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Не удалось преобразовать строку в число!");
                Console.WriteLine("Нажмите ENTER, чтобы продолжить!");
                Console.ReadLine();
            }
            int number_2 = 0;
            while (number_1 > 0)
            {
                number_2 = 10 * number_2 + number_1 % 10;
                number_1 = number_1 / 10;
            }

            return number_2;
        }

        static string Str_Revers()
        {
            string input = Console.ReadLine();
            string output = new string(input.ToCharArray().Reverse().ToArray());
            return output;
        }

        static double Revers_3(string One)
        {
            int Two = 0;
            int Three = 0;
            char symb = '.';
            char[] arr = One.ToCharArray();
            int i = 0;

            while (arr[i] != symb)//перша частина числа
            {
                int temp1 = int.Parse(arr[i].ToString());
                Two = Two * 10 + temp1;
                temp1 = 0;
                i++;
            }

            int temp = 0;
            int count = 0;
            for (int j = 0; j < arr.Length; j++)//друга частина
            {
                if (arr[j] == symb)
                {
                    temp = j;
                }
                if (temp > 0 && temp < j)
                {
                    int temp2 = int.Parse(arr[j].ToString());
                    Three = Three * 10 + temp2;
                    temp2 = 0;
                    count++;//підрахунок кількості чисел пілся коми
                }
            }
            int Revers1 = 0;
            int Revers2 = 0;

            while (Two > 0)//ціла частина
            {
                Revers1 = 10 * Revers1 + Two % 10;
                Two = Two / 10;
            }

            while (Three > 0)//дробова частина
            {
                Revers2 = 10 * Revers2 + Three % 10;
                Three = Three / 10;
            }
            double result = Revers1 + Revers2 / Math.Pow(10, count); //складаємо наше число до купи

            return result;
        }
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tВведите ваше число: ");
                int number_1 = 0, number_2 = 0;
                number_2 = Num_Revers(number_1);

                if (number_2 != 0)
                {
                    Console.WriteLine("Новое число: " + number_2);
                };

                //2. Виводить будь-яку строку в зворотному порядку (АБВ-&gt;ВБА)
                Console.WriteLine("\tВведите строку: ");
                string output = Str_Revers();
                Console.WriteLine("Перевернутая строка: " + output);
                //3. Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456-&gt; 321.654)
                Console.WriteLine("Введите ваше число через .");
                string One = Console.ReadLine();
                double result = Revers_3(One);

                Console.WriteLine("Новое число: " + result);

                Console.ReadLine();
            }
        }
    }
}
