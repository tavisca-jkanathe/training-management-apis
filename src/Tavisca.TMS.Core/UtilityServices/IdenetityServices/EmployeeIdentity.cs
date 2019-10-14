using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;

namespace Tavisca.TMS.Core.UtilityServices.IdenetityServices
{
    public class EmployeeIdentity : IIdentityService<Employee>
    {
        public string Get(Employee entity)
        {
            // Formula will be implemented here to get employee Id
            throw new NotImplementedException();
        }
    }
}
