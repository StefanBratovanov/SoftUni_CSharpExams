using System;

class Program02
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sumOne = 0L;
        long sumTwo = 0L;
        long diff = 0L;

        for (int i = 0; i < n; i++)
        {
            sumOne += long.Parse(Console.ReadLine());
        }
        for (int i = n; i < 2*n; i++)
        {
            sumTwo += long.Parse(Console.ReadLine());
        }
        if (sumOne==sumTwo)
        {
            Console.WriteLine("Yes, sum={0}",sumOne);
        }
        else 
        {
            diff = Math.Abs(sumOne - sumTwo);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}

