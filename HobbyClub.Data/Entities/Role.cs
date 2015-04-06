using Microsoft.AspNet.Identity.EntityFramework;
using HobbyClub.Data.Abstract;
using System;

namespace HobbyClub.Data.Entities
{
    public class Role : IdentityRole, IEntity
    {
        public Role() : base() { }
        public Role(string name) : base(name) { }

        public System.Guid ID
        {
            get
            {
                return Guid.Parse(base.Id);
            }
            set
            {
                base.Id = value.ToString();
            }
        }
    }
}