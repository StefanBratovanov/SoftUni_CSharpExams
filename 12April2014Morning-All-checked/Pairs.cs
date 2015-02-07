using System;
using System.Linq;
class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] digits = input.Split(' ');
        int[] numbers = new int[digits.Length];
        for (int index = 0; index < digits.Length; index++)
        {
            numbers[index] = Convert.ToInt32(digits[index]);
        }

        int[] pairsSums = new int[numbers.Length / 2];
        for (int index = 0, indexPairs = 0; indexPairs < numbers.Length / 2; indexPairs++, index += 2)
        {
            pairsSums[indexPairs] = numbers[index] + numbers[index + 1];
        }

       if (pairsSums.Max() == pairsSums.Min())
       {
       Console.WriteLine("Yes, value={0}",pairsSums.Max());
       }

       else
       {
           int[] diffs = new int[pairsSums.Length -1];
           for (int index = 0, i = 0; index < diffs.Length; index++, i += 1)
           {
               diffs[index] = Math.Abs(pairsSums[i+1] - pairsSums[i]);
           }
           Console.WriteLine("No, maxdiff={0}", diffs.Max());
       }
    }
}

