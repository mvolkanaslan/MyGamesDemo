using MyGamesDemo.Abstract;
using MyGamesDemo.Entities;
using MyGamesDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using System.Threading.Tasks;

namespace MyGamesDemo.Adapters
{
    class MernisServiceAdapter : IPlayerCheckService
    {
        public static async Task<bool> TaskAsync(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12); ;
            var state = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year);
            return state.Body.TCKimlikNoDogrulaResult;
            
        }

        public bool PlayerCheckAsync(Player player)
        {
            return TaskAsync(player).Result;
        }
    }
}
