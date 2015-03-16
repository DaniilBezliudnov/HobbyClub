using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    class GroupEntityConfig : EntityTypeConfiguration<Group>
    {
        public GroupEntityConfig()
        {
            this.ToTable("Group");
            this.HasKey<UInt32>(gr => gr.GroupId);
            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.Description).IsRequired();
            this.HasOptional(p => p.Users);
            this.HasOptional(p => p.LogoID)
                .WithRequired(g => g.Group);
            this.HasOptional(g => g.Events);
        }
    }
}
