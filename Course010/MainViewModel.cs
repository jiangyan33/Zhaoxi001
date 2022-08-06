using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Course010
{
    public class MainViewModel : DependencyObject
    {
        public Models.Model1 Model1 { get; set; } = new Models.Model1();

        public Models.Model2 Model2 { get; set; } = new Models.Model2();

        public ObservableCollection<Models.Model2> Models { get; set; } = new ObservableCollection<Models.Model2>();

        public MainViewModel()
        {
            Models.Add(new Course010.Models.Model2 { Value = 1 });
            Models.Add(new Course010.Models.Model2 { Value = 2 });
            Models.Add(new Course010.Models.Model2 { Value = 3 });
            Models.Add(new Course010.Models.Model2 { Value = 4 });
            Models.Add(new Course010.Models.Model2 { Value = 5 });

            Task.Run(async () =>
            {
                await Task.Delay(2000);

                Model1.Value = 100;

                Application.Current.Dispatcher.Invoke(() =>
                {
                    Models.Add(new Course010.Models.Model2 { Value = 6 });
                });
            });
        }



        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty",
                typeof(int),
                typeof(MainViewModel),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));


    }
}
