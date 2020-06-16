using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _123
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        
        
        
        public LoginPage()
        {
            InitializeComponent();
           
        }

        private void logsubmit_Click(object sender, RoutedEventArgs e)
        {
            IventContext context = new IventContext(); 
            if (context.Users.FirstOrDefault(x1=>x1.Username==txtUsername.Text && x1.Password==txtPassord.Password)!=null)
            {
                //LoginWindow loginWindow = new LoginWindow();
                //loginWindow.Show();

                Users user = context.Users.FirstOrDefault(x1 => x1.Username == txtUsername.Text);
                Messenger.Default.Send<OpenWindowMessage>(new OpenWindowMessage() { Type = WindowType.kMain, Argument = user });
                
                




               // Application.Current.MainWindow.Close();
            }
            else
            {
                MessageBox.Show("Проверте правильность введённых данных");
            }

            

        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

}


