using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    class EventEntityConfig : EntityTypeConfiguration<Event>
    {
        public EventEntityConfig()
        {
            this.ToTable("Event");
            this.HasKey<Guid>(p=>p.EventID);
            this.Property(p=>p.Name).IsRequired();
            this.Property(p=>p.Description).IsRequired();
            this.Property(p=>p.CreationDate)
                .HasColumnType("datetime2")
                .IsRequired();
            this.HasRequired<Group>(g => g.Group)
                .WithMany(e => e.Events)
                .HasForeignKey(e => e.EventID);
            //this.HasRequired<AppUser>(u => u.CreatorID)
            //    .WithMany(e => e.Events)
            //    .HasForeignKey(e => e.EventID);
            //this.HasRequired<Interest>(i => i.Interest)
            //    .WithMany(e => e.Events)
            //    .HasForeignKey(e => e.EventID);
            //this.HasOptional(p => p.LogoID)
            //    .WithRequired(g => g.Event);

        }
    }
}
