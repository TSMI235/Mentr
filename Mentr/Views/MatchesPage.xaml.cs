using System;
using System.Collections.Generic;
using MLToolkit.Forms.SwipeCardView.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mentr.ViewModels;
using Mentr.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mentr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchesPage : ContentPage
    {
        public MatchesPage()
        {
            InitializeComponent();
            this.BindingContext = new MatchesViewModel();
        }
        private void OnDragging(object sender, DraggingCardEventArgs e)
        {

        }
    }
}