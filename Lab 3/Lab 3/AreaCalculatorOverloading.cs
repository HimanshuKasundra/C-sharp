using System;

namespace Lab3
{
    class AreaCalculatorOverloading
    {
        public static void RunAreaCalculatorOverloadingProgram()
        {
            Console.Write("Enter side of square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square: " + AreaCalculatorOverloading.CalculateArea(side));

            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of rectangle: " + AreaCalculatorOverloading.CalculateArea(length, width));

            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle: " + AreaCalculatorOverloading.CalculateArea(radius));
        }
        public static double CalculateArea(int side)
        {
            return side * side; // Area of square
        }

        public static double CalculateArea(double length, double width)
        {
            return length * width; // Area of rectangle
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius; // Area of circle
        }
    }
}