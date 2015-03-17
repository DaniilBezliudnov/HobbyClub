using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HobbyClub.Data.Entities
{
    public class Photo
    {
        public Guid PhotoId { get; set; }
        public string Value { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Interest Interest { get; set; }
        public virtual Group Group { get; set; }
        public virtual Event Event { get; set; }
    }
}
