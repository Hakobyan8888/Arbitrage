using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace ArbitrageTrading
{
    class Program
    {
        static async Task Main(string[] args)
        {
        int count = 0;
        OperationChecker operationChecker = new OperationChecker();
            Stopwatch stopwatch = new Stopwatch();
            Value value = new Value();
            while (true)
            {
                List<decimal> askPrice = new List<decimal>();
                List<decimal> bidPrice = new List<decimal>();
                await value.GetBinancePriceAsync();
                Console.WriteLine($"Binance price is {Price.BinancePrice}");
                askPrice.Add(Price.BinancePrice);
                bidPrice.Add(Price.BinancePrice);
                await value.GetBitfinexPriceAsync();
                Console.WriteLine($"Bitfinex ask price is {Price.BitfinexAskPrice}");
                Console.WriteLine($"Bitfinex bid price is {Price.BitfinexBidPrice}");
                askPrice.Add(Price.BitfinexAskPrice);
                bidPrice.Add(Price.BitfinexBidPrice);
                await value.GetBitforexPriceAsync();
                Console.WriteLine($"Bitforex ask price is {Price.BitforexAskPrice}");
                Console.WriteLine($"Bitforex bid price is {Price.BitforexBidPrice}");
                askPrice.Add(Price.BitforexAskPrice);
                bidPrice.Add(Price.BitforexBidPrice);
                Console.WriteLine();

                if (operationChecker.FindMinMax(askPrice, bidPrice) == true)
                {
                    Console.WriteLine("true");
                    Console.WriteLine(OperationChecker.Profit);
                    count++;
                    
                    Thread.Sleep(10000);
                }
                else
                {
                    Console.WriteLine("false");
                }
                Console.WriteLine(count);
                Thread.Sleep(2000);

                Console.WriteLine();
            }
        }
    }
}
