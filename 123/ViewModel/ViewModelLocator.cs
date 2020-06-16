using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace _123
{
   
    public class ViewModelLocator
    {
        
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Page1ViewModel>();
            SimpleIoc.Default.Register<Page2ViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<RegistrationViewModel>();
            SimpleIoc.Default.Register<AdminViewModel>();
            SimpleIoc.Default.Register<AddIvetViewModel>();

        }
        public AddIvetViewModel AddIvet
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddIvetViewModel>();
            }
        }

        public AdminViewModel Admin
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AdminViewModel>();
            }
        }
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public Page1ViewModel Page1
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Page1ViewModel>();
            }
        }
        public LoginViewModel Login
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }
        public RegistrationViewModel Registration
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RegistrationViewModel>();
            }
        }
        public Page2ViewModel Page2
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Page2ViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}