using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int centerX = n / 2 + 1;
        int centerY = -(n / 2 + 1);

        for (int row = 1; row < n + 1; row++)
        {
            for (int col = 1; col < n + 1; col++)
            {
                if ((col - centerX) * (col - centerX) + ((row + centerY) * (row + centerY)) <= r * r)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

