class Program
{
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        double interest = (principal * rate * time) / 100;
        return interest;
    }

    static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double principalAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the interest rate: ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time period (in years): ");
        double timePeriod = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = CalculateSimpleInterest(principalAmount, interestRate, timePeriod);

        Console.WriteLine("Simple Interest: " + simpleInterest);
    }
}
