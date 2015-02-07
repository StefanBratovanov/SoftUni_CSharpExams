using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < 1; i++)
        {
            string dots = new string('.', n);
            string star = new string('*', 1);
            Console.WriteLine("{0}{1}{0}", dots, star);
        }
        //
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string dots = new string('.', n - i - 1);
            string star = new string('*', 1);
            string midDot = new string('.', 2 * i + 1);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midDot);
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
        //
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string dots = new string('.', i + 1);
            string star = new string('*', 1);
            string midDot = new string('.', 2 * n - 2 * i - 3);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, midDot);
        }
        for (int i = 0; i < 1; i++)
        {
            string dots = new string('.', n / 2);
            string star = new string('*', 1);
            string midDot = new string('.', n / 2 - 1);
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", dots, star, midDot);
        }
        //
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string dots = new string('.', n / 2 - i - 1);
            string star = new string('*', 1);
            string midDot = new string('.',n / 2 - 1);
            string midDotDot = new string('.', 2 * i + 1);
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", dots, star, midDot, midDotDot);
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));

    }
}

