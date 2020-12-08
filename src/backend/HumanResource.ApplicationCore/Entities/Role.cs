using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Role: BaseEntity
    {
        public string RoleName { set; get; }
        public bool IsActive { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }
        public virtual ICollection<BlogRole> BlogRoles { set; get; }
    }
}
