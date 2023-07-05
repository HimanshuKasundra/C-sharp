// Write a program for implementing single inheritance which creates one
// class Account_Details for getting account information and another class
// Interest for calculating and displaying total interest from the data inserted
// from account details
using System;

class Account_Details
{
    public int AccountNumber;
        public String UserName;
        public String Email;
        public String Type;
        public double Balance;

        public BankAccount()
        {
            Console.WriteLine("Enter Account Number : ");
            this.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name : ");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter Type : ");
            this.Type = Console.ReadLine();
            Console.WriteLine("Enter Balance : ");
            this.Balance = Convert.ToDouble(Console.ReadLine());
        }
}
class Interest : Account_Details
{
    private double Time;
    private double Rate;
    
    Interest(double t , double r)  :base() {
        t = Time;
        r = Rate;
    }

    double surface_area;
    public Table(string Material, double Price, double Height, double SurfaceArea)
        {
            this.material = Material;
            this.price = Price;
            this.height = Height;
            this.surface_areaurfaceArea = SurfaceArea;
        }
} 
class Program
{
    static void Main(string[] args)
    {
        Table t = new Table("Material", 50000, 120, 1200);
            t.displayData();
    }
}
