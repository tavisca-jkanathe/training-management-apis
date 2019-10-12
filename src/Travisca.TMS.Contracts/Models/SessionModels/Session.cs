using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.BaseModels;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Contracts.Models.TopicModels;

namespace Tavisca.TMS.Contracts.Models.SessionModels
{
    public class Session : BaseModel
    {
        public Topic Topic { get; set; }
        public Employee Trainer { get; set; }
        public string Location { get; set; }
        public int Time { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

    }
}
