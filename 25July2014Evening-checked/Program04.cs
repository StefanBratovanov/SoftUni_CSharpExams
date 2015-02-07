using System;

class Program04
{
    static void Main()
    {
        string wordA = Console.ReadLine().ToLower();
        string wordB = Console.ReadLine().ToLower();
        int diff = int.Parse(Console.ReadLine());
        string aLeft = "";
        string aRight = "";
        string bLeft = "";
        string bRight = "";
        long sumAleft = 0;
        long sumAright = 0;
        long sumBleft = 0;
        long sumBright = 0;
        long nakovs = 0;
        bool foundMatch = false;

        for (int i = 1; i < wordA.Length; i++)
        {
            aLeft = wordA.Substring(0, i);
            sumAleft = CalculateSumChars(aLeft);

            aRight = wordA.Substring(i);
            sumAright = CalculateSumChars(aRight);

            for (int j = 1; j < wordB.Length; j++)
            {
                bLeft = wordB.Substring(0, j);
                sumBleft = CalculateSumChars(bLeft);

                bRight = wordB.Substring(j);
                sumBright = CalculateSumChars(bRight);
                nakovs = Math.Abs(sumAleft * sumBright - sumAright * sumBleft);
                if (nakovs <= diff)
                {
                    foundMatch = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", aLeft, aRight, bLeft, bRight, nakovs);
                }
            }
        }
        if (!foundMatch)
        {
            Console.WriteLine("No");
        }
    }

    public static long CalculateSumChars(string input)
    {
        long sumChars = 0;
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            sumChars += chars[i];
        }
        return sumChars;
    }
}

