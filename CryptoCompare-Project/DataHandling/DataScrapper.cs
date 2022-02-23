using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Controls;

namespace CryptoCompare_Project
{
    public class HomePageDataScrapper
    {
        public List<EUR> BestCryptoList { get; set; }

        public HomePageDataScrapper()
        {
            BestCryptoList = new List<EUR>();
        }

        public void scrapDataFunction(DataGrid cryptoInfo1)
        {
            string url_best_10_cryptos = "https://min-api.cryptocompare.com/data/top/mktcapfull?limit=10&tsym=EUR";
            string key = "0edc1384280b50ac53679b94991868fb11fca894abeaf40290cbe2548199599f";

            using (var web = new HttpClient())
            {
                web.DefaultRequestHeaders.Add("Apikey", key);

                var response = web.GetAsync(url_best_10_cryptos).Result;

                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<BestCryptoData>(a);
                    for (int i = 0; i< result.Data.Count; i++)
                    {
                        EUR eur = result.Data[i].RAW.EUR;
                        BestCryptoList.Add(eur);
                    }
                    cryptoInfo1.ItemsSource = from element in BestCryptoList select new {element.FROMSYMBOL, element.PRICE, element.HIGHDAY, element.LOWDAY, element.LASTVOLUME};
                }
            }
        }
    }

    public class CryptoRatesDataScrapper
    {
        private List<double> crypto1ClosePrices { get; set; }
        private List<double> crypto2ClosePrices { get; set; }

        public CryptoRatesDataScrapper()
        {
            crypto1ClosePrices = new List<double>();
            crypto2ClosePrices = new List<double>();

        }
        
        public void scrapDataFunction(string cryptoLink)
        {
            string key = "0edc1384280b50ac53679b94991868fb11fca894abeaf40290cbe2548199599f";
            
            using (var web = new HttpClient())
            {
                web.DefaultRequestHeaders.Add("Apikey", key);

                var response = web.GetAsync(cryptoLink).Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<CryptoHistDataRoot>(jsonString);
                    for (int i = 0; i < result.Data.Data.Count; i++)
                    {
                        var closePrice = result.Data.Data[i].close;
                        crypto1ClosePrices.Add(closePrice);
                    }
                    //cryptoInfo1.ItemsSource = from element in BestCryptoList select new {element.FROMSYMBOL, element.PRICE, element.HIGHDAY, element.LOWDAY, element.LASTVOLUME};
                }
            }
        }
    }
}