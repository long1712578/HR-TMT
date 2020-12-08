using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class RequestApproval: BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public string Type { get; set; }
        // default : 0
        // Chưa duyệt : 0 ,Không duyệt : -1, Đã duyệt : 1
        public int Status { get; set; } = 0;
        public string TypeTimeOff { get; set; }
        public string Reason { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string RejectedReason { get; set; }
        public int EmployeeId { get; set; }
        public int ApproverId { get; set; }
        public virtual Employee Employee { get; set; }

        public int userApprovalID { get; set; }
    }
}
