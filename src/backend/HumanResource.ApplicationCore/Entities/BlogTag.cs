using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class BlogTag
    {
        public int BlogId { get; set; }
        public virtual Blog Blog { set; get; }
        public int TagId { set; get; }
        public virtual Tag Tag { set; get; }
    }
}
