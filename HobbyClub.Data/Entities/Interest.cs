using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Entities
{
    public class Interest : IEntity
    {
        public Guid ID { get; set; }
        public virtual Logo Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
