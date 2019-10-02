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
                List<decimal> XRP_Ask_Price = new List<decimal>();
                List<decimal> XRP_Bid_Price = new List<decimal>();
                List<decimal> ETH_Ask_Price = new List<decimal>();
                List<decimal> ETH_Bid_Price = new List<decimal>();

                await value.GetBinancePriceAsync();
                //Console.WriteLine($"Binance price XRP is {BinancePrice.XRP_Price}");
                //Console.WriteLine();
                //Console.WriteLine($"Binance price XRP is {BinancePrice.ETH_Price}");
                XRP_Ask_Price.Add(BinancePrice.XRP_Price);
                XRP_Bid_Price.Add(BinancePrice.XRP_Price);
                ETH_Ask_Price.Add(BinancePrice.ETH_Price);
                ETH_Bid_Price.Add(BinancePrice.ETH_Price);
                await value.GetBitfinexPriceAsync();
                //Console.WriteLine($"Bitfinex XRP ask price is {BitfinexPrice.XRP_Ask_Price}");
                //Console.WriteLine($"Bitfinex XRP bid price is {BitfinexPrice.XRP_Bid_Price}");
                //Console.WriteLine();
                //Console.WriteLine($"Bitfinex ETH ask price is {BitfinexPrice.ETH_Ask_Price}");
                //Console.WriteLine($"Bitfinex ETH bid price is {BitfinexPrice.ETH_Bid_Price}");
                XRP_Ask_Price.Add(BitfinexPrice.XRP_Ask_Price);
                XRP_Bid_Price.Add(BitfinexPrice.XRP_Bid_Price);
                ETH_Ask_Price.Add(BitfinexPrice.ETH_Ask_Price);
                ETH_Bid_Price.Add(BitfinexPrice.ETH_Bid_Price);
                await value.GetBitforexPriceAsync();
                //Console.WriteLine($"Bitforex XRP ask price is {BitforexPrice.XRP_Ask_Price}");
                //Console.WriteLine($"Bitforex XRP bid price is {BitforexPrice.XRP_Bid_Price}");
                //Console.WriteLine();
                //Console.WriteLine($"Bitforex ETH ask price is {BitforexPrice.ETH_Ask_Price}");
                //Console.WriteLine($"Bitforex ETH bid price is {BitforexPrice.ETH_Bid_Price}");
                XRP_Ask_Price.Add(BitforexPrice.XRP_Ask_Price);
                XRP_Bid_Price.Add(BitforexPrice.XRP_Bid_Price);
                ETH_Ask_Price.Add(BitforexPrice.ETH_Ask_Price);
                ETH_Bid_Price.Add(BitforexPrice.ETH_Bid_Price);
                Console.WriteLine();

                if (operationChecker.FindMinMax(XRP_Ask_Price, XRP_Bid_Price) == true || operationChecker.FindMinMax(ETH_Ask_Price, ETH_Bid_Price) == true)
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
