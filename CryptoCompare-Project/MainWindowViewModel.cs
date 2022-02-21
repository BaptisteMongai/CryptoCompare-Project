﻿using System.Windows.Input;
using CryptoCompare_Project;

namespace MvvmSwitchViews
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ICommand _gotoView1Command;
        private ICommand _gotoView2Command;
        private object _currentView;
        private object _view1;
        private object _view2;
 
        public MainWindowViewModel()
        {
            _view1 = new HomePage();
            _view2 = new CryptoRates();
 
            CurrentView = _view1;
        }
 
        public object GotoView1Command
        {
            get
            {
                return _gotoView1Command ?? (_gotoView1Command = new RelayCommand(
                    x =>
                    {
                        GotoView1();
                    }));
            }
        }
 
        public ICommand GotoView2Command
        {
            get
            {
                return _gotoView2Command ?? (_gotoView2Command = new RelayCommand(
                    x =>
                    {
                        GotoView2();
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
 
        private void GotoView1()
        {
            CurrentView = _view1;
        }
 
        private void GotoView2()
        {
            CurrentView =  _view2;
        }
    }
}