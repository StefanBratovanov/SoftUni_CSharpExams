using System;

class Program01
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        PrintSmalAndBigBox(w1, h1, d1, w2, h2, d2);
        PrintSmalAndBigBox(w1, h1, d1, w2, d2, h2);
        PrintSmalAndBigBox(w1, h1, d1, h2, w2, d2);
        PrintSmalAndBigBox(w1, h1, d1, h2, d2, w2);
        PrintSmalAndBigBox(w1, h1, d1, d2, w2, h2);
        PrintSmalAndBigBox(w1, h1, d1, d2, h2, w2);

        PrintSmalAndBigBox(w2, h2, d2, w1, h1, d1);
        PrintSmalAndBigBox(w2, h2, d2, w1, d1, h1);
        PrintSmalAndBigBox(w2, h2, d2, h1, w1, d1);
        PrintSmalAndBigBox(w2, h2, d2, h1, d1, w1);
        PrintSmalAndBigBox(w2, h2, d2, d1, h1, w1);
        PrintSmalAndBigBox(w2, h2, d2, d1, w1, h1);
    }

    private static void PrintSmalAndBigBox(int ww1, int hh1, int dd1, int ww2, int hh2, int dd2)
    {
        if ((ww1 < ww2) && (hh1 < hh2) && (dd1 < dd2))
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", ww1, hh1, dd1, ww2, hh2, dd2);
        }
    }
}