using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.TMS.Persistence.Dto
{
    public class BaseDto
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
