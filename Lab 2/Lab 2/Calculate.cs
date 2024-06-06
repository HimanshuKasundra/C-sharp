using System;

namespace Lab2
{
    abstract class Sum
    {
        public abstract int SumOfTwo(int a, int b);
        public abstract int SumOfThree(int a, int b, int c);
    }

    class Calculate : Sum
    {
        public static void RunCalculateProgram()
        {
            Calculate calc = new Calculate();
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number (or 0 if not needed): ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of 2 numbers: " + calc.SumOfTwo(a, b));
            if (c != 0)
                Console.WriteLine("Sum of 3 numbers: " + calc.SumOfThree(a, b, c));
        }
        public override int SumOfTwo(int a, int b)
        {
            return a + b;
        }

        public override int SumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}