using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Persistence.Mapper;
using Tavisca.TMS.Persistence.Translator.Employees;

namespace Tavisca.TMS.Persistence.EmployeeRepositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        MySqlConnection _conn = null;
        EmployeeMapper _employeeMapper = new EmployeeMapper();
        EmployeeTranslator _translator = new EmployeeTranslator();
        public EmployeeRepository(MySqlConnection conn)
        {
            _conn = conn;
        }


        public List<Employee> Get(Predicate<Employee> condition)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            _conn.Open();
            var query = "select * from employee left join team on employee.TeamId = team.Id";
            var cmd = new MySqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();
            //_conn.Close();
            var employees =  _employeeMapper.GetAll(reader);
            return _translator.Translate(employees);
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
