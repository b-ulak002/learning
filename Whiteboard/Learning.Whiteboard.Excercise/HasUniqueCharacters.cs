using System;

namespace Learning.Whiteboard.Excercise
{
    /*Is Unique
         Implement an algorithm to determine if a string has all unique characters.
         What if you cannot use additional data structures*/

    public class HasUniqueCharacters : IExcercise
    {
        public void Start()
        {
            Console.Write("Please enter a string: ");
            string word = Console.ReadLine();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine($"The word '{word}' has unique characters: {IsUnique(word)}");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");
        }

        public bool IsUnique(string s)
        {
            bool isUnique = true;

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length - 1; j++)
                {
                    if (s[i] == s[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
            }

            return isUnique;
        }
    }
}
