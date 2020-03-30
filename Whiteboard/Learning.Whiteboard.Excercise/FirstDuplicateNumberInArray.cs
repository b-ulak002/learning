using System;
using System.Collections.Generic;

namespace Learning.Whiteboard.Excercise
{
    /// <summary>
    /**
     * Write a solution with O(n) time complexity and O(1) additional space complexity, 
since this is what you would be asked to do during a real interview.

Given an array a that contains only numbers in the range from 1 to a.length, 
find the first duplicate number for which the second occurrence has the minimal index. In other words, 
if there are more than 1 duplicated numbers, 
return the number for which the second occurrence has a smaller index than the second occurrence of the other number does. 
If there are no such elements, return -1.

Example

For a = [2, 3, 3, 1, 5, 2], the output should be
firstDuplicate(a) = 3.

There are 2 duplicates: numbers 2 and 3. 
The second occurrence of 3 has a smaller index than than second occurrence of 2 does, so the answer is 3.

For a = [2, 4, 3, 5, 1], the output should be
firstDuplicate(a) = -1.

Input/Output

[execution time limit] 3 seconds (cs)

[input] array.integer a

Guaranteed constraints:
1 ≤ a.length ≤ 105,
1 ≤ a[i] ≤ a.length.

[output] integer

The element in a that occurs in the array more than once and has the minimal index for its second occurrence. 
If there are no such elements, return -1.
     */
    /// </summary>
    public class FirstDuplicateNumberInArray : IExcercise
    {
        public void Start()
        {
            int[] array = {1, 2, 2, 3, 3 };
            Console.WriteLine($"First duplicate in [1, 2, 2, 3, 3] is {FirstDuplicate(array)}");

            array = new int[] { 1, 2, 3, 3, 2 };
            Console.WriteLine($"First duplicate in [ 1, 2, 3, 3, 2] is {FirstDuplicate(array)}");

            array = new int[] { 1, 2, 3};
            Console.WriteLine($"First duplicate in [ 1, 2, 3] is {FirstDuplicate(array)}");
        }
        public static int FirstDuplicate(int[] array)
        {
            int firstDuplicate = -1;
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (list.Contains(array[i]))
                {
                    firstDuplicate = array[i];
                    break;
                }
                else
                {
                    list.Add(array[i]);
                }
            }
            return firstDuplicate;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
