using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
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
            };

            GameManager gameManager1 = new GameManager();

            gameManager1.Add(game1);
            gameManager1.Sell(gamer1, game1);

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "½50", 
            };

            CampaignManager campaignManager1 = new CampaignManager();

            campaignManager1.Add(campaign1);
            campaignManager1.Delete(campaign1);
            campaignManager1.Update(campaign1);
        }
    }
}
