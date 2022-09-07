using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course019
{
    public class MainViewModel
    {

        public ChartValues<int> Values { get; set; }

        public ObservableCollection<string> XLabels { get; set; }

        public MainViewModel()
        {

            Values = new ChartValues<int>();

            XLabels = new ObservableCollection<string>();

            Task.Run(async () =>
            {
                var random = new Random();

                while (true)
                {
                    await Task.Delay(2000);

                    Values.Add(random.Next(0, 50));

                    XLabels.Add(DateTime.Now.ToString("mm:ss"));

                    if (Values.Count > 30)
                    {
                        Values.RemoveAt(0);

                        XLabels.RemoveAt(0);
                    }
                }
            });
        }
    }

}
