using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program02
{
    static void Main()
    {
        string[] input = (Console.ReadLine()).Split(' ');
        int step = int.Parse(Console.ReadLine());

        int firstNumber = int.Parse(input[0]);
        int equalCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            int num = int.Parse(input[i]);
            if (num == firstNumber)
            {
                equalCount++;
            }
            else
            {
                for (int j = 0; j < equalCount % step; j++)
                {
                    Console.Write(firstNumber + " ");
                }
                equalCount = 1;
            }
            
            firstNumber = num;
        }
       for (int j = 0; j < equalCount % step; j++)
        {
            Console.Write(firstNumber + " ");
        }
        equalCount = 1;

    }

}


