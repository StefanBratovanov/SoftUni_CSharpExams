using System;

class Program01
{
    static void Main()
    {

        string[] firstClassSrting = Console.ReadLine().Split(' ');
        int[] firstClass = new int[firstClassSrting.Length];
        firstClass = Array.ConvertAll(firstClassSrting, int.Parse);

        string[] bussinessClassSrting = Console.ReadLine().Split(' ');
        int[] bussinessClass = new int[bussinessClassSrting.Length];
        bussinessClass = Array.ConvertAll(bussinessClassSrting, int.Parse);

        string[] economyClassSrting = Console.ReadLine().Split(' ');
        int[] economyClass = new int[economyClassSrting.Length];
        economyClass = Array.ConvertAll(economyClassSrting, int.Parse);

        double incomeFirstClass = Income(firstClass, 7000);
        double incomeBusinessClass = Income(bussinessClass, 3500);
        double incomeEconomyClass = Income(economyClass, 1000);
        int totalIncome = (int)(incomeFirstClass + incomeBusinessClass + incomeEconomyClass);

        int maxIncome = (int)(12 * (7000 + 35) + 28 * 3500 + (28 * 17.5) + 50 * (1000 + 5));

        Console.WriteLine(totalIncome);
        Console.WriteLine(maxIncome - totalIncome);


    }

    private static double Income(int[] flyClass, int p)
    {
        int frequantFlyers = flyClass[1];
        int regularFlyers = flyClass[0] - flyClass[1];
        double income = (regularFlyers * p + frequantFlyers * (30 * p / 100.0) + flyClass[2] * (p / 200.0));
        return income;
    }


}
