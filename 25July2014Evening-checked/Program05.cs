
using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        long L = long.Parse(Console.ReadLine());
        string Lstring = Convert.ToString(L, 2);
        char[] LChar = new char[Lstring.Length];
        for (int m = 0; m < LChar.Length; m++)
        {
            LChar[m] = Lstring[m];
        }

        int bitsChanged = 0;
        ulong result = 0;

        for (int k = 0; k < numbers.Length; k++)

        {
            string number = "";
            

            number = Convert.ToString(numbers[k], 2);
            int evenBitsToChange = number.Length;

            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 != 0)
                    continue;
                else
                {
                    long searchBit = (L >> i) & 1;
                    if (searchBit == 1)
                    {
                        continue;
                    }
                    else
                    {
                        LChar[LChar.Length -1-i] = '1';
                        bitsChanged++;
                    }
                }
            }
        }
        for (int i = 0; i < LChar.Length; i++)
        {
            Console.Write(LChar[i]);
        }
        Console.WriteLine(bitsChanged);
    }
   /* public static int ChangeEvenBits(int input)
    {
        string number = "";
        int bitsChanged = 0;
        int result = 0;
        number = Convert.ToString(input, 2);
        int evenBitsToChange = number.Length;

        for (int i = 0; i < number.Length; i++)
        {
            if (i % 2 != 0)
                continue;
            else
            {
                int searchBit = (input >> i) & 1;
                if (searchBit == 1)
                {
                    continue;
                }
                else
                {
                    result = input | (1 << i);
                    bitsChanged++;
                }
            }
        }
        return result;
    }*/


}

