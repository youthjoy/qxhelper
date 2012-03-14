using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
   public partial class WH_Price
    {
        /// <summary>
        /// 库存最大值
        /// </summary>
       public Int64 Storage_TNum { get; set; }
       /// <summary>
       /// 库存最小值
       /// </summary>
       public Int64 Storage_LNum { get; set; }
       /// <summary>
       /// 库存
       /// </summary>
       public Int64 Storage_Count { get; set; }
       /// <summary>
       /// 经验值
       /// </summary>
       public Decimal  Storage_Dvalue { get; set; }
    }
}
