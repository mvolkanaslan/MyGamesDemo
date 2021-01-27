using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Abstract
{
    public interface IPlayerCheckService
    {
        bool PlayerCheck(Player player); 
    }
}
