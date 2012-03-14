using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOPCD_Expception
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PCD_Expception对象(即:一条记录)
      /// </summary>
      public int Add(PCD_Expception pCD_Expception)
      {
         string sql = "INSERT INTO PCD_Expception (PCDE_Code,PCDE_Key,PCDE_Module,PCDE_Type,PCDE_iType,PCDE_Date,PCDE_Content,PCDE_Company,PCDE_PLine,PCDE_Object,PCDE_Ticket,PCDE_BOwner,PCDE_Recordor,PCDE_Handle,PCDE_HType,PCDE_HAdvice,PCDE_COwner,PCDE_Pay,PCDE_IPay,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCDE_Code,@PCDE_Key,@PCDE_Module,@PCDE_Type,@PCDE_iType,@PCDE_Date,@PCDE_Content,@PCDE_Company,@PCDE_PLine,@PCDE_Object,@PCDE_Ticket,@PCDE_BOwner,@PCDE_Recordor,@PCDE_Handle,@PCDE_HType,@PCDE_HAdvice,@PCDE_COwner,@PCDE_Pay,@PCDE_IPay,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Code))
         {
            idb.AddParameter("@PCDE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Code", pCD_Expception.PCDE_Code);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Key))
         {
            idb.AddParameter("@PCDE_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Key", pCD_Expception.PCDE_Key);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Module))
         {
            idb.AddParameter("@PCDE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Module", pCD_Expception.PCDE_Module);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Type))
         {
            idb.AddParameter("@PCDE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Type", pCD_Expception.PCDE_Type);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_iType))
         {
            idb.AddParameter("@PCDE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_iType", pCD_Expception.PCDE_iType);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Date))
         {
            idb.AddParameter("@PCDE_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Date", pCD_Expception.PCDE_Date);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Content))
         {
            idb.AddParameter("@PCDE_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Content", pCD_Expception.PCDE_Content);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Company))
         {
            idb.AddParameter("@PCDE_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Company", pCD_Expception.PCDE_Company);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_PLine))
         {
            idb.AddParameter("@PCDE_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_PLine", pCD_Expception.PCDE_PLine);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Object))
         {
            idb.AddParameter("@PCDE_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Object", pCD_Expception.PCDE_Object);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Ticket))
         {
            idb.AddParameter("@PCDE_Ticket", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Ticket", pCD_Expception.PCDE_Ticket);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_BOwner))
         {
            idb.AddParameter("@PCDE_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_BOwner", pCD_Expception.PCDE_BOwner);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Recordor))
         {
            idb.AddParameter("@PCDE_Recordor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Recordor", pCD_Expception.PCDE_Recordor);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Handle))
         {
            idb.AddParameter("@PCDE_Handle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Handle", pCD_Expception.PCDE_Handle);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_HType))
         {
            idb.AddParameter("@PCDE_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_HType", pCD_Expception.PCDE_HType);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_HAdvice))
         {
            idb.AddParameter("@PCDE_HAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_HAdvice", pCD_Expception.PCDE_HAdvice);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_COwner))
         {
            idb.AddParameter("@PCDE_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_COwner", pCD_Expception.PCDE_COwner);
         }
         if (pCD_Expception.PCDE_Pay == 0)
         {
            idb.AddParameter("@PCDE_Pay", 0);
         }
         else
         {
            idb.AddParameter("@PCDE_Pay", pCD_Expception.PCDE_Pay);
         }
         if (pCD_Expception.PCDE_IPay == 0)
         {
            idb.AddParameter("@PCDE_IPay", 0);
         }
         else
         {
            idb.AddParameter("@PCDE_IPay", pCD_Expception.PCDE_IPay);
         }
         if (string.IsNullOrEmpty(pCD_Expception.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pCD_Expception.AuditStat);
         }
         if (string.IsNullOrEmpty(pCD_Expception.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pCD_Expception.AuditCurAudit);
         }
         if (pCD_Expception.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Expception.Stat);
         }
         if (pCD_Expception.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_Expception.CreateDate);
         }
         if (pCD_Expception.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_Expception.UpdateDate);
         }
         if (pCD_Expception.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_Expception.DeleteDate);
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
      /// 添加PCD_Expception对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCD_Expception pCD_Expception)
      {
         string sql = "INSERT INTO PCD_Expception (PCDE_Code,PCDE_Key,PCDE_Module,PCDE_Type,PCDE_iType,PCDE_Date,PCDE_Content,PCDE_Company,PCDE_PLine,PCDE_Object,PCDE_Ticket,PCDE_BOwner,PCDE_Recordor,PCDE_Handle,PCDE_HType,PCDE_HAdvice,PCDE_COwner,PCDE_Pay,PCDE_IPay,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCDE_Code,@PCDE_Key,@PCDE_Module,@PCDE_Type,@PCDE_iType,@PCDE_Date,@PCDE_Content,@PCDE_Company,@PCDE_PLine,@PCDE_Object,@PCDE_Ticket,@PCDE_BOwner,@PCDE_Recordor,@PCDE_Handle,@PCDE_HType,@PCDE_HAdvice,@PCDE_COwner,@PCDE_Pay,@PCDE_IPay,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Code))
         {
            idb.AddParameter("@PCDE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Code", pCD_Expception.PCDE_Code);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Key))
         {
            idb.AddParameter("@PCDE_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Key", pCD_Expception.PCDE_Key);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Module))
         {
            idb.AddParameter("@PCDE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Module", pCD_Expception.PCDE_Module);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Type))
         {
            idb.AddParameter("@PCDE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Type", pCD_Expception.PCDE_Type);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_iType))
         {
            idb.AddParameter("@PCDE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_iType", pCD_Expception.PCDE_iType);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Date))
         {
            idb.AddParameter("@PCDE_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Date", pCD_Expception.PCDE_Date);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Content))
         {
            idb.AddParameter("@PCDE_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Content", pCD_Expception.PCDE_Content);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Company))
         {
            idb.AddParameter("@PCDE_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Company", pCD_Expception.PCDE_Company);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_PLine))
         {
            idb.AddParameter("@PCDE_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_PLine", pCD_Expception.PCDE_PLine);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Object))
         {
            idb.AddParameter("@PCDE_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Object", pCD_Expception.PCDE_Object);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Ticket))
         {
            idb.AddParameter("@PCDE_Ticket", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Ticket", pCD_Expception.PCDE_Ticket);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_BOwner))
         {
            idb.AddParameter("@PCDE_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_BOwner", pCD_Expception.PCDE_BOwner);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Recordor))
         {
            idb.AddParameter("@PCDE_Recordor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Recordor", pCD_Expception.PCDE_Recordor);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Handle))
         {
            idb.AddParameter("@PCDE_Handle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Handle", pCD_Expception.PCDE_Handle);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_HType))
         {
            idb.AddParameter("@PCDE_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_HType", pCD_Expception.PCDE_HType);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_HAdvice))
         {
            idb.AddParameter("@PCDE_HAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_HAdvice", pCD_Expception.PCDE_HAdvice);
         }
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_COwner))
         {
            idb.AddParameter("@PCDE_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_COwner", pCD_Expception.PCDE_COwner);
         }
         if (pCD_Expception.PCDE_Pay == 0)
         {
            idb.AddParameter("@PCDE_Pay", 0);
         }
         else
         {
            idb.AddParameter("@PCDE_Pay", pCD_Expception.PCDE_Pay);
         }
         if (pCD_Expception.PCDE_IPay == 0)
         {
            idb.AddParameter("@PCDE_IPay", 0);
         }
         else
         {
            idb.AddParameter("@PCDE_IPay", pCD_Expception.PCDE_IPay);
         }
         if (string.IsNullOrEmpty(pCD_Expception.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pCD_Expception.AuditStat);
         }
         if (string.IsNullOrEmpty(pCD_Expception.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pCD_Expception.AuditCurAudit);
         }
         if (pCD_Expception.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Expception.Stat);
         }
         if (pCD_Expception.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_Expception.CreateDate);
         }
         if (pCD_Expception.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_Expception.UpdateDate);
         }
         if (pCD_Expception.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_Expception.DeleteDate);
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
      /// 更新PCD_Expception对象(即:一条记录
      /// </summary>
      public int Update(PCD_Expception pCD_Expception)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCD_Expception       SET ");
            if(pCD_Expception.PCDE_Code_IsChanged){sbParameter.Append("PCDE_Code=@PCDE_Code, ");}
      if(pCD_Expception.PCDE_Key_IsChanged){sbParameter.Append("PCDE_Key=@PCDE_Key, ");}
      if(pCD_Expception.PCDE_Module_IsChanged){sbParameter.Append("PCDE_Module=@PCDE_Module, ");}
      if(pCD_Expception.PCDE_Type_IsChanged){sbParameter.Append("PCDE_Type=@PCDE_Type, ");}
      if(pCD_Expception.PCDE_iType_IsChanged){sbParameter.Append("PCDE_iType=@PCDE_iType, ");}
      if(pCD_Expception.PCDE_Date_IsChanged){sbParameter.Append("PCDE_Date=@PCDE_Date, ");}
      if(pCD_Expception.PCDE_Content_IsChanged){sbParameter.Append("PCDE_Content=@PCDE_Content, ");}
      if(pCD_Expception.PCDE_Company_IsChanged){sbParameter.Append("PCDE_Company=@PCDE_Company, ");}
      if(pCD_Expception.PCDE_PLine_IsChanged){sbParameter.Append("PCDE_PLine=@PCDE_PLine, ");}
      if(pCD_Expception.PCDE_Object_IsChanged){sbParameter.Append("PCDE_Object=@PCDE_Object, ");}
      if(pCD_Expception.PCDE_Ticket_IsChanged){sbParameter.Append("PCDE_Ticket=@PCDE_Ticket, ");}
      if(pCD_Expception.PCDE_BOwner_IsChanged){sbParameter.Append("PCDE_BOwner=@PCDE_BOwner, ");}
      if(pCD_Expception.PCDE_Recordor_IsChanged){sbParameter.Append("PCDE_Recordor=@PCDE_Recordor, ");}
      if(pCD_Expception.PCDE_Handle_IsChanged){sbParameter.Append("PCDE_Handle=@PCDE_Handle, ");}
      if(pCD_Expception.PCDE_HType_IsChanged){sbParameter.Append("PCDE_HType=@PCDE_HType, ");}
      if(pCD_Expception.PCDE_HAdvice_IsChanged){sbParameter.Append("PCDE_HAdvice=@PCDE_HAdvice, ");}
      if(pCD_Expception.PCDE_COwner_IsChanged){sbParameter.Append("PCDE_COwner=@PCDE_COwner, ");}
      if(pCD_Expception.PCDE_Pay_IsChanged){sbParameter.Append("PCDE_Pay=@PCDE_Pay, ");}
      if(pCD_Expception.PCDE_IPay_IsChanged){sbParameter.Append("PCDE_IPay=@PCDE_IPay, ");}
      if(pCD_Expception.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(pCD_Expception.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(pCD_Expception.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCD_Expception.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCD_Expception.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCD_Expception.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCDE_ID=@PCDE_ID; " );
      string sql=sb.ToString();
         if(pCD_Expception.PCDE_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Code))
         {
            idb.AddParameter("@PCDE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Code", pCD_Expception.PCDE_Code);
         }
          }
         if(pCD_Expception.PCDE_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Key))
         {
            idb.AddParameter("@PCDE_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Key", pCD_Expception.PCDE_Key);
         }
          }
         if(pCD_Expception.PCDE_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Module))
         {
            idb.AddParameter("@PCDE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Module", pCD_Expception.PCDE_Module);
         }
          }
         if(pCD_Expception.PCDE_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Type))
         {
            idb.AddParameter("@PCDE_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Type", pCD_Expception.PCDE_Type);
         }
          }
         if(pCD_Expception.PCDE_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_iType))
         {
            idb.AddParameter("@PCDE_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_iType", pCD_Expception.PCDE_iType);
         }
          }
         if(pCD_Expception.PCDE_Date_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Date))
         {
            idb.AddParameter("@PCDE_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Date", pCD_Expception.PCDE_Date);
         }
          }
         if(pCD_Expception.PCDE_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Content))
         {
            idb.AddParameter("@PCDE_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Content", pCD_Expception.PCDE_Content);
         }
          }
         if(pCD_Expception.PCDE_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Company))
         {
            idb.AddParameter("@PCDE_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Company", pCD_Expception.PCDE_Company);
         }
          }
         if(pCD_Expception.PCDE_PLine_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_PLine))
         {
            idb.AddParameter("@PCDE_PLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_PLine", pCD_Expception.PCDE_PLine);
         }
          }
         if(pCD_Expception.PCDE_Object_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Object))
         {
            idb.AddParameter("@PCDE_Object", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Object", pCD_Expception.PCDE_Object);
         }
          }
         if(pCD_Expception.PCDE_Ticket_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Ticket))
         {
            idb.AddParameter("@PCDE_Ticket", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Ticket", pCD_Expception.PCDE_Ticket);
         }
          }
         if(pCD_Expception.PCDE_BOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_BOwner))
         {
            idb.AddParameter("@PCDE_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_BOwner", pCD_Expception.PCDE_BOwner);
         }
          }
         if(pCD_Expception.PCDE_Recordor_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Recordor))
         {
            idb.AddParameter("@PCDE_Recordor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Recordor", pCD_Expception.PCDE_Recordor);
         }
          }
         if(pCD_Expception.PCDE_Handle_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_Handle))
         {
            idb.AddParameter("@PCDE_Handle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_Handle", pCD_Expception.PCDE_Handle);
         }
          }
         if(pCD_Expception.PCDE_HType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_HType))
         {
            idb.AddParameter("@PCDE_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_HType", pCD_Expception.PCDE_HType);
         }
          }
         if(pCD_Expception.PCDE_HAdvice_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_HAdvice))
         {
            idb.AddParameter("@PCDE_HAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_HAdvice", pCD_Expception.PCDE_HAdvice);
         }
          }
         if(pCD_Expception.PCDE_COwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.PCDE_COwner))
         {
            idb.AddParameter("@PCDE_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDE_COwner", pCD_Expception.PCDE_COwner);
         }
          }
         if(pCD_Expception.PCDE_Pay_IsChanged)
         {
         if (pCD_Expception.PCDE_Pay == 0)
         {
            idb.AddParameter("@PCDE_Pay", 0);
         }
         else
         {
            idb.AddParameter("@PCDE_Pay", pCD_Expception.PCDE_Pay);
         }
          }
         if(pCD_Expception.PCDE_IPay_IsChanged)
         {
         if (pCD_Expception.PCDE_IPay == 0)
         {
            idb.AddParameter("@PCDE_IPay", 0);
         }
         else
         {
            idb.AddParameter("@PCDE_IPay", pCD_Expception.PCDE_IPay);
         }
          }
         if(pCD_Expception.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pCD_Expception.AuditStat);
         }
          }
         if(pCD_Expception.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_Expception.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pCD_Expception.AuditCurAudit);
         }
          }
         if(pCD_Expception.Stat_IsChanged)
         {
         if (pCD_Expception.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_Expception.Stat);
         }
          }
         if(pCD_Expception.CreateDate_IsChanged)
         {
         if (pCD_Expception.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_Expception.CreateDate);
         }
          }
         if(pCD_Expception.UpdateDate_IsChanged)
         {
         if (pCD_Expception.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_Expception.UpdateDate);
         }
          }
         if(pCD_Expception.DeleteDate_IsChanged)
         {
         if (pCD_Expception.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_Expception.DeleteDate);
         }
          }

         idb.AddParameter("@PCDE_ID", pCD_Expception.PCDE_ID);

           
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
      /// 删除PCD_Expception对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCDE_ID)
      {
         string sql = "DELETE PCD_Expception WHERE 1=1  AND PCDE_ID=@PCDE_ID ";
         idb.AddParameter("@PCDE_ID", pCDE_ID);

           
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
      /// 获取指定的PCD_Expception对象(即:一条记录
      /// </summary>
      public PCD_Expception GetByKey(decimal pCDE_ID)
      {
         PCD_Expception pCD_Expception = new PCD_Expception();
         string sql = "SELECT  PCDE_ID,PCDE_Code,PCDE_Key,PCDE_Module,PCDE_Type,PCDE_iType,PCDE_Date,PCDE_Content,PCDE_Company,PCDE_PLine,PCDE_Object,PCDE_Ticket,PCDE_BOwner,PCDE_Recordor,PCDE_Handle,PCDE_HType,PCDE_HAdvice,PCDE_COwner,PCDE_Pay,PCDE_IPay,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_Expception WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCDE_ID=@PCDE_ID ";
         idb.AddParameter("@PCDE_ID", pCDE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCDE_ID"] != DBNull.Value) pCD_Expception.PCDE_ID = Convert.ToDecimal(dr["PCDE_ID"]);
            if (dr["PCDE_Code"] != DBNull.Value) pCD_Expception.PCDE_Code = Convert.ToString(dr["PCDE_Code"]);
            if (dr["PCDE_Key"] != DBNull.Value) pCD_Expception.PCDE_Key = Convert.ToString(dr["PCDE_Key"]);
            if (dr["PCDE_Module"] != DBNull.Value) pCD_Expception.PCDE_Module = Convert.ToString(dr["PCDE_Module"]);
            if (dr["PCDE_Type"] != DBNull.Value) pCD_Expception.PCDE_Type = Convert.ToString(dr["PCDE_Type"]);
            if (dr["PCDE_iType"] != DBNull.Value) pCD_Expception.PCDE_iType = Convert.ToString(dr["PCDE_iType"]);
            if (dr["PCDE_Date"] != DBNull.Value) pCD_Expception.PCDE_Date = Convert.ToString(dr["PCDE_Date"]);
            if (dr["PCDE_Content"] != DBNull.Value) pCD_Expception.PCDE_Content = Convert.ToString(dr["PCDE_Content"]);
            if (dr["PCDE_Company"] != DBNull.Value) pCD_Expception.PCDE_Company = Convert.ToString(dr["PCDE_Company"]);
            if (dr["PCDE_PLine"] != DBNull.Value) pCD_Expception.PCDE_PLine = Convert.ToString(dr["PCDE_PLine"]);
            if (dr["PCDE_Object"] != DBNull.Value) pCD_Expception.PCDE_Object = Convert.ToString(dr["PCDE_Object"]);
            if (dr["PCDE_Ticket"] != DBNull.Value) pCD_Expception.PCDE_Ticket = Convert.ToString(dr["PCDE_Ticket"]);
            if (dr["PCDE_BOwner"] != DBNull.Value) pCD_Expception.PCDE_BOwner = Convert.ToString(dr["PCDE_BOwner"]);
            if (dr["PCDE_Recordor"] != DBNull.Value) pCD_Expception.PCDE_Recordor = Convert.ToString(dr["PCDE_Recordor"]);
            if (dr["PCDE_Handle"] != DBNull.Value) pCD_Expception.PCDE_Handle = Convert.ToString(dr["PCDE_Handle"]);
            if (dr["PCDE_HType"] != DBNull.Value) pCD_Expception.PCDE_HType = Convert.ToString(dr["PCDE_HType"]);
            if (dr["PCDE_HAdvice"] != DBNull.Value) pCD_Expception.PCDE_HAdvice = Convert.ToString(dr["PCDE_HAdvice"]);
            if (dr["PCDE_COwner"] != DBNull.Value) pCD_Expception.PCDE_COwner = Convert.ToString(dr["PCDE_COwner"]);
            if (dr["PCDE_Pay"] != DBNull.Value) pCD_Expception.PCDE_Pay = Convert.ToDecimal(dr["PCDE_Pay"]);
            if (dr["PCDE_IPay"] != DBNull.Value) pCD_Expception.PCDE_IPay = Convert.ToDecimal(dr["PCDE_IPay"]);
            if (dr["AuditStat"] != DBNull.Value) pCD_Expception.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pCD_Expception.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) pCD_Expception.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_Expception.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_Expception.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_Expception.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCD_Expception;
      }
      /// <summary>
      /// 获取指定的PCD_Expception对象集合
      /// </summary>
      public List<PCD_Expception> GetListByWhere(string strCondition)
      {
         List<PCD_Expception> ret = new List<PCD_Expception>();
         string sql = "SELECT  PCDE_ID,PCDE_Code,PCDE_Key,PCDE_Module,PCDE_Type,PCDE_iType,PCDE_Date,PCDE_Content,PCDE_Company,PCDE_PLine,PCDE_Object,PCDE_Ticket,PCDE_BOwner,PCDE_Recordor,PCDE_Handle,PCDE_HType,PCDE_HAdvice,PCDE_COwner,PCDE_Pay,PCDE_IPay,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_Expception WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCD_Expception pCD_Expception = new PCD_Expception();
            if (dr["PCDE_ID"] != DBNull.Value) pCD_Expception.PCDE_ID = Convert.ToDecimal(dr["PCDE_ID"]);
            if (dr["PCDE_Code"] != DBNull.Value) pCD_Expception.PCDE_Code = Convert.ToString(dr["PCDE_Code"]);
            if (dr["PCDE_Key"] != DBNull.Value) pCD_Expception.PCDE_Key = Convert.ToString(dr["PCDE_Key"]);
            if (dr["PCDE_Module"] != DBNull.Value) pCD_Expception.PCDE_Module = Convert.ToString(dr["PCDE_Module"]);
            if (dr["PCDE_Type"] != DBNull.Value) pCD_Expception.PCDE_Type = Convert.ToString(dr["PCDE_Type"]);
            if (dr["PCDE_iType"] != DBNull.Value) pCD_Expception.PCDE_iType = Convert.ToString(dr["PCDE_iType"]);
            if (dr["PCDE_Date"] != DBNull.Value) pCD_Expception.PCDE_Date = Convert.ToString(dr["PCDE_Date"]);
            if (dr["PCDE_Content"] != DBNull.Value) pCD_Expception.PCDE_Content = Convert.ToString(dr["PCDE_Content"]);
            if (dr["PCDE_Company"] != DBNull.Value) pCD_Expception.PCDE_Company = Convert.ToString(dr["PCDE_Company"]);
            if (dr["PCDE_PLine"] != DBNull.Value) pCD_Expception.PCDE_PLine = Convert.ToString(dr["PCDE_PLine"]);
            if (dr["PCDE_Object"] != DBNull.Value) pCD_Expception.PCDE_Object = Convert.ToString(dr["PCDE_Object"]);
            if (dr["PCDE_Ticket"] != DBNull.Value) pCD_Expception.PCDE_Ticket = Convert.ToString(dr["PCDE_Ticket"]);
            if (dr["PCDE_BOwner"] != DBNull.Value) pCD_Expception.PCDE_BOwner = Convert.ToString(dr["PCDE_BOwner"]);
            if (dr["PCDE_Recordor"] != DBNull.Value) pCD_Expception.PCDE_Recordor = Convert.ToString(dr["PCDE_Recordor"]);
            if (dr["PCDE_Handle"] != DBNull.Value) pCD_Expception.PCDE_Handle = Convert.ToString(dr["PCDE_Handle"]);
            if (dr["PCDE_HType"] != DBNull.Value) pCD_Expception.PCDE_HType = Convert.ToString(dr["PCDE_HType"]);
            if (dr["PCDE_HAdvice"] != DBNull.Value) pCD_Expception.PCDE_HAdvice = Convert.ToString(dr["PCDE_HAdvice"]);
            if (dr["PCDE_COwner"] != DBNull.Value) pCD_Expception.PCDE_COwner = Convert.ToString(dr["PCDE_COwner"]);
            if (dr["PCDE_Pay"] != DBNull.Value) pCD_Expception.PCDE_Pay = Convert.ToDecimal(dr["PCDE_Pay"]);
            if (dr["PCDE_IPay"] != DBNull.Value) pCD_Expception.PCDE_IPay = Convert.ToDecimal(dr["PCDE_IPay"]);
            if (dr["AuditStat"] != DBNull.Value) pCD_Expception.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pCD_Expception.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) pCD_Expception.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_Expception.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_Expception.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_Expception.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCD_Expception);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PCD_Expception对象(即:一条记录
      /// </summary>
      public List<PCD_Expception> GetAll()
      {
         List<PCD_Expception> ret = new List<PCD_Expception>();
         string sql = "SELECT  PCDE_ID,PCDE_Code,PCDE_Key,PCDE_Module,PCDE_Type,PCDE_iType,PCDE_Date,PCDE_Content,PCDE_Company,PCDE_PLine,PCDE_Object,PCDE_Ticket,PCDE_BOwner,PCDE_Recordor,PCDE_Handle,PCDE_HType,PCDE_HAdvice,PCDE_COwner,PCDE_Pay,PCDE_IPay,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_Expception where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCDE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCD_Expception pCD_Expception = new PCD_Expception();
            if (dr["PCDE_ID"] != DBNull.Value) pCD_Expception.PCDE_ID = Convert.ToDecimal(dr["PCDE_ID"]);
            if (dr["PCDE_Code"] != DBNull.Value) pCD_Expception.PCDE_Code = Convert.ToString(dr["PCDE_Code"]);
            if (dr["PCDE_Key"] != DBNull.Value) pCD_Expception.PCDE_Key = Convert.ToString(dr["PCDE_Key"]);
            if (dr["PCDE_Module"] != DBNull.Value) pCD_Expception.PCDE_Module = Convert.ToString(dr["PCDE_Module"]);
            if (dr["PCDE_Type"] != DBNull.Value) pCD_Expception.PCDE_Type = Convert.ToString(dr["PCDE_Type"]);
            if (dr["PCDE_iType"] != DBNull.Value) pCD_Expception.PCDE_iType = Convert.ToString(dr["PCDE_iType"]);
            if (dr["PCDE_Date"] != DBNull.Value) pCD_Expception.PCDE_Date = Convert.ToString(dr["PCDE_Date"]);
            if (dr["PCDE_Content"] != DBNull.Value) pCD_Expception.PCDE_Content = Convert.ToString(dr["PCDE_Content"]);
            if (dr["PCDE_Company"] != DBNull.Value) pCD_Expception.PCDE_Company = Convert.ToString(dr["PCDE_Company"]);
            if (dr["PCDE_PLine"] != DBNull.Value) pCD_Expception.PCDE_PLine = Convert.ToString(dr["PCDE_PLine"]);
            if (dr["PCDE_Object"] != DBNull.Value) pCD_Expception.PCDE_Object = Convert.ToString(dr["PCDE_Object"]);
            if (dr["PCDE_Ticket"] != DBNull.Value) pCD_Expception.PCDE_Ticket = Convert.ToString(dr["PCDE_Ticket"]);
            if (dr["PCDE_BOwner"] != DBNull.Value) pCD_Expception.PCDE_BOwner = Convert.ToString(dr["PCDE_BOwner"]);
            if (dr["PCDE_Recordor"] != DBNull.Value) pCD_Expception.PCDE_Recordor = Convert.ToString(dr["PCDE_Recordor"]);
            if (dr["PCDE_Handle"] != DBNull.Value) pCD_Expception.PCDE_Handle = Convert.ToString(dr["PCDE_Handle"]);
            if (dr["PCDE_HType"] != DBNull.Value) pCD_Expception.PCDE_HType = Convert.ToString(dr["PCDE_HType"]);
            if (dr["PCDE_HAdvice"] != DBNull.Value) pCD_Expception.PCDE_HAdvice = Convert.ToString(dr["PCDE_HAdvice"]);
            if (dr["PCDE_COwner"] != DBNull.Value) pCD_Expception.PCDE_COwner = Convert.ToString(dr["PCDE_COwner"]);
            if (dr["PCDE_Pay"] != DBNull.Value) pCD_Expception.PCDE_Pay = Convert.ToDecimal(dr["PCDE_Pay"]);
            if (dr["PCDE_IPay"] != DBNull.Value) pCD_Expception.PCDE_IPay = Convert.ToDecimal(dr["PCDE_IPay"]);
            if (dr["AuditStat"] != DBNull.Value) pCD_Expception.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pCD_Expception.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) pCD_Expception.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_Expception.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_Expception.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_Expception.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCD_Expception);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
