using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Abstract
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
