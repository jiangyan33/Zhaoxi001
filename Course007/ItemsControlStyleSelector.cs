using System.Windows;
using System.Windows.Controls;

namespace Course007
{
    public class ItemsControlStyleSelector : StyleSelector
    {
        public Style Normal { get; set; }

        public Style Alarm { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            if (item is Person person)
            {
                if (person.Age > 20)
                {
                    return Alarm;
                }
                return Normal;
            }
            return base.SelectStyle(item, container);
        }
    }
}
