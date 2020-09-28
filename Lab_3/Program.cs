using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //16. Перевірити істинність вислову: "Цифри даного тризначного числа утворюють геометричну прогресію"
            while (true)
            {
                Console.Clear();
                int number;
                double q;
                int[] arr = new int[3];
                bool Geometric = false;
                Console.WriteLine("Введите целое трехзначное число: ");
                try //проверка на input
                {
                    number = int.Parse(Console.ReadLine()); 
                    while (number < 100 || number > 1000)
                    {
                        Console.WriteLine("Вы неверно ввели число! Попробуйте еще раз!");
                        number = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.WriteLine("Нажмите ENTER, чтобы продолжить!");
                    Console.ReadLine();
                    continue;
                }
                for(int i = 2; i>-1; i--)//запись в массив числа
                {
                    arr[i]= number % 10;
                    number = number /= 10;
                }

                q = arr[1] / arr[0]; //нахождение знаменателя прогрессии
                if (arr[1] == 0)//на 0 делить нельзя
                {
                    Console.WriteLine("На ноль делить нельзя! Прогрессия не существует. Нажмите Enter");
                } else if (arr[1] / arr[0] == q && arr[2] / arr[1] == q) {//проверка элементов
                    Geometric = true;
                    Console.WriteLine(Geometric);
                } else {
                    Console.WriteLine(Geometric);
                }
                
                Console.ReadLine();
               
            }
        }
    }
}