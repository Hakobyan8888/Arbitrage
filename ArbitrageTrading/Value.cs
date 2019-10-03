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
                //Price of XRP-BTC
                BinancePrice.XRP_Price_BTC = await api.GetExchangeRateAsync(Asset.XRP, Asset.BTC);

                //Price of ETH-BTC
                BinancePrice.ETH_Price_BTC = await api.GetExchangeRateAsync(Asset.ETH, Asset.BTC);
                
                //Price of XRP-ETH
                BinancePrice.XRP_Price_ETH = await api.GetExchangeRateAsync(Asset.XRP, Asset.ETH);


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
                //Price of XRP-BTC
                BitfinexPrice.XRP_Ask_Price_BTC = await tickers.Market(BaseCurrency.XRP, QuoteCurrency.BTC, "ask");
                BitfinexPrice.XRP_Bid_Price_BTC = await tickers.Market(BaseCurrency.XRP, QuoteCurrency.BTC, "bid");

                //Price of ETH-BTC
                BitfinexPrice.ETH_Ask_Price_BTC = await tickers.Market(BaseCurrency.ETH, QuoteCurrency.BTC, "ask");
                BitfinexPrice.ETH_Bid_Price_BTC = await tickers.Market(BaseCurrency.ETH, QuoteCurrency.BTC, "bid");

                //Price of XRP-ETH
                //BitfinexPrice.XRP_Ask_Price_ETH = await tickers.Market(BaseCurrency.ETH, QuoteCurrency.XRP, "ask");
                //BitfinexPrice.XRP_Bid_Price_ETH = await tickers.Market(BaseCurrency.ETH, QuoteCurrency.XRP, "bid");
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
                //Price of XRP-BTC
                BitforexPrice.XRP_Ask_Price_BTC = await bitforexClient.MarketAsync(assets.XRP, assets.BTC, "ask");
                BitforexPrice.XRP_Bid_Price_BTC = await bitforexClient.MarketAsync(assets.XRP, assets.BTC, "bid");

                //Price of ETH-BTC
                BitforexPrice.ETH_Ask_Price_BTC = await bitforexClient.MarketAsync(assets.ETH, assets.BTC, "bid");
                BitforexPrice.ETH_Bid_Price_BTC = await bitforexClient.MarketAsync(assets.ETH, assets.BTC, "bid");

                //Price of XRP-ETH
                BitforexPrice.XRP_Ask_Price_ETH = await bitforexClient.MarketAsync(assets.XRP, assets.ETH, "bid");
                BitforexPrice.XRP_Bid_Price_ETH = await bitforexClient.MarketAsync(assets.XRP, assets.ETH, "bid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
