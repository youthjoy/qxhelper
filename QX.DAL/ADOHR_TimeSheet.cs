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
   /// 考勤信息
   /// </summary>
   [Serializable]
   public partial class ADOHR_TimeSheet
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加考勤信息 HR_TimeSheet对象(即:一条记录)
      /// </summary>
      public int Add(HR_TimeSheet hR_TimeSheet)
      {
         string sql = "INSERT INTO HR_TimeSheet (TS_Code,TS_StuffName,TS_StuffCode,TS_Type,TS_TypeName,TS_Start,TS_End,TS_Total,TS_Matter,Creator,CreateTime,VerifyStat,VerifyDate,VerifyStuff,VerifyNext,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TS_Code,@TS_StuffName,@TS_StuffCode,@TS_Type,@TS_TypeName,@TS_Start,@TS_End,@TS_Total,@TS_Matter,@Creator,@CreateTime,@VerifyStat,@VerifyDate,@VerifyStuff,@VerifyNext,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Code))
         {
            idb.AddParameter("@TS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Code", hR_TimeSheet.TS_Code);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_StuffName))
         {
            idb.AddParameter("@TS_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_StuffName", hR_TimeSheet.TS_StuffName);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_StuffCode))
         {
            idb.AddParameter("@TS_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_StuffCode", hR_TimeSheet.TS_StuffCode);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Type))
         {
            idb.AddParameter("@TS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Type", hR_TimeSheet.TS_Type);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_TypeName))
         {
            idb.AddParameter("@TS_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_TypeName", hR_TimeSheet.TS_TypeName);
         }
         if (hR_TimeSheet.TS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@TS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Start", hR_TimeSheet.TS_Start);
         }
         if (hR_TimeSheet.TS_End == DateTime.MinValue)
         {
            idb.AddParameter("@TS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_End", hR_TimeSheet.TS_End);
         }
         if (hR_TimeSheet.TS_Total == 0)
         {
            idb.AddParameter("@TS_Total", 0);
         }
         else
         {
            idb.AddParameter("@TS_Total", hR_TimeSheet.TS_Total);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Matter))
         {
            idb.AddParameter("@TS_Matter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Matter", hR_TimeSheet.TS_Matter);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_TimeSheet.Creator);
         }
         if (hR_TimeSheet.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_TimeSheet.CreateTime);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", hR_TimeSheet.VerifyStat);
         }
         if (hR_TimeSheet.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", hR_TimeSheet.VerifyDate);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", hR_TimeSheet.VerifyStuff);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyNext))
         {
            idb.AddParameter("@VerifyNext", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNext", hR_TimeSheet.VerifyNext);
         }
         if (hR_TimeSheet.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_TimeSheet.Stat);
         }
         if (hR_TimeSheet.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_TimeSheet.CreateDate);
         }
         if (hR_TimeSheet.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_TimeSheet.UpdateDate);
         }
         if (hR_TimeSheet.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_TimeSheet.DeleteDate);
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
      /// 添加考勤信息 HR_TimeSheet对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(HR_TimeSheet hR_TimeSheet)
      {
         string sql = "INSERT INTO HR_TimeSheet (TS_Code,TS_StuffName,TS_StuffCode,TS_Type,TS_TypeName,TS_Start,TS_End,TS_Total,TS_Matter,Creator,CreateTime,VerifyStat,VerifyDate,VerifyStuff,VerifyNext,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@TS_Code,@TS_StuffName,@TS_StuffCode,@TS_Type,@TS_TypeName,@TS_Start,@TS_End,@TS_Total,@TS_Matter,@Creator,@CreateTime,@VerifyStat,@VerifyDate,@VerifyStuff,@VerifyNext,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Code))
         {
            idb.AddParameter("@TS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Code", hR_TimeSheet.TS_Code);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_StuffName))
         {
            idb.AddParameter("@TS_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_StuffName", hR_TimeSheet.TS_StuffName);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_StuffCode))
         {
            idb.AddParameter("@TS_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_StuffCode", hR_TimeSheet.TS_StuffCode);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Type))
         {
            idb.AddParameter("@TS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Type", hR_TimeSheet.TS_Type);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_TypeName))
         {
            idb.AddParameter("@TS_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_TypeName", hR_TimeSheet.TS_TypeName);
         }
         if (hR_TimeSheet.TS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@TS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Start", hR_TimeSheet.TS_Start);
         }
         if (hR_TimeSheet.TS_End == DateTime.MinValue)
         {
            idb.AddParameter("@TS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_End", hR_TimeSheet.TS_End);
         }
         if (hR_TimeSheet.TS_Total == 0)
         {
            idb.AddParameter("@TS_Total", 0);
         }
         else
         {
            idb.AddParameter("@TS_Total", hR_TimeSheet.TS_Total);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Matter))
         {
            idb.AddParameter("@TS_Matter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Matter", hR_TimeSheet.TS_Matter);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_TimeSheet.Creator);
         }
         if (hR_TimeSheet.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_TimeSheet.CreateTime);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", hR_TimeSheet.VerifyStat);
         }
         if (hR_TimeSheet.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", hR_TimeSheet.VerifyDate);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", hR_TimeSheet.VerifyStuff);
         }
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyNext))
         {
            idb.AddParameter("@VerifyNext", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNext", hR_TimeSheet.VerifyNext);
         }
         if (hR_TimeSheet.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_TimeSheet.Stat);
         }
         if (hR_TimeSheet.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_TimeSheet.CreateDate);
         }
         if (hR_TimeSheet.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_TimeSheet.UpdateDate);
         }
         if (hR_TimeSheet.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_TimeSheet.DeleteDate);
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
      /// 更新考勤信息 HR_TimeSheet对象(即:一条记录
      /// </summary>
      public int Update(HR_TimeSheet hR_TimeSheet)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       HR_TimeSheet       SET ");
            if(hR_TimeSheet.TS_Code_IsChanged){sbParameter.Append("TS_Code=@TS_Code, ");}
      if(hR_TimeSheet.TS_StuffName_IsChanged){sbParameter.Append("TS_StuffName=@TS_StuffName, ");}
      if(hR_TimeSheet.TS_StuffCode_IsChanged){sbParameter.Append("TS_StuffCode=@TS_StuffCode, ");}
      if(hR_TimeSheet.TS_Type_IsChanged){sbParameter.Append("TS_Type=@TS_Type, ");}
      if(hR_TimeSheet.TS_TypeName_IsChanged){sbParameter.Append("TS_TypeName=@TS_TypeName, ");}
      if(hR_TimeSheet.TS_Start_IsChanged){sbParameter.Append("TS_Start=@TS_Start, ");}
      if(hR_TimeSheet.TS_End_IsChanged){sbParameter.Append("TS_End=@TS_End, ");}
      if(hR_TimeSheet.TS_Total_IsChanged){sbParameter.Append("TS_Total=@TS_Total, ");}
      if(hR_TimeSheet.TS_Matter_IsChanged){sbParameter.Append("TS_Matter=@TS_Matter, ");}
      if(hR_TimeSheet.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(hR_TimeSheet.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(hR_TimeSheet.VerifyStat_IsChanged){sbParameter.Append("VerifyStat=@VerifyStat, ");}
      if(hR_TimeSheet.VerifyDate_IsChanged){sbParameter.Append("VerifyDate=@VerifyDate, ");}
      if(hR_TimeSheet.VerifyStuff_IsChanged){sbParameter.Append("VerifyStuff=@VerifyStuff, ");}
      if(hR_TimeSheet.VerifyNext_IsChanged){sbParameter.Append("VerifyNext=@VerifyNext, ");}
      if(hR_TimeSheet.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(hR_TimeSheet.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(hR_TimeSheet.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(hR_TimeSheet.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TS_ID=@TS_ID; " );
      string sql=sb.ToString();
         if(hR_TimeSheet.TS_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Code))
         {
            idb.AddParameter("@TS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Code", hR_TimeSheet.TS_Code);
         }
          }
         if(hR_TimeSheet.TS_StuffName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_StuffName))
         {
            idb.AddParameter("@TS_StuffName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_StuffName", hR_TimeSheet.TS_StuffName);
         }
          }
         if(hR_TimeSheet.TS_StuffCode_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_StuffCode))
         {
            idb.AddParameter("@TS_StuffCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_StuffCode", hR_TimeSheet.TS_StuffCode);
         }
          }
         if(hR_TimeSheet.TS_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Type))
         {
            idb.AddParameter("@TS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Type", hR_TimeSheet.TS_Type);
         }
          }
         if(hR_TimeSheet.TS_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_TypeName))
         {
            idb.AddParameter("@TS_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_TypeName", hR_TimeSheet.TS_TypeName);
         }
          }
         if(hR_TimeSheet.TS_Start_IsChanged)
         {
         if (hR_TimeSheet.TS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@TS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Start", hR_TimeSheet.TS_Start);
         }
          }
         if(hR_TimeSheet.TS_End_IsChanged)
         {
         if (hR_TimeSheet.TS_End == DateTime.MinValue)
         {
            idb.AddParameter("@TS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_End", hR_TimeSheet.TS_End);
         }
          }
         if(hR_TimeSheet.TS_Total_IsChanged)
         {
         if (hR_TimeSheet.TS_Total == 0)
         {
            idb.AddParameter("@TS_Total", 0);
         }
         else
         {
            idb.AddParameter("@TS_Total", hR_TimeSheet.TS_Total);
         }
          }
         if(hR_TimeSheet.TS_Matter_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.TS_Matter))
         {
            idb.AddParameter("@TS_Matter", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TS_Matter", hR_TimeSheet.TS_Matter);
         }
          }
         if(hR_TimeSheet.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", hR_TimeSheet.Creator);
         }
          }
         if(hR_TimeSheet.CreateTime_IsChanged)
         {
         if (hR_TimeSheet.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", hR_TimeSheet.CreateTime);
         }
          }
         if(hR_TimeSheet.VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyStat))
         {
            idb.AddParameter("@VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStat", hR_TimeSheet.VerifyStat);
         }
          }
         if(hR_TimeSheet.VerifyDate_IsChanged)
         {
         if (hR_TimeSheet.VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyDate", hR_TimeSheet.VerifyDate);
         }
          }
         if(hR_TimeSheet.VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyStuff))
         {
            idb.AddParameter("@VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyStuff", hR_TimeSheet.VerifyStuff);
         }
          }
         if(hR_TimeSheet.VerifyNext_IsChanged)
         {
         if (string.IsNullOrEmpty(hR_TimeSheet.VerifyNext))
         {
            idb.AddParameter("@VerifyNext", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@VerifyNext", hR_TimeSheet.VerifyNext);
         }
          }
         if(hR_TimeSheet.Stat_IsChanged)
         {
         if (hR_TimeSheet.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", hR_TimeSheet.Stat);
         }
          }
         if(hR_TimeSheet.CreateDate_IsChanged)
         {
         if (hR_TimeSheet.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", hR_TimeSheet.CreateDate);
         }
          }
         if(hR_TimeSheet.UpdateDate_IsChanged)
         {
         if (hR_TimeSheet.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", hR_TimeSheet.UpdateDate);
         }
          }
         if(hR_TimeSheet.DeleteDate_IsChanged)
         {
         if (hR_TimeSheet.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", hR_TimeSheet.DeleteDate);
         }
          }

         idb.AddParameter("@TS_ID", hR_TimeSheet.TS_ID);

           
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
      /// 删除考勤信息 HR_TimeSheet对象(即:一条记录
      /// </summary>
      public int Delete(decimal tS_ID)
      {
         string sql = "DELETE HR_TimeSheet WHERE 1=1  AND TS_ID=@TS_ID ";
         idb.AddParameter("@TS_ID", tS_ID);

           
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
      /// 获取指定的考勤信息 HR_TimeSheet对象(即:一条记录
      /// </summary>
      public HR_TimeSheet GetByKey(decimal tS_ID)
      {
         HR_TimeSheet hR_TimeSheet = new HR_TimeSheet();
         string sql = "SELECT  TS_ID,TS_Code,TS_StuffName,TS_StuffCode,TS_Type,TS_TypeName,TS_Start,TS_End,TS_Total,TS_Matter,Creator,CreateTime,VerifyStat,VerifyDate,VerifyStuff,VerifyNext,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_TimeSheet WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TS_ID=@TS_ID ";
         idb.AddParameter("@TS_ID", tS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TS_ID"] != DBNull.Value) hR_TimeSheet.TS_ID = Convert.ToDecimal(dr["TS_ID"]);
            if (dr["TS_Code"] != DBNull.Value) hR_TimeSheet.TS_Code = Convert.ToString(dr["TS_Code"]);
            if (dr["TS_StuffName"] != DBNull.Value) hR_TimeSheet.TS_StuffName = Convert.ToString(dr["TS_StuffName"]);
            if (dr["TS_StuffCode"] != DBNull.Value) hR_TimeSheet.TS_StuffCode = Convert.ToString(dr["TS_StuffCode"]);
            if (dr["TS_Type"] != DBNull.Value) hR_TimeSheet.TS_Type = Convert.ToString(dr["TS_Type"]);
            if (dr["TS_TypeName"] != DBNull.Value) hR_TimeSheet.TS_TypeName = Convert.ToString(dr["TS_TypeName"]);
            if (dr["TS_Start"] != DBNull.Value) hR_TimeSheet.TS_Start = Convert.ToDateTime(dr["TS_Start"]);
            if (dr["TS_End"] != DBNull.Value) hR_TimeSheet.TS_End = Convert.ToDateTime(dr["TS_End"]);
            if (dr["TS_Total"] != DBNull.Value) hR_TimeSheet.TS_Total = Convert.ToInt64(dr["TS_Total"]);
            if (dr["TS_Matter"] != DBNull.Value) hR_TimeSheet.TS_Matter = Convert.ToString(dr["TS_Matter"]);
            if (dr["Creator"] != DBNull.Value) hR_TimeSheet.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) hR_TimeSheet.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStat"] != DBNull.Value) hR_TimeSheet.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) hR_TimeSheet.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStuff"] != DBNull.Value) hR_TimeSheet.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyNext"] != DBNull.Value) hR_TimeSheet.VerifyNext = Convert.ToString(dr["VerifyNext"]);
            if (dr["Stat"] != DBNull.Value) hR_TimeSheet.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_TimeSheet.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_TimeSheet.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_TimeSheet.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return hR_TimeSheet;
      }
      /// <summary>
      /// 获取指定的考勤信息 HR_TimeSheet对象集合
      /// </summary>
      public List<HR_TimeSheet> GetListByWhere(string strCondition)
      {
         List<HR_TimeSheet> ret = new List<HR_TimeSheet>();
         string sql = "SELECT  TS_ID,TS_Code,TS_StuffName,TS_StuffCode,TS_Type,TS_TypeName,TS_Start,TS_End,TS_Total,TS_Matter,Creator,CreateTime,VerifyStat,VerifyDate,VerifyStuff,VerifyNext,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_TimeSheet WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            HR_TimeSheet hR_TimeSheet = new HR_TimeSheet();
            if (dr["TS_ID"] != DBNull.Value) hR_TimeSheet.TS_ID = Convert.ToDecimal(dr["TS_ID"]);
            if (dr["TS_Code"] != DBNull.Value) hR_TimeSheet.TS_Code = Convert.ToString(dr["TS_Code"]);
            if (dr["TS_StuffName"] != DBNull.Value) hR_TimeSheet.TS_StuffName = Convert.ToString(dr["TS_StuffName"]);
            if (dr["TS_StuffCode"] != DBNull.Value) hR_TimeSheet.TS_StuffCode = Convert.ToString(dr["TS_StuffCode"]);
            if (dr["TS_Type"] != DBNull.Value) hR_TimeSheet.TS_Type = Convert.ToString(dr["TS_Type"]);
            if (dr["TS_TypeName"] != DBNull.Value) hR_TimeSheet.TS_TypeName = Convert.ToString(dr["TS_TypeName"]);
            if (dr["TS_Start"] != DBNull.Value) hR_TimeSheet.TS_Start = Convert.ToDateTime(dr["TS_Start"]);
            if (dr["TS_End"] != DBNull.Value) hR_TimeSheet.TS_End = Convert.ToDateTime(dr["TS_End"]);
            if (dr["TS_Total"] != DBNull.Value) hR_TimeSheet.TS_Total = Convert.ToInt64(dr["TS_Total"]);
            if (dr["TS_Matter"] != DBNull.Value) hR_TimeSheet.TS_Matter = Convert.ToString(dr["TS_Matter"]);
            if (dr["Creator"] != DBNull.Value) hR_TimeSheet.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) hR_TimeSheet.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStat"] != DBNull.Value) hR_TimeSheet.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) hR_TimeSheet.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStuff"] != DBNull.Value) hR_TimeSheet.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyNext"] != DBNull.Value) hR_TimeSheet.VerifyNext = Convert.ToString(dr["VerifyNext"]);
            if (dr["Stat"] != DBNull.Value) hR_TimeSheet.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_TimeSheet.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_TimeSheet.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_TimeSheet.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_TimeSheet);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的考勤信息 HR_TimeSheet对象(即:一条记录
      /// </summary>
      public List<HR_TimeSheet> GetAll()
      {
         List<HR_TimeSheet> ret = new List<HR_TimeSheet>();
         string sql = "SELECT  TS_ID,TS_Code,TS_StuffName,TS_StuffCode,TS_Type,TS_TypeName,TS_Start,TS_End,TS_Total,TS_Matter,Creator,CreateTime,VerifyStat,VerifyDate,VerifyStuff,VerifyNext,Stat,CreateDate,UpdateDate,DeleteDate FROM HR_TimeSheet where 1=1 AND ((Stat is null) or (Stat=0) ) order by TS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            HR_TimeSheet hR_TimeSheet = new HR_TimeSheet();
            if (dr["TS_ID"] != DBNull.Value) hR_TimeSheet.TS_ID = Convert.ToDecimal(dr["TS_ID"]);
            if (dr["TS_Code"] != DBNull.Value) hR_TimeSheet.TS_Code = Convert.ToString(dr["TS_Code"]);
            if (dr["TS_StuffName"] != DBNull.Value) hR_TimeSheet.TS_StuffName = Convert.ToString(dr["TS_StuffName"]);
            if (dr["TS_StuffCode"] != DBNull.Value) hR_TimeSheet.TS_StuffCode = Convert.ToString(dr["TS_StuffCode"]);
            if (dr["TS_Type"] != DBNull.Value) hR_TimeSheet.TS_Type = Convert.ToString(dr["TS_Type"]);
            if (dr["TS_TypeName"] != DBNull.Value) hR_TimeSheet.TS_TypeName = Convert.ToString(dr["TS_TypeName"]);
            if (dr["TS_Start"] != DBNull.Value) hR_TimeSheet.TS_Start = Convert.ToDateTime(dr["TS_Start"]);
            if (dr["TS_End"] != DBNull.Value) hR_TimeSheet.TS_End = Convert.ToDateTime(dr["TS_End"]);
            if (dr["TS_Total"] != DBNull.Value) hR_TimeSheet.TS_Total = Convert.ToInt64(dr["TS_Total"]);
            if (dr["TS_Matter"] != DBNull.Value) hR_TimeSheet.TS_Matter = Convert.ToString(dr["TS_Matter"]);
            if (dr["Creator"] != DBNull.Value) hR_TimeSheet.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) hR_TimeSheet.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["VerifyStat"] != DBNull.Value) hR_TimeSheet.VerifyStat = Convert.ToString(dr["VerifyStat"]);
            if (dr["VerifyDate"] != DBNull.Value) hR_TimeSheet.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
            if (dr["VerifyStuff"] != DBNull.Value) hR_TimeSheet.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
            if (dr["VerifyNext"] != DBNull.Value) hR_TimeSheet.VerifyNext = Convert.ToString(dr["VerifyNext"]);
            if (dr["Stat"] != DBNull.Value) hR_TimeSheet.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) hR_TimeSheet.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) hR_TimeSheet.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) hR_TimeSheet.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(hR_TimeSheet);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
