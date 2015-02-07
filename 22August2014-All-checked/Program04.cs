using System;
using System.Collections.Generic;
using System.Linq;

class Program04
{
    static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int row = 0; row < boardSize; row++)
        {
            for (int column = 0; column < boardSize; column++)
            {
                if (column + distance + 1 < boardSize)
                {
                    Console.WriteLine("{0} - {1}", (char)(row + 97) + "" + (column + 1), (char)(row + 97) + "" + (column + distance + 2));
                    Console.WriteLine("{1} - {0}", (char)(row + 97) + "" + (column + 1), (char)(row + 97) + "" + (column + distance + 2));

                   
                    counter +=2;
                }
                if (row + distance + 1 < boardSize)
                {
                    Console.WriteLine("{0} - {1}", (char)(row + 97) + "" + (column + 1), (char)(row + 97 + distance + 1) + "" + (column + 1));
                    Console.WriteLine("{1} - {0}", (char)(row + 97) + "" + (column + 1), (char)(row + 97 + distance + 1) + "" + (column + 1));
                    counter += 2;
                }
                if ((column + distance + 1 < boardSize)&&(row + distance + 1 < boardSize))
                {
                    Console.WriteLine("{0} - {1}", (char)(row + 97) + "" + (column + 1), (char)(row + 97 + distance + 1) + "" + (column + distance + 2));
                    Console.WriteLine("{1} - {0}", (char)(row + 97) + "" + (column + 1), (char)(row + 97 + distance + 1) + "" + (column + distance + 2));
                    counter += 2;

                    Console.WriteLine("{0} - {1}", (char)(row + 97) + "" + (column + distance + 2), (char)(row + 97 + distance + 1) + "" + (column + 1));
                    Console.WriteLine("{1} - {0}", (char)(row + 97) + "" + (column + distance + 2), (char)(row + 97 + distance + 1) + "" + (column + 1));
                    counter += 2;
                }
            }
            
        }
        if (counter == 0)
        {
            Console.WriteLine("No valid positions");
        }

    }
}

