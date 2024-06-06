using System;

namespace Lab3
{
    class Calculator
    {
        public static void RunCalculatorProgram()
        {
            Console.Write("Enter first integer: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Calculator.CalculatorDelegate<int> calcInt = Calculator.Add;
            Console.WriteLine("Addition result: " + calcInt(int1, int2));

            Console.Write("Enter first double: ");
            double double1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second double: ");
            double double2 = Convert.ToDouble(Console.ReadLine());
            Calculator.CalculatorDelegate<double> calcDouble = Calculator.Subtract;
            Console.WriteLine("Subtraction result: " + calcDouble(double1, double2));
        }
        public delegate T CalculatorDelegate<T>(T num1, T num2);

        public static T Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }

        public static T Subtract<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a - b;
        }
    }
}