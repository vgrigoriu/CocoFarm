using System.Data.Entity;
using CocoFarm.Model;
using System;
using System.Collections.Generic;

namespace CocoFarm.DataAccess
{
    public class DbContextDataStore<T> : IDataStore<T, Guid> where T : class, IEntityWithId<Guid>, new()
    {
        private readonly DbContext context;

        public DbContextDataStore(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        public T Create(T entity)
        {
            entity.Id = Guid.NewGuid();
            context.Set<T>().Add(entity);
            context.SaveChanges();

            return entity;
        }

        public T Update(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity;
        }

        public void Delete(Guid id)
        {
            context.Entry(new T {Id = id}).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
