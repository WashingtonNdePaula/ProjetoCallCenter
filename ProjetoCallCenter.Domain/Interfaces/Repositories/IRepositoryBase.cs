
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Dispose();
    }
}
