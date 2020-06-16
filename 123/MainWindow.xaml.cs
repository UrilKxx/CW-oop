using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _123
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationSetup();
            Closing += (s, e) => ViewModelLocator.Cleanup();
            Messenger.Default.Register<OpenWindowMessage>(
              this,
              message =>
              {
                  if (message.Type == WindowType.kMain)
                  {
                      var modalWindowVM = SimpleIoc.Default.GetInstance<MainViewModel>();
                      modalWindowVM.User = message.Argument;
                      modalWindowVM.IsAdmin = modalWindowVM.User.Level == Level.Admin;
                      var loginWindow = new LoginWindow();
                      loginWindow.Show();
                      this.Close();
                  }
              });




        }

        void NavigationSetup()
        {
            Messenger.Default.Register<NavigateArgs>(this, (x) =>
            {
                LoginFrame.Navigate(new Uri(x.Url, UriKind.Relative));
            });
        }
    }
}
