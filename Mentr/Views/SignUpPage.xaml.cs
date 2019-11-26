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
        private Label headerLabel;
        private Entry emailEntry;
        private Entry confirmEmailEntry;
        private Entry passwordEntry;
        private Entry confirmPasswordEntry;
        private Button signUpButton;

        public SignUpPage()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout();
            headerLabel = new Label
            {
                Text = "SignUp Page",
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(10, 10, 10, 10),
                HorizontalOptions = LayoutOptions.StartAndExpand
            };
            stackLayout.Children.Add(headerLabel);

            emailEntry = new Entry
            {
                Keyboard = Keyboard.Email,
                Placeholder = "School Email"
            };
            stackLayout.Children.Add(emailEntry);

            confirmEmailEntry = new Entry
            {
                Keyboard = Keyboard.Email,
                Placeholder = "Confirm Email"
            };
            stackLayout.Children.Add(confirmEmailEntry);

            passwordEntry = new Entry
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Password"
            };
            stackLayout.Children.Add(passwordEntry);

            confirmEmailEntry = new Entry
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Confirm Password"
            };



            signUpButton = new Button
            {
                Text = "Sign In"
            };
            signUpButton.Clicked += SignUpButton_clicked;
            stackLayout.Children.Add(signUpButton);

            Content = stackLayout;
        }

        private void SignUpButton_clicked(object sender, EventArgs e)
        {

            string Email = emailEntry.Text;
            string Password = passwordEntry.Text;

        }
    }
    
}