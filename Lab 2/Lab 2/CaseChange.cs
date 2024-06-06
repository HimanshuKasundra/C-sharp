using System;

namespace Lab2
{
    class CaseChange
    {
        public static void RunCaseChangeProgram()
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nOriginal character: {ch}");
            char changedChar = CaseChange.ChangeCase(ch);
            Console.WriteLine($"Changed character: {changedChar}");
        }
        public static char ChangeCase(char ch)
        {
            if (char.IsLower(ch))
            {
                return char.ToUpper(ch);
            }
            else if (char.IsUpper(ch))
            {
                return char.ToLower(ch);
            }
            else
            {
                return ch;
            }
        }
    }
}