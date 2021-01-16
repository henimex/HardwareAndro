using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HardwareAndro.CCPage
{
    public class CorConPage : CarouselPage
    {
        public CorConPage()
        {
            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Welcome to Xamarin.Forms!" }
            //    }
            //};

            Children.Add(new CPage1());
            Children.Add(new CPage2());
        }
    }
}