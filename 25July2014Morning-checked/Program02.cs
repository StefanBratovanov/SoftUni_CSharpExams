using System;
using System.Collections.Generic;
using System.Linq;
class Program02
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long lettersSum = 0L;
        long digitsSum = 0L;
        long symbolsSum = 0L;

   
        string allStrings = "";
        for (int i = 0; i < n; i++)
        {
            allStrings += Console.ReadLine();
        }
        string[] letters = allStrings.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        string onlyLetters = string.Join("", letters).ToUpper();

        for (int i = 0; i < onlyLetters.Length; i++)
        {
            char currentCh = onlyLetters[i];
            if (currentCh >= 'A' && currentCh <= 'Z')
            {
                lettersSum += (currentCh - 'A' + 1) * 10;
            }
            else if (currentCh >= '0' && currentCh <= '9')
            {
                digitsSum += (currentCh - '0' )* 20;
            }
            else
            {
                symbolsSum += 200;
            }
        }
        Console.WriteLine(lettersSum);
        Console.WriteLine(digitsSum);
        Console.WriteLine(symbolsSum);
    }
}

