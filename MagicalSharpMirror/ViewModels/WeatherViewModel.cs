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
        private string time;
        private DataTimeRetriever data;

        public WeatherViewModel()
        {
            this.SetMidNightTimeCommand = new DelegateCommand<object>(this.OnSetMidNightTime);
            this.weather = new Weather();
            data = new DataTimeRetriever(this.weather);
        }

        public ICommand SetMidNightTimeCommand { get; private set; }

        public string Time
        {
            get { return weather.Time; }
            set
            {
                weather.Time = value;
                SetProperty(ref time, value);
            }
        }

        private void OnSetMidNightTime(object obj)
        {
            Time = DateTime.Now.ToString();
        }


        
    }
}
