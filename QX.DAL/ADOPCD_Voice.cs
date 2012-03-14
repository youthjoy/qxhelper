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
   /// 语音播报
   /// </summary>
   [Serializable]
   public partial class ADOPCD_Voice
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加语音播报 PCD_Voice对象(即:一条记录)
      /// </summary>
      public int Add(PCD_Voice pCD_Voice)
      {
         string sql = "INSERT INTO PCD_Voice (PCDV_Code,PCDV_Type,PCDV_OType,PCDV_Object,PCDV_Content,PCDV_Date,PCDV_ODate,PCDV_FType,PCDV_FCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCDV_Code,@PCDV_Type,@PCDV_OType,@PCDV_Object,@PCDV_Content,@PCDV_Date,@PCDV_ODate,@PCDV_FType,@PCDV_FCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Code))
         {
            idb.AddParameter("@PCDV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Code", pCD_Voice.PCDV_Code);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Type))
         {
            idb.AddParameter("@PCDV_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Type", pCD_Voice.PCDV_Type);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_OType))
         {
            idb.AddParameter("@PCDV_OType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_OType", pCD_Voice.PCDV_OType);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Object))
         {
            idb.AddParameter("@PCDV_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Object", pCD_Voice.PCDV_Object);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Content))
         {
            idb.AddParameter("@PCDV_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Content", pCD_Voice.PCDV_Content);
         }
         if (pCD_Voice.PCDV_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCDV_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Date", pCD_Voice.PCDV_Date);
         }
         if (pCD_Voice.PCDV_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDV_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_ODate", pCD_Voice.PCDV_ODate);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_FType))
         {
            idb.AddParameter("@PCDV_FType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_FType", pCD_Voice.PCDV_FType);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_FCode))
         {
            idb.AddParameter("@PCDV_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_FCode", pCD_Voice.PCDV_FCode);
         }
         if (pCD_Voice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Voice.Stat);
         }
         if (pCD_Voice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_Voice.CreateDate);
         }
         if (pCD_Voice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_Voice.UpdateDate);
         }
         if (pCD_Voice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_Voice.DeleteDate);
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
      /// 添加语音播报 PCD_Voice对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCD_Voice pCD_Voice)
      {
         string sql = "INSERT INTO PCD_Voice (PCDV_Code,PCDV_Type,PCDV_OType,PCDV_Object,PCDV_Content,PCDV_Date,PCDV_ODate,PCDV_FType,PCDV_FCode,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCDV_Code,@PCDV_Type,@PCDV_OType,@PCDV_Object,@PCDV_Content,@PCDV_Date,@PCDV_ODate,@PCDV_FType,@PCDV_FCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Code))
         {
            idb.AddParameter("@PCDV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Code", pCD_Voice.PCDV_Code);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Type))
         {
            idb.AddParameter("@PCDV_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Type", pCD_Voice.PCDV_Type);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_OType))
         {
            idb.AddParameter("@PCDV_OType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_OType", pCD_Voice.PCDV_OType);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Object))
         {
            idb.AddParameter("@PCDV_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Object", pCD_Voice.PCDV_Object);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Content))
         {
            idb.AddParameter("@PCDV_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Content", pCD_Voice.PCDV_Content);
         }
         if (pCD_Voice.PCDV_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCDV_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Date", pCD_Voice.PCDV_Date);
         }
         if (pCD_Voice.PCDV_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDV_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_ODate", pCD_Voice.PCDV_ODate);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_FType))
         {
            idb.AddParameter("@PCDV_FType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_FType", pCD_Voice.PCDV_FType);
         }
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_FCode))
         {
            idb.AddParameter("@PCDV_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_FCode", pCD_Voice.PCDV_FCode);
         }
         if (pCD_Voice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Voice.Stat);
         }
         if (pCD_Voice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_Voice.CreateDate);
         }
         if (pCD_Voice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_Voice.UpdateDate);
         }
         if (pCD_Voice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_Voice.DeleteDate);
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
      /// 更新语音播报 PCD_Voice对象(即:一条记录
      /// </summary>
      public int Update(PCD_Voice pCD_Voice)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCD_Voice       SET ");
            if(pCD_Voice.PCDV_Code_IsChanged){sbParameter.Append("PCDV_Code=@PCDV_Code, ");}
      if(pCD_Voice.PCDV_Type_IsChanged){sbParameter.Append("PCDV_Type=@PCDV_Type, ");}
      if(pCD_Voice.PCDV_OType_IsChanged){sbParameter.Append("PCDV_OType=@PCDV_OType, ");}
      if(pCD_Voice.PCDV_Object_IsChanged){sbParameter.Append("PCDV_Object=@PCDV_Object, ");}
      if(pCD_Voice.PCDV_Content_IsChanged){sbParameter.Append("PCDV_Content=@PCDV_Content, ");}
      if(pCD_Voice.PCDV_Date_IsChanged){sbParameter.Append("PCDV_Date=@PCDV_Date, ");}
      if(pCD_Voice.PCDV_ODate_IsChanged){sbParameter.Append("PCDV_ODate=@PCDV_ODate, ");}
      if(pCD_Voice.PCDV_FType_IsChanged){sbParameter.Append("PCDV_FType=@PCDV_FType, ");}
      if(pCD_Voice.PCDV_FCode_IsChanged){sbParameter.Append("PCDV_FCode=@PCDV_FCode, ");}
      if(pCD_Voice.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCD_Voice.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCD_Voice.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCD_Voice.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCDV_ID=@PCDV_ID; " );
      string sql=sb.ToString();
         if(pCD_Voice.PCDV_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Code))
         {
            idb.AddParameter("@PCDV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Code", pCD_Voice.PCDV_Code);
         }
          }
         if(pCD_Voice.PCDV_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Type))
         {
            idb.AddParameter("@PCDV_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Type", pCD_Voice.PCDV_Type);
         }
          }
         if(pCD_Voice.PCDV_OType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_OType))
         {
            idb.AddParameter("@PCDV_OType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_OType", pCD_Voice.PCDV_OType);
         }
          }
         if(pCD_Voice.PCDV_Object_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Object))
         {
            idb.AddParameter("@PCDV_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Object", pCD_Voice.PCDV_Object);
         }
          }
         if(pCD_Voice.PCDV_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_Content))
         {
            idb.AddParameter("@PCDV_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Content", pCD_Voice.PCDV_Content);
         }
          }
         if(pCD_Voice.PCDV_Date_IsChanged)
         {
         if (pCD_Voice.PCDV_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCDV_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_Date", pCD_Voice.PCDV_Date);
         }
          }
         if(pCD_Voice.PCDV_ODate_IsChanged)
         {
         if (pCD_Voice.PCDV_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDV_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_ODate", pCD_Voice.PCDV_ODate);
         }
          }
         if(pCD_Voice.PCDV_FType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_FType))
         {
            idb.AddParameter("@PCDV_FType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_FType", pCD_Voice.PCDV_FType);
         }
          }
         if(pCD_Voice.PCDV_FCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Voice.PCDV_FCode))
         {
            idb.AddParameter("@PCDV_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDV_FCode", pCD_Voice.PCDV_FCode);
         }
          }
         if(pCD_Voice.Stat_IsChanged)
         {
         if (pCD_Voice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Voice.Stat);
         }
          }
         if(pCD_Voice.CreateDate_IsChanged)
         {
         if (pCD_Voice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_Voice.CreateDate);
         }
          }
         if(pCD_Voice.UpdateDate_IsChanged)
         {
         if (pCD_Voice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_Voice.UpdateDate);
         }
          }
         if(pCD_Voice.DeleteDate_IsChanged)
         {
         if (pCD_Voice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_Voice.DeleteDate);
         }
          }

         idb.AddParameter("@PCDV_ID", pCD_Voice.PCDV_ID);

           
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
      /// 删除语音播报 PCD_Voice对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCDV_ID)
      {
         string sql = "DELETE PCD_Voice WHERE 1=1  AND PCDV_ID=@PCDV_ID ";
         idb.AddParameter("@PCDV_ID", pCDV_ID);

           
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
      /// 获取指定的语音播报 PCD_Voice对象(即:一条记录
      /// </summary>
      public PCD_Voice GetByKey(decimal pCDV_ID)
      {
         PCD_Voice pCD_Voice = new PCD_Voice();
         string sql = "SELECT  PCDV_ID,PCDV_Code,PCDV_Type,PCDV_OType,PCDV_Object,PCDV_Content,PCDV_Date,PCDV_ODate,PCDV_FType,PCDV_FCode,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_Voice WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCDV_ID=@PCDV_ID ";
         idb.AddParameter("@PCDV_ID", pCDV_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCDV_ID"] != DBNull.Value) pCD_Voice.PCDV_ID = Convert.ToDecimal(dr["PCDV_ID"]);
            if (dr["PCDV_Code"] != DBNull.Value) pCD_Voice.PCDV_Code = Convert.ToString(dr["PCDV_Code"]);
            if (dr["PCDV_Type"] != DBNull.Value) pCD_Voice.PCDV_Type = Convert.ToString(dr["PCDV_Type"]);
            if (dr["PCDV_OType"] != DBNull.Value) pCD_Voice.PCDV_OType = Convert.ToString(dr["PCDV_OType"]);
            if (dr["PCDV_Object"] != DBNull.Value) pCD_Voice.PCDV_Object = Convert.ToString(dr["PCDV_Object"]);
            if (dr["PCDV_Content"] != DBNull.Value) pCD_Voice.PCDV_Content = Convert.ToString(dr["PCDV_Content"]);
            if (dr["PCDV_Date"] != DBNull.Value) pCD_Voice.PCDV_Date = Convert.ToDateTime(dr["PCDV_Date"]);
            if (dr["PCDV_ODate"] != DBNull.Value) pCD_Voice.PCDV_ODate = Convert.ToDateTime(dr["PCDV_ODate"]);
            if (dr["PCDV_FType"] != DBNull.Value) pCD_Voice.PCDV_FType = Convert.ToString(dr["PCDV_FType"]);
            if (dr["PCDV_FCode"] != DBNull.Value) pCD_Voice.PCDV_FCode = Convert.ToString(dr["PCDV_FCode"]);
            if (dr["Stat"] != DBNull.Value) pCD_Voice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_Voice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_Voice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_Voice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCD_Voice;
      }
      /// <summary>
      /// 获取指定的语音播报 PCD_Voice对象集合
      /// </summary>
      public List<PCD_Voice> GetListByWhere(string strCondition)
      {
         List<PCD_Voice> ret = new List<PCD_Voice>();
         string sql = "SELECT  PCDV_ID,PCDV_Code,PCDV_Type,PCDV_OType,PCDV_Object,PCDV_Content,PCDV_Date,PCDV_ODate,PCDV_FType,PCDV_FCode,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_Voice WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCD_Voice pCD_Voice = new PCD_Voice();
            if (dr["PCDV_ID"] != DBNull.Value) pCD_Voice.PCDV_ID = Convert.ToDecimal(dr["PCDV_ID"]);
            if (dr["PCDV_Code"] != DBNull.Value) pCD_Voice.PCDV_Code = Convert.ToString(dr["PCDV_Code"]);
            if (dr["PCDV_Type"] != DBNull.Value) pCD_Voice.PCDV_Type = Convert.ToString(dr["PCDV_Type"]);
            if (dr["PCDV_OType"] != DBNull.Value) pCD_Voice.PCDV_OType = Convert.ToString(dr["PCDV_OType"]);
            if (dr["PCDV_Object"] != DBNull.Value) pCD_Voice.PCDV_Object = Convert.ToString(dr["PCDV_Object"]);
            if (dr["PCDV_Content"] != DBNull.Value) pCD_Voice.PCDV_Content = Convert.ToString(dr["PCDV_Content"]);
            if (dr["PCDV_Date"] != DBNull.Value) pCD_Voice.PCDV_Date = Convert.ToDateTime(dr["PCDV_Date"]);
            if (dr["PCDV_ODate"] != DBNull.Value) pCD_Voice.PCDV_ODate = Convert.ToDateTime(dr["PCDV_ODate"]);
            if (dr["PCDV_FType"] != DBNull.Value) pCD_Voice.PCDV_FType = Convert.ToString(dr["PCDV_FType"]);
            if (dr["PCDV_FCode"] != DBNull.Value) pCD_Voice.PCDV_FCode = Convert.ToString(dr["PCDV_FCode"]);
            if (dr["Stat"] != DBNull.Value) pCD_Voice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_Voice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_Voice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_Voice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCD_Voice);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的语音播报 PCD_Voice对象(即:一条记录
      /// </summary>
      public List<PCD_Voice> GetAll()
      {
         List<PCD_Voice> ret = new List<PCD_Voice>();
         string sql = "SELECT  PCDV_ID,PCDV_Code,PCDV_Type,PCDV_OType,PCDV_Object,PCDV_Content,PCDV_Date,PCDV_ODate,PCDV_FType,PCDV_FCode,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_Voice where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCDV_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCD_Voice pCD_Voice = new PCD_Voice();
            if (dr["PCDV_ID"] != DBNull.Value) pCD_Voice.PCDV_ID = Convert.ToDecimal(dr["PCDV_ID"]);
            if (dr["PCDV_Code"] != DBNull.Value) pCD_Voice.PCDV_Code = Convert.ToString(dr["PCDV_Code"]);
            if (dr["PCDV_Type"] != DBNull.Value) pCD_Voice.PCDV_Type = Convert.ToString(dr["PCDV_Type"]);
            if (dr["PCDV_OType"] != DBNull.Value) pCD_Voice.PCDV_OType = Convert.ToString(dr["PCDV_OType"]);
            if (dr["PCDV_Object"] != DBNull.Value) pCD_Voice.PCDV_Object = Convert.ToString(dr["PCDV_Object"]);
            if (dr["PCDV_Content"] != DBNull.Value) pCD_Voice.PCDV_Content = Convert.ToString(dr["PCDV_Content"]);
            if (dr["PCDV_Date"] != DBNull.Value) pCD_Voice.PCDV_Date = Convert.ToDateTime(dr["PCDV_Date"]);
            if (dr["PCDV_ODate"] != DBNull.Value) pCD_Voice.PCDV_ODate = Convert.ToDateTime(dr["PCDV_ODate"]);
            if (dr["PCDV_FType"] != DBNull.Value) pCD_Voice.PCDV_FType = Convert.ToString(dr["PCDV_FType"]);
            if (dr["PCDV_FCode"] != DBNull.Value) pCD_Voice.PCDV_FCode = Convert.ToString(dr["PCDV_FCode"]);
            if (dr["Stat"] != DBNull.Value) pCD_Voice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_Voice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_Voice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_Voice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCD_Voice);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
