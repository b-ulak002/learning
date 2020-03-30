using System;

namespace Learning.Whiteboard.Excercise
{
    /**CLOCK ANGLE PROBLEM
* Given a four digit integer ranging from 0000 to 2359, 
* 
* Write a method that will calculate
* the smallest angle made by the hour hand and the minute hand of an analog clock.
* Assume hour hand hand rests at the given number, suppose at 0330, the hour hand 
* will stop at 3, not in between 3 & 4, the minute hand stops at 30. 
* 
* Asssume there are no seconds.
 
* Things to do!!!!
* Display a error message to if user enters number greater than 2359 or a negative number.
* Add a second hand and find the angles.
* */

    public class AnalogClockAngle : IExcercise
    {
        public void Start()
        {
            Console.Write("Please enter an positive integer between 0000 and 2359 that represents a 24 hour time format: ");
            int time = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine($"The small angle made by analog clock at {time} is {CalculateAngle(time)} degrees.");     
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Method Execution took: {elapsedMs} ms");
        }

        private double CalculateAngle(int time)
        {
            int hour = time / 100;
            int minute = time % 100;
            double angle = 30 * hour - 5.5 * minute;
            angle = (angle > 180) ? 360 - angle : angle;
            return Math.Abs(angle);
        }
    }
}
