using HardwareAndro.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HardwareAndro.TabMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabControl : TabbedPage
    {
        public TabControl()
        {
            InitializeComponent();

            var page1 = new Lesson5Pages();
            page1.Title = "Sleepy";
            page1.IconImageSource = "eyemask.png";

            var page2 = new Lesson6Pages();
            page2.Title = "Unicorn";
            page2.IconImageSource = "unicorn2.png";

            var page3 = new Lesson7Pages();
            page3.Title = "Credit Card";
            page3.IconImageSource = "candycane.png";

            var page4 = new Lesson8Pages();
            page4.Title = "New One";
            page4.IconImageSource = "unicorn1.png";

            var page5 = new Lesson9Pages();
            page5.Title = "Summer";
            page5.IconImageSource = "rubberring.png";

            this.Children.Add(page1);
            this.Children.Add(page2);
            this.Children.Add(page3);
            this.Children.Add(page4);
            this.Children.Add(page5);
        }
    }
}