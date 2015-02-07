using System;
using System.Collections.Generic;
using System.Linq;

class Program04
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        char[] inputAsChars = input.ToCharArray();
        int letSum = 0;
        int counter = 0;
        for (int i = 0; i < inputAsChars.Length; i++)
        {
            inputAsChars[i] = (char)(inputAsChars[i] - 96);
            letSum += inputAsChars[i];
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int m = 0; m < 10; m++)
                {
                    for (int n = 0; n < 10; n++)
                    {
                        for (int p = 0; p < 10; p++)
                        {
                            for (int q = 0; q < 10; q++)
                            {
                                if ((i * j * m == n * p * q) && (i * j * m == letSum) && (n * p * q == letSum))
                                {
                                    Console.WriteLine("" + i + j + m + "-" + "" + n + p + q);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter<1)
        {
            Console.WriteLine("No");
        }
    }
}

