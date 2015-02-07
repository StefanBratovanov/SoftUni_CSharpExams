using System;

    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < 2; i++)
            {
                string dots = new string('.', n/2  );
                string star = new string('*', 1);
                Console.WriteLine("{0}{1}{0}", dots, star);
            }
            for (int i = n/2 - 1, j = 1; i > 0; i--, j+=2)
            {
                string dots = new string('.', i);
                string star = new string('*', 1);
                string dotsMinddle = new string('.', j );
                Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, dotsMinddle);
            }
            string starsOnly = new string('*', n);
            Console.WriteLine(starsOnly);

            for (int i = 0; i < n/2-1; i++)
            {
                string dots = new string('.', n / 4);
                string star = new string('*', 1);
                string dotsMinddle = new string('.', n -2 - n/4 - n/4);

                Console.WriteLine("{0}{1}{2}{1}{0}", dots, star, dotsMinddle);
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - n / 4 - n / 4));

        }
    }

