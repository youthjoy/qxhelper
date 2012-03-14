using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class WH_Warehouse
    {
        /// <summary>
        /// child节点
        /// </summary>
        public IEnumerable<WH_Warehouse> Children
        {
            get;
            set;
        }

        public IList<WH_Warehouse> Childrens
        { get; set; }
    }
}
