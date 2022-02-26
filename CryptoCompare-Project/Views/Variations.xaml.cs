using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CryptoCompare_Project.Views
{
    public partial class Variations : UserControl
    {
        private CryptoDifferencePriceDataScrapper _cryptoDifferencePriceDataScrapper;
        private string crypto1Link;
        private string crypto2Link;
        private string date1_crypto1Link;
        private string date2_crypto1Link;
        private string currentPriceCrypto1Link;
        private string currentPriceCrypto2Link;
        private string initialPriceCrypto1Link;
        private string initialPriceCrypto2Link;

        
        public Variations()
        {
            InitializeComponent();
            _cryptoDifferencePriceDataScrapper = new CryptoDifferencePriceDataScrapper();
            crypto1Link = "";
            crypto2Link = "";
            currentPriceCrypto1Link = "";
            currentPriceCrypto2Link = "";
            initialPriceCrypto1Link = "";
            initialPriceCrypto2Link = "";
        }
        
        public void GetHistoricalData()
        {
            var crypto1 = Crypto1.Text;
            var crypto2 = Crypto2.Text;
            var period = Period.Text;
            var date = DateTime.Now;
            long unixTime = ((DateTimeOffset)date).ToUnixTimeSeconds();
            string toTs = "";

            currentPriceCrypto1Link = "https://min-api.cryptocompare.com/data/price?fsym=" + crypto1 + "&tsyms=USD";
            currentPriceCrypto2Link = "https://min-api.cryptocompare.com/data/price?fsym=" + crypto2 + "&tsyms=USD";

            switch (period)
            {
                case "Today":
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + crypto1 + "&tsym=USD&limit=1"; 
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + crypto2 + "&tsym=USD&limit=1";
                    break;
                
                case "1 hour":
                    toTs = (unixTime - 3600).ToString();
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + crypto1 + "&tsym=USD&limit=1&toTs=" + toTs;
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + crypto2 + "&tsym=USD&limit=1&toTs=" + toTs;
                    break;
                
                case "24 hours":
                    toTs = (unixTime - 86400).ToString();
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + crypto1 + "&tsym=USD&limit=1&toTs=" + toTs;
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + crypto2 + "&tsym=USD&limit=1&toTs=" + toTs;
                    break;
                
                case "7 days": //7 days - 2 minutes exactly
                    toTs = (unixTime - 604680).ToString();
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + crypto1 + "&tsym=USD&limit=1&toTs=" + toTs;
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + crypto2 + "&tsym=USD&limit=1&toTs=" + toTs;
                    break;
                
                //En cours
                case "30 days":
                    toTs = (unixTime - 2592000).ToString();
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + crypto1 + "&tsym=USD&limit=1&toTs=" + toTs;
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + crypto2 + "&tsym=USD&limit=1&toTs=" + toTs;
                    break;

                case "90 days":
                    toTs = (unixTime - 7776000).ToString();
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + crypto1 + "&tsym=USD&limit=1&toTs=" + toTs;
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + crypto2 + "&tsym=USD&limit=1&toTs=" + toTs;
                    break;

                case "1 year":
                    toTs = (unixTime - 31536000).ToString();
                    initialPriceCrypto1Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + crypto1 + "&tsym=USD&limit=1&toTs=" + toTs;
                    initialPriceCrypto2Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + crypto2 + "&tsym=USD&limit=1&toTs=" + toTs;

                    break;
                default:
                    break;
            }
        }
        

        private async void calcul_Click(object sender, RoutedEventArgs e)
        {
            GetHistoricalData();
            
            
            await _cryptoDifferencePriceDataScrapper.scrappingCrypto1CurrentPrice(currentPriceCrypto1Link);
            await _cryptoDifferencePriceDataScrapper.scrappingCrypto2CurrentPrice(currentPriceCrypto2Link);
            await _cryptoDifferencePriceDataScrapper.scrappingCrypto1InitialPrice(initialPriceCrypto1Link);
            await _cryptoDifferencePriceDataScrapper.scrappingCrypto2InitialPrice(initialPriceCrypto2Link);
            
            double currentPriceCrypto1 = _cryptoDifferencePriceDataScrapper.crypto1CurrentPrice;
            double currentPriceCrypto2 = _cryptoDifferencePriceDataScrapper.crypto2CurrentPrice;
            double initialPriceCrypto1 = _cryptoDifferencePriceDataScrapper.crypto1OpenPrice;
            double initialPriceCrypto2 = _cryptoDifferencePriceDataScrapper.crypto2OpenPrice;

            var crypto1Variation = (currentPriceCrypto1 - initialPriceCrypto1) / initialPriceCrypto1 * 100;
            var crypto2Variation = (currentPriceCrypto2 - initialPriceCrypto2) / initialPriceCrypto2 * 100;
            var deltaCrypto1Crypto2 = Math.Abs(crypto1Variation - crypto2Variation);

            // Affichage
            if (crypto1Variation >= 0)
            {
                Crypto1Variation.Text = "+ " + crypto1Variation.ToString(".###") + " %";
            }
            else
            {
                Crypto1Variation.Text = crypto1Variation.ToString(".###") + " %";
            }
            
            if (crypto2Variation >= 0)
            {
                Crypto2Variation.Text = "+ " + crypto2Variation.ToString(".###") + " %";
            }
            else
            {
                Crypto2Variation.Text = crypto2Variation.ToString(".###") + " %";
            }
            
            Delta.Text = deltaCrypto1Crypto2.ToString(".###");
            
        }
    }
}