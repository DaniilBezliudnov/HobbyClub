using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.DAL.Configuration
{
    class InterestEntityConfig : EntityTypeConfiguration<Interest>
    {
        public InterestEntityConfig()
        {
            this.ToTable("Interest");
            this.HasKey<UInt32>(i => i.InterestId);
            this.Property(p => p.Name).IsRequired()
                .HasMaxLength(300);
            this.Property(p => p.Description).IsRequired();
            this.HasOptional(p => p.LogoId)
                .WithRequired(i => i.Interest);
            this.HasMany<Group>(e => e.Groups)
                .WithMany(gr => gr.Interests)
                .Map(ig =>
                {
                    ig.MapLeftKey("InterestRefId");
                    ig.MapRightKey("GroupRefId");
                    ig.ToTable("InterestGroup");
                });
        }
    }
}
