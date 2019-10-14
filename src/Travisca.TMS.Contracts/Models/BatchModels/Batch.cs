using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.BaseModels;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Contracts.Models.TrainingModels;

namespace Tavisca.TMS.Contracts.Models.BatchModels
{
    public class Batch : BaseModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Employee[] EmployeeList { get; set; }
        public Training Training { get; set; }
    }
}
