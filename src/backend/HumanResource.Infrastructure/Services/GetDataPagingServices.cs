using HumanResource.Api.Dtos;
using HumanResource.ApplicationCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Data.Migrations
{
    public class GetDataPagingServices
    {
        private DataContext _context;
        public GetDataPagingServices(DataContext context)
        {
            _context = context;
        }
        public async Task<PageResult<EmployeeDtos>> GetDataPaging(PageRequestBase request)
        {
            var query = from em in _context.Employees
                        select new { em };
            int totalRow=await query.CountAsync();
            var data = await query.Skip((request.index - 1) * request.sizePage)
                                   .Take(request.sizePage)
                                   .Select(x => new EmployeeDtos()
                                   {
                                       FullName=x.em.FullName,
                                       Email=x.em.Email,
                                       DateOfBirth=x.em.DateOfBirth,
                                       Gender=x.em.Gender,
                                       Username=x.em.Username,
                                       //Password=x.em.
                                       Addresses=x.em.Addresses,
                                       AvatarUrl=x.em.AvatarUrl,
                                       ProfileUrl=x.em.ProfileUrl,
                                       //Position=x.em.Po
                                      // Status=x.em.
                                      StartDate=x.em.StartDate,
                                      EndDate=x.em.EndDate,

                                   }).ToListAsync();
            var pageResult = new PageResult<EmployeeDtos>
            {
                record=data,
                totalRecord=totalRow
            };
            return pageResult;
        }
    }
}
