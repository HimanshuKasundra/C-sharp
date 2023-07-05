using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms in the Fibonacci series: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int firstNum = 0;
        int secondNum = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(firstNum + " ");

            int temp = firstNum;
            firstNum = secondNum;
            secondNum = temp + secondNum;
        }
    }
}
