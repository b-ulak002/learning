using System;

namespace Learning.Whiteboard.Excercise
{
    /**
     * In mathematics, the factorial of a positive integer n, denoted by n!, is the product of all positive integers less than or equal to n:
     *Denoted by (symbol: !) it says to multiply all whole numbers from our chosen number down to 1. The factorial of zero is 1
     *
     * Examples:
     * 
     * 4! = 4 × 3 × 2 × 1 = 24
     * 7! = 7 × 6 × 5 × 4 × 3 × 2 × 1 = 5040
     * 1! = 1 and 0! = 1
     */
    public class Factorial : IExcercise
    {
        public void Start()
        {
            Console.WriteLine("***Welcome to Factorial calculation***");
            Console.Write("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine($"{number}! = {FactorialWithoutRecursion(number)}");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");
        }
        public double FactorialWithoutRecursion(int number)
        {
            double factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public double FactorialWithRecursion(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else return number * FactorialWithRecursion(number - 1);
        }
    }    
}
