using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using System.Data;

namespace QX.DAL
{
    public partial class ADODoc_Info
    {
        /// <summary>
        /// 获取分发列表
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<Doc_Info> GetListByWhereExtend(string strCondition)
        {
            List<Doc_Info> ret = new List<Doc_Info>();
            string sql = @"select * from (SELECT  Doc_ID,Doc_Code,Doc_Type,Doc_TypeName,Doc_No,Doc_IsBusyName
,Doc_IsBusy,Doc_Level,Doc_LevelName,Doc_Title
,Doc_Object,Doc_Cate,Doc_CateName
,Doc_Creator,Doc_CreatorName,Doc_DpCode
,Doc_DpName,Doc_MainTitle,Doc_CC,Doc_Content
,Doc_Date,Doc_Num,Doc_Opinion,Doc_Stat,Doc_RefDoc,di.Stat
,di.CreateTime,di.UpdateTime,di.DeleteTime,AuditStat,AuditCurAudit ,da.DA_Allot,da.DA_Module,da.DA_iType,(select top 1 dict_name from bse_dict where dict_key='IsHandle' and dict_code=isnull(da.DA_IsHandle,'NoHandle')) as IsHandle
FROM Doc_Info di
JOIN Doc_Allot da on di.Doc_Code=da.DA_DocCode and isnull(da.stat,0)=0 and isnull(di.stat,0)=0
) aa WHERE 1=1 ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY Doc_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    Doc_Info doc_Info = new Doc_Info();
                    if (dr["Doc_ID"] != DBNull.Value) doc_Info.Doc_ID = Convert.ToDecimal(dr["Doc_ID"]);
                    if (dr["Doc_Code"] != DBNull.Value) doc_Info.Doc_Code = Convert.ToString(dr["Doc_Code"]);
                    if (dr["Doc_Type"] != DBNull.Value) doc_Info.Doc_Type = Convert.ToString(dr["Doc_Type"]);
                    if (dr["Doc_TypeName"] != DBNull.Value) doc_Info.Doc_TypeName = Convert.ToString(dr["Doc_TypeName"]);
                    if (dr["Doc_No"] != DBNull.Value) doc_Info.Doc_No = Convert.ToString(dr["Doc_No"]);
                    if (dr["Doc_IsBusyName"] != DBNull.Value) doc_Info.Doc_IsBusyName = Convert.ToString(dr["Doc_IsBusyName"]);
                    if (dr["Doc_IsBusy"] != DBNull.Value) doc_Info.Doc_IsBusy = Convert.ToString(dr["Doc_IsBusy"]);
                    if (dr["Doc_Level"] != DBNull.Value) doc_Info.Doc_Level = Convert.ToString(dr["Doc_Level"]);
                    if (dr["Doc_LevelName"] != DBNull.Value) doc_Info.Doc_LevelName = Convert.ToString(dr["Doc_LevelName"]);
                    if (dr["Doc_Title"] != DBNull.Value) doc_Info.Doc_Title = Convert.ToString(dr["Doc_Title"]);
                    if (dr["Doc_Object"] != DBNull.Value) doc_Info.Doc_Object = Convert.ToString(dr["Doc_Object"]);
                    if (dr["Doc_Cate"] != DBNull.Value) doc_Info.Doc_Cate = Convert.ToString(dr["Doc_Cate"]);
                    if (dr["Doc_CateName"] != DBNull.Value) doc_Info.Doc_CateName = Convert.ToString(dr["Doc_CateName"]);
                    if (dr["Doc_Creator"] != DBNull.Value) doc_Info.Doc_Creator = Convert.ToString(dr["Doc_Creator"]);
                    if (dr["Doc_CreatorName"] != DBNull.Value) doc_Info.Doc_CreatorName = Convert.ToString(dr["Doc_CreatorName"]);
                    if (dr["Doc_DpCode"] != DBNull.Value) doc_Info.Doc_DpCode = Convert.ToString(dr["Doc_DpCode"]);
                    if (dr["Doc_DpName"] != DBNull.Value) doc_Info.Doc_DpName = Convert.ToString(dr["Doc_DpName"]);
                    if (dr["Doc_MainTitle"] != DBNull.Value) doc_Info.Doc_MainTitle = Convert.ToString(dr["Doc_MainTitle"]);
                    if (dr["Doc_CC"] != DBNull.Value) doc_Info.Doc_CC = Convert.ToString(dr["Doc_CC"]);
                    if (dr["Doc_Content"] != DBNull.Value) doc_Info.Doc_Content = Convert.ToString(dr["Doc_Content"]);
                    if (dr["Doc_Date"] != DBNull.Value) doc_Info.Doc_Date = Convert.ToDateTime(dr["Doc_Date"]);
                    if (dr["Doc_Num"] != DBNull.Value) doc_Info.Doc_Num = Convert.ToInt32(dr["Doc_Num"]);
                    if (dr["Doc_Opinion"] != DBNull.Value) doc_Info.Doc_Opinion = Convert.ToString(dr["Doc_Opinion"]);
                    if (dr["Doc_Stat"] != DBNull.Value) doc_Info.Doc_Stat = Convert.ToString(dr["Doc_Stat"]);
                    if (dr["Doc_RefDoc"] != DBNull.Value) doc_Info.Doc_RefDoc = Convert.ToString(dr["Doc_RefDoc"]);
                    if (dr["Stat"] != DBNull.Value) doc_Info.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateTime"] != DBNull.Value) doc_Info.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                    if (dr["UpdateTime"] != DBNull.Value) doc_Info.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
                    if (dr["DeleteTime"] != DBNull.Value) doc_Info.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
                    if (dr["AuditStat"] != DBNull.Value) doc_Info.AuditStat = Convert.ToString(dr["AuditStat"]);
                    if (dr["AuditCurAudit"] != DBNull.Value) doc_Info.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                    //扩展属性

                    if (dr["IsHandle"] != DBNull.Value) doc_Info.IsHandle = Convert.ToString(dr["IsHandle"]);


                    ret.Add(doc_Info);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
