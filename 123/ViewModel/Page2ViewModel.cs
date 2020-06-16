using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _123
{
    public class Page2ViewModel : NavigateViewModel
    {
        public Page2ViewModel()
        {
            Title = "Page2";
        }

        private ICommand _page1Command;

        public ICommand Page1Command
        {
            get
            {
                if (_page1Command == null)
                {
                    _page1Command = new RelayCommand(() =>
                    {
                        Navigate("View/Page1.xaml");
                    });
                }
                return _page1Command;
            }
            set { _page1Command = value; }
        }
    }
}
