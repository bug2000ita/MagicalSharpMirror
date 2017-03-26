using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;


/// <summary>
/// The ViewModelLocator needed to be implemented manually since it is not provided by Universal IOT App
/// Installed MvvmLight to get the right dipendencies
/// </summary>
namespace MagicalSharpMirror.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<WeatherViewModel>();

        }

        public MainPageViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }
        public WeatherViewModel WeatherViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WeatherViewModel>();
            }
        }
    }
}
