using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Infrastructure
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private DbContext context;
        private DbSet<TEntity> table;

        public BaseRepository(IDataBaseFactory dataBaseFactory)
        {
            this.context = dataBaseFactory.Get();
            this.table = this.context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                this.table.Add(entity);
            }
        }
        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                this.table.Remove(entity);
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return this.table.Where(where).FirstOrDefault();
        }
        public void Update(TEntity entity)
        {
            if (entity != null)
            {
                this.table.Attach(entity);
                this.context.Entry(entity).State = EntityState.Modified;
            }
        }
        public IEnumerable<TEntity> GetAll()
        {
            return this.table;
        }
        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return this.table.Where(where);
        }

        public void Commit()
        {
            if (this.context == null)
            {
                throw new ArgumentNullException("Null reference Dbthis.context!");
            }

            using (var scope = this.context.Database.BeginTransaction())
            {
                this.context.SaveChanges();
                scope.Commit();
            }
        }
    }
}
