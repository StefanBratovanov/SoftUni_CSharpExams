using System;
using System.Collections.Generic;
using System.Linq;

class Program02
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        ulong bitrhDayMulty = 1L;

        int birthMonth = int.Parse(input[1]);
        for (int i = 0; i < 3; i++)
        {
            bitrhDayMulty *= ulong.Parse(input[i]);
        }
        if (birthMonth % 2 != 0)
        {
            bitrhDayMulty *= bitrhDayMulty;
        }

        string name = input[3];
        int sumLetters = 0;
        ulong totalSum = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 65 && name[i] <= 90)
            {
                int valueLetter = 2 * (name[i] - 'A' + 1);
                sumLetters += valueLetter;
            }
            else if (name[i] >= 97 && name[i] <= 122)
            {
                int valueLetter = name[i] - 'a' + 1;
                sumLetters += valueLetter;
            }
            else
            {
                int valueLetter = name[i] - '0';
                sumLetters += valueLetter;
            }
        }
        totalSum = (ulong)sumLetters + bitrhDayMulty;
        if (totalSum <= 13)
        {
            Console.WriteLine(totalSum);
        }
        else
        {
            do
            {
                ulong newSum = 0;
                string digits = totalSum.ToString();
                for (int i = 0; i < digits.Length; i++)
                {
                    newSum += (ulong)(digits[i] - '0');
                }
                totalSum = newSum;
            } while (totalSum > 13 || totalSum < 0);
            Console.WriteLine(totalSum);
        }
    }

}

