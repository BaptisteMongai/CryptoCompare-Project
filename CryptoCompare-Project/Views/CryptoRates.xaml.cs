using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using ScottPlot;
using ScottPlot.Plottable;
using Color = System.Drawing.Color;

namespace CryptoCompare_Project
{
    public partial class CryptoRates : UserControl
    {
        
        private CryptoRatesDataScrapper _crDataScrapper;
        private string crypto1Link;
        private string crypto2Link;
        
        
        public CryptoRates()
        {
            InitializeComponent();
            _crDataScrapper = new CryptoRatesDataScrapper();
            crypto1Link = "";
            crypto2Link = "";
            //GetHistoricalData();
            //DrawRates();
        }

        public void GetHistoricalData()
        {
            var crypto1 = Crypto1.Text;
            var crypto2 = Crypto2.Text;
            var period = Period.Text;
            var currency = Currency.Text;
            int limit = 0;

            switch (period)
            {
                case "Daily":
                    limit = 1440;
                    crypto1Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym="+crypto1+"&tsym="+currency+"&limit="+limit;
                    crypto2Link = "https://min-api.cryptocompare.com/data/v2/histominute?fsym="+crypto2+"&tsym="+currency+"&limit="+limit;
                    break;
                case "Weekly":
                    limit = 168;
                    crypto1Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym="+crypto1+"&tsym="+currency+"&limit="+limit;
                    crypto2Link = "https://min-api.cryptocompare.com/data/v2/histohour?fsym="+crypto2+"&tsym="+currency+"&limit="+limit;
                    break;
                case "Monthly":
                    limit = 30;
                    crypto1Link = "https://min-api.cryptocompare.com/data/v2/histoday?fsym="+crypto1+"&tsym="+currency+"&limit="+limit;
                    crypto2Link = "https://min-api.cryptocompare.com/data/v2/histoday?fsym="+crypto2+"&tsym="+currency+"&limit="+limit;
                    break;
                case "Yearly":
                    limit = 364;
                    crypto1Link = "https://min-api.cryptocompare.com/data/v2/histoday?fsym="+crypto1+"&tsym="+currency+"&limit="+limit;
                    crypto2Link = "https://min-api.cryptocompare.com/data/v2/histoday?fsym="+crypto2+"&tsym="+currency+"&limit="+limit;
                    break;
                default:
                    break;
            }
        }
        /*
        public void DrawRates()
        {
            double[] rate = new double[_crDataScrapper.crypto1ClosePrices.Count];
            double[] axis = new double[_crDataScrapper.crypto1ClosePrices.Count];
            for (int valueIndex = 0; valueIndex < _crDataScrapper.crypto1ClosePrices.Count; valueIndex++)
            {
                rate[valueIndex] = _crDataScrapper.crypto1ClosePrices[valueIndex] /
                                   _crDataScrapper.crypto2ClosePrices[valueIndex];
                axis[valueIndex] = valueIndex;
            }
            WpfPlot1.Plot.Width = 400;
            WpfPlot1.Plot.Height = 400;
            WpfPlot1.Plot.Title("Rate evolution");
            //WpfPlot1.Plot.AddSignal(rate, rate.Length);
            WpfPlot1.Plot.PlotScatter(axis, rate, color: Color.Red, markerSize: 0);
            WpfPlot1.Plot.XLabel("Horizontal Axis");
            WpfPlot1.Plot.YLabel("Vertical Axis");
            WpfPlot1.Refresh();
        }
        */
        
        private void Draw_Rate_Click(object sender, RoutedEventArgs e)
        {

            GetHistoricalData();
            _crDataScrapper.scrapDataCrypto1Function(crypto1Link);
            _crDataScrapper.scrapDataCrypto2Function(crypto2Link);
            double[] crypto1 = new double[_crDataScrapper.crypto1ClosePrices.Count];
            double[] crypto2 = new double[_crDataScrapper.crypto2ClosePrices.Count];
            double[] rate = new double[_crDataScrapper.crypto2ClosePrices.Count];
            double[] axis = new double[_crDataScrapper.crypto1ClosePrices.Count];
            for (int valueIndex = 0; valueIndex < _crDataScrapper.crypto1ClosePrices.Count; valueIndex++)
            {
                rate[valueIndex] = _crDataScrapper.crypto1ClosePrices[valueIndex] /
                                   _crDataScrapper.crypto2ClosePrices[valueIndex];

                crypto1[valueIndex] = _crDataScrapper.crypto1ClosePrices[valueIndex];
                crypto2[valueIndex] = _crDataScrapper.crypto2ClosePrices[valueIndex];
                axis[valueIndex] = valueIndex;
            }

            WpfPlot1.Plot.Title("Rate evolution");
            //WpfPlot1.Plot.AddSignal(rate, rate.Length);
            WpfPlot1.Plot.PlotScatter(axis, rate, color: Color.Red, markerSize: 0);
           // WpfPlot1.Plot.PlotScatter(axis, crypto1, color: Color.Blue, markerSize: 0);
           //WpfPlot1.Plot.PlotScatter(axis, crypto2, color: Color.Green, markerSize: 0);

            WpfPlot1.Plot.XLabel("Honrizontal Axis");
            WpfPlot1.Plot.YLabel(Crypto1.Text+" / "+Crypto2.Text);
            WpfPlot1.Refresh();

        }
        /*
        private void Draw_Sin_Click(object sender, RoutedEventArgs e)
        {
            _crDataScrapper.scrapDataCrypto1Function(crypto1Link);
            _crDataScrapper.scrapDataCrypto2Function(crypto2Link);
            AddChart();
        }
        */
        /*
        private void AddChart()
        {
            polyline = new Polyline {Stroke = Brushes.Black};
            double[] rate = new double[_crDataScrapper.crypto1ClosePrices.Count];
            for (int valueIndex = 0; valueIndex < _crDataScrapper.crypto1ClosePrices.Count; valueIndex++)
            {
                rate[valueIndex] = _crDataScrapper.crypto1ClosePrices[valueIndex] /
                                   _crDataScrapper.crypto2ClosePrices[valueIndex];
                
            }
            for(int valueIndex = 0; valueIndex < _crDataScrapper.crypto1ClosePrices.Count; valueIndex++)
            {
                var max = rate.Max();
                var x = ((double)valueIndex/_crDataScrapper.crypto1ClosePrices.Count);
                var y = (rate[valueIndex]/max);
                polyline.Points.Add(CorrespondingPoint(new Point(x, y)));
            }

            canvas.Children.Add(polyline);
            /*
            // 2e fonction potentielle
            polyline = new Polyline
            {
                Stroke = Brushes.Blue,
                StrokeDashArray = new DoubleCollection(new double[] {4, 3})
            };
            for (int i = 0; i < 70; i++)
            {
                var x = i / 5.0;
                var y = Math.Cos(x);
                polyline.Points.Add(CorrespondingPoint(new Point(x, y)));
            }
            canvas.Children.Add(polyline);
            
        }
        
        private Point CorrespondingPoint(Point pt)
        {
            var result = new Point
            {
                X = pt.X*canvas.Width,
                Y = pt.Y*canvas.Height
            };
            return result;
        }
        */
    }
}