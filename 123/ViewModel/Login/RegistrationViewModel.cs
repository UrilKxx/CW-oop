using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using System.Linq;
using System.Threading;
using System.Windows.Input;

namespace _123
{
    public class RegistrationViewModel:NavigateViewModel
    {

        private IventContext context = new IventContext();
        private string username;
        private string password;
        private string message;
  
       
        private bool isOpenDialog;

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
        
        /// <summary>
        /// Is Open Dialog 
        /// </summary>
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
        /// <summary>
        /// Message for the dialog  
        /// </summary>
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
        private ICommand _logCommand;
        public ICommand logCommand
        {
            get
            {
                if (_logCommand == null)
                {
                    _logCommand = new RelayCommand(() =>
                    {
                        Navigate("View/LoginPage.xaml");
                    });
                }
                return _logCommand;
            }
            set { _logCommand = value; }
        }

        private RelayCommandParametr _registerCommand;
        public RelayCommandParametr RegisterCommand
        {
            get
            {
                return _registerCommand
                    ?? (_registerCommand = new RelayCommandParametr(
                    (x) =>
                    {
                        
                       
                            if (context.Users.FirstOrDefault(x1 => x1.Username == username) != null)
                            {
                               
                                Message = "Пользователь с таким логином уже зарегистрирован.";
                                IsOpenDialog = true;
                            }
                            
                            else if (Username != null && Password != null )
                            {
                               ;
                                Users user = new Users(Username, Password);
                                context.Users.Add(user);
                                context.SaveChanges();
                                DispatcherHelper.CheckBeginInvokeOnUI(
                                    () =>
                                    {
                                        Messenger.Default.Send<OpenWindowMessage>(
                                        new OpenWindowMessage() { Type = WindowType.kMain, Argument = user });
                                    }
                                    );
                            }
                            else
                            {
                                
                                Message = "Некорректно введены данные.";
                                IsOpenDialog = true;
                            }
                        }
                    ));
                    
            }
        }

    }
}
