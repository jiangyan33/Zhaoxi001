using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Course011
{
    public class GenderValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.ToString() == "123")
            {
                return new ValidationResult(false, "123报错了");
            }

            return new ValidationResult(true, "");
        }
    }
}
