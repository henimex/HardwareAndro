using HardwareAndro.Model;
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
    public partial class Lesson6Pages : ContentPage
    {
        public Lesson6Pages()
        {
            InitializeComponent();

            var list = new List<Personel>
            {
                new Personel {name = "Ali",money = 100, linkImage = "http://lorempixel.com/400/200/sports/"},
                new Personel {name = "Veli",money = 1000, linkImage = "http://lorempixel.com/400/200/sports/"}
            };

            lstView1.ItemsSource = list;
        }
    }
}