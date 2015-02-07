using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < 2; i++)
        {
            string dots = new string('.', (n - 1) / 2);
            string hash = new string('#', n);
            Console.WriteLine("{0}{1}{0}", dots, hash);
        }
        for (int i = 0; i < n - 2 ; i++)
        {
            string dots = new string('.', (n - 1)/2);
            string hash = new string('#', 1);
            string dotsMiddle = new string('.', n - 2);
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, hash,dotsMiddle);
        }
        for (int i = 0; i < 1; i++)
        {
            string hash = new string('#', n/2 + 1);
            string dotsMiddle = new string('.', n - 2);
            Console.WriteLine("{0}{1}{0}", hash, dotsMiddle);
        }
        for (int i = 1; i < n - 1; i++)
        {
            string dots = new string('.', i);
            string hash = new string('#', 1);
            string dotsMiddle = new string('.', (2*n-1) - (2*i+2));
            Console.WriteLine("{0}{1}{2}{1}{0}", dots, hash, dotsMiddle);
        }
        for (int i = 0; i < 1; i++)
        {
            string hash = new string('#', 1);
            string dots = new string('.', n - 1);
            Console.WriteLine("{0}{1}{0}", dots, hash);
        }
    }
}