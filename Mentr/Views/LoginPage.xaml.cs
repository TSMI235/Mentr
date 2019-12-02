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


        //Redirects the login page to the main page after successfully logging in
        private async void Login_Button_Clicked(object sender, EventArgs e)
        {
           if(Entry_Username.Text == "MikeTheTiger" && Entry_Password.Text == "Password")
            {
               await Navigation.PushAsync(new MainPage());
            }
           else
            {              
               await DisplayAlert("Login Unsuccessful", "Username or Password Incorrect", "OK");
            }
        }

        //Redirects the login page to the sign up page
        private async void Sign_Up_Page_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}