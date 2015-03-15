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
        public virtual UInt32 LogoID { get; set; }
        public virtual UInt32 InterestID { get; set; }
        public virtual UInt32 GroupID { get; set; }
        public virtual UInt32 CreatorID { get; set; }
        
    }

    enum EventType
    {
        Public,
        Private
    }
}
