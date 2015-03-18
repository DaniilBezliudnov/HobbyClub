using Microsoft.AspNet.Identity.EntityFramework;
namespace HobbyClub.Data.Entities
{
    public class Role : IdentityRole
    {
        public Role() : base() { }
        public Role(string name) : base(name) { }
    }
}