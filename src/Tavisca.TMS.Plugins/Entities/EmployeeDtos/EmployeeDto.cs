using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.TMS.Persistence.Entities.EmployeeDtos
{
    public class EmployeeDto : BaseDto
    {

        public string Name { get; set; }
        public string TeamId { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
    }
}
