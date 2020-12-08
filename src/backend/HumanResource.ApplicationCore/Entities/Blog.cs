using HumanResource.ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { set; get; }
        public string Content { set; get; }
        public DateTime? CreateDate { set; get; }
        public DateTime? UpdateDate { set; get; } = null;
        public Status Status { set; get; }
        public int EmployeeId { set; get; }
        public int BlogTypeId { set; get; }

        public virtual Employee Employee { set; get; }
        public virtual ICollection<BlogTag> BlogTags { set; get; }
        public virtual ICollection<BlogRole> BlogRoles { set; get; }
        public virtual ICollection<Comment> Comments { set; get; }
    }
}
