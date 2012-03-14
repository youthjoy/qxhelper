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
   /// 计划准备记录
   /// </summary>
   [Serializable]
   public partial class ADOPC_PStatus
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加计划准备记录 PC_PStatus对象(即:一条记录)
      /// </summary>
      public int Add(PC_PStatus pC_PStatus)
      {
         string sql = "INSERT INTO PC_PStatus (PCPS_Code,PCPS_PlanCode,PCPS_SType,PCPS_SVal,PCPS_RDate,PCPS_ROperator,PCPS_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCPS_Code,@PCPS_PlanCode,@PCPS_SType,@PCPS_SVal,@PCPS_RDate,@PCPS_ROperator,@PCPS_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_Code))
         {
            idb.AddParameter("@PCPS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_Code", pC_PStatus.PCPS_Code);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_PlanCode))
         {
            idb.AddParameter("@PCPS_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_PlanCode", pC_PStatus.PCPS_PlanCode);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_SType))
         {
            idb.AddParameter("@PCPS_SType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_SType", pC_PStatus.PCPS_SType);
         }
         if (pC_PStatus.PCPS_SVal == 0)
         {
            idb.AddParameter("@PCPS_SVal", 0);
         }
         else
         {
            idb.AddParameter("@PCPS_SVal", pC_PStatus.PCPS_SVal);
         }
         if (pC_PStatus.PCPS_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCPS_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_RDate", pC_PStatus.PCPS_RDate);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_ROperator))
         {
            idb.AddParameter("@PCPS_ROperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_ROperator", pC_PStatus.PCPS_ROperator);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_Remark))
         {
            idb.AddParameter("@PCPS_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_Remark", pC_PStatus.PCPS_Remark);
         }
         if (pC_PStatus.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_PStatus.Stat);
         }
         if (pC_PStatus.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_PStatus.CreateDate);
         }
         if (pC_PStatus.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_PStatus.UpdateDate);
         }
         if (pC_PStatus.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_PStatus.DeleteDate);
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
      /// 添加计划准备记录 PC_PStatus对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_PStatus pC_PStatus)
      {
         string sql = "INSERT INTO PC_PStatus (PCPS_Code,PCPS_PlanCode,PCPS_SType,PCPS_SVal,PCPS_RDate,PCPS_ROperator,PCPS_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCPS_Code,@PCPS_PlanCode,@PCPS_SType,@PCPS_SVal,@PCPS_RDate,@PCPS_ROperator,@PCPS_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_Code))
         {
            idb.AddParameter("@PCPS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_Code", pC_PStatus.PCPS_Code);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_PlanCode))
         {
            idb.AddParameter("@PCPS_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_PlanCode", pC_PStatus.PCPS_PlanCode);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_SType))
         {
            idb.AddParameter("@PCPS_SType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_SType", pC_PStatus.PCPS_SType);
         }
         if (pC_PStatus.PCPS_SVal == 0)
         {
            idb.AddParameter("@PCPS_SVal", 0);
         }
         else
         {
            idb.AddParameter("@PCPS_SVal", pC_PStatus.PCPS_SVal);
         }
         if (pC_PStatus.PCPS_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCPS_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_RDate", pC_PStatus.PCPS_RDate);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_ROperator))
         {
            idb.AddParameter("@PCPS_ROperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_ROperator", pC_PStatus.PCPS_ROperator);
         }
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_Remark))
         {
            idb.AddParameter("@PCPS_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_Remark", pC_PStatus.PCPS_Remark);
         }
         if (pC_PStatus.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_PStatus.Stat);
         }
         if (pC_PStatus.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_PStatus.CreateDate);
         }
         if (pC_PStatus.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_PStatus.UpdateDate);
         }
         if (pC_PStatus.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_PStatus.DeleteDate);
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
      /// 更新计划准备记录 PC_PStatus对象(即:一条记录
      /// </summary>
      public int Update(PC_PStatus pC_PStatus)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_PStatus       SET ");
            if(pC_PStatus.PCPS_Code_IsChanged){sbParameter.Append("PCPS_Code=@PCPS_Code, ");}
      if(pC_PStatus.PCPS_PlanCode_IsChanged){sbParameter.Append("PCPS_PlanCode=@PCPS_PlanCode, ");}
      if(pC_PStatus.PCPS_SType_IsChanged){sbParameter.Append("PCPS_SType=@PCPS_SType, ");}
      if(pC_PStatus.PCPS_SVal_IsChanged){sbParameter.Append("PCPS_SVal=@PCPS_SVal, ");}
      if(pC_PStatus.PCPS_RDate_IsChanged){sbParameter.Append("PCPS_RDate=@PCPS_RDate, ");}
      if(pC_PStatus.PCPS_ROperator_IsChanged){sbParameter.Append("PCPS_ROperator=@PCPS_ROperator, ");}
      if(pC_PStatus.PCPS_Remark_IsChanged){sbParameter.Append("PCPS_Remark=@PCPS_Remark, ");}
      if(pC_PStatus.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_PStatus.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_PStatus.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_PStatus.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCPS_ID=@PCPS_ID; " );
      string sql=sb.ToString();
         if(pC_PStatus.PCPS_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_Code))
         {
            idb.AddParameter("@PCPS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_Code", pC_PStatus.PCPS_Code);
         }
          }
         if(pC_PStatus.PCPS_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_PlanCode))
         {
            idb.AddParameter("@PCPS_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_PlanCode", pC_PStatus.PCPS_PlanCode);
         }
          }
         if(pC_PStatus.PCPS_SType_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_SType))
         {
            idb.AddParameter("@PCPS_SType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_SType", pC_PStatus.PCPS_SType);
         }
          }
         if(pC_PStatus.PCPS_SVal_IsChanged)
         {
         if (pC_PStatus.PCPS_SVal == 0)
         {
            idb.AddParameter("@PCPS_SVal", 0);
         }
         else
         {
            idb.AddParameter("@PCPS_SVal", pC_PStatus.PCPS_SVal);
         }
          }
         if(pC_PStatus.PCPS_RDate_IsChanged)
         {
         if (pC_PStatus.PCPS_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCPS_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_RDate", pC_PStatus.PCPS_RDate);
         }
          }
         if(pC_PStatus.PCPS_ROperator_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_ROperator))
         {
            idb.AddParameter("@PCPS_ROperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_ROperator", pC_PStatus.PCPS_ROperator);
         }
          }
         if(pC_PStatus.PCPS_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_PStatus.PCPS_Remark))
         {
            idb.AddParameter("@PCPS_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCPS_Remark", pC_PStatus.PCPS_Remark);
         }
          }
         if(pC_PStatus.Stat_IsChanged)
         {
         if (pC_PStatus.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_PStatus.Stat);
         }
          }
         if(pC_PStatus.CreateDate_IsChanged)
         {
         if (pC_PStatus.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_PStatus.CreateDate);
         }
          }
         if(pC_PStatus.UpdateDate_IsChanged)
         {
         if (pC_PStatus.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_PStatus.UpdateDate);
         }
          }
         if(pC_PStatus.DeleteDate_IsChanged)
         {
         if (pC_PStatus.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_PStatus.DeleteDate);
         }
          }

         idb.AddParameter("@PCPS_ID", pC_PStatus.PCPS_ID);

           
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
      /// 删除计划准备记录 PC_PStatus对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCPS_ID)
      {
         string sql = "DELETE PC_PStatus WHERE 1=1  AND PCPS_ID=@PCPS_ID ";
         idb.AddParameter("@PCPS_ID", pCPS_ID);

           
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
      /// 获取指定的计划准备记录 PC_PStatus对象(即:一条记录
      /// </summary>
      public PC_PStatus GetByKey(decimal pCPS_ID)
      {
         PC_PStatus pC_PStatus = new PC_PStatus();
         string sql = "SELECT  PCPS_ID,PCPS_Code,PCPS_PlanCode,PCPS_SType,PCPS_SVal,PCPS_RDate,PCPS_ROperator,PCPS_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_PStatus WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCPS_ID=@PCPS_ID ";
         idb.AddParameter("@PCPS_ID", pCPS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCPS_ID"] != DBNull.Value) pC_PStatus.PCPS_ID = Convert.ToDecimal(dr["PCPS_ID"]);
            if (dr["PCPS_Code"] != DBNull.Value) pC_PStatus.PCPS_Code = Convert.ToString(dr["PCPS_Code"]);
            if (dr["PCPS_PlanCode"] != DBNull.Value) pC_PStatus.PCPS_PlanCode = Convert.ToString(dr["PCPS_PlanCode"]);
            if (dr["PCPS_SType"] != DBNull.Value) pC_PStatus.PCPS_SType = Convert.ToString(dr["PCPS_SType"]);
            if (dr["PCPS_SVal"] != DBNull.Value) pC_PStatus.PCPS_SVal = Convert.ToDecimal(dr["PCPS_SVal"]);
            if (dr["PCPS_RDate"] != DBNull.Value) pC_PStatus.PCPS_RDate = Convert.ToDateTime(dr["PCPS_RDate"]);
            if (dr["PCPS_ROperator"] != DBNull.Value) pC_PStatus.PCPS_ROperator = Convert.ToString(dr["PCPS_ROperator"]);
            if (dr["PCPS_Remark"] != DBNull.Value) pC_PStatus.PCPS_Remark = Convert.ToString(dr["PCPS_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_PStatus.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_PStatus.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_PStatus.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_PStatus.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_PStatus;
      }
      /// <summary>
      /// 获取指定的计划准备记录 PC_PStatus对象集合
      /// </summary>
      public List<PC_PStatus> GetListByWhere(string strCondition)
      {
         List<PC_PStatus> ret = new List<PC_PStatus>();
         string sql = "SELECT  PCPS_ID,PCPS_Code,PCPS_PlanCode,PCPS_SType,PCPS_SVal,PCPS_RDate,PCPS_ROperator,PCPS_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_PStatus WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_PStatus pC_PStatus = new PC_PStatus();
            if (dr["PCPS_ID"] != DBNull.Value) pC_PStatus.PCPS_ID = Convert.ToDecimal(dr["PCPS_ID"]);
            if (dr["PCPS_Code"] != DBNull.Value) pC_PStatus.PCPS_Code = Convert.ToString(dr["PCPS_Code"]);
            if (dr["PCPS_PlanCode"] != DBNull.Value) pC_PStatus.PCPS_PlanCode = Convert.ToString(dr["PCPS_PlanCode"]);
            if (dr["PCPS_SType"] != DBNull.Value) pC_PStatus.PCPS_SType = Convert.ToString(dr["PCPS_SType"]);
            if (dr["PCPS_SVal"] != DBNull.Value) pC_PStatus.PCPS_SVal = Convert.ToDecimal(dr["PCPS_SVal"]);
            if (dr["PCPS_RDate"] != DBNull.Value) pC_PStatus.PCPS_RDate = Convert.ToDateTime(dr["PCPS_RDate"]);
            if (dr["PCPS_ROperator"] != DBNull.Value) pC_PStatus.PCPS_ROperator = Convert.ToString(dr["PCPS_ROperator"]);
            if (dr["PCPS_Remark"] != DBNull.Value) pC_PStatus.PCPS_Remark = Convert.ToString(dr["PCPS_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_PStatus.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_PStatus.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_PStatus.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_PStatus.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_PStatus);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的计划准备记录 PC_PStatus对象(即:一条记录
      /// </summary>
      public List<PC_PStatus> GetAll()
      {
         List<PC_PStatus> ret = new List<PC_PStatus>();
         string sql = "SELECT  PCPS_ID,PCPS_Code,PCPS_PlanCode,PCPS_SType,PCPS_SVal,PCPS_RDate,PCPS_ROperator,PCPS_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_PStatus where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCPS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_PStatus pC_PStatus = new PC_PStatus();
            if (dr["PCPS_ID"] != DBNull.Value) pC_PStatus.PCPS_ID = Convert.ToDecimal(dr["PCPS_ID"]);
            if (dr["PCPS_Code"] != DBNull.Value) pC_PStatus.PCPS_Code = Convert.ToString(dr["PCPS_Code"]);
            if (dr["PCPS_PlanCode"] != DBNull.Value) pC_PStatus.PCPS_PlanCode = Convert.ToString(dr["PCPS_PlanCode"]);
            if (dr["PCPS_SType"] != DBNull.Value) pC_PStatus.PCPS_SType = Convert.ToString(dr["PCPS_SType"]);
            if (dr["PCPS_SVal"] != DBNull.Value) pC_PStatus.PCPS_SVal = Convert.ToDecimal(dr["PCPS_SVal"]);
            if (dr["PCPS_RDate"] != DBNull.Value) pC_PStatus.PCPS_RDate = Convert.ToDateTime(dr["PCPS_RDate"]);
            if (dr["PCPS_ROperator"] != DBNull.Value) pC_PStatus.PCPS_ROperator = Convert.ToString(dr["PCPS_ROperator"]);
            if (dr["PCPS_Remark"] != DBNull.Value) pC_PStatus.PCPS_Remark = Convert.ToString(dr["PCPS_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_PStatus.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_PStatus.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_PStatus.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_PStatus.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_PStatus);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
