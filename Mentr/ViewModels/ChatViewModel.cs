using Mentr.Helpers;
using Mentr.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mentr.ViewModels
{
    class ChatViewModel
    {
        public ObservableRangeCollection<Message> Messages { get; }

        string outgoingText = string.Empty;
        IMessanger messanger;

        public string OutGoingText { get; set; }
        public ICommand SendCommand { get; set; }

        public ChatViewModel()
        {
            messanger = DependencyService.Get<IMessanger>();
            Messages = new ObservableRangeCollection<Message>();

            SendCommand = new Command(() =>
            {
                var message = new Message
                {
                    Text = OutGoingText,
                    OutOrIn = true
                };

                Messages.Add(message);
                messanger?.SendMessage(message.Text);
                OutGoingText = string.Empty;
            });

            //if (messanger == null)
            //{
            //    return;
            //}

            //messanger.MessageAdded = (message) =>
            //{
            //    Messages.Add(message);
            //};
        }

    }
}
