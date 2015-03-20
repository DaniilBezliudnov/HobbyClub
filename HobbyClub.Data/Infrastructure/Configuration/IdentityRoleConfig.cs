using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    class IdentityRoleConfig : EntityTypeConfiguration<Role>
    {
        public IdentityRoleConfig()
        {

            this.HasKey(r => r.Id);
            this.Property(r => r.Id).HasColumnName("RoleId");
            this.Ignore(r => r.ID);
        }
    }
}
