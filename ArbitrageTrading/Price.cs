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
    
    public static class BinancePrice
    {
        public static decimal XRP_Price { get; set; }
        public static decimal ETH_Price { get; set; }
        public static decimal LTC_Price { get; set; }
    }
    public static class BitfinexPrice
    {
        public static decimal XRP_Ask_Price { get; set; }
        public static decimal XRP_Bid_Price { get; set; }
        public static decimal ETH_Ask_Price { get; set; }
        public static decimal ETH_Bid_Price { get; set; }
        public static decimal LTC_Ask_Price { get; set; }
        public static decimal LTC_Bid_Price { get; set; }
    }
    public static class BitforexPrice
    {
        public static decimal XRP_Ask_Price { get; set; }
        public static decimal XRP_Bid_Price { get; set; }
        public static decimal ETH_Ask_Price { get; set; }
        public static decimal ETH_Bid_Price { get; set; }
        public static decimal LTC_Ask_Price { get; set; }
        public static decimal LTC_Bid_Price { get; set; }
    }

}
