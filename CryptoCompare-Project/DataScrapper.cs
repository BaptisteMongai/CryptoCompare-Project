using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Controls;

namespace CryptoCompare_Project
{
    public class DataScrapper
    {
        public void scrapDataFunction(List<EUR> list ,DataGrid cryptoInfo1)
        {
            string url_best_20_cryptos = "https://min-api.cryptocompare.com/data/top/mktcapfull?limit=14&tsym=EUR";
            string key = "0edc1384280b50ac53679b94991868fb11fca894abeaf40290cbe2548199599f";

            using (var web = new HttpClient())
            {
                web.DefaultRequestHeaders.Add("Apikey", key);

                var response = web.GetAsync(url_best_20_cryptos).Result;

                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<Root>(a);
                    for (int i = 0; i< result.Data.Count; i++)
                    {
                        EUR eur = result.Data[i].RAW.EUR;
                        list.Add(eur);
                    }
                    cryptoInfo1.ItemsSource = from element in list select new {element.FROMSYMBOL, element.PRICE, element.HIGHDAY, element.LOWDAY, element.LASTVOLUME};
                }
            }
        }
    }
}