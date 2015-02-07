using System;

class Program05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string inputBits = "";
        for (int i = 0; i < n; i++)
        {
            inputBits += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }

        string result = "";
        int counter = 0;
        int indexToCatch = 1;

        for (int i = 0; i < inputBits.Length; i++)
        {
            if (i == indexToCatch)
            {
                indexToCatch += step;
                result += inputBits[i];
                counter++;
                if (counter == 8)
                {
                    Console.WriteLine(Convert.ToInt32(result, 2));
                    counter = 0;
                    result = "";
                }
            }
        }
        if (result != "")
        {
            string resultBitsLeft = result.PadRight(8, '0');
            Console.WriteLine(Convert.ToInt32(resultBitsLeft, 2));
        }
    }
}
