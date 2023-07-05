
class Program
{
    static int CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static int CalculatePermutation(int n, int r)
    {
        int numerator = CalculateFactorial(n);
        int denominator = CalculateFactorial(n - r);

        int permutation = numerator / denominator;

        return permutation;
    }

    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of r: ");
        int r = Convert.ToInt32(Console.ReadLine());

        int nPr = CalculatePermutation(n, r);

        Console.WriteLine("nPr = " + nPr);
    }
}
