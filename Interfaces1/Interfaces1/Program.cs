using System;

namespace Interfaces1
{
    class Program
    {
        //Shape Interface
        interface IShape
        {
            double CalculateArea();
            double CalculatePerimeter();
        }


        //Shape Classes
        public class Circle : IShape
        {
            public double Radius { get; set; }
            public double CalculateArea()
            {
                return Math.PI * (Radius / 2) * (Radius / 2);
            }
            public double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
            public Circle(double radius)
            {
                Radius = radius;
            }
        }
        public class Rectangle : IShape
        {
            double Height { get; set; }
            double Width { get; set; }
            public double CalculateArea()
            {
                return Width * Height;
            }
            public double CalculatePerimeter()
            {
                return 2 * (Height + Width);
            }
            public Rectangle(double height, double width)
            {
                Height = height;
                Width = width;
            }
        }
        public class Triangle : IShape
        {
            double TriangleBase { get; set; }
            double Height { get; set; }
            public double CalculateArea()
            {
                return (TriangleBase * Height) / 2;
            }
            public double CalculatePerimeter()
            {
                return (2 * Math.Pow((Height + Math.Pow(TriangleBase / 2, 2)), -2)) + TriangleBase;
            }
            public Triangle(double trianglebase, double height)
            {
                TriangleBase = trianglebase;
                Height = height;
            }
        }

        //Logic
        static void Main(string[] args)
        {
            Menu();
            bool Start = true;
            string selection = Console.ReadLine();
            while (Start)
            {
                switch (selection)
                {
                    case "1":
                        {
                            CircleOutput();
                            continue;
                        }
                    case "2":
                        {
                            RectangleOutput();
                            continue;
                        }
                    case "3":
                        {
                            TriangleOutput();
                            continue;
                        }
                    case "4":
                        {
                            Console.WriteLine("Goodbye");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Input");
                            continue;
                        }
                }
            }
        }

        //menu
        static void Menu()
        {
            Console.WriteLine("Choose a Shape");
            Console.WriteLine("1) Circle");
            Console.WriteLine("2) Rectangle");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Exit");
        }

        //Shape Creating
        static IShape CreateCircle(double radius)
        {
            IShape shapeC = new Circle(radius);
            return shapeC;
        }
        static IShape CreateRectangle(double height, double width)
        {
            IShape shapeR = new Rectangle(height, width);
            return shapeR;
        }
        static IShape CreateTriangle(double trianglebase, double height)
        {
            IShape shapeT = new Triangle(trianglebase, height);
            return shapeT;
        }

        //outputs
        static void CircleOutput()
        {
            string radius;
            Console.WriteLine("Write The Radius of Circle");
            radius = Console.ReadLine();
            IShape shape = CreateCircle(Convert.ToDouble(radius));
            Console.WriteLine("Area of Circle: " + shape.CalculateArea());
            Console.WriteLine("Perimeter of Circle:" + shape.CalculatePerimeter());
        }
        static void RectangleOutput()
        {
            string Width;
            string Height;
            Console.WriteLine("Write The Height of Rectangle");
            Height = Console.ReadLine();
            Console.WriteLine("Write The Width of Rectangle");
            Width = Console.ReadLine();
            IShape shape = CreateRectangle(Convert.ToDouble(Height), Convert.ToDouble(Width));
            Console.WriteLine("Area of Rectangle: " + shape.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: " + shape.CalculatePerimeter());
        }
        static void TriangleOutput()
        {
            string TriangleBase;
            string Height;
            Console.WriteLine("Write The width of the base");
            TriangleBase = Console.ReadLine();
            Console.WriteLine("Write The height of the triangle");
            Height = Console.ReadLine();
            IShape shape = CreateTriangle(Convert.ToDouble(TriangleBase), Convert.ToDouble(Height));
            Console.WriteLine("Area of Triangle: " + shape.CalculateArea());
            Console.WriteLine("Perimeter of Triangle: " + shape.CalculatePerimeter());
        }
    }
}
