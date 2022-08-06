using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course011
{
    public class MainViewModel : IDataErrorInfo
    {

        public int Value { get; set; } = 123456789;

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public string UserName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Error { get; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Age) && Age == 123)
                {
                    return "Age不能为123";
                }

                return "";

            }
        }

    }
}
