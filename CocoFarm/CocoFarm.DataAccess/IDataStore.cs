using System.Collections.Generic;
using CocoFarm.Model;

namespace CocoFarm.DataAccess
{
    public interface IDataStore<T>
        where T : IEntityWithId
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
