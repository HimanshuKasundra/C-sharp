using System;
using System.Collections.Generic;

namespace Lab4
{
    class ListOperations
    {
        public static void Run()
        {
            List<int> studentList = new List<int>();

            // Add students
            studentList.Add(21);
            studentList.Add(1111);
            studentList.Add(121212);
            studentList.Add(21);
            studentList.Add(1111);
            studentList.Add(121212);

            // Remove student at specified index
            studentList.RemoveAt(1);

            // Remove students within a range
            studentList.RemoveRange(0, 2); // Removes all students

            // Clear all students
            studentList.Clear();

            Console.WriteLine("List operations completed.");
        }
    }
}