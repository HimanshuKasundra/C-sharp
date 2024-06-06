using System;

namespace Lab3
{
    class Addition
    {
        public static void RunAdditionProgram()
        {
            Console.Write("Enter first integer: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of integers: " + Addition.Add(int1, int2));

            Console.Write("Enter first float: ");
            float float1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second float: ");
            float float2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Addition of floats: " + Addition.Add(float1, float2));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }
    }
} 