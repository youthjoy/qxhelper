
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
using QX.Comm;
using QX.Config;

namespace QX.BLL
{
    [Serializable]
    public partial class Bll_Sys_UserPermission
    {

        private ADOSys_UserPermission instance = new ADOSys_UserPermission();
        private Bll_Comm comInstance = new Bll_Comm();
        private ADOSys_OpLog logInstance = new ADOSys_OpLog();

        private ADOBse_Group gInstance = new ADOBse_Group();

        public List<Bse_Group> GetGroupList(string where)
        {
            return gInstance.GetListByWhere(string.Format(" AND (GP_Creator='{0}' OR GP_Type='{1}') AND {2} ",SessionConfig.UserId(),"Comm", where));
        }

        public List<Sys_OpLog> GetLogList(string where)
        {
            return logInstance.GetListByWhere(where);
        }

        public bool IsHavePermission(string userCode,string FunCode)
        {
            var model = GetModel(string.Format(" AND PU_UserCode='{0}' AND PU_FunCode='{1}'",userCode,FunCode));

            if (model != null)
            {
                return true;
            }

            return false;

        }

        public List<Sys_UserPermission> GetUserPermission(string usercode)
        { 
           return GetListByCode(string.Format(" AND PU_UserCode='{0}'",usercode));
        }

        /// <summary>
        /// 权限更新
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool UpdatePermission(string userCode,List<Sys_UserPermission> list)
        {
            List<Sys_UserPermission> oldlist = GetListByCode(string.Format("AND PU_UserCode='{0}'", userCode));
            foreach (var u in oldlist)
            {
                var mo = list.FirstOrDefault(o => o.PU_FunCode == u.PU_FunCode);
                if (mo != null)
                {
                    u.PU_IsCheck = "1";
                    Update(u);
                    list.Remove(mo);
                }
                else
                {
                    u.Stat = 1;
                    u.PU_IsCheck = "0";
                   // u.PU_IsCheck = "0";
                    Update(u);
                }
  

            }
              foreach (var uu in list)
                {
                    Sys_UserPermission per = new Sys_UserPermission();
                    per.PU_Code = GenereatePermissionCode();
                    per.PU_UserCode = userCode;
                    per.PU_FunCode = uu.PU_FunCode;
                    per.PU_IsCheck = "1";
                    Insert(per);
                }
            return true;
        }

        /// <summary>
        /// 生成权限编码
        /// </summary>
        /// <returns></returns>
        public string GenereatePermissionCode()
        {
            return comInstance.GetTableKeyCode("Sys_UserPermission");
        }

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns>list</returns>
        public List<Sys_UserPermission> GetAll()
        {
            List<Sys_UserPermission> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 根据条件获取List
        /// </summary>
        /// <param name='strCondition'>条件(' AND Code='11'')</param>
        /// <returns>list</returns>
        public List<Sys_UserPermission> GetListByCode(string strCondition)
        {
            return instance.GetListByWhere(strCondition);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Insert(Sys_UserPermission model)
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
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <param name='model'>是否完成验证</param>
        /// <returns>bool</returns>
        public bool Insert(Sys_UserPermission model, bool IsValid)
        {
            var e = new ModelExceptions();
            bool result = false;
            if (e.IsValid && IsValid)
            {
                //完成了验证，开始更新数据库了
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Sys_UserPermission GetModel(string strCondition)
        {
            List<Sys_UserPermission> list = instance.GetListByWhere(strCondition);
            Sys_UserPermission model = new Sys_UserPermission();
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
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Sys_UserPermission GetModel(int id)
        {
            Sys_UserPermission model = instance.GetByKey(id);
            return model;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Update(Sys_UserPermission model)
        {
            bool result = false;
            var e = new ModelExceptions();
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Update(Sys_UserPermission model, bool IsValid)
        {

            bool result = false;
            var e = new ModelExceptions();
            if (e.IsValid && IsValid)
            {
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name='model'>model</param>
        /// <returns>bool</returns>
        public bool Delete(string Condition)
        {
            bool result = false;
            List<Sys_UserPermission> list = instance.GetListByWhere(Condition);
            if (list.Count > 0)
            {
                Sys_UserPermission model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
