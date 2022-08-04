using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course009
{
    public class StaticModel
    {
        public static int MyProperty { get; set; } = 555;

        private static int _value;

        public static int Value
        {
            get { return _value; }
            set
            {
                _value = value;

                //静态属性变更通知,通用性强
                StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs("Value"));
            }
        }

        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
         
    }
}
