using System;

class Program06
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        // n numbers --> connect them in binary form
        string allBitsJoined = "";

        for (int i = 0; i < n; i++)
        {
            string momentString = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            allBitsJoined += momentString;
            momentString = "";
        }
       
        char[] charDigits = allBitsJoined.ToCharArray();
        for (int i = 0; i < allBitsJoined.Length; i++)
        {
            int position = 1 + i * step;
            if (position > allBitsJoined.Length - 1)
            {
                break;
            }
            if (charDigits[position] == '0')
            {
                charDigits[position] = '1';
            }
            else
            {
                charDigits[position] = '1';
            }
        }
        string eigtBitsString = "";
        for (int i = 0; i < charDigits.Length; i++)
        {
            eigtBitsString += charDigits[i];
            if ((i + 1) % 8 == 0)
            {
                int result = Convert.ToInt32(eigtBitsString, 2);
                Console.WriteLine(result);
                eigtBitsString = "";
            }
        }
    }
}

