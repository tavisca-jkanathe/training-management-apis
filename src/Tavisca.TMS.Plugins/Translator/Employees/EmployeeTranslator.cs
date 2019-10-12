using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Persistence.Dto.Employee;
using System.Linq;
namespace Tavisca.TMS.Persistence.Translator.Employees
{
    public class EmployeeTranslator
    {
        public Employee Translate(EmployeeDto employeeDto)
        {
            return new Employee
            {
                Id= employeeDto.Id,
                Email = employeeDto.Email,
                Name = employeeDto.Name,
                Role = employeeDto.Role,
                Source = employeeDto.Source,
                Type = employeeDto.Type,
                Team = new Contracts.Models.TeamModels.Team
                {
                    Id = employeeDto.Team.Id,
                    Name = employeeDto.Team.Id
                }
            };
        }
        
        public List<Employee> Translate(List<EmployeeDto> employees)
        {
            return employees.Select(x => Translate(x)).ToList();
        }
    }
}
