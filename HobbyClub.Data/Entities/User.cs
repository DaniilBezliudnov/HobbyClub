using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using HobbyClub.Data.Abstract;
namespace HobbyClub.Data.Entities
{
    public class User : IdentityUser/*, IEntity*/
    {

        public string SecondName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }

        //public Guid ID
        //{
        //    get
        //    {
        //        return Guid.Parse(base.Id);
        //    }
        //    set
        //    {
        //        base.Id = value.ToString();
        //    }
        //}
    }
}