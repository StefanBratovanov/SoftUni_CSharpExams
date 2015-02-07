using System;

class Program05
{
    static void Main()
    {
        ulong inputBit = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int counterOnes = 0;
        ulong one = 1L;

        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());

            for (int j = 0; j < 64; j++)
            {
                ulong bitAtPositionSieve = sieve & (one << j);
                if (bitAtPositionSieve > 0)
                {
                    inputBit = inputBit & ~(one << j);
                }
            }
        }

        for (int i = 0; i < 64; i++)
        {
            if ((inputBit & (one << i)) > 0)
            {
                counterOnes++;
            }
        }
        Console.WriteLine(counterOnes);
    }
}

