using System;
using Lab4;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run (1-4) or 0 to exit:");
                Console.WriteLine("1. ArrayListOperations");
                Console.WriteLine("2. ListOperations");
                Console.WriteLine("3. StackOperations");
                Console.WriteLine("4. QueueOperations");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        ArrayListOperations.Run();
                        break;
                    case 2:
                        ListOperations.Run();
                        break;
                    case 3:
                        StackOperations.Run();
                        break;
                    case 4:
                        QueueOperations.Run();
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