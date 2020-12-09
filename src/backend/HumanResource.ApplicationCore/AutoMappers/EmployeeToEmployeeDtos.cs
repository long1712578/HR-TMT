using AutoMapper;
using HumanResource.Api.Dtos;
using HumanResource.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.AutoMappers
{
    public class EmployeeToEmployeeDtos:Profile
    {
        public EmployeeToEmployeeDtos()
        {
            CreateMap<Employee, EmployeeDtos>();
        }
    }
}
