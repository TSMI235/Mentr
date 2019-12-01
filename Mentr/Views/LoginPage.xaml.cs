using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mentr.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           if(Entry_Username.Text == "MikeTheTiger" && Entry_Password.Text == "Password")
            {
               await Navigation.PushAsync(new ProfilePage());
            }
           else
            {              
               await DisplayAlert("Login", "Username or Password Incorrect", "OK");
            }
        }
    }
}