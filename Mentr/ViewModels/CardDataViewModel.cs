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
            //App.Database.ClearDatabase();
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
            //FillCollection();
        }

        // Gets Collection from DB
        //protected async void FillCollection()
        //{
        //    CardDataCollection = await App.Database.GetArticlesAsync();
        //}

        // Adds in a Test Card 
        private void GenerateCardModel()
        {
            //await App.Database.SaveArticleAsync(new CardDataModel
            CardDataCollection = new ObservableCollection<CardDataModel>
            {
                new CardDataModel
                {
                HeadTitle = "17m ago - Duncan William",
                HeadLines = "Publication on Recursive Function Theory",
                ProfileImage = "https://www.lsu.edu/eng/cse/people/faculty/photos/william.duncan.jpg",
                HeadLinesDesc = "For those interested in recursive function theory, I'd recommend reading Cutland's Computability: An Introduction to Recusrive Function Theory (Cambridge)" +
                "by Nigel J. Cutland. It is written in a way where undergraduates will not require a vast mathematical background.", 
                },
                new CardDataModel
                {
                HeadTitle = "3h ago - Steve Cai",
                HeadLines = "Available Times",
                ProfileImage = "https://www.lsu.edu/eng/cee/images/steve.cai.jpg",
                HeadLinesDesc = "I will be in my office for for the next two hours if any mentees would like to come in or call. Hope finals studying is going well!"
                },
                new CardDataModel
                {
                HeadTitle = "11h ago - Joesph Cabral",
                HeadLines = "Article Relating to Information Systems in Buisness",
                ProfileImage = "https://www.lsu.edu/business/images/Faculty-and-Staff/cabral-joseph-120x168.jpg",
                HeadLinesDesc = "Just read a really good article discussing why information systems are important for any buisness which connects with what we discussed in class earlier (for those" +
                "taking my class). It's a quick read, highly recommend."
                },
                new CardDataModel
                {
                HeadTitle = "12/3/2019 - Bonnie Achee",
                HeadLines = "Checking in on you guys",
                ProfileImage = "https://www.lsu.edu/business/images/Faculty-and-Staff/cabral-joseph-120x168.jpg",
                HeadLinesDesc = "Hope you all had a wonderful Thanksgiving and are preparing for your finals. I'm always available, just message me on the app."
                },
            };
        }

        // Adds a new card to the database, Wrapper Method
        public async void AddCardModel(CardDataModel card)
        {
            await App.Database.SaveArticleAsync(card);
        }
    }
}
