using MyGamesDemo.Abstract;
using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Concrete
{
    public class PlayerManager : IPlayerManager
    {


        // burada abstruck sınıftan miras alınan Add methoduna oyuncu kimlik kontrol servisini entegrasyonunu simüle ettik.
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.PlayerCheckAsync(player))
            {
                Console.WriteLine("Geçerli Kullanıcı....");
                Console.WriteLine("Oyuncu Eklendi : " + player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli kullanıcı bilgileri giriniz...");
            }

        }


        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi : " + player.FirstName + " " + player.LastName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + player.FirstName + " " + player.LastName);
        }
    }
}
