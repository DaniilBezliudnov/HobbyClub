using System;
using System.Collections.Generic;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Entities
{
   public class City : IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
    }
}
