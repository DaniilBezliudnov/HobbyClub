using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class LogoEntityConfig : EntityTypeConfiguration<Logo>
    {
        public LogoEntityConfig()
        {
            this.ToTable("Logo");
            this.HasKey<Guid>(p => p.ID);
            this.Property(p => p.ID).HasColumnName("LogoId");
            this.Property(p => p.Value).IsRequired();
            this.HasOptional(e => e.User)
                .WithOptionalPrincipal(e => e.Photo)
                .Map(e => e.MapKey("LogoId"));
            this.HasOptional(e => e.Group)
                .WithOptionalPrincipal(e => e.Logo)
                .Map(e => e.MapKey("LogoId"));
            this.HasOptional(e => e.Event)
                .WithOptionalPrincipal(e => e.Logo)
                .Map(e => e.MapKey("LogoId"));
            this.HasOptional(e => e.Interest)
                .WithOptionalPrincipal(e => e.Logo)
                .Map(e => e.MapKey("LogoId"));
        }
    }
}
