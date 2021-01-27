using MyGamesDemo.Abstract;
using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool PlayerCheck(Player player)
        {
            //Kullanıcı bilgi kontrolünden sonra bu yaş kontrolü yapıldığını düşünelim.
            if (player.Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
