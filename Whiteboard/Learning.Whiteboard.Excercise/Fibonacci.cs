using System;

namespace Learning.Whiteboard.Excercise
{
    /**
     * The Fibonacci Sequence is the series of numbers:
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
The next number is found by adding up the two numbers before it.
The 2 is found by adding the two numbers before it (1+1)
The 3 is found by adding the two numbers before it (1+2),
And the 5 is (2+3),
and so on!
     */
    public class Fibonacci : IExcercise
    {
        public void Start()
        {
            Console.WriteLine("***Welcome to Fibonacci sequence generator***");
            Console.Write("How many numbers do you want? ");
            int number = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i <= number; i++)
            {
                Console.Write(GetFibonacciRecursive(i) + ", ");
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine();
            Console.WriteLine($"GetFibonacciRecursive Method Execution took: {elapsedMs} ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i <= number; i++)
            {
                Console.Write(GetFibonacci1(i) + ", ");
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine();
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            PrintFibonacci(number);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine();
            Console.WriteLine($"Print Fibonacci Method Execution took: {elapsedMs} ms");
        }

        public int GetFibonacciRecursive(int n)
        {
            return (n <= 1) ? n : GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
        }

        private void PrintFibonacci(int n)
        {
            int a = 1;
            int b = 1;
            Console.Write($"{a}, {b}, ");
            for (int i = 3; i <= n; i++)
            {
                int temp = a + b;
                Console.Write($"{temp}, ");
                a = b;
                b = temp;
            }                        
        }

        public int GetFibonacci1(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
