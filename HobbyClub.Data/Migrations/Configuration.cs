using HobbyClub.Data.Entities;
using HobbyClub.Data.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity;
namespace HobbyClub.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<HobbyClub.Data.Infrastructure.HobbyClubIdentityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HobbyClub.Data.Infrastructure.HobbyClubIdentityDbContext context)
        {
            AppUserManager userMgr = new AppUserManager(new UserStore<AppUser>(context));
            AppRoleManager roleMgr = new AppRoleManager(new RoleStore<AppRole>(context));
            string roleName = "Admin";
            string userName = "Admin";
            string password = "Qwerty";
            string email = " admin@example.com ";

            if (!roleMgr.RoleExists(roleName))
            {
                roleMgr.Create(new AppRole(roleName));
            }
            AppUser user = userMgr.FindByName(userName);
            if (user == null)
            {
                userMgr.Create(new AppUser { UserName = userName, Email = email, SecondName= "Adminium", CreationDate=DateTime.Today },
                password);
                user = userMgr.FindByName(userName);
            }
            if (!userMgr.IsInRole(user.Id, roleName))
            {
                userMgr.AddToRole(user.Id, roleName);
            }
            context.SaveChanges();
        }
    }
}
