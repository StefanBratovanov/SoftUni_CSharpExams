using System;

class FruitMarket
{
    static void Main()
    {
        string inputDay = Console.ReadLine();
        double totalPrice = 0;
        for (int i = 0; i < 3; i++)
        {
            double quantity = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            if (inputDay == "Monday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8); break;
                    case "orange": totalPrice += (quantity * 1.6); break;
                    case "apple": totalPrice += (quantity * 0.86) ; break;
                    case "cucumber": totalPrice += (quantity * 2.75); break;
                    case "tomato": totalPrice += (quantity * 3.20); break;
                }
            }
            if (inputDay == "Tuesday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8) - (quantity * 1.8) * 0.2; break;
                    case "orange": totalPrice += (quantity * 1.6) - (quantity * 1.6) * 0.2; break;
                    case "apple": totalPrice += (quantity * 0.86) - (quantity * 0.86) * 0.2; break;
                    case "cucumber": totalPrice += (quantity * 2.75); break;
                    case "tomato": totalPrice += (quantity * 3.20); break;
                }
            }
            if (inputDay == "Wednesday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8) ; break;
                    case "orange": totalPrice += (quantity * 1.6) ; break;
                    case "apple": totalPrice += (quantity * 0.86) ; break;
                    case "cucumber": totalPrice += (quantity * 2.75) - (quantity * 2.75)* 0.1; break;
                    case "tomato": totalPrice += (quantity * 3.20) - (quantity * 3.20)*0.1; break;
                }
            }
            if (inputDay == "Thursday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8) - (quantity * 1.8)* 0.3 ; break;
                    case "orange": totalPrice += (quantity * 1.6); break;
                    case "apple": totalPrice += (quantity * 0.86); break;
                    case "cucumber": totalPrice += (quantity * 2.75) ; break;
                    case "tomato": totalPrice += (quantity * 3.20) ; break;
                }
            }
            if (inputDay == "Friday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8) - (quantity * 1.8) * 0.1; break;
                    case "orange": totalPrice += (quantity * 1.6) - (quantity * 1.6)*0.1 ; break;
                    case "apple": totalPrice += (quantity * 0.86) - (quantity * 0.86) * 0.1; break;
                    case "cucumber": totalPrice += (quantity * 2.75) - (quantity * 2.75)*0.1; break;
                    case "tomato": totalPrice += (quantity * 3.20) - (quantity * 3.20)*0.1; break;
                }
            }
            if (inputDay == "Saturday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8); break;
                    case "orange": totalPrice += (quantity * 1.6); break;
                    case "apple": totalPrice += (quantity * 0.86); break;
                    case "cucumber": totalPrice += (quantity * 2.75); break;
                    case "tomato": totalPrice += (quantity * 3.20); break;
                }
            }
            if (inputDay == "Sunday")
            {
                switch (product)
                {
                    case "banana": totalPrice += (quantity * 1.8) - (quantity * 1.8) * 0.05; break;
                    case "orange": totalPrice += (quantity * 1.6) - (quantity * 1.6) * 0.05; break;
                    case "apple": totalPrice += (quantity * 0.86) - (quantity * 0.86) * 0.05; break;
                    case "cucumber": totalPrice += (quantity * 2.75) - (quantity * 2.75) * 0.05; break;
                    case "tomato": totalPrice += (quantity * 3.20) - (quantity * 3.20) * 0.05; break;
                }
            }
        }

        Console.WriteLine("{0:f2}", totalPrice);
    }
}

