using System;

namespace Lab2
{
    class LongestWordFinder
    {
        public static void RunLongestWordFinderProgram()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string longestWord = LongestWordFinder.FindLongestWord(sentence);
            Console.WriteLine($"Longest word: {longestWord}");
        }
        public static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}