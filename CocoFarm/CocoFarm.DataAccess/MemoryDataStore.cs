using CocoFarm.Model;
using System;
using System.Collections.Generic;

namespace CocoFarm.DataAccess
{
    public class MemoryDataStore<TEntity> : IDataStore<TEntity, Guid>
        where TEntity : IEntityWithId<Guid>
    {
        public TEntity GetById(Guid id)
        {
            return Storage[id];
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Storage.Values;
        }

        public TEntity Create(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            Storage.Add(entity.Id, entity);

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            Storage[entity.Id] = entity;
            return entity;
        }

        public void Delete(Guid id)
        {
            Storage.Remove(id);
        }

        private static readonly Dictionary<Guid, TEntity> Storage = new Dictionary<Guid, TEntity>();
    }
}
