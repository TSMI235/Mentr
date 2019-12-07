using Mentr.Views;
using Rg.Plugins.Popup.Services;
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
    public partial class SocialPage : ContentPage
    {
        public SocialPage()
        {
            InitializeComponent();

            //if (GlobalVariables.current_user != null)
            //{
            //    Database db = 
            //    User current_user = Database.GetUserAsync(GlobalVariables.current_user);
            //}
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new SocialAddPopup());
        }
    }
}