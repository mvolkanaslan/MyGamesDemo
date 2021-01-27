using MyGamesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);

    }
}
