using System;

class Program04
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int abc = 0;
        int def = 0;
        int ghi = 0;
        bool isSumAndDiff = false;
        for (int i = 100; i <= 777; i++)
        {
            abc = i;
            def = abc + diff;
            ghi = def + diff;
            if (def > 777)
            {
                break;
            }
            string digitString = "" + abc + def + ghi;

            if (digitString.Contains("8") || digitString.Contains("9") || digitString.Contains("0"))
            {
                continue;
            }

            int digitSum = 0;
            for (int j = 0; j < digitString.Length; j++)
            {
                digitSum += Convert.ToInt32(Convert.ToString(digitString[j]));
            }
            if (digitSum == sum)
            {
                Console.WriteLine(digitString);
                isSumAndDiff = true;
            }
        }
        if (!isSumAndDiff)
        {
            Console.WriteLine("No");
        }
    }
}
