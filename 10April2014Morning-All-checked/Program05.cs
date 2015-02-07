using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string allBitsJoined = "";


        for (int i = 0; i < n; i++)
        {
            string currentString = "";
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int lastBit = (number & (1 << j)) >> j;
                currentString = lastBit + currentString;
            }
            allBitsJoined += currentString;
        }
        char[] digits = allBitsJoined.ToCharArray();
        for (int i = 0; i < digits.Length; i++)
        {
            int position = i * step;
            if (position > digits.Length -1)
            {
                break;
            }
            if (digits[position] == '1')
            {
                digits[position] = '0';
            }
            else 
            {
                digits[position] = '1';
            }
        }

        string eightDigitString = "";
        for (int i = 0; i < digits.Length; i++)
        {
            eightDigitString += digits[i];
            if ((i + 1) % 8 == 0)
            {
                int result = Convert.ToInt32(eightDigitString, 2);
                Console.WriteLine(result);
                eightDigitString = "";
            }
        }
    }
}

