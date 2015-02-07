using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        long[] values = new long[numbers.Length];
        for (int index = 0; index < values.Length; index++)
        {
            values[index] = Convert.ToInt64(numbers[index]);
        }
        for (int index = 0; index < values.Length; index++)
        {
            if (values.Max() == (values.Sum() - values.Max()))   
            {
                Console.WriteLine("Yes, sum={0}", values.Max());
                break;
            }
            else 
            {
                Console.WriteLine("No, diff={0}", Math.Abs(values.Max() - (values.Sum() - values.Max())));
                break;
            }
        }
    }
}
