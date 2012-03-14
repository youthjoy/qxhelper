using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;

namespace QX.BLL
{
   public partial class Bll_System_Menu
   {
     
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public System_Menu GetModels(string strCondition)
        {
            string where = string.Format(" AND Menu_Code='{0}'", strCondition);
            List<System_Menu> list = instance.GetListByWhere(where);
            System_Menu model = new System_Menu();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            else
            {
                model = null;
            }
            return model;
        }

        public bool AddUpdatePlanObject(System_Menu info)
        {
            int result = 0;
            if (info != null)
            {
                if (info.Menu_ID.Equals(0))
                {
                    result = instance.Add(info);
                }
                else
                {
                    result = instance.Update(info);
                }
            }
            return result > 0 ? true : false;
        }
    }
}
