using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.BaseModels;
using Tavisca.TMS.Contracts.Models.TeamModels;

namespace Tavisca.TMS.Contracts.Models.TrainingModels
{
    public class Training : BaseModel
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public Team Team { get; set; }

    }
}
