using System;

class Program05
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int pillPosF = int.Parse(Console.ReadLine());
        int numberRolls = int.Parse(Console.ReadLine());
        int rolledNumber = 0;
        if (pillPosF == 18)
        {
            for (int i = 0; i < numberRolls; i++)
            {
                int pillarBit = (inputNumber >> pillPosF) & 1;
                rolledNumber = inputNumber >> 1;
                int bitAtFRolled = (rolledNumber >> pillPosF) & 1;

                if (bitAtFRolled != pillarBit)
                {
                    if (bitAtFRolled == 0)
                    {
                        rolledNumber = rolledNumber | (1 << pillPosF);

                    }
                    else
                    {
                        rolledNumber = rolledNumber & ~(1 << pillPosF);
                    }
                }
            }
            inputNumber = rolledNumber;
        }
        else
        {
            for (int i = 0; i < numberRolls; i++)
            {
                int pillarBit = (inputNumber >> pillPosF) & 1;
                int firstBitNum = (inputNumber >> 0) & 1;
                int bitAtFplus1 = (inputNumber >> (pillPosF + 1)) & 1;

                rolledNumber = inputNumber >> 1;
                int bitAtFRolled = (rolledNumber >> pillPosF) & 1;

                if (bitAtFRolled != pillarBit)
                {
                    if (bitAtFRolled == 0)
                    {
                        rolledNumber = rolledNumber | (1 << pillPosF);

                    }
                    else
                    {
                        rolledNumber = rolledNumber & ~(1 << pillPosF);
                    }
                }

                int bitat18RolledNum = (rolledNumber >> 18) & 1;
                if (bitat18RolledNum != firstBitNum)
                {
                    if (bitat18RolledNum == 0)
                    {
                        rolledNumber = rolledNumber | (1 << 18);

                    }
                    else
                    {
                        rolledNumber = rolledNumber & ~(1 << 18);
                    }
                }

                int bitAtFminus1RolledNum = (rolledNumber >> (pillPosF - 1)) & 1;
                if (bitAtFminus1RolledNum != bitAtFplus1)
                {
                    if (bitAtFminus1RolledNum == 0)
                    {
                        rolledNumber = rolledNumber | (1 << (pillPosF - 1));

                    }
                    else
                    {
                        rolledNumber = rolledNumber & ~(1 << (pillPosF - 1));
                    }
                }
                inputNumber = rolledNumber;
            }
            
        }
        Console.WriteLine(rolledNumber);
    }
}
