using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using QX.DAL;
using QX.Comm;
using QX.Config;

namespace QX.BLL
{
    public class Bll_File
    {
        public ADOBse_File instance = new ADOBse_File();

        private Bll_Audit auditInstance = new Bll_Audit();

        private Bll_Comm commInstance = new Bll_Comm();

        /// <summary>
        /// 获取草稿列表
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Bse_File> GetFileList(string filter)
        {
            return instance.GetListByWhere(string.Format(" AND CF_iType='{1}' AND CF_Creator='{2}' AND {0} ",filter,"Draft",SessionConfig.UserId()));
        }

        /// <summary>
        /// 获取待审核
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Bse_File> GetAuditList(string filter)
        {
            string filterSql = auditInstance.GetAuditFilterWhere(AuditModuleEnum.ComFileAudit.ToString(), SessionConfig.UserId());
            string condition = string.Format("AND CF_iType='{0}' AND AuditStat<>'LastAudit'  AND {2} AND {1}", "Normal", filter, filterSql);
            return instance.GetListByWhere(condition);
        }

        /// <summary>
        /// 获取所有文档
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_File> GetAllFileList(string where)
        {
            //string condition = string.Format("AND isnull(CF_iType,'')='{0}' AND {1}", "Normal", where);
            //return instance.GetListByWhere(condition);

            List<Bse_File> allList = new List<Bse_File>();
            List<Bse_File> list = new List<Bse_File>();
            string condition = string.Format("AND isnull(CF_iType,'')='{0}' AND {1} AND CF_Code in (select DA_DocCode from doc_allot where da_allot='{2}' and isnull(da_ishandle,'NoHandle')='{3}') AND {1}", DocStat.Normal.ToString(), where, SessionConfig.UserId(), "Handle");
            list = instance.GetListByWhere(condition);
            List<Verify_TemplateConfig> rlNodes = auditInstance.GetVerifyNodesByCurUser(AuditModuleEnum.ComFileAudit.ToString(), SessionConfig.UserId());

            if (rlNodes.Count != 0)
            {
                var list2 = instance.GetListByWhere(string.Format("AND CF_iType='{0}' AND {1}", "Normal", where));
                allList = list.Union(list2).Distinct(o => o.CF_Code).ToList();
            }

            return allList;
        }

        public List<Bse_File> GetMyFileList(string where)
        {
            //string condition = string.Format("AND isnull(Comp_Stat,'')='{0}' AND {1}", "Normal", where);
            // return cInstance.GetListByWhere(condition);
            
            //所有文档
            // List<Bse_Components> allList = new List<Bse_Components>();
            List<Bse_File> list = new List<Bse_File>();
            string condition = string.Format("AND isnull(CF_iType,'')='{0}' AND CF_Creator='{1}' AND {2}", "Normal", SessionConfig.UserId(), where);
            list = instance.GetListByWhere(condition);
            // List<Verify_TemplateConfig> rlNodes = auditInstance.GetVerifyNodesByCurUser(AuditModuleEnum.CompAudit.ToString(), SessionConfig.UserId());

            return list;
        }



        /// <summary>
        /// 获取待办
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_File> GetDoingFileList(string where)
        {
            string condition = string.Format(" AND AuditStat ='{3}' AND CF_iType='{0}' AND DA_Allot='{2}' AND DA_Module='{4}' AND DA_iType='{5}'  AND {1}", "Normal", where, SessionConfig.UserId(), AudtiOperaTypeEnum.LastAudit.ToString(),"Bse_FileModule",AllotType.Distribution.ToString());
            return instance.GetListByWhereExtend(condition);
        }

        public Bse_File GetModel(string where)
        {
            return instance.GetListByWhere(where).FirstOrDefault();
        }

        public string GenerateComFileCode()
        {
            return commInstance.GetTableKeyCode("Bse_File");
        }

        public bool AddModel(Bse_File model)
        {
            if (instance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateModel(Bse_File model)
        {
            if (instance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteModel(Bse_File model)
        {
            model.Stat = 1;
            if (instance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
