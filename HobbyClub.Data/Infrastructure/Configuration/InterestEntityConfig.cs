using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class InterestEntityConfig : EntityTypeConfiguration<Interest>
    {
        public InterestEntityConfig()
        {
            this.ToTable("Interest");
            this.HasKey<Guid>(i => i.ID);
            this.Property(i => i.ID).HasColumnName("InterestId");
            this.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(300);
            this.Property(p => p.Description)
                .IsRequired();
            this.HasMany<Event>(e => e.Events)
                .WithRequired(e => e.Interest)
                .Map(e => e.MapKey("InterestId"));
            this.HasOptional(e => e.ParentId)
                .WithOptionalPrincipal()
                .Map(m=>m.MapKey("ParentId"));
            this.HasMany<Group>(e => e.Groups)
                .WithMany(gr => gr.Interests)
                .Map(ig =>
                {
                    ig.MapLeftKey("InterestId");
                    ig.MapRightKey("GroupId");
                    ig.ToTable("InterestGroup");
                });
        }
    }
}
