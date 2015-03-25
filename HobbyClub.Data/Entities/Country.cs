using System;
using System.Collections.Generic;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Entities
{
   public class Country :IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
