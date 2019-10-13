using System;
using System.Collections.Generic;
using System.Text;
using StructureMap;
using StructureMap.Pipeline;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Models.EmployeeModels;
using Tavisca.TMS.Core.Service;
using Tavisca.TMS.Persistence.Dal;
using Tavisca.TMS.Persistence.Entities.EmployeeDtos;
using Tavisca.TMS.Persistence.Repositories;

namespace Tavisca.TMS.Ioc.StructureMapRegistries
{
    public class EmployeeRegistry : Registry
    {
        public EmployeeRegistry()
        {
            For<IService<Employee>>().LifecycleIs(Lifecycles.Container).Use<EmployeeService>();
            For<IRepository<Employee>>().LifecycleIs(Lifecycles.Container).Use<EmployeeRepository>();
            For<IBaseDal<EmployeeDto>>().LifecycleIs(Lifecycles.Container).Use<EmployeeDal>();
            
        }
    }
}
