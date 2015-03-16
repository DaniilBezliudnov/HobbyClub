using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace HobbyClub.Data.Infrastructure
{
    public interface IDataBaseFactory
    {
        DbContext Get();
    }
}
