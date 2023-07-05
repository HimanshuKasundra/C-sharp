class Program
{
    static void Main()
    {
        Console.Write("Enter your weight in pounds: ");
        double weightPounds = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your height in inches: ");
        double heightInches = Convert.ToDouble(Console.ReadLine());
        double weightKg = weightPounds * 0.45359237;
        double heightMeters = heightInches * 0.0254;
        double bmi = weightKg / (heightMeters * heightMeters);
        Console.WriteLine("Your BMI is: " + bmi);
    }
}
