using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.ApplicationCore.Common
{
    public class PageRequestBase
    {
        public int index { get; set; }
        public int sizePage { get; set; }
    }
}
