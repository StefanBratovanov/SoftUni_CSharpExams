using System;

class Program02
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 2 * n;
        long oddSum = 0;
        long evenSum = 0;
        long diff = 0;
        long[] numbers = new long[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i += 2)
        {
            oddSum += numbers[i];
        }
        for (int i = 1; i < count; i+=2)
        {
            evenSum += numbers[i];
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum );
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum-evenSum));
        }

    }
}

