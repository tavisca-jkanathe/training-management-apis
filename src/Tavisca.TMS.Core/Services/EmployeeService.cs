using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;

namespace Tavisca.TMS.Core.services
{
    public class EmployeeService : IService<Employee>
    {
        private IRepository<Employee> _repository;
        private IIdentityService<Employee> _identityService;

        public EmployeeService(IRepository<Employee> repository, IIdentityService<Employee> identityServie)
        {
            _repository = repository;
            _identityService = identityServie; // this class will be used in future for creating employee identity

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
            return _repository.GetAll();
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
