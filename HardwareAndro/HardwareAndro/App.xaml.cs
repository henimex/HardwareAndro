using HardwareAndro.CCPage;
using HardwareAndro.TabMenu;
using HardwareAndro.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HardwareAndro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new ActivityIndi();
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
