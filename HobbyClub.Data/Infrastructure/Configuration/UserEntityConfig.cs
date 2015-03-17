using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    class UserEntityConfig : EntityTypeConfiguration<AppUser>
    {
        public UserEntityConfig()
        {
            this.ToTable("User");
            this.HasKey(u => u.Id);
            this.Property(p => p.CreationDate)
                .HasColumnType("datetime2");
            this.Property(p => p.UserName).IsRequired();
            this.Property(p => p.SecondName).IsRequired();
            this.Property(p => p.Email).IsRequired();
            this.HasOptional(p => p.Photo)
                .WithRequired(u => u.User);

            this.HasMany<Event>(e => e.Events)
                .WithMany(u => u.Users)
                .Map(us =>
                    {
                        us.MapLeftKey("UserRefId");
                        us.MapRightKey("EventRefId");
                        us.ToTable("UserEvent");
                    });
            this.HasMany<Group>(e => e.Groups)
                .WithMany(u => u.Users)
                .Map(us =>
                    {
                        us.MapLeftKey("UserRefId");
                        us.MapRightKey("GroupRefId");
                        us.ToTable("UserGroup");
                    });
           this.HasMany<Interest>(e => e.Interests)
                .WithMany(u => u.Users)
                .Map(us =>
                {
                    us.MapLeftKey("UserRefId");
                    us.MapRightKey("InterestRefId");
                    us.ToTable("UserInterest");
                });
        }
    }
}
