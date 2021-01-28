using MyGamesDemo.Abstract;
using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Concrete
{
    class SalesManager : ISalesService
    {
        public void Purchase(Player player, Game game)
        {
            Console.WriteLine("Satın Alma işlemi gerçekleşti.\n\n Alıcı : " + player.FirstName + " " + player.LastName 
                 +"\n Oyun Adı : "+game.Name+"\n Fiyat : "+ game.Price.ToString() +"$ \n");
        }
        public void Purchase(Player player, Game game,Campaign campaign)
        {
            Console.WriteLine("Satın Alma işlemi gerçekleşti.\n\n Alıcı : " + player.FirstName + " " + player.LastName
                 + "\n Oyun Adı : " + game.Name +"\n Kampanya : "+campaign.Name+"\n İndirim Oranı : %"+campaign.DiscountRate*10+ "\n Fiyat : " + (game.Price*(1-campaign.DiscountRate)).ToString()+ "$ \n");
        }
    }
}
