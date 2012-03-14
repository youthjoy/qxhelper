using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class HR_Department
    {
        /// <summary>
        /// child节点
        /// </summary>
        public IEnumerable<HR_Department> ChildrenDept
        {
            get;
            set;
        }
    }
    public partial class System_Menu
    {
        /// <summary>
        /// child节点
        /// </summary>
        public IEnumerable<System_Menu> ChildrenMenus
        {
            get;
            set;
        }
    }

    public partial class WH_Warehouse
    {
        /// <summary>
        /// child节点
        /// </summary>
        public IEnumerable<WH_Warehouse> ChildrenHouse
        {
            get;
            set;
        }
    }

    public partial class WH_MaterialType
    {
        /// <summary>
        /// child节点
        /// </summary>
        public IEnumerable<WH_MaterialType> ChildrenType
        {
            get;
            set;
        }
    }

}
