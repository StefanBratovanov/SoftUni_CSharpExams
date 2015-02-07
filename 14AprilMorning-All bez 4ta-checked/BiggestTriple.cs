using System;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        int tr1 = 0; int tr2 = 0; int tr3 = 0; int maxThree = 0;
        string[] digits = input.Split(' ');
        int[] numbers = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            numbers[i] = Convert.ToInt32(digits[i]);
        }

        if (numbers.Length == 1)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        else if (numbers.Length == 2)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        else if (numbers.Length == 3)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        } //1,2,3

        else if (numbers.Length == 4) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                tr1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                tr2 = numbers[numbers.Length - 1];

                maxThree = Math.Max(tr2, tr1);
                if (maxThree == tr1)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (maxThree == tr2)
                {
                    Console.WriteLine(numbers[numbers.Length - 1]);
                    break;
                }
                else if (tr1 == tr2)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
            }
        }//4

        else if (numbers.Length == 5) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                tr1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                tr2 = numbers[numbers.Length - 1] + numbers[numbers.Length - 2];

                maxThree = Math.Max(tr1,tr2);
                if (maxThree == tr1)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (maxThree == tr2)
                {
                    Console.WriteLine(numbers[numbers.Length - 2] + " " + numbers[numbers.Length - 1]);
                    break;
                }
                else if (tr1 == tr2)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
            }
        }//5

        else if ((numbers.Length % 3 == 0) && (numbers.Length > 5))
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                tr1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                tr2 = numbers[i + 3] + numbers[i + 4] + numbers[i + 5];
                tr3 = numbers[numbers.Length - 1] + numbers[numbers.Length - 2] + numbers[numbers.Length - 3];

                maxThree = Math.Max(tr1, Math.Max(tr2, tr3));
                if (maxThree == tr1)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (maxThree == tr2)
                {
                    Console.WriteLine(numbers[i + 3] + " " + numbers[i + 4] + " " + numbers[i + 5]);
                    break;
                }
                else if (maxThree == tr3)
                {
                    Console.WriteLine(numbers[numbers.Length - 3] + " " + numbers[numbers.Length - 2] + " " + numbers[numbers.Length - 1]);
                    break;
                }
                else if (tr1 == tr2)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (tr2 == tr3)
                {
                    Console.WriteLine(numbers[i + 3] + " " + numbers[i + 4] + " " + numbers[i + 5]);
                    break;
                }
                else if (tr1 == tr3)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if ((tr1 == tr3) && (tr1 == tr2))
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }

            }
        }

        else if ((numbers.Length % 3 == 2) && (numbers.Length > 5))
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                tr1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                tr2 = numbers[i + 3] + numbers[i + 4] + numbers[i + 5];
                tr3 = numbers[numbers.Length - 1] + numbers[numbers.Length - 2];
                maxThree = Math.Max(tr1, Math.Max(tr2, tr3));

                if (maxThree == tr1)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (maxThree == tr2)
                {
                    Console.WriteLine(numbers[i + 3] + " " + numbers[i + 4] + " " + numbers[i + 5]);
                    break;
                }
                else if (maxThree == tr3)
                {
                    Console.WriteLine(numbers[numbers.Length - 2] + " " + numbers[numbers.Length - 1]);
                    break;
                }

                else if (tr1 == tr2)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (tr2 == tr3)
                {
                    Console.WriteLine(numbers[i + 3] + " " + numbers[i + 4] + " " + numbers[i + 5]);
                    break;
                }
                else if (tr1 == tr3)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if ((tr1 == tr3) && (tr1 == tr2))
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
            }
        }

        else if ((numbers.Length % 3 == 1) && (numbers.Length > 5))
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                tr1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                tr2 = numbers[i + 3] + numbers[i + 4] + numbers[i + 5];
                tr3 = numbers[numbers.Length - 1];

                maxThree = Math.Max(tr1, Math.Max(tr2, tr3));
                if (maxThree == tr1)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (maxThree == tr2)
                {
                    Console.WriteLine(numbers[i + 3] + " " + numbers[i + 4] + " " + numbers[i + 5]);
                    break;
                }
                else if (maxThree == tr3)
                {
                    Console.WriteLine(numbers[numbers.Length - 1]);
                    break;
                }
                else if (tr1 == tr2)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if (tr2 == tr3)
                {
                    Console.WriteLine(numbers[i + 3] + " " + numbers[i + 4] + " " + numbers[i + 5]);
                    break;
                }
                else if (tr1 == tr3)
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
                else if ((tr1 == tr3) && (tr1 == tr2))
                {
                    Console.WriteLine(numbers[i] + " " + numbers[i + 1] + " " + numbers[i + 2]);
                    break;
                }
            }
        }
    }
}

