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
   public partial class ADOLoadometer_Usage
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加地磅计量信息 Loadometer_Usage对象(即:一条记录)
      /// </summary>
      public int Add(Loadometer_Usage loadometer_Usage)
      {
         string sql = "INSERT INTO Loadometer_Usage (Loadometer_Code,Loadometer_Unit,Loadometer_Error,Loadometer_No,Loadometer_Date,Loadometer_Delivery,Loadometer_Receive,Loadometer_Type,Loadometer_iType,Loadometer_Price,Loadometer_Amount,Loadometer_PounderName,Loadometer_Pounder,Loadometer_MName,Loadometer_MCode,Loadometer_Transport,Loadometer_TransportName,Loadometer_Pilot,Loadometer_PilotName,Loadometer_Remark,Stat,UpdateDate,DeleteDate,CreateDate) VALUES (@Loadometer_Code,@Loadometer_Unit,@Loadometer_Error,@Loadometer_No,@Loadometer_Date,@Loadometer_Delivery,@Loadometer_Receive,@Loadometer_Type,@Loadometer_iType,@Loadometer_Price,@Loadometer_Amount,@Loadometer_PounderName,@Loadometer_Pounder,@Loadometer_MName,@Loadometer_MCode,@Loadometer_Transport,@Loadometer_TransportName,@Loadometer_Pilot,@Loadometer_PilotName,@Loadometer_Remark,@Stat,@UpdateDate,@DeleteDate,@CreateDate)";
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Code))
         {
            idb.AddParameter("@Loadometer_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Code", loadometer_Usage.Loadometer_Code);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Unit))
         {
            idb.AddParameter("@Loadometer_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Unit", loadometer_Usage.Loadometer_Unit);
         }
         if (loadometer_Usage.Loadometer_Error == 0)
         {
            idb.AddParameter("@Loadometer_Error", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Error", loadometer_Usage.Loadometer_Error);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_No))
         {
            idb.AddParameter("@Loadometer_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_No", loadometer_Usage.Loadometer_No);
         }
         if (loadometer_Usage.Loadometer_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Loadometer_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Date", loadometer_Usage.Loadometer_Date);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Delivery))
         {
            idb.AddParameter("@Loadometer_Delivery", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Delivery", loadometer_Usage.Loadometer_Delivery);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Receive))
         {
            idb.AddParameter("@Loadometer_Receive", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Receive", loadometer_Usage.Loadometer_Receive);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Type))
         {
            idb.AddParameter("@Loadometer_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Type", loadometer_Usage.Loadometer_Type);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_iType))
         {
            idb.AddParameter("@Loadometer_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_iType", loadometer_Usage.Loadometer_iType);
         }
         if (loadometer_Usage.Loadometer_Price == 0)
         {
            idb.AddParameter("@Loadometer_Price", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Price", loadometer_Usage.Loadometer_Price);
         }
         if (loadometer_Usage.Loadometer_Amount == 0)
         {
            idb.AddParameter("@Loadometer_Amount", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Amount", loadometer_Usage.Loadometer_Amount);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_PounderName))
         {
            idb.AddParameter("@Loadometer_PounderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_PounderName", loadometer_Usage.Loadometer_PounderName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Pounder))
         {
            idb.AddParameter("@Loadometer_Pounder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Pounder", loadometer_Usage.Loadometer_Pounder);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_MName))
         {
            idb.AddParameter("@Loadometer_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_MName", loadometer_Usage.Loadometer_MName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_MCode))
         {
            idb.AddParameter("@Loadometer_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_MCode", loadometer_Usage.Loadometer_MCode);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Transport))
         {
            idb.AddParameter("@Loadometer_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Transport", loadometer_Usage.Loadometer_Transport);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_TransportName))
         {
            idb.AddParameter("@Loadometer_TransportName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_TransportName", loadometer_Usage.Loadometer_TransportName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Pilot))
         {
            idb.AddParameter("@Loadometer_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Pilot", loadometer_Usage.Loadometer_Pilot);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_PilotName))
         {
            idb.AddParameter("@Loadometer_PilotName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_PilotName", loadometer_Usage.Loadometer_PilotName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Remark))
         {
            idb.AddParameter("@Loadometer_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Remark", loadometer_Usage.Loadometer_Remark);
         }
         if (loadometer_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", loadometer_Usage.Stat);
         }
         if (loadometer_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", loadometer_Usage.UpdateDate);
         }
         if (loadometer_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", loadometer_Usage.DeleteDate);
         }
         if (loadometer_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", loadometer_Usage.CreateDate);
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
      /// 添加地磅计量信息 Loadometer_Usage对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Loadometer_Usage loadometer_Usage)
      {
         string sql = "INSERT INTO Loadometer_Usage (Loadometer_Code,Loadometer_Unit,Loadometer_Error,Loadometer_No,Loadometer_Date,Loadometer_Delivery,Loadometer_Receive,Loadometer_Type,Loadometer_iType,Loadometer_Price,Loadometer_Amount,Loadometer_PounderName,Loadometer_Pounder,Loadometer_MName,Loadometer_MCode,Loadometer_Transport,Loadometer_TransportName,Loadometer_Pilot,Loadometer_PilotName,Loadometer_Remark,Stat,UpdateDate,DeleteDate,CreateDate) VALUES (@Loadometer_Code,@Loadometer_Unit,@Loadometer_Error,@Loadometer_No,@Loadometer_Date,@Loadometer_Delivery,@Loadometer_Receive,@Loadometer_Type,@Loadometer_iType,@Loadometer_Price,@Loadometer_Amount,@Loadometer_PounderName,@Loadometer_Pounder,@Loadometer_MName,@Loadometer_MCode,@Loadometer_Transport,@Loadometer_TransportName,@Loadometer_Pilot,@Loadometer_PilotName,@Loadometer_Remark,@Stat,@UpdateDate,@DeleteDate,@CreateDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Code))
         {
            idb.AddParameter("@Loadometer_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Code", loadometer_Usage.Loadometer_Code);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Unit))
         {
            idb.AddParameter("@Loadometer_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Unit", loadometer_Usage.Loadometer_Unit);
         }
         if (loadometer_Usage.Loadometer_Error == 0)
         {
            idb.AddParameter("@Loadometer_Error", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Error", loadometer_Usage.Loadometer_Error);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_No))
         {
            idb.AddParameter("@Loadometer_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_No", loadometer_Usage.Loadometer_No);
         }
         if (loadometer_Usage.Loadometer_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Loadometer_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Date", loadometer_Usage.Loadometer_Date);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Delivery))
         {
            idb.AddParameter("@Loadometer_Delivery", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Delivery", loadometer_Usage.Loadometer_Delivery);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Receive))
         {
            idb.AddParameter("@Loadometer_Receive", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Receive", loadometer_Usage.Loadometer_Receive);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Type))
         {
            idb.AddParameter("@Loadometer_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Type", loadometer_Usage.Loadometer_Type);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_iType))
         {
            idb.AddParameter("@Loadometer_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_iType", loadometer_Usage.Loadometer_iType);
         }
         if (loadometer_Usage.Loadometer_Price == 0)
         {
            idb.AddParameter("@Loadometer_Price", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Price", loadometer_Usage.Loadometer_Price);
         }
         if (loadometer_Usage.Loadometer_Amount == 0)
         {
            idb.AddParameter("@Loadometer_Amount", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Amount", loadometer_Usage.Loadometer_Amount);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_PounderName))
         {
            idb.AddParameter("@Loadometer_PounderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_PounderName", loadometer_Usage.Loadometer_PounderName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Pounder))
         {
            idb.AddParameter("@Loadometer_Pounder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Pounder", loadometer_Usage.Loadometer_Pounder);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_MName))
         {
            idb.AddParameter("@Loadometer_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_MName", loadometer_Usage.Loadometer_MName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_MCode))
         {
            idb.AddParameter("@Loadometer_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_MCode", loadometer_Usage.Loadometer_MCode);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Transport))
         {
            idb.AddParameter("@Loadometer_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Transport", loadometer_Usage.Loadometer_Transport);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_TransportName))
         {
            idb.AddParameter("@Loadometer_TransportName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_TransportName", loadometer_Usage.Loadometer_TransportName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Pilot))
         {
            idb.AddParameter("@Loadometer_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Pilot", loadometer_Usage.Loadometer_Pilot);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_PilotName))
         {
            idb.AddParameter("@Loadometer_PilotName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_PilotName", loadometer_Usage.Loadometer_PilotName);
         }
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Remark))
         {
            idb.AddParameter("@Loadometer_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Remark", loadometer_Usage.Loadometer_Remark);
         }
         if (loadometer_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", loadometer_Usage.Stat);
         }
         if (loadometer_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", loadometer_Usage.UpdateDate);
         }
         if (loadometer_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", loadometer_Usage.DeleteDate);
         }
         if (loadometer_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", loadometer_Usage.CreateDate);
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
      /// 更新地磅计量信息 Loadometer_Usage对象(即:一条记录
      /// </summary>
      public int Update(Loadometer_Usage loadometer_Usage)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Loadometer_Usage       SET ");
            if(loadometer_Usage.Loadometer_Code_IsChanged){sbParameter.Append("Loadometer_Code=@Loadometer_Code, ");}
      if(loadometer_Usage.Loadometer_Unit_IsChanged){sbParameter.Append("Loadometer_Unit=@Loadometer_Unit, ");}
      if(loadometer_Usage.Loadometer_Error_IsChanged){sbParameter.Append("Loadometer_Error=@Loadometer_Error, ");}
      if(loadometer_Usage.Loadometer_No_IsChanged){sbParameter.Append("Loadometer_No=@Loadometer_No, ");}
      if(loadometer_Usage.Loadometer_Date_IsChanged){sbParameter.Append("Loadometer_Date=@Loadometer_Date, ");}
      if(loadometer_Usage.Loadometer_Delivery_IsChanged){sbParameter.Append("Loadometer_Delivery=@Loadometer_Delivery, ");}
      if(loadometer_Usage.Loadometer_Receive_IsChanged){sbParameter.Append("Loadometer_Receive=@Loadometer_Receive, ");}
      if(loadometer_Usage.Loadometer_Type_IsChanged){sbParameter.Append("Loadometer_Type=@Loadometer_Type, ");}
      if(loadometer_Usage.Loadometer_iType_IsChanged){sbParameter.Append("Loadometer_iType=@Loadometer_iType, ");}
      if(loadometer_Usage.Loadometer_Price_IsChanged){sbParameter.Append("Loadometer_Price=@Loadometer_Price, ");}
      if(loadometer_Usage.Loadometer_Amount_IsChanged){sbParameter.Append("Loadometer_Amount=@Loadometer_Amount, ");}
      if(loadometer_Usage.Loadometer_PounderName_IsChanged){sbParameter.Append("Loadometer_PounderName=@Loadometer_PounderName, ");}
      if(loadometer_Usage.Loadometer_Pounder_IsChanged){sbParameter.Append("Loadometer_Pounder=@Loadometer_Pounder, ");}
      if(loadometer_Usage.Loadometer_MName_IsChanged){sbParameter.Append("Loadometer_MName=@Loadometer_MName, ");}
      if(loadometer_Usage.Loadometer_MCode_IsChanged){sbParameter.Append("Loadometer_MCode=@Loadometer_MCode, ");}
      if(loadometer_Usage.Loadometer_Transport_IsChanged){sbParameter.Append("Loadometer_Transport=@Loadometer_Transport, ");}
      if(loadometer_Usage.Loadometer_TransportName_IsChanged){sbParameter.Append("Loadometer_TransportName=@Loadometer_TransportName, ");}
      if(loadometer_Usage.Loadometer_Pilot_IsChanged){sbParameter.Append("Loadometer_Pilot=@Loadometer_Pilot, ");}
      if(loadometer_Usage.Loadometer_PilotName_IsChanged){sbParameter.Append("Loadometer_PilotName=@Loadometer_PilotName, ");}
      if(loadometer_Usage.Loadometer_Remark_IsChanged){sbParameter.Append("Loadometer_Remark=@Loadometer_Remark, ");}
      if(loadometer_Usage.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(loadometer_Usage.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(loadometer_Usage.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(loadometer_Usage.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Loadometer_ID=@Loadometer_ID; " );
      string sql=sb.ToString();
         if(loadometer_Usage.Loadometer_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Code))
         {
            idb.AddParameter("@Loadometer_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Code", loadometer_Usage.Loadometer_Code);
         }
          }
         if(loadometer_Usage.Loadometer_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Unit))
         {
            idb.AddParameter("@Loadometer_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Unit", loadometer_Usage.Loadometer_Unit);
         }
          }
         if(loadometer_Usage.Loadometer_Error_IsChanged)
         {
         if (loadometer_Usage.Loadometer_Error == 0)
         {
            idb.AddParameter("@Loadometer_Error", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Error", loadometer_Usage.Loadometer_Error);
         }
          }
         if(loadometer_Usage.Loadometer_No_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_No))
         {
            idb.AddParameter("@Loadometer_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_No", loadometer_Usage.Loadometer_No);
         }
          }
         if(loadometer_Usage.Loadometer_Date_IsChanged)
         {
         if (loadometer_Usage.Loadometer_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Loadometer_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Date", loadometer_Usage.Loadometer_Date);
         }
          }
         if(loadometer_Usage.Loadometer_Delivery_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Delivery))
         {
            idb.AddParameter("@Loadometer_Delivery", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Delivery", loadometer_Usage.Loadometer_Delivery);
         }
          }
         if(loadometer_Usage.Loadometer_Receive_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Receive))
         {
            idb.AddParameter("@Loadometer_Receive", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Receive", loadometer_Usage.Loadometer_Receive);
         }
          }
         if(loadometer_Usage.Loadometer_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Type))
         {
            idb.AddParameter("@Loadometer_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Type", loadometer_Usage.Loadometer_Type);
         }
          }
         if(loadometer_Usage.Loadometer_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_iType))
         {
            idb.AddParameter("@Loadometer_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_iType", loadometer_Usage.Loadometer_iType);
         }
          }
         if(loadometer_Usage.Loadometer_Price_IsChanged)
         {
         if (loadometer_Usage.Loadometer_Price == 0)
         {
            idb.AddParameter("@Loadometer_Price", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Price", loadometer_Usage.Loadometer_Price);
         }
          }
         if(loadometer_Usage.Loadometer_Amount_IsChanged)
         {
         if (loadometer_Usage.Loadometer_Amount == 0)
         {
            idb.AddParameter("@Loadometer_Amount", 0);
         }
         else
         {
            idb.AddParameter("@Loadometer_Amount", loadometer_Usage.Loadometer_Amount);
         }
          }
         if(loadometer_Usage.Loadometer_PounderName_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_PounderName))
         {
            idb.AddParameter("@Loadometer_PounderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_PounderName", loadometer_Usage.Loadometer_PounderName);
         }
          }
         if(loadometer_Usage.Loadometer_Pounder_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Pounder))
         {
            idb.AddParameter("@Loadometer_Pounder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Pounder", loadometer_Usage.Loadometer_Pounder);
         }
          }
         if(loadometer_Usage.Loadometer_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_MName))
         {
            idb.AddParameter("@Loadometer_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_MName", loadometer_Usage.Loadometer_MName);
         }
          }
         if(loadometer_Usage.Loadometer_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_MCode))
         {
            idb.AddParameter("@Loadometer_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_MCode", loadometer_Usage.Loadometer_MCode);
         }
          }
         if(loadometer_Usage.Loadometer_Transport_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Transport))
         {
            idb.AddParameter("@Loadometer_Transport", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Transport", loadometer_Usage.Loadometer_Transport);
         }
          }
         if(loadometer_Usage.Loadometer_TransportName_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_TransportName))
         {
            idb.AddParameter("@Loadometer_TransportName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_TransportName", loadometer_Usage.Loadometer_TransportName);
         }
          }
         if(loadometer_Usage.Loadometer_Pilot_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Pilot))
         {
            idb.AddParameter("@Loadometer_Pilot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Pilot", loadometer_Usage.Loadometer_Pilot);
         }
          }
         if(loadometer_Usage.Loadometer_PilotName_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_PilotName))
         {
            idb.AddParameter("@Loadometer_PilotName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_PilotName", loadometer_Usage.Loadometer_PilotName);
         }
          }
         if(loadometer_Usage.Loadometer_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(loadometer_Usage.Loadometer_Remark))
         {
            idb.AddParameter("@Loadometer_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Loadometer_Remark", loadometer_Usage.Loadometer_Remark);
         }
          }
         if(loadometer_Usage.Stat_IsChanged)
         {
         if (loadometer_Usage.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", loadometer_Usage.Stat);
         }
          }
         if(loadometer_Usage.UpdateDate_IsChanged)
         {
         if (loadometer_Usage.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", loadometer_Usage.UpdateDate);
         }
          }
         if(loadometer_Usage.DeleteDate_IsChanged)
         {
         if (loadometer_Usage.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", loadometer_Usage.DeleteDate);
         }
          }
         if(loadometer_Usage.CreateDate_IsChanged)
         {
         if (loadometer_Usage.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", loadometer_Usage.CreateDate);
         }
          }

         idb.AddParameter("@Loadometer_ID", loadometer_Usage.Loadometer_ID);

           
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
      /// 删除地磅计量信息 Loadometer_Usage对象(即:一条记录
      /// </summary>
      public int Delete(decimal loadometer_ID)
      {
         string sql = "DELETE Loadometer_Usage WHERE 1=1  AND Loadometer_ID=@Loadometer_ID ";
         idb.AddParameter("@Loadometer_ID", loadometer_ID);

           
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
      /// 获取指定的地磅计量信息 Loadometer_Usage对象(即:一条记录
      /// </summary>
      public Loadometer_Usage GetByKey(decimal loadometer_ID)
      {
         Loadometer_Usage loadometer_Usage = new Loadometer_Usage();
         string sql = "SELECT  Loadometer_ID,Loadometer_Code,Loadometer_Unit,Loadometer_Error,Loadometer_No,Loadometer_Date,Loadometer_Delivery,Loadometer_Receive,Loadometer_Type,Loadometer_iType,Loadometer_Price,Loadometer_Amount,Loadometer_PounderName,Loadometer_Pounder,Loadometer_MName,Loadometer_MCode,Loadometer_Transport,Loadometer_TransportName,Loadometer_Pilot,Loadometer_PilotName,Loadometer_Remark,Stat,UpdateDate,DeleteDate,CreateDate FROM Loadometer_Usage WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Loadometer_ID=@Loadometer_ID ";
         idb.AddParameter("@Loadometer_ID", loadometer_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Loadometer_ID"] != DBNull.Value) loadometer_Usage.Loadometer_ID = Convert.ToDecimal(dr["Loadometer_ID"]);
            if (dr["Loadometer_Code"] != DBNull.Value) loadometer_Usage.Loadometer_Code = Convert.ToString(dr["Loadometer_Code"]);
            if (dr["Loadometer_Unit"] != DBNull.Value) loadometer_Usage.Loadometer_Unit = Convert.ToString(dr["Loadometer_Unit"]);
            if (dr["Loadometer_Error"] != DBNull.Value) loadometer_Usage.Loadometer_Error = Convert.ToSingle(dr["Loadometer_Error"]);
            if (dr["Loadometer_No"] != DBNull.Value) loadometer_Usage.Loadometer_No = Convert.ToString(dr["Loadometer_No"]);
            if (dr["Loadometer_Date"] != DBNull.Value) loadometer_Usage.Loadometer_Date = Convert.ToDateTime(dr["Loadometer_Date"]);
            if (dr["Loadometer_Delivery"] != DBNull.Value) loadometer_Usage.Loadometer_Delivery = Convert.ToString(dr["Loadometer_Delivery"]);
            if (dr["Loadometer_Receive"] != DBNull.Value) loadometer_Usage.Loadometer_Receive = Convert.ToString(dr["Loadometer_Receive"]);
            if (dr["Loadometer_Type"] != DBNull.Value) loadometer_Usage.Loadometer_Type = Convert.ToString(dr["Loadometer_Type"]);
            if (dr["Loadometer_iType"] != DBNull.Value) loadometer_Usage.Loadometer_iType = Convert.ToString(dr["Loadometer_iType"]);
            if (dr["Loadometer_Price"] != DBNull.Value) loadometer_Usage.Loadometer_Price = Convert.ToDecimal(dr["Loadometer_Price"]);
            if (dr["Loadometer_Amount"] != DBNull.Value) loadometer_Usage.Loadometer_Amount = Convert.ToDecimal(dr["Loadometer_Amount"]);
            if (dr["Loadometer_PounderName"] != DBNull.Value) loadometer_Usage.Loadometer_PounderName = Convert.ToString(dr["Loadometer_PounderName"]);
            if (dr["Loadometer_Pounder"] != DBNull.Value) loadometer_Usage.Loadometer_Pounder = Convert.ToString(dr["Loadometer_Pounder"]);
            if (dr["Loadometer_MName"] != DBNull.Value) loadometer_Usage.Loadometer_MName = Convert.ToString(dr["Loadometer_MName"]);
            if (dr["Loadometer_MCode"] != DBNull.Value) loadometer_Usage.Loadometer_MCode = Convert.ToString(dr["Loadometer_MCode"]);
            if (dr["Loadometer_Transport"] != DBNull.Value) loadometer_Usage.Loadometer_Transport = Convert.ToString(dr["Loadometer_Transport"]);
            if (dr["Loadometer_TransportName"] != DBNull.Value) loadometer_Usage.Loadometer_TransportName = Convert.ToString(dr["Loadometer_TransportName"]);
            if (dr["Loadometer_Pilot"] != DBNull.Value) loadometer_Usage.Loadometer_Pilot = Convert.ToString(dr["Loadometer_Pilot"]);
            if (dr["Loadometer_PilotName"] != DBNull.Value) loadometer_Usage.Loadometer_PilotName = Convert.ToString(dr["Loadometer_PilotName"]);
            if (dr["Loadometer_Remark"] != DBNull.Value) loadometer_Usage.Loadometer_Remark = Convert.ToString(dr["Loadometer_Remark"]);
            if (dr["Stat"] != DBNull.Value) loadometer_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateDate"] != DBNull.Value) loadometer_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) loadometer_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateDate"] != DBNull.Value) loadometer_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return loadometer_Usage;
      }
      /// <summary>
      /// 获取指定的地磅计量信息 Loadometer_Usage对象集合
      /// </summary>
      public List<Loadometer_Usage> GetListByWhere(string strCondition)
      {
         List<Loadometer_Usage> ret = new List<Loadometer_Usage>();
         string sql = "SELECT  Loadometer_ID,Loadometer_Code,Loadometer_Unit,Loadometer_Error,Loadometer_No,Loadometer_Date,Loadometer_Delivery,Loadometer_Receive,Loadometer_Type,Loadometer_iType,Loadometer_Price,Loadometer_Amount,Loadometer_PounderName,Loadometer_Pounder,Loadometer_MName,Loadometer_MCode,Loadometer_Transport,Loadometer_TransportName,Loadometer_Pilot,Loadometer_PilotName,Loadometer_Remark,Stat,UpdateDate,DeleteDate,CreateDate FROM Loadometer_Usage WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Loadometer_Usage loadometer_Usage = new Loadometer_Usage();
            if (dr["Loadometer_ID"] != DBNull.Value) loadometer_Usage.Loadometer_ID = Convert.ToDecimal(dr["Loadometer_ID"]);
            if (dr["Loadometer_Code"] != DBNull.Value) loadometer_Usage.Loadometer_Code = Convert.ToString(dr["Loadometer_Code"]);
            if (dr["Loadometer_Unit"] != DBNull.Value) loadometer_Usage.Loadometer_Unit = Convert.ToString(dr["Loadometer_Unit"]);
            if (dr["Loadometer_Error"] != DBNull.Value) loadometer_Usage.Loadometer_Error = Convert.ToSingle(dr["Loadometer_Error"]);
            if (dr["Loadometer_No"] != DBNull.Value) loadometer_Usage.Loadometer_No = Convert.ToString(dr["Loadometer_No"]);
            if (dr["Loadometer_Date"] != DBNull.Value) loadometer_Usage.Loadometer_Date = Convert.ToDateTime(dr["Loadometer_Date"]);
            if (dr["Loadometer_Delivery"] != DBNull.Value) loadometer_Usage.Loadometer_Delivery = Convert.ToString(dr["Loadometer_Delivery"]);
            if (dr["Loadometer_Receive"] != DBNull.Value) loadometer_Usage.Loadometer_Receive = Convert.ToString(dr["Loadometer_Receive"]);
            if (dr["Loadometer_Type"] != DBNull.Value) loadometer_Usage.Loadometer_Type = Convert.ToString(dr["Loadometer_Type"]);
            if (dr["Loadometer_iType"] != DBNull.Value) loadometer_Usage.Loadometer_iType = Convert.ToString(dr["Loadometer_iType"]);
            if (dr["Loadometer_Price"] != DBNull.Value) loadometer_Usage.Loadometer_Price = Convert.ToDecimal(dr["Loadometer_Price"]);
            if (dr["Loadometer_Amount"] != DBNull.Value) loadometer_Usage.Loadometer_Amount = Convert.ToDecimal(dr["Loadometer_Amount"]);
            if (dr["Loadometer_PounderName"] != DBNull.Value) loadometer_Usage.Loadometer_PounderName = Convert.ToString(dr["Loadometer_PounderName"]);
            if (dr["Loadometer_Pounder"] != DBNull.Value) loadometer_Usage.Loadometer_Pounder = Convert.ToString(dr["Loadometer_Pounder"]);
            if (dr["Loadometer_MName"] != DBNull.Value) loadometer_Usage.Loadometer_MName = Convert.ToString(dr["Loadometer_MName"]);
            if (dr["Loadometer_MCode"] != DBNull.Value) loadometer_Usage.Loadometer_MCode = Convert.ToString(dr["Loadometer_MCode"]);
            if (dr["Loadometer_Transport"] != DBNull.Value) loadometer_Usage.Loadometer_Transport = Convert.ToString(dr["Loadometer_Transport"]);
            if (dr["Loadometer_TransportName"] != DBNull.Value) loadometer_Usage.Loadometer_TransportName = Convert.ToString(dr["Loadometer_TransportName"]);
            if (dr["Loadometer_Pilot"] != DBNull.Value) loadometer_Usage.Loadometer_Pilot = Convert.ToString(dr["Loadometer_Pilot"]);
            if (dr["Loadometer_PilotName"] != DBNull.Value) loadometer_Usage.Loadometer_PilotName = Convert.ToString(dr["Loadometer_PilotName"]);
            if (dr["Loadometer_Remark"] != DBNull.Value) loadometer_Usage.Loadometer_Remark = Convert.ToString(dr["Loadometer_Remark"]);
            if (dr["Stat"] != DBNull.Value) loadometer_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateDate"] != DBNull.Value) loadometer_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) loadometer_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateDate"] != DBNull.Value) loadometer_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            ret.Add(loadometer_Usage);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的地磅计量信息 Loadometer_Usage对象(即:一条记录
      /// </summary>
      public List<Loadometer_Usage> GetAll()
      {
         List<Loadometer_Usage> ret = new List<Loadometer_Usage>();
         string sql = "SELECT  Loadometer_ID,Loadometer_Code,Loadometer_Unit,Loadometer_Error,Loadometer_No,Loadometer_Date,Loadometer_Delivery,Loadometer_Receive,Loadometer_Type,Loadometer_iType,Loadometer_Price,Loadometer_Amount,Loadometer_PounderName,Loadometer_Pounder,Loadometer_MName,Loadometer_MCode,Loadometer_Transport,Loadometer_TransportName,Loadometer_Pilot,Loadometer_PilotName,Loadometer_Remark,Stat,UpdateDate,DeleteDate,CreateDate FROM Loadometer_Usage where 1=1 AND ((Stat is null) or (Stat=0) ) order by Loadometer_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Loadometer_Usage loadometer_Usage = new Loadometer_Usage();
            if (dr["Loadometer_ID"] != DBNull.Value) loadometer_Usage.Loadometer_ID = Convert.ToDecimal(dr["Loadometer_ID"]);
            if (dr["Loadometer_Code"] != DBNull.Value) loadometer_Usage.Loadometer_Code = Convert.ToString(dr["Loadometer_Code"]);
            if (dr["Loadometer_Unit"] != DBNull.Value) loadometer_Usage.Loadometer_Unit = Convert.ToString(dr["Loadometer_Unit"]);
            if (dr["Loadometer_Error"] != DBNull.Value) loadometer_Usage.Loadometer_Error = Convert.ToSingle(dr["Loadometer_Error"]);
            if (dr["Loadometer_No"] != DBNull.Value) loadometer_Usage.Loadometer_No = Convert.ToString(dr["Loadometer_No"]);
            if (dr["Loadometer_Date"] != DBNull.Value) loadometer_Usage.Loadometer_Date = Convert.ToDateTime(dr["Loadometer_Date"]);
            if (dr["Loadometer_Delivery"] != DBNull.Value) loadometer_Usage.Loadometer_Delivery = Convert.ToString(dr["Loadometer_Delivery"]);
            if (dr["Loadometer_Receive"] != DBNull.Value) loadometer_Usage.Loadometer_Receive = Convert.ToString(dr["Loadometer_Receive"]);
            if (dr["Loadometer_Type"] != DBNull.Value) loadometer_Usage.Loadometer_Type = Convert.ToString(dr["Loadometer_Type"]);
            if (dr["Loadometer_iType"] != DBNull.Value) loadometer_Usage.Loadometer_iType = Convert.ToString(dr["Loadometer_iType"]);
            if (dr["Loadometer_Price"] != DBNull.Value) loadometer_Usage.Loadometer_Price = Convert.ToDecimal(dr["Loadometer_Price"]);
            if (dr["Loadometer_Amount"] != DBNull.Value) loadometer_Usage.Loadometer_Amount = Convert.ToDecimal(dr["Loadometer_Amount"]);
            if (dr["Loadometer_PounderName"] != DBNull.Value) loadometer_Usage.Loadometer_PounderName = Convert.ToString(dr["Loadometer_PounderName"]);
            if (dr["Loadometer_Pounder"] != DBNull.Value) loadometer_Usage.Loadometer_Pounder = Convert.ToString(dr["Loadometer_Pounder"]);
            if (dr["Loadometer_MName"] != DBNull.Value) loadometer_Usage.Loadometer_MName = Convert.ToString(dr["Loadometer_MName"]);
            if (dr["Loadometer_MCode"] != DBNull.Value) loadometer_Usage.Loadometer_MCode = Convert.ToString(dr["Loadometer_MCode"]);
            if (dr["Loadometer_Transport"] != DBNull.Value) loadometer_Usage.Loadometer_Transport = Convert.ToString(dr["Loadometer_Transport"]);
            if (dr["Loadometer_TransportName"] != DBNull.Value) loadometer_Usage.Loadometer_TransportName = Convert.ToString(dr["Loadometer_TransportName"]);
            if (dr["Loadometer_Pilot"] != DBNull.Value) loadometer_Usage.Loadometer_Pilot = Convert.ToString(dr["Loadometer_Pilot"]);
            if (dr["Loadometer_PilotName"] != DBNull.Value) loadometer_Usage.Loadometer_PilotName = Convert.ToString(dr["Loadometer_PilotName"]);
            if (dr["Loadometer_Remark"] != DBNull.Value) loadometer_Usage.Loadometer_Remark = Convert.ToString(dr["Loadometer_Remark"]);
            if (dr["Stat"] != DBNull.Value) loadometer_Usage.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateDate"] != DBNull.Value) loadometer_Usage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) loadometer_Usage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateDate"] != DBNull.Value) loadometer_Usage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            ret.Add(loadometer_Usage);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
