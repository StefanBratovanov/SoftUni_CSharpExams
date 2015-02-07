using System;

class Program04
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumN = 0;
        sumN += n / 1000 + (n / 100) % 10 + (n / 10) % 10 + n % 10;
        int product = 1;
        int counter = 0;
        for (int i = 1; i < 6; i++)
        {
            for (int j = 1; j < 6; j++)
            {
                for (int k = 1; k < 6; k++)
                {
                    for (int p = 1; p < 6; p++)
                    {
                        for (int l = 1; l < 6; l++)
                        {
                            for (int q = 0; q < 6; q++)
                            {
                                product = i * j * k * p * l * q;

                                if (product == sumN)
                                {
                                    counter++;
                                    string I = i.ToString();
                                    string J = j.ToString();
                                    string K = k.ToString();
                                    string P = p.ToString();
                                    string L = l.ToString();
                                    string Q = q.ToString();

                                    switch (I)
                                    {
                                        case "0": I = "-----"; break;
                                        case "1": I = ".----"; break;
                                        case "2": I = "..---"; break;
                                        case "3": I = "...--"; break;
                                        case "4": I = "....-"; break;
                                        case "5": I = "....."; break;
                                    }
                                    switch (J)
                                    {
                                        case "0": J = "-----"; break;
                                        case "1": J = ".----"; break;
                                        case "2": J = "..---"; break;
                                        case "3": J = "...--"; break;
                                        case "4": J = "....-"; break;
                                        case "5": J = "....."; break;
                                    }
                                    switch (K)
                                    {
                                        case "0": K = "-----"; break;
                                        case "1": K = ".----"; break;
                                        case "2": K = "..---"; break;
                                        case "3": K = "...--"; break;
                                        case "4": K = "....-"; break;
                                        case "5": K = "....."; break;
                                    }
                                    switch (P)
                                    {
                                        case "0": P = "-----"; break;
                                        case "1": P = ".----"; break;
                                        case "2": P = "..---"; break;
                                        case "3": P = "...--"; break;
                                        case "4": P = "....-"; break;
                                        case "5": P = "....."; break;
                                    }
                                    switch (L)
                                    {
                                        case "0": L = "-----"; break;
                                        case "1": L = ".----"; break;
                                        case "2": L = "..---"; break;
                                        case "3": L = "...--"; break;
                                        case "4": L = "....-"; break;
                                        case "5": L = "....."; break;
                                    }
                                    switch (Q)
                                    {
                                        case "0": Q = "-----"; break;
                                        case "1": Q = ".----"; break;
                                        case "2": Q = "..---"; break;
                                        case "3": Q = "...--"; break;
                                        case "4": Q = "....-"; break;
                                        case "5": Q = "....."; break;
                                    }
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", I, J, K, P, L, Q);
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }

    }
}

/*using System;

public class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int nSum = 0;
        while (n > 0)
        {
            nSum += n % 10;
            n /= 10;
        }

        string[] morseCodes = { "-----", ".----", "..---", "...--", "....-", "....." };
        bool foundAnswer = false;
        for (int i0 = 0; i0 <= 5; i0++)
        {
            for (int i1 = 0; i1 <= 5; i1++)
            {
                for (int i2 = 0; i2 <= 5; i2++)
                {
                    for (int i3 = 0; i3 <= 5; i3++)
                    {
                        for (int i4 = 0; i4 <= 5; i4++)
                        {
                            for (int i5 = 0; i5 <= 5; i5++)
                            {
                                int morseProduct = i0 * i1 * i2 * i3 * i4 * i5;
                                if (morseProduct == nSum)
                                {
                                    string morseNumber =
                                        morseCodes[i0] + "|" +
                                        morseCodes[i1] + "|" +
                                        morseCodes[i2] + "|" +
                                        morseCodes[i3] + "|" +
                                        morseCodes[i4] + "|" +
                                        morseCodes[i5] + "|";
                                    foundAnswer = true;
                                    Console.WriteLine(morseNumber);
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!foundAnswer)
        {
            Console.WriteLine("No");
        }
    }
}
*/