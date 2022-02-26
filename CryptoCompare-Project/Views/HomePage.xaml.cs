using System.Collections.Generic;
using System.Windows.Controls;

namespace CryptoCompare_Project
{
    public partial class HomePage : UserControl
    {
        List<EUR> cryptoList = new List<EUR>();
        public HomePage()
        {
            InitializeComponent();
            HomePageDataScrapper HPdataScrapper = new HomePageDataScrapper();
            HPdataScrapper.scrapDataFunction(CryptoInfo1);
        }
    }
}