using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dotss = new string('.', n - 1);
        string stars = new string('*', 1);
        Console.WriteLine("{0}{1}{0}", dotss, stars);
        for (int i = 0; i < n - 1; i++)
        {
            string dots = new string('.', n - 2 - i);
            string star = new string('*', 1);
            string middleDots = new string('.', 2 * i + 1);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, middleDots);
        }
        Console.WriteLine("{0}", new string('*', 2 * n - 1));

        for (int i = 0; i < n / 4; i++)
        {
            string dots = new string('.', 2 * n - 3);
            string star = new string('*', 1);
            Console.WriteLine("{0}{1}{0}", star, dots);
        }

        for (int i = 0; i < n / 2; i++)
        {
            string star = new string('*', 1);
            string dots = new string('.', n/2);
            string middleStar = new string('*', n-3);
            Console.WriteLine("{0}{1}{2}{1}{0}", star, dots, middleStar);
        }

        for (int i = 0; i < n / 4; i++)
        {
            string dots = new string('.', 2 * n - 3);
            string star = new string('*', 1);
            Console.WriteLine("{0}{1}{0}", star, dots);
        }

        Console.WriteLine("{0}", new string('*', 2 * n - 1));

    }
}

