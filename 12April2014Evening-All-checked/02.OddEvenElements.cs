using System;
using System.Collections.Generic;
using System.Linq;


class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');
        decimal[] digitsArr = new decimal[splitInput.Length];
        for (int index = 0; index < splitInput.Length; index++)
        {
            digitsArr[index] = decimal.Parse(splitInput[index]);
        }
        decimal oddMax = decimal.MinValue; decimal oddMin = decimal.MaxValue; decimal oddSum = 0; decimal evenMax = decimal.MinValue; decimal evenMin = decimal.MaxValue; decimal evenSum = 0;

        if (input.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (digitsArr.Length == 1)
        {

            oddMax = Math.Max(digitsArr[0], oddMax);
            oddMin = Math.Min(digitsArr[0], oddMin);

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddMin, (double)oddMin, (double)oddMax);
        }
        else
        {

            for (int i = 0; i < digitsArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddMax = Math.Max(digitsArr[i], oddMax);
                    oddMin = Math.Min(digitsArr[i], oddMin);
                    oddSum += digitsArr[i];
                }
                else
                {
                    evenMax = Math.Max(digitsArr[i], evenMax);
                    evenMin = Math.Min(digitsArr[i], evenMin);
                    evenSum += digitsArr[i];
                }
            }


            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax,
                (double)evenSum, (double)evenMin, (double)evenMax);
        }

    }
}

