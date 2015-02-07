using System;

class Program04
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isAnum = false;

        for (int i = 555; i <= 999; i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi > 999)
            {
                break;
            }
            string wholeNumber = "" + abc + def + ghi;

            if (wholeNumber.Contains("0") || wholeNumber.Contains("1")
             || wholeNumber.Contains("2") || wholeNumber.Contains("3")
                || wholeNumber.Contains("4"))
            {
                continue;
            }
            int targetSum = 0;
            for (int j = 0; j < wholeNumber.Length; j++)
            {
                targetSum += Convert.ToInt32(Convert.ToString(wholeNumber[j]));
            }

            if (targetSum == sum)
            {
                Console.WriteLine(wholeNumber);
                isAnum = true;
            }
        }
        if (!isAnum)
        {
            Console.WriteLine("No");
        }

    }
}
