using System;
using System.Collections.Generic;
using System.Linq;

class Program05
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        string numberBit = Convert.ToString(n, 2).PadLeft(8, '0');
        uint friens = 0;
        uint alone = 0;
        string friendsBits = "0";
        string aloneBits = "0";

        char bitToBegin = numberBit[0];
        int count = 1;

        for (int i = 1; i < numberBit.Length; i++)
        {
            if (bitToBegin == numberBit[i])
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    friendsBits += new string(bitToBegin, count);
                }
                else
                {
                    aloneBits += bitToBegin;
                }
                count = 1;
            }
            bitToBegin = numberBit[i];
        }
        if (count > 1)
        {
            friendsBits += new string(bitToBegin, count);
        }
        else
        {
            aloneBits += bitToBegin;
        }
        count = 1;
        Console.WriteLine(Convert.ToUInt32(friendsBits,2));
        Console.WriteLine(Convert.ToUInt32(aloneBits, 2));
    }
}

