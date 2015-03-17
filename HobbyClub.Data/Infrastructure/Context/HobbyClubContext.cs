using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Infrastructure.Configuration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Context
{
    public class HobbyClubContext : DbContext
    {
        public HobbyClubContext()
            : this("HobbyClubConnection")

        {

        }
        public HobbyClubContext(string connString)
            : base(connString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EventEntityConfig());
            modelBuilder.Configurations.Add(new GroupEntityConfig());
            modelBuilder.Configurations.Add(new InterestEntityConfig());
            modelBuilder.Configurations.Add(new PhotoEntityConfig());
            modelBuilder.Configurations.Add(new UserEntityConfig());
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
