using System;

namespace Lab2
{
    interface IShape
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double side);
    }

    class Shape : IShape
    {
        public static void RunShapeProgram()
        {
            Shape shape = new Shape();
            Console.WriteLine("Select a shape to calculate area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Square");
            int shapeChoice = Convert.ToInt32(Console.ReadLine());

            switch (shapeChoice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Circle: " + shape.Circle(radius));
                    break;
                case 2:
                    Console.Write("Enter base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Triangle: " + shape.Triangle(baseLength, height));
                    break;
                case 3:
                    Console.Write("Enter side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Square: " + shape.Square(side));
                    break;
                default:
                    Console.WriteLine("Invalid shape choice");
                    break;
            }
        }
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double side)
        {
            return side * side;
        }
    }
}