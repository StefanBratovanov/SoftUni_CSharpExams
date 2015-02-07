using System;

class Program055
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        ulong mask = 7;
        for (int i = 61; i >= 0; i--)
        {
      
            ulong check3Bits = mask << i;
            check3Bits = check3Bits & input;
            check3Bits = check3Bits >> i;

            if ((check3Bits == 0) || (check3Bits == 7))
            {
                input = input ^ (mask << i);
                i -= 2;
            }
        }
        Console.WriteLine(input);
    }
}

