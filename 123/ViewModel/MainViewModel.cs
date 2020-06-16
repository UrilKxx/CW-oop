using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace _123
{
    
    public class MainViewModel : NavigateViewModel
    {
        private Users user;
        private bool isAdmin;

        public Users User
        {
            get
            {
                return user;
            }
            set
            {
                if (user == value)
                {
                    return;
                }
                user = value;
                RaisePropertyChanged();
            }
        }
        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                if (isAdmin == value)
                {
                    return;
                }
                isAdmin = value;
                RaisePropertyChanged();
            }
        }

        private ICommand _iventsCommand;

        public ICommand IventsCommand
        {
            get
            {
                if (_iventsCommand == null)
                {
                    _iventsCommand = new RelayCommand(() =>
                    {
                        Navigate("View/Page1.xaml");
                    });
                }
                return _iventsCommand;
            }
            set { _iventsCommand = value; }
        }

        private ICommand _page2Command;

        public ICommand page2Command
        {
            get
            {
                if (_page2Command == null)
                {
                    _page2Command = new RelayCommand(() =>
                    {
                        Navigate("View/Page2.xaml");
                    });
                }
                return _page2Command;
            }
            set { _page2Command = value; }
        }
        public MainViewModel()
        {
          
        }
    }
}