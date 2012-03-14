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
   /// 车辆人员安排
   /// </summary>
   [Serializable]
   public partial class ADOPCT_Owner
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加车辆人员安排 PCT_Owner对象(即:一条记录)
      /// </summary>
      public int Add(PCT_Owner pCT_Owner)
      {
         string sql = "INSERT INTO PCT_Owner (PCTO_Code,PCTO_VCode,PCTO_VNo,PCTO_EVCode,PCTO_EName,PCTO_Contact,PCTO_Batch,PCTO_Description,PCTO_BeginDate,PCTO_EndDate,PCTO_iType,PCTO_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PCTO_IsDefault,PCTO_TCode) VALUES (@PCTO_Code,@PCTO_VCode,@PCTO_VNo,@PCTO_EVCode,@PCTO_EName,@PCTO_Contact,@PCTO_Batch,@PCTO_Description,@PCTO_BeginDate,@PCTO_EndDate,@PCTO_iType,@PCTO_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTO_IsDefault,@PCTO_TCode)";
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Code))
         {
            idb.AddParameter("@PCTO_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Code", pCT_Owner.PCTO_Code);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_VCode))
         {
            idb.AddParameter("@PCTO_VCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_VCode", pCT_Owner.PCTO_VCode);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_VNo))
         {
            idb.AddParameter("@PCTO_VNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_VNo", pCT_Owner.PCTO_VNo);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_EVCode))
         {
            idb.AddParameter("@PCTO_EVCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EVCode", pCT_Owner.PCTO_EVCode);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_EName))
         {
            idb.AddParameter("@PCTO_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EName", pCT_Owner.PCTO_EName);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Contact))
         {
            idb.AddParameter("@PCTO_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Contact", pCT_Owner.PCTO_Contact);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Batch))
         {
            idb.AddParameter("@PCTO_Batch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Batch", pCT_Owner.PCTO_Batch);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Description))
         {
            idb.AddParameter("@PCTO_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Description", pCT_Owner.PCTO_Description);
         }
         if (pCT_Owner.PCTO_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTO_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_BeginDate", pCT_Owner.PCTO_BeginDate);
         }
         if (pCT_Owner.PCTO_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTO_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EndDate", pCT_Owner.PCTO_EndDate);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_iType))
         {
            idb.AddParameter("@PCTO_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_iType", pCT_Owner.PCTO_iType);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Remark))
         {
            idb.AddParameter("@PCTO_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Remark", pCT_Owner.PCTO_Remark);
         }
         if (pCT_Owner.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Owner.Stat);
         }
         if (pCT_Owner.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Owner.CreateDate);
         }
         if (pCT_Owner.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Owner.UpdateDate);
         }
         if (pCT_Owner.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Owner.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_IsDefault))
         {
            idb.AddParameter("@PCTO_IsDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_IsDefault", pCT_Owner.PCTO_IsDefault);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_TCode))
         {
            idb.AddParameter("@PCTO_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_TCode", pCT_Owner.PCTO_TCode);
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
      /// 添加车辆人员安排 PCT_Owner对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCT_Owner pCT_Owner)
      {
         string sql = "INSERT INTO PCT_Owner (PCTO_Code,PCTO_VCode,PCTO_VNo,PCTO_EVCode,PCTO_EName,PCTO_Contact,PCTO_Batch,PCTO_Description,PCTO_BeginDate,PCTO_EndDate,PCTO_iType,PCTO_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PCTO_IsDefault,PCTO_TCode) VALUES (@PCTO_Code,@PCTO_VCode,@PCTO_VNo,@PCTO_EVCode,@PCTO_EName,@PCTO_Contact,@PCTO_Batch,@PCTO_Description,@PCTO_BeginDate,@PCTO_EndDate,@PCTO_iType,@PCTO_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTO_IsDefault,@PCTO_TCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Code))
         {
            idb.AddParameter("@PCTO_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Code", pCT_Owner.PCTO_Code);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_VCode))
         {
            idb.AddParameter("@PCTO_VCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_VCode", pCT_Owner.PCTO_VCode);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_VNo))
         {
            idb.AddParameter("@PCTO_VNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_VNo", pCT_Owner.PCTO_VNo);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_EVCode))
         {
            idb.AddParameter("@PCTO_EVCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EVCode", pCT_Owner.PCTO_EVCode);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_EName))
         {
            idb.AddParameter("@PCTO_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EName", pCT_Owner.PCTO_EName);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Contact))
         {
            idb.AddParameter("@PCTO_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Contact", pCT_Owner.PCTO_Contact);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Batch))
         {
            idb.AddParameter("@PCTO_Batch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Batch", pCT_Owner.PCTO_Batch);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Description))
         {
            idb.AddParameter("@PCTO_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Description", pCT_Owner.PCTO_Description);
         }
         if (pCT_Owner.PCTO_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTO_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_BeginDate", pCT_Owner.PCTO_BeginDate);
         }
         if (pCT_Owner.PCTO_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTO_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EndDate", pCT_Owner.PCTO_EndDate);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_iType))
         {
            idb.AddParameter("@PCTO_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_iType", pCT_Owner.PCTO_iType);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Remark))
         {
            idb.AddParameter("@PCTO_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Remark", pCT_Owner.PCTO_Remark);
         }
         if (pCT_Owner.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Owner.Stat);
         }
         if (pCT_Owner.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Owner.CreateDate);
         }
         if (pCT_Owner.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Owner.UpdateDate);
         }
         if (pCT_Owner.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Owner.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_IsDefault))
         {
            idb.AddParameter("@PCTO_IsDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_IsDefault", pCT_Owner.PCTO_IsDefault);
         }
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_TCode))
         {
            idb.AddParameter("@PCTO_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_TCode", pCT_Owner.PCTO_TCode);
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
      /// 更新车辆人员安排 PCT_Owner对象(即:一条记录
      /// </summary>
      public int Update(PCT_Owner pCT_Owner)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCT_Owner       SET ");
            if(pCT_Owner.PCTO_Code_IsChanged){sbParameter.Append("PCTO_Code=@PCTO_Code, ");}
      if(pCT_Owner.PCTO_VCode_IsChanged){sbParameter.Append("PCTO_VCode=@PCTO_VCode, ");}
      if(pCT_Owner.PCTO_VNo_IsChanged){sbParameter.Append("PCTO_VNo=@PCTO_VNo, ");}
      if(pCT_Owner.PCTO_EVCode_IsChanged){sbParameter.Append("PCTO_EVCode=@PCTO_EVCode, ");}
      if(pCT_Owner.PCTO_EName_IsChanged){sbParameter.Append("PCTO_EName=@PCTO_EName, ");}
      if(pCT_Owner.PCTO_Contact_IsChanged){sbParameter.Append("PCTO_Contact=@PCTO_Contact, ");}
      if(pCT_Owner.PCTO_Batch_IsChanged){sbParameter.Append("PCTO_Batch=@PCTO_Batch, ");}
      if(pCT_Owner.PCTO_Description_IsChanged){sbParameter.Append("PCTO_Description=@PCTO_Description, ");}
      if(pCT_Owner.PCTO_BeginDate_IsChanged){sbParameter.Append("PCTO_BeginDate=@PCTO_BeginDate, ");}
      if(pCT_Owner.PCTO_EndDate_IsChanged){sbParameter.Append("PCTO_EndDate=@PCTO_EndDate, ");}
      if(pCT_Owner.PCTO_iType_IsChanged){sbParameter.Append("PCTO_iType=@PCTO_iType, ");}
      if(pCT_Owner.PCTO_Remark_IsChanged){sbParameter.Append("PCTO_Remark=@PCTO_Remark, ");}
      if(pCT_Owner.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCT_Owner.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCT_Owner.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCT_Owner.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pCT_Owner.PCTO_IsDefault_IsChanged){sbParameter.Append("PCTO_IsDefault=@PCTO_IsDefault, ");}
      if(pCT_Owner.PCTO_TCode_IsChanged){sbParameter.Append("PCTO_TCode=@PCTO_TCode ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCTO_ID=@PCTO_ID; " );
      string sql=sb.ToString();
         if(pCT_Owner.PCTO_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Code))
         {
            idb.AddParameter("@PCTO_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Code", pCT_Owner.PCTO_Code);
         }
          }
         if(pCT_Owner.PCTO_VCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_VCode))
         {
            idb.AddParameter("@PCTO_VCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_VCode", pCT_Owner.PCTO_VCode);
         }
          }
         if(pCT_Owner.PCTO_VNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_VNo))
         {
            idb.AddParameter("@PCTO_VNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_VNo", pCT_Owner.PCTO_VNo);
         }
          }
         if(pCT_Owner.PCTO_EVCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_EVCode))
         {
            idb.AddParameter("@PCTO_EVCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EVCode", pCT_Owner.PCTO_EVCode);
         }
          }
         if(pCT_Owner.PCTO_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_EName))
         {
            idb.AddParameter("@PCTO_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EName", pCT_Owner.PCTO_EName);
         }
          }
         if(pCT_Owner.PCTO_Contact_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Contact))
         {
            idb.AddParameter("@PCTO_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Contact", pCT_Owner.PCTO_Contact);
         }
          }
         if(pCT_Owner.PCTO_Batch_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Batch))
         {
            idb.AddParameter("@PCTO_Batch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Batch", pCT_Owner.PCTO_Batch);
         }
          }
         if(pCT_Owner.PCTO_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Description))
         {
            idb.AddParameter("@PCTO_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Description", pCT_Owner.PCTO_Description);
         }
          }
         if(pCT_Owner.PCTO_BeginDate_IsChanged)
         {
         if (pCT_Owner.PCTO_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTO_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_BeginDate", pCT_Owner.PCTO_BeginDate);
         }
          }
         if(pCT_Owner.PCTO_EndDate_IsChanged)
         {
         if (pCT_Owner.PCTO_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTO_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_EndDate", pCT_Owner.PCTO_EndDate);
         }
          }
         if(pCT_Owner.PCTO_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_iType))
         {
            idb.AddParameter("@PCTO_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_iType", pCT_Owner.PCTO_iType);
         }
          }
         if(pCT_Owner.PCTO_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_Remark))
         {
            idb.AddParameter("@PCTO_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_Remark", pCT_Owner.PCTO_Remark);
         }
          }
         if(pCT_Owner.Stat_IsChanged)
         {
         if (pCT_Owner.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Owner.Stat);
         }
          }
         if(pCT_Owner.CreateDate_IsChanged)
         {
         if (pCT_Owner.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Owner.CreateDate);
         }
          }
         if(pCT_Owner.UpdateDate_IsChanged)
         {
         if (pCT_Owner.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Owner.UpdateDate);
         }
          }
         if(pCT_Owner.DeleteDate_IsChanged)
         {
         if (pCT_Owner.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Owner.DeleteDate);
         }
          }
         if(pCT_Owner.PCTO_IsDefault_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_IsDefault))
         {
            idb.AddParameter("@PCTO_IsDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_IsDefault", pCT_Owner.PCTO_IsDefault);
         }
          }
         if(pCT_Owner.PCTO_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Owner.PCTO_TCode))
         {
            idb.AddParameter("@PCTO_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTO_TCode", pCT_Owner.PCTO_TCode);
         }
          }

         idb.AddParameter("@PCTO_ID", pCT_Owner.PCTO_ID);

           
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
      /// 删除车辆人员安排 PCT_Owner对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCTO_ID)
      {
         string sql = "DELETE PCT_Owner WHERE 1=1  AND PCTO_ID=@PCTO_ID ";
         idb.AddParameter("@PCTO_ID", pCTO_ID);

           
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
      /// 获取指定的车辆人员安排 PCT_Owner对象(即:一条记录
      /// </summary>
      public PCT_Owner GetByKey(decimal pCTO_ID)
      {
         PCT_Owner pCT_Owner = new PCT_Owner();
         string sql = "SELECT  PCTO_ID,PCTO_Code,PCTO_VCode,PCTO_VNo,PCTO_EVCode,PCTO_EName,PCTO_Contact,PCTO_Batch,PCTO_Description,PCTO_BeginDate,PCTO_EndDate,PCTO_iType,PCTO_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PCTO_IsDefault,PCTO_TCode FROM PCT_Owner WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCTO_ID=@PCTO_ID ";
         idb.AddParameter("@PCTO_ID", pCTO_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCTO_ID"] != DBNull.Value) pCT_Owner.PCTO_ID = Convert.ToDecimal(dr["PCTO_ID"]);
            if (dr["PCTO_Code"] != DBNull.Value) pCT_Owner.PCTO_Code = Convert.ToString(dr["PCTO_Code"]);
            if (dr["PCTO_VCode"] != DBNull.Value) pCT_Owner.PCTO_VCode = Convert.ToString(dr["PCTO_VCode"]);
            if (dr["PCTO_VNo"] != DBNull.Value) pCT_Owner.PCTO_VNo = Convert.ToString(dr["PCTO_VNo"]);
            if (dr["PCTO_EVCode"] != DBNull.Value) pCT_Owner.PCTO_EVCode = Convert.ToString(dr["PCTO_EVCode"]);
            if (dr["PCTO_EName"] != DBNull.Value) pCT_Owner.PCTO_EName = Convert.ToString(dr["PCTO_EName"]);
            if (dr["PCTO_Contact"] != DBNull.Value) pCT_Owner.PCTO_Contact = Convert.ToString(dr["PCTO_Contact"]);
            if (dr["PCTO_Batch"] != DBNull.Value) pCT_Owner.PCTO_Batch = Convert.ToString(dr["PCTO_Batch"]);
            if (dr["PCTO_Description"] != DBNull.Value) pCT_Owner.PCTO_Description = Convert.ToString(dr["PCTO_Description"]);
            if (dr["PCTO_BeginDate"] != DBNull.Value) pCT_Owner.PCTO_BeginDate = Convert.ToDateTime(dr["PCTO_BeginDate"]);
            if (dr["PCTO_EndDate"] != DBNull.Value) pCT_Owner.PCTO_EndDate = Convert.ToDateTime(dr["PCTO_EndDate"]);
            if (dr["PCTO_iType"] != DBNull.Value) pCT_Owner.PCTO_iType = Convert.ToString(dr["PCTO_iType"]);
            if (dr["PCTO_Remark"] != DBNull.Value) pCT_Owner.PCTO_Remark = Convert.ToString(dr["PCTO_Remark"]);
            if (dr["Stat"] != DBNull.Value) pCT_Owner.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Owner.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Owner.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Owner.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTO_IsDefault"] != DBNull.Value) pCT_Owner.PCTO_IsDefault = Convert.ToString(dr["PCTO_IsDefault"]);
            if (dr["PCTO_TCode"] != DBNull.Value) pCT_Owner.PCTO_TCode = Convert.ToString(dr["PCTO_TCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCT_Owner;
      }
      /// <summary>
      /// 获取指定的车辆人员安排 PCT_Owner对象集合
      /// </summary>
      public List<PCT_Owner> GetListByWhere(string strCondition)
      {
         List<PCT_Owner> ret = new List<PCT_Owner>();
         string sql = "SELECT  PCTO_ID,PCTO_Code,PCTO_VCode,PCTO_VNo,PCTO_EVCode,PCTO_EName,PCTO_Contact,PCTO_Batch,PCTO_Description,PCTO_BeginDate,PCTO_EndDate,PCTO_iType,PCTO_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PCTO_IsDefault,PCTO_TCode FROM PCT_Owner WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCT_Owner pCT_Owner = new PCT_Owner();
            if (dr["PCTO_ID"] != DBNull.Value) pCT_Owner.PCTO_ID = Convert.ToDecimal(dr["PCTO_ID"]);
            if (dr["PCTO_Code"] != DBNull.Value) pCT_Owner.PCTO_Code = Convert.ToString(dr["PCTO_Code"]);
            if (dr["PCTO_VCode"] != DBNull.Value) pCT_Owner.PCTO_VCode = Convert.ToString(dr["PCTO_VCode"]);
            if (dr["PCTO_VNo"] != DBNull.Value) pCT_Owner.PCTO_VNo = Convert.ToString(dr["PCTO_VNo"]);
            if (dr["PCTO_EVCode"] != DBNull.Value) pCT_Owner.PCTO_EVCode = Convert.ToString(dr["PCTO_EVCode"]);
            if (dr["PCTO_EName"] != DBNull.Value) pCT_Owner.PCTO_EName = Convert.ToString(dr["PCTO_EName"]);
            if (dr["PCTO_Contact"] != DBNull.Value) pCT_Owner.PCTO_Contact = Convert.ToString(dr["PCTO_Contact"]);
            if (dr["PCTO_Batch"] != DBNull.Value) pCT_Owner.PCTO_Batch = Convert.ToString(dr["PCTO_Batch"]);
            if (dr["PCTO_Description"] != DBNull.Value) pCT_Owner.PCTO_Description = Convert.ToString(dr["PCTO_Description"]);
            if (dr["PCTO_BeginDate"] != DBNull.Value) pCT_Owner.PCTO_BeginDate = Convert.ToDateTime(dr["PCTO_BeginDate"]);
            if (dr["PCTO_EndDate"] != DBNull.Value) pCT_Owner.PCTO_EndDate = Convert.ToDateTime(dr["PCTO_EndDate"]);
            if (dr["PCTO_iType"] != DBNull.Value) pCT_Owner.PCTO_iType = Convert.ToString(dr["PCTO_iType"]);
            if (dr["PCTO_Remark"] != DBNull.Value) pCT_Owner.PCTO_Remark = Convert.ToString(dr["PCTO_Remark"]);
            if (dr["Stat"] != DBNull.Value) pCT_Owner.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Owner.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Owner.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Owner.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTO_IsDefault"] != DBNull.Value) pCT_Owner.PCTO_IsDefault = Convert.ToString(dr["PCTO_IsDefault"]);
            if (dr["PCTO_TCode"] != DBNull.Value) pCT_Owner.PCTO_TCode = Convert.ToString(dr["PCTO_TCode"]);
            ret.Add(pCT_Owner);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆人员安排 PCT_Owner对象(即:一条记录
      /// </summary>
      public List<PCT_Owner> GetAll()
      {
         List<PCT_Owner> ret = new List<PCT_Owner>();
         string sql = "SELECT  PCTO_ID,PCTO_Code,PCTO_VCode,PCTO_VNo,PCTO_EVCode,PCTO_EName,PCTO_Contact,PCTO_Batch,PCTO_Description,PCTO_BeginDate,PCTO_EndDate,PCTO_iType,PCTO_Remark,Stat,CreateDate,UpdateDate,DeleteDate,PCTO_IsDefault,PCTO_TCode FROM PCT_Owner where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCTO_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCT_Owner pCT_Owner = new PCT_Owner();
            if (dr["PCTO_ID"] != DBNull.Value) pCT_Owner.PCTO_ID = Convert.ToDecimal(dr["PCTO_ID"]);
            if (dr["PCTO_Code"] != DBNull.Value) pCT_Owner.PCTO_Code = Convert.ToString(dr["PCTO_Code"]);
            if (dr["PCTO_VCode"] != DBNull.Value) pCT_Owner.PCTO_VCode = Convert.ToString(dr["PCTO_VCode"]);
            if (dr["PCTO_VNo"] != DBNull.Value) pCT_Owner.PCTO_VNo = Convert.ToString(dr["PCTO_VNo"]);
            if (dr["PCTO_EVCode"] != DBNull.Value) pCT_Owner.PCTO_EVCode = Convert.ToString(dr["PCTO_EVCode"]);
            if (dr["PCTO_EName"] != DBNull.Value) pCT_Owner.PCTO_EName = Convert.ToString(dr["PCTO_EName"]);
            if (dr["PCTO_Contact"] != DBNull.Value) pCT_Owner.PCTO_Contact = Convert.ToString(dr["PCTO_Contact"]);
            if (dr["PCTO_Batch"] != DBNull.Value) pCT_Owner.PCTO_Batch = Convert.ToString(dr["PCTO_Batch"]);
            if (dr["PCTO_Description"] != DBNull.Value) pCT_Owner.PCTO_Description = Convert.ToString(dr["PCTO_Description"]);
            if (dr["PCTO_BeginDate"] != DBNull.Value) pCT_Owner.PCTO_BeginDate = Convert.ToDateTime(dr["PCTO_BeginDate"]);
            if (dr["PCTO_EndDate"] != DBNull.Value) pCT_Owner.PCTO_EndDate = Convert.ToDateTime(dr["PCTO_EndDate"]);
            if (dr["PCTO_iType"] != DBNull.Value) pCT_Owner.PCTO_iType = Convert.ToString(dr["PCTO_iType"]);
            if (dr["PCTO_Remark"] != DBNull.Value) pCT_Owner.PCTO_Remark = Convert.ToString(dr["PCTO_Remark"]);
            if (dr["Stat"] != DBNull.Value) pCT_Owner.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Owner.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Owner.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Owner.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTO_IsDefault"] != DBNull.Value) pCT_Owner.PCTO_IsDefault = Convert.ToString(dr["PCTO_IsDefault"]);
            if (dr["PCTO_TCode"] != DBNull.Value) pCT_Owner.PCTO_TCode = Convert.ToString(dr["PCTO_TCode"]);
            ret.Add(pCT_Owner);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
