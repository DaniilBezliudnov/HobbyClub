using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.DAL.Configuration
{
    class PhotoEntityConfig : EntityTypeConfiguration<Photo>
    {
        public PhotoEntityConfig()
        {
            this.ToTable("Photo");
            this.HasKey(p => p.PhotoId);
            this.Property(p => p.Value).IsRequired();
        }
    }
}
