

class Program
{
    static string DecimalToBinary(int number)
    {
        string binary = "";

        while (number > 0)
        {
            int remainder = number % 2;
            binary = remainder + binary;
            number = number / 2;
        }

        return binary;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string binary = DecimalToBinary(num);

        Console.WriteLine("Binary equivalent: " + binary);
    }
}
