using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Persistence.Dto.Team;

namespace Tavisca.TMS.Persistence.Dto.Employee
{
    public class EmployeeDto : BaseDto
    {

        public string Name { get; set; }
        public string TeamId { get; set; }
        public TeamDto Team { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
    }
}
