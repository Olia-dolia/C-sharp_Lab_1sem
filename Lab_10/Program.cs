using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public static class CharArrayExtension
    {
        public static void Reverse(this char[] value1, char[] value2)
        {
            for (int i = value1.Length - 2; i > -1; i--)
            {
                Console.Write(value1[i]);
            }
            Console.Write(',');
            for (int i = value2.Length - 2; i > -1; i--)
            {
                Console.Write(value2[i]);
            }
            Console.WriteLine();
        }
        public static void ReverseR(this char[] value1, char[] value2, int i1, int i2)
        {
            ReverseR(value1, i1);
            Console.Write(',');
            ReverseR(value2, i2);

        }
        public static void ReverseR(this char[] value, int i)
        {
            if (i > -1)
            {
                Console.Write(value[i]);
                ReverseR(value, i - 1);
            }
        }
    }
        public static class StringExtension
    {
        public static void Reverse(this string value)
        {
            for (int i = value.Length - 1; i > -1; i--)
            {
                Console.Write(value[i]);
            }
            Console.WriteLine();
        }
        public static void ReverseR(this string value, int i)
        {
            if (i > -1)
            {
                Console.Write(value[i]);
                ReverseR(value, i - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;    
            Console.InputEncoding = System.Text.Encoding.Unicode;      

            Console.WriteLine("Введіть число або рядок (без розділових знаків та пробілів):");
            string data = Console.ReadLine();

            Console.WriteLine("\nРезультат:");
            data.Reverse();
            Console.WriteLine("Рекурсія:");
            data.ReverseR(data.Length - 1);

            char[] chData = new char[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                chData[i] = data[i];
            }

            Console.WriteLine("\n\nВведіть дробове число або рядок з ОДНІЄЮ комою всередині (без пробілів):");
            string data1 = Console.ReadLine();

            int size = 0;
            for (int i = 0; i < data1.Length; i++)
            {
                if (data1[i] == ',')
                {
                    size = i;
                    break;
                }
            }

            char[] data1_1 = new char[size + 1];
            char[] data1_2 = new char[data1.Length - size];

            for (int i = 0; i < size; i++)
            {
                data1_1[i] = data1[i];
            }
            for (int i = size + 1, j = 0; i < data1.Length; i++, j++)
            {
                data1_2[j] = data1[i];
            }

            Console.WriteLine("\nРезультат:");
            data1_1.Reverse(data1_2);
            Console.WriteLine("Рекурсія:");
            data1_1.ReverseR(data1_2, data1_1.Length - 2, data1_2.Length - 2);

            Console.ReadKey();
        }
    }
}
