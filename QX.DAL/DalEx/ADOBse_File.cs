using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using System.Data;

namespace QX.DAL
{
    public partial class ADOBse_File
    {
        public List<Bse_File> GetListByWhereExtend(string strCondition)
        {
            List<Bse_File> ret = new List<Bse_File>();
            string sql = @"select * from (SELECT  CF_ID,CF_Code,CF_Name,CF_Path,CF_Cate,CF_CateName
                ,CF_Type,CF_iType,AuditStat
                ,AuditCurAudit,CF_Bak,f.Stat,da.DA_Allot,da.DA_Module,(select top 1 dict_name from bse_dict where dict_key='IsHandle' and dict_code=isnull(da.DA_IsHandle,'NoHandle')) as IsHandle
                ,f.CreateTime,f.UpdateTime,f.DeleteTime 
            FROM Bse_File f JOIN Doc_Allot da on f.CF_Code=da.DA_DocCode and isnull(da.stat,0)=0 and isnull(f.stat,0)=0
) aa WHERE 1=1 ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY CF_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    Bse_File bse_File = new Bse_File();
                    if (dr["CF_ID"] != DBNull.Value) bse_File.CF_ID = Convert.ToDecimal(dr["CF_ID"]);
                    if (dr["CF_Code"] != DBNull.Value) bse_File.CF_Code = Convert.ToString(dr["CF_Code"]);
                    if (dr["CF_Name"] != DBNull.Value) bse_File.CF_Name = Convert.ToString(dr["CF_Name"]);
                    if (dr["CF_Path"] != DBNull.Value) bse_File.CF_Path = Convert.ToString(dr["CF_Path"]);
                    if (dr["CF_Cate"] != DBNull.Value) bse_File.CF_Cate = Convert.ToString(dr["CF_Cate"]);
                    if (dr["CF_CateName"] != DBNull.Value) bse_File.CF_CateName = Convert.ToString(dr["CF_CateName"]);
                    if (dr["CF_Type"] != DBNull.Value) bse_File.CF_Type = Convert.ToString(dr["CF_Type"]);
                    if (dr["CF_iType"] != DBNull.Value) bse_File.CF_iType = Convert.ToString(dr["CF_iType"]);
                    if (dr["AuditStat"] != DBNull.Value) bse_File.AuditStat = Convert.ToString(dr["AuditStat"]);
                    if (dr["AuditCurAudit"] != DBNull.Value) bse_File.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                    if (dr["CF_Bak"] != DBNull.Value) bse_File.CF_Bak = Convert.ToString(dr["CF_Bak"]);
                    if (dr["Stat"] != DBNull.Value) bse_File.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateTime"] != DBNull.Value) bse_File.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                    if (dr["UpdateTime"] != DBNull.Value) bse_File.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
                    if (dr["DeleteTime"] != DBNull.Value) bse_File.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);

                    if (dr["IsHandle"] != DBNull.Value) bse_File.IsHandle = Convert.ToString(dr["IsHandle"]);

                    ret.Add(bse_File);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
