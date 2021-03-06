﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HobbyClub.Data.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Commit();

        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> where);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        void Update(TEntity entity);
    }
}
