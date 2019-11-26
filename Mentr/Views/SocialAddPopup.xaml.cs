using Mentr.ViewModels;
using Rg.Plugins.Popup.Services;
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
    public partial class SocialAddPopup
    {
        public SocialAddPopup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string headline = post_title.Text;
            string description = post_text.Text;

            string headtitle = "Posted by: " + GlobalVariables.current_user;

            string profileImage = "";

            CardDataModel card = new CardDataModel {
                HeadTitle = headtitle,
                HeadLines = headline,
                HeadLinesDesc = description,
                ProfileImage = profileImage
            };

            CardDataViewModel cardview = new CardDataViewModel();
            cardview.AddCardModel(card);

            PopupNavigation.Instance.PopAsync(true);
        }
    }
}