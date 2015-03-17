using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class EventEntityConfig : EntityTypeConfiguration<Event>
    {
        public EventEntityConfig()
        {
            this.ToTable("Event");
            this.HasKey<Guid>(p => p.EventId);
            this.Property(p => p.Name)
                .IsRequired();
            this.Property(p => p.Description)
                .IsRequired();
            this.Property(p => p.CreationDate)
                .HasColumnType("datetime2")
                .IsRequired();
            //this.HasRequired<User>(u => u.Creator)
            //    .WithRequiredDependent(e => e.)
            //    .Map(e => e.MapKey("EventCreatorId"));
        }
    }
}
