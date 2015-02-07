using System;
using System.Collections.Generic;
using System.Linq;

class Program05
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
       
        int result = 0;

        for (int i = 0; ; i++)
        {
            int bitPosition = 0;
            if (int.TryParse(Console.ReadLine(), out bitPosition))
            {
                string comand = Console.ReadLine();
                if (comand == "quit")
                {
                    break;
                }
                else if (comand == "flip")
                {
                    result = inputNumber ^ (1 << bitPosition);
                    inputNumber = result;
                }
                else if (comand == "remove")
                {
                    int bitCount = 0;
                    while (inputNumber > 0)
                    {
                        inputNumber >>= 1;
                        bitCount++;
                    }
                    for (int index = 0; index < bitCount + 1; index++)
                    {
                        if (index == bitPosition)
                        {
                            continue;
                        }
                        result = result >> 1;
                        int bit = (inputNumber >> index) & 1;
                        result = result | (bit << bitCount - 1);
                        inputNumber = result;
                    }
                }
                else if (comand == "insert")
                {
                    int bitCount = 0;
                    while (inputNumber > 0)
                    {
                        inputNumber >>= 1;
                        bitCount++;
                    }
                    int insertBit = 1;
                    for (int index = 0; index < bitCount; index++)
                    {
                        if (index == bitPosition)
                        {
                            result >>= 1;
                            result = result | (insertBit << bitCount);
                            bitPosition = -1;
                            index--;
                            continue;
                        }
                        result >>= 1;
                        int bit = (inputNumber >> index) & 1;
                        result = result | (bit << bitCount);
                        inputNumber = result;
                    }
                }
                else if (comand == "skip")
                {

                }
            }
            else
                break;
            //int bitPosition = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}

