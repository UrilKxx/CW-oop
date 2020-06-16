using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _123
{
    public class Page1ViewModel : NavigateViewModel
    {
        public Page1ViewModel()
        {
            Title = "Page1";
        }
        private IventContext ivent = new IventContext();
        private ObservableCollection<Ivents> ivents = new ObservableCollection<Ivents>();
        private string searchField;
        private bool isVisibleProgressBar;
        private Thread searchedThread;

        public ObservableCollection<Ivents> Ivents
        {
            get { return ivents; }
            set
            {
                if (ivents==value)
                {
                    return;
                }
                ivents = value;
                RaisePropertyChanged();
            }
        }
        public string SearchField
        {
            get
            {
                return searchField;
            }
            set
            {
                if (searchField == value)
                {
                    return;
                }

                searchField = value;
                RaisePropertyChanged();
            }
        }
        public bool IsVisibleProgressBar
        {
            get
            {
                return isVisibleProgressBar;
            }
            set
            {
                if (isVisibleProgressBar == value)
                {
                    return;
                }
                isVisibleProgressBar = value;
                RaisePropertyChanged();
            }
        }

        //private RelayCommandParametr searchCommand;
        //public RelayCommandParametr SearchCommand
        //{
        //    get
        //    {
        //        return searchCommand
        //            ?? (searchCommand = new RelayCommandParametr(
        //            (obj) =>
        //            {
        //                IsVisibleProgressBar = true;
        //                searchedThread = new Thread(() =>
        //                {
        //                    if (String.IsNullOrWhiteSpace(searchField))
        //                    {
        //                        Ivents = new ObservableCollection<Ivents>(ivents.IventName.AsNoTracking().ToList());
        //                    }
        //                    else if (!String.IsNullOrWhiteSpace(searchField))
        //                    {
        //                        Ivents = new ObservableCollection<Ivents>(ivents.Ivents.Where(x => x.MenuDishName.Contains(searchField)));

        //                    }
        //                    SearchField = null;
        //                    IsVisibleProgressBar = false;
        //                });
        //                searchedThread.IsBackground = true;
        //                searchedThread.Start();
        //            }));
        //    }
        //}

        private ICommand _page2Command;
        public ICommand Page2Command
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
    }
}
