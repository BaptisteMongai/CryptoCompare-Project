// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

using System;
using System.Collections;
using System.Collections.Generic;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class MetaData
    {
        public int Count { get; set; }
    }

    public class Weiss
    {
        public string Rating { get; set; }
        public string TechnologyAdoptionRating { get; set; }
        public string MarketPerformanceRating { get; set; }
    }

    public class Rating
    {
        public Weiss Weiss { get; set; }
    }

    public class CoinInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Internal { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Algorithm { get; set; }
        public string ProofType { get; set; }
        public Rating Rating { get; set; }
        public string NetHashesPerSecond { get; set; }
        public string BlockNumber { get; set; }
        public string BlockTime { get; set; }
        public string BlockReward { get; set; }
        public string AssetLaunchDate { get; set; }
        public string MaxSupply { get; set; }
        public string Type { get; set; }
        public string DocumentType { get; set; }
    }

    public class USD
    {
        public string TYPE { get; set; }
        public string MARKET { get; set; }
        public string FROMSYMBOL { get; set; }
        public string TOSYMBOL { get; set; }
        public string FLAGS { get; set; }
        public string PRICE { get; set; }
        public string LASTUPDATE { get; set; }
        public string MEDIAN { get; set; }
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

    public class RAW
    {
        public USD USD { get; set; }
    }

    public class DISPLAY
    {
        public USD USD { get; set; }
    }

    public class Datum
    {
        public CoinInfo CoinInfo { get; set; }
        public RAW RAW { get; set; }
        public DISPLAY DISPLAY { get; set; }
    }

    public class RateLimit
    {
    }

    public class BestCryptoData
    {
        public string Message { get; set; }
        public int Type { get; set; }
        public MetaData MetaData { get; set; }
        public List<object> SponsoredData { get; set; }
        public List<Datum> Data { get; set; }
        public RateLimit RateLimit { get; set; }
        public bool HasWarning { get; set; }
    }

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class RateLimit2
{
}

public class Datum2
{
    public int time { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double open { get; set; }
    public double volumefrom { get; set; }
    public double volumeto { get; set; }
    public double close { get; set; }
    public string conversionType { get; set; }
    public string conversionSymbol { get; set; }
    public bool Aggregated { get; set; }
    public int TimeFrom { get; set; }
    public int TimeTo { get; set; }
    public List<Datum2> Data { get; set; }
}

public class CryptoHistDataRoot
{
    public string Response { get; set; }
    public string Message { get; set; }
    public bool HasWarning { get; set; }
    public int Type { get; set; }
    public RateLimit2 RateLimit { get; set; }
    public Datum2 Data { get; set; }
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class CurrentPriceUSD
{
    public double USD { get; set; }
}