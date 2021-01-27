using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Abstract
{
    public interface ISalesService
    {
        // Doğru mu yaptım bilmiyorum ama eğer satış kamapanyalı ise kampanya girdisi ekledim.
        // overloading 
        void Purchase(Player player,Game game);
        void Purchase(Player player, Game game,Campaign campaign);
    }
}
