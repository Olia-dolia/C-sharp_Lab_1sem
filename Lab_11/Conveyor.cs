using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Conveyor
    {
        public static void DimensionsRemoved(Product Obj)
        {
            Obj.dimensionsRemoved = true;
        }
        public static void Cut(Product Obj)
        {
            Obj.cut = true;
        }
        public static void Sharpened(Product Obj)
        {
            Obj.sharpened = true;
        }
        public static void Threaded(Product Obj)
        {
            Obj.threaded = true;
        }
        public static void Drilled(Product Obj)
        {
            Obj.drilled = true;
        }
        public static void Painted(Product Obj)
        {
            Obj.painted = true;
        }
        public static void Tested(Product Obj)
        {
            Obj.tested = true;
        }
        public static void Packaged(Product Obj)
        {
            Obj.packaged = true;
        }
    }
}
