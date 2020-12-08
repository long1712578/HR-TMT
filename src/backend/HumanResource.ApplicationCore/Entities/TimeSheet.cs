using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class TimeSheet: BaseEntity
    {
        public int Month { set; get; }
        public int Year { set; get; }
        public bool IsActive { set; get; }
        public int EmployeeId { set; get; }
        public int TotalDayOfMonth { set; get; }
        public int TotalDay { set; get; }
        public int TotalWeekendDay { set; get; }
        public int TotalLeaveDay { set; get; }
        public int TotalOffDay { set; get; }
        public int TotalHoliday { set; get; }
        public int TotalNoCheck { set; get; }
        public Employee Employee { set; get; }
        public DateTime UploadTime { set; get; }
    }
}
