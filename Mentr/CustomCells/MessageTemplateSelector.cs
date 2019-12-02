using Mentr.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mentr.CustomCells
{
    class MessageTemplateSelector : DataTemplateSelector
    {
        public MessageTemplateSelector()
        {
            // Retain instances!
            this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Message;
            if (messageVm == null)
                return null;
            //return messageVm.IsIncoming ? this.incomingDataTemplate : this.outgoingDataTemplate;
            return this.outgoingDataTemplate;
        }

        private readonly DataTemplate incomingDataTemplate;
        private readonly DataTemplate outgoingDataTemplate;
    }
}
