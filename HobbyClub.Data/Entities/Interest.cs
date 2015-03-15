using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Entities
{
    class Interest
    {
        public UInt32 InterestId { get; set; }
        public virtual Photo LogoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
