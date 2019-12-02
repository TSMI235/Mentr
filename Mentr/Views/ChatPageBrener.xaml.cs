﻿using Mentr.Models;
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
    public partial class ChatPageBrener : ContentPage
    {
        ChatViewModel vm;
        public ChatPageBrener()
        {
            InitializeComponent();
            Title = "Nathan Brener";
            BindingContext = vm = new ChatViewModel();

            bool[] outOrIn = new bool[] {true, false, true, false, true};
            string[] messagesSent = new string[] {"Hey Dr. Brener! Could we meet up sometime this week?", "Yes Mike, I will be free on Thursday at 12:30pm. Does that work?", "It does, thanks. I've got a couple questions from my Programming Languages class", "Alright, see you then.", "Thanks"};
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