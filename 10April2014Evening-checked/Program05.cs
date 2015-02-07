using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string wholeSequence = "";

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string currentSequence = "";
            for (int j = 0; j < 8; j++)
            {
                int lastDigit = (number & (1 << j)) >> j;
                currentSequence = lastDigit + currentSequence;
            }
            wholeSequence += currentSequence;
        }
        char[] digits = wholeSequence.ToCharArray();
        for (int i = 0; i < digits.Length; i++)
        {
            int position = 1 + (i * step);
            if (position > digits.Length-1)
            {
                break;
            }
            digits[position] = '1';
            
        }
        string eightBit = "";
        for (int i = 0; i < digits.Length; i++)
        {
            eightBit += digits[i];
            if ((i+1) % 8 == 0)
            {
                Console.WriteLine(Convert.ToInt32(eightBit,2));
                eightBit = "";
            }
        }

    }
}

