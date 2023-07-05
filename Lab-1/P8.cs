using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Sum: " + result);
                break;

            case 2:
                result = num1 - num2;
                Console.WriteLine("Difference: " + result);
                break;

            case 3:
                result = num1 * num2;
                Console.WriteLine("Product: " + result);
                break;

            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Quotient: " + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
