using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerManager
    {
        

        public virtual void Add(Player player)
        {
                Console.WriteLine("Yeni oyuncu Eklendi : " + player.FirstName + " " + player.LastName);    
        }

        public  void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi : " + player.FirstName + " " +player.LastName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + player.FirstName + " " + player.LastName);
        }
    }
}
