using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamesDemo.Entities
{
    public class Player:IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int Age { get; set; }
    }
}
