using System;
using System.Numerics;
class Program02
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        ulong oddResult = 0;
        ulong evenResult = 0;
        int oddcounter = 0;
        int evencounter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddcounter++;
                if (oddcounter % oddJump == 0)
                {
                    oddResult *= (ulong)input[i];
                }
                else
                {
                    oddResult += (ulong)input[i];
                }
            }
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0)
            {
                evencounter++;
                if (evencounter % evenJump == 0)
                {
                    evenResult *= (ulong)input[i];
                }
                else
                {
                    evenResult += (ulong)input[i];
                }

            }
        }
        Console.WriteLine("Odd: {0:X}", oddResult);

        Console.WriteLine("Even: {0:X}", evenResult);
    }
}

