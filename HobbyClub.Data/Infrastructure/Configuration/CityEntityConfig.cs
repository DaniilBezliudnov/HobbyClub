using HobbyClub.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    class CityEntityConfig : EntityTypeConfiguration<City>
    {
        public CityEntityConfig ()
	    {
            this.ToTable("City");
            this.HasKey<Guid>(p => p.ID);
            this.Property(p => p.ID).HasColumnName("CityId");
            this.Property(p => p.Name)
                .IsRequired();
           
	    }
        
    }
}
