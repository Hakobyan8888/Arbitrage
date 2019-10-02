using Binance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArbitrageTrading
{
    class Value
    {
        public async Task GetBinancePriceAsync()
        {
            var api = new BinanceApi();
            var price = await api.GetExchangeRateAsync(Asset.XRP, Asset.BTC);
            Price.BinancePrice = price;
            //Console.WriteLine($"Binance is {price}");
        }

        public async Task GetBitfinexPriceAsync()
        {
            BitfinexApi.Assets BaseCurrency = new BitfinexApi.Assets();
            BitfinexApi.Assets QuoteCurrency = new BitfinexApi.Assets();

            BitfinexApi.Tickers tickers = new BitfinexApi.Tickers();
            decimal askPrice = await tickers.Market(BaseCurrency.XRP, QuoteCurrency.BTC, "ask");
            decimal bidPrice = await tickers.Market(BaseCurrency.XRP, QuoteCurrency.BTC, "bid");

            Price.BitfinexAskPrice = askPrice;
            Price.BitfinexBidPrice = bidPrice;
        }

        public async Task GetBitforexPriceAsync()
        {
            decimal askPrice;
            decimal bidPrice;
            BitforexAPI.Assets assets = new BitforexAPI.Assets();
            BitforexAPI.BitforexClient bitforexClient = new BitforexAPI.BitforexClient();
            try
            {
                askPrice = await bitforexClient.MarketAsync(assets.XRP, assets.BTC, "ask");
                bidPrice = await bitforexClient.MarketAsync(assets.XRP, assets.BTC, "bid");
                Price.BitforexAskPrice = askPrice;
                Price.BitforexBidPrice = bidPrice;
            }
            catch
            {
                askPrice = -1;
                bidPrice = -1;
            }
            
            //Console.WriteLine($"Bitforex ask is {askPrice}");
            //Console.WriteLine($"Bitforex bid is {bidPrice}");
        }

    }
}
