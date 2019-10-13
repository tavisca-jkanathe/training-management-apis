using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.TMS.Contracts.Interfaces
{
    public interface IBaseDal<T>
    {
        List<T> Fetch();
        T FetchById(string id);
        void Insert(T entity);
        void Remove(T entity);
        void Update(string id, T newEntity);
    }
}
