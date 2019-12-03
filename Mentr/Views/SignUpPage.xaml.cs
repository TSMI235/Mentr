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
    public partial class SignUpPage : ContentPage
    {
    
        public SignUpPage()
        {
            InitializeComponent();

            Title = "Sign Up";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#E67349");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;

            //Adding Items to the picker lists 
            //University_Picker.Items.Add("Louisiana State University");
            //University_Picker.Items.Add("Universtiy of Louisiana Lafyette");
            //University_Picker.Items.Add("Louisiana Tech University");
            //University_Picker.Items.Add("Louisiana College");
            //University_Picker.Items.Add("Mcneese State University");
            //University_Picker.Items.Add("Northwestern State University");
            //University_Picker.Items.Add("Louisiana State University");
            //University_Picker.Items.Add("University of No Opportunity");

            //Status_Picker.Items.Add("Mentor");
            //Status_Picker.Items.Add("Mentee");

            //Field_Picker.Items.Add("Cloud Computing");
            //Field_Picker.Items.Add("Software Engineering");
            //Field_Picker.Items.Add("Cybersecurity");
            //Field_Picker.Items.Add("Biologist");
        }

       //Redirects the sign up page to the login page and assigns values entered 
        private async void SignUpButton_clicked(object sender, EventArgs e)
        {
            string Email = Email_Entry.Text;
            string Password = Password_Entry.Text;
            //string University = (string) University_Picker.SelectedItem;
            string Username = Username_Entry.Text;
            //string UserStatus = (string) Status_Picker.SelectedItem;

            await Navigation.PushAsync(new SignUpContinuePage());
        }
    }
    
}