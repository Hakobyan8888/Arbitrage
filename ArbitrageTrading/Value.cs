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
            try
            {
                BinancePrice.XRP_Price = await api.GetExchangeRateAsync(Asset.XRP, Asset.BTC);
                BinancePrice.ETH_Price = await api.GetExchangeRateAsync(Asset.ETH, Asset.BTC);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task GetBitfinexPriceAsync()
        {
            BitfinexApi.Assets BaseCurrency = new BitfinexApi.Assets();
            BitfinexApi.Assets QuoteCurrency = new BitfinexApi.Assets();

            BitfinexApi.Tickers tickers = new BitfinexApi.Tickers();
            try
            {
                BitfinexPrice.XRP_Ask_Price = await tickers.Market(BaseCurrency.XRP, QuoteCurrency.BTC, "ask");
                BitfinexPrice.XRP_Bid_Price = await tickers.Market(BaseCurrency.XRP, QuoteCurrency.BTC, "bid");

                BitfinexPrice.ETH_Ask_Price = await tickers.Market(BaseCurrency.ETH, QuoteCurrency.BTC, "ask");
                BitfinexPrice.ETH_Bid_Price = await tickers.Market(BaseCurrency.ETH, QuoteCurrency.BTC, "bid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task GetBitforexPriceAsync()
        {
            BitforexAPI.Assets assets = new BitforexAPI.Assets();
            BitforexAPI.BitforexClient bitforexClient = new BitforexAPI.BitforexClient();
            try
            {
                BitforexPrice.XRP_Ask_Price = await bitforexClient.MarketAsync(assets.XRP, assets.BTC, "ask");
                BitforexPrice.XRP_Bid_Price = await bitforexClient.MarketAsync(assets.XRP, assets.BTC, "bid");

                BitforexPrice.ETH_Ask_Price = await bitforexClient.MarketAsync(assets.ETH, assets.BTC, "bid");
                BitforexPrice.ETH_Bid_Price = await bitforexClient.MarketAsync(assets.ETH, assets.BTC, "bid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
