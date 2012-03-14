
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
using QX.Config;
using QX.Comm;
namespace QX.BLL
{
    public enum DocStat
    {
        Draft,
        Normal,
        OnDo,
        Finish
    }

    public partial class Bll_Doc_Info
    {

        private Bll_Audit auditInstance = new Bll_Audit();
        private Bll_Comm comInstance = new Bll_Comm();
        private ADODoc_Allot daInstance = new ADODoc_Allot();
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Doc_Info GetModels(string code)
        {
            Doc_Info model = new Doc_Info();
            string where = string.Format(" AND Doc_Code='{0}'", code);
            List<Doc_Info> list = instance.GetListByWhere(where);
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

        public string GenerateAllotCode()
        {
            return comInstance.GetTableKeyCode("Doc_Allot");
        }

        public string GenerateDocCode()
        {
            return comInstance.GetTableKeyCode("Doc_Info");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="modelcode"></param>
        /// <returns></returns>
        public bool IsHaveAllot(string userCode, string modelcode)
        {
            
           var model= daInstance.GetListByWhere(string.Format("AND DA_DocCode='{0}' AND DA_Allot='{1}'", modelcode, userCode)).FirstOrDefault();

           if (model == null)
           {
               return false;
           }

           return true;
        }

        /// <summary>
        /// 判断是否有下载图纸授权
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="modelcode"></param>
        /// <returns></returns>
        public bool IsHaveAllotForComp(string userCode, string modelcode,string type)
        {

            var model = daInstance.GetListByWhere(string.Format("AND DA_DocCode='{0}' AND isnull(DA_Type,'View')='{2}' AND DA_Allot='{1}'", modelcode, userCode,type)).FirstOrDefault();

            if (model == null)
            {
                return false;
            }

            return true;
        }

        public bool IsHaveAudit(string userCode, string moduleCode)
        {
            var list=auditInstance.GetVerifyUserListEx(moduleCode);
            if (list.FirstOrDefault(o => o.VU_User == userCode) != null)
            {
                return true;
            }

            return false;
        }

        public bool AddAllot(Doc_Allot info)
        {
            int result = 0;
            if (info != null)
            {

                result = daInstance.Add(info);

            }
            return result > 0 ? true : false;
        }
        public bool UpdateAllot(Doc_Allot info)
        {
            int result = 0;
            if (info != null)
            {

                result = daInstance.Update(info);

            }
            return result > 0 ? true : false;
        }


        public bool AddObject(Doc_Info info)
        {
            int result = 0;
            if (info != null)
            {

                result = instance.Add(info);

            }
            return result > 0 ? true : false;
        }


        public bool UpdateObject(Doc_Info doc)
        {
            if (instance.Update(doc) > 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 获取草稿列表(获取与用户相关的草稿列表)
        /// </summary>
        /// <returns></returns>
        public List<Doc_Info> GetDraftDocList(string where)
        {
            string condition = string.Format("AND Doc_Stat='{0}' AND Doc_Creator='{2}' AND {1}", DocStat.Draft.ToString(), where,SessionConfig.UserId());
            return GetDocList(condition);
        }

        /// <summary>
        /// 获取我提交的公文
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Doc_Info> GetMyDocList(string where)
        {
            //string condition = string.Format("AND isnull(Comp_Stat,'')='{0}' AND {1}", "Normal", where);
            // return cInstance.GetListByWhere(condition);

            //所有文档
            // List<Bse_Components> allList = new List<Bse_Components>();
            List<Doc_Info> list = new List<Doc_Info>();
            string condition = string.Format("AND isnull(Doc_Stat,'')='{0}' AND Doc_Creator='{1}' AND {2}", "Normal", SessionConfig.UserId(), where);
            list = instance.GetListByWhere(condition);
            // List<Verify_TemplateConfig> rlNodes = auditInstance.GetVerifyNodesByCurUser(AuditModuleEnum.CompAudit.ToString(), SessionConfig.UserId());

            return list;
        }




        /// <summary>
        /// 获取文档列表（不是草稿状态的代办)--已审核，但未进一步操作的（比如分发）
        /// </summary>
        /// <returns></returns>
        public List<Doc_Info> GetNormalDocList(string where)
        {
            string condition = string.Format(" AND AuditStat ='{3}' AND Doc_Stat='{0}' AND DA_Allot='{2}' AND DA_Module='{4}' AND DA_iType='{5}' AND {1}", DocStat.Normal.ToString(), where, SessionConfig.UserId(), AudtiOperaTypeEnum.LastAudit.ToString(), "CList_DocInfo",AllotType.Distribution.ToString());
            var list = instance.GetListByWhereExtend(condition);
            return list;
        }

        /// <summary>
        /// 获取抄送列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Doc_Info> GetNormalCCDocList(string where)
        {
            string condition = string.Format(" AND Doc_Stat='{0}' AND DA_Allot='{2}' AND DA_Module='{3}' AND DA_iType='{4}' AND {1}", DocStat.Normal.ToString(), where, SessionConfig.UserId(), "CList_DocInfo", AllotType.CC.ToString());
            var list = instance.GetListByWhereExtend(condition);
            return list;
        }


        /// <summary>
        /// 获取与本人相关的所有文档
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Doc_Info> GetAllDocList(string where)
        {
            //所有文档
            List<Doc_Info> allList = new List<Doc_Info>();
            List<Doc_Info> list = new List<Doc_Info>();
            string condition = string.Format("AND Doc_Stat='{0}' AND Doc_Code in (select DA_DocCode from doc_allot where da_allot='{2}' and isnull(da_ishandle,'NoHandle')='{3}') AND {1}", DocStat.Normal.ToString(), where, SessionConfig.UserId(), "Handle");
            list = GetDocList(condition);
            List<Verify_TemplateConfig> rlNodes = auditInstance.GetVerifyNodesByCurUser(AuditModuleEnum.DocumentAudit.ToString(), SessionConfig.UserId());
            
            if (rlNodes.Count != 0)
            {
                var list2 = instance.GetListByWhere(string.Format("AND Doc_Stat='{0}' AND {1}","Normal",where));
                allList = list.Union(list2).Distinct(o=>o.Doc_Code).ToList();
            }

            return allList;

        }

        public List<Doc_Info> GetAuditDocList(string where)
        {
            string filterSql = auditInstance.GetAuditFilterWhere(AuditModuleEnum.DocumentAudit.ToString(), SessionConfig.UserId());
            string condition = string.Format("AND Doc_Stat='{0}'  AND {2} AND AuditStat in ('OnAudit','Auditing') AND {1}", DocStat.Normal.ToString(), where, filterSql);
            return GetDocList(condition);
        }

        /// <summary>
        /// 获取归档公文列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Doc_Info> GetFinDocList(string where)
        {
            string condition = string.Format("AND Doc_Stat='{0}' and {1}", DocStat.Finish.ToString(), where);
            return GetDocList(condition);
        }

        private List<Doc_Info> GetDocList(string where)
        {
            return instance.GetListByWhere(where);
        }

        public Doc_Allot GetAllotModel(string where)
        {

            return daInstance.GetListByWhere(where).FirstOrDefault();
        }

        /// <summary>
        /// 获取分发列表
        /// </summary>
        /// <param name="code"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Doc_Allot> GetAllotList(string code, string where)
        {
            string condition = string.Format("AND DA_DocCode='{0}' AND DA_iType='{2}' And {1}", code, where, AllotType.Distribution.ToString());
            return daInstance.GetListByWhere(condition);
        }

        /// <summary>
        /// 获取抄送
        /// </summary>
        /// <param name="code"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Doc_Allot> GetCCList(string code, string where)
        {
            string condition = string.Format("AND DA_DocCode='{0}' AND DA_iType='{2}' And {1}", code, where, AllotType.CC.ToString());
            return daInstance.GetListByWhere(condition);
        }
    }
}
