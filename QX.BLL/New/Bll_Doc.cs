using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
using QX.Comm;

namespace QX.BLL
{
    public class Bll_Doc
    {
        private ADODoc_Info instance =new ADODoc_Info();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<Doc_Info> GetAll()
        {
            List<Doc_Info> list = instance.GetAll();
            return list;
        }
        public Doc_Info GetDocModelBySupplier(string code)
        {
            Doc_Info model = new Doc_Info();
            string where = string.Format(" AND Doc_Code='{0}'",code);
            List<Doc_Info> list = instance.GetListByWhere(where);
            if (list!=null && list.Count>0)
            {
                model = list[0];
            }
            else
            {
                model = null;
            }
            return model;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Doc_Info model)
        {
            bool result = false;
            try
            {
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public Doc_Info GetModel(string strCondition)
        {
            List<Doc_Info> list = instance.GetListByWhere(strCondition);
            Doc_Info model = new Doc_Info();
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

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Doc_Info model)
        {
            bool result = false;
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(string Code)
        {
            bool result = false;
            List<Doc_Info> list = instance.GetListByWhere(" AND Menu_Code='" + Code + "'");
            if (list.Count > 0)
            {
                Doc_Info model = list[0];
                //model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 获取菜单数据
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public List<Doc_Info> GetMenu(MenuLocation location)
        {
            List<Doc_Info> list = instance.GetListByWhere("  AND Menu_Location='" + location.ToString() + "' AND Menu_Enable='Enable' ORDER BY Menu_Order ASC ");
            return list;
        }

    }
}
