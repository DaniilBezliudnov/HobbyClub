using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
namespace HobbyClub.Data.Entities
{
    //public enum Cities
    //{
    //    LONDON, PARIS, CHICAGO
    //}
    public class AppUser : IdentityUser
    {
       // public Cities City { get; set; }
        public string SecondName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
    }
}