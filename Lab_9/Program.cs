using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        interface IDraw
        {
            void Draw();
        }
        class Painter
        {
            public static void Draw(IDraw Obj)
            {
                Obj.Draw();
            }
        }
        abstract class Shape : IDraw
        {
            public abstract double S();
            public abstract double Perimeter();
            public abstract string ShapeName();
            public abstract double Length();
            public abstract void Draw();
            public ConsoleColor color;


            public void ShowInfo()
            {
                Console.WriteLine(
                    $"Название фигуры: {ShapeName()}\n" +
                    $"Площадь: {S()}\n" +
                    $"Периметр: {Perimeter()}\n" +
                    $"Длина: {Length()}"
                    );
                Console.WriteLine();
            }
        }

        class Triangle : Shape
        {
            Random random = new Random();
            double sideA, sideB, sideC;   // Стороны треугольника
           
            // Конструктор
            public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
            {
                SideA = triangleSideA;
                SideB = triangleSideB;
                SideC = triangleSideC;
            }

            // Свойство, проверяем значение на отрицательность.
            // Если значение отрицательное меняем его на аналогичное положительное.
            public double SideA
            {
                get { return sideA; }
                set { sideA = value < 0 ? -value : value; }
            }

            public double SideB
            {
                get { return sideB; }
                set { sideB = value < 0 ? -value : value; }
            }

            public double SideC
            {
                get { return sideC; }
                set { sideC = value < 0 ? -value : value; }
            }
            
            // Метод для вычисления периметра треугольника
            public override double Perimeter()
            {
                double perimetr = (sideA + sideB + sideC);
                return perimetr;
            }
            // Метод для вычисления площади треугольника
            public override double S()
            {
                double semPer = Perimeter() / 2;
                double S = Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC));
                return S;
            }
            public override double Length()
            {
                int numberOfApexes = 3;
                double length = S() * numberOfApexes;
                return length;
            }

            // Метод возвращающий наименование фигуры
            public override string ShapeName()
            {
                string name = "Треугольник";
                return name;
            }

            public override void Draw()
            {
                color = (ConsoleColor)random.Next(16);
                Console.ForegroundColor = color;
                if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
                if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

                Console.ResetColor();
            }
        }

        class Square : Shape
        {
            Random random = new Random();
            double side;   // Сторона квадрата

            // Конструктор
            public Square(double squareSide)
            {
                Side = squareSide;
            }

            // Свойство, проверяем значение на отрицательность.
            public double Side
            {
                get { return side; }
                set { side = value < 0 ? -value : value; }
            }

            // Метод для вычисления площади квадрата
            public override double S()
            {
                double S = (side * side);
                return S;
            }

            // Метод для вычисления периметра квадрата
            public override double Perimeter()
            {
                double perimetr = (side * 4);
                return perimetr;
            }

            public override double Length()
            {
                int numberOfApexes = 4;
                double length = S() * numberOfApexes;
                return length;
            }

            // Метод возвращающий наименование фигуры
            public override string ShapeName()
            {
                return "Квадрат";
            }

            public override void Draw()
            {
                color = (ConsoleColor)random.Next(16);
                Console.ForegroundColor = color;
                if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
                if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

                Console.ResetColor();
            }
        }

        class Circle : Shape
        {
            Random random = new Random();
            double radius;   // Радиус круга
           
            // Конструктор
            public Circle(double circleRadius)
            {
                Radius = circleRadius;
            }

            // Свойство, проверяем значение на отрицательность.
            public double Radius
            {
                get { return radius; }
                set { radius = value < 0 ? -value : value; }
            }

             // Метод для вычисления площади круга 
            public override double S()
            {
                double S = radius * radius * Math.PI;
                return S;
            }

            public override double Perimeter()
            {
                return 0;
            }

            // Метод для вычисления длинны круга
            public override double Length()
            {
                int numberOfApexes = 0;
                double length = 2 * radius * Math.PI;
                return length;
            }

            // Метод возвращающий наименование фигуры
            public override string ShapeName()
            {
                return "Круг";
            }

            public override void Draw()
            {
                color = (ConsoleColor)random.Next(16);
                Console.ForegroundColor = color;
                if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
                if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

                Console.ResetColor();
            }
        }

        class Picture
        {
            public List<Shape> shapes;

            public int lengthOfList
            {
                get
                {
                    return shapes.Count();
                }
            }

            public Picture()
            {
                shapes = new List<Shape>();
            }

            public Picture(int lengthOfList)
            {
                shapes = new List<Shape>(lengthOfList);
            }

            public void AddShape(Shape Obj)
            {
                shapes.Add(Obj);
            }
            public void DeleteShape(string name)
            {
                shapes.RemoveAll(i => i.ShapeName() == name);
            }

            public void DeleteShape(int length)
            {
                shapes.RemoveAll(i => i.Length() == length);
            }
            public void DeleteShape(double S)
            {
                shapes.RemoveAll(i => i.S() == S);
            }
            public void Draw()
            {
                foreach (Shape i in shapes)
                    i.Draw();
            }

            public Shape this[int index]
            {
                get
                {
                    return shapes[index];
                }
            }
        }
        static void Main(string[] args)
        {
            Shape figure1 = new Triangle(4, 5, 6);
            //

            Shape figure2 = new Square(5);
            //

            Shape figure3 = new Circle(5);
            

            Picture picture = new Picture(3);
            picture.AddShape(figure1);
            picture.AddShape(figure2);
            picture.AddShape(figure3);

            Console.WriteLine("Length of list : {0}", picture.lengthOfList);

            figure1.ShowInfo();
            figure2.ShowInfo();
            figure3.ShowInfo();

            Console.WriteLine("Painter.Draw(figure1)");
            Painter.Draw(figure1);

            Console.WriteLine("picture:");
            picture.Draw();

            Console.WriteLine("Фигура круг была удалена.");
            picture.DeleteShape("Круг");

            Console.ReadLine();
            }
        
    }
}
