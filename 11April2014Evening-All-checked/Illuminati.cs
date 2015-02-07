using System;

using System.Linq;

class Illuminati
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] symbolsChars = input.ToCharArray();
        int counter = 0;
        int sum = 0;
        foreach (char item in symbolsChars)
        {
            
        }

        for (int index = 0; index < symbolsChars.Length; index++)
        {
            if ((symbolsChars[index] == 'a') || (symbolsChars[index] == 'A'))
            {
                counter++;
                sum += 65;
                symbolsChars[index] = '*';
            }
        }
        for (int index = 0; index < symbolsChars.Length; index++)
        {
            if ((symbolsChars[index] == 'e') || (symbolsChars[index] == 'E'))
            {
                counter++;
                sum += 69;
                symbolsChars[index] = '*';
            }
        }
        for (int index = 0; index < symbolsChars.Length; index++)
        {
            if ((symbolsChars[index] == 'i') || (symbolsChars[index] == 'I'))
            {
                counter++;
                sum += 73;
                symbolsChars[index] = '*';
            }
        }
        for (int index = 0; index < symbolsChars.Length; index++)
        {
            if ((symbolsChars[index] == 'o') || (symbolsChars[index] == 'O'))
            {
                counter++;
                sum += 79;
                symbolsChars[index] = '*';
            }
        }
        for (int index = 0; index < symbolsChars.Length; index++)
        {
            if ((symbolsChars[index] == 'u') || (symbolsChars[index] == 'U'))
            {
                counter++;
                sum += 85;
                symbolsChars[index] = '*';
            }
        }
        Console.WriteLine(counter);
        Console.WriteLine(sum);
    }
}

