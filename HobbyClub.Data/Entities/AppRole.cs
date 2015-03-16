using Microsoft.AspNet.Identity.EntityFramework;
namespace HobbyClub.Data.Entities
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base() { }
        public AppRole(string name) : base(name) { }
    }
}