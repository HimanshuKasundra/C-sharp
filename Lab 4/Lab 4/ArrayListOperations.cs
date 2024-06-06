using System;
using System.Collections;

namespace Lab4
{
    class ArrayListOperations
    {
        public static void Run()
        {
            ArrayList studentNames = new ArrayList();

            // Add students
            Console.WriteLine("Enter the number of student you want ta add in arrayList:");
            int n=Convert.ToInt32(Console.ReadLine());  
            for(int i=0; i<n;i++)
            {
                Console.Write("Enter a StudentName :");
                studentNames.Add(Console.ReadLine());
            }
            

            // Remove student at specified index
            studentNames.RemoveAt(1);
            
            // Remove students within a range
            studentNames.RemoveRange(0, 2); // Removes all students

            // Display Students
            foreach (var item in studentNames)
            {
                Console.WriteLine($"STudentName:{ item}");
            }

            // Clear all students
            studentNames.Clear();

            Console.WriteLine("ArrayList operations completed.");
        }
    }
}