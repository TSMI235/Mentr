﻿using System;
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

        public ICommand ClearItemsCommand { get; }

        public ICommand AddItemsCommand { get; }

        public MatchesViewModel()  
        {
            _matches = new ObservableCollection<User>();
            for (var i = 1; i <= 5; i++)
            {
                _matches.Add(UserService.Instance.GetTestUser());
            }

            this.SwipedCommand = new Command<SwipedCardEventArgs>(this.OnSwipedCommand);
            this.DraggingCommand = new Command<DraggingCardEventArgs>(this.OnDraggingCommand);

            this.ClearItemsCommand = new Command(this.OnClearItemsCommand);
            this.AddItemsCommand = new Command(this.OnAddItemsCommand);
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

        private void OnClearItemsCommand()
        {
            this.Matches.Clear();
        }

        private void OnAddItemsCommand()
        {
            for (var i = 1; i <= 5; i++)
            {
                Matches.Add(UserService.Instance.GetTestUser());
            }
        }


    }
}