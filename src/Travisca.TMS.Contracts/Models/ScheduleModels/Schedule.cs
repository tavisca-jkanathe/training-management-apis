using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.BaseModels;
using Tavisca.TMS.Contracts.Models.SessionModels;

namespace Tavisca.TMS.Contracts.Models.ScheduleModels
{
    public class Schedule : BaseModel
    {
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public string Status { get; set; }
        public bool IsPublished { get; set; }
        public Session[] Sessions { get; set; }
    }
    
}
