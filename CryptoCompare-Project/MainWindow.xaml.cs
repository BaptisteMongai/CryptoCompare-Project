using System;
using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Wpf;

namespace CryptoCompare_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Draw_Sin_Click(object sender, RoutedEventArgs e)
        {
            AddChart();
        }
        
        private double xmin = 0;

        private double xmax = 6.5;
        private double ymin = -1.1;
        private double ymax = 1.1;
        private Polyline polyline;

        
        private void AddChart()
        {
            // Draw sine chart:
            polyline = new Polyline {Stroke = Brushes.Black};

            for (int i = 0; i < 70; i++)
            {
                var x = i / 5.0;
                var y = Math.Sin(x);
                polyline.Points.Add(CorrespondingPoint(new Point(x, y)));
            }
            canvas.Children.Add(polyline);
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
                X = (pt.X - xmin)*canvas.Width/(xmax - xmin),
                Y = canvas.Height - (pt.Y - ymin)*canvas.Height
                    /(ymax - ymin)
            };
            return result;
        }
    }
}