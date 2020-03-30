using System;
using System.Timers;

namespace Learning.Whiteboard.Excercise
{
    /// <summary>
    /// Given an integer num, repeatedly add all its digits until the result has only one digit.
    /// For example:
    ///    Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. 
    ///    Since 2 has only one digit, return it.
    /// </summary>
    public class AddDigitInNumber : IExcercise
    {
        
        public void Start()
        {
            Console.Write("Please enter an positive integer: ");
            int number = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(Add2(number));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");

            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(Add1(number));
            //watch.Stop();
            //elapsedMs = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Method Execution took: {elapsedMs} ms");


        }
        /// <summary>
        /// Approach 1
        /// </summary>
        /// <param name="num">positive integer only</param>
        /// <returns>single digit integer</returns>
        public int Add1(int num)
        {
            int sum = 0;
            if (num < 10)
            {
                return num;
            }
            else
            {
                while (num != 0)
                {
                    int modulo = num % 10;
                    num = num / 10;
                    sum += modulo;
                }
                return Add1(sum);
            }
        }

        /// <summary>
        /// Approach 2
        /// </summary>
        /// <param name="num">positive integer only</param>
        /// <returns>single digit integer</returns>
        public int Add2(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else if (num % 9 == 0)
            {
                return 9;
            }
            else return num % 9;
        }  
    }
}
