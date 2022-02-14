﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

using System;
using System.Collections;
using System.Collections.Generic;


public class EUR
    {
        public string TYPE { get; set; }
        public string MARKET { get; set; }
        public string FROMSYMBOL { get; set; }
        public string TOSYMBOL { get; set; }
        public string FLAGS { get; set; }
        public string PRICE { get; set; }
        public string LASTUPDATE { get; set; }
        public double MEDIAN { get; set; }
        public string LASTVOLUME { get; set; }
        public string LASTVOLUMETO { get; set; }
        public string LASTTRADEID { get; set; }
        public string VOLUMEDAY { get; set; }
        public string VOLUMEDAYTO { get; set; }
        public string VOLUME24HOUR { get; set; }
        public string VOLUME24HOURTO { get; set; }
        public string OPENDAY { get; set; }
        public string HIGHDAY { get; set; }
        public string LOWDAY { get; set; }
        public string OPEN24HOUR { get; set; }
        public string HIGH24HOUR { get; set; }
        public string LOW24HOUR { get; set; }
        public string LASTMARKET { get; set; }
        public string VOLUMEHOUR { get; set; }
        public string VOLUMEHOURTO { get; set; }
        public string OPENHOUR { get; set; }
        public string HIGHHOUR { get; set; }
        public string LOWHOUR { get; set; }
        public string TOPTIERVOLUME24HOUR { get; set; }
        public string TOPTIERVOLUME24HOURTO { get; set; }
        public string CHANGE24HOUR { get; set; }
        public string CHANGEPCT24HOUR { get; set; }
        public string CHANGEDAY { get; set; }
        public string CHANGEPCTDAY { get; set; }
        public string CHANGEHOUR { get; set; }
        public string CHANGEPCTHOUR { get; set; }
        public string CONVERSIONTYPE { get; set; }
        public string CONVERSIONSYMBOL { get; set; }
        public string SUPPLY { get; set; }
        public string MKTCAP { get; set; }
        public string MKTCAPPENALTY { get; set; }
        public string CIRCULATINGSUPPLY { get; set; }
        public string CIRCULATINGSUPPLYMKTCAP { get; set; }
        public string TOTALVOLUME24H { get; set; }
        public string TOTALVOLUME24HTO { get; set; }
        public string TOTALTOPTIERVOLUME24H { get; set; }
        public string TOTALTOPTIERVOLUME24HTO { get; set; }
        public string IMAGEURL { get; set; }

    }
public class EURContainer
{
    public static List<EUR> EURList { get; set; }
}

public class BestCrypto
{
    public static List<string> BestCryptoName { get; set; }
}
public class BTC
    {
        public EUR EUR { get; set; }
    }

    public class RAW
    {
        public BTC BTC { get; set; }
    }

    public class DISPLAY
    {
        public BTC BTC { get; set; }
    }

    public class Root
    {
        public RAW RAW { get; set; }
        public DISPLAY DISPLAY { get; set; }
    }
