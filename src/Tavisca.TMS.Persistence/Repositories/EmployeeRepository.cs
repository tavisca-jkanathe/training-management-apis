using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Persistence.Entities.EmployeeDtos;
using Tavisca.TMS.Persistence.Translator.Employees;

namespace Tavisca.TMS.Persistence.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        EmployeeTranslator _translator = new EmployeeTranslator();
        IBaseDal<EmployeeDto> _dal = null;
        public EmployeeRepository(IBaseDal<EmployeeDto> dal)
        {
            _dal = dal;
        }


        public List<Employee> Get(Predicate<Employee> condition)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            var emp = _dal.Fetch();
            return _translator.Translate(emp);
        }

        public Employee GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<Employee> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(IEnumerable<Employee> entities)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
