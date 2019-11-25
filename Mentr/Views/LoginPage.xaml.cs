using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mentr.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mentr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        void SignInProcedure(Object sender, EventArgs e)
        {
            
         string username = Entry_Username.Text;
         string password = Entry_Password.Text;

         User user = new User(username, password);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success");
            }
            else
            {
                DisplayAlert("Login", "Username or Password Incorrect");
            }
        }
    }
}