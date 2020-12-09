using AutoMapper;
using HumanResource.ApplicationCore.Common;
using HumanResource.ApplicationCore.Interfaces;
using HumanResource.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        [HttpGet("paging")]
        public async Task<IActionResult>GetEmployeePaging([FromQuery] PageRequestBase request)
        {

        }
    }
}
