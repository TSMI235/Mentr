using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using Mentr.Models;

namespace Mentr.ViewModels
{
    public class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            CardDataCollection = new ObservableCollection<CardDataModel>
            {
                new CardDataModel
                {
                    HeadTitle = "This is a test",
                    HeadLines = "This is another long test for the head lines",
                    ProfileImage = "Settings.png",
                    HeadLinesDesc = "More words to hopefully fill up the card to make it look like it works!"
                },

                new CardDataModel
                {
                    HeadTitle = "This is a test",
                    HeadLines = "This is another long test for the head lines",
                    ProfileImage = "Settings.png",
                    HeadLinesDesc = "More words to hopefully fill up the card to make it look like it works!"
                },

                new CardDataModel
                {
                    HeadTitle = "This is a test",
                    HeadLines = "This is another long test for the head lines",
                    ProfileImage = "Settings.png",
                    HeadLinesDesc = "More words to hopefully fill up the card to make it look like it works!"
                }
            };
        }
    }
}
