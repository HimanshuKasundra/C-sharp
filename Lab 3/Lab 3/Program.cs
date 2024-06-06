using System;
using Lab3;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-8) or 0 to exit:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. AreaCalculator");
                Console.WriteLine("3. RBI Interest Calculation");
                Console.WriteLine("4. FactorialCalculator");
                Console.WriteLine("5. Hospital Details");
                Console.WriteLine("6. AreaCalculatorOverloading");
                Console.WriteLine("7. TrafficSignal");
                Console.WriteLine("8. Calculator");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        Addition.RunAdditionProgram();
                        break;
                    case 2:
                        AreaCalculator.RunAreaCalculatorProgram();
                        break;
                    case 3:
                        RBI.RunRBIProgram();
                        break;
                    case 4:
                        FactorialCalculator.RunFactorialCalculatorProgram();
                        break;
                    case 5:
                        Hospital.RunHospitalProgram();
                        break;
                    case 6:
                        AreaCalculatorOverloading.RunAreaCalculatorOverloadingProgram();
                        break;
                    case 7:
                        TrafficSignal.RunTrafficSignalProgram();
                        break;
                    case 8:
                        Calculator.RunCalculatorProgram();
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
