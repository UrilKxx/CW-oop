using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace _123
{
    public class AdminViewModel :NavigateViewModel
    {
        private ICommand _addIventCommand;
        public ICommand AddIventCommand
        {
            get
            {
                if (_addIventCommand == null)
                {
                    _addIventCommand = new RelayCommand(() =>
                    {
                        Navigate("View/Page2.xaml");
                    });
                }
                return _addIventCommand;
            }
            set { _addIventCommand = value; }
        }

    }
}
