using MyGamesDemo.Abstract;
using MyGamesDemo.Concrete;
using MyGamesDemo.Entities;
using System;

namespace MyGamesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            IPlayerManager playerManager = new PlayerManager();
            ICampaignService campaignService = new CampaignManager();
            ISalesService salesService = new SalesManager();
            // Oyunları sanallaştırmadım. Şimdilik
            Game game1 = new Game {
                Id=1,
                Name= "Crysis 3",
                Price=20
            };

            // Player Add,Update,Delete control simulation



            Console.WriteLine("\n------ Player Add , Update , Delete Management-------\n");
            Player player1 = new Player{
            Id=1,
            FirstName="Volkan",
            LastName="ASLAN",
            Age = 30,
            NationalityId="123456789"
            };
            Player player2 = new Player
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "DEMİROĞ",
                Age = 33,
                NationalityId = "93468162354"
            };
            Player player3 = new Player
            {
                Id = 3,
                FirstName = "Mustafa Murat",
                LastName = "COŞKUN",
                Age = 31,
                NationalityId = "816131351"
            };

            playerManager.Add(player1);
            playerManager.Update(player2);
            playerManager.Delete(player3);
            //----------------------------------------------------------------------

            //Campaign Add,Update control Simulation

            Console.WriteLine("\n------ Campaign Add , Update , Delete Management-------\n");

            Campaign campaign1 = new Campaign {
                Name = "New Player Discount",
                DiscountRate = 0.1
            };
            Campaign campaign2 = new Campaign
            {
                Name = "5-Year Membership Discount",
                DiscountRate = 0.3
            };
            Campaign campaign3 = new Campaign
            {
                Name = "Most Active Membership",
                DiscountRate = 0.1
            };
            campaignService.Add(campaign1);
            campaignService.Update(campaign2);
            campaignService.Delete(campaign1);

            // Sale Management Simulatin
            Console.WriteLine("\n------ Sale Management-------\n");

            //Burada aynı kişi ve oyuncu için normal satış
            salesService.Purchase(player1, game1);
            //Burada aynı kişi ve oyuncu için kampanyalı satış
            salesService.Purchase(player1, game1,campaign2);

            Console.ReadLine();
        }
    }
}
