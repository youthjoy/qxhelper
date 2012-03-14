using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using QX.DataAcess;
using System.Data;

namespace QX.DAL
{
   public partial class ADOPCD_NRecord
    {
       
        /// <summary>
        /// 获取指定的发货记录 PCD_NRecord对象集合
        /// </summary>
        public List<PCD_NRecord> GetListByWhere(string strCondition,string select)
        {
            List<PCD_NRecord> ret = new List<PCD_NRecord>();
            string sql = "select * from PCD_NRecord a JOIN WH_Supplier b ON a.pcdn_ccode=b.whs_custcode  JOIN SD_Project c ON a.pcdn_prcode=c.sdi_code  where (a.Stat is null or a.Stat=0 ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY PCDN_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    PCD_NRecord pCD_NRecord = new PCD_NRecord();
                    if (dr["PCDN_ID"] != DBNull.Value) pCD_NRecord.PCDN_ID = Convert.ToDecimal(dr["PCDN_ID"]);
                    if (dr["PCDN_Code"] != DBNull.Value) pCD_NRecord.PCDN_Code = Convert.ToString(dr["PCDN_Code"]);
                    if (dr["PCDN_CCode"] != DBNull.Value) pCD_NRecord.PCDN_CCode = Convert.ToString(dr["PCDN_CCode"]);
                    if (dr["PCDN_PRCode"] != DBNull.Value) pCD_NRecord.PCDN_PRCode = Convert.ToString(dr["PCDN_PRCode"]);
                    if (dr["PCDN_PCode"] != DBNull.Value) pCD_NRecord.PCDN_PCode = Convert.ToString(dr["PCDN_PCode"]);
                    if (dr["PCDN_PDCode"] != DBNull.Value) pCD_NRecord.PCDN_PDCode = Convert.ToString(dr["PCDN_PDCode"]);
                    if (dr["PCDN_PSCode"] != DBNull.Value) pCD_NRecord.PCDN_PSCode = Convert.ToString(dr["PCDN_PSCode"]);
                    if (dr["PCDN_Part"] != DBNull.Value) pCD_NRecord.PCDN_Part = Convert.ToString(dr["PCDN_Part"]);
                    if (dr["PCDN_Slump"] != DBNull.Value) pCD_NRecord.PCDN_Slump = Convert.ToString(dr["PCDN_Slump"]);
                    if (dr["PCDN_Spec1"] != DBNull.Value) pCD_NRecord.PCDN_Spec1 = Convert.ToString(dr["PCDN_Spec1"]);
                    if (dr["PCDN_Spec2"] != DBNull.Value) pCD_NRecord.PCDN_Spec2 = Convert.ToString(dr["PCDN_Spec2"]);
                    if (dr["PCDN_TType"] != DBNull.Value) pCD_NRecord.PCDN_TType = Convert.ToString(dr["PCDN_TType"]);
                    if (dr["PCDN_TEqu"] != DBNull.Value) pCD_NRecord.PCDN_TEqu = Convert.ToString(dr["PCDN_TEqu"]);
                    if (dr["PCDN_SOwner"] != DBNull.Value) pCD_NRecord.PCDN_SOwner = Convert.ToString(dr["PCDN_SOwner"]);
                    if (dr["PCDN_SDate"] != DBNull.Value) pCD_NRecord.PCDN_SDate = Convert.ToDateTime(dr["PCDN_SDate"]);
                    if (dr["PCDN_TBSta"] != DBNull.Value) pCD_NRecord.PCDN_TBSta = Convert.ToString(dr["PCDN_TBSta"]);
                    if (dr["PCDN_TBLine"] != DBNull.Value) pCD_NRecord.PCDN_TBLine = Convert.ToString(dr["PCDN_TBLine"]);
                    if (dr["PCDN_OOwner"] != DBNull.Value) pCD_NRecord.PCDN_OOwner = Convert.ToString(dr["PCDN_OOwner"]);
                    if (dr["PCDN_ODate"] != DBNull.Value) pCD_NRecord.PCDN_ODate = Convert.ToDateTime(dr["PCDN_ODate"]);
                    if (dr["PCDN_PPLimit"] != DBNull.Value) pCD_NRecord.PCDN_PPLimit = Convert.ToDecimal(dr["PCDN_PPLimit"]);
                    if (dr["PCDN_DIType"] != DBNull.Value) pCD_NRecord.PCDN_DIType = Convert.ToString(dr["PCDN_DIType"]);
                    if (dr["PCDN_DINum"] != DBNull.Value) pCD_NRecord.PCDN_DINum = Convert.ToDecimal(dr["PCDN_DINum"]);
                    if (dr["PCDN_PNum"] != DBNull.Value) pCD_NRecord.PCDN_PNum = Convert.ToDecimal(dr["PCDN_PNum"]);
                    if (dr["PCDN_PCNum"] != DBNull.Value) pCD_NRecord.PCDN_PCNum = Convert.ToDecimal(dr["PCDN_PCNum"]);
                    if (dr["PCDN_PTOrd"] != DBNull.Value) pCD_NRecord.PCDN_PTOrd = Convert.ToInt32(dr["PCDN_PTOrd"]);
                    if (dr["PCDN_PCDrv"] != DBNull.Value) pCD_NRecord.PCDN_PCDrv = Convert.ToString(dr["PCDN_PCDrv"]);
                    if (dr["PCDN_PCCode"] != DBNull.Value) pCD_NRecord.PCDN_PCCode = Convert.ToString(dr["PCDN_PCCode"]);
                    if (dr["PCDN_PCNo"] != DBNull.Value) pCD_NRecord.PCDN_PCNo = Convert.ToString(dr["PCDN_PCNo"]);
                    if (dr["PCDN_DDate"] != DBNull.Value) pCD_NRecord.PCDN_DDate = Convert.ToDateTime(dr["PCDN_DDate"]);
                    if (dr["PCDN_RDate"] != DBNull.Value) pCD_NRecord.PCDN_RDate = Convert.ToDateTime(dr["PCDN_RDate"]);
                    if (dr["PCDN_JBegin"] != DBNull.Value) pCD_NRecord.PCDN_JBegin = Convert.ToDateTime(dr["PCDN_JBegin"]);
                    if (dr["PCDN_JEnd"] != DBNull.Value) pCD_NRecord.PCDN_JEnd = Convert.ToDateTime(dr["PCDN_JEnd"]);
                    if (dr["PCDN_LDate"] != DBNull.Value) pCD_NRecord.PCDN_LDate = Convert.ToDateTime(dr["PCDN_LDate"]);
                    if (dr["PCDN_BDate"] != DBNull.Value) pCD_NRecord.PCDN_BDate = Convert.ToDateTime(dr["PCDN_BDate"]);
                    if (dr["PCDN_PPNum"] != DBNull.Value) pCD_NRecord.PCDN_PPNum = Convert.ToDecimal(dr["PCDN_PPNum"]);
                    if (dr["PCDN_TDNum"] != DBNull.Value) pCD_NRecord.PCDN_TDNum = Convert.ToDecimal(dr["PCDN_TDNum"]);
                    if (dr["PCDN_TTNum"] != DBNull.Value) pCD_NRecord.PCDN_TTNum = Convert.ToInt32(dr["PCDN_TTNum"]);
                    if (dr["PCDN_RTNum"] != DBNull.Value) pCD_NRecord.PCDN_RTNum = Convert.ToDecimal(dr["PCDN_RTNum"]);
                    if (dr["PCDN_CTNum"] != DBNull.Value) pCD_NRecord.PCDN_CTNum = Convert.ToDecimal(dr["PCDN_CTNum"]);
                    if (dr["PCDN_RRNum"] != DBNull.Value) pCD_NRecord.PCDN_RRNum = Convert.ToDecimal(dr["PCDN_RRNum"]);
                    if (dr["PCDN_MoreNum"] != DBNull.Value) pCD_NRecord.PCDN_MoreNum = Convert.ToDecimal(dr["PCDN_MoreNum"]);
                    if (dr["PCDN_PRNum"] != DBNull.Value) pCD_NRecord.PCDN_PRNum = Convert.ToDecimal(dr["PCDN_PRNum"]);
                    if (dr["PCDN_BStatus"] != DBNull.Value) pCD_NRecord.PCDN_BStatus = Convert.ToString(dr["PCDN_BStatus"]);
                    if (dr["PCDN_TRNum"] != DBNull.Value) pCD_NRecord.PCDN_TRNum = Convert.ToDecimal(dr["PCDN_TRNum"]);
                    if (dr["PCDN_TBNum"] != DBNull.Value) pCD_NRecord.PCDN_TBNum = Convert.ToDecimal(dr["PCDN_TBNum"]);
                    if (dr["PCDN_TBBak"] != DBNull.Value) pCD_NRecord.PCDN_TBBak = Convert.ToString(dr["PCDN_TBBak"]);
                    if (dr["PCDN_Stat"] != DBNull.Value) pCD_NRecord.PCDN_Stat = Convert.ToString(dr["PCDN_Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) pCD_NRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) pCD_NRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) pCD_NRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    ret.Add(pCD_NRecord);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
