using System;

class Program03
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string space = new string(' ', 1);
        string star = new string('*', 2 * n - 2);
        string empyLine = new string(' ', n-1);

        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", space, star, empyLine);
        for (int i = 0; i < n/2 - 1; i++)
        {
            string Midstar = new string('*', 1);
            string slash = new string('/', 2*n - 2);
            string midEmpyLine = new string(' ', n - 1);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", Midstar, slash, midEmpyLine);
        }

        for (int i = 0; i < 1; i++)
        {
            string Midstar = new string('*', 1);
            string slash = new string('/', 2 * n - 2);
            string midDash = new string('-', n - 1);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", Midstar, slash, midDash);
        }

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string Midstar = new string('*', 1);
            string slash = new string('/', 2 * n - 2);
            string midEmpyLine = new string(' ', n - 1);
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", Midstar, slash, midEmpyLine);
        }

        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", space, star, empyLine);
    }
}
