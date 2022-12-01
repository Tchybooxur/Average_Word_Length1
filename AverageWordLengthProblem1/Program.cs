using System;
using System.Text;

namespace AverageWordLengthProblem1
{
    class Program
    {
        /*
        Average Word Length:

        You are in a college level English class, your professor wants you to write an essay, but you need to find out the average length of all the words you use. It is up to you to figure out how long each word is and to average it out.

        Task: 
        Takes in a string, figure out the average length of all the words and return a number representing the average length. Remove all punctuation. Round up to the nearest whole number.

        Input Format: 
        A string containing multiple words.

        Output Format: 
        A number representing the average length of each word, rounded up to the nearest whole number.

        Sample Input: 
        this phrase has multiple words

        Sample Output: 
        6


        Explanation:
        The string in question has five words with a total of 26 letters (spaces do not count). The average word length is 5.20 letters, rounding it up to the nearest whole numbers results in 6.
        */

        public static string Stripper(string text)
        {
            //assuming only alphabets and numbers
            string alpha = "abcdefghijklmnopqrstuvwxyz1234567890 ";
            //instantiate stringBuilder 
            var sb = new StringBuilder();
            //remove punctuations
            foreach (char c in text)
            {
                if (alpha.Contains(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an english sentence:");
            string text = Console.ReadLine();
            text = Stripper(text);
            string[] words = text.Split();

            float letters = 0;
            foreach (string word in words)
                letters += word.Length;

            float avg = letters / words.Length;
            Console.WriteLine("\nThe average word length according to the task is {0}.\n\n", Math.Ceiling(avg));
        }
    }
}
