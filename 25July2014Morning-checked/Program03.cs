
using System;

class Program03
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());




        for (int i = 0; i < n / 2; i++)
        {

            char letterBegin = Convert.ToChar(('A' + 2 * i));
            string hashes = new string('#', n - 2 - (2 * i));
            char letterNext = Convert.ToChar((letterBegin + 1));
            if (letterNext > 'Z')
            {
                letterNext = Convert.ToChar((letterNext - 26));
            }
            if (letterBegin > 'Z')
            {
                letterBegin = Convert.ToChar((letterBegin - 26));
            }
            string wave = new string('~', i);
            Console.WriteLine("{0}{1}{2}{3}{0}", wave, letterBegin, hashes, letterNext);
        }
        char middleLetter = Convert.ToChar(('A' + n - 1));
        if (middleLetter > 90)
        {
            middleLetter = Convert.ToChar((middleLetter - 26));
        }
        string dashes = new string('-', n / 2);
        Console.WriteLine("{0}{1}{0}", dashes, middleLetter);

        for (int i = 0; i < n / 2; i++)
        {
            char letterBegin = Convert.ToChar((middleLetter + 1 + 2 * i));
            string wave = new string('~', n / 2 - 1 - i);
            string hashes = new string('#', 1 + 2 * i);

            char letterNext = Convert.ToChar((letterBegin + 1));
            if (letterNext > 90)
            {
                letterNext = Convert.ToChar((letterNext - 26));
            }
            if (letterBegin > 90)
            {
                letterBegin = Convert.ToChar((letterBegin - 26));
            }
            Console.WriteLine("{0}{1}{2}{3}{0}", wave, letterBegin, hashes, letterNext);
        }
    }
}



/*          leftLetter = CheckLetter((char)(leftLetter + 2));
            rightLetter = CheckLetter((char)(leftLetter + 1));
        }
    }

    public static char CheckLetter(char letter)
    {
        if (letter > 'Z')
        {
            letter = (char)(letter - 26);
        }
        return letter;
    }*/