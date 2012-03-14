using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class Audit_Template
    {
        public IEnumerable<Audit_Template> ChildrenNode
        {
            get;
            set;
        }
    }
}
