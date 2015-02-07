using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < 1; i++)
        {
            string dots = new string('.', n);
            string stars = new string('*', n);
            Console.WriteLine("{0}{1}{0}", dots, stars);
        }
        //top
        for (int i = 0; i < n / 2; i++)
        {
            string dots = new string('.', n - 2 - i * 2);
            string star = new string('*', 1);
            string midDots = new string('.', n + 2 + i * 4);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midDots);
        }
        //wings1
        for (int i = 0; i < 1; i++)
        {
            string star = new string('*', 1);
            string dots = new string('.', n - 2);
            string midDots = new string('.', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", star, dots, midDots);
        }

        //wings2
        for (int i = 0; i < n / 2-1; i++)
        {
            string star = new string('*', 1);
            string dots = new string('.', n - 4 - i * 2);
            string midMidDots = new string('.', 1 + i * 2);
            string midDots = new string('.', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", star, dots, midMidDots, midDots);
        }

        // bottom1
        for (int i = 0; i < n-1; i++)
        {
             string dots = new string('.', n - 1- i*1);
             string star = new string('*', 1);
             string midMidDots = new string('.', n + i * 2);
             Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midMidDots);
        }
        Console.WriteLine(new string ('*',3*n));


    }
}

