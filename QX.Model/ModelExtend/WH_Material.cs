using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class WH_Material
    {
        public long Storage_Count
        {
            get;
            set;
        }
        /// <summary>
        /// 仓库号
        /// </summary>
        public string Storage_WarehouseNo
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string Storage_Code
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库号名称
        /// </summary>
        public string Storage_WarehouseNoName
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string Storage_Name
        {
            get;
            set;
        }


        public string Storage_Company
        {
            get;
            set;
        }

        public string Storage_CompanyCode { get; set; }
    }
}
