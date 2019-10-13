using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tavisca.TMS.Contracts.Interfaces;
using Tavisca.TMS.Contracts.Messages.EmployeeMessages;
using Tavisca.TMS.Contracts.Models.EmployeeModels;

namespace Tavisca.TMS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IService<Employee> _service;
        IMapper _mapper;
        public EmployeeController(IService<Employee> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeResponse>> Get()
        {
            return _service.GetAll().Select(x=>_mapper.Map<EmployeeResponse>(x)).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
