using System;


class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //first line
        for (int i = 0; i < 1; i++)
        {
            string dots = new string('.', (3 * n - 1) / 2);
            string star = new string('*', 1);
            Console.WriteLine("{0}{1}{0}", dots, star);
        }
        //top

        for (int i = 0; i < n / 2 + 2; i++)
        {
            string dots = new string('.', (3 * n - 3) / 2 - i);
            string star = new string('*', 1);
            string midDots = new string('.', 1 + i * 2);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midDots);
        }

        //mid  1

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string dots = new string('.', n - 4 - i * 2);
            string star = new string('*', 1);
            string midDots = new string('.', n + 6 + i * 4);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midDots);
        }
        // wing 1
        for (int i = 0; i < 1; i++)
        {
            string star = new string('*', 1);
            string dots = new string('.', (2 * n - 4) / 2);
            string midDots = new string('.', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", star, dots, midDots);
        }

        //wings
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string star = new string('*', 1);
            string dots = new string('.', n - 4 - i * 2);
            string midSmallDots = new string('.', 1 + i * 2);
            string midDots = new string('.', n);
            Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", star, dots, midSmallDots, midDots);
        }

        // bottom 1
        for (int i = 0; i < n - 1; i++)
        {
            string dots = new string('.', n - 1 - i);
            string star = new string('*', 1);
            string midDots = new string('.', n+2*i);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midDots);
        }
        Console.WriteLine(new string('*', 3*n));
    }
}

