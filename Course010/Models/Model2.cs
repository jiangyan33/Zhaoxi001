using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course010.Models
{
    public class Model2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
            }
        }

    }
}
