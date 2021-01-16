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
    public partial class Lesson7Pages : ContentPage
    {
        public Lesson7Pages()
        {
            InitializeComponent();

            var liste = new List<Personel>
            {
                new Personel {name = "Ali", money = 100, linkImage = "https://picsum.photos/200/300"},
                new Personel {name = "Veli", money = 750, linkImage = "https://picsum.photos/200/300"},
                new Personel {name = "Celil", money = 500, linkImage = "https://picsum.photos/200/300"}
            };

            lst_View1.ItemsSource = liste;
        }
    }
}