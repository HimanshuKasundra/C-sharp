// Write a program to create a class Staff having data members as Name,
// Department, Designation, Experience & Salary. Accept this data for 5
// different staffs and display only names & salary of those staff who are HOD
public class Staff
{
    public string? name , Department, Designation, Experience;
    long Salary;

    public void GetStaffDetails()
    {
        Console.WriteLine("-----------------Enter Staff Member details-----------------");
        Console.WriteLine("Enter name : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter Department : ");
        Department = Console.ReadLine();
        Console.WriteLine("Enter Designation : ");
        Designation = Console.ReadLine();
        Console.WriteLine("Enter Experience : ");
        Experience =Console.ReadLine();
        Console.WriteLine("Enter Salary: ");
        Salary = Convert.ToInt64(Console.ReadLine());
    }
    public void print_HOD_Details()
    {
        Console.WriteLine("---------------HOD Details--------------");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Salary : " + Salary);

    }
}
class Program
{
    static void Main()
    {
        Staff[] c = new Staff[5];
        for(int i = 0 ; i < 5 ; i++){
            c[i] = new Staff();
            c[i].GetStaffDetails();
        }
        for(int i  = 0; i < 5 ; i++){
            if(c[i].Department == "HOD"){
                c[i].print_HOD_Details();
            }
        }
        
    }
}
