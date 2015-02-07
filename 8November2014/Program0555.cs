using System;
using System.Collections.Generic;
using System.Linq;

class Program05
{
    static void Main()
    {
        long inputNumber = long.Parse(Console.ReadLine());

        long result = 0L;

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
                    result = inputNumber ^ (1L << bitPosition);
                    inputNumber = result;
                }

                else if (comand == "remove")
                {
                    result = 0L;
                    int bitCount = 0;
                    long currentNumber = inputNumber;

                    while (inputNumber > 0)
                    {
                        inputNumber >>= 1;
                        bitCount++;
                    }

                    if (bitPosition < bitCount)
                    {
                        for (int index = 0; index < (bitCount); index++)
                        {
                            if (index == bitPosition)
                            {
                                continue;
                            }
                            result >>= 1;
                            long bitToMove = (currentNumber >> index) & 1L;
                            result = result | (bitToMove << (bitCount - 2));

                            inputNumber = result;
                        }
                    }
                    else
                    {
                        inputNumber = currentNumber;
                    }
                }

                else if (comand == "insert")
                {
                    long currentNumber = inputNumber;
                    result = 0L;

                    int bitCount = 0;
                    while (inputNumber > 0)
                    {
                        inputNumber >>= 1;
                        bitCount++;
                    }
                    long insertBit = 1L;

                    if (bitPosition < bitCount)
                    {
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
                            long bitToMove = (currentNumber >> index) & 1L;
                            result = result | (bitToMove << bitCount);
                            inputNumber = result;
                        }
                    }
                    else
                    {
                        currentNumber = currentNumber | (1L << bitPosition);
                        inputNumber = currentNumber;
                    }

                }
                else if (comand == "skip")
                {

                }
            }

            else
                break;
        }
        Console.WriteLine(result);
    }
}





