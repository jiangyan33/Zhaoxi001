using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZhaoxiXamarinForms.LayOut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FramePageFlyout : ContentPage
    {
        public ListView ListView;

        public FramePageFlyout()
        {
            InitializeComponent();

            BindingContext = new FramePageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FramePageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FramePageFlyoutMenuItem> MenuItems { get; set; }
            
            public FramePageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FramePageFlyoutMenuItem>(new[]
                {
                    new FramePageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new FramePageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new FramePageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new FramePageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new FramePageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}