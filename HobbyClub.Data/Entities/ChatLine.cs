using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Entities
{
    public class ChatLine : IEntity
    {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public Group Group { get; set; }
        public User User { get; set; }
        public DateTime CreationDateTime { get; set; }

    }
}
