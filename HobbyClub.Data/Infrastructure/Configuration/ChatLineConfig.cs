using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class ChatLineConfig : EntityTypeConfiguration<ChatLine>
    {
        public ChatLineConfig()
        {
            this.ToTable("ChatLine");
            this.HasKey(k => k.ID);
            this.Property(p => p.ID).HasColumnName("ChatLineId");

        }
    }
}
