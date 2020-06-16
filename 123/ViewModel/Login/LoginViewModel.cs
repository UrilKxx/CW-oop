using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _123
{
    public class LoginViewModel : NavigateViewModel
    {
        public Action CloseAction { get; set; }

        private ICommand _regCommand;
        public ICommand regCommand
        {
            get
            {
                if (_regCommand == null)
                {
                    _regCommand = new RelayCommand(() =>
                    {
                        Navigate("View/Registration.xaml");
                    });
                }
                return _regCommand;
            }
            set { _regCommand = value; }
        }

        

    }
}
