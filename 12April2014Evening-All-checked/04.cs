using System;
using System.Collections.Generic;
using System.Linq;

class Program04
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        long weight = 0;
        int counter = 0;

        char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    for (int m = 0; m < letters.Length; m++)
                    {
                        for (int n = 0; n < letters.Length; n++)
                        {
                            string fiveLetterSequence = "" + letters[i] + letters[j] + letters[k] + letters[m] + letters[n];
                            char[] fixedSeq = fiveLetterSequence.Distinct().ToArray();
                            for (int p = 0; p < fixedSeq.Length; p++)
                            {
                                
                                if (fixedSeq[p] == 'a')
                                {
                                   
                                    weight += (p + 1)*5;
                                }
                                if (fixedSeq[p] == 'b')
                                {

                                    weight += (p + 1) * -12;
                                }
                                if (fixedSeq[p] == 'c')
                                {

                                    weight += (p + 1) * 47;
                                }
                                if (fixedSeq[p] == 'd')
                                {

                                    weight += (p + 1) * 7;
                                }
                                if (fixedSeq[p] == 'e')
                                {

                                    weight += (p + 1) * -32;
                                }
                              
                                
                            }
                            if (weight >= start && weight <= end)
                            {
                                counter++;
                                Console.Write(fiveLetterSequence + " ");
                                weight = 0;
                            }
                            else
                            {
                                weight = 0;
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

