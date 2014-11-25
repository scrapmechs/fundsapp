using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsApp.Model
{
    class Account : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public float CurrentAmount { get; set; }

        public Account(string name, float currAmount)
        {
            Name = name;

            CurrentAmount = currAmount;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
