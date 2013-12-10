using System.Collections.Generic;
using CocoFarm.Model;

namespace CocoFarm.DataAccess
{
    public interface IDataStore<T, TId>
        where T : IEntityWithId<TId>
    {
        IEnumerable<T> GetAll();
        T GetById(TId id);
        T Create(T entity);
        T Update(T entity);
        void Delete(TId id);
    }
}
