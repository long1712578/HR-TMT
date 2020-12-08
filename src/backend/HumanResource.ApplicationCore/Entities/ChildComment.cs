using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanResource.ApplicationCore.Entities
{
    public class ChildComment: BaseEntity
    {
        public string Content { set; get; }
        public DateTime DateComment { set; get; }
        public bool IsActive { set; get; }
        public int? CommentId { set; get; } = null;
        public virtual Comment Comment { set; get; }
        public int? EmployeeId { set; get; } = null;
        public virtual Employee Employee { set; get; }
    }
}
