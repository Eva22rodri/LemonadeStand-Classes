using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of this lemonade stand?");
            string lemonadeStandName = Console.ReadLine();
         

            Console.WriteLine("How much will your table cost?");
            string tableCostResponse = Console.ReadLine();
            decimal lemonadeStandTableCost = decimal.Parse(tableCostResponse);

            Console.WriteLine("How much will the lemon cost per cup?");
            string lemonCostResponse = Console.ReadLine();
            decimal lemonadeStandLemonCostPerCup = decimal.Parse(lemonCostResponse);
                
            Console.WriteLine("What will be the price of a cup?");
            string cupPriceResponse = Console.ReadLine();
            decimal lemonadeStandPricePerCup = decimal.Parse(cupPriceResponse);

            Console.WriteLine("Will you open a second lemonade stand?");
            string secondStandResponse = Console.ReadLine();

            if (secondStandResponse == "yes")
            {
                //Does something
            }
        }
    }
}
