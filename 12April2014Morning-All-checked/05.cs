using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string inputBits = "";
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            inputBits += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }
        string resulBits = "";
        int indexToAvoid = 1;
        for (int j = 0; j < inputBits.Length; j++)
        {
            if (j == indexToAvoid)
            {
                indexToAvoid += step;
            }
            else
            {
                resulBits += inputBits[j];
                counter++;
                if (counter == 8)
                {
                    Console.WriteLine(Convert.ToInt32(resulBits, 2));
                    counter = 0;
                    resulBits = "";
                }
            }
        }
        if (resulBits != "")
        {
            string leftBits = resulBits.PadRight(8, '0');
            Console.WriteLine(Convert.ToInt32(leftBits, 2));
        }

    }
}
/*
using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string inputBits = "";
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            inputBits += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }
        string resulBits = "";
        for (int j = 0; j < inputBits.Length; j++)
        {
            if (step == 1)
            {
                Console.WriteLine(0);
                break;
            }
            else
            {
                if ((j % step == 1) || j == 1)
                {
                    continue;
                }
                else
                {
                    resulBits += inputBits[j];
                    counter++;
                    if (counter == 8)
                    {
                        Console.WriteLine(Convert.ToInt32(resulBits, 2));
                        counter = 0;
                        resulBits = "";
                    }
                }
            }

        }
        if (resulBits != "")
        {
            string leftBits = resulBits.PadRight(8, '0');
            Console.WriteLine(Convert.ToInt32(leftBits, 2));
        }

    }
}

*/