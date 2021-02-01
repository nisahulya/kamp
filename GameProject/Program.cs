using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    //I codded this entire game project by myself so i am very happy. 


    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer { Id = 1,
                FirstName = "Nisa",
                LastName="Dastan", 
                NationalityId="12345678910",
                YearOfBirth=1994
            };

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "Demiroğ",
                NationalityId = "1234567236",
                YearOfBirth = 1985
            };

            Console.WriteLine(gamer1.FirstName);
            Console.WriteLine(gamer2.FirstName);


            GamerCheckManager gamerCheckManager1 = new GamerCheckManager();

            GamerManager gamerManager1 = new GamerManager(gamerCheckManager1);
            gamerManager1.Add(gamer1);
            gamerManager1.Delete(gamer1);
            gamerManager1.Update(gamer1);

            GamerManager gamerManager2 = new GamerManager(gamerCheckManager1);
            gamerManager2.Add(gamer2);
            gamerManager2.Delete(gamer2);
            gamerManager2.Update(gamer2);

            Game game1 = new Game
            {
                Id = 1,
                GameName = "Pubg",
                Price = 500,
                Amount = 1
            };

            GameManager gameManager1 = new GameManager();

            gameManager1.Add(game1);


            BaseCampaign baseCampaign1 = new HalfToHalfCampaign
            {
                Id = 1,

            };


            BaseCampaignManager baseCampaignManager1 = new HalfToHalfCampaignManager();

            baseCampaignManager1.Add(baseCampaign1);
            baseCampaignManager1.Update(baseCampaign1);
            baseCampaignManager1.Delete(baseCampaign1);

            BaseCampaign baseCampaign2 = new Buy1Free1Campaign
            {
                Id = 1,

            };


            BaseCampaignManager baseCampaignManager2 = new Buy1Free1CampaignManager();

            baseCampaignManager2.Add(baseCampaign2);
            baseCampaignManager2.Update(baseCampaign2);
            baseCampaignManager2.Delete(baseCampaign2);

            ISellManager iSellManager1 = new Buy1Free1CampaignManager();
            iSellManager1.Sell(game1, gamer1, baseCampaign2);

            ISellManager iSellManager2 = new HalfToHalfCampaignManager();
            iSellManager2.Sell(game1, gamer1, baseCampaign1);

            ISellManager iSellManager3 = new Buy1Free1CampaignManager();
            iSellManager3.Sell(game1, gamer1, baseCampaign2);





        }
    }
}
