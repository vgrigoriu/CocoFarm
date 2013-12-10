using System;
using System.Collections.Generic;
using System.Linq;
using CocoFarm.Model;

namespace CocoFarm.DataAccess
{
    public class MemoryDataStore<TEntity> : IDataStore<TEntity, Guid>
        where TEntity : IEntityWithId<Guid>
    {
        public TEntity GetById(Guid id)
        {
            return storage[id];
        }

        public IEnumerable<TEntity> GetAll()
        {
            return storage.Select(keyValue => keyValue.Value);
        }

        public TEntity Create(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            storage.Add(entity.Id, entity);

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            storage[entity.Id] = entity;
            return entity;
        }

        public void Delete(Guid id)
        {
            storage.Remove(id);
        }

        private static readonly Dictionary<Guid, TEntity> storage = new Dictionary<Guid, TEntity>();
    }
}
