using System;
using System.Collections.Generic;
using System.Linq;


class Program04
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());
        int counter = 0;
        bool foundN = false;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int m = 0; m < 5; m++)
                    {
                        for (int n = 0; n < 5; n++)
                        {
                            string look = "" + input[i] + input[j] + input[k] + input[m] + input[n];
                            counter++;

                            if ((counter - 1) == (number))
                            {
                                foundN = true;
                                Console.WriteLine(look);
                            }
                        }
                    }
                }
            }

        }
        if (!foundN)
        {
            Console.WriteLine("No");

        }

    }
}


