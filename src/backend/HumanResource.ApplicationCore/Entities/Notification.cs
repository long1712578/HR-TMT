using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Notification: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string LinkRelated { get; set; }
        public bool IsRead { get; set; }
        public bool IsSaw { get; set; }
        public string DataUser { get; set; }
        public DateTime CreatDateTime { get; set; }
        public int TotalNotification { set; get; }
        public string ThumbNailImage { get; set; }
        public int EmployeeId { get; set; }
    }
}
