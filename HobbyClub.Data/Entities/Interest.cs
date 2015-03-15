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
        public virtual UInt32 LogoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
