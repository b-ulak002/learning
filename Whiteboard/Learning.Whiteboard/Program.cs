using Learning.Whiteboard.Excercise;
using System;

namespace Learning.Whiteboard
{
    class Program
    {
        static void Main(string[] args)
        {
            // No excercise(s) specified in args then run all
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please specify excercise(s) name");                
            }
            
            else
            {                
                // Consume any handled exception in case when Just-In-Time debugger 
                // is enabled on the host the process cannot be teminated on time, then it would
                // block the scheduled run instances afterwards
                //
                try
                {
                    var entry = new Entry();
                    entry.Run(args);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unhandled Exception: {0}", ex.ToString());
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
