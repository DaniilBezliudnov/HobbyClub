using HobbyClub.Data.Concrete;
using HobbyClub.Data.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Infrastructure.Manager
{
    class BaseManager
    {
        private IDataBaseFactory dbContext;

        public BaseManager()
        {

        }

        protected IDataBaseFactory Get()
        {
            if (dbContext == null)
                dbContext = new EntityDataBaseFactory(new HobbyClubContext());
            return this.dbContext;
        }
    }
}
