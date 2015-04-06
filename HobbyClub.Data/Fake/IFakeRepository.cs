using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Fake
{
    interface IFakeRepository<T> where T : IEntity
    {
        void Add(T entity);
        T Delete(T entity);
        void Update(T entity);
        IQueryable<T> FakeData { get; set; }
    }
}
