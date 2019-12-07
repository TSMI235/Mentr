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
    public partial class MatchedPage : ContentPage
    {
        public MatchedPage()
        {
            InitializeComponent();
        }

        private async void ImageCell_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatPage());
        }

        private async void ImageCell_TappedGerald(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatPageBaumgartner());
        }
    }
}