using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Tag: BaseEntity
    {
        public string TagName { set; get; }
        public bool IsActive { set; get; }
        public virtual ICollection<BlogTag> BlogTags { set; get; }
    }
}
