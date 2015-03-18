using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class IdentityUserEntityConfig : EntityTypeConfiguration<User>
    {
        public IdentityUserEntityConfig()
        {
            this.HasKey(u => u.Id);
            this.Property(p => p.CreationDate)
                .HasColumnType("datetime2");
            this.Property(p => p.UserName);

            this.Property(p => p.SecondName);
                
            this.Property(p => p.Email)
                .IsRequired();
            this.HasMany<Event>(e => e.Events)
                .WithMany(u => u.Users)
                .Map(us =>
                {
                    us.MapLeftKey("UserId");
                    us.MapRightKey("EventId");
                    us.ToTable("UserEvent");
                });
            this.HasMany<Group>(u => u.Groups)
                .WithMany(u => u.Users)
                .Map(us =>
                {
                    us.MapLeftKey("UserId");
                    us.MapRightKey("GroupId");
                    us.ToTable("UserGroup");
                });
            this.HasMany<Interest>(e => e.Interests)
                 .WithMany(u => u.Users)
                 .Map(us =>
                 {
                     us.MapLeftKey("UserId");
                     us.MapRightKey("InterestId");
                     us.ToTable("UserInterest");
                 });
        }
    }
}
