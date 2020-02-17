using System;
using System.Collections.Generic;
using System.Text;

namespace Sage.Pessoas.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        TEntity GetById(Guid id);

        IEnumerable<TEntity> GetAll();

        void Delete(Guid id);
    }
}
