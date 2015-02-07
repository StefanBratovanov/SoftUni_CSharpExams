using System;
using System.Collections.Generic;
using System.Linq;

class Program04
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        string[] handHouse = Console.ReadLine().Split(' ');
        int houseStrenght = 0;
        int myHand = 0;
      
        int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        for (int i = 0; i < handHouse.Length; i++)
        {
            int valueCard = 0;
            switch (handHouse[i])
            {
                case "2": valueCard = 2; break;
                case "3": valueCard = 3; break;
                case "4": valueCard = 4; break;
                case "5": valueCard = 5; break;
                case "6": valueCard = 6; break;
                case "7": valueCard = 7; break;
                case "8": valueCard = 8; break;
                case "9": valueCard = 9; break;
                case "10": valueCard = 10; break;
                case "J": valueCard = 11; break;
                case "Q": valueCard = 12; break;
                case "K": valueCard = 13; break;
                case "A": valueCard = 14; break;
            }
            houseStrenght += valueCard;
        }
        int totalHands = 0;
        int winningHans = 0;
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                for (int p = 0; p < 13; p++)
                {
                    for (int q = 0; q < 13; q++)
                    {
                        myHand = values[i] + values[j] + values[p] + values[q];
                        totalHands++;
                        if (myHand > houseStrenght)
                        {
                            winningHans++;
                        }
                    }
                }
            }
        }

        double winPercent = winningHans*100  / (double)totalHands;
        double possiblePot = winPercent * 2 * cash/100;
        if (winPercent < 50)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:f2}",possiblePot);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:f2}",possiblePot);
        }
    }
}

