using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine("The maximum number is: " + max);
    }
}
