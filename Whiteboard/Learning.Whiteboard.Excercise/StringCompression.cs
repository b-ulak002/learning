using System;
using System.Text;

namespace Learning.Whiteboard.Excercise
{
    /* String Compression:
         * Implement a method to perform basic string compression using 
         * the counts of repeated characters. For example, the string "aabcccccaaa" would become "a2b1c5a3".
         * If the "compressed" string would not become smaller than the original string, 
         * your method should return the original string. 
         * You can assume the string has only uppercase and lowercase letters (a-z, A-Z).*/
    public class StringCompression : IExcercise
    {
        public void Start()
        {
            Console.WriteLine("***Welcome to string compression excercise****");
            Console.Write("Please enter a string: ");
            string word  = Console.ReadLine();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine($"Compressed string for word '{word}' is {Compress(word)}.");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");
        }

        public StringBuilder Compress(string s)
        {
            StringBuilder compressedString = new StringBuilder();
            int counter = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals(s[i + 1]))
                {
                    counter++;
                }
                else
                {
                    compressedString.Append(s[i].ToString() + counter);
                    counter = 1;
                }
            }
            compressedString.Append(s[s.Length - 1].ToString() + counter);
            return compressedString;
        }
    }
}
