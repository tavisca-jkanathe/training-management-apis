using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Persistence.Entities.EmployeeDtos;
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
            };
        }
        
        public List<Employee> Translate(List<EmployeeDto> employees)
        {
            return employees.Select(x => Translate(x)).ToList();
        }
    }
}
