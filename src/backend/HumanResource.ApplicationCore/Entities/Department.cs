using System.Collections.Generic;

namespace HumanResource.ApplicationCore.Entities
{
    public class Department: BaseEntity
    {
        
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}