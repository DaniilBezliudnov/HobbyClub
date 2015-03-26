using HobbyClub.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    class CountryEntityConfig :EntityTypeConfiguration<Country>
    {
        public CountryEntityConfig()
        {
            this.ToTable("Country");
            this.HasKey<Guid>(p => p.ID);
            this.Property(p => p.ID).HasColumnName("CountryId");
            this.Property(p => p.Name)
                .IsRequired();
            this.HasMany(e => e.Cities)
                .WithRequired(e => e.Country)
                .Map(e => e.MapKey("CountryId"));
        }
    }
}
