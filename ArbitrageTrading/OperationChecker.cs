using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArbitrageTrading
{
    public class OperationChecker
    {
        public static decimal Profit = 0;
        public static decimal MinAsk { get; set; }
        public static decimal MaxBid { get; set; }
        public static string MinAskName { get; set; }
        public static string MaxBidName { get; set; }

        public bool FindMinMax(Dictionary<string, decimal> askPrice, Dictionary<string,decimal> bidPrice)
        {
            askPrice.OrderBy(i => i);
            bidPrice.OrderByDescending(i => i);

            MinAsk = askPrice.First().Value;
            MaxBid = bidPrice.First().Value;
            MinAskName = askPrice.First().Key;
            MaxBidName = bidPrice.First().Key;

            return CheckProfit();
        }

        public bool CheckProfit()
        {
            decimal com = (decimal)0.001;
            var profit = MaxBid - MinAsk - (MaxBid * com + MinAsk * com);
            if (profit > 0)
            {
                Profit = profit;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
