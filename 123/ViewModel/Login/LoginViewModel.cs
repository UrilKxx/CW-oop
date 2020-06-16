using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
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

        private IventContext context = new IventContext();
        private string username;
        private string password;
                
        private bool isOpenDialog;

        private string message;
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

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (username == value)
                {
                    return;
                }
                username = value;
                RaisePropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password == value)
                {
                    return;
                }
                password = value;
                RaisePropertyChanged();
            }
        }

        public bool IsOpenDialog
        {
            get
            {
                return isOpenDialog;
            }
            set
            {
                if (isOpenDialog == value)
                {
                    return;
                }
                isOpenDialog = value;
                RaisePropertyChanged();
            }
        }
        
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if (message == value)
                {
                    return;
                }
                message = value;
                RaisePropertyChanged();
            }
        }
        private RelayCommand closeDialodCommand;
        public RelayCommand CloseDialodCommand
        {
            get
            {
                return closeDialodCommand
                    ?? (closeDialodCommand = new RelayCommand(
                    () =>
                    {
                        IsOpenDialog = false;
                    }));
            }
        }

        private RelayCommandParametr _loginCommand;
        public RelayCommandParametr LoginCommand
        {
            get
            {
                return _loginCommand
                    ?? (_loginCommand = new RelayCommandParametr(
                    (x) =>
                    {

                        if (context.Users.FirstOrDefault(x1 => x1.Username == username && x1.Password == password) != null)
                        {

                            Users user = context.Users.FirstOrDefault(x1 => x1.Username == username);
                            context.SaveChanges();
                           
                                    Messenger.Default.Send<OpenWindowMessage>(
                                    new OpenWindowMessage() { Type = WindowType.kMain, Argument = user });
                             
                            //LoginWindow loginWindow = new LoginWindow();
                            //loginWindow.Show();

                        }
                        else
                        {

                            Message = "Неверный логин или пароль!";
                            IsOpenDialog = true;
                        }
                    }
                        
                ));
            }
                    
        }
        

    }
}
