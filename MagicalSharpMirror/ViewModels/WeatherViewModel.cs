using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using MagicalSharpMirror.Models;
using MagicalSharpMirror.BusinessLogic;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace MagicalSharpMirror.ViewModels
{
    public class WeatherViewModel: BindableBase
    {
        private Weather weather;
        private DataTimeRetriever data;

        public WeatherViewModel()
        {
            this.SetMidNightTimeCommand = new DelegateCommand<object>(this.OnSetMidNightTime);            
            this.weather = new Weather();
            this.weather.PropertyChanged += (s, e) => { OnSetMidNightTime(s); };

            data = new DataTimeRetriever(this.weather);
        }

        public ICommand SetMidNightTimeCommand { get; private set; }

        public Weather Weather
        {
            get { return weather; }
            set
            {
                weather = value;
                SetProperty(ref weather, value);
            }
        }

        private void OnSetMidNightTime(object obj)
        {
            Weather = obj as Weather;
        }


        
    }
}
