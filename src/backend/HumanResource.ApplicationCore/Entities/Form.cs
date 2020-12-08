using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Entities
{
    public class Form: BaseEntity
    {
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string FileName { get; set; }
        public int FormType { get; set; }
        public virtual List<FormVersion> FormVersions { get; set; }
    }
}
