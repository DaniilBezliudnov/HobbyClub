﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class GroupEntityConfig : EntityTypeConfiguration<Group>
    {
        public GroupEntityConfig()
        {
            this.ToTable("Group");
            this.HasKey<Guid>(gr => gr.ID);
            this.Property(gr => gr.ID).HasColumnName("GroupId");
            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.Description).IsRequired();
            this.HasMany(e => e.Events)
                .WithOptional(e => e.Group)
                .Map(e => e.MapKey("GroupId"));
            this.HasOptional<City>(c => c.City)
                .WithOptionalDependent()
                .Map(c => c.MapKey("CityId"));
        }
    }
}
