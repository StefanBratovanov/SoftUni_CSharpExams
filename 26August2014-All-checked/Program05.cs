using System;
using System.Collections.Generic;
using System.Linq;

class Program05
{
    static void Main()
    {
        int countX = 0;
        int firstN = int.Parse(Console.ReadLine());
        int secondN = int.Parse(Console.ReadLine());
        for (int i = 0; i < 6; i++)
        {
            
            int thirdN = int.Parse(Console.ReadLine());
            
            for (int j = 0; j < 30; j++)
            {
                int firstNRightJ = firstN >> j;
                int secondNRightJ = secondN >> j;
                int thirdNRightJ = thirdN >> j;

                int firstNRightJ1 = firstN >> (j + 1);
                int secondNRightJ1 = secondN >> (j + 1);
                int thirdNRightJ1 = thirdN >> (j + 1);

                int firstNRightJ2 = firstN >> (j + 2);
                int secondNRightJ2 = secondN >> (j + 2);
                int thirdNRightJ2 = thirdN >> (j + 2);


                if (((firstNRightJ & 1) == 1) && ((secondNRightJ & 1) == 0) && ((thirdNRightJ & 1) == 1) &&
                    ((firstNRightJ1 & 1) == 0) && ((secondNRightJ1 & 1) == 1) && ((thirdNRightJ1 & 1) == 0) &&
                   ((firstNRightJ2 & 1) == 1) && ((secondNRightJ2 & 1) == 0) && ((thirdNRightJ2 & 1) == 1))
                {
                    countX ++;
                }

            }
            firstN = secondN;
            secondN = thirdN;
        }
        Console.WriteLine(countX);
    }
}

