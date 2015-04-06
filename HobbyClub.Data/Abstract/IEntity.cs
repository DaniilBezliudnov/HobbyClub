using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Abstract
{
    public interface IEntity
    {
        Guid ID { get; set; }
    }
}
