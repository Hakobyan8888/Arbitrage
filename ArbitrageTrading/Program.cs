using System;
using System.Threading;
using System.Threading.Tasks;
using BitfinexApi;

namespace ArbitrageTrading
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Value value = new Value();
            while (true)
            {
                ThreadPool.QueueUserWorkItem(value.GetBinancePriceAsync);
                ThreadPool.QueueUserWorkItem(value.GetBitfinexPriceAsync);
                ThreadPool.QueueUserWorkItem(value.GetBitforexPriceAsync);
                Thread.Sleep(2000);
                
                Console.WriteLine($"Binance price is {Price.BinancePrice}");
                Console.WriteLine($"Bitfinex ask price is {Price.BitfinexAskPrice}");
                Console.WriteLine($"Bitfinex bid price is {Price.BitfinexBidPrice}");
                Console.WriteLine($"Bitforex ask price is {Price.BitforexAskPrice}");
                Console.WriteLine($"Bitforex bid price is {Price.BitforexBidPrice}");
            }
        }
    }
}
