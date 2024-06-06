using System;

namespace Lab2
{
    interface ICalculate
    {
        void Addition(int a, int b);
        void Subtraction(int a, int b);
    }

    class Result : ICalculate
    {
        public static void RunResultProgram()
        {
            Result result = new Result();
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            result.Addition(a, b);
            result.Subtraction(a, b);
        }
        public void Addition(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
        }

        public void Subtraction(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }
    }
}