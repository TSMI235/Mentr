using System;
using System.Collections.Generic;
using System.Text;
using Mentr.Services;
using Mentr.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MLToolkit.Forms.SwipeCardView.Core;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mentr.ViewModels
{
    class MatchesViewModel : BindableObject
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        private ObservableCollection<User> _matches;

        public ObservableCollection<User> Matches
        {
            get => _matches;
            set
            {
                _matches = value;
                this.RaisePropertyChanged();
            }
        }

        public ICommand SwipedCommand { get; }

        public ICommand DraggingCommand { get; }

        public ICommand DeclineCommand { get; }

        public ICommand AcceptCommand { get; }

        public MatchesViewModel()  
        {
            _matches = UserService.Instance.GetMatches();
          
            this.SwipedCommand = new Command<SwipedCardEventArgs>(this.OnSwipedCommand);
            this.DraggingCommand = new Command<DraggingCardEventArgs>(this.OnDraggingCommand);

            this.DeclineCommand = new Command(this.OnDeclineCommand);
            this.AcceptCommand = new Command(this.OnAcceptCommand);
        }

        private void OnSwipedCommand(SwipedCardEventArgs eventArgs)
        {
        }

        private void OnDraggingCommand(DraggingCardEventArgs eventArgs)
        {
            switch (eventArgs.Position)
            {
                case DraggingCardPosition.Start:
                    return;
                case DraggingCardPosition.UnderThreshold:
                    break;
                case DraggingCardPosition.OverThreshold:
                    break;
                case DraggingCardPosition.FinishedUnderThreshold:
                    return;
                case DraggingCardPosition.FinishedOverThreshold:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnDeclineCommand()
        {
        }

        private void OnAcceptCommand()
        {
            this.Matches = UserService.Instance.GetMatches();
        }


    }
}
