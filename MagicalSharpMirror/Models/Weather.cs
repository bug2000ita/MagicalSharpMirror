﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel;
namespace MagicalSharpMirror.Models
{
    public class Weather : INotifyPropertyChanged
    {
        private string time;

        public Weather()
        {
            time = DateTime.Now.ToString();
        }


        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                if (value != time)
                {
                    time = value;
                    NotifyPropertyChanged("Time");
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
