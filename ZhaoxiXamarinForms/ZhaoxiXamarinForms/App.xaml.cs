using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZhaoxiXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var shell = Shell();

            MainPage = new ZhaoxiXamarinForms.LayOut.FramePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
