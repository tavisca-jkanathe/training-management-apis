using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Persistence.Dto.Employee;
using Tavisca.TMS.Persistence.Dto.Team;

namespace Tavisca.TMS.Persistence.Mapper
{
    class EmployeeMapper
    {
        
        public List<EmployeeDto> GetAll(MySqlDataReader reader)
        {
            List<EmployeeDto> employeeDtos = new List<EmployeeDto>(); 
            while (reader.Read())
            {
                var emp = new EmployeeDto
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
                    Team = new TeamDto
                    {
                        Id = reader.GetString(9),
                        Name = reader.GetString(10),
                        Created = reader.GetDateTime(11),
                        LastUpdated = reader.GetDateTime(12)
                    }

                };
                employeeDtos.Add(emp);
            }
            return employeeDtos;
        }
    }
}
