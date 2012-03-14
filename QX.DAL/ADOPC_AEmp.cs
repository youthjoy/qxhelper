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
   /// 生产人员安排
   /// </summary>
   [Serializable]
   public partial class ADOPC_AEmp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产人员安排 PC_AEmp对象(即:一条记录)
      /// </summary>
      public int Add(PC_AEmp pC_AEmp)
      {
         string sql = "INSERT INTO PC_AEmp (PCAE_PCode,PCAE_ACode,PCAE_Type,PCAE_ECode,PCAE_EName,PCAE_EContact,PCAE_RDate,PCAE_LDate,PCAE_Num,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCAE_PCode,@PCAE_ACode,@PCAE_Type,@PCAE_ECode,@PCAE_EName,@PCAE_EContact,@PCAE_RDate,@PCAE_LDate,@PCAE_Num,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_PCode))
         {
            idb.AddParameter("@PCAE_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_PCode", pC_AEmp.PCAE_PCode);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_ACode))
         {
            idb.AddParameter("@PCAE_ACode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_ACode", pC_AEmp.PCAE_ACode);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_Type))
         {
            idb.AddParameter("@PCAE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_Type", pC_AEmp.PCAE_Type);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_ECode))
         {
            idb.AddParameter("@PCAE_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_ECode", pC_AEmp.PCAE_ECode);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_EName))
         {
            idb.AddParameter("@PCAE_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_EName", pC_AEmp.PCAE_EName);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_EContact))
         {
            idb.AddParameter("@PCAE_EContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_EContact", pC_AEmp.PCAE_EContact);
         }
         if (pC_AEmp.PCAE_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCAE_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_RDate", pC_AEmp.PCAE_RDate);
         }
         if (pC_AEmp.PCAE_LDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCAE_LDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_LDate", pC_AEmp.PCAE_LDate);
         }
         if (pC_AEmp.PCAE_Num == 0)
         {
            idb.AddParameter("@PCAE_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCAE_Num", pC_AEmp.PCAE_Num);
         }
         if (pC_AEmp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_AEmp.Stat);
         }
         if (pC_AEmp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_AEmp.CreateDate);
         }
         if (pC_AEmp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_AEmp.UpdateDate);
         }
         if (pC_AEmp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_AEmp.DeleteDate);
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
      /// 添加生产人员安排 PC_AEmp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_AEmp pC_AEmp)
      {
         string sql = "INSERT INTO PC_AEmp (PCAE_PCode,PCAE_ACode,PCAE_Type,PCAE_ECode,PCAE_EName,PCAE_EContact,PCAE_RDate,PCAE_LDate,PCAE_Num,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCAE_PCode,@PCAE_ACode,@PCAE_Type,@PCAE_ECode,@PCAE_EName,@PCAE_EContact,@PCAE_RDate,@PCAE_LDate,@PCAE_Num,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_PCode))
         {
            idb.AddParameter("@PCAE_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_PCode", pC_AEmp.PCAE_PCode);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_ACode))
         {
            idb.AddParameter("@PCAE_ACode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_ACode", pC_AEmp.PCAE_ACode);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_Type))
         {
            idb.AddParameter("@PCAE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_Type", pC_AEmp.PCAE_Type);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_ECode))
         {
            idb.AddParameter("@PCAE_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_ECode", pC_AEmp.PCAE_ECode);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_EName))
         {
            idb.AddParameter("@PCAE_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_EName", pC_AEmp.PCAE_EName);
         }
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_EContact))
         {
            idb.AddParameter("@PCAE_EContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_EContact", pC_AEmp.PCAE_EContact);
         }
         if (pC_AEmp.PCAE_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCAE_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_RDate", pC_AEmp.PCAE_RDate);
         }
         if (pC_AEmp.PCAE_LDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCAE_LDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_LDate", pC_AEmp.PCAE_LDate);
         }
         if (pC_AEmp.PCAE_Num == 0)
         {
            idb.AddParameter("@PCAE_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCAE_Num", pC_AEmp.PCAE_Num);
         }
         if (pC_AEmp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_AEmp.Stat);
         }
         if (pC_AEmp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_AEmp.CreateDate);
         }
         if (pC_AEmp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_AEmp.UpdateDate);
         }
         if (pC_AEmp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_AEmp.DeleteDate);
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
      /// 更新生产人员安排 PC_AEmp对象(即:一条记录
      /// </summary>
      public int Update(PC_AEmp pC_AEmp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_AEmp       SET ");
            if(pC_AEmp.PCAE_PCode_IsChanged){sbParameter.Append("PCAE_PCode=@PCAE_PCode, ");}
      if(pC_AEmp.PCAE_ACode_IsChanged){sbParameter.Append("PCAE_ACode=@PCAE_ACode, ");}
      if(pC_AEmp.PCAE_Type_IsChanged){sbParameter.Append("PCAE_Type=@PCAE_Type, ");}
      if(pC_AEmp.PCAE_ECode_IsChanged){sbParameter.Append("PCAE_ECode=@PCAE_ECode, ");}
      if(pC_AEmp.PCAE_EName_IsChanged){sbParameter.Append("PCAE_EName=@PCAE_EName, ");}
      if(pC_AEmp.PCAE_EContact_IsChanged){sbParameter.Append("PCAE_EContact=@PCAE_EContact, ");}
      if(pC_AEmp.PCAE_RDate_IsChanged){sbParameter.Append("PCAE_RDate=@PCAE_RDate, ");}
      if(pC_AEmp.PCAE_LDate_IsChanged){sbParameter.Append("PCAE_LDate=@PCAE_LDate, ");}
      if(pC_AEmp.PCAE_Num_IsChanged){sbParameter.Append("PCAE_Num=@PCAE_Num, ");}
      if(pC_AEmp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_AEmp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_AEmp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_AEmp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCAE_ID=@PCAE_ID; " );
      string sql=sb.ToString();
         if(pC_AEmp.PCAE_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_PCode))
         {
            idb.AddParameter("@PCAE_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_PCode", pC_AEmp.PCAE_PCode);
         }
          }
         if(pC_AEmp.PCAE_ACode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_ACode))
         {
            idb.AddParameter("@PCAE_ACode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_ACode", pC_AEmp.PCAE_ACode);
         }
          }
         if(pC_AEmp.PCAE_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_Type))
         {
            idb.AddParameter("@PCAE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_Type", pC_AEmp.PCAE_Type);
         }
          }
         if(pC_AEmp.PCAE_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_ECode))
         {
            idb.AddParameter("@PCAE_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_ECode", pC_AEmp.PCAE_ECode);
         }
          }
         if(pC_AEmp.PCAE_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_EName))
         {
            idb.AddParameter("@PCAE_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_EName", pC_AEmp.PCAE_EName);
         }
          }
         if(pC_AEmp.PCAE_EContact_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEmp.PCAE_EContact))
         {
            idb.AddParameter("@PCAE_EContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_EContact", pC_AEmp.PCAE_EContact);
         }
          }
         if(pC_AEmp.PCAE_RDate_IsChanged)
         {
         if (pC_AEmp.PCAE_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCAE_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_RDate", pC_AEmp.PCAE_RDate);
         }
          }
         if(pC_AEmp.PCAE_LDate_IsChanged)
         {
         if (pC_AEmp.PCAE_LDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCAE_LDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAE_LDate", pC_AEmp.PCAE_LDate);
         }
          }
         if(pC_AEmp.PCAE_Num_IsChanged)
         {
         if (pC_AEmp.PCAE_Num == 0)
         {
            idb.AddParameter("@PCAE_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCAE_Num", pC_AEmp.PCAE_Num);
         }
          }
         if(pC_AEmp.Stat_IsChanged)
         {
         if (pC_AEmp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_AEmp.Stat);
         }
          }
         if(pC_AEmp.CreateDate_IsChanged)
         {
         if (pC_AEmp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_AEmp.CreateDate);
         }
          }
         if(pC_AEmp.UpdateDate_IsChanged)
         {
         if (pC_AEmp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_AEmp.UpdateDate);
         }
          }
         if(pC_AEmp.DeleteDate_IsChanged)
         {
         if (pC_AEmp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_AEmp.DeleteDate);
         }
          }

         idb.AddParameter("@PCAE_ID", pC_AEmp.PCAE_ID);

           
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
      /// 删除生产人员安排 PC_AEmp对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCAE_ID)
      {
         string sql = "DELETE PC_AEmp WHERE 1=1  AND PCAE_ID=@PCAE_ID ";
         idb.AddParameter("@PCAE_ID", pCAE_ID);

           
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
      /// 获取指定的生产人员安排 PC_AEmp对象(即:一条记录
      /// </summary>
      public PC_AEmp GetByKey(decimal pCAE_ID)
      {
         PC_AEmp pC_AEmp = new PC_AEmp();
         string sql = "SELECT  PCAE_ID,PCAE_PCode,PCAE_ACode,PCAE_Type,PCAE_ECode,PCAE_EName,PCAE_EContact,PCAE_RDate,PCAE_LDate,PCAE_Num,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_AEmp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCAE_ID=@PCAE_ID ";
         idb.AddParameter("@PCAE_ID", pCAE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCAE_ID"] != DBNull.Value) pC_AEmp.PCAE_ID = Convert.ToDecimal(dr["PCAE_ID"]);
            if (dr["PCAE_PCode"] != DBNull.Value) pC_AEmp.PCAE_PCode = Convert.ToString(dr["PCAE_PCode"]);
            if (dr["PCAE_ACode"] != DBNull.Value) pC_AEmp.PCAE_ACode = Convert.ToString(dr["PCAE_ACode"]);
            if (dr["PCAE_Type"] != DBNull.Value) pC_AEmp.PCAE_Type = Convert.ToString(dr["PCAE_Type"]);
            if (dr["PCAE_ECode"] != DBNull.Value) pC_AEmp.PCAE_ECode = Convert.ToString(dr["PCAE_ECode"]);
            if (dr["PCAE_EName"] != DBNull.Value) pC_AEmp.PCAE_EName = Convert.ToString(dr["PCAE_EName"]);
            if (dr["PCAE_EContact"] != DBNull.Value) pC_AEmp.PCAE_EContact = Convert.ToString(dr["PCAE_EContact"]);
            if (dr["PCAE_RDate"] != DBNull.Value) pC_AEmp.PCAE_RDate = Convert.ToDateTime(dr["PCAE_RDate"]);
            if (dr["PCAE_LDate"] != DBNull.Value) pC_AEmp.PCAE_LDate = Convert.ToDateTime(dr["PCAE_LDate"]);
            if (dr["PCAE_Num"] != DBNull.Value) pC_AEmp.PCAE_Num = Convert.ToInt32(dr["PCAE_Num"]);
            if (dr["Stat"] != DBNull.Value) pC_AEmp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_AEmp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_AEmp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_AEmp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_AEmp;
      }
      /// <summary>
      /// 获取指定的生产人员安排 PC_AEmp对象集合
      /// </summary>
      public List<PC_AEmp> GetListByWhere(string strCondition)
      {
         List<PC_AEmp> ret = new List<PC_AEmp>();
         string sql = "SELECT  PCAE_ID,PCAE_PCode,PCAE_ACode,PCAE_Type,PCAE_ECode,PCAE_EName,PCAE_EContact,PCAE_RDate,PCAE_LDate,PCAE_Num,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_AEmp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_AEmp pC_AEmp = new PC_AEmp();
            if (dr["PCAE_ID"] != DBNull.Value) pC_AEmp.PCAE_ID = Convert.ToDecimal(dr["PCAE_ID"]);
            if (dr["PCAE_PCode"] != DBNull.Value) pC_AEmp.PCAE_PCode = Convert.ToString(dr["PCAE_PCode"]);
            if (dr["PCAE_ACode"] != DBNull.Value) pC_AEmp.PCAE_ACode = Convert.ToString(dr["PCAE_ACode"]);
            if (dr["PCAE_Type"] != DBNull.Value) pC_AEmp.PCAE_Type = Convert.ToString(dr["PCAE_Type"]);
            if (dr["PCAE_ECode"] != DBNull.Value) pC_AEmp.PCAE_ECode = Convert.ToString(dr["PCAE_ECode"]);
            if (dr["PCAE_EName"] != DBNull.Value) pC_AEmp.PCAE_EName = Convert.ToString(dr["PCAE_EName"]);
            if (dr["PCAE_EContact"] != DBNull.Value) pC_AEmp.PCAE_EContact = Convert.ToString(dr["PCAE_EContact"]);
            if (dr["PCAE_RDate"] != DBNull.Value) pC_AEmp.PCAE_RDate = Convert.ToDateTime(dr["PCAE_RDate"]);
            if (dr["PCAE_LDate"] != DBNull.Value) pC_AEmp.PCAE_LDate = Convert.ToDateTime(dr["PCAE_LDate"]);
            if (dr["PCAE_Num"] != DBNull.Value) pC_AEmp.PCAE_Num = Convert.ToInt32(dr["PCAE_Num"]);
            if (dr["Stat"] != DBNull.Value) pC_AEmp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_AEmp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_AEmp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_AEmp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_AEmp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产人员安排 PC_AEmp对象(即:一条记录
      /// </summary>
      public List<PC_AEmp> GetAll()
      {
         List<PC_AEmp> ret = new List<PC_AEmp>();
         string sql = "SELECT  PCAE_ID,PCAE_PCode,PCAE_ACode,PCAE_Type,PCAE_ECode,PCAE_EName,PCAE_EContact,PCAE_RDate,PCAE_LDate,PCAE_Num,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_AEmp where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCAE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_AEmp pC_AEmp = new PC_AEmp();
            if (dr["PCAE_ID"] != DBNull.Value) pC_AEmp.PCAE_ID = Convert.ToDecimal(dr["PCAE_ID"]);
            if (dr["PCAE_PCode"] != DBNull.Value) pC_AEmp.PCAE_PCode = Convert.ToString(dr["PCAE_PCode"]);
            if (dr["PCAE_ACode"] != DBNull.Value) pC_AEmp.PCAE_ACode = Convert.ToString(dr["PCAE_ACode"]);
            if (dr["PCAE_Type"] != DBNull.Value) pC_AEmp.PCAE_Type = Convert.ToString(dr["PCAE_Type"]);
            if (dr["PCAE_ECode"] != DBNull.Value) pC_AEmp.PCAE_ECode = Convert.ToString(dr["PCAE_ECode"]);
            if (dr["PCAE_EName"] != DBNull.Value) pC_AEmp.PCAE_EName = Convert.ToString(dr["PCAE_EName"]);
            if (dr["PCAE_EContact"] != DBNull.Value) pC_AEmp.PCAE_EContact = Convert.ToString(dr["PCAE_EContact"]);
            if (dr["PCAE_RDate"] != DBNull.Value) pC_AEmp.PCAE_RDate = Convert.ToDateTime(dr["PCAE_RDate"]);
            if (dr["PCAE_LDate"] != DBNull.Value) pC_AEmp.PCAE_LDate = Convert.ToDateTime(dr["PCAE_LDate"]);
            if (dr["PCAE_Num"] != DBNull.Value) pC_AEmp.PCAE_Num = Convert.ToInt32(dr["PCAE_Num"]);
            if (dr["Stat"] != DBNull.Value) pC_AEmp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_AEmp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_AEmp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_AEmp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_AEmp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
