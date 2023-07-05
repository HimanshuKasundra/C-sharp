class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);

        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);
    }
}
