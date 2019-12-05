using Mentr.Models;
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
    public partial class ChatPageBaumgartner : ContentPage
    {
        ChatViewModel vm;
        public ChatPageBaumgartner()
        {
            InitializeComponent();
            Title = "Gerald Baumgartner";
            BindingContext = vm = new ChatViewModel();

            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#E67349");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;

            bool[] outOrIn = new bool[] {true, false, false, true, false, true};
            string[] messagesSent = new string[] {"Hey Dr. Baumgartner! Could we meet up sometime this week?", "Yes Mike, I will be free on Thursday at 12:30pm. Does that work?", "I do have a meeting around 2pm that I will have to attend, but that shouldn't be a problem.", "It does, thanks. I've got a couple questions from my Programming Languages class", "Alright, see you then.", "Thanks"};
            var messageCreate = new Message { Text = "", OutOrIn = true };
            
            for (int i = 0; i < outOrIn.Length; i++)
            {
                messageCreate = new Message
                {
                    Text = messagesSent[i],
                    OutOrIn = outOrIn[i]
                };
                vm.Messages.Add(messageCreate);
            }

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