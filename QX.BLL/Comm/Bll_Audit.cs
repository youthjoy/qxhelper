using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;
using QX.Comm;
using QX.Comm.Utils;
using System.Data;
using System.Data.SqlClient;

namespace QX.BLL
{
    /// <summary>
    /// 通用审核配置
    /// </summary>
    public class Bll_Audit
    {

        #region 实例

        /// <summary>
        /// 模板实例
        /// </summary>
        public ADOAudit_Template AuditTemplateInstance = new ADOAudit_Template();
        /// <summary>
        /// 模板配置实例
        /// </summary>
        public ADOVerify_TemplateConfig AuditTemplateConfigInstance = new ADOVerify_TemplateConfig();
        /// <summary>
        /// 审核阶段配置实例 
        /// </summary>
        public ADOVerify_Nodes AuditNodesInstance = new ADOVerify_Nodes();
        /// <summary>
        /// 审核阶段用户实例
        /// </summary>
        public ADOVerify_Users AuditUserInstance = new ADOVerify_Users();
        /// <summary>
        /// 审核记录配置实例
        /// </summary>
        public ADOVerifyProcess_Records AuditProcessRecordsInstance = new ADOVerifyProcess_Records();

        #endregion

        /// <summary>
        /// 返回模板配置信息
        /// </summary>
        /// <param name="TemplateKey">模块关键字</param>
        /// <param name="TemplateCode">模块单据编码</param>
        /// <returns></returns>
        public Verify_TemplateConfig VerifyTemplateConfig(AuditModuleEnum TemplateKey, string TemplateCode)
        {

            Verify_TemplateConfig resulst = AuditTemplateConfigInstance.GetAll()
                .Where(o => o.VT_Key == TemplateKey.ToString() && o.VT_Template_Code == TemplateCode).FirstOrDefault();
            return resulst;
        }

        public Audit_Template GetTemplateModel(string code)
        {
            return AuditTemplateInstance.GetListByWhere(string.Format(" AND Template_Code='{0}'", code)).FirstOrDefault();
        }

        /// <summary>
        /// 返回配置节点信息
        /// </summary>
        /// <param name="NodesCode"></param>
        /// <returns></returns>
        public Verify_Nodes VerfiyNodes(string NodesCode)
        {
            Verify_Nodes result = AuditNodesInstance.GetAll().Where(o => o.VerifyNode_Code == NodesCode).FirstOrDefault();
            return result;
        }

        /// <summary>
        /// 返回节点下所有可以审核的用户列表
        /// </summary>
        /// <param name="TemplateCode"></param>
        /// <param name="VerifyNodeCode"></param>
        /// <returns></returns>
        public List<Verify_Users> VerfiyUsers(string TemplateCode, string VerifyNodeCode)
        {
            List<Verify_Users> result = AuditUserInstance.GetAll()
                .Where(o => o.VU_VerifyTempldate_Code == TemplateCode && o.VU_VerifyNode_Code == VerifyNodeCode).ToList();
            return result;
        }

        /// <summary>
        /// 返回模块审核记录信息
        /// </summary>
        /// <param name="VerfiyKey">模块关键字</param>
        /// <param name="TemplateCode">流程配置模板编码</param>
        /// <param name="DataCode">单据编码</param>
        /// <returns></returns>
        public IEnumerable<VerifyProcess_Records> VerfiyProcessRecords(string VerfiyKey, string DataCode)
        {
            IEnumerable<VerifyProcess_Records> result = AuditProcessRecordsInstance.GetAll()
                .Where(o => o.Module_Code == VerfiyKey.ToString() && o.Record_ID == DataCode);
            return result;
        }

        /// <summary>
        /// 检查用户是否审核该数据
        /// </summary>
        /// <param name="VerfiyKey"></param>
        /// <param name="TeamplateCode"></param>
        /// <param name="DataCode"></param>
        /// <returns></returns>
        public IEnumerable<VerifyProcess_Records> CheckVerfiyProcessRecords(string VerfiyKey,
             string DataCode, string UserId)
        {
            IEnumerable<VerifyProcess_Records> result = this.VerfiyProcessRecords(VerfiyKey, DataCode).Where(o => o.VRecord_Owner == UserId);
            return result;
        }

        /// <summary>
        /// 审核记录添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool VerfiyProcessRecordsAdd(VerifyProcess_Records model)
        {
            int result = 0;
            result = AuditProcessRecordsInstance.Add(model);
            return result > 0 ? true : false;
        }


        /// <summary>
        /// 获取下一个审核节点
        /// </summary>
        /// <param name="VerfiyKey">模块关键字</param>
        /// <param name="TemplateCode">模块编码</param>
        /// <param name="CurNode">当前节点</param>
        /// <param name="IsLastAuditNode">是否为最后一个审核节点</param>
        /// <returns>返回下一节点信息，是否为最后一个审核节点</returns>
        public Verify_TemplateConfig VerifyNextNodes(string VerfiyKey, string CurNode, out bool IsLastAuditNode)
        {
            IsLastAuditNode = false;
            var result = this.AuditTemplateConfigInstance.GetAll()
                .Where(o => o.VT_Key == VerfiyKey.ToString())
                .OrderBy(o => o.VT_VerifyNode_Order);
            List<Verify_TemplateConfig> list = new List<Verify_TemplateConfig>();
            Verify_TemplateConfig SearchResult = new Verify_TemplateConfig();
            int NextNode = 0;
            if (result.Count() > 0)
            {
                try
                {
                    list = result.ToList();
                    int CurNodeIndex = list.FindIndex(o => o.VT_VerifyNode_Code == CurNode);
                    if (CurNodeIndex < result.Count())
                    {
                        NextNode = CurNodeIndex + 1;
                    }
                    else
                    {
                        NextNode = result.Count();
                        IsLastAuditNode = true;
                    }
                    SearchResult = list[NextNode];
                }
                catch (System.Exception ex)
                {
                    SearchResult = null;
                }

            }
            else
            {
                SearchResult = null;
            }
            return SearchResult;
        }

        public Verify_Users GetVerifyUser(string VerfiyKey, string Node)
        {
            bool _isLastAuditNode = false;
            Verify_Users model = new Verify_Users();
            //获取下一阶段节点信息
            Verify_TemplateConfig nextConfig = this.VerifyNextNodes(VerfiyKey, Node, out _isLastAuditNode);
            if (nextConfig != null)
            {
                List<Verify_Users> List = AuditUserInstance.GetAll()
                    .Where(o => o.VU_VerifyNode_Code == nextConfig.VT_VerifyNode_Code).ToList();
                if (List.Count > 0)
                {
                    model = List.FirstOrDefault();
                }
                else
                {
                    model = null;
                }
            }
            return model;
        }

        public Verify_Users GetUserModel(string where)
        {
            return AuditUserInstance.GetListByWhere(where).FirstOrDefault();
        }

        public List<Verify_Users> GetVerifyUserList(string VerfiyKey, string Node)
        {
            bool _isLastAuditNode = false;
            Verify_Users model = new Verify_Users();
            //获取下一阶段节点信息
            Verify_TemplateConfig nextConfig = this.VerifyNextNodes(VerfiyKey, Node, out _isLastAuditNode);
            if (nextConfig != null)
            {
                List<Verify_Users> List = AuditUserInstance.GetAll()
                    .Where(o => o.VU_VerifyNode_Code == nextConfig.VT_VerifyNode_Code).ToList();
                return List;
            }
            return new List<Verify_Users>();
        }


        /// <summary>
        /// 获取当前模板相关的审核阶段的用户列表
        /// </summary>
        /// <param name="VerfiyKey"></param>
        /// <param name="Node"></param>
        /// <returns></returns>
        public List<Verify_Users> GetVerifyUserListEx(string VerfiyKey)
        {
            List<Verify_TemplateConfig> list = new List<Verify_TemplateConfig>();

            list = AuditTemplateConfigInstance.GetListByWhere(string.Format("AND VT_Key='{0}'", VerfiyKey));

            StringBuilder sb = new StringBuilder();

            foreach (var v in list)
            {
                sb.AppendFormat("'{0}',", v.VT_VerifyNode_Code);
            }

            var ulist = AuditUserInstance.GetListByWhere(string.Format(" AND VU_VerifyNode_Code in ({0})", sb.ToString().TrimEnd(',')));

            return ulist;
        }

        /// <summary>
        /// 检查阶段是否审核完成
        /// </summary>
        /// <param name="VerfiyKey"></param>
        /// <param name="TemmplateCode"></param>
        /// <param name="CurCode"></param>
        /// <returns></returns>
        public bool CheckAuditNum(string VerfiyKey, string RecoredId, string CurCode, string UserId)
        {
            bool result = false;
            var ListNode = AuditNodesInstance.GetListByWhere(" AND VerifyNode_Code='" + CurCode + "' ");
            if (ListNode.Count() > 0)
            {
                Verify_Nodes node = ListNode[0];
                int nodeNum = node.VerifyNode_AuditNum;
                int RecordsNum = 0;
                IEnumerable<VerifyProcess_Records> Records = this.CheckVerfiyProcessRecords(VerfiyKey, RecoredId, UserId);
                if (Records.Count() > 0)
                {
                    RecordsNum = Records.Count();
                }
                if (nodeNum != 0 && nodeNum == RecordsNum)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="VerfiyKey">模块名称</param>
        /// <param name="KeyCode">编码字段名称</param>
        /// <param name="RecordId">编码单据号</param>
        /// <param name="AuditSuggest">备注</param>
        /// <param name="UserId">用户ID</param>
        /// <param name="NextAuditNode">下一审核节点</param>
        /// <param name="IsLastAuditNode">是否为最后一个节点</param>
        /// <returns></returns>
        public bool Audit(string VerfiyKey,
                            string RecordId,
                            string AuditSuggest,
                            string UserId,
                            string Agree,
                            string VerfiyNodeCode, out string _ProResult
            )
        {
            bool result = false;
            string ProResult = "";
            _ProResult = "";
            //审核单据，判断是否终审
            VerifyProcess_Records Records = new VerifyProcess_Records()
            {
                Module_Code = VerfiyKey.ToString(),  //模块编码
                VRecord_Code = Bll_Comm.GetTableKey("VerifyProcess_Records"),
                Record_ID = RecordId,                //单据ID                          
                VRecord_Opinion = AuditSuggest,      //审理意见                         
                VRecord_VCode = VerfiyNodeCode,     //审核阶段编码                
                VRecord_Flag = Agree,
                VRecord_Owner = UserId,
                Stat = 2
            };
            int Temp_result = AuditProcessRecordsInstance.Add(Records);
            if (Temp_result > 0)
            {
                SqlParameter x1 = new SqlParameter("@auditCode", SqlDbType.VarChar, 50);
                x1.Value = Records.VRecord_Code;
                SqlParameter[] param = new SqlParameter[] { x1 };
                IDbDataParameter[] parames = param as IDbDataParameter[];
                DataTable dt = AuditProcessRecordsInstance.idb.RunProcReturnDatatable("qx_sp_audit", parames);
                ProResult = dt.Rows[0][0].ToString();
                if (!string.IsNullOrEmpty(ProResult))
                {
                    result = true;
                    _ProResult = ProResult;
                }
            }

            return result;
        }


        public string GetAuditFilterWhere(string moduleCode, string UserId)
        {
            SqlParameter x1 = new SqlParameter("@userID", SqlDbType.VarChar, 20);
            x1.Value = UserId;
            SqlParameter x2 = new SqlParameter("@moduleCode", SqlDbType.VarChar, 20);
            x2.Value = moduleCode;

            SqlParameter x3 = new SqlParameter("@filterSQL", SqlDbType.VarChar, 200);
            x3.Direction = ParameterDirection.Output;
            x3.Value = moduleCode;
            SqlParameter[] param = new SqlParameter[] { x1, x2, x3 };
            IDbDataParameter[] parames = param as IDbDataParameter[];
            DataTable dt = AuditProcessRecordsInstance.idb.RunProcReturnDatatable("qx_sp_auditfilter", parames);
            return dt.Rows[0][0].ToString();
        }




        /// <summary>
        /// 获取当前用户相关的阶段
        /// </summary>
        /// <param name="moduleCode">模板编码</param>
        /// <param name="userCode">用户编码</param>
        /// <returns></returns>
        public List<Verify_TemplateConfig> GetVerifyNodesByCurUser(string moduleCode, string userCode)
        {
            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetTemplateConfigList(string.Format(" AND VT_Key='{0}' AND VU_User='{1}'", moduleCode, userCode));

            return list;

        }

        public Verify_TemplateConfig GetVerifyTemplateFirstNode(string moduleCode)
        {
            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetListByWhere(string.Format(" AND VT_Key='{0}' Order by VT_VerifyNode_Order asc", moduleCode));
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取审核模板第一个节点
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <returns></returns>
        //public Verify_TemplateConfig GetVerifyTemplateFirstNode(string moduleCode)
        //{
        //    List<Verify_TemplateConfig> list = AuditTemplateConfigInstance
        //        .GetListByWhere(string.Format(" AND VT_Key='{0}'", moduleCode)).OrderBy(o=>o.VT_VerifyNode_Order).ToList();
        //    if (list != null && list.Count > 0)
        //    {
        //        return list[0];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        #region 审核配置

        /// <summary>
        /// 获取模板相关阶段列表
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public List<Verify_TemplateConfig> GetTemplateConfig(string module)
        {
            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetListByWhere(string.Format("AND VT_Key='{0}'", module));
            return list;
        }

        public List<Verify_Users> GetVerifyUsersByNode(string node, string where)
        {
            List<Verify_Users> list = AuditUserInstance.GetListByWhere(string.Format("AND VU_VerifyNode_Code='{0}' {1}", node, where));
            return list;
        }

        /// <summary>
        /// 获取阶段列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Verify_Nodes> GetVerifyNodes(string where)
        {
            List<Verify_Nodes> list = AuditNodesInstance.GetListByWhere(string.Format("AND {0}", where));
            return list;
        }

        /// <summary>
        /// 获取模板列表
        /// </summary>
        /// <returns></returns>
        public List<Audit_Template> GetTemplateList()
        {
            List<Audit_Template> list = AuditTemplateInstance.GetAll();
            return list;
        }

        public bool Config(string data, string module)
        {
            string[] Nodes = data.TrimEnd(',').Trim().Split(',');
            //当前模块对应配置阶段
            List<Verify_TemplateConfig> tlist = GetTemplateConfig(module);
            //所有阶段列表
            List<Verify_Nodes> list = GetVerifyNodes("1=1");
            int max = 0;
            if (tlist.Count == 0)
            {
                max = 0;
            }
            else
            {
                max = tlist.Max(o => o.VT_VerifyNode_Order);
            }
            foreach (var n in Nodes)
            {
                if (string.IsNullOrEmpty(n))
                {
                    continue;
                }
                var vnode = list.FirstOrDefault(o => o.VerifyNode_Code == n);

                Verify_TemplateConfig config = new Verify_TemplateConfig();
                config.VT_VerifyNode_Code = vnode.VerifyNode_Code;
                config.VT_VerifyNode_Name = vnode.VerifyNode_Name;
                config.VT_Key = module;

                config.VT_VerifyNode_Order = ++max;

                config.VT_Template_Code = GenerateTemplateConfigCode();

                AddConfig(config);
            }

            return true;
        }


        public bool DelConfig(string data, string module)
        {
            string[] Nodes = data.TrimEnd(',').Trim().Split(',');
            //当前模块对应配置阶段
            List<Verify_TemplateConfig> tlist = GetTemplateConfig(module);
            foreach (var n in Nodes)
            {
                if (string.IsNullOrEmpty(n))
                {
                    continue;
                }

                var model = tlist.FirstOrDefault(o => o.VT_Template_Code == n);

                if (model != null)
                {
                    model.Stat = 1;
                    UpdateConfig(model);
                }

            }
            return true;
        }



        public string GenerateTemplateConfigCode()
        {
            return Bll_Comm.GetTableKey("Verify_TemplateConfig");
        }

        public bool AddConfig(Verify_TemplateConfig model)
        {
            if (AuditTemplateConfigInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddUser(Verify_Users model)
        {
            if (AuditUserInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateUser(Verify_Users model)
        {
            if (AuditUserInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddNode(Verify_Nodes model)
        {
            if (AuditNodesInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateNode(Verify_Nodes model)
        {
            if (AuditNodesInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }


        public bool UpdateConfig(Verify_TemplateConfig model)
        {
            if (AuditTemplateConfigInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
