using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tavisca.TMS.Contracts.Messages.EmployeeMessages;
using Tavisca.TMS.Contracts.Models.EmployeeModels;

namespace Tavisca.TMS.Web.Mappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeResponse>();
            CreateMap<EmployeeRequest, Employee>();
        }
    }

}
