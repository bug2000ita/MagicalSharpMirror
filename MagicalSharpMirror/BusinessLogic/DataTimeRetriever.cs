using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Windows.UI.Xaml;
using MagicalSharpMirror.Models;

namespace MagicalSharpMirror.BusinessLogic
{
    public class DataTimeRetriever
    {
        private Weather weather;

        public DataTimeRetriever(Weather weather)
        {
            this.weather = weather;
            StartTimer();
        }

        private void StartTimer()
        {
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += OnTimerExpired;
            timer.Start();
        }
        private void OnTimerExpired(object sender, object e)
        {
            weather.Time = DateTime.Now.ToString();
        }
    }
}
