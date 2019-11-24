using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            GenerateCardModel();
            FillCollection();
        }

        protected async void FillCollection()
        {
            CardDataCollection = await App.Database.GetArticlesAsync();
        }

        private async void GenerateCardModel()
        {
            await App.Database.SaveArticleAsync(new CardDataModel
            {
                HeadTitle = "This is a test",
                HeadLines = "This Test adds a new entery every time on startup",
                ProfileImage = "Settings.png",
                HeadLinesDesc = "More words to hopefully fill up the card to make it look like it works!"
            });
        }
    }
}
