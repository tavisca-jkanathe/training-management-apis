using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.BaseModels;
using Tavisca.TMS.Contracts.Models.TeamModels;

namespace Tavisca.TMS.Contracts.Models.EmployeeModels
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Role { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public Team Team { get; set; }

    }
}
