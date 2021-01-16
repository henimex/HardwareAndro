using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HardwareAndro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndi : ContentPage
    {
        public ActivityIndi()
        {
            InitializeComponent();
            _image.Source = "https://www.satsignal.eu/wxsat/Meteosat7-full-scan.jpg";
        }
    }
}