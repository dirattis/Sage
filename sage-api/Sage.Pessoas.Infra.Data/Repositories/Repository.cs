using Microsoft.EntityFrameworkCore;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sage.Pessoas.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected PessoaContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(PessoaContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {   
            DbSet.Update(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> GetAll<TProp>(params Expression<Func<TEntity, TProp>>[] includes)
        {
            var query = DbSet.AsQueryable();

            if (includes?.Count() > 0)
            {
                foreach (var prop in includes)
                    query = query.Include(prop);
            }
            return query.ToList();
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public TEntity GetById<TProp>(Guid id, params Expression<Func<TEntity, TProp>>[] includes)
        {
            var query = DbSet.AsQueryable();

            if (includes?.Count() > 0)
            {
                foreach (var prop in includes)
                    query = query.Include(prop);
            }
            
            return query.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }
        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
