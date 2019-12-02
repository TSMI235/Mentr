using Mentr.ViewModels;
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
    public partial class ChatPage : ContentPage
    {
        ChatViewModel vm;
        public ChatPage()
        {
            InitializeComponent();
            Title = "William Duncan";
            BindingContext = vm = new ChatViewModel();

            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#E67349");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;

            vm.Messages.CollectionChanged += (sender, e) =>
            {
                var target = vm.Messages[vm.Messages.Count - 1];
                MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
            };
        }

        void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }

        void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagesListView.SelectedItem = null;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            InputLine.Text = null;
        }
    }
}