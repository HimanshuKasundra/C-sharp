

class Program
{
    static void Main()
    {
        Console.Write("Enter the marks obtained in 5 subjects: ");
        double[] marks = new double[5];

        for (int i = 0; i < 5; i++)
        {
            marks[i] = Convert.ToDouble(Console.ReadLine());
        }

        double totalMarks = 500;
        double totalObtainedMarks = 0;

        for (int i = 0; i < 5; i++)
        {
            totalObtainedMarks += marks[i];
        }

        double percentage = (totalObtainedMarks / totalMarks) * 100;

        Console.WriteLine("Percentage: " + percentage);

        if (percentage >= 60)
        {
            Console.WriteLine("Grade: First Grade");
        }
        else if (percentage >= 50 && percentage < 60)
        {
            Console.WriteLine("Grade: Second Grade");
        }
        else if (percentage >= 40 && percentage < 50)
        {
            Console.WriteLine("Grade: Third Grade");
        }
        else
        {
            Console.WriteLine("Grade: Poor Grade");
        }
    }
}
