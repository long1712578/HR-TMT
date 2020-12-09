using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Common
{
    public class PageResult<T>
    {
        public List<T>  record { get; set; }
        public int totalRecord { get; set; }
    }
}
