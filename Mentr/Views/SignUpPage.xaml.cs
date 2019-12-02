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


            //Adding Items to the picker lists 
            University_Picker.Items.Add("Louisiana State University");
            University_Picker.Items.Add("Universtiy of Louisiana Lafyette");
            University_Picker.Items.Add("Louisiana Tech University");
            University_Picker.Items.Add("Louisiana College");
            University_Picker.Items.Add("Mcneese State University");
            University_Picker.Items.Add("Northwestern State University");
            University_Picker.Items.Add("Louisiana State University");
            University_Picker.Items.Add("University of No Opportunity");

            Status_Picker.Items.Add("Mentor");
            Status_Picker.Items.Add("Mentee");

            Field_Picker.Items.Add("Cloud Computing");
            Field_Picker.Items.Add("Software Engineering");
            Field_Picker.Items.Add("Cybersecurity");
            Field_Picker.Items.Add("Biologist");

            Grade_Profession.Items.Add("Freshman");
            Grade_Profession.Items.Add("Sophomore");
            Grade_Profession.Items.Add("Junior");
            Grade_Profession.Items.Add("Senior");
            Grade_Profession.Items.Add("Graduate");
            Grade_Profession.Items.Add("Cyber Security Professional");
        }

       //Redirects the sign up page to the login page and assigns values entered 
        private async void SignUpButton_clicked(object sender, EventArgs e)
        {
            string Email = Email_Entry.Text;
            string Password = Password_Entry.Text;
            string University = (string) University_Picker.SelectedItem;
            string Username = Username_Entry.Text;
            string UserStatus = (string) Status_Picker.SelectedItem;

            await Navigation.PushAsync(new LoginPage());
        }

        //Displays the selected item 
        private void University_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var University = University_Picker.Items[University_Picker.SelectedIndex];

            DisplayAlert(University,"Selected Value", "Ok");
        }

        //Displays selected item 
        private void Mentor_Mentee_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Status = Status_Picker.Items[Status_Picker.SelectedIndex];

            DisplayAlert(Status, "Selected Value","Ok");
        }

        private void Field_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Field = Field_Picker.Items[Field_Picker.SelectedIndex];

            DisplayAlert(Field, "Selected Value", "Ok");
        }

        private void Grade_Profession_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Grade = Grade_Profession.Items[Field_Picker.SelectedIndex];

            DisplayAlert(Grade, "Selected Value", "Ok");
        }
    }
    
}