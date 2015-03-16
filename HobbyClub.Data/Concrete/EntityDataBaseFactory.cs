using HobbyClub.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HobbyClub.Data.Concrete
{
    class EntityDataBaseFactory : IDataBaseFactory, IDisposable
    {
        private DbContext context;
        public EntityDataBaseFactory(DbContext context)
        {
            this.context = context;
        }
        public DbContext Get()
        {
            if (context != null)
                return context;
            else return null;
        }
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
