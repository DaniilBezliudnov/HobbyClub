using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Entities
{
    class Event
    {
        public UInt32 EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EventType EventType  { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Photo LogoID { get; set; }
        public virtual Interest Interest { get; set; }
        public virtual Group Group { get; set; }
        public virtual User CreatorID { get; set; }
        
    }

    enum EventType
    {
        Public,
        Private
    }
}
