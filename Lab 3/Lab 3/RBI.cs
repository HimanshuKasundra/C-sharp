using System;

namespace Lab3
{

    class RBI
    {
        public static void RunRBIProgram()
        {
            Console.Write("Enter principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time period: ");
            double time = Convert.ToDouble(Console.ReadLine());

            RBI rbi1 = new HDFC();
            Console.WriteLine("Interest calculated by HDFC: " + rbi1.CalculateInterest(principal, rate, time));

            RBI rbi2 = new SBI();
            Console.WriteLine("Interest calculated by SBI: " + rbi2.CalculateInterest(principal, rate, time));

            RBI rbi3 = new ICICI();
            Console.WriteLine("Interest calculated by ICICI: " + rbi3.CalculateInterest(principal, rate, time));
        }
        public virtual double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100;
        }
    }

    class HDFC : RBI
    {
        public override double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100 * 1.5; // Example custom calculation for HDFC
        }
    }

    class SBI : RBI
    {
        public override double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100 * 1.2; // Example custom calculation for SBI
        }
    }

    class ICICI : RBI
    {
        public override double CalculateInterest(double principal, double rate, double time)
        {
            return principal * rate * time / 100 * 1.3; // Example custom calculation for ICICI
        }
    }
}