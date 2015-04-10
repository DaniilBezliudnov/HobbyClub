using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class EventEntityConfig : EntityTypeConfiguration<Event>
    {
        public EventEntityConfig()
        {
            this.ToTable("Event");
            this.HasKey<Guid>(p => p.ID);
            this.Property(p => p.ID).HasColumnName("EventId");
            //this.Property(p=> p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name)
                .IsRequired();
            this.Property(p => p.Description)
                .IsRequired();
            this.Property(p => p.Place)
                .IsRequired();
            this.Property(p => p.Time)
                .HasColumnType("datetime2")
                .IsRequired();
            this.Property(p => p.CreationDate)
                .HasColumnType("datetime2")
                .IsRequired();
            this.HasOptional<City>(c => c.City)
               //.WithMany()
            .WithOptionalDependent()
            .Map(c => c.MapKey("CityId"));
                            
        }
    }
}
