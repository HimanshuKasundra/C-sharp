// Write a program with following specifications:
// Class Name: Student
// Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
// Get Students Details using constructor and DisplayStudentDetails() using
// member function
public class Student
{   
    long Enrollment_No;
    int Semester;
    string? Student_Name;
    double CPI;
    double SPI;
    public void GetStudentDetails()
    {
        Console.WriteLine("-----------------Enter Account details-----------------");
        Console.WriteLine("Enter ENROLL no : ");
        Enrollment_No = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter Sem : ");
        int Semester= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student name : ");
        Student_Name = Console.ReadLine();
        Console.WriteLine("Enter CPI: ");
        CPI = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter CSPI: ");
        SPI = Convert.ToDouble(Console.ReadLine());
        
    }
    public void printStudentDetails()
    {
        Console.WriteLine("---------------Account Details--------------");
        Console.WriteLine("Acc No : " + Enrollment_No);
        Console.WriteLine("Acc Email : " + Semester);
        Console.WriteLine("Username : "+Student_Name);
        Console.WriteLine("Acc type :"+ CPI);
        Console.WriteLine("Acc balance :" +SPI);
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.GetStudentDetails();
        s.printStudentDetails();
    }
}
