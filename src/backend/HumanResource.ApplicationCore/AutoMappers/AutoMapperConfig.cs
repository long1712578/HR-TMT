using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.AutoMappers
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EmployeeToEmployeeDtos());
                cfg.AddProfile(new EmployeeDtosToEmployee());
            });
        }
    }
}
