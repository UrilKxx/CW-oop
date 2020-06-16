using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _123
{
    public class AddIvetViewModel: NavigateViewModel
    {


        private IventContext context = new IventContext();
        private string iventName;
        private string iventDescription;
        private Tag tag;
        private IventType iventType;
        private byte[] iventImagine;
        private bool isOpenDialog;
        private string message;
        private DateTime dateStart;
        private DateTime dateEnd;


        public byte[] IventImagine
        {
            get
            {
                return iventImagine;
            }
            set
            {
                if (iventImagine == value)
                {
                    return;
                }

                iventImagine = value;
                RaisePropertyChanged();
            }
        }
        public string IventName
        {
            get
            {
                return iventName;
            }
            set
            {
                if (iventName == value)
                {
                    return;
                }

                iventName = value;
                RaisePropertyChanged();
            }
        }

        public string IventDescription
        {
            get
            {
                return iventDescription;
            }
            set
            {
                if (iventDescription == value)
                {
                    return;
                }

                iventDescription = value;
                RaisePropertyChanged();
            }
        }
        public Tag Tag
        {
            get
            {
                return tag;
            }
            set
            {
                if (tag == value)
                {
                    return;
                }
                tag = value;
                RaisePropertyChanged();
            }
        }
        public IventType IventType
        {
            get
            {
                return iventType;
            }
            set
            {
                if (iventType == value)
                {
                    return;
                }
                iventType = value;
                RaisePropertyChanged();
            }
        }
        public DateTime DateStart
        {
            get
            {
                return dateStart;
            }
            set
            {
                if (dateStart == value)
                {
                    return;
                }
                dateStart = value;
                RaisePropertyChanged();
            }
        }
        public DateTime DateEnd
        {
            get
            {
                return dateEnd;
            }
            set
            {
                if (dateEnd == value)
                {
                    return;
                }
                dateEnd = value;
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

        private RelayCommandParametr _setPathToImageCommand;
        public RelayCommandParametr SetPathToImageCommand
        {
            get
            {

                return _setPathToImageCommand
                    ?? (_setPathToImageCommand = new RelayCommandParametr(
                    (o) =>
                    {
                        Messenger.Default.Send<NotificationMessage>(new NotificationMessage(this, "ChooseImage"));
                    })); 
            }
        }

        private RelayCommandParametr addIventCommand;
        public RelayCommandParametr AddIventCommand
        {
            get
            {
                return addIventCommand
                    ?? (addIventCommand = new RelayCommandParametr(
                    (obj) =>
                    {
                        if (!String.IsNullOrWhiteSpace(IventName) && !String.IsNullOrWhiteSpace(IventDescription))
                        {
                           
                            

                                Ivents ivents = new Ivents(iventName, iventDescription, iventImagine,dateStart, dateEnd, iventType, tag);

                                context.Ivents.Add(ivents);
                                context.SaveChanges();
                                
                                Message = "Мероприятие добавленно";
                                IsOpenDialog = true;

                                Image img = System.Drawing.Image.FromFile(new Uri("../../Assets/noPhoto.png", UriKind.RelativeOrAbsolute).OriginalString);
                                IventImagine = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));


                        }

                    },
                    (x) => !String.IsNullOrWhiteSpace(iventName)));
            }
        }

        public AddIvetViewModel()
        {
            Image img = System.Drawing.Image.FromFile(new Uri("../../Assets/noPhoto.png", UriKind.RelativeOrAbsolute).OriginalString);
            IventImagine = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
            IventName = String.Empty;
            IventDescription = String.Empty;

        }
    }
}
