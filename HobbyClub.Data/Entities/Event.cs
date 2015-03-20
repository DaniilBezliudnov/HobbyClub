using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Entities
{
    public class Event : IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Logo Logo { get; set; }
        public virtual Interest Interest { get; set; }
        public virtual Group Group { get; set; }
        //public virtual User Creator { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }

    public enum EventType
    {
        Public,
        Private
    }
}
