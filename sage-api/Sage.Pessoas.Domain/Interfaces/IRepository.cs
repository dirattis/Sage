using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Sage.Pessoas.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        TEntity GetById(Guid id);

        TEntity GetById<TProp>(Guid id, params Expression<Func<TEntity, TProp>>[] includes);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll<TProp>(params Expression<Func<TEntity, TProp>>[] includes);

        void Delete(Guid id);

        int SaveChanges();

        void Dispose();
    }
}
