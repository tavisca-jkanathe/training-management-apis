using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.TMS.Contracts.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        TEntity GetById(string Id);
        List<TEntity> GetAll();
        void Insert(TEntity entity);
        void Update(string id, TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void Remove(IEnumerable<TEntity> entities);
    }
}
