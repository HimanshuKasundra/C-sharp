using System;

namespace Lab3
{
    class FactorialCalculator
    {
        public static void RunFactorialCalculatorProgram()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            FactorialCalculator.FactorialDelegate factorial = FactorialCalculator.GetFactorial;
            Console.WriteLine("Factorial of " + num + ": " + factorial(num));
        }

        public delegate int FactorialDelegate(int n);

        public static int GetFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}