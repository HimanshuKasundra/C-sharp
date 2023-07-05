// 1. Write a program to create a class named Candidate with ID, Name, Age,
// Weight and Height as data members & also create a member functions like
// GetCandidateDetails() and DisplayCandidateDetails()
class Candidate
{
    int ID;
    string? name;
    int Age;
    double height;
    double weight;

    public void GetCandidateDetails()
    {
        Console.WriteLine("-----------------Enter your details-----------------");
        Console.WriteLine("Enter id: ");
        ID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter weight: ");
        weight = Convert.ToDouble(Console.ReadLine());
    }
    public void printCandidateDetails()
    {
        Console.WriteLine("---------------Student Details--------------");
        Console.WriteLine("ID : " + ID);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + Age);
        Console.WriteLine("Height : " + height);
        Console.WriteLine("Weight : " + weight);
    }
}
class Program
{
    static void Main()
    {
        Candidate c1 = new Candidate();
        c1.GetCandidateDetails();
        c1.printCandidateDetails();
    }
}
