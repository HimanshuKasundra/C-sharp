using System;
using Lab2;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-10) or 0 to exit:");
                Console.WriteLine("1. DivideByZeroExceptionDemo");
                Console.WriteLine("2. IndexOutOfRangeDemo");
                Console.WriteLine("3. Calculate Sum");
                Console.WriteLine("4. Result Calculation");
                Console.WriteLine("5. StringMethodsDemo");
                Console.WriteLine("6. CaseConversionDemo");
                Console.WriteLine("7. Shape Calculation");
                Console.WriteLine("8. EvenNumberChecker");
                Console.WriteLine("9. LongestWordFinder");
                Console.WriteLine("10. CaseChange");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        DivideByZeroExceptionDemo.Run();
                        break;
                    case 2:
                        IndexOutOfRangeDemo.Run();
                        break;
                    case 3:
                        Calculate.RunCalculateProgram();
                        break;
                    case 4:
                        Result.RunResultProgram();
                        break;
                    case 5:
                        StringMethodsDemo.Run();
                        break;
                    case 6:
                        CaseConversionDemo.Run();
                        break;
                    case 7:
                        Shape.RunShapeProgram();
                        break;
                    case 8:
                        EvenNumberChecker.RunEvenNumberCheckerProgram();
                        break;
                    case 9:
                        LongestWordFinder.RunLongestWordFinderProgram();
                        break;
                    case 10:
                        CaseChange.RunCaseChangeProgram();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
