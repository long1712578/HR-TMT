using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class ShiftWork: BaseEntity
    {
        public string Name { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public bool IsActive { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }
    }
}
