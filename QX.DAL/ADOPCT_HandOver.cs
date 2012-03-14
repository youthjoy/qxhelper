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
   /// 车辆交接班
   /// </summary>
   [Serializable]
   public partial class ADOPCT_HandOver
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加车辆交接班 PCT_HandOver对象(即:一条记录)
      /// </summary>
      public int Add(PCT_HandOver pCT_HandOver)
      {
         string sql = "INSERT INTO PCT_HandOver (PCTH_Code,PCTH_TCode,PCTH_TNo,PCTH_TName,PCTH_Type,PCTH_Key,PCTH_LDriver,PCTH_LDcode,PCTH_CDriver,PCTH_CDcode,PCTH_JDate,PCTH_HDate,PCTH_CStatus,PCTH_IsCurrent,PCTH_Date,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCTH_Code,@PCTH_TCode,@PCTH_TNo,@PCTH_TName,@PCTH_Type,@PCTH_Key,@PCTH_LDriver,@PCTH_LDcode,@PCTH_CDriver,@PCTH_CDcode,@PCTH_JDate,@PCTH_HDate,@PCTH_CStatus,@PCTH_IsCurrent,@PCTH_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Code))
         {
            idb.AddParameter("@PCTH_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Code", pCT_HandOver.PCTH_Code);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TCode))
         {
            idb.AddParameter("@PCTH_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TCode", pCT_HandOver.PCTH_TCode);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TNo))
         {
            idb.AddParameter("@PCTH_TNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TNo", pCT_HandOver.PCTH_TNo);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TName))
         {
            idb.AddParameter("@PCTH_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TName", pCT_HandOver.PCTH_TName);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Type))
         {
            idb.AddParameter("@PCTH_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Type", pCT_HandOver.PCTH_Type);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Key))
         {
            idb.AddParameter("@PCTH_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Key", pCT_HandOver.PCTH_Key);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_LDriver))
         {
            idb.AddParameter("@PCTH_LDriver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_LDriver", pCT_HandOver.PCTH_LDriver);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_LDcode))
         {
            idb.AddParameter("@PCTH_LDcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_LDcode", pCT_HandOver.PCTH_LDcode);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CDriver))
         {
            idb.AddParameter("@PCTH_CDriver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CDriver", pCT_HandOver.PCTH_CDriver);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CDcode))
         {
            idb.AddParameter("@PCTH_CDcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CDcode", pCT_HandOver.PCTH_CDcode);
         }
         if (pCT_HandOver.PCTH_JDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTH_JDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_JDate", pCT_HandOver.PCTH_JDate);
         }
         if (pCT_HandOver.PCTH_HDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTH_HDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_HDate", pCT_HandOver.PCTH_HDate);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CStatus))
         {
            idb.AddParameter("@PCTH_CStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CStatus", pCT_HandOver.PCTH_CStatus);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_IsCurrent))
         {
            idb.AddParameter("@PCTH_IsCurrent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_IsCurrent", pCT_HandOver.PCTH_IsCurrent);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Date))
         {
            idb.AddParameter("@PCTH_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Date", pCT_HandOver.PCTH_Date);
         }
         if (pCT_HandOver.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_HandOver.Stat);
         }
         if (pCT_HandOver.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_HandOver.CreateDate);
         }
         if (pCT_HandOver.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_HandOver.UpdateDate);
         }
         if (pCT_HandOver.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_HandOver.DeleteDate);
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
      /// 添加车辆交接班 PCT_HandOver对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCT_HandOver pCT_HandOver)
      {
         string sql = "INSERT INTO PCT_HandOver (PCTH_Code,PCTH_TCode,PCTH_TNo,PCTH_TName,PCTH_Type,PCTH_Key,PCTH_LDriver,PCTH_LDcode,PCTH_CDriver,PCTH_CDcode,PCTH_JDate,PCTH_HDate,PCTH_CStatus,PCTH_IsCurrent,PCTH_Date,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCTH_Code,@PCTH_TCode,@PCTH_TNo,@PCTH_TName,@PCTH_Type,@PCTH_Key,@PCTH_LDriver,@PCTH_LDcode,@PCTH_CDriver,@PCTH_CDcode,@PCTH_JDate,@PCTH_HDate,@PCTH_CStatus,@PCTH_IsCurrent,@PCTH_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Code))
         {
            idb.AddParameter("@PCTH_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Code", pCT_HandOver.PCTH_Code);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TCode))
         {
            idb.AddParameter("@PCTH_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TCode", pCT_HandOver.PCTH_TCode);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TNo))
         {
            idb.AddParameter("@PCTH_TNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TNo", pCT_HandOver.PCTH_TNo);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TName))
         {
            idb.AddParameter("@PCTH_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TName", pCT_HandOver.PCTH_TName);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Type))
         {
            idb.AddParameter("@PCTH_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Type", pCT_HandOver.PCTH_Type);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Key))
         {
            idb.AddParameter("@PCTH_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Key", pCT_HandOver.PCTH_Key);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_LDriver))
         {
            idb.AddParameter("@PCTH_LDriver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_LDriver", pCT_HandOver.PCTH_LDriver);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_LDcode))
         {
            idb.AddParameter("@PCTH_LDcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_LDcode", pCT_HandOver.PCTH_LDcode);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CDriver))
         {
            idb.AddParameter("@PCTH_CDriver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CDriver", pCT_HandOver.PCTH_CDriver);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CDcode))
         {
            idb.AddParameter("@PCTH_CDcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CDcode", pCT_HandOver.PCTH_CDcode);
         }
         if (pCT_HandOver.PCTH_JDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTH_JDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_JDate", pCT_HandOver.PCTH_JDate);
         }
         if (pCT_HandOver.PCTH_HDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTH_HDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_HDate", pCT_HandOver.PCTH_HDate);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CStatus))
         {
            idb.AddParameter("@PCTH_CStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CStatus", pCT_HandOver.PCTH_CStatus);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_IsCurrent))
         {
            idb.AddParameter("@PCTH_IsCurrent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_IsCurrent", pCT_HandOver.PCTH_IsCurrent);
         }
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Date))
         {
            idb.AddParameter("@PCTH_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Date", pCT_HandOver.PCTH_Date);
         }
         if (pCT_HandOver.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_HandOver.Stat);
         }
         if (pCT_HandOver.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_HandOver.CreateDate);
         }
         if (pCT_HandOver.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_HandOver.UpdateDate);
         }
         if (pCT_HandOver.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_HandOver.DeleteDate);
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
      /// 更新车辆交接班 PCT_HandOver对象(即:一条记录
      /// </summary>
      public int Update(PCT_HandOver pCT_HandOver)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCT_HandOver       SET ");
            if(pCT_HandOver.PCTH_Code_IsChanged){sbParameter.Append("PCTH_Code=@PCTH_Code, ");}
      if(pCT_HandOver.PCTH_TCode_IsChanged){sbParameter.Append("PCTH_TCode=@PCTH_TCode, ");}
      if(pCT_HandOver.PCTH_TNo_IsChanged){sbParameter.Append("PCTH_TNo=@PCTH_TNo, ");}
      if(pCT_HandOver.PCTH_TName_IsChanged){sbParameter.Append("PCTH_TName=@PCTH_TName, ");}
      if(pCT_HandOver.PCTH_Type_IsChanged){sbParameter.Append("PCTH_Type=@PCTH_Type, ");}
      if(pCT_HandOver.PCTH_Key_IsChanged){sbParameter.Append("PCTH_Key=@PCTH_Key, ");}
      if(pCT_HandOver.PCTH_LDriver_IsChanged){sbParameter.Append("PCTH_LDriver=@PCTH_LDriver, ");}
      if(pCT_HandOver.PCTH_LDcode_IsChanged){sbParameter.Append("PCTH_LDcode=@PCTH_LDcode, ");}
      if(pCT_HandOver.PCTH_CDriver_IsChanged){sbParameter.Append("PCTH_CDriver=@PCTH_CDriver, ");}
      if(pCT_HandOver.PCTH_CDcode_IsChanged){sbParameter.Append("PCTH_CDcode=@PCTH_CDcode, ");}
      if(pCT_HandOver.PCTH_JDate_IsChanged){sbParameter.Append("PCTH_JDate=@PCTH_JDate, ");}
      if(pCT_HandOver.PCTH_HDate_IsChanged){sbParameter.Append("PCTH_HDate=@PCTH_HDate, ");}
      if(pCT_HandOver.PCTH_CStatus_IsChanged){sbParameter.Append("PCTH_CStatus=@PCTH_CStatus, ");}
      if(pCT_HandOver.PCTH_IsCurrent_IsChanged){sbParameter.Append("PCTH_IsCurrent=@PCTH_IsCurrent, ");}
      if(pCT_HandOver.PCTH_Date_IsChanged){sbParameter.Append("PCTH_Date=@PCTH_Date, ");}
      if(pCT_HandOver.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCT_HandOver.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCT_HandOver.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCT_HandOver.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCTH_ID=@PCTH_ID; " );
      string sql=sb.ToString();
         if(pCT_HandOver.PCTH_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Code))
         {
            idb.AddParameter("@PCTH_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Code", pCT_HandOver.PCTH_Code);
         }
          }
         if(pCT_HandOver.PCTH_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TCode))
         {
            idb.AddParameter("@PCTH_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TCode", pCT_HandOver.PCTH_TCode);
         }
          }
         if(pCT_HandOver.PCTH_TNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TNo))
         {
            idb.AddParameter("@PCTH_TNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TNo", pCT_HandOver.PCTH_TNo);
         }
          }
         if(pCT_HandOver.PCTH_TName_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_TName))
         {
            idb.AddParameter("@PCTH_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_TName", pCT_HandOver.PCTH_TName);
         }
          }
         if(pCT_HandOver.PCTH_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Type))
         {
            idb.AddParameter("@PCTH_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Type", pCT_HandOver.PCTH_Type);
         }
          }
         if(pCT_HandOver.PCTH_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Key))
         {
            idb.AddParameter("@PCTH_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Key", pCT_HandOver.PCTH_Key);
         }
          }
         if(pCT_HandOver.PCTH_LDriver_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_LDriver))
         {
            idb.AddParameter("@PCTH_LDriver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_LDriver", pCT_HandOver.PCTH_LDriver);
         }
          }
         if(pCT_HandOver.PCTH_LDcode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_LDcode))
         {
            idb.AddParameter("@PCTH_LDcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_LDcode", pCT_HandOver.PCTH_LDcode);
         }
          }
         if(pCT_HandOver.PCTH_CDriver_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CDriver))
         {
            idb.AddParameter("@PCTH_CDriver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CDriver", pCT_HandOver.PCTH_CDriver);
         }
          }
         if(pCT_HandOver.PCTH_CDcode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CDcode))
         {
            idb.AddParameter("@PCTH_CDcode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CDcode", pCT_HandOver.PCTH_CDcode);
         }
          }
         if(pCT_HandOver.PCTH_JDate_IsChanged)
         {
         if (pCT_HandOver.PCTH_JDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTH_JDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_JDate", pCT_HandOver.PCTH_JDate);
         }
          }
         if(pCT_HandOver.PCTH_HDate_IsChanged)
         {
         if (pCT_HandOver.PCTH_HDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTH_HDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_HDate", pCT_HandOver.PCTH_HDate);
         }
          }
         if(pCT_HandOver.PCTH_CStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_CStatus))
         {
            idb.AddParameter("@PCTH_CStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_CStatus", pCT_HandOver.PCTH_CStatus);
         }
          }
         if(pCT_HandOver.PCTH_IsCurrent_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_IsCurrent))
         {
            idb.AddParameter("@PCTH_IsCurrent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_IsCurrent", pCT_HandOver.PCTH_IsCurrent);
         }
          }
         if(pCT_HandOver.PCTH_Date_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_HandOver.PCTH_Date))
         {
            idb.AddParameter("@PCTH_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTH_Date", pCT_HandOver.PCTH_Date);
         }
          }
         if(pCT_HandOver.Stat_IsChanged)
         {
         if (pCT_HandOver.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_HandOver.Stat);
         }
          }
         if(pCT_HandOver.CreateDate_IsChanged)
         {
         if (pCT_HandOver.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_HandOver.CreateDate);
         }
          }
         if(pCT_HandOver.UpdateDate_IsChanged)
         {
         if (pCT_HandOver.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_HandOver.UpdateDate);
         }
          }
         if(pCT_HandOver.DeleteDate_IsChanged)
         {
         if (pCT_HandOver.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_HandOver.DeleteDate);
         }
          }

         idb.AddParameter("@PCTH_ID", pCT_HandOver.PCTH_ID);

           
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
      /// 删除车辆交接班 PCT_HandOver对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCTH_ID)
      {
         string sql = "DELETE PCT_HandOver WHERE 1=1  AND PCTH_ID=@PCTH_ID ";
         idb.AddParameter("@PCTH_ID", pCTH_ID);

           
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
      /// 获取指定的车辆交接班 PCT_HandOver对象(即:一条记录
      /// </summary>
      public PCT_HandOver GetByKey(decimal pCTH_ID)
      {
         PCT_HandOver pCT_HandOver = new PCT_HandOver();
         string sql = "SELECT  PCTH_ID,PCTH_Code,PCTH_TCode,PCTH_TNo,PCTH_TName,PCTH_Type,PCTH_Key,PCTH_LDriver,PCTH_LDcode,PCTH_CDriver,PCTH_CDcode,PCTH_JDate,PCTH_HDate,PCTH_CStatus,PCTH_IsCurrent,PCTH_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM PCT_HandOver WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCTH_ID=@PCTH_ID ";
         idb.AddParameter("@PCTH_ID", pCTH_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCTH_ID"] != DBNull.Value) pCT_HandOver.PCTH_ID = Convert.ToDecimal(dr["PCTH_ID"]);
            if (dr["PCTH_Code"] != DBNull.Value) pCT_HandOver.PCTH_Code = Convert.ToString(dr["PCTH_Code"]);
            if (dr["PCTH_TCode"] != DBNull.Value) pCT_HandOver.PCTH_TCode = Convert.ToString(dr["PCTH_TCode"]);
            if (dr["PCTH_TNo"] != DBNull.Value) pCT_HandOver.PCTH_TNo = Convert.ToString(dr["PCTH_TNo"]);
            if (dr["PCTH_TName"] != DBNull.Value) pCT_HandOver.PCTH_TName = Convert.ToString(dr["PCTH_TName"]);
            if (dr["PCTH_Type"] != DBNull.Value) pCT_HandOver.PCTH_Type = Convert.ToString(dr["PCTH_Type"]);
            if (dr["PCTH_Key"] != DBNull.Value) pCT_HandOver.PCTH_Key = Convert.ToString(dr["PCTH_Key"]);
            if (dr["PCTH_LDriver"] != DBNull.Value) pCT_HandOver.PCTH_LDriver = Convert.ToString(dr["PCTH_LDriver"]);
            if (dr["PCTH_LDcode"] != DBNull.Value) pCT_HandOver.PCTH_LDcode = Convert.ToString(dr["PCTH_LDcode"]);
            if (dr["PCTH_CDriver"] != DBNull.Value) pCT_HandOver.PCTH_CDriver = Convert.ToString(dr["PCTH_CDriver"]);
            if (dr["PCTH_CDcode"] != DBNull.Value) pCT_HandOver.PCTH_CDcode = Convert.ToString(dr["PCTH_CDcode"]);
            if (dr["PCTH_JDate"] != DBNull.Value) pCT_HandOver.PCTH_JDate = Convert.ToDateTime(dr["PCTH_JDate"]);
            if (dr["PCTH_HDate"] != DBNull.Value) pCT_HandOver.PCTH_HDate = Convert.ToDateTime(dr["PCTH_HDate"]);
            if (dr["PCTH_CStatus"] != DBNull.Value) pCT_HandOver.PCTH_CStatus = Convert.ToString(dr["PCTH_CStatus"]);
            if (dr["PCTH_IsCurrent"] != DBNull.Value) pCT_HandOver.PCTH_IsCurrent = Convert.ToString(dr["PCTH_IsCurrent"]);
            if (dr["PCTH_Date"] != DBNull.Value) pCT_HandOver.PCTH_Date = Convert.ToString(dr["PCTH_Date"]);
            if (dr["Stat"] != DBNull.Value) pCT_HandOver.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_HandOver.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_HandOver.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_HandOver.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCT_HandOver;
      }
      /// <summary>
      /// 获取指定的车辆交接班 PCT_HandOver对象集合
      /// </summary>
      public List<PCT_HandOver> GetListByWhere(string strCondition)
      {
         List<PCT_HandOver> ret = new List<PCT_HandOver>();
         string sql = "SELECT  PCTH_ID,PCTH_Code,PCTH_TCode,PCTH_TNo,PCTH_TName,PCTH_Type,PCTH_Key,PCTH_LDriver,PCTH_LDcode,PCTH_CDriver,PCTH_CDcode,PCTH_JDate,PCTH_HDate,PCTH_CStatus,PCTH_IsCurrent,PCTH_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM PCT_HandOver WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCT_HandOver pCT_HandOver = new PCT_HandOver();
            if (dr["PCTH_ID"] != DBNull.Value) pCT_HandOver.PCTH_ID = Convert.ToDecimal(dr["PCTH_ID"]);
            if (dr["PCTH_Code"] != DBNull.Value) pCT_HandOver.PCTH_Code = Convert.ToString(dr["PCTH_Code"]);
            if (dr["PCTH_TCode"] != DBNull.Value) pCT_HandOver.PCTH_TCode = Convert.ToString(dr["PCTH_TCode"]);
            if (dr["PCTH_TNo"] != DBNull.Value) pCT_HandOver.PCTH_TNo = Convert.ToString(dr["PCTH_TNo"]);
            if (dr["PCTH_TName"] != DBNull.Value) pCT_HandOver.PCTH_TName = Convert.ToString(dr["PCTH_TName"]);
            if (dr["PCTH_Type"] != DBNull.Value) pCT_HandOver.PCTH_Type = Convert.ToString(dr["PCTH_Type"]);
            if (dr["PCTH_Key"] != DBNull.Value) pCT_HandOver.PCTH_Key = Convert.ToString(dr["PCTH_Key"]);
            if (dr["PCTH_LDriver"] != DBNull.Value) pCT_HandOver.PCTH_LDriver = Convert.ToString(dr["PCTH_LDriver"]);
            if (dr["PCTH_LDcode"] != DBNull.Value) pCT_HandOver.PCTH_LDcode = Convert.ToString(dr["PCTH_LDcode"]);
            if (dr["PCTH_CDriver"] != DBNull.Value) pCT_HandOver.PCTH_CDriver = Convert.ToString(dr["PCTH_CDriver"]);
            if (dr["PCTH_CDcode"] != DBNull.Value) pCT_HandOver.PCTH_CDcode = Convert.ToString(dr["PCTH_CDcode"]);
            if (dr["PCTH_JDate"] != DBNull.Value) pCT_HandOver.PCTH_JDate = Convert.ToDateTime(dr["PCTH_JDate"]);
            if (dr["PCTH_HDate"] != DBNull.Value) pCT_HandOver.PCTH_HDate = Convert.ToDateTime(dr["PCTH_HDate"]);
            if (dr["PCTH_CStatus"] != DBNull.Value) pCT_HandOver.PCTH_CStatus = Convert.ToString(dr["PCTH_CStatus"]);
            if (dr["PCTH_IsCurrent"] != DBNull.Value) pCT_HandOver.PCTH_IsCurrent = Convert.ToString(dr["PCTH_IsCurrent"]);
            if (dr["PCTH_Date"] != DBNull.Value) pCT_HandOver.PCTH_Date = Convert.ToString(dr["PCTH_Date"]);
            if (dr["Stat"] != DBNull.Value) pCT_HandOver.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_HandOver.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_HandOver.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_HandOver.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCT_HandOver);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆交接班 PCT_HandOver对象(即:一条记录
      /// </summary>
      public List<PCT_HandOver> GetAll()
      {
         List<PCT_HandOver> ret = new List<PCT_HandOver>();
         string sql = "SELECT  PCTH_ID,PCTH_Code,PCTH_TCode,PCTH_TNo,PCTH_TName,PCTH_Type,PCTH_Key,PCTH_LDriver,PCTH_LDcode,PCTH_CDriver,PCTH_CDcode,PCTH_JDate,PCTH_HDate,PCTH_CStatus,PCTH_IsCurrent,PCTH_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM PCT_HandOver where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCTH_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCT_HandOver pCT_HandOver = new PCT_HandOver();
            if (dr["PCTH_ID"] != DBNull.Value) pCT_HandOver.PCTH_ID = Convert.ToDecimal(dr["PCTH_ID"]);
            if (dr["PCTH_Code"] != DBNull.Value) pCT_HandOver.PCTH_Code = Convert.ToString(dr["PCTH_Code"]);
            if (dr["PCTH_TCode"] != DBNull.Value) pCT_HandOver.PCTH_TCode = Convert.ToString(dr["PCTH_TCode"]);
            if (dr["PCTH_TNo"] != DBNull.Value) pCT_HandOver.PCTH_TNo = Convert.ToString(dr["PCTH_TNo"]);
            if (dr["PCTH_TName"] != DBNull.Value) pCT_HandOver.PCTH_TName = Convert.ToString(dr["PCTH_TName"]);
            if (dr["PCTH_Type"] != DBNull.Value) pCT_HandOver.PCTH_Type = Convert.ToString(dr["PCTH_Type"]);
            if (dr["PCTH_Key"] != DBNull.Value) pCT_HandOver.PCTH_Key = Convert.ToString(dr["PCTH_Key"]);
            if (dr["PCTH_LDriver"] != DBNull.Value) pCT_HandOver.PCTH_LDriver = Convert.ToString(dr["PCTH_LDriver"]);
            if (dr["PCTH_LDcode"] != DBNull.Value) pCT_HandOver.PCTH_LDcode = Convert.ToString(dr["PCTH_LDcode"]);
            if (dr["PCTH_CDriver"] != DBNull.Value) pCT_HandOver.PCTH_CDriver = Convert.ToString(dr["PCTH_CDriver"]);
            if (dr["PCTH_CDcode"] != DBNull.Value) pCT_HandOver.PCTH_CDcode = Convert.ToString(dr["PCTH_CDcode"]);
            if (dr["PCTH_JDate"] != DBNull.Value) pCT_HandOver.PCTH_JDate = Convert.ToDateTime(dr["PCTH_JDate"]);
            if (dr["PCTH_HDate"] != DBNull.Value) pCT_HandOver.PCTH_HDate = Convert.ToDateTime(dr["PCTH_HDate"]);
            if (dr["PCTH_CStatus"] != DBNull.Value) pCT_HandOver.PCTH_CStatus = Convert.ToString(dr["PCTH_CStatus"]);
            if (dr["PCTH_IsCurrent"] != DBNull.Value) pCT_HandOver.PCTH_IsCurrent = Convert.ToString(dr["PCTH_IsCurrent"]);
            if (dr["PCTH_Date"] != DBNull.Value) pCT_HandOver.PCTH_Date = Convert.ToString(dr["PCTH_Date"]);
            if (dr["Stat"] != DBNull.Value) pCT_HandOver.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_HandOver.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_HandOver.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_HandOver.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCT_HandOver);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
