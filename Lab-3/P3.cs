// Write a pogram to Create a class Bank_Account with Account_No, Email,
// User_Name, Account_Type and Account_Balance as data members. Also
// create a Member function GetAccountDetails() & DisplayAccountDetails()
public class Bank_Account
{   
    long Account_No;
    string? Email;
    string? User_Name;
    string? Account_Type;
    string? Account_Balance;
    public void GetAccountDetails()
    {
        Console.WriteLine("-----------------Enter Account details-----------------");
        Console.WriteLine("Enter acc no : ");
        Account_No = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter email : ");
        Email = Console.ReadLine();
        Console.WriteLine("Enter username : ");
        User_Name = Console.ReadLine();
        Console.WriteLine("Enter acc type : ");
        Account_Type =Console.ReadLine();
        Console.WriteLine("Enter acc balance : ");
        Account_Balance = Console.ReadLine();
    }
    public void printAccountDetails()
    {
        Console.WriteLine("---------------Account Details--------------");
        Console.WriteLine("Acc No : " + Account_No);
        Console.WriteLine("Acc Email : " + Email);
        Console.WriteLine("Username : "+User_Name);
        Console.WriteLine("Acc type :"+ Account_Type);
        Console.WriteLine("Acc balance :" +Account_Balance);
    }
}
class Program
{
    static void Main()
    {
        Bank_Account bObj = new Bank_Account();
        bObj.GetAccountDetails();
        bObj.printAccountDetails();
    }
}
