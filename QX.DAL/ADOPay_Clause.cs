using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// 付款条款
   /// </summary>
   [Serializable]
   public partial class ADOPay_Clause
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加付款条款 Pay_Clause对象(即:一条记录)
      /// </summary>
      public int Add(Pay_Clause pay_Clause)
      {
         string sql = "INSERT INTO Pay_Clause (Contract_Code,Stat) VALUES (@Contract_Code,@Stat)";
         if (string.IsNullOrEmpty(pay_Clause.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", pay_Clause.Contract_Code);
         }
         if (pay_Clause.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pay_Clause.Stat);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
         
      }
      /// <summary>
      /// 添加付款条款 Pay_Clause对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Pay_Clause pay_Clause)
      {
         string sql = "INSERT INTO Pay_Clause (Contract_Code,Stat) VALUES (@Contract_Code,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pay_Clause.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", pay_Clause.Contract_Code);
         }
         if (pay_Clause.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pay_Clause.Stat);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 var Return = idb.ReturnValue(sql);
                 Ex = Return.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 更新付款条款 Pay_Clause对象(即:一条记录
      /// </summary>
      public int Update(Pay_Clause pay_Clause)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Pay_Clause       SET ");
            if(pay_Clause.Contract_Code_IsChanged){sbParameter.Append("Contract_Code=@Contract_Code, ");}
      if(pay_Clause.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Cluase_ID=@Cluase_ID; " );
      string sql=sb.ToString();
         if(pay_Clause.Contract_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pay_Clause.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", pay_Clause.Contract_Code);
         }
          }
         if(pay_Clause.Stat_IsChanged)
         {
         if (pay_Clause.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pay_Clause.Stat);
         }
          }

         idb.AddParameter("@Cluase_ID", pay_Clause.Cluase_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 删除付款条款 Pay_Clause对象(即:一条记录
      /// </summary>
      public int Delete(decimal cluase_ID)
      {
         string sql = "DELETE Pay_Clause WHERE 1=1  AND Cluase_ID=@Cluase_ID ";
         idb.AddParameter("@Cluase_ID", cluase_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 获取指定的付款条款 Pay_Clause对象(即:一条记录
      /// </summary>
      public Pay_Clause GetByKey(decimal cluase_ID)
      {
         Pay_Clause pay_Clause = new Pay_Clause();
         string sql = "SELECT  Cluase_ID,Contract_Code,Stat FROM Pay_Clause WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Cluase_ID=@Cluase_ID ";
         idb.AddParameter("@Cluase_ID", cluase_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Cluase_ID"] != DBNull.Value) pay_Clause.Cluase_ID = Convert.ToDecimal(dr["Cluase_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) pay_Clause.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Stat"] != DBNull.Value) pay_Clause.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pay_Clause;
      }
      /// <summary>
      /// 获取指定的付款条款 Pay_Clause对象集合
      /// </summary>
      public List<Pay_Clause> GetListByWhere(string strCondition)
      {
         List<Pay_Clause> ret = new List<Pay_Clause>();
         string sql = "SELECT  Cluase_ID,Contract_Code,Stat FROM Pay_Clause WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Pay_Clause pay_Clause = new Pay_Clause();
            if (dr["Cluase_ID"] != DBNull.Value) pay_Clause.Cluase_ID = Convert.ToDecimal(dr["Cluase_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) pay_Clause.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Stat"] != DBNull.Value) pay_Clause.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(pay_Clause);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的付款条款 Pay_Clause对象(即:一条记录
      /// </summary>
      public List<Pay_Clause> GetAll()
      {
         List<Pay_Clause> ret = new List<Pay_Clause>();
         string sql = "SELECT  Cluase_ID,Contract_Code,Stat FROM Pay_Clause where 1=1 AND ((Stat is null) or (Stat=0) ) order by Cluase_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Pay_Clause pay_Clause = new Pay_Clause();
            if (dr["Cluase_ID"] != DBNull.Value) pay_Clause.Cluase_ID = Convert.ToDecimal(dr["Cluase_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) pay_Clause.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Stat"] != DBNull.Value) pay_Clause.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(pay_Clause);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
