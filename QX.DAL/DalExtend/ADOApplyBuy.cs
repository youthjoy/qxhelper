using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using QX.DataAcess;

namespace QX.DAL
{
    public class ADOApplyBuy
    {
        public ADORec_Main MainInstance;
        public ADOWH_ApplyBuy DetailInstance;
        public IDBOperator idb = DBOperator.GetInstance();
        public ADOApplyBuy()
        {
            MainInstance = new ADORec_Main();
            DetailInstance = new ADOWH_ApplyBuy();
            DetailInstance.idb.SetConnection(MainInstance.idb.GetConnection());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="main"></param>
        /// <param name="detail"></param>
        /// <returns></returns>
        public bool InsertOrUpdateApplyBuy(List<WH_ApplyBuy> detail)
        {
            bool result = false;
            if (detail != null)
            {
                DetailInstance.idb.BeginTransaction();
                //DetailInstance.idb.BeginTransaction(MainInstance.idb.GetTransaction());
                try
                {
                    //string ReturnId =(string)MainInstance.AddWithReturn(main);
                    for (int i = 0; i < detail.Count; i++)
                    {
                        if (DetailInstance.GetListByWhere(" AND MVI_Code='"+detail[i].MVI_Code+"' ").Count()>0)
                        {
                            DetailInstance.Update(detail[i]);
                        }else
                        {
                            DetailInstance.Add(detail[i]);
                        }                       
                    }
                    DetailInstance.idb.CommitTransaction();
                    result = true;
                }
                catch (Exception)
                {
                    DetailInstance.idb.RollbackTransaction();
                }
            }
            return result;
        }

        public List<WH_ApplyBuy> GetApplyBuyDetailByVender(string code, string auditStat)
        {
            List<WH_ApplyBuy> ret = new List<WH_ApplyBuy>();
            string sql = @" select b.* from Rec_Main a,
                            WH_ApplyBuy b
                            where a.RM_Code=MVI_RCode
                            and a.VerifyStat='{0}' and b.MV_CustCode='{1}' 
                            ";
            sql = string.Format(sql, auditStat, code);
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                WH_ApplyBuy wH_ApplyBuy = new WH_ApplyBuy();
                if (dr["MVI_ID"] != DBNull.Value) wH_ApplyBuy.MVI_ID = Convert.ToInt32(dr["MVI_ID"]);
                if (dr["MVI_Code"] != DBNull.Value) wH_ApplyBuy.MVI_Code = Convert.ToString(dr["MVI_Code"]);
                if (dr["MVI_RCode"] != DBNull.Value) wH_ApplyBuy.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
                if (dr["MVI_Type"] != DBNull.Value) wH_ApplyBuy.MVI_Type = Convert.ToString(dr["MVI_Type"]);
                if (dr["MVI_MCode"] != DBNull.Value) wH_ApplyBuy.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
                if (dr["MVI_Spec"] != DBNull.Value) wH_ApplyBuy.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
                if (dr["MVI_Sup"] != DBNull.Value) wH_ApplyBuy.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
                if (dr["MVI_Num"] != DBNull.Value) wH_ApplyBuy.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
                if (dr["MVI_Unit"] != DBNull.Value) wH_ApplyBuy.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
                if (dr["MVI_MDPrice"] != DBNull.Value) wH_ApplyBuy.MVI_MDPrice = Convert.ToDouble(dr["MVI_MDPrice"]);
                if (dr["Stat"] != DBNull.Value) wH_ApplyBuy.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["MV_CustCode"] != DBNull.Value) wH_ApplyBuy.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
                if (dr["MV_CustName"] != DBNull.Value) wH_ApplyBuy.MV_CustName = Convert.ToString(dr["MV_CustName"]);
                if (dr["MV_CustRef"] != DBNull.Value) wH_ApplyBuy.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
                if (dr["MV_CustDate"] != DBNull.Value) wH_ApplyBuy.MV_CustDate = Convert.ToString(dr["MV_CustDate"]);
                if (dr["MV_VerifyStep"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
                if (dr["MV_VerifyStuff"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
                if (dr["MV_VerifyDate"] != DBNull.Value) wH_ApplyBuy.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
                if (dr["MV_VerifyStat"] != DBNull.Value) wH_ApplyBuy.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
                if (dr["MV_ContractNo"] != DBNull.Value) wH_ApplyBuy.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
                ret.Add(wH_ApplyBuy);
            }
            dr.Close();
            return ret;

        }
    }
}
