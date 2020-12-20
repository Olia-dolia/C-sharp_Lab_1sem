using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11//Variant 1
{
    delegate void Conveyor_d(Product Obj);
    class Program
    {       
        static void Main(string[] args)
        {
            Product product = new Product();

            Conveyor_d line = Conveyor.DimensionsRemoved;
            line(product);
            Conveyor_d line1 = Conveyor.Cut;
            line1(product);
            Conveyor_d line2 = Conveyor.Sharpened;
            line2(product);
            Conveyor_d line3 = Conveyor.Threaded;
            line3(product);
            Conveyor_d line4 = Conveyor.Drilled;
            line4(product);
            Conveyor_d line5 = Conveyor.Painted;
            line5(product);
            Conveyor_d line6 = Conveyor.Tested;
            line6(product);
            Conveyor_d line7 = Conveyor.Packaged;
            line7(product);

            product.ShowInfo();

            Console.ReadLine();
        }
    }
}
