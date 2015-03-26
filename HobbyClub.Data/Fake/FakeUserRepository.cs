using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Entities;

namespace HobbyClub.Data.Fake
{
    class FakeUserRepository:IFakeRepository<User>
    {
        private Dictionary<int, User> fakeData;

        public FakeUserRepository()
        {

        }
        
        public void Add(User entity)
        {
            
            //throw new NotImplementedException();
        }

        public User Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> FakeData
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
