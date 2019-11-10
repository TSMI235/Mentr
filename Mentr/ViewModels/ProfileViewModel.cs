using System;
using System.Collections.Generic;
using System.Text;
using Mentr.Services;
using Mentr.Models;
using Xamarin.Forms;

namespace Mentr.ViewModels
{
    public class ProfileViewModel : BindableObject
    {
        private User _user;

        public ProfileViewModel()
        {
             User = UserService.Instance.GetTestUser();

        }

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }
    }
}
