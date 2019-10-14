using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.TMS.Contracts.Interfaces
{
    public interface IService<T> where T : class
    {
        T Create(T entity);
        void Update(string id, T entity);
        bool DeleteById(T entity);
        T GetById(string id);
        List<T> GetAll();
    }
}
