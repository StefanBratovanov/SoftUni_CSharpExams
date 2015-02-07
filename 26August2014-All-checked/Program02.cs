using System;
using System.Collections.Generic;
using System.Linq;

class Program02
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int numberOfJumps = int.Parse(Console.ReadLine());
        int[] numbers = new int[input.Length];


        numbers = Array.ConvertAll(input, int.Parse);

       
        long sumIndex = 0;
        long maxSum = int.MinValue;
       
        for (int i = 0; i < numbers.Length; i++)
        {
            int index = i;
            sumIndex = numbers[index];

            for (int j = 0; j < numberOfJumps; j ++)
            {
                index += numbers[index];
                if (index > numbers.Length - 1)
                {
                    index %= numbers.Length;
                }
                sumIndex += numbers[index];

                if (sumIndex > maxSum)
                {
                    maxSum = sumIndex;
                }
            }
            
        }
        Console.WriteLine("max sum = {0}",maxSum);
    }
}
