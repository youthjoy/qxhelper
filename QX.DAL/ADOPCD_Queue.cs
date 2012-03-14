using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOPCD_Queue
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PCD_Queue对象(即:一条记录)
      /// </summary>
      public int Add(PCD_Queue pCD_Queue)
      {
         string sql = "INSERT INTO PCD_Queue (PCDO_PlanCode,PCDO_NCode,PCDO_Order,Stat) VALUES (@PCDO_PlanCode,@PCDO_NCode,@PCDO_Order,@Stat)";
         if (string.IsNullOrEmpty(pCD_Queue.PCDO_PlanCode))
         {
            idb.AddParameter("@PCDO_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDO_PlanCode", pCD_Queue.PCDO_PlanCode);
         }
         if (string.IsNullOrEmpty(pCD_Queue.PCDO_NCode))
         {
            idb.AddParameter("@PCDO_NCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDO_NCode", pCD_Queue.PCDO_NCode);
         }
         if (pCD_Queue.PCDO_Order == 0)
         {
            idb.AddParameter("@PCDO_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCDO_Order", pCD_Queue.PCDO_Order);
         }
         if (pCD_Queue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Queue.Stat);
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
      /// 添加PCD_Queue对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCD_Queue pCD_Queue)
      {
         string sql = "INSERT INTO PCD_Queue (PCDO_PlanCode,PCDO_NCode,PCDO_Order,Stat) VALUES (@PCDO_PlanCode,@PCDO_NCode,@PCDO_Order,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCD_Queue.PCDO_PlanCode))
         {
            idb.AddParameter("@PCDO_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDO_PlanCode", pCD_Queue.PCDO_PlanCode);
         }
         if (string.IsNullOrEmpty(pCD_Queue.PCDO_NCode))
         {
            idb.AddParameter("@PCDO_NCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDO_NCode", pCD_Queue.PCDO_NCode);
         }
         if (pCD_Queue.PCDO_Order == 0)
         {
            idb.AddParameter("@PCDO_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCDO_Order", pCD_Queue.PCDO_Order);
         }
         if (pCD_Queue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Queue.Stat);
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
      /// 更新PCD_Queue对象(即:一条记录
      /// </summary>
      public int Update(PCD_Queue pCD_Queue)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCD_Queue       SET ");
            if(pCD_Queue.PCDO_PlanCode_IsChanged){sbParameter.Append("PCDO_PlanCode=@PCDO_PlanCode, ");}
      if(pCD_Queue.PCDO_NCode_IsChanged){sbParameter.Append("PCDO_NCode=@PCDO_NCode, ");}
      if(pCD_Queue.PCDO_Order_IsChanged){sbParameter.Append("PCDO_Order=@PCDO_Order, ");}
      if(pCD_Queue.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCDO_ID=@PCDO_ID; " );
      string sql=sb.ToString();
         if(pCD_Queue.PCDO_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Queue.PCDO_PlanCode))
         {
            idb.AddParameter("@PCDO_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDO_PlanCode", pCD_Queue.PCDO_PlanCode);
         }
          }
         if(pCD_Queue.PCDO_NCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Queue.PCDO_NCode))
         {
            idb.AddParameter("@PCDO_NCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDO_NCode", pCD_Queue.PCDO_NCode);
         }
          }
         if(pCD_Queue.PCDO_Order_IsChanged)
         {
         if (pCD_Queue.PCDO_Order == 0)
         {
            idb.AddParameter("@PCDO_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCDO_Order", pCD_Queue.PCDO_Order);
         }
          }
         if(pCD_Queue.Stat_IsChanged)
         {
         if (pCD_Queue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Queue.Stat);
         }
          }

         idb.AddParameter("@PCDO_ID", pCD_Queue.PCDO_ID);

           
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
      /// 删除PCD_Queue对象(即:一条记录
      /// </summary>
      public int Delete(Int64 pCDO_ID)
      {
         string sql = "DELETE PCD_Queue WHERE 1=1  AND PCDO_ID=@PCDO_ID ";
         idb.AddParameter("@PCDO_ID", pCDO_ID);

           
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
      /// 获取指定的PCD_Queue对象(即:一条记录
      /// </summary>
      public PCD_Queue GetByKey(Int64 pCDO_ID)
      {
         PCD_Queue pCD_Queue = new PCD_Queue();
         string sql = "SELECT  PCDO_ID,PCDO_PlanCode,PCDO_NCode,PCDO_Order,Stat FROM PCD_Queue WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCDO_ID=@PCDO_ID ";
         idb.AddParameter("@PCDO_ID", pCDO_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCDO_ID"] != DBNull.Value) pCD_Queue.PCDO_ID = Convert.ToInt64(dr["PCDO_ID"]);
            if (dr["PCDO_PlanCode"] != DBNull.Value) pCD_Queue.PCDO_PlanCode = Convert.ToString(dr["PCDO_PlanCode"]);
            if (dr["PCDO_NCode"] != DBNull.Value) pCD_Queue.PCDO_NCode = Convert.ToString(dr["PCDO_NCode"]);
            if (dr["PCDO_Order"] != DBNull.Value) pCD_Queue.PCDO_Order = Convert.ToInt32(dr["PCDO_Order"]);
            if (dr["Stat"] != DBNull.Value) pCD_Queue.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCD_Queue;
      }
      /// <summary>
      /// 获取指定的PCD_Queue对象集合
      /// </summary>
      public List<PCD_Queue> GetListByWhere(string strCondition)
      {
         List<PCD_Queue> ret = new List<PCD_Queue>();
         string sql = "SELECT  PCDO_ID,PCDO_PlanCode,PCDO_NCode,PCDO_Order,Stat FROM PCD_Queue WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCD_Queue pCD_Queue = new PCD_Queue();
            if (dr["PCDO_ID"] != DBNull.Value) pCD_Queue.PCDO_ID = Convert.ToInt64(dr["PCDO_ID"]);
            if (dr["PCDO_PlanCode"] != DBNull.Value) pCD_Queue.PCDO_PlanCode = Convert.ToString(dr["PCDO_PlanCode"]);
            if (dr["PCDO_NCode"] != DBNull.Value) pCD_Queue.PCDO_NCode = Convert.ToString(dr["PCDO_NCode"]);
            if (dr["PCDO_Order"] != DBNull.Value) pCD_Queue.PCDO_Order = Convert.ToInt32(dr["PCDO_Order"]);
            if (dr["Stat"] != DBNull.Value) pCD_Queue.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(pCD_Queue);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PCD_Queue对象(即:一条记录
      /// </summary>
      public List<PCD_Queue> GetAll()
      {
         List<PCD_Queue> ret = new List<PCD_Queue>();
         string sql = "SELECT  PCDO_ID,PCDO_PlanCode,PCDO_NCode,PCDO_Order,Stat FROM PCD_Queue where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCDO_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCD_Queue pCD_Queue = new PCD_Queue();
            if (dr["PCDO_ID"] != DBNull.Value) pCD_Queue.PCDO_ID = Convert.ToInt64(dr["PCDO_ID"]);
            if (dr["PCDO_PlanCode"] != DBNull.Value) pCD_Queue.PCDO_PlanCode = Convert.ToString(dr["PCDO_PlanCode"]);
            if (dr["PCDO_NCode"] != DBNull.Value) pCD_Queue.PCDO_NCode = Convert.ToString(dr["PCDO_NCode"]);
            if (dr["PCDO_Order"] != DBNull.Value) pCD_Queue.PCDO_Order = Convert.ToInt32(dr["PCDO_Order"]);
            if (dr["Stat"] != DBNull.Value) pCD_Queue.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(pCD_Queue);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
