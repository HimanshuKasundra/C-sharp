using System;

namespace Lab2
{
    class EvenNumberException : Exception
    {
        public EvenNumberException(string message) : base(message) { }
    }

    class EvenNumberChecker
    {
        public static void RunEvenNumberCheckerProgram()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                EvenNumberChecker.CheckEvenNumber(num);
            }
            catch (EvenNumberException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
        public static void CheckEvenNumber(int num)
        {
            if (num % 2 != 0)
            {
                throw new EvenNumberException("Number is not even.");
            }
            else
            {
                Console.WriteLine("Number is even.");
            }
        }
    }
}