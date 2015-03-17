using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Entities
{
    public class Group
    {
        public Guid GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Photo Logo { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<AppUser> Users { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
