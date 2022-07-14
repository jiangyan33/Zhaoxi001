using System.ComponentModel;

namespace Course001.Models
{
    public class ButtonModel : INotifyPropertyChanged
    {
        public int Width { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        private string _text = "点击";

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
            }
        }
    }

}
