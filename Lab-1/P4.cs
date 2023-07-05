
class P4
{
    static void Main()
    {
        Console.Write("Enter the length in feet: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width in feet: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("The area is: " + area + " square feet.");
    }
}
