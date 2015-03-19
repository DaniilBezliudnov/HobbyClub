using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Entities
{
    public class Photo :IEntity
    {
        public Guid ID { get; set; }
        public string Value { get; set; }
        public virtual User User { get; set; }
        public virtual Interest Interest { get; set; }
        public virtual Group Group { get; set; }
        public virtual Event Event { get; set; }
    }
}
