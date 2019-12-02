using Mentr.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mentr.Helpers
{
    public interface IMessanger
    {
        Task<bool> InitalizeAsync();
        void SendMessage(string text);
        //Action<Message> MessageAdded { get; set; }
    }
}
