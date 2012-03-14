using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using System.Data;

namespace QX.DAL
{
    public partial class ADOBse_Components
    {
        public List<Bse_Components> GetListByWhereExtend(string strCondition)
        {
            List<Bse_Components> ret = new List<Bse_Components>();
            string sql = @"select * from (SELECT  Comp_ID,Comp_Code,Comp_CCode,Comp_Name,Comp_Type,Comp_Stat,Comp_Content,Comp_Creator
                ,Comp_CreatorName,Comp_Date
                ,AuditStat,AuditCurAudit,bc.Stat,da.DA_Allot,da.DA_Module,(select top 1 dict_name from bse_dict where dict_key='IsHandle' and dict_code=isnull(da.DA_IsHandle,'NoHandle')) as IsHandle
,bc.CreateTime,bc.UpdateTime,bc.DeleteTime FROM Bse_Components bc JOIN Doc_Allot da on bc.Comp_Code=da.DA_DocCode and isnull(da.stat,0)=0 and isnull(bc.stat,0)=0
) aa WHERE 1=1 ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY Comp_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    Bse_Components bse_Components = new Bse_Components();
                    if (dr["Comp_ID"] != DBNull.Value) bse_Components.Comp_ID = Convert.ToDecimal(dr["Comp_ID"]);
                    if (dr["Comp_Code"] != DBNull.Value) bse_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
                    if (dr["Comp_CCode"] != DBNull.Value) bse_Components.Comp_CCode = Convert.ToString(dr["Comp_CCode"]);
                    if (dr["Comp_Name"] != DBNull.Value) bse_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
                    if (dr["Comp_Type"] != DBNull.Value) bse_Components.Comp_Type = Convert.ToString(dr["Comp_Type"]);
                    if (dr["Comp_Stat"] != DBNull.Value) bse_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
                    if (dr["Comp_Content"] != DBNull.Value) bse_Components.Comp_Content = Convert.ToString(dr["Comp_Content"]);
                    if (dr["Comp_Creator"] != DBNull.Value) bse_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
                    if (dr["Comp_CreatorName"] != DBNull.Value) bse_Components.Comp_CreatorName = Convert.ToString(dr["Comp_CreatorName"]);
                    if (dr["Comp_Date"] != DBNull.Value) bse_Components.Comp_Date = Convert.ToDateTime(dr["Comp_Date"]);
                    if (dr["AuditStat"] != DBNull.Value) bse_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
                    if (dr["AuditCurAudit"] != DBNull.Value) bse_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                    if (dr["Stat"] != DBNull.Value) bse_Components.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateTime"] != DBNull.Value) bse_Components.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                    if (dr["UpdateTime"] != DBNull.Value) bse_Components.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
                    if (dr["DeleteTime"] != DBNull.Value) bse_Components.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);

                    if (dr["IsHandle"] != DBNull.Value) bse_Components.IsHandle = Convert.ToString(dr["IsHandle"]);

                    ret.Add(bse_Components);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
