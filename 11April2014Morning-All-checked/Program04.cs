using System;

class Program04
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());

        char[] letters = { 'k', 'n', 'p', 's' };
        int[] numbers = { 1, 4, 5, 3 };
        int sumOne = 0;
        int sumTwo = 0;
        int magicWeight = 0;
        int counter = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int p = 0; p < 4; p++)
                {
                    for (int q = 0; q < 4; q++)
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = 0; n < 4; n++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    for (int l = 0; l < 4; l++)
                                    {
                                        sumOne = (int)numbers[i] + (int)numbers[j] + (int)numbers[p] + (int)numbers[q];
                                        sumTwo = (int)numbers[m] + (int)numbers[n]  + (int)numbers[k] + (int)numbers[l];

                                        if (Math.Abs(sumOne - sumTwo) == diff)
                                        {
                                            counter++;
                                            Console.WriteLine("" + letters[i] + letters[j] + letters[p] + letters[q]
                                               + letters[m] + letters[n] + letters[k] + letters[l]);

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter <1)
        {
            Console.WriteLine("No");
        }
    }
}
/*
using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };

        int resultsCount = 0;
        for (int d1 = 0; d1 < letters.Length; d1++)
        {
            for (int d2 = 0; d2 < letters.Length; d2++)
            {
                for (int d3 = 0; d3 < letters.Length; d3++)
                {
                    for (int d4 = 0; d4 < letters.Length; d4++)
                    {
                        string left = "" + letters[d1] + letters[d2] + letters[d3] + letters[d4];
                        int weightLeft = CalcWeight(left);
                        for (int d5 = 0; d5 < letters.Length; d5++)
                        {
                            for (int d6 = 0; d6 < letters.Length; d6++)
                            {
                                for (int d7 = 0; d7 < letters.Length; d7++)
                                {
                                    for (int d8 = 0; d8 < letters.Length; d8++)
                                    {
                                        string right = "" + letters[d5] + letters[d6] + letters[d7] + letters[d8];
                                        int weightRight = CalcWeight(right);
                                        if (Math.Abs(weightLeft - weightRight) == diff)
                                        {
                                            Console.WriteLine(left + right);
                                            resultsCount++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcWeight(string str)
    {
        int weight = 0;
        foreach (var ch in str)
        {
            switch (ch)
            {
                case 's': weight += 3; break;
                case 'n': weight += 4; break;
                case 'k': weight += 1; break;
                case 'p': weight += 5; break;
            }
        }
        return weight;
    }
}
*/