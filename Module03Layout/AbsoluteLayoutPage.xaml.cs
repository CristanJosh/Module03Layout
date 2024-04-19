using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module03Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }
        async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}