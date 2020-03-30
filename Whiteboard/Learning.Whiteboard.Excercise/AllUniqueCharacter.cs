using System;

namespace Learning.Whiteboard.Excercise
{
    /// <summary>
    /// Implement an algorithm to determine if a string(ASCII characters only) has all unique characters. What if
    /// you can not use additional data structures?
    /// </summary>
    public class AllUniqueCharacter : IExcercise
    {
        public void Start()
        {
            Console.WriteLine("***determine if a string has all unique characters****");
            Console.Write("Please enter a string: ");
            string word = Console.ReadLine();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            bool isUnique = IsUniqueChars(word);
            watch.Stop();

            if (isUnique)
            {
                Console.WriteLine($"The string '{word}' has unique characters.");
            }
            else
            {
                Console.WriteLine($"The string '{word}' does not unique characters.");
            }                  
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");
        }

        /// <summary>
        /// Time complexity is O(n), where n is the length of the string, and space complexity is O(n)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsUniqueChars(string str)
        {
            //For simplicity, assume char set is ASCII (if not, we need to increase the storage size)
            bool[] charset = new bool[256];
            for (int i = 0; i < str.Length; ++i)
            {
                int val = str[i];
                if (charset[val]) return false;
                charset[val] = true;
            }
            return true;
        }
    }    
}
