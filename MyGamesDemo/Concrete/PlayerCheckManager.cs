using MyGamesDemo.Abstract;
using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool PlayerCheckAsync(Player player)
        {
            return true;
        }
    }
}
