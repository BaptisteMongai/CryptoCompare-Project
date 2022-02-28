using System.Windows;
using System.Windows.Controls;

namespace CryptoCompare_Project.Views
{
    public partial class Notifications : UserControl
    {
        public Notifications()
        {
            InitializeComponent();
        }
        
        private void Calcul_OnClick(object sender, RoutedEventArgs e)
        {
            var crypto1 = Crypto1.Text;
            var crypto2 = Crypto2.Text;
            var delta = Delta.Text;
            var period = Period.Text;

            if (N1C1.Text == "")
            {
                N1C1.Text = crypto1;
                N1C2.Text = crypto2;
                N1Delta.Text = delta;
                N1Time.Text = period;
            }
            else if (N2C1.Text == "")
            {
                N2C1.Text = crypto1;
                N2C2.Text = crypto2;
                N2Delta.Text = delta;
                N2Time.Text = period;
            }
            else
            {
                N3C1.Text = crypto1;
                N3C2.Text = crypto2;
                N3Delta.Text = delta;
                N3Time.Text = period;
            }
            //throw new System.NotImplementedException();
        }
    }
}