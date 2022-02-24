using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
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

        public async Task scrapDataFunction()
        {
            string url_best_10_cryptos = "https://min-api.cryptocompare.com/data/top/mktcapfull?limit=10&tsym=EUR";
            string key = "0edc1384280b50ac53679b94991868fb11fca894abeaf40290cbe2548199599f";

            using (var web1 = new HttpClient())
            {
                web1.DefaultRequestHeaders.Add("Apikey", key);

                var response = web1.GetAsync(url_best_10_cryptos).Result;

                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<BestCryptoData>(a);
                    for (int i = 0; i< result.Data.Count; i++)
                    {
                        EUR eur = result.Data[i].RAW.EUR;
                        BestCryptoList.Add(eur);
                    }
                }
            }
        }
    }

    public class CryptoRatesDataScrapper
    {
        public List<double> crypto1ClosePrices { get; set; }
        public List<int> crypto1Dates { get; set; }
        public List<double> crypto2ClosePrices { get; set; }
        public List<int> crypto2Dates { get; set; }

        public CryptoRatesDataScrapper()
        {
            crypto1ClosePrices = new List<double>();
            crypto1Dates = new List<int>();
            crypto2ClosePrices = new List<double>();
            crypto2Dates = new List<int>();
        }
        
        public async Task ScrapDataCrypto1Function(string cryptoLink)
        {
            crypto1ClosePrices = new List<double>();
            crypto1Dates = new List<int>();
            string key = "0edc1384280b50ac53679b94991868fb11fca894abeaf40290cbe2548199599f";
            
            using (var web2 = new HttpClient())
            {
                web2.DefaultRequestHeaders.Add("Apikey", key);

                var response = web2.GetAsync(cryptoLink).Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<CryptoHistDataRoot>(jsonString);
                    for (int i = 0; i < result.Data.Data.Count; i++)
                    {
                        crypto1ClosePrices.Add(result.Data.Data[i].close);
                        crypto1Dates.Add(result.Data.Data[i].time);
                    }
                }
            }
        }
        
        public async Task  ScrapDataCrypto2Function(string cryptoLink)
        {
            crypto2ClosePrices = new List<double>();
            crypto2Dates = new List<int>();
            string key = "0edc1384280b50ac53679b94991868fb11fca894abeaf40290cbe2548199599f";

            using (var web3 = new HttpClient())
            {
                web3.DefaultRequestHeaders.Add("Apikey", key);

                var response = web3.GetAsync(cryptoLink).Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<CryptoHistDataRoot>(jsonString);
                    for (int i = 0; i < result.Data.Data.Count; i++)
                    {
                        crypto2ClosePrices.Add(result.Data.Data[i].close);
                        crypto2Dates.Add(result.Data.Data[i].time);
                    }
                }
            }
        }
    }
}