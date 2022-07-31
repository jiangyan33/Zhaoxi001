using System.Windows;
using System.Windows.Controls;

namespace Course007
{
    public class ItemsControlDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate NormalDataTemplate { get; set; }

        public DataTemplate AlarmDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Person person)
            {
                if (person.Age > 20)
                {
                    return AlarmDataTemplate;
                }
                return NormalDataTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
