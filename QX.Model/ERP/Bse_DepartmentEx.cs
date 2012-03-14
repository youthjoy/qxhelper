using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class Bse_Department
    {
        public IEnumerable<Bse_Department> ChildrenDept{get;set;}
    }
}
