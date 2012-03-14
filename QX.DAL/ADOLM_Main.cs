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
   /// 地磅计量信息
   /// </summary>
   [Serializable]
   public partial class ADOLM_Main
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加地磅计量信息 LM_Main对象(即:一条记录)
      /// </summary>
      public int Add(LM_Main lM_Main)
      {
         string sql = "INSERT INTO LM_Main (LM_Code,LM_Unit,LM_Error,LM_No,LM_Date,LM_GW,LM_NWeight,LM_TareWeight,LM_LastWeight,LM_RType,LM_RCode,LM_Delivery,LM_Receive,LM_Type,LM_iType,LM_Stat,LM_Price,LM_Amount,LM_PounderName,LM_Pounder,LM_MName,LM_MCode,LM_Transport,LM_TransportName,LM_Pilot,LM_PilotName,LM_Remark,Stat,UpdateDate,DeleteDate,CreateDate) VALUES (@LM_Code,@LM_Unit,@LM_Error,@LM_No,@LM_Date,@LM_GW,@LM_NWeight,@LM_TareWeight,@LM_LastWeight,@LM_RType,@LM_RCode,@LM_Delivery,@LM_Receive,@LM_Type,@LM_iType,@LM_Stat,@LM_Price,@LM_Amount,@LM_PounderName,@LM_Pounder,@LM_MName,@LM_MCode,@LM_Transport,@LM_TransportName,@LM_Pilot,@LM_PilotName,@LM_Remark,@Stat,@UpdateDate,@DeleteDate,@CreateDate)";
         if (string.IsNullOrEmpty(lM_Main.LM_Code))
         {
            idb.AddParameter("@LM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Code", lM_Main.LM_Code);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Unit))
         {
            idb.AddParameter("@LM_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Unit", lM_Main.LM_Unit);
         }
         if (lM_Main.LM_Error == 0)
         {
            idb.AddParameter("@LM_Error", 0);
         }
         else
         {
            idb.AddParameter("@LM_Error", lM_Main.LM_Error);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_No))
         {
            idb.AddParameter("@LM_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_No", lM_Main.LM_No);
         }
         if (lM_Main.LM_Date == DateTime.MinValue)
         {
            idb.AddParameter("@LM_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Date", lM_Main.LM_Date);
         }
         if (lM_Main.LM_GW == 0)
         {
            idb.AddParameter("@LM_GW", 0);
         }
         else
         {
            idb.AddParameter("@LM_GW", lM_Main.LM_GW);
         }
         if (lM_Main.LM_NWeight == 0)
         {
            idb.AddParameter("@LM_NWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_NWeight", lM_Main.LM_NWeight);
         }
         if (lM_Main.LM_TareWeight == 0)
         {
            idb.AddParameter("@LM_TareWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_TareWeight", lM_Main.LM_TareWeight);
         }
         if (lM_Main.LM_LastWeight == 0)
         {
            idb.AddParameter("@LM_LastWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_LastWeight", lM_Main.LM_LastWeight);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_RType))
         {
            idb.AddParameter("@LM_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_RType", lM_Main.LM_RType);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_RCode))
         {
            idb.AddParameter("@LM_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_RCode", lM_Main.LM_RCode);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Delivery))
         {
            idb.AddParameter("@LM_Delivery", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Delivery", lM_Main.LM_Delivery);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Receive))
         {
            idb.AddParameter("@LM_Receive", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Receive", lM_Main.LM_Receive);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Type))
         {
            idb.AddParameter("@LM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Type", lM_Main.LM_Type);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_iType))
         {
            idb.AddParameter("@LM_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_iType", lM_Main.LM_iType);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Stat))
         {
            idb.AddParameter("@LM_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Stat", lM_Main.LM_Stat);
         }
         if (lM_Main.LM_Price == 0)
         {
            idb.AddParameter("@LM_Price", 0);
         }
         else
         {
            idb.AddParameter("@LM_Price", lM_Main.LM_Price);
         }
         if (lM_Main.LM_Amount == 0)
         {
            idb.AddParameter("@LM_Amount", 0);
         }
         else
         {
            idb.AddParameter("@LM_Amount", lM_Main.LM_Amount);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_PounderName))
         {
            idb.AddParameter("@LM_PounderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_PounderName", lM_Main.LM_PounderName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Pounder))
         {
            idb.AddParameter("@LM_Pounder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Pounder", lM_Main.LM_Pounder);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_MName))
         {
            idb.AddParameter("@LM_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_MName", lM_Main.LM_MName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_MCode))
         {
            idb.AddParameter("@LM_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_MCode", lM_Main.LM_MCode);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Transport))
         {
            idb.AddParameter("@LM_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Transport", lM_Main.LM_Transport);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_TransportName))
         {
            idb.AddParameter("@LM_TransportName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_TransportName", lM_Main.LM_TransportName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Pilot))
         {
            idb.AddParameter("@LM_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Pilot", lM_Main.LM_Pilot);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_PilotName))
         {
            idb.AddParameter("@LM_PilotName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_PilotName", lM_Main.LM_PilotName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Remark))
         {
            idb.AddParameter("@LM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Remark", lM_Main.LM_Remark);
         }
         if (lM_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", lM_Main.Stat);
         }
         if (lM_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", lM_Main.UpdateDate);
         }
         if (lM_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", lM_Main.DeleteDate);
         }
         if (lM_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", lM_Main.CreateDate);
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
      /// 添加地磅计量信息 LM_Main对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(LM_Main lM_Main)
      {
         string sql = "INSERT INTO LM_Main (LM_Code,LM_Unit,LM_Error,LM_No,LM_Date,LM_GW,LM_NWeight,LM_TareWeight,LM_LastWeight,LM_RType,LM_RCode,LM_Delivery,LM_Receive,LM_Type,LM_iType,LM_Stat,LM_Price,LM_Amount,LM_PounderName,LM_Pounder,LM_MName,LM_MCode,LM_Transport,LM_TransportName,LM_Pilot,LM_PilotName,LM_Remark,Stat,UpdateDate,DeleteDate,CreateDate) VALUES (@LM_Code,@LM_Unit,@LM_Error,@LM_No,@LM_Date,@LM_GW,@LM_NWeight,@LM_TareWeight,@LM_LastWeight,@LM_RType,@LM_RCode,@LM_Delivery,@LM_Receive,@LM_Type,@LM_iType,@LM_Stat,@LM_Price,@LM_Amount,@LM_PounderName,@LM_Pounder,@LM_MName,@LM_MCode,@LM_Transport,@LM_TransportName,@LM_Pilot,@LM_PilotName,@LM_Remark,@Stat,@UpdateDate,@DeleteDate,@CreateDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(lM_Main.LM_Code))
         {
            idb.AddParameter("@LM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Code", lM_Main.LM_Code);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Unit))
         {
            idb.AddParameter("@LM_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Unit", lM_Main.LM_Unit);
         }
         if (lM_Main.LM_Error == 0)
         {
            idb.AddParameter("@LM_Error", 0);
         }
         else
         {
            idb.AddParameter("@LM_Error", lM_Main.LM_Error);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_No))
         {
            idb.AddParameter("@LM_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_No", lM_Main.LM_No);
         }
         if (lM_Main.LM_Date == DateTime.MinValue)
         {
            idb.AddParameter("@LM_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Date", lM_Main.LM_Date);
         }
         if (lM_Main.LM_GW == 0)
         {
            idb.AddParameter("@LM_GW", 0);
         }
         else
         {
            idb.AddParameter("@LM_GW", lM_Main.LM_GW);
         }
         if (lM_Main.LM_NWeight == 0)
         {
            idb.AddParameter("@LM_NWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_NWeight", lM_Main.LM_NWeight);
         }
         if (lM_Main.LM_TareWeight == 0)
         {
            idb.AddParameter("@LM_TareWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_TareWeight", lM_Main.LM_TareWeight);
         }
         if (lM_Main.LM_LastWeight == 0)
         {
            idb.AddParameter("@LM_LastWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_LastWeight", lM_Main.LM_LastWeight);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_RType))
         {
            idb.AddParameter("@LM_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_RType", lM_Main.LM_RType);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_RCode))
         {
            idb.AddParameter("@LM_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_RCode", lM_Main.LM_RCode);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Delivery))
         {
            idb.AddParameter("@LM_Delivery", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Delivery", lM_Main.LM_Delivery);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Receive))
         {
            idb.AddParameter("@LM_Receive", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Receive", lM_Main.LM_Receive);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Type))
         {
            idb.AddParameter("@LM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Type", lM_Main.LM_Type);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_iType))
         {
            idb.AddParameter("@LM_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_iType", lM_Main.LM_iType);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Stat))
         {
            idb.AddParameter("@LM_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Stat", lM_Main.LM_Stat);
         }
         if (lM_Main.LM_Price == 0)
         {
            idb.AddParameter("@LM_Price", 0);
         }
         else
         {
            idb.AddParameter("@LM_Price", lM_Main.LM_Price);
         }
         if (lM_Main.LM_Amount == 0)
         {
            idb.AddParameter("@LM_Amount", 0);
         }
         else
         {
            idb.AddParameter("@LM_Amount", lM_Main.LM_Amount);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_PounderName))
         {
            idb.AddParameter("@LM_PounderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_PounderName", lM_Main.LM_PounderName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Pounder))
         {
            idb.AddParameter("@LM_Pounder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Pounder", lM_Main.LM_Pounder);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_MName))
         {
            idb.AddParameter("@LM_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_MName", lM_Main.LM_MName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_MCode))
         {
            idb.AddParameter("@LM_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_MCode", lM_Main.LM_MCode);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Transport))
         {
            idb.AddParameter("@LM_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Transport", lM_Main.LM_Transport);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_TransportName))
         {
            idb.AddParameter("@LM_TransportName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_TransportName", lM_Main.LM_TransportName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Pilot))
         {
            idb.AddParameter("@LM_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Pilot", lM_Main.LM_Pilot);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_PilotName))
         {
            idb.AddParameter("@LM_PilotName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_PilotName", lM_Main.LM_PilotName);
         }
         if (string.IsNullOrEmpty(lM_Main.LM_Remark))
         {
            idb.AddParameter("@LM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Remark", lM_Main.LM_Remark);
         }
         if (lM_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", lM_Main.Stat);
         }
         if (lM_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", lM_Main.UpdateDate);
         }
         if (lM_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", lM_Main.DeleteDate);
         }
         if (lM_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", lM_Main.CreateDate);
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
      /// 更新地磅计量信息 LM_Main对象(即:一条记录
      /// </summary>
      public int Update(LM_Main lM_Main)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       LM_Main       SET ");
            if(lM_Main.LM_Code_IsChanged){sbParameter.Append("LM_Code=@LM_Code, ");}
      if(lM_Main.LM_Unit_IsChanged){sbParameter.Append("LM_Unit=@LM_Unit, ");}
      if(lM_Main.LM_Error_IsChanged){sbParameter.Append("LM_Error=@LM_Error, ");}
      if(lM_Main.LM_No_IsChanged){sbParameter.Append("LM_No=@LM_No, ");}
      if(lM_Main.LM_Date_IsChanged){sbParameter.Append("LM_Date=@LM_Date, ");}
      if(lM_Main.LM_GW_IsChanged){sbParameter.Append("LM_GW=@LM_GW, ");}
      if(lM_Main.LM_NWeight_IsChanged){sbParameter.Append("LM_NWeight=@LM_NWeight, ");}
      if(lM_Main.LM_TareWeight_IsChanged){sbParameter.Append("LM_TareWeight=@LM_TareWeight, ");}
      if(lM_Main.LM_LastWeight_IsChanged){sbParameter.Append("LM_LastWeight=@LM_LastWeight, ");}
      if(lM_Main.LM_RType_IsChanged){sbParameter.Append("LM_RType=@LM_RType, ");}
      if(lM_Main.LM_RCode_IsChanged){sbParameter.Append("LM_RCode=@LM_RCode, ");}
      if(lM_Main.LM_Delivery_IsChanged){sbParameter.Append("LM_Delivery=@LM_Delivery, ");}
      if(lM_Main.LM_Receive_IsChanged){sbParameter.Append("LM_Receive=@LM_Receive, ");}
      if(lM_Main.LM_Type_IsChanged){sbParameter.Append("LM_Type=@LM_Type, ");}
      if(lM_Main.LM_iType_IsChanged){sbParameter.Append("LM_iType=@LM_iType, ");}
      if(lM_Main.LM_Stat_IsChanged){sbParameter.Append("LM_Stat=@LM_Stat, ");}
      if(lM_Main.LM_Price_IsChanged){sbParameter.Append("LM_Price=@LM_Price, ");}
      if(lM_Main.LM_Amount_IsChanged){sbParameter.Append("LM_Amount=@LM_Amount, ");}
      if(lM_Main.LM_PounderName_IsChanged){sbParameter.Append("LM_PounderName=@LM_PounderName, ");}
      if(lM_Main.LM_Pounder_IsChanged){sbParameter.Append("LM_Pounder=@LM_Pounder, ");}
      if(lM_Main.LM_MName_IsChanged){sbParameter.Append("LM_MName=@LM_MName, ");}
      if(lM_Main.LM_MCode_IsChanged){sbParameter.Append("LM_MCode=@LM_MCode, ");}
      if(lM_Main.LM_Transport_IsChanged){sbParameter.Append("LM_Transport=@LM_Transport, ");}
      if(lM_Main.LM_TransportName_IsChanged){sbParameter.Append("LM_TransportName=@LM_TransportName, ");}
      if(lM_Main.LM_Pilot_IsChanged){sbParameter.Append("LM_Pilot=@LM_Pilot, ");}
      if(lM_Main.LM_PilotName_IsChanged){sbParameter.Append("LM_PilotName=@LM_PilotName, ");}
      if(lM_Main.LM_Remark_IsChanged){sbParameter.Append("LM_Remark=@LM_Remark, ");}
      if(lM_Main.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(lM_Main.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(lM_Main.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(lM_Main.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and LM_ID=@LM_ID; " );
      string sql=sb.ToString();
         if(lM_Main.LM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Code))
         {
            idb.AddParameter("@LM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Code", lM_Main.LM_Code);
         }
          }
         if(lM_Main.LM_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Unit))
         {
            idb.AddParameter("@LM_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Unit", lM_Main.LM_Unit);
         }
          }
         if(lM_Main.LM_Error_IsChanged)
         {
         if (lM_Main.LM_Error == 0)
         {
            idb.AddParameter("@LM_Error", 0);
         }
         else
         {
            idb.AddParameter("@LM_Error", lM_Main.LM_Error);
         }
          }
         if(lM_Main.LM_No_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_No))
         {
            idb.AddParameter("@LM_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_No", lM_Main.LM_No);
         }
          }
         if(lM_Main.LM_Date_IsChanged)
         {
         if (lM_Main.LM_Date == DateTime.MinValue)
         {
            idb.AddParameter("@LM_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Date", lM_Main.LM_Date);
         }
          }
         if(lM_Main.LM_GW_IsChanged)
         {
         if (lM_Main.LM_GW == 0)
         {
            idb.AddParameter("@LM_GW", 0);
         }
         else
         {
            idb.AddParameter("@LM_GW", lM_Main.LM_GW);
         }
          }
         if(lM_Main.LM_NWeight_IsChanged)
         {
         if (lM_Main.LM_NWeight == 0)
         {
            idb.AddParameter("@LM_NWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_NWeight", lM_Main.LM_NWeight);
         }
          }
         if(lM_Main.LM_TareWeight_IsChanged)
         {
         if (lM_Main.LM_TareWeight == 0)
         {
            idb.AddParameter("@LM_TareWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_TareWeight", lM_Main.LM_TareWeight);
         }
          }
         if(lM_Main.LM_LastWeight_IsChanged)
         {
         if (lM_Main.LM_LastWeight == 0)
         {
            idb.AddParameter("@LM_LastWeight", 0);
         }
         else
         {
            idb.AddParameter("@LM_LastWeight", lM_Main.LM_LastWeight);
         }
          }
         if(lM_Main.LM_RType_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_RType))
         {
            idb.AddParameter("@LM_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_RType", lM_Main.LM_RType);
         }
          }
         if(lM_Main.LM_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_RCode))
         {
            idb.AddParameter("@LM_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_RCode", lM_Main.LM_RCode);
         }
          }
         if(lM_Main.LM_Delivery_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Delivery))
         {
            idb.AddParameter("@LM_Delivery", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Delivery", lM_Main.LM_Delivery);
         }
          }
         if(lM_Main.LM_Receive_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Receive))
         {
            idb.AddParameter("@LM_Receive", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Receive", lM_Main.LM_Receive);
         }
          }
         if(lM_Main.LM_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Type))
         {
            idb.AddParameter("@LM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Type", lM_Main.LM_Type);
         }
          }
         if(lM_Main.LM_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_iType))
         {
            idb.AddParameter("@LM_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_iType", lM_Main.LM_iType);
         }
          }
         if(lM_Main.LM_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Stat))
         {
            idb.AddParameter("@LM_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Stat", lM_Main.LM_Stat);
         }
          }
         if(lM_Main.LM_Price_IsChanged)
         {
         if (lM_Main.LM_Price == 0)
         {
            idb.AddParameter("@LM_Price", 0);
         }
         else
         {
            idb.AddParameter("@LM_Price", lM_Main.LM_Price);
         }
          }
         if(lM_Main.LM_Amount_IsChanged)
         {
         if (lM_Main.LM_Amount == 0)
         {
            idb.AddParameter("@LM_Amount", 0);
         }
         else
         {
            idb.AddParameter("@LM_Amount", lM_Main.LM_Amount);
         }
          }
         if(lM_Main.LM_PounderName_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_PounderName))
         {
            idb.AddParameter("@LM_PounderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_PounderName", lM_Main.LM_PounderName);
         }
          }
         if(lM_Main.LM_Pounder_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Pounder))
         {
            idb.AddParameter("@LM_Pounder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Pounder", lM_Main.LM_Pounder);
         }
          }
         if(lM_Main.LM_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_MName))
         {
            idb.AddParameter("@LM_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_MName", lM_Main.LM_MName);
         }
          }
         if(lM_Main.LM_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_MCode))
         {
            idb.AddParameter("@LM_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_MCode", lM_Main.LM_MCode);
         }
          }
         if(lM_Main.LM_Transport_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Transport))
         {
            idb.AddParameter("@LM_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Transport", lM_Main.LM_Transport);
         }
          }
         if(lM_Main.LM_TransportName_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_TransportName))
         {
            idb.AddParameter("@LM_TransportName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_TransportName", lM_Main.LM_TransportName);
         }
          }
         if(lM_Main.LM_Pilot_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Pilot))
         {
            idb.AddParameter("@LM_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Pilot", lM_Main.LM_Pilot);
         }
          }
         if(lM_Main.LM_PilotName_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_PilotName))
         {
            idb.AddParameter("@LM_PilotName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_PilotName", lM_Main.LM_PilotName);
         }
          }
         if(lM_Main.LM_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Main.LM_Remark))
         {
            idb.AddParameter("@LM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LM_Remark", lM_Main.LM_Remark);
         }
          }
         if(lM_Main.Stat_IsChanged)
         {
         if (lM_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", lM_Main.Stat);
         }
          }
         if(lM_Main.UpdateDate_IsChanged)
         {
         if (lM_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", lM_Main.UpdateDate);
         }
          }
         if(lM_Main.DeleteDate_IsChanged)
         {
         if (lM_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", lM_Main.DeleteDate);
         }
          }
         if(lM_Main.CreateDate_IsChanged)
         {
         if (lM_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", lM_Main.CreateDate);
         }
          }

         idb.AddParameter("@LM_ID", lM_Main.LM_ID);

           
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
      /// 删除地磅计量信息 LM_Main对象(即:一条记录
      /// </summary>
      public int Delete(decimal lM_ID)
      {
         string sql = "DELETE LM_Main WHERE 1=1  AND LM_ID=@LM_ID ";
         idb.AddParameter("@LM_ID", lM_ID);

           
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
      /// 获取指定的地磅计量信息 LM_Main对象(即:一条记录
      /// </summary>
      public LM_Main GetByKey(decimal lM_ID)
      {
         LM_Main lM_Main = new LM_Main();
         string sql = "SELECT  LM_ID,LM_Code,LM_Unit,LM_Error,LM_No,LM_Date,LM_GW,LM_NWeight,LM_TareWeight,LM_LastWeight,LM_RType,LM_RCode,LM_Delivery,LM_Receive,LM_Type,LM_iType,LM_Stat,LM_Price,LM_Amount,LM_PounderName,LM_Pounder,LM_MName,LM_MCode,LM_Transport,LM_TransportName,LM_Pilot,LM_PilotName,LM_Remark,Stat,UpdateDate,DeleteDate,CreateDate FROM LM_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND LM_ID=@LM_ID ";
         idb.AddParameter("@LM_ID", lM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["LM_ID"] != DBNull.Value) lM_Main.LM_ID = Convert.ToDecimal(dr["LM_ID"]);
            if (dr["LM_Code"] != DBNull.Value) lM_Main.LM_Code = Convert.ToString(dr["LM_Code"]);
            if (dr["LM_Unit"] != DBNull.Value) lM_Main.LM_Unit = Convert.ToString(dr["LM_Unit"]);
            if (dr["LM_Error"] != DBNull.Value) lM_Main.LM_Error = Convert.ToDecimal(dr["LM_Error"]);
            if (dr["LM_No"] != DBNull.Value) lM_Main.LM_No = Convert.ToString(dr["LM_No"]);
            if (dr["LM_Date"] != DBNull.Value) lM_Main.LM_Date = Convert.ToDateTime(dr["LM_Date"]);
            if (dr["LM_GW"] != DBNull.Value) lM_Main.LM_GW = Convert.ToDecimal(dr["LM_GW"]);
            if (dr["LM_NWeight"] != DBNull.Value) lM_Main.LM_NWeight = Convert.ToDecimal(dr["LM_NWeight"]);
            if (dr["LM_TareWeight"] != DBNull.Value) lM_Main.LM_TareWeight = Convert.ToDecimal(dr["LM_TareWeight"]);
            if (dr["LM_LastWeight"] != DBNull.Value) lM_Main.LM_LastWeight = Convert.ToDecimal(dr["LM_LastWeight"]);
            if (dr["LM_RType"] != DBNull.Value) lM_Main.LM_RType = Convert.ToString(dr["LM_RType"]);
            if (dr["LM_RCode"] != DBNull.Value) lM_Main.LM_RCode = Convert.ToString(dr["LM_RCode"]);
            if (dr["LM_Delivery"] != DBNull.Value) lM_Main.LM_Delivery = Convert.ToString(dr["LM_Delivery"]);
            if (dr["LM_Receive"] != DBNull.Value) lM_Main.LM_Receive = Convert.ToString(dr["LM_Receive"]);
            if (dr["LM_Type"] != DBNull.Value) lM_Main.LM_Type = Convert.ToString(dr["LM_Type"]);
            if (dr["LM_iType"] != DBNull.Value) lM_Main.LM_iType = Convert.ToString(dr["LM_iType"]);
            if (dr["LM_Stat"] != DBNull.Value) lM_Main.LM_Stat = Convert.ToString(dr["LM_Stat"]);
            if (dr["LM_Price"] != DBNull.Value) lM_Main.LM_Price = Convert.ToDecimal(dr["LM_Price"]);
            if (dr["LM_Amount"] != DBNull.Value) lM_Main.LM_Amount = Convert.ToDecimal(dr["LM_Amount"]);
            if (dr["LM_PounderName"] != DBNull.Value) lM_Main.LM_PounderName = Convert.ToString(dr["LM_PounderName"]);
            if (dr["LM_Pounder"] != DBNull.Value) lM_Main.LM_Pounder = Convert.ToString(dr["LM_Pounder"]);
            if (dr["LM_MName"] != DBNull.Value) lM_Main.LM_MName = Convert.ToString(dr["LM_MName"]);
            if (dr["LM_MCode"] != DBNull.Value) lM_Main.LM_MCode = Convert.ToString(dr["LM_MCode"]);
            if (dr["LM_Transport"] != DBNull.Value) lM_Main.LM_Transport = Convert.ToString(dr["LM_Transport"]);
            if (dr["LM_TransportName"] != DBNull.Value) lM_Main.LM_TransportName = Convert.ToString(dr["LM_TransportName"]);
            if (dr["LM_Pilot"] != DBNull.Value) lM_Main.LM_Pilot = Convert.ToString(dr["LM_Pilot"]);
            if (dr["LM_PilotName"] != DBNull.Value) lM_Main.LM_PilotName = Convert.ToString(dr["LM_PilotName"]);
            if (dr["LM_Remark"] != DBNull.Value) lM_Main.LM_Remark = Convert.ToString(dr["LM_Remark"]);
            if (dr["Stat"] != DBNull.Value) lM_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateDate"] != DBNull.Value) lM_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) lM_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateDate"] != DBNull.Value) lM_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return lM_Main;
      }
      /// <summary>
      /// 获取指定的地磅计量信息 LM_Main对象集合
      /// </summary>
      public List<LM_Main> GetListByWhere(string strCondition)
      {
         List<LM_Main> ret = new List<LM_Main>();
         string sql = "SELECT  LM_ID,LM_Code,LM_Unit,LM_Error,LM_No,LM_Date,LM_GW,LM_NWeight,LM_TareWeight,LM_LastWeight,LM_RType,LM_RCode,LM_Delivery,LM_Receive,LM_Type,LM_iType,LM_Stat,LM_Price,LM_Amount,LM_PounderName,LM_Pounder,LM_MName,LM_MCode,LM_Transport,LM_TransportName,LM_Pilot,LM_PilotName,LM_Remark,Stat,UpdateDate,DeleteDate,CreateDate FROM LM_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            LM_Main lM_Main = new LM_Main();
            if (dr["LM_ID"] != DBNull.Value) lM_Main.LM_ID = Convert.ToDecimal(dr["LM_ID"]);
            if (dr["LM_Code"] != DBNull.Value) lM_Main.LM_Code = Convert.ToString(dr["LM_Code"]);
            if (dr["LM_Unit"] != DBNull.Value) lM_Main.LM_Unit = Convert.ToString(dr["LM_Unit"]);
            if (dr["LM_Error"] != DBNull.Value) lM_Main.LM_Error = Convert.ToDecimal(dr["LM_Error"]);
            if (dr["LM_No"] != DBNull.Value) lM_Main.LM_No = Convert.ToString(dr["LM_No"]);
            if (dr["LM_Date"] != DBNull.Value) lM_Main.LM_Date = Convert.ToDateTime(dr["LM_Date"]);
            if (dr["LM_GW"] != DBNull.Value) lM_Main.LM_GW = Convert.ToDecimal(dr["LM_GW"]);
            if (dr["LM_NWeight"] != DBNull.Value) lM_Main.LM_NWeight = Convert.ToDecimal(dr["LM_NWeight"]);
            if (dr["LM_TareWeight"] != DBNull.Value) lM_Main.LM_TareWeight = Convert.ToDecimal(dr["LM_TareWeight"]);
            if (dr["LM_LastWeight"] != DBNull.Value) lM_Main.LM_LastWeight = Convert.ToDecimal(dr["LM_LastWeight"]);
            if (dr["LM_RType"] != DBNull.Value) lM_Main.LM_RType = Convert.ToString(dr["LM_RType"]);
            if (dr["LM_RCode"] != DBNull.Value) lM_Main.LM_RCode = Convert.ToString(dr["LM_RCode"]);
            if (dr["LM_Delivery"] != DBNull.Value) lM_Main.LM_Delivery = Convert.ToString(dr["LM_Delivery"]);
            if (dr["LM_Receive"] != DBNull.Value) lM_Main.LM_Receive = Convert.ToString(dr["LM_Receive"]);
            if (dr["LM_Type"] != DBNull.Value) lM_Main.LM_Type = Convert.ToString(dr["LM_Type"]);
            if (dr["LM_iType"] != DBNull.Value) lM_Main.LM_iType = Convert.ToString(dr["LM_iType"]);
            if (dr["LM_Stat"] != DBNull.Value) lM_Main.LM_Stat = Convert.ToString(dr["LM_Stat"]);
            if (dr["LM_Price"] != DBNull.Value) lM_Main.LM_Price = Convert.ToDecimal(dr["LM_Price"]);
            if (dr["LM_Amount"] != DBNull.Value) lM_Main.LM_Amount = Convert.ToDecimal(dr["LM_Amount"]);
            if (dr["LM_PounderName"] != DBNull.Value) lM_Main.LM_PounderName = Convert.ToString(dr["LM_PounderName"]);
            if (dr["LM_Pounder"] != DBNull.Value) lM_Main.LM_Pounder = Convert.ToString(dr["LM_Pounder"]);
            if (dr["LM_MName"] != DBNull.Value) lM_Main.LM_MName = Convert.ToString(dr["LM_MName"]);
            if (dr["LM_MCode"] != DBNull.Value) lM_Main.LM_MCode = Convert.ToString(dr["LM_MCode"]);
            if (dr["LM_Transport"] != DBNull.Value) lM_Main.LM_Transport = Convert.ToString(dr["LM_Transport"]);
            if (dr["LM_TransportName"] != DBNull.Value) lM_Main.LM_TransportName = Convert.ToString(dr["LM_TransportName"]);
            if (dr["LM_Pilot"] != DBNull.Value) lM_Main.LM_Pilot = Convert.ToString(dr["LM_Pilot"]);
            if (dr["LM_PilotName"] != DBNull.Value) lM_Main.LM_PilotName = Convert.ToString(dr["LM_PilotName"]);
            if (dr["LM_Remark"] != DBNull.Value) lM_Main.LM_Remark = Convert.ToString(dr["LM_Remark"]);
            if (dr["Stat"] != DBNull.Value) lM_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateDate"] != DBNull.Value) lM_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) lM_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateDate"] != DBNull.Value) lM_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            ret.Add(lM_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的地磅计量信息 LM_Main对象(即:一条记录
      /// </summary>
      public List<LM_Main> GetAll()
      {
         List<LM_Main> ret = new List<LM_Main>();
         string sql = "SELECT  LM_ID,LM_Code,LM_Unit,LM_Error,LM_No,LM_Date,LM_GW,LM_NWeight,LM_TareWeight,LM_LastWeight,LM_RType,LM_RCode,LM_Delivery,LM_Receive,LM_Type,LM_iType,LM_Stat,LM_Price,LM_Amount,LM_PounderName,LM_Pounder,LM_MName,LM_MCode,LM_Transport,LM_TransportName,LM_Pilot,LM_PilotName,LM_Remark,Stat,UpdateDate,DeleteDate,CreateDate FROM LM_Main where 1=1 AND ((Stat is null) or (Stat=0) ) order by LM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            LM_Main lM_Main = new LM_Main();
            if (dr["LM_ID"] != DBNull.Value) lM_Main.LM_ID = Convert.ToDecimal(dr["LM_ID"]);
            if (dr["LM_Code"] != DBNull.Value) lM_Main.LM_Code = Convert.ToString(dr["LM_Code"]);
            if (dr["LM_Unit"] != DBNull.Value) lM_Main.LM_Unit = Convert.ToString(dr["LM_Unit"]);
            if (dr["LM_Error"] != DBNull.Value) lM_Main.LM_Error = Convert.ToDecimal(dr["LM_Error"]);
            if (dr["LM_No"] != DBNull.Value) lM_Main.LM_No = Convert.ToString(dr["LM_No"]);
            if (dr["LM_Date"] != DBNull.Value) lM_Main.LM_Date = Convert.ToDateTime(dr["LM_Date"]);
            if (dr["LM_GW"] != DBNull.Value) lM_Main.LM_GW = Convert.ToDecimal(dr["LM_GW"]);
            if (dr["LM_NWeight"] != DBNull.Value) lM_Main.LM_NWeight = Convert.ToDecimal(dr["LM_NWeight"]);
            if (dr["LM_TareWeight"] != DBNull.Value) lM_Main.LM_TareWeight = Convert.ToDecimal(dr["LM_TareWeight"]);
            if (dr["LM_LastWeight"] != DBNull.Value) lM_Main.LM_LastWeight = Convert.ToDecimal(dr["LM_LastWeight"]);
            if (dr["LM_RType"] != DBNull.Value) lM_Main.LM_RType = Convert.ToString(dr["LM_RType"]);
            if (dr["LM_RCode"] != DBNull.Value) lM_Main.LM_RCode = Convert.ToString(dr["LM_RCode"]);
            if (dr["LM_Delivery"] != DBNull.Value) lM_Main.LM_Delivery = Convert.ToString(dr["LM_Delivery"]);
            if (dr["LM_Receive"] != DBNull.Value) lM_Main.LM_Receive = Convert.ToString(dr["LM_Receive"]);
            if (dr["LM_Type"] != DBNull.Value) lM_Main.LM_Type = Convert.ToString(dr["LM_Type"]);
            if (dr["LM_iType"] != DBNull.Value) lM_Main.LM_iType = Convert.ToString(dr["LM_iType"]);
            if (dr["LM_Stat"] != DBNull.Value) lM_Main.LM_Stat = Convert.ToString(dr["LM_Stat"]);
            if (dr["LM_Price"] != DBNull.Value) lM_Main.LM_Price = Convert.ToDecimal(dr["LM_Price"]);
            if (dr["LM_Amount"] != DBNull.Value) lM_Main.LM_Amount = Convert.ToDecimal(dr["LM_Amount"]);
            if (dr["LM_PounderName"] != DBNull.Value) lM_Main.LM_PounderName = Convert.ToString(dr["LM_PounderName"]);
            if (dr["LM_Pounder"] != DBNull.Value) lM_Main.LM_Pounder = Convert.ToString(dr["LM_Pounder"]);
            if (dr["LM_MName"] != DBNull.Value) lM_Main.LM_MName = Convert.ToString(dr["LM_MName"]);
            if (dr["LM_MCode"] != DBNull.Value) lM_Main.LM_MCode = Convert.ToString(dr["LM_MCode"]);
            if (dr["LM_Transport"] != DBNull.Value) lM_Main.LM_Transport = Convert.ToString(dr["LM_Transport"]);
            if (dr["LM_TransportName"] != DBNull.Value) lM_Main.LM_TransportName = Convert.ToString(dr["LM_TransportName"]);
            if (dr["LM_Pilot"] != DBNull.Value) lM_Main.LM_Pilot = Convert.ToString(dr["LM_Pilot"]);
            if (dr["LM_PilotName"] != DBNull.Value) lM_Main.LM_PilotName = Convert.ToString(dr["LM_PilotName"]);
            if (dr["LM_Remark"] != DBNull.Value) lM_Main.LM_Remark = Convert.ToString(dr["LM_Remark"]);
            if (dr["Stat"] != DBNull.Value) lM_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateDate"] != DBNull.Value) lM_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) lM_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateDate"] != DBNull.Value) lM_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            ret.Add(lM_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
