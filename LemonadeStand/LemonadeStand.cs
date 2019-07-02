using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeStand
    {
        public string Name { get; set; }
        public decimal TableCost { get; set; }
        public decimal ChairCost { get; set; }
        public decimal SignCost { get; set; }
        public decimal LemonsCostPerCup { get; set; }
        public decimal SugarCostPerCup { get; set; }
        public decimal PricePerCup { get; set; }
        public int NumberOfCupsSold { get; set; }

        public decimal GetTotalRevenue()
        {
            return NumberOfCupsSold * PricePerCup;
        }

        public decimal GetTotalExpenses()
        {
            decimal fixedCosts = TableCost + ChairCost + SignCost;
            decimal variableCosts = (LemonsCostPerCup + SugarCostPerCup) * NumberOfCupsSold;
            return fixedCosts + variableCosts;

        }


    }
}
