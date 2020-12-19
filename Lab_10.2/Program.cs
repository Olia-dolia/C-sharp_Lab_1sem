using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_2//Variant 4
{
    public static class DoubleArrayExtention
    {
        public static double AvarageOfArray(this double[] arr)
        {
            double temp = 0.0;
            
            for(int i=0; i <arr.Length; i++)
            {
                temp += arr[i];
            }
           return temp / arr.Length;
            
        }
        public static double AvarageOfarray_2(this double[] arr)
        {
            double temp2 = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                temp2 *= arr[i];
            }
            return temp2 / arr.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            double[] arr = new double[n] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            double avarageAr = 0;
            double avarageGeom = 0;
            Console.Write("Массив:\t");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
           
            avarageAr = arr.AvarageOfArray();
            avarageGeom = arr.AvarageOfarray_2();
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + avarageAr + "\t" + "Среднее геометрическое: " + avarageGeom);

            Console.ReadLine();
        }
    }
}
