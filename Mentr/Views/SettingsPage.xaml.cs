using Mentr.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mentr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Disclaimer_View(object sender, EventArgs e)
        {
            DisplayAlert("Disclaimer", "This app is not liable for any personal " +
                "information being stolen and shared with others online", "Ok");
        }

        private async void Sign_Out(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}