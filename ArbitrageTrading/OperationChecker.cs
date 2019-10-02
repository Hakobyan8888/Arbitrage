using System;
using System.Collections.Generic;
using System.Linq;

namespace ArbitrageTrading
{
    public class OperationChecker
    {
        public static decimal Profit = 0;

        public bool FindMinMax(List<decimal> askPrice, List<decimal> bidPrice)
        {
            askPrice.Sort();
            bidPrice.OrderByDescending(i => i);

            decimal minAsk = askPrice[0];
            decimal maxBid = bidPrice[0];

            return CheckProfit(minAsk, maxBid);
        }

        public bool CheckProfit(decimal MinAskPrice, decimal MaxBidPrice)
        {
            decimal com = (decimal)0.001;
            var profit = MaxBidPrice - MinAskPrice - (MaxBidPrice * com + MinAskPrice * com);
            if (profit>0)
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
