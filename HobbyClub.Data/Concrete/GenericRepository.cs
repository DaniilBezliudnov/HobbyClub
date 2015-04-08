using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HobbyClub.Data.Abstract;

namespace HobbyClub.Data.Concrete
{
    //abstract
    public  class GenericRepository<TEntity, TContext> :
        IBaseRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        private readonly TContext _context = new TContext();

        public DbSet<TEntity> Table
        {
            get { return _context.Set<TEntity>(); }
        }

        public virtual void Add(TEntity entity)
        {
            if (entity != null)
            {
                this.Table.Add(entity);
            }
        }
        public virtual void Delete(TEntity entity)
        {
            if (entity != null)
            {
                this.Table.Remove(entity);
            }
        }
        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return this.Table.Where(where).FirstOrDefault();
        }
        public virtual void Update(TEntity entity)
        {
            if (entity != null)
            {
                this.Table.Attach(entity);
                this._context.Entry(entity).State = EntityState.Modified;
            }
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return this.Table;
        }
        public virtual IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return this.Table.Where(where);
        }

        public virtual void Commit()
        {
            if (this._context == null)
                throw new ArgumentNullException("Null reference Dbcontext!");

            using (var scope = this._context.Database.BeginTransaction())
            {
                this._context.SaveChanges();
                scope.Commit();
            }
        }
    }
}
