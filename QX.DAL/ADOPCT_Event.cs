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
   /// 车辆事件表
   /// </summary>
   [Serializable]
   public partial class ADOPCT_Event
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加车辆事件表 PCT_Event对象(即:一条记录)
      /// </summary>
      public int Add(PCT_Event pCT_Event)
      {
         string sql = "INSERT INTO PCT_Event (PCTE_Code,PCTE_CCode,PCTE_CNo,PCTE_Description,PCTE_BeginDate,PCTE_EndDate,PCTE_EventType,PCTE_DCode,PCTE_Join,PCTE_Cost,PCTE_Before,PCTE_After,PCTE_Address,Stat,CreateDate,UpdateDate,DeleteDate,PCTE_iType,PCTE_TCode,PCTE_Udef2,PCTE_Udef3,PCTE_Udef4,PCTE_Udef5) VALUES (@PCTE_Code,@PCTE_CCode,@PCTE_CNo,@PCTE_Description,@PCTE_BeginDate,@PCTE_EndDate,@PCTE_EventType,@PCTE_DCode,@PCTE_Join,@PCTE_Cost,@PCTE_Before,@PCTE_After,@PCTE_Address,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTE_iType,@PCTE_TCode,@PCTE_Udef2,@PCTE_Udef3,@PCTE_Udef4,@PCTE_Udef5)";
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Code))
         {
            idb.AddParameter("@PCTE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Code", pCT_Event.PCTE_Code);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_CCode))
         {
            idb.AddParameter("@PCTE_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_CCode", pCT_Event.PCTE_CCode);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_CNo))
         {
            idb.AddParameter("@PCTE_CNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_CNo", pCT_Event.PCTE_CNo);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Description))
         {
            idb.AddParameter("@PCTE_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Description", pCT_Event.PCTE_Description);
         }
         if (pCT_Event.PCTE_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTE_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_BeginDate", pCT_Event.PCTE_BeginDate);
         }
         if (pCT_Event.PCTE_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTE_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_EndDate", pCT_Event.PCTE_EndDate);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_EventType))
         {
            idb.AddParameter("@PCTE_EventType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_EventType", pCT_Event.PCTE_EventType);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_DCode))
         {
            idb.AddParameter("@PCTE_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_DCode", pCT_Event.PCTE_DCode);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Join))
         {
            idb.AddParameter("@PCTE_Join", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Join", pCT_Event.PCTE_Join);
         }
         if (pCT_Event.PCTE_Cost == 0)
         {
            idb.AddParameter("@PCTE_Cost", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_Cost", pCT_Event.PCTE_Cost);
         }
         if (pCT_Event.PCTE_Before == 0)
         {
            idb.AddParameter("@PCTE_Before", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_Before", pCT_Event.PCTE_Before);
         }
         if (pCT_Event.PCTE_After == 0)
         {
            idb.AddParameter("@PCTE_After", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_After", pCT_Event.PCTE_After);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Address))
         {
            idb.AddParameter("@PCTE_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Address", pCT_Event.PCTE_Address);
         }
         if (pCT_Event.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Event.Stat);
         }
         if (pCT_Event.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Event.CreateDate);
         }
         if (pCT_Event.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Event.UpdateDate);
         }
         if (pCT_Event.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Event.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_iType))
         {
            idb.AddParameter("@PCTE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_iType", pCT_Event.PCTE_iType);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_TCode))
         {
            idb.AddParameter("@PCTE_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_TCode", pCT_Event.PCTE_TCode);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef2))
         {
            idb.AddParameter("@PCTE_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef2", pCT_Event.PCTE_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef3))
         {
            idb.AddParameter("@PCTE_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef3", pCT_Event.PCTE_Udef3);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef4))
         {
            idb.AddParameter("@PCTE_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef4", pCT_Event.PCTE_Udef4);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef5))
         {
            idb.AddParameter("@PCTE_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef5", pCT_Event.PCTE_Udef5);
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
      /// 添加车辆事件表 PCT_Event对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCT_Event pCT_Event)
      {
         string sql = "INSERT INTO PCT_Event (PCTE_Code,PCTE_CCode,PCTE_CNo,PCTE_Description,PCTE_BeginDate,PCTE_EndDate,PCTE_EventType,PCTE_DCode,PCTE_Join,PCTE_Cost,PCTE_Before,PCTE_After,PCTE_Address,Stat,CreateDate,UpdateDate,DeleteDate,PCTE_iType,PCTE_TCode,PCTE_Udef2,PCTE_Udef3,PCTE_Udef4,PCTE_Udef5) VALUES (@PCTE_Code,@PCTE_CCode,@PCTE_CNo,@PCTE_Description,@PCTE_BeginDate,@PCTE_EndDate,@PCTE_EventType,@PCTE_DCode,@PCTE_Join,@PCTE_Cost,@PCTE_Before,@PCTE_After,@PCTE_Address,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTE_iType,@PCTE_TCode,@PCTE_Udef2,@PCTE_Udef3,@PCTE_Udef4,@PCTE_Udef5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Code))
         {
            idb.AddParameter("@PCTE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Code", pCT_Event.PCTE_Code);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_CCode))
         {
            idb.AddParameter("@PCTE_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_CCode", pCT_Event.PCTE_CCode);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_CNo))
         {
            idb.AddParameter("@PCTE_CNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_CNo", pCT_Event.PCTE_CNo);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Description))
         {
            idb.AddParameter("@PCTE_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Description", pCT_Event.PCTE_Description);
         }
         if (pCT_Event.PCTE_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTE_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_BeginDate", pCT_Event.PCTE_BeginDate);
         }
         if (pCT_Event.PCTE_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTE_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_EndDate", pCT_Event.PCTE_EndDate);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_EventType))
         {
            idb.AddParameter("@PCTE_EventType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_EventType", pCT_Event.PCTE_EventType);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_DCode))
         {
            idb.AddParameter("@PCTE_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_DCode", pCT_Event.PCTE_DCode);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Join))
         {
            idb.AddParameter("@PCTE_Join", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Join", pCT_Event.PCTE_Join);
         }
         if (pCT_Event.PCTE_Cost == 0)
         {
            idb.AddParameter("@PCTE_Cost", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_Cost", pCT_Event.PCTE_Cost);
         }
         if (pCT_Event.PCTE_Before == 0)
         {
            idb.AddParameter("@PCTE_Before", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_Before", pCT_Event.PCTE_Before);
         }
         if (pCT_Event.PCTE_After == 0)
         {
            idb.AddParameter("@PCTE_After", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_After", pCT_Event.PCTE_After);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Address))
         {
            idb.AddParameter("@PCTE_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Address", pCT_Event.PCTE_Address);
         }
         if (pCT_Event.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Event.Stat);
         }
         if (pCT_Event.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Event.CreateDate);
         }
         if (pCT_Event.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Event.UpdateDate);
         }
         if (pCT_Event.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Event.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_iType))
         {
            idb.AddParameter("@PCTE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_iType", pCT_Event.PCTE_iType);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_TCode))
         {
            idb.AddParameter("@PCTE_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_TCode", pCT_Event.PCTE_TCode);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef2))
         {
            idb.AddParameter("@PCTE_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef2", pCT_Event.PCTE_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef3))
         {
            idb.AddParameter("@PCTE_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef3", pCT_Event.PCTE_Udef3);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef4))
         {
            idb.AddParameter("@PCTE_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef4", pCT_Event.PCTE_Udef4);
         }
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef5))
         {
            idb.AddParameter("@PCTE_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef5", pCT_Event.PCTE_Udef5);
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
      /// 更新车辆事件表 PCT_Event对象(即:一条记录
      /// </summary>
      public int Update(PCT_Event pCT_Event)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCT_Event       SET ");
            if(pCT_Event.PCTE_Code_IsChanged){sbParameter.Append("PCTE_Code=@PCTE_Code, ");}
      if(pCT_Event.PCTE_CCode_IsChanged){sbParameter.Append("PCTE_CCode=@PCTE_CCode, ");}
      if(pCT_Event.PCTE_CNo_IsChanged){sbParameter.Append("PCTE_CNo=@PCTE_CNo, ");}
      if(pCT_Event.PCTE_Description_IsChanged){sbParameter.Append("PCTE_Description=@PCTE_Description, ");}
      if(pCT_Event.PCTE_BeginDate_IsChanged){sbParameter.Append("PCTE_BeginDate=@PCTE_BeginDate, ");}
      if(pCT_Event.PCTE_EndDate_IsChanged){sbParameter.Append("PCTE_EndDate=@PCTE_EndDate, ");}
      if(pCT_Event.PCTE_EventType_IsChanged){sbParameter.Append("PCTE_EventType=@PCTE_EventType, ");}
      if(pCT_Event.PCTE_DCode_IsChanged){sbParameter.Append("PCTE_DCode=@PCTE_DCode, ");}
      if(pCT_Event.PCTE_Join_IsChanged){sbParameter.Append("PCTE_Join=@PCTE_Join, ");}
      if(pCT_Event.PCTE_Cost_IsChanged){sbParameter.Append("PCTE_Cost=@PCTE_Cost, ");}
      if(pCT_Event.PCTE_Before_IsChanged){sbParameter.Append("PCTE_Before=@PCTE_Before, ");}
      if(pCT_Event.PCTE_After_IsChanged){sbParameter.Append("PCTE_After=@PCTE_After, ");}
      if(pCT_Event.PCTE_Address_IsChanged){sbParameter.Append("PCTE_Address=@PCTE_Address, ");}
      if(pCT_Event.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCT_Event.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCT_Event.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCT_Event.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pCT_Event.PCTE_iType_IsChanged){sbParameter.Append("PCTE_iType=@PCTE_iType, ");}
      if(pCT_Event.PCTE_TCode_IsChanged){sbParameter.Append("PCTE_TCode=@PCTE_TCode, ");}
      if(pCT_Event.PCTE_Udef2_IsChanged){sbParameter.Append("PCTE_Udef2=@PCTE_Udef2, ");}
      if(pCT_Event.PCTE_Udef3_IsChanged){sbParameter.Append("PCTE_Udef3=@PCTE_Udef3, ");}
      if(pCT_Event.PCTE_Udef4_IsChanged){sbParameter.Append("PCTE_Udef4=@PCTE_Udef4, ");}
      if(pCT_Event.PCTE_Udef5_IsChanged){sbParameter.Append("PCTE_Udef5=@PCTE_Udef5 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCTE_ID=@PCTE_ID; " );
      string sql=sb.ToString();
         if(pCT_Event.PCTE_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Code))
         {
            idb.AddParameter("@PCTE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Code", pCT_Event.PCTE_Code);
         }
          }
         if(pCT_Event.PCTE_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_CCode))
         {
            idb.AddParameter("@PCTE_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_CCode", pCT_Event.PCTE_CCode);
         }
          }
         if(pCT_Event.PCTE_CNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_CNo))
         {
            idb.AddParameter("@PCTE_CNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_CNo", pCT_Event.PCTE_CNo);
         }
          }
         if(pCT_Event.PCTE_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Description))
         {
            idb.AddParameter("@PCTE_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Description", pCT_Event.PCTE_Description);
         }
          }
         if(pCT_Event.PCTE_BeginDate_IsChanged)
         {
         if (pCT_Event.PCTE_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTE_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_BeginDate", pCT_Event.PCTE_BeginDate);
         }
          }
         if(pCT_Event.PCTE_EndDate_IsChanged)
         {
         if (pCT_Event.PCTE_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTE_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_EndDate", pCT_Event.PCTE_EndDate);
         }
          }
         if(pCT_Event.PCTE_EventType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_EventType))
         {
            idb.AddParameter("@PCTE_EventType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_EventType", pCT_Event.PCTE_EventType);
         }
          }
         if(pCT_Event.PCTE_DCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_DCode))
         {
            idb.AddParameter("@PCTE_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_DCode", pCT_Event.PCTE_DCode);
         }
          }
         if(pCT_Event.PCTE_Join_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Join))
         {
            idb.AddParameter("@PCTE_Join", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Join", pCT_Event.PCTE_Join);
         }
          }
         if(pCT_Event.PCTE_Cost_IsChanged)
         {
         if (pCT_Event.PCTE_Cost == 0)
         {
            idb.AddParameter("@PCTE_Cost", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_Cost", pCT_Event.PCTE_Cost);
         }
          }
         if(pCT_Event.PCTE_Before_IsChanged)
         {
         if (pCT_Event.PCTE_Before == 0)
         {
            idb.AddParameter("@PCTE_Before", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_Before", pCT_Event.PCTE_Before);
         }
          }
         if(pCT_Event.PCTE_After_IsChanged)
         {
         if (pCT_Event.PCTE_After == 0)
         {
            idb.AddParameter("@PCTE_After", 0);
         }
         else
         {
            idb.AddParameter("@PCTE_After", pCT_Event.PCTE_After);
         }
          }
         if(pCT_Event.PCTE_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Address))
         {
            idb.AddParameter("@PCTE_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Address", pCT_Event.PCTE_Address);
         }
          }
         if(pCT_Event.Stat_IsChanged)
         {
         if (pCT_Event.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Event.Stat);
         }
          }
         if(pCT_Event.CreateDate_IsChanged)
         {
         if (pCT_Event.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Event.CreateDate);
         }
          }
         if(pCT_Event.UpdateDate_IsChanged)
         {
         if (pCT_Event.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Event.UpdateDate);
         }
          }
         if(pCT_Event.DeleteDate_IsChanged)
         {
         if (pCT_Event.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Event.DeleteDate);
         }
          }
         if(pCT_Event.PCTE_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_iType))
         {
            idb.AddParameter("@PCTE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_iType", pCT_Event.PCTE_iType);
         }
          }
         if(pCT_Event.PCTE_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_TCode))
         {
            idb.AddParameter("@PCTE_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_TCode", pCT_Event.PCTE_TCode);
         }
          }
         if(pCT_Event.PCTE_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef2))
         {
            idb.AddParameter("@PCTE_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef2", pCT_Event.PCTE_Udef2);
         }
          }
         if(pCT_Event.PCTE_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef3))
         {
            idb.AddParameter("@PCTE_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef3", pCT_Event.PCTE_Udef3);
         }
          }
         if(pCT_Event.PCTE_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef4))
         {
            idb.AddParameter("@PCTE_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef4", pCT_Event.PCTE_Udef4);
         }
          }
         if(pCT_Event.PCTE_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Event.PCTE_Udef5))
         {
            idb.AddParameter("@PCTE_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTE_Udef5", pCT_Event.PCTE_Udef5);
         }
          }

         idb.AddParameter("@PCTE_ID", pCT_Event.PCTE_ID);

           
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
      /// 删除车辆事件表 PCT_Event对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCTE_ID)
      {
         string sql = "DELETE PCT_Event WHERE 1=1  AND PCTE_ID=@PCTE_ID ";
         idb.AddParameter("@PCTE_ID", pCTE_ID);

           
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
      /// 获取指定的车辆事件表 PCT_Event对象(即:一条记录
      /// </summary>
      public PCT_Event GetByKey(decimal pCTE_ID)
      {
         PCT_Event pCT_Event = new PCT_Event();
         string sql = "SELECT  PCTE_ID,PCTE_Code,PCTE_CCode,PCTE_CNo,PCTE_Description,PCTE_BeginDate,PCTE_EndDate,PCTE_EventType,PCTE_DCode,PCTE_Join,PCTE_Cost,PCTE_Before,PCTE_After,PCTE_Address,Stat,CreateDate,UpdateDate,DeleteDate,PCTE_iType,PCTE_TCode,PCTE_Udef2,PCTE_Udef3,PCTE_Udef4,PCTE_Udef5 FROM PCT_Event WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCTE_ID=@PCTE_ID ";
         idb.AddParameter("@PCTE_ID", pCTE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCTE_ID"] != DBNull.Value) pCT_Event.PCTE_ID = Convert.ToDecimal(dr["PCTE_ID"]);
            if (dr["PCTE_Code"] != DBNull.Value) pCT_Event.PCTE_Code = Convert.ToString(dr["PCTE_Code"]);
            if (dr["PCTE_CCode"] != DBNull.Value) pCT_Event.PCTE_CCode = Convert.ToString(dr["PCTE_CCode"]);
            if (dr["PCTE_CNo"] != DBNull.Value) pCT_Event.PCTE_CNo = Convert.ToString(dr["PCTE_CNo"]);
            if (dr["PCTE_Description"] != DBNull.Value) pCT_Event.PCTE_Description = Convert.ToString(dr["PCTE_Description"]);
            if (dr["PCTE_BeginDate"] != DBNull.Value) pCT_Event.PCTE_BeginDate = Convert.ToDateTime(dr["PCTE_BeginDate"]);
            if (dr["PCTE_EndDate"] != DBNull.Value) pCT_Event.PCTE_EndDate = Convert.ToDateTime(dr["PCTE_EndDate"]);
            if (dr["PCTE_EventType"] != DBNull.Value) pCT_Event.PCTE_EventType = Convert.ToString(dr["PCTE_EventType"]);
            if (dr["PCTE_DCode"] != DBNull.Value) pCT_Event.PCTE_DCode = Convert.ToString(dr["PCTE_DCode"]);
            if (dr["PCTE_Join"] != DBNull.Value) pCT_Event.PCTE_Join = Convert.ToString(dr["PCTE_Join"]);
            if (dr["PCTE_Cost"] != DBNull.Value) pCT_Event.PCTE_Cost = Convert.ToDecimal(dr["PCTE_Cost"]);
            if (dr["PCTE_Before"] != DBNull.Value) pCT_Event.PCTE_Before = Convert.ToSingle(dr["PCTE_Before"]);
            if (dr["PCTE_After"] != DBNull.Value) pCT_Event.PCTE_After = Convert.ToSingle(dr["PCTE_After"]);
            if (dr["PCTE_Address"] != DBNull.Value) pCT_Event.PCTE_Address = Convert.ToString(dr["PCTE_Address"]);
            if (dr["Stat"] != DBNull.Value) pCT_Event.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Event.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Event.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Event.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTE_iType"] != DBNull.Value) pCT_Event.PCTE_iType = Convert.ToString(dr["PCTE_iType"]);
            if (dr["PCTE_TCode"] != DBNull.Value) pCT_Event.PCTE_TCode = Convert.ToString(dr["PCTE_TCode"]);
            if (dr["PCTE_Udef2"] != DBNull.Value) pCT_Event.PCTE_Udef2 = Convert.ToString(dr["PCTE_Udef2"]);
            if (dr["PCTE_Udef3"] != DBNull.Value) pCT_Event.PCTE_Udef3 = Convert.ToString(dr["PCTE_Udef3"]);
            if (dr["PCTE_Udef4"] != DBNull.Value) pCT_Event.PCTE_Udef4 = Convert.ToString(dr["PCTE_Udef4"]);
            if (dr["PCTE_Udef5"] != DBNull.Value) pCT_Event.PCTE_Udef5 = Convert.ToString(dr["PCTE_Udef5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCT_Event;
      }
      /// <summary>
      /// 获取指定的车辆事件表 PCT_Event对象集合
      /// </summary>
      public List<PCT_Event> GetListByWhere(string strCondition)
      {
         List<PCT_Event> ret = new List<PCT_Event>();
         string sql = "SELECT  PCTE_ID,PCTE_Code,PCTE_CCode,PCTE_CNo,PCTE_Description,PCTE_BeginDate,PCTE_EndDate,PCTE_EventType,PCTE_DCode,PCTE_Join,PCTE_Cost,PCTE_Before,PCTE_After,PCTE_Address,Stat,CreateDate,UpdateDate,DeleteDate,PCTE_iType,PCTE_TCode,PCTE_Udef2,PCTE_Udef3,PCTE_Udef4,PCTE_Udef5 FROM PCT_Event WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCT_Event pCT_Event = new PCT_Event();
            if (dr["PCTE_ID"] != DBNull.Value) pCT_Event.PCTE_ID = Convert.ToDecimal(dr["PCTE_ID"]);
            if (dr["PCTE_Code"] != DBNull.Value) pCT_Event.PCTE_Code = Convert.ToString(dr["PCTE_Code"]);
            if (dr["PCTE_CCode"] != DBNull.Value) pCT_Event.PCTE_CCode = Convert.ToString(dr["PCTE_CCode"]);
            if (dr["PCTE_CNo"] != DBNull.Value) pCT_Event.PCTE_CNo = Convert.ToString(dr["PCTE_CNo"]);
            if (dr["PCTE_Description"] != DBNull.Value) pCT_Event.PCTE_Description = Convert.ToString(dr["PCTE_Description"]);
            if (dr["PCTE_BeginDate"] != DBNull.Value) pCT_Event.PCTE_BeginDate = Convert.ToDateTime(dr["PCTE_BeginDate"]);
            if (dr["PCTE_EndDate"] != DBNull.Value) pCT_Event.PCTE_EndDate = Convert.ToDateTime(dr["PCTE_EndDate"]);
            if (dr["PCTE_EventType"] != DBNull.Value) pCT_Event.PCTE_EventType = Convert.ToString(dr["PCTE_EventType"]);
            if (dr["PCTE_DCode"] != DBNull.Value) pCT_Event.PCTE_DCode = Convert.ToString(dr["PCTE_DCode"]);
            if (dr["PCTE_Join"] != DBNull.Value) pCT_Event.PCTE_Join = Convert.ToString(dr["PCTE_Join"]);
            if (dr["PCTE_Cost"] != DBNull.Value) pCT_Event.PCTE_Cost = Convert.ToDecimal(dr["PCTE_Cost"]);
            if (dr["PCTE_Before"] != DBNull.Value) pCT_Event.PCTE_Before = Convert.ToSingle(dr["PCTE_Before"]);
            if (dr["PCTE_After"] != DBNull.Value) pCT_Event.PCTE_After = Convert.ToSingle(dr["PCTE_After"]);
            if (dr["PCTE_Address"] != DBNull.Value) pCT_Event.PCTE_Address = Convert.ToString(dr["PCTE_Address"]);
            if (dr["Stat"] != DBNull.Value) pCT_Event.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Event.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Event.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Event.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTE_iType"] != DBNull.Value) pCT_Event.PCTE_iType = Convert.ToString(dr["PCTE_iType"]);
            if (dr["PCTE_TCode"] != DBNull.Value) pCT_Event.PCTE_TCode = Convert.ToString(dr["PCTE_TCode"]);
            if (dr["PCTE_Udef2"] != DBNull.Value) pCT_Event.PCTE_Udef2 = Convert.ToString(dr["PCTE_Udef2"]);
            if (dr["PCTE_Udef3"] != DBNull.Value) pCT_Event.PCTE_Udef3 = Convert.ToString(dr["PCTE_Udef3"]);
            if (dr["PCTE_Udef4"] != DBNull.Value) pCT_Event.PCTE_Udef4 = Convert.ToString(dr["PCTE_Udef4"]);
            if (dr["PCTE_Udef5"] != DBNull.Value) pCT_Event.PCTE_Udef5 = Convert.ToString(dr["PCTE_Udef5"]);
            ret.Add(pCT_Event);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆事件表 PCT_Event对象(即:一条记录
      /// </summary>
      public List<PCT_Event> GetAll()
      {
         List<PCT_Event> ret = new List<PCT_Event>();
         string sql = "SELECT  PCTE_ID,PCTE_Code,PCTE_CCode,PCTE_CNo,PCTE_Description,PCTE_BeginDate,PCTE_EndDate,PCTE_EventType,PCTE_DCode,PCTE_Join,PCTE_Cost,PCTE_Before,PCTE_After,PCTE_Address,Stat,CreateDate,UpdateDate,DeleteDate,PCTE_iType,PCTE_TCode,PCTE_Udef2,PCTE_Udef3,PCTE_Udef4,PCTE_Udef5 FROM PCT_Event where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCTE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCT_Event pCT_Event = new PCT_Event();
            if (dr["PCTE_ID"] != DBNull.Value) pCT_Event.PCTE_ID = Convert.ToDecimal(dr["PCTE_ID"]);
            if (dr["PCTE_Code"] != DBNull.Value) pCT_Event.PCTE_Code = Convert.ToString(dr["PCTE_Code"]);
            if (dr["PCTE_CCode"] != DBNull.Value) pCT_Event.PCTE_CCode = Convert.ToString(dr["PCTE_CCode"]);
            if (dr["PCTE_CNo"] != DBNull.Value) pCT_Event.PCTE_CNo = Convert.ToString(dr["PCTE_CNo"]);
            if (dr["PCTE_Description"] != DBNull.Value) pCT_Event.PCTE_Description = Convert.ToString(dr["PCTE_Description"]);
            if (dr["PCTE_BeginDate"] != DBNull.Value) pCT_Event.PCTE_BeginDate = Convert.ToDateTime(dr["PCTE_BeginDate"]);
            if (dr["PCTE_EndDate"] != DBNull.Value) pCT_Event.PCTE_EndDate = Convert.ToDateTime(dr["PCTE_EndDate"]);
            if (dr["PCTE_EventType"] != DBNull.Value) pCT_Event.PCTE_EventType = Convert.ToString(dr["PCTE_EventType"]);
            if (dr["PCTE_DCode"] != DBNull.Value) pCT_Event.PCTE_DCode = Convert.ToString(dr["PCTE_DCode"]);
            if (dr["PCTE_Join"] != DBNull.Value) pCT_Event.PCTE_Join = Convert.ToString(dr["PCTE_Join"]);
            if (dr["PCTE_Cost"] != DBNull.Value) pCT_Event.PCTE_Cost = Convert.ToDecimal(dr["PCTE_Cost"]);
            if (dr["PCTE_Before"] != DBNull.Value) pCT_Event.PCTE_Before = Convert.ToSingle(dr["PCTE_Before"]);
            if (dr["PCTE_After"] != DBNull.Value) pCT_Event.PCTE_After = Convert.ToSingle(dr["PCTE_After"]);
            if (dr["PCTE_Address"] != DBNull.Value) pCT_Event.PCTE_Address = Convert.ToString(dr["PCTE_Address"]);
            if (dr["Stat"] != DBNull.Value) pCT_Event.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Event.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Event.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Event.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTE_iType"] != DBNull.Value) pCT_Event.PCTE_iType = Convert.ToString(dr["PCTE_iType"]);
            if (dr["PCTE_TCode"] != DBNull.Value) pCT_Event.PCTE_TCode = Convert.ToString(dr["PCTE_TCode"]);
            if (dr["PCTE_Udef2"] != DBNull.Value) pCT_Event.PCTE_Udef2 = Convert.ToString(dr["PCTE_Udef2"]);
            if (dr["PCTE_Udef3"] != DBNull.Value) pCT_Event.PCTE_Udef3 = Convert.ToString(dr["PCTE_Udef3"]);
            if (dr["PCTE_Udef4"] != DBNull.Value) pCT_Event.PCTE_Udef4 = Convert.ToString(dr["PCTE_Udef4"]);
            if (dr["PCTE_Udef5"] != DBNull.Value) pCT_Event.PCTE_Udef5 = Convert.ToString(dr["PCTE_Udef5"]);
            ret.Add(pCT_Event);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
