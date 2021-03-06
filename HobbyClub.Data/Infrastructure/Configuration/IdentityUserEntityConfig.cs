﻿using System;
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
            this.ToTable("User");
            this.HasKey(u => u.Id);
            this.Property(u => u.Id).HasColumnName("UserId");
            this.Property(p => p.CreationDate)
                .HasColumnType("datetime2");
            this.Property(p => p.UserName);

            this.Property(p => p.SecondName);
            this.Ignore(p => p.ID);
            this.Property(p => p.Email)
                .IsRequired();
            this.HasOptional<City>(c => c.City)
                .WithOptionalDependent()
                .Map(c => c.MapKey("CityId"));
            this.HasMany<Event>(e => e.CreatedEvents)
                .WithRequired(e => e.Creator)
                .Map(e => e.MapKey("CreatorId"))
                .WillCascadeOnDelete(false);
            this.HasMany<Event>(e => e.Events)
                .WithMany(u => u.Users)
                .Map(us =>
                {
                    us.MapLeftKey("UserId");
                    us.MapRightKey("EventId");
                    us.ToTable("UserEvent");
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
