using MyGamesDemo.Abstract;
using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Concrete
{
    public class PlayerManager : BasePlayerManager
    {


        // burada abstruck sınıftan miras alınan Add methoduna oyuncu kimlik kontrol servisini entegrasyonunu simüle ettik.
        private IPlayerCheckService _playerCheckService = new PlayerCheckManager();
        public override void Add(Player player)
        {
            if (_playerCheckService.PlayerCheck(player))
            {
                Console.WriteLine("Geçerli Kullanıcı....");
                base.Add(player);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli kullanıcı bilgileri giriniz...");
            }
            
        }
    }
}
