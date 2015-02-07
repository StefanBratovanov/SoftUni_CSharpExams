using System;

class Program055
{
    static void Main()
    {
        ulong intput = ulong.Parse(Console.ReadLine());
        string inputBinary = Convert.ToString((long)intput, 2).PadLeft(64, '0');
        ulong result = 0;
        string resultAsString = "";
        char[] inputAsChar = new char[8];
        inputAsChar = inputBinary.ToCharArray();
        for (int i = 0; i < inputAsChar.Length - 2; i += 3)
        {
            if ((inputAsChar[i] == inputAsChar[i + 1]) && (inputAsChar[i + 1] == inputAsChar[i + 2]) && (inputAsChar[i] == '0'))
            {
                inputAsChar[i] = '1';
                inputAsChar[i + 1] = '1';
                inputAsChar[i + 2] = '1';
            }
            else if ((inputAsChar[i] == inputAsChar[i + 1]) && (inputAsChar[i + 1] == inputAsChar[i + 2]) && (inputAsChar[i] == '1'))
            {
                inputAsChar[i] = '0';
                inputAsChar[i + 1] = '0';
                inputAsChar[i + 2] = '0';
            }
        }
        for (int i = 0; i < inputAsChar.Length; i++)
        {
            Console.Write(inputAsChar[i] + " ");
        }
      /*  char[] reversed = new char[inputAsChar.Length];

        for (int i = 0; i < inputAsChar.Length; i++)
        {
            reversed[i] = inputAsChar[inputAsChar.Length - i - 1];
        }
        for (int i = 0; i < reversed.Length; i++)
        {
            resultAsString += "" + reversed[i];

        }
        Console.WriteLine(resultAsString);*/

    }
}

