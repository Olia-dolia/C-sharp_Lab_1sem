using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Product
    {
        public bool dimensionsRemoved;
        public bool cut;
        public bool sharpened;
        public bool threaded;
        public bool drilled;
        public bool painted;
        public bool tested;
        public bool packaged;

        public Product()
        {
            dimensionsRemoved = false;
            cut = false;
            sharpened = false;
            threaded = false;
            drilled = false;
            painted = false;
            tested = false;
            packaged = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine(
            $"Размеры сняты \t-- {dimensionsRemoved}\n" +
            $"Отрезано \t-- {cut}\n" +
            $"Заточено \t-- {sharpened}\n" +
            $"Нарезано резьбу \t\t-- {threaded}\n" +
            $"просверлено \t-- {drilled}" +
            $"Покрашено \t-- {painted}" +
            $"Протестировано \t-- {tested}" +
            $"\nУпаковано\t-- {packaged}\n");
        }
    }
}
