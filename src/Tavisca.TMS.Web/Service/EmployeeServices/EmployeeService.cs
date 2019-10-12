using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;

namespace Tavisca.TMS.Web.Service.EmployeeServices
{
    class EmployeeService : IService<Employee>
    {
        IRepository<Employee> repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public Employee Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(Employee entity)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return repository.GetAll();
        }

        public Employee GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
