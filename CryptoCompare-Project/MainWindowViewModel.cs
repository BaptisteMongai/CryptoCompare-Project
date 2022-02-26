using System.Windows.Input;
using CryptoCompare_Project;
using CryptoCompare_Project.Views;

namespace MvvmSwitchViews
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ICommand _gotoHomePageCommand;
        private ICommand _gotoCryptoRatesCommand;
        private ICommand _gotoVariationsCommand;
        private object _currentView;
        private object _HomePageView;
        private object _CryptoRatesView;
        private object _VariationsView;
 
        public MainWindowViewModel()
        {
            _HomePageView = new HomePage();
            _CryptoRatesView = new CryptoRates();
            _VariationsView = new Variations();
 
            CurrentView = _HomePageView;
        }
 
        public object GotoHomePageCommand
        {
            get
            {
                return _gotoHomePageCommand ?? (_gotoHomePageCommand = new RelayCommand(
                    x =>
                    {
                        GotoHomePageView();
                    }));
            }
        }
 
        public ICommand GotoCryptoRatesCommand
        {
            get
            {
                return _gotoCryptoRatesCommand ?? (_gotoCryptoRatesCommand = new RelayCommand(
                    x =>
                    {
                        GotoCryptoRatesView();
                    }));
            }
        }
        
        public ICommand GotoPortfolioCommand
        {
            get
            {
                return _gotoVariationsCommand ?? (_gotoVariationsCommand = new RelayCommand(
                    x =>
                    {
                        GotoPortfolioView();
                    }));
            }
        }
 
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }
 
        private void GotoHomePageView()
        {
            CurrentView = _HomePageView;
        }
 
        private void GotoCryptoRatesView()
        {
            CurrentView =  _CryptoRatesView;
        }
        
        private void GotoPortfolioView()
        {
            CurrentView =  _VariationsView;
        }
    }
}