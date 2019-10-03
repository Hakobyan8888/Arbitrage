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
                Dictionary<string, decimal> XRP_BTC_Ask_Price = new Dictionary<string, decimal>();
                Dictionary<string, decimal> XRP_BTC_Bid_Price = new Dictionary<string, decimal>();

                Dictionary<string, decimal> ETH_BTC_Ask_Price = new Dictionary<string, decimal>();
                Dictionary<string, decimal> ETH_BTC_Bid_Price = new Dictionary<string, decimal>();

                //Get the values of cryptos in Binance
                await value.GetBinancePriceAsync();
                Console.WriteLine($"Binance price XRP is {BinancePrice.XRP_Price_BTC}");
                Console.WriteLine();
                Console.WriteLine($"Binance price ETH is {BinancePrice.ETH_Price_BTC}");
                XRP_BTC_Ask_Price.Add("BinanceAskPriceXRP", BinancePrice.XRP_Price_BTC);
                XRP_BTC_Bid_Price.Add("BinanceBidPriceXRP", BinancePrice.XRP_Price_BTC);
                ETH_BTC_Ask_Price.Add("BinanceAskPriceETH", BinancePrice.ETH_Price_BTC);
                ETH_BTC_Bid_Price.Add("BinanceBidPriceETH", BinancePrice.ETH_Price_BTC);


                //Get the values of cryptos in Bitfinex
                await value.GetBitfinexPriceAsync();
                Console.WriteLine($"Bitfinex XRP ask price is {BitfinexPrice.XRP_Ask_Price_BTC}");
                Console.WriteLine($"Bitfinex XRP bid price is {BitfinexPrice.XRP_Bid_Price_BTC}");
                Console.WriteLine();
                Console.WriteLine($"Bitfinex ETH ask price is {BitfinexPrice.ETH_Ask_Price_BTC}");
                Console.WriteLine($"Bitfinex ETH bid price is {BitfinexPrice.ETH_Bid_Price_BTC}");
                XRP_BTC_Ask_Price.Add("BitfinexAskPriceXRP", BitfinexPrice.XRP_Ask_Price_BTC);
                XRP_BTC_Bid_Price.Add("BitfinexBidPriceXRP", BitfinexPrice.XRP_Bid_Price_BTC);
                ETH_BTC_Ask_Price.Add("BitfinexAskPriceETH", BitfinexPrice.ETH_Ask_Price_BTC);
                ETH_BTC_Bid_Price.Add("BitfinexBidPriceETH", BitfinexPrice.ETH_Bid_Price_BTC);


                //Get the values of cryptos in Bitforex
                await value.GetBitforexPriceAsync();
                Console.WriteLine($"Bitforex XRP ask price is {BitforexPrice.XRP_Ask_Price_BTC}");
                Console.WriteLine($"Bitforex XRP bid price is {BitforexPrice.XRP_Bid_Price_BTC}");
                Console.WriteLine();
                Console.WriteLine($"Bitforex ETH ask price is {BitforexPrice.ETH_Ask_Price_BTC}");
                Console.WriteLine($"Bitforex ETH bid price is {BitforexPrice.ETH_Bid_Price_BTC}");
                XRP_BTC_Ask_Price.Add("BitforexAskPriceXRP", BitforexPrice.XRP_Ask_Price_BTC);
                XRP_BTC_Bid_Price.Add("BitforexBidPriceXRP", BitforexPrice.XRP_Bid_Price_BTC);
                ETH_BTC_Ask_Price.Add("BitforexAskPriceETH", BitforexPrice.ETH_Ask_Price_BTC);
                ETH_BTC_Bid_Price.Add("BitforexBidPriceETH", BitforexPrice.ETH_Bid_Price_BTC);
                Console.WriteLine();

                if (operationChecker.FindMinMax(XRP_BTC_Ask_Price, XRP_BTC_Bid_Price) == true )
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
                Console.WriteLine($"Minimum ask is in {OperationChecker.MinAskName} {OperationChecker.MinAsk}");
                Console.WriteLine($"Maximum bid is in {OperationChecker.MaxBidName} {OperationChecker.MaxBid}");
                Thread.Sleep(2000);

                Console.WriteLine();
            }
        }
    }
}
