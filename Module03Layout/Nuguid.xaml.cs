using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module03Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StackLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage() { Title = "Cristan Josh Nuguid" });
        }

        private async void AbsoluteLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage() { Title = "Cristan Josh Nuguid" });
        }

        private async void RelativeLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage() { Title = "Cristan Josh Nuguid" });
        }

        private async void GridPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage() { Title = "Cristan Josh Nuguid" });
        }

        private async void CarouselPage1(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarouselPage1() { Title = "Cristan Josh Nuguid" });
        }

        private async void TabbedPage1(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1() { Title = "Cristan Josh Nuguid" });
        }
    }
}

