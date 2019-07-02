using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStand stand = new LemonadeStand();

            Console.WriteLine("What is the name of this lemonade stand?");
            stand.Name = Console.ReadLine();
         

            Console.WriteLine("How much will your table cost?");
            string tableCostResponse = Console.ReadLine();
            stand.TableCost = decimal.Parse(tableCostResponse);

            Console.WriteLine("How much will your chair cost?");
            string chairCostResponse = Console.ReadLine();
            stand.ChairCost = decimal.Parse(chairCostResponse);

            Console.WriteLine("How much will your sign cost?");
            string signCostResponse = Console.ReadLine();
            stand.SignCost = decimal.Parse(signCostResponse);

            Console.WriteLine("How much will the lemon cost per cup?");
            string lemonCostResponse = Console.ReadLine();
            stand.LemonsCostPerCup = decimal.Parse(lemonCostResponse);
                
            Console.WriteLine("What will be the price of a cup?");
            string cupPriceResponse = Console.ReadLine();
            stand.PricePerCup = decimal.Parse(cupPriceResponse);



        }
    }
}
