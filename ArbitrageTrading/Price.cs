using System;
using System.Collections.Generic;
using System.Text;

namespace ArbitrageTrading
{
    //public class Price
    //{
    //    public static decimal BinancePrice { get; set; }

    //    public static decimal BitfinexAskPrice { get; set; }
    //    public static decimal BitfinexBidPrice { get; set; }

    //    public static decimal BitforexAskPrice { get; set; }
    //    public static decimal BitforexBidPrice { get; set; }

    //}
    public struct BinancePrice
    {
        public static decimal XRP_Price_BTC { get; set; }
        public static decimal ETH_Price_BTC { get; set; }
        public static decimal XRP_Price_ETH { get; set; }
    }
    public struct BitfinexPrice
    {
        public static decimal XRP_Ask_Price_BTC { get; set; }
        public static decimal XRP_Bid_Price_BTC { get; set; }
        public static decimal ETH_Ask_Price_BTC { get; set; }
        public static decimal ETH_Bid_Price_BTC { get; set; }
        public static decimal XRP_Ask_Price_ETH { get; set; }
        public static decimal XRP_Bid_Price_ETH { get; set; }
    }
    public struct BitforexPrice
    {
        public static decimal XRP_Ask_Price_BTC { get; set; }
        public static decimal XRP_Bid_Price_BTC { get; set; }
        public static decimal ETH_Ask_Price_BTC { get; set; }
        public static decimal ETH_Bid_Price_BTC { get; set; }
        public static decimal XRP_Ask_Price_ETH { get; set; }
        public static decimal XRP_Bid_Price_ETH { get; set; }
    }

}
