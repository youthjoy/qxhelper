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
   /// 费用交纳明细(环保费用，其他费用)
   /// </summary>
   [Serializable]
   public partial class ADOOther_Cost
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加费用交纳明细(环保费用，其他费用) Other_Cost对象(即:一条记录)
      /// </summary>
      public int Add(Other_Cost other_Cost)
      {
         string sql = "INSERT INTO Other_Cost (OtherCost_Code,OtherCost_Money,OtherCost_Date,OtherCost_Type,OtherCost_Remark,OtherCost_Usage,OtherCost_Company,OtherCost_Dept,OtherCost_BeginDate,OtherCost_EndDate,OtherCost_Operator,OtherCost_OpDate,OtherCost_Auditor,OtherCost_AuditDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@OtherCost_Code,@OtherCost_Money,@OtherCost_Date,@OtherCost_Type,@OtherCost_Remark,@OtherCost_Usage,@OtherCost_Company,@OtherCost_Dept,@OtherCost_BeginDate,@OtherCost_EndDate,@OtherCost_Operator,@OtherCost_OpDate,@OtherCost_Auditor,@OtherCost_AuditDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Code))
         {
            idb.AddParameter("@OtherCost_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Code", other_Cost.OtherCost_Code);
         }
         if (other_Cost.OtherCost_Money == 0)
         {
            idb.AddParameter("@OtherCost_Money", 0);
         }
         else
         {
            idb.AddParameter("@OtherCost_Money", other_Cost.OtherCost_Money);
         }
         if (other_Cost.OtherCost_Date == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Date", other_Cost.OtherCost_Date);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Type))
         {
            idb.AddParameter("@OtherCost_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Type", other_Cost.OtherCost_Type);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Remark))
         {
            idb.AddParameter("@OtherCost_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Remark", other_Cost.OtherCost_Remark);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Usage))
         {
            idb.AddParameter("@OtherCost_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Usage", other_Cost.OtherCost_Usage);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Company))
         {
            idb.AddParameter("@OtherCost_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Company", other_Cost.OtherCost_Company);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Dept))
         {
            idb.AddParameter("@OtherCost_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Dept", other_Cost.OtherCost_Dept);
         }
         if (other_Cost.OtherCost_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_BeginDate", other_Cost.OtherCost_BeginDate);
         }
         if (other_Cost.OtherCost_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_EndDate", other_Cost.OtherCost_EndDate);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Operator))
         {
            idb.AddParameter("@OtherCost_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Operator", other_Cost.OtherCost_Operator);
         }
         if (other_Cost.OtherCost_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_OpDate", other_Cost.OtherCost_OpDate);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Auditor))
         {
            idb.AddParameter("@OtherCost_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Auditor", other_Cost.OtherCost_Auditor);
         }
         if (other_Cost.OtherCost_AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_AuditDate", other_Cost.OtherCost_AuditDate);
         }
         if (other_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", other_Cost.Stat);
         }
         if (other_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", other_Cost.CreateDate);
         }
         if (other_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", other_Cost.UpdateDate);
         }
         if (other_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", other_Cost.DeleteDate);
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
      /// 添加费用交纳明细(环保费用，其他费用) Other_Cost对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Other_Cost other_Cost)
      {
         string sql = "INSERT INTO Other_Cost (OtherCost_Code,OtherCost_Money,OtherCost_Date,OtherCost_Type,OtherCost_Remark,OtherCost_Usage,OtherCost_Company,OtherCost_Dept,OtherCost_BeginDate,OtherCost_EndDate,OtherCost_Operator,OtherCost_OpDate,OtherCost_Auditor,OtherCost_AuditDate,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@OtherCost_Code,@OtherCost_Money,@OtherCost_Date,@OtherCost_Type,@OtherCost_Remark,@OtherCost_Usage,@OtherCost_Company,@OtherCost_Dept,@OtherCost_BeginDate,@OtherCost_EndDate,@OtherCost_Operator,@OtherCost_OpDate,@OtherCost_Auditor,@OtherCost_AuditDate,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Code))
         {
            idb.AddParameter("@OtherCost_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Code", other_Cost.OtherCost_Code);
         }
         if (other_Cost.OtherCost_Money == 0)
         {
            idb.AddParameter("@OtherCost_Money", 0);
         }
         else
         {
            idb.AddParameter("@OtherCost_Money", other_Cost.OtherCost_Money);
         }
         if (other_Cost.OtherCost_Date == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Date", other_Cost.OtherCost_Date);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Type))
         {
            idb.AddParameter("@OtherCost_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Type", other_Cost.OtherCost_Type);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Remark))
         {
            idb.AddParameter("@OtherCost_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Remark", other_Cost.OtherCost_Remark);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Usage))
         {
            idb.AddParameter("@OtherCost_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Usage", other_Cost.OtherCost_Usage);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Company))
         {
            idb.AddParameter("@OtherCost_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Company", other_Cost.OtherCost_Company);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Dept))
         {
            idb.AddParameter("@OtherCost_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Dept", other_Cost.OtherCost_Dept);
         }
         if (other_Cost.OtherCost_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_BeginDate", other_Cost.OtherCost_BeginDate);
         }
         if (other_Cost.OtherCost_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_EndDate", other_Cost.OtherCost_EndDate);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Operator))
         {
            idb.AddParameter("@OtherCost_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Operator", other_Cost.OtherCost_Operator);
         }
         if (other_Cost.OtherCost_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_OpDate", other_Cost.OtherCost_OpDate);
         }
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Auditor))
         {
            idb.AddParameter("@OtherCost_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Auditor", other_Cost.OtherCost_Auditor);
         }
         if (other_Cost.OtherCost_AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_AuditDate", other_Cost.OtherCost_AuditDate);
         }
         if (other_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", other_Cost.Stat);
         }
         if (other_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", other_Cost.CreateDate);
         }
         if (other_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", other_Cost.UpdateDate);
         }
         if (other_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", other_Cost.DeleteDate);
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
      /// 更新费用交纳明细(环保费用，其他费用) Other_Cost对象(即:一条记录
      /// </summary>
      public int Update(Other_Cost other_Cost)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Other_Cost       SET ");
            if(other_Cost.OtherCost_Code_IsChanged){sbParameter.Append("OtherCost_Code=@OtherCost_Code, ");}
      if(other_Cost.OtherCost_Money_IsChanged){sbParameter.Append("OtherCost_Money=@OtherCost_Money, ");}
      if(other_Cost.OtherCost_Date_IsChanged){sbParameter.Append("OtherCost_Date=@OtherCost_Date, ");}
      if(other_Cost.OtherCost_Type_IsChanged){sbParameter.Append("OtherCost_Type=@OtherCost_Type, ");}
      if(other_Cost.OtherCost_Remark_IsChanged){sbParameter.Append("OtherCost_Remark=@OtherCost_Remark, ");}
      if(other_Cost.OtherCost_Usage_IsChanged){sbParameter.Append("OtherCost_Usage=@OtherCost_Usage, ");}
      if(other_Cost.OtherCost_Company_IsChanged){sbParameter.Append("OtherCost_Company=@OtherCost_Company, ");}
      if(other_Cost.OtherCost_Dept_IsChanged){sbParameter.Append("OtherCost_Dept=@OtherCost_Dept, ");}
      if(other_Cost.OtherCost_BeginDate_IsChanged){sbParameter.Append("OtherCost_BeginDate=@OtherCost_BeginDate, ");}
      if(other_Cost.OtherCost_EndDate_IsChanged){sbParameter.Append("OtherCost_EndDate=@OtherCost_EndDate, ");}
      if(other_Cost.OtherCost_Operator_IsChanged){sbParameter.Append("OtherCost_Operator=@OtherCost_Operator, ");}
      if(other_Cost.OtherCost_OpDate_IsChanged){sbParameter.Append("OtherCost_OpDate=@OtherCost_OpDate, ");}
      if(other_Cost.OtherCost_Auditor_IsChanged){sbParameter.Append("OtherCost_Auditor=@OtherCost_Auditor, ");}
      if(other_Cost.OtherCost_AuditDate_IsChanged){sbParameter.Append("OtherCost_AuditDate=@OtherCost_AuditDate, ");}
      if(other_Cost.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(other_Cost.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(other_Cost.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(other_Cost.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and OtherCost_ID=@OtherCost_ID; " );
      string sql=sb.ToString();
         if(other_Cost.OtherCost_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Code))
         {
            idb.AddParameter("@OtherCost_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Code", other_Cost.OtherCost_Code);
         }
          }
         if(other_Cost.OtherCost_Money_IsChanged)
         {
         if (other_Cost.OtherCost_Money == 0)
         {
            idb.AddParameter("@OtherCost_Money", 0);
         }
         else
         {
            idb.AddParameter("@OtherCost_Money", other_Cost.OtherCost_Money);
         }
          }
         if(other_Cost.OtherCost_Date_IsChanged)
         {
         if (other_Cost.OtherCost_Date == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Date", other_Cost.OtherCost_Date);
         }
          }
         if(other_Cost.OtherCost_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Type))
         {
            idb.AddParameter("@OtherCost_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Type", other_Cost.OtherCost_Type);
         }
          }
         if(other_Cost.OtherCost_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Remark))
         {
            idb.AddParameter("@OtherCost_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Remark", other_Cost.OtherCost_Remark);
         }
          }
         if(other_Cost.OtherCost_Usage_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Usage))
         {
            idb.AddParameter("@OtherCost_Usage", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Usage", other_Cost.OtherCost_Usage);
         }
          }
         if(other_Cost.OtherCost_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Company))
         {
            idb.AddParameter("@OtherCost_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Company", other_Cost.OtherCost_Company);
         }
          }
         if(other_Cost.OtherCost_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Dept))
         {
            idb.AddParameter("@OtherCost_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Dept", other_Cost.OtherCost_Dept);
         }
          }
         if(other_Cost.OtherCost_BeginDate_IsChanged)
         {
         if (other_Cost.OtherCost_BeginDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_BeginDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_BeginDate", other_Cost.OtherCost_BeginDate);
         }
          }
         if(other_Cost.OtherCost_EndDate_IsChanged)
         {
         if (other_Cost.OtherCost_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_EndDate", other_Cost.OtherCost_EndDate);
         }
          }
         if(other_Cost.OtherCost_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Operator))
         {
            idb.AddParameter("@OtherCost_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Operator", other_Cost.OtherCost_Operator);
         }
          }
         if(other_Cost.OtherCost_OpDate_IsChanged)
         {
         if (other_Cost.OtherCost_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_OpDate", other_Cost.OtherCost_OpDate);
         }
          }
         if(other_Cost.OtherCost_Auditor_IsChanged)
         {
         if (string.IsNullOrEmpty(other_Cost.OtherCost_Auditor))
         {
            idb.AddParameter("@OtherCost_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_Auditor", other_Cost.OtherCost_Auditor);
         }
          }
         if(other_Cost.OtherCost_AuditDate_IsChanged)
         {
         if (other_Cost.OtherCost_AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@OtherCost_AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OtherCost_AuditDate", other_Cost.OtherCost_AuditDate);
         }
          }
         if(other_Cost.Stat_IsChanged)
         {
         if (other_Cost.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", other_Cost.Stat);
         }
          }
         if(other_Cost.CreateDate_IsChanged)
         {
         if (other_Cost.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", other_Cost.CreateDate);
         }
          }
         if(other_Cost.UpdateDate_IsChanged)
         {
         if (other_Cost.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", other_Cost.UpdateDate);
         }
          }
         if(other_Cost.DeleteDate_IsChanged)
         {
         if (other_Cost.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", other_Cost.DeleteDate);
         }
          }

         idb.AddParameter("@OtherCost_ID", other_Cost.OtherCost_ID);

           
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
      /// 删除费用交纳明细(环保费用，其他费用) Other_Cost对象(即:一条记录
      /// </summary>
      public int Delete(decimal otherCost_ID)
      {
         string sql = "DELETE Other_Cost WHERE 1=1  AND OtherCost_ID=@OtherCost_ID ";
         idb.AddParameter("@OtherCost_ID", otherCost_ID);

           
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
      /// 获取指定的费用交纳明细(环保费用，其他费用) Other_Cost对象(即:一条记录
      /// </summary>
      public Other_Cost GetByKey(decimal otherCost_ID)
      {
         Other_Cost other_Cost = new Other_Cost();
         string sql = "SELECT  OtherCost_ID,OtherCost_Code,OtherCost_Money,OtherCost_Date,OtherCost_Type,OtherCost_Remark,OtherCost_Usage,OtherCost_Company,OtherCost_Dept,OtherCost_BeginDate,OtherCost_EndDate,OtherCost_Operator,OtherCost_OpDate,OtherCost_Auditor,OtherCost_AuditDate,Stat,CreateDate,UpdateDate,DeleteDate FROM Other_Cost WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND OtherCost_ID=@OtherCost_ID ";
         idb.AddParameter("@OtherCost_ID", otherCost_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["OtherCost_ID"] != DBNull.Value) other_Cost.OtherCost_ID = Convert.ToDecimal(dr["OtherCost_ID"]);
            if (dr["OtherCost_Code"] != DBNull.Value) other_Cost.OtherCost_Code = Convert.ToString(dr["OtherCost_Code"]);
            if (dr["OtherCost_Money"] != DBNull.Value) other_Cost.OtherCost_Money = Convert.ToDecimal(dr["OtherCost_Money"]);
            if (dr["OtherCost_Date"] != DBNull.Value) other_Cost.OtherCost_Date = Convert.ToDateTime(dr["OtherCost_Date"]);
            if (dr["OtherCost_Type"] != DBNull.Value) other_Cost.OtherCost_Type = Convert.ToString(dr["OtherCost_Type"]);
            if (dr["OtherCost_Remark"] != DBNull.Value) other_Cost.OtherCost_Remark = Convert.ToString(dr["OtherCost_Remark"]);
            if (dr["OtherCost_Usage"] != DBNull.Value) other_Cost.OtherCost_Usage = Convert.ToString(dr["OtherCost_Usage"]);
            if (dr["OtherCost_Company"] != DBNull.Value) other_Cost.OtherCost_Company = Convert.ToString(dr["OtherCost_Company"]);
            if (dr["OtherCost_Dept"] != DBNull.Value) other_Cost.OtherCost_Dept = Convert.ToString(dr["OtherCost_Dept"]);
            if (dr["OtherCost_BeginDate"] != DBNull.Value) other_Cost.OtherCost_BeginDate = Convert.ToDateTime(dr["OtherCost_BeginDate"]);
            if (dr["OtherCost_EndDate"] != DBNull.Value) other_Cost.OtherCost_EndDate = Convert.ToDateTime(dr["OtherCost_EndDate"]);
            if (dr["OtherCost_Operator"] != DBNull.Value) other_Cost.OtherCost_Operator = Convert.ToString(dr["OtherCost_Operator"]);
            if (dr["OtherCost_OpDate"] != DBNull.Value) other_Cost.OtherCost_OpDate = Convert.ToDateTime(dr["OtherCost_OpDate"]);
            if (dr["OtherCost_Auditor"] != DBNull.Value) other_Cost.OtherCost_Auditor = Convert.ToString(dr["OtherCost_Auditor"]);
            if (dr["OtherCost_AuditDate"] != DBNull.Value) other_Cost.OtherCost_AuditDate = Convert.ToDateTime(dr["OtherCost_AuditDate"]);
            if (dr["Stat"] != DBNull.Value) other_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) other_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) other_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) other_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return other_Cost;
      }
      /// <summary>
      /// 获取指定的费用交纳明细(环保费用，其他费用) Other_Cost对象集合
      /// </summary>
      public List<Other_Cost> GetListByWhere(string strCondition)
      {
         List<Other_Cost> ret = new List<Other_Cost>();
         string sql = "SELECT  OtherCost_ID,OtherCost_Code,OtherCost_Money,OtherCost_Date,OtherCost_Type,OtherCost_Remark,OtherCost_Usage,OtherCost_Company,OtherCost_Dept,OtherCost_BeginDate,OtherCost_EndDate,OtherCost_Operator,OtherCost_OpDate,OtherCost_Auditor,OtherCost_AuditDate,Stat,CreateDate,UpdateDate,DeleteDate FROM Other_Cost WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Other_Cost other_Cost = new Other_Cost();
            if (dr["OtherCost_ID"] != DBNull.Value) other_Cost.OtherCost_ID = Convert.ToDecimal(dr["OtherCost_ID"]);
            if (dr["OtherCost_Code"] != DBNull.Value) other_Cost.OtherCost_Code = Convert.ToString(dr["OtherCost_Code"]);
            if (dr["OtherCost_Money"] != DBNull.Value) other_Cost.OtherCost_Money = Convert.ToDecimal(dr["OtherCost_Money"]);
            if (dr["OtherCost_Date"] != DBNull.Value) other_Cost.OtherCost_Date = Convert.ToDateTime(dr["OtherCost_Date"]);
            if (dr["OtherCost_Type"] != DBNull.Value) other_Cost.OtherCost_Type = Convert.ToString(dr["OtherCost_Type"]);
            if (dr["OtherCost_Remark"] != DBNull.Value) other_Cost.OtherCost_Remark = Convert.ToString(dr["OtherCost_Remark"]);
            if (dr["OtherCost_Usage"] != DBNull.Value) other_Cost.OtherCost_Usage = Convert.ToString(dr["OtherCost_Usage"]);
            if (dr["OtherCost_Company"] != DBNull.Value) other_Cost.OtherCost_Company = Convert.ToString(dr["OtherCost_Company"]);
            if (dr["OtherCost_Dept"] != DBNull.Value) other_Cost.OtherCost_Dept = Convert.ToString(dr["OtherCost_Dept"]);
            if (dr["OtherCost_BeginDate"] != DBNull.Value) other_Cost.OtherCost_BeginDate = Convert.ToDateTime(dr["OtherCost_BeginDate"]);
            if (dr["OtherCost_EndDate"] != DBNull.Value) other_Cost.OtherCost_EndDate = Convert.ToDateTime(dr["OtherCost_EndDate"]);
            if (dr["OtherCost_Operator"] != DBNull.Value) other_Cost.OtherCost_Operator = Convert.ToString(dr["OtherCost_Operator"]);
            if (dr["OtherCost_OpDate"] != DBNull.Value) other_Cost.OtherCost_OpDate = Convert.ToDateTime(dr["OtherCost_OpDate"]);
            if (dr["OtherCost_Auditor"] != DBNull.Value) other_Cost.OtherCost_Auditor = Convert.ToString(dr["OtherCost_Auditor"]);
            if (dr["OtherCost_AuditDate"] != DBNull.Value) other_Cost.OtherCost_AuditDate = Convert.ToDateTime(dr["OtherCost_AuditDate"]);
            if (dr["Stat"] != DBNull.Value) other_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) other_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) other_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) other_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(other_Cost);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的费用交纳明细(环保费用，其他费用) Other_Cost对象(即:一条记录
      /// </summary>
      public List<Other_Cost> GetAll()
      {
         List<Other_Cost> ret = new List<Other_Cost>();
         string sql = "SELECT  OtherCost_ID,OtherCost_Code,OtherCost_Money,OtherCost_Date,OtherCost_Type,OtherCost_Remark,OtherCost_Usage,OtherCost_Company,OtherCost_Dept,OtherCost_BeginDate,OtherCost_EndDate,OtherCost_Operator,OtherCost_OpDate,OtherCost_Auditor,OtherCost_AuditDate,Stat,CreateDate,UpdateDate,DeleteDate FROM Other_Cost where 1=1 AND ((Stat is null) or (Stat=0) ) order by OtherCost_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Other_Cost other_Cost = new Other_Cost();
            if (dr["OtherCost_ID"] != DBNull.Value) other_Cost.OtherCost_ID = Convert.ToDecimal(dr["OtherCost_ID"]);
            if (dr["OtherCost_Code"] != DBNull.Value) other_Cost.OtherCost_Code = Convert.ToString(dr["OtherCost_Code"]);
            if (dr["OtherCost_Money"] != DBNull.Value) other_Cost.OtherCost_Money = Convert.ToDecimal(dr["OtherCost_Money"]);
            if (dr["OtherCost_Date"] != DBNull.Value) other_Cost.OtherCost_Date = Convert.ToDateTime(dr["OtherCost_Date"]);
            if (dr["OtherCost_Type"] != DBNull.Value) other_Cost.OtherCost_Type = Convert.ToString(dr["OtherCost_Type"]);
            if (dr["OtherCost_Remark"] != DBNull.Value) other_Cost.OtherCost_Remark = Convert.ToString(dr["OtherCost_Remark"]);
            if (dr["OtherCost_Usage"] != DBNull.Value) other_Cost.OtherCost_Usage = Convert.ToString(dr["OtherCost_Usage"]);
            if (dr["OtherCost_Company"] != DBNull.Value) other_Cost.OtherCost_Company = Convert.ToString(dr["OtherCost_Company"]);
            if (dr["OtherCost_Dept"] != DBNull.Value) other_Cost.OtherCost_Dept = Convert.ToString(dr["OtherCost_Dept"]);
            if (dr["OtherCost_BeginDate"] != DBNull.Value) other_Cost.OtherCost_BeginDate = Convert.ToDateTime(dr["OtherCost_BeginDate"]);
            if (dr["OtherCost_EndDate"] != DBNull.Value) other_Cost.OtherCost_EndDate = Convert.ToDateTime(dr["OtherCost_EndDate"]);
            if (dr["OtherCost_Operator"] != DBNull.Value) other_Cost.OtherCost_Operator = Convert.ToString(dr["OtherCost_Operator"]);
            if (dr["OtherCost_OpDate"] != DBNull.Value) other_Cost.OtherCost_OpDate = Convert.ToDateTime(dr["OtherCost_OpDate"]);
            if (dr["OtherCost_Auditor"] != DBNull.Value) other_Cost.OtherCost_Auditor = Convert.ToString(dr["OtherCost_Auditor"]);
            if (dr["OtherCost_AuditDate"] != DBNull.Value) other_Cost.OtherCost_AuditDate = Convert.ToDateTime(dr["OtherCost_AuditDate"]);
            if (dr["Stat"] != DBNull.Value) other_Cost.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) other_Cost.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) other_Cost.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) other_Cost.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(other_Cost);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
