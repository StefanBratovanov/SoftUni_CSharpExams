using System;

class Program01
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int consecutiveDays = int.Parse(Console.ReadLine());
        int m = 0;
        int w = 0;
        for (int i = day; i < day + consecutiveDays; i++)
        {
            switch (i % 7)
            {
                case 1: w++; break;
                case 2: m += 2; break;
                case 3:
                    {
                        w++;
                        m++; break;
                    }
                case 4: w += 2; break;
                case 5:
                    {
                        w += 2;
                        m += 2; break;
                    }
                case 6:
                    {
                        w++;
                        m += 2; break;
                    }
                case 7: continue; break;
            }
        }
        int diff = Math.Abs(m - w);
        if (m > w)
        {

            Console.WriteLine("{0} more melons", diff);
        }
        else if (m < w)
        {
            Console.WriteLine("{0} more watermelons", diff);
        }
        else if (m == w)
        {
            Console.WriteLine("Equal amount: {0}", m);
        }
    }
}

