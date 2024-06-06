using System;

namespace Lab3
{
    class AreaCalculator
    {
        public static void RunAreaCalculatorProgram()
        {
            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of square: " + AreaCalculator.CalculateArea(side));

            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of rectangle: " + AreaCalculator.CalculateArea(length, width));
        }
        public static double CalculateArea(double side)
        {
            return side * side; // Area of square
        }

        public static double CalculateArea(double length, double width)
        {
            return length * width; // Area of rectangle
        }
    }
}