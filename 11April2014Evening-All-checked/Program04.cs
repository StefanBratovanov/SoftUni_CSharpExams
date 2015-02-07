using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
class Program04
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int spiralStart = int.Parse(Console.ReadLine());
        int spiralStep = int.Parse(Console.ReadLine());
        int tribunNumber = 0;
        int spiralNum = 0;
        int tempSpiralStep = spiralStep;
        List<int> Trib = new  List<int>();
        int counter = 0;
        int counterMatch = 0;

        if ((spiralStart == firstNum) || (spiralStart == secondNum) || (spiralStart == thirdNum))
        {
            Console.WriteLine(spiralStart);
        }
        else
        {
            for (int i = 0; i <= 250000; i++)
            {
                tribunNumber = firstNum + secondNum + thirdNum;
                
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = tribunNumber;
                if (tribunNumber>1000000)
                {
                    break;
                }
                else
                {
                    Trib.Add(tribunNumber);

                    spiralNum = spiralStart + spiralStep;
                    spiralStart = spiralNum;
                    counter++;
                    if (counter == tempSpiralStep)
                    {
                        spiralStep += tempSpiralStep;
                        counter = 0;
                    }


                    foreach (var item in Trib)
                    {
                        if (item == spiralNum)
                        {
                            counterMatch++;
                            Console.WriteLine(spiralNum);
                            break;
                        }

                    }
                    if (counterMatch > 0)
                    {
                        break;
                    }
                }
                
            }
            if (counterMatch < 1)
            {
                Console.WriteLine("No");
            }
        }


    }
}

