using HobbyClub.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Infrastructure.Configuration
{
    public class UserGroupEntityConfig : EntityTypeConfiguration<UserGroup>
    {
        public UserGroupEntityConfig()
        {
            this.ToTable("UserGroup");
            this.HasKey(k => new { k.GroupId, k.UserId });
            this.HasRequired(p => p.Group)
                .WithMany(p => p.UserGroups)
                .Map(m => m.MapKey("GroupIdRef"));
            this.HasRequired(p => p.User)
                .WithMany(p => p.UserGroups)
                .Map(m => m.MapKey("UserIdRef"));
        }
    }
}
