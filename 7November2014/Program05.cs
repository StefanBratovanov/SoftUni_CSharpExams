using System;

class Program05
{
    static void Main()
    {
        // read the four numbers
        uint[] numbers = new uint[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }

        
        uint one = 1u;
        for (int k = 0; ; k++)   //do calculations if input != "End"
        {
            string comandOne = Console.ReadLine();

            if (comandOne != "End")
            {
                string comandTwo = Console.ReadLine();
                string[] splitComandOne = comandOne.Split(' ');
                string[] splitComandTwo = comandTwo.Split(' ');
                uint[] comandOneDigits = new uint[splitComandOne.Length];
                uint[] comandTwoDigits = new uint[splitComandTwo.Length];

                comandOneDigits = Array.ConvertAll(splitComandOne, uint.Parse);
                comandTwoDigits = Array.ConvertAll(splitComandTwo, uint.Parse);

                uint commandOneBitGroup = comandOneDigits[1];
                uint commandTwoBitGroup = comandTwoDigits[1];

                uint numberOneToChange = numbers[comandOneDigits[0]];
                uint numberTwoToChange = numbers[comandTwoDigits[0]];
              
                //one number to change
                if (comandOneDigits[0] == comandTwoDigits[0])
                {
                    uint bitPositionNumOne = commandOneBitGroup * 4;
                    uint bitPositionNumTwo = commandTwoBitGroup * 4;

                    for (int i = 0; i < 4; i++)
                    {
                        uint numOneRightPos = numberOneToChange >> (int)(bitPositionNumOne + i);
                        uint numTwoRightPos = numberTwoToChange >> (int)(bitPositionNumTwo + i);
                        uint bitNumOne = numOneRightPos & one;
                        uint bitNumTwo = numTwoRightPos & one;

                        if (bitNumOne == 0 && bitNumTwo == 1)
                        {
                            numberOneToChange = numberOneToChange | (one << (int)(bitPositionNumOne + i));
                            numberTwoToChange = numberOneToChange & ~(one << (int)(bitPositionNumTwo + i));
                            numberOneToChange = numberTwoToChange;
                            numbers[comandOneDigits[0]] = numberTwoToChange;
                           

                        }
                        else if (bitNumOne == 1 && bitNumTwo == 0)
                        {
                            numberOneToChange = numberOneToChange & ~(one << (int)(bitPositionNumOne + i));
                            numberTwoToChange = numberOneToChange | (one << (int)(bitPositionNumTwo + i));
                            numberOneToChange = numberTwoToChange;
                            numbers[comandOneDigits[0]] = numberTwoToChange;
                          

                        }
                       
                    }

                    //two number to change
                }
                else
                {
                    uint bitPositionNumOne = commandOneBitGroup * 4;
                    uint bitPositionNumTwo = commandTwoBitGroup * 4;

                    for (int i = 0; i < 4; i++)
                    {
                        uint numOneRightPos = numberOneToChange >> (int)(bitPositionNumOne + i);
                        uint numTwoRightPos = numberTwoToChange >> (int)(bitPositionNumTwo + i);
                        uint bitNumOne = numOneRightPos & one;
                        uint bitNumTwo = numTwoRightPos & one;

                        if (bitNumOne == 0 && bitNumTwo == 1)
                        {
                            numberOneToChange = numberOneToChange | (one << (int)(bitPositionNumOne + i));
                            numberTwoToChange = numberTwoToChange & ~(one << (int)(bitPositionNumTwo + i));
                            numbers[comandOneDigits[0]] = numberOneToChange;
                            numbers[comandTwoDigits[0]] = numberTwoToChange;

                        }
                        else if (bitNumOne == 1 && bitNumTwo == 0)
                        {
                            numberOneToChange = numberOneToChange & ~(one << (int)(bitPositionNumOne + i));
                            numberTwoToChange = numberTwoToChange | (one << (int)(bitPositionNumTwo + i));
                            numbers[comandOneDigits[0]] = numberOneToChange;
                            numbers[comandTwoDigits[0]] = numberTwoToChange;

                        }
                      
                    }
                }
                

            }
            else
            {
                break;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }
}










