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

        // Populates CardDataCollection, Collection of articles for social view
        public CardDataViewModel()
        {
            App.Database.ClearDatabase();
            GenerateCardModel();
            FillCollection();
        }

        // Gets Collection from DB
        protected async void FillCollection()
        {
            CardDataCollection = await App.Database.GetArticlesAsync();
        }

        // Adds in a Test Card 
        private async void GenerateCardModel()
        {
            await App.Database.SaveArticleAsync(new CardDataModel
            {
                HeadTitle = "The Social Page!",
                HeadLines = "This test demonstrates the Social Article Feature!",
                ProfileImage = "Settings.png",
                HeadLinesDesc = "It can be used for posting articles and status posts by Mentors!"
            });
        }

        // Adds a new card to the database, Wrapper Method
        public async void AddCardModel(CardDataModel card)
        {
            await App.Database.SaveArticleAsync(card);
        }
    }
}
