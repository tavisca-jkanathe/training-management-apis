using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Persistence.Entities.EmployeeDtos;

namespace Tavisca.TMS.Persistence.Dal
{
    public class EmployeeDal : IBaseDal<EmployeeDto>
    {
        public MySqlConnection _conn = MySqlConnectionConfig.GetConnection();
       public List<EmployeeDto> Fetch()
        {
            _conn.Open();
            var query = "select * from employee";
            var cmd = new MySqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();
            List<EmployeeDto> employeeDtos = new List<EmployeeDto>();
            while (reader.Read())
            {
                EmployeeDto emp = Fetch(reader);
                employeeDtos.Add(emp);
            }
            
            _conn.Close();
            return employeeDtos;
         
        }

        private EmployeeDto Fetch(MySqlDataReader reader)
        {
            return new EmployeeDto
            {
                Id = reader.GetString(0),
                Name = reader.GetString(1),
                Email = reader.GetString(2),
                Role = reader.GetString(3),
                Type = reader.GetString(4),
                Source = reader.GetString(5),
                TeamId = reader.GetString(6),
                Created = (DateTime)reader.GetMySqlDateTime(7),
                LastUpdated = (DateTime)reader.GetMySqlDateTime(8),
            };
        }

        public EmployeeDto FetchById(string id)
        {
            _conn.Open();
            var query = $"select * from employee where id = { id }";
            var cmd = new MySqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();
            var emp = Fetch(reader);
            _conn.Close();
            return emp;

        }

        public void Insert(EmployeeDto entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(EmployeeDto entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, EmployeeDto newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
