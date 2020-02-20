using Microsoft.EntityFrameworkCore;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
        
        public TEntity GetById(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
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
