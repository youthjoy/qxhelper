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
   public partial class ADOPC_CPlan
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PC_CPlan对象(即:一条记录)
      /// </summary>
      public int Add(PC_CPlan pC_CPlan)
      {
         string sql = "INSERT INTO PC_CPlan (PCCP_Code,PCCP_CustomerCode,PCCP_CName,PCCP_CCode,PCCP_ProjectCode,PCCP_ProjectName,PCCP_Address,PCCP_Part,PCCP_ProdName,PCCP_Level,PCCP_Impervious,PCCP_Volume,PCCP_Slump,PCCP_SubmitDate,PCCP_BeginTime,PCCP_SPC,PCCP_Request1,PCCP_Request2,PCCP_Request3,PCCP_Request4,PCCP_Request5,PCCP_Transpot,PCCP_Stat,PCCP_Remark1,PCCP_Remark2,PCCP_CurStep,PCCP_NextStep,PCCP_Owner,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,LastAuditor,LastAuditDate,PCCP_Udef1,PCCP_Udef2,PCCP_Udef3,PCCP_Udef4,PCCP_Udef5) VALUES (@PCCP_Code,@PCCP_CustomerCode,@PCCP_CName,@PCCP_CCode,@PCCP_ProjectCode,@PCCP_ProjectName,@PCCP_Address,@PCCP_Part,@PCCP_ProdName,@PCCP_Level,@PCCP_Impervious,@PCCP_Volume,@PCCP_Slump,@PCCP_SubmitDate,@PCCP_BeginTime,@PCCP_SPC,@PCCP_Request1,@PCCP_Request2,@PCCP_Request3,@PCCP_Request4,@PCCP_Request5,@PCCP_Transpot,@PCCP_Stat,@PCCP_Remark1,@PCCP_Remark2,@PCCP_CurStep,@PCCP_NextStep,@PCCP_Owner,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit,@LastAuditor,@LastAuditDate,@PCCP_Udef1,@PCCP_Udef2,@PCCP_Udef3,@PCCP_Udef4,@PCCP_Udef5)";
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Code))
         {
            idb.AddParameter("@PCCP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Code", pC_CPlan.PCCP_Code);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CustomerCode))
         {
            idb.AddParameter("@PCCP_CustomerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CustomerCode", pC_CPlan.PCCP_CustomerCode);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CName))
         {
            idb.AddParameter("@PCCP_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CName", pC_CPlan.PCCP_CName);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CCode))
         {
            idb.AddParameter("@PCCP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CCode", pC_CPlan.PCCP_CCode);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProjectCode))
         {
            idb.AddParameter("@PCCP_ProjectCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProjectCode", pC_CPlan.PCCP_ProjectCode);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProjectName))
         {
            idb.AddParameter("@PCCP_ProjectName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProjectName", pC_CPlan.PCCP_ProjectName);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Address))
         {
            idb.AddParameter("@PCCP_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Address", pC_CPlan.PCCP_Address);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Part))
         {
            idb.AddParameter("@PCCP_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Part", pC_CPlan.PCCP_Part);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProdName))
         {
            idb.AddParameter("@PCCP_ProdName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProdName", pC_CPlan.PCCP_ProdName);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Level))
         {
            idb.AddParameter("@PCCP_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Level", pC_CPlan.PCCP_Level);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Impervious))
         {
            idb.AddParameter("@PCCP_Impervious", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Impervious", pC_CPlan.PCCP_Impervious);
         }
         if (pC_CPlan.PCCP_Volume == 0)
         {
            idb.AddParameter("@PCCP_Volume", 0);
         }
         else
         {
            idb.AddParameter("@PCCP_Volume", pC_CPlan.PCCP_Volume);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Slump))
         {
            idb.AddParameter("@PCCP_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Slump", pC_CPlan.PCCP_Slump);
         }
         if (pC_CPlan.PCCP_SubmitDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCCP_SubmitDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_SubmitDate", pC_CPlan.PCCP_SubmitDate);
         }
         if (pC_CPlan.PCCP_BeginTime == DateTime.MinValue)
         {
            idb.AddParameter("@PCCP_BeginTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_BeginTime", pC_CPlan.PCCP_BeginTime);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_SPC))
         {
            idb.AddParameter("@PCCP_SPC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_SPC", pC_CPlan.PCCP_SPC);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request1))
         {
            idb.AddParameter("@PCCP_Request1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request1", pC_CPlan.PCCP_Request1);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request2))
         {
            idb.AddParameter("@PCCP_Request2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request2", pC_CPlan.PCCP_Request2);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request3))
         {
            idb.AddParameter("@PCCP_Request3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request3", pC_CPlan.PCCP_Request3);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request4))
         {
            idb.AddParameter("@PCCP_Request4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request4", pC_CPlan.PCCP_Request4);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request5))
         {
            idb.AddParameter("@PCCP_Request5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request5", pC_CPlan.PCCP_Request5);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Transpot))
         {
            idb.AddParameter("@PCCP_Transpot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Transpot", pC_CPlan.PCCP_Transpot);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Stat))
         {
            idb.AddParameter("@PCCP_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Stat", pC_CPlan.PCCP_Stat);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Remark1))
         {
            idb.AddParameter("@PCCP_Remark1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Remark1", pC_CPlan.PCCP_Remark1);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Remark2))
         {
            idb.AddParameter("@PCCP_Remark2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Remark2", pC_CPlan.PCCP_Remark2);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CurStep))
         {
            idb.AddParameter("@PCCP_CurStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CurStep", pC_CPlan.PCCP_CurStep);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_NextStep))
         {
            idb.AddParameter("@PCCP_NextStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_NextStep", pC_CPlan.PCCP_NextStep);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Owner))
         {
            idb.AddParameter("@PCCP_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Owner", pC_CPlan.PCCP_Owner);
         }
         if (pC_CPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_CPlan.Stat);
         }
         if (pC_CPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_CPlan.CreateDate);
         }
         if (pC_CPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_CPlan.UpdateDate);
         }
         if (pC_CPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_CPlan.DeleteDate);
         }
         if (string.IsNullOrEmpty(pC_CPlan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pC_CPlan.AuditStat);
         }
         if (string.IsNullOrEmpty(pC_CPlan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pC_CPlan.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(pC_CPlan.LastAuditor))
         {
            idb.AddParameter("@LastAuditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LastAuditor", pC_CPlan.LastAuditor);
         }
         if (pC_CPlan.LastAuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@LastAuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LastAuditDate", pC_CPlan.LastAuditDate);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef1))
         {
            idb.AddParameter("@PCCP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef1", pC_CPlan.PCCP_Udef1);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef2))
         {
            idb.AddParameter("@PCCP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef2", pC_CPlan.PCCP_Udef2);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef3))
         {
            idb.AddParameter("@PCCP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef3", pC_CPlan.PCCP_Udef3);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef4))
         {
            idb.AddParameter("@PCCP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef4", pC_CPlan.PCCP_Udef4);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef5))
         {
            idb.AddParameter("@PCCP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef5", pC_CPlan.PCCP_Udef5);
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
      /// 添加PC_CPlan对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_CPlan pC_CPlan)
      {
         string sql = "INSERT INTO PC_CPlan (PCCP_Code,PCCP_CustomerCode,PCCP_CName,PCCP_CCode,PCCP_ProjectCode,PCCP_ProjectName,PCCP_Address,PCCP_Part,PCCP_ProdName,PCCP_Level,PCCP_Impervious,PCCP_Volume,PCCP_Slump,PCCP_SubmitDate,PCCP_BeginTime,PCCP_SPC,PCCP_Request1,PCCP_Request2,PCCP_Request3,PCCP_Request4,PCCP_Request5,PCCP_Transpot,PCCP_Stat,PCCP_Remark1,PCCP_Remark2,PCCP_CurStep,PCCP_NextStep,PCCP_Owner,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,LastAuditor,LastAuditDate,PCCP_Udef1,PCCP_Udef2,PCCP_Udef3,PCCP_Udef4,PCCP_Udef5) VALUES (@PCCP_Code,@PCCP_CustomerCode,@PCCP_CName,@PCCP_CCode,@PCCP_ProjectCode,@PCCP_ProjectName,@PCCP_Address,@PCCP_Part,@PCCP_ProdName,@PCCP_Level,@PCCP_Impervious,@PCCP_Volume,@PCCP_Slump,@PCCP_SubmitDate,@PCCP_BeginTime,@PCCP_SPC,@PCCP_Request1,@PCCP_Request2,@PCCP_Request3,@PCCP_Request4,@PCCP_Request5,@PCCP_Transpot,@PCCP_Stat,@PCCP_Remark1,@PCCP_Remark2,@PCCP_CurStep,@PCCP_NextStep,@PCCP_Owner,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit,@LastAuditor,@LastAuditDate,@PCCP_Udef1,@PCCP_Udef2,@PCCP_Udef3,@PCCP_Udef4,@PCCP_Udef5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Code))
         {
            idb.AddParameter("@PCCP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Code", pC_CPlan.PCCP_Code);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CustomerCode))
         {
            idb.AddParameter("@PCCP_CustomerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CustomerCode", pC_CPlan.PCCP_CustomerCode);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CName))
         {
            idb.AddParameter("@PCCP_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CName", pC_CPlan.PCCP_CName);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CCode))
         {
            idb.AddParameter("@PCCP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CCode", pC_CPlan.PCCP_CCode);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProjectCode))
         {
            idb.AddParameter("@PCCP_ProjectCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProjectCode", pC_CPlan.PCCP_ProjectCode);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProjectName))
         {
            idb.AddParameter("@PCCP_ProjectName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProjectName", pC_CPlan.PCCP_ProjectName);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Address))
         {
            idb.AddParameter("@PCCP_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Address", pC_CPlan.PCCP_Address);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Part))
         {
            idb.AddParameter("@PCCP_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Part", pC_CPlan.PCCP_Part);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProdName))
         {
            idb.AddParameter("@PCCP_ProdName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProdName", pC_CPlan.PCCP_ProdName);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Level))
         {
            idb.AddParameter("@PCCP_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Level", pC_CPlan.PCCP_Level);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Impervious))
         {
            idb.AddParameter("@PCCP_Impervious", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Impervious", pC_CPlan.PCCP_Impervious);
         }
         if (pC_CPlan.PCCP_Volume == 0)
         {
            idb.AddParameter("@PCCP_Volume", 0);
         }
         else
         {
            idb.AddParameter("@PCCP_Volume", pC_CPlan.PCCP_Volume);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Slump))
         {
            idb.AddParameter("@PCCP_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Slump", pC_CPlan.PCCP_Slump);
         }
         if (pC_CPlan.PCCP_SubmitDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCCP_SubmitDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_SubmitDate", pC_CPlan.PCCP_SubmitDate);
         }
         if (pC_CPlan.PCCP_BeginTime == DateTime.MinValue)
         {
            idb.AddParameter("@PCCP_BeginTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_BeginTime", pC_CPlan.PCCP_BeginTime);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_SPC))
         {
            idb.AddParameter("@PCCP_SPC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_SPC", pC_CPlan.PCCP_SPC);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request1))
         {
            idb.AddParameter("@PCCP_Request1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request1", pC_CPlan.PCCP_Request1);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request2))
         {
            idb.AddParameter("@PCCP_Request2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request2", pC_CPlan.PCCP_Request2);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request3))
         {
            idb.AddParameter("@PCCP_Request3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request3", pC_CPlan.PCCP_Request3);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request4))
         {
            idb.AddParameter("@PCCP_Request4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request4", pC_CPlan.PCCP_Request4);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request5))
         {
            idb.AddParameter("@PCCP_Request5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request5", pC_CPlan.PCCP_Request5);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Transpot))
         {
            idb.AddParameter("@PCCP_Transpot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Transpot", pC_CPlan.PCCP_Transpot);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Stat))
         {
            idb.AddParameter("@PCCP_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Stat", pC_CPlan.PCCP_Stat);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Remark1))
         {
            idb.AddParameter("@PCCP_Remark1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Remark1", pC_CPlan.PCCP_Remark1);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Remark2))
         {
            idb.AddParameter("@PCCP_Remark2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Remark2", pC_CPlan.PCCP_Remark2);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CurStep))
         {
            idb.AddParameter("@PCCP_CurStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CurStep", pC_CPlan.PCCP_CurStep);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_NextStep))
         {
            idb.AddParameter("@PCCP_NextStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_NextStep", pC_CPlan.PCCP_NextStep);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Owner))
         {
            idb.AddParameter("@PCCP_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Owner", pC_CPlan.PCCP_Owner);
         }
         if (pC_CPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_CPlan.Stat);
         }
         if (pC_CPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_CPlan.CreateDate);
         }
         if (pC_CPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_CPlan.UpdateDate);
         }
         if (pC_CPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_CPlan.DeleteDate);
         }
         if (string.IsNullOrEmpty(pC_CPlan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pC_CPlan.AuditStat);
         }
         if (string.IsNullOrEmpty(pC_CPlan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pC_CPlan.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(pC_CPlan.LastAuditor))
         {
            idb.AddParameter("@LastAuditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LastAuditor", pC_CPlan.LastAuditor);
         }
         if (pC_CPlan.LastAuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@LastAuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LastAuditDate", pC_CPlan.LastAuditDate);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef1))
         {
            idb.AddParameter("@PCCP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef1", pC_CPlan.PCCP_Udef1);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef2))
         {
            idb.AddParameter("@PCCP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef2", pC_CPlan.PCCP_Udef2);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef3))
         {
            idb.AddParameter("@PCCP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef3", pC_CPlan.PCCP_Udef3);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef4))
         {
            idb.AddParameter("@PCCP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef4", pC_CPlan.PCCP_Udef4);
         }
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef5))
         {
            idb.AddParameter("@PCCP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef5", pC_CPlan.PCCP_Udef5);
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
      /// 更新PC_CPlan对象(即:一条记录
      /// </summary>
      public int Update(PC_CPlan pC_CPlan)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_CPlan       SET ");
            if(pC_CPlan.PCCP_Code_IsChanged){sbParameter.Append("PCCP_Code=@PCCP_Code, ");}
      if(pC_CPlan.PCCP_CustomerCode_IsChanged){sbParameter.Append("PCCP_CustomerCode=@PCCP_CustomerCode, ");}
      if(pC_CPlan.PCCP_CName_IsChanged){sbParameter.Append("PCCP_CName=@PCCP_CName, ");}
      if(pC_CPlan.PCCP_CCode_IsChanged){sbParameter.Append("PCCP_CCode=@PCCP_CCode, ");}
      if(pC_CPlan.PCCP_ProjectCode_IsChanged){sbParameter.Append("PCCP_ProjectCode=@PCCP_ProjectCode, ");}
      if(pC_CPlan.PCCP_ProjectName_IsChanged){sbParameter.Append("PCCP_ProjectName=@PCCP_ProjectName, ");}
      if(pC_CPlan.PCCP_Address_IsChanged){sbParameter.Append("PCCP_Address=@PCCP_Address, ");}
      if(pC_CPlan.PCCP_Part_IsChanged){sbParameter.Append("PCCP_Part=@PCCP_Part, ");}
      if(pC_CPlan.PCCP_ProdName_IsChanged){sbParameter.Append("PCCP_ProdName=@PCCP_ProdName, ");}
      if(pC_CPlan.PCCP_Level_IsChanged){sbParameter.Append("PCCP_Level=@PCCP_Level, ");}
      if(pC_CPlan.PCCP_Impervious_IsChanged){sbParameter.Append("PCCP_Impervious=@PCCP_Impervious, ");}
      if(pC_CPlan.PCCP_Volume_IsChanged){sbParameter.Append("PCCP_Volume=@PCCP_Volume, ");}
      if(pC_CPlan.PCCP_Slump_IsChanged){sbParameter.Append("PCCP_Slump=@PCCP_Slump, ");}
      if(pC_CPlan.PCCP_SubmitDate_IsChanged){sbParameter.Append("PCCP_SubmitDate=@PCCP_SubmitDate, ");}
      if(pC_CPlan.PCCP_BeginTime_IsChanged){sbParameter.Append("PCCP_BeginTime=@PCCP_BeginTime, ");}
      if(pC_CPlan.PCCP_SPC_IsChanged){sbParameter.Append("PCCP_SPC=@PCCP_SPC, ");}
      if(pC_CPlan.PCCP_Request1_IsChanged){sbParameter.Append("PCCP_Request1=@PCCP_Request1, ");}
      if(pC_CPlan.PCCP_Request2_IsChanged){sbParameter.Append("PCCP_Request2=@PCCP_Request2, ");}
      if(pC_CPlan.PCCP_Request3_IsChanged){sbParameter.Append("PCCP_Request3=@PCCP_Request3, ");}
      if(pC_CPlan.PCCP_Request4_IsChanged){sbParameter.Append("PCCP_Request4=@PCCP_Request4, ");}
      if(pC_CPlan.PCCP_Request5_IsChanged){sbParameter.Append("PCCP_Request5=@PCCP_Request5, ");}
      if(pC_CPlan.PCCP_Transpot_IsChanged){sbParameter.Append("PCCP_Transpot=@PCCP_Transpot, ");}
      if(pC_CPlan.PCCP_Stat_IsChanged){sbParameter.Append("PCCP_Stat=@PCCP_Stat, ");}
      if(pC_CPlan.PCCP_Remark1_IsChanged){sbParameter.Append("PCCP_Remark1=@PCCP_Remark1, ");}
      if(pC_CPlan.PCCP_Remark2_IsChanged){sbParameter.Append("PCCP_Remark2=@PCCP_Remark2, ");}
      if(pC_CPlan.PCCP_CurStep_IsChanged){sbParameter.Append("PCCP_CurStep=@PCCP_CurStep, ");}
      if(pC_CPlan.PCCP_NextStep_IsChanged){sbParameter.Append("PCCP_NextStep=@PCCP_NextStep, ");}
      if(pC_CPlan.PCCP_Owner_IsChanged){sbParameter.Append("PCCP_Owner=@PCCP_Owner, ");}
      if(pC_CPlan.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_CPlan.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_CPlan.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_CPlan.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pC_CPlan.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(pC_CPlan.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(pC_CPlan.LastAuditor_IsChanged){sbParameter.Append("LastAuditor=@LastAuditor, ");}
      if(pC_CPlan.LastAuditDate_IsChanged){sbParameter.Append("LastAuditDate=@LastAuditDate, ");}
      if(pC_CPlan.PCCP_Udef1_IsChanged){sbParameter.Append("PCCP_Udef1=@PCCP_Udef1, ");}
      if(pC_CPlan.PCCP_Udef2_IsChanged){sbParameter.Append("PCCP_Udef2=@PCCP_Udef2, ");}
      if(pC_CPlan.PCCP_Udef3_IsChanged){sbParameter.Append("PCCP_Udef3=@PCCP_Udef3, ");}
      if(pC_CPlan.PCCP_Udef4_IsChanged){sbParameter.Append("PCCP_Udef4=@PCCP_Udef4, ");}
      if(pC_CPlan.PCCP_Udef5_IsChanged){sbParameter.Append("PCCP_Udef5=@PCCP_Udef5 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCCP_ID=@PCCP_ID; " );
      string sql=sb.ToString();
         if(pC_CPlan.PCCP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Code))
         {
            idb.AddParameter("@PCCP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Code", pC_CPlan.PCCP_Code);
         }
          }
         if(pC_CPlan.PCCP_CustomerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CustomerCode))
         {
            idb.AddParameter("@PCCP_CustomerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CustomerCode", pC_CPlan.PCCP_CustomerCode);
         }
          }
         if(pC_CPlan.PCCP_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CName))
         {
            idb.AddParameter("@PCCP_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CName", pC_CPlan.PCCP_CName);
         }
          }
         if(pC_CPlan.PCCP_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CCode))
         {
            idb.AddParameter("@PCCP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CCode", pC_CPlan.PCCP_CCode);
         }
          }
         if(pC_CPlan.PCCP_ProjectCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProjectCode))
         {
            idb.AddParameter("@PCCP_ProjectCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProjectCode", pC_CPlan.PCCP_ProjectCode);
         }
          }
         if(pC_CPlan.PCCP_ProjectName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProjectName))
         {
            idb.AddParameter("@PCCP_ProjectName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProjectName", pC_CPlan.PCCP_ProjectName);
         }
          }
         if(pC_CPlan.PCCP_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Address))
         {
            idb.AddParameter("@PCCP_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Address", pC_CPlan.PCCP_Address);
         }
          }
         if(pC_CPlan.PCCP_Part_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Part))
         {
            idb.AddParameter("@PCCP_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Part", pC_CPlan.PCCP_Part);
         }
          }
         if(pC_CPlan.PCCP_ProdName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_ProdName))
         {
            idb.AddParameter("@PCCP_ProdName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_ProdName", pC_CPlan.PCCP_ProdName);
         }
          }
         if(pC_CPlan.PCCP_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Level))
         {
            idb.AddParameter("@PCCP_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Level", pC_CPlan.PCCP_Level);
         }
          }
         if(pC_CPlan.PCCP_Impervious_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Impervious))
         {
            idb.AddParameter("@PCCP_Impervious", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Impervious", pC_CPlan.PCCP_Impervious);
         }
          }
         if(pC_CPlan.PCCP_Volume_IsChanged)
         {
         if (pC_CPlan.PCCP_Volume == 0)
         {
            idb.AddParameter("@PCCP_Volume", 0);
         }
         else
         {
            idb.AddParameter("@PCCP_Volume", pC_CPlan.PCCP_Volume);
         }
          }
         if(pC_CPlan.PCCP_Slump_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Slump))
         {
            idb.AddParameter("@PCCP_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Slump", pC_CPlan.PCCP_Slump);
         }
          }
         if(pC_CPlan.PCCP_SubmitDate_IsChanged)
         {
         if (pC_CPlan.PCCP_SubmitDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCCP_SubmitDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_SubmitDate", pC_CPlan.PCCP_SubmitDate);
         }
          }
         if(pC_CPlan.PCCP_BeginTime_IsChanged)
         {
         if (pC_CPlan.PCCP_BeginTime == DateTime.MinValue)
         {
            idb.AddParameter("@PCCP_BeginTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_BeginTime", pC_CPlan.PCCP_BeginTime);
         }
          }
         if(pC_CPlan.PCCP_SPC_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_SPC))
         {
            idb.AddParameter("@PCCP_SPC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_SPC", pC_CPlan.PCCP_SPC);
         }
          }
         if(pC_CPlan.PCCP_Request1_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request1))
         {
            idb.AddParameter("@PCCP_Request1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request1", pC_CPlan.PCCP_Request1);
         }
          }
         if(pC_CPlan.PCCP_Request2_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request2))
         {
            idb.AddParameter("@PCCP_Request2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request2", pC_CPlan.PCCP_Request2);
         }
          }
         if(pC_CPlan.PCCP_Request3_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request3))
         {
            idb.AddParameter("@PCCP_Request3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request3", pC_CPlan.PCCP_Request3);
         }
          }
         if(pC_CPlan.PCCP_Request4_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request4))
         {
            idb.AddParameter("@PCCP_Request4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request4", pC_CPlan.PCCP_Request4);
         }
          }
         if(pC_CPlan.PCCP_Request5_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Request5))
         {
            idb.AddParameter("@PCCP_Request5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Request5", pC_CPlan.PCCP_Request5);
         }
          }
         if(pC_CPlan.PCCP_Transpot_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Transpot))
         {
            idb.AddParameter("@PCCP_Transpot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Transpot", pC_CPlan.PCCP_Transpot);
         }
          }
         if(pC_CPlan.PCCP_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Stat))
         {
            idb.AddParameter("@PCCP_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Stat", pC_CPlan.PCCP_Stat);
         }
          }
         if(pC_CPlan.PCCP_Remark1_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Remark1))
         {
            idb.AddParameter("@PCCP_Remark1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Remark1", pC_CPlan.PCCP_Remark1);
         }
          }
         if(pC_CPlan.PCCP_Remark2_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Remark2))
         {
            idb.AddParameter("@PCCP_Remark2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Remark2", pC_CPlan.PCCP_Remark2);
         }
          }
         if(pC_CPlan.PCCP_CurStep_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_CurStep))
         {
            idb.AddParameter("@PCCP_CurStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_CurStep", pC_CPlan.PCCP_CurStep);
         }
          }
         if(pC_CPlan.PCCP_NextStep_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_NextStep))
         {
            idb.AddParameter("@PCCP_NextStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_NextStep", pC_CPlan.PCCP_NextStep);
         }
          }
         if(pC_CPlan.PCCP_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Owner))
         {
            idb.AddParameter("@PCCP_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Owner", pC_CPlan.PCCP_Owner);
         }
          }
         if(pC_CPlan.Stat_IsChanged)
         {
         if (pC_CPlan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_CPlan.Stat);
         }
          }
         if(pC_CPlan.CreateDate_IsChanged)
         {
         if (pC_CPlan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_CPlan.CreateDate);
         }
          }
         if(pC_CPlan.UpdateDate_IsChanged)
         {
         if (pC_CPlan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_CPlan.UpdateDate);
         }
          }
         if(pC_CPlan.DeleteDate_IsChanged)
         {
         if (pC_CPlan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_CPlan.DeleteDate);
         }
          }
         if(pC_CPlan.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pC_CPlan.AuditStat);
         }
          }
         if(pC_CPlan.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pC_CPlan.AuditCurAudit);
         }
          }
         if(pC_CPlan.LastAuditor_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.LastAuditor))
         {
            idb.AddParameter("@LastAuditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LastAuditor", pC_CPlan.LastAuditor);
         }
          }
         if(pC_CPlan.LastAuditDate_IsChanged)
         {
         if (pC_CPlan.LastAuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@LastAuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LastAuditDate", pC_CPlan.LastAuditDate);
         }
          }
         if(pC_CPlan.PCCP_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef1))
         {
            idb.AddParameter("@PCCP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef1", pC_CPlan.PCCP_Udef1);
         }
          }
         if(pC_CPlan.PCCP_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef2))
         {
            idb.AddParameter("@PCCP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef2", pC_CPlan.PCCP_Udef2);
         }
          }
         if(pC_CPlan.PCCP_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef3))
         {
            idb.AddParameter("@PCCP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef3", pC_CPlan.PCCP_Udef3);
         }
          }
         if(pC_CPlan.PCCP_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef4))
         {
            idb.AddParameter("@PCCP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef4", pC_CPlan.PCCP_Udef4);
         }
          }
         if(pC_CPlan.PCCP_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_CPlan.PCCP_Udef5))
         {
            idb.AddParameter("@PCCP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCP_Udef5", pC_CPlan.PCCP_Udef5);
         }
          }

         idb.AddParameter("@PCCP_ID", pC_CPlan.PCCP_ID);

           
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
      /// 删除PC_CPlan对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCCP_ID)
      {
         string sql = "DELETE PC_CPlan WHERE 1=1  AND PCCP_ID=@PCCP_ID ";
         idb.AddParameter("@PCCP_ID", pCCP_ID);

           
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
      /// 获取指定的PC_CPlan对象(即:一条记录
      /// </summary>
      public PC_CPlan GetByKey(decimal pCCP_ID)
      {
         PC_CPlan pC_CPlan = new PC_CPlan();
         string sql = "SELECT  PCCP_ID,PCCP_Code,PCCP_CustomerCode,PCCP_CName,PCCP_CCode,PCCP_ProjectCode,PCCP_ProjectName,PCCP_Address,PCCP_Part,PCCP_ProdName,PCCP_Level,PCCP_Impervious,PCCP_Volume,PCCP_Slump,PCCP_SubmitDate,PCCP_BeginTime,PCCP_SPC,PCCP_Request1,PCCP_Request2,PCCP_Request3,PCCP_Request4,PCCP_Request5,PCCP_Transpot,PCCP_Stat,PCCP_Remark1,PCCP_Remark2,PCCP_CurStep,PCCP_NextStep,PCCP_Owner,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,LastAuditor,LastAuditDate,PCCP_Udef1,PCCP_Udef2,PCCP_Udef3,PCCP_Udef4,PCCP_Udef5 FROM PC_CPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCCP_ID=@PCCP_ID ";
         idb.AddParameter("@PCCP_ID", pCCP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCCP_ID"] != DBNull.Value) pC_CPlan.PCCP_ID = Convert.ToDecimal(dr["PCCP_ID"]);
            if (dr["PCCP_Code"] != DBNull.Value) pC_CPlan.PCCP_Code = Convert.ToString(dr["PCCP_Code"]);
            if (dr["PCCP_CustomerCode"] != DBNull.Value) pC_CPlan.PCCP_CustomerCode = Convert.ToString(dr["PCCP_CustomerCode"]);
            if (dr["PCCP_CName"] != DBNull.Value) pC_CPlan.PCCP_CName = Convert.ToString(dr["PCCP_CName"]);
            if (dr["PCCP_CCode"] != DBNull.Value) pC_CPlan.PCCP_CCode = Convert.ToString(dr["PCCP_CCode"]);
            if (dr["PCCP_ProjectCode"] != DBNull.Value) pC_CPlan.PCCP_ProjectCode = Convert.ToString(dr["PCCP_ProjectCode"]);
            if (dr["PCCP_ProjectName"] != DBNull.Value) pC_CPlan.PCCP_ProjectName = Convert.ToString(dr["PCCP_ProjectName"]);
            if (dr["PCCP_Address"] != DBNull.Value) pC_CPlan.PCCP_Address = Convert.ToString(dr["PCCP_Address"]);
            if (dr["PCCP_Part"] != DBNull.Value) pC_CPlan.PCCP_Part = Convert.ToString(dr["PCCP_Part"]);
            if (dr["PCCP_ProdName"] != DBNull.Value) pC_CPlan.PCCP_ProdName = Convert.ToString(dr["PCCP_ProdName"]);
            if (dr["PCCP_Level"] != DBNull.Value) pC_CPlan.PCCP_Level = Convert.ToString(dr["PCCP_Level"]);
            if (dr["PCCP_Impervious"] != DBNull.Value) pC_CPlan.PCCP_Impervious = Convert.ToString(dr["PCCP_Impervious"]);
            if (dr["PCCP_Volume"] != DBNull.Value) pC_CPlan.PCCP_Volume = Convert.ToInt32(dr["PCCP_Volume"]);
            if (dr["PCCP_Slump"] != DBNull.Value) pC_CPlan.PCCP_Slump = Convert.ToString(dr["PCCP_Slump"]);
            if (dr["PCCP_SubmitDate"] != DBNull.Value) pC_CPlan.PCCP_SubmitDate = Convert.ToDateTime(dr["PCCP_SubmitDate"]);
            if (dr["PCCP_BeginTime"] != DBNull.Value) pC_CPlan.PCCP_BeginTime = Convert.ToDateTime(dr["PCCP_BeginTime"]);
            if (dr["PCCP_SPC"] != DBNull.Value) pC_CPlan.PCCP_SPC = Convert.ToString(dr["PCCP_SPC"]);
            if (dr["PCCP_Request1"] != DBNull.Value) pC_CPlan.PCCP_Request1 = Convert.ToString(dr["PCCP_Request1"]);
            if (dr["PCCP_Request2"] != DBNull.Value) pC_CPlan.PCCP_Request2 = Convert.ToString(dr["PCCP_Request2"]);
            if (dr["PCCP_Request3"] != DBNull.Value) pC_CPlan.PCCP_Request3 = Convert.ToString(dr["PCCP_Request3"]);
            if (dr["PCCP_Request4"] != DBNull.Value) pC_CPlan.PCCP_Request4 = Convert.ToString(dr["PCCP_Request4"]);
            if (dr["PCCP_Request5"] != DBNull.Value) pC_CPlan.PCCP_Request5 = Convert.ToString(dr["PCCP_Request5"]);
            if (dr["PCCP_Transpot"] != DBNull.Value) pC_CPlan.PCCP_Transpot = Convert.ToString(dr["PCCP_Transpot"]);
            if (dr["PCCP_Stat"] != DBNull.Value) pC_CPlan.PCCP_Stat = Convert.ToString(dr["PCCP_Stat"]);
            if (dr["PCCP_Remark1"] != DBNull.Value) pC_CPlan.PCCP_Remark1 = Convert.ToString(dr["PCCP_Remark1"]);
            if (dr["PCCP_Remark2"] != DBNull.Value) pC_CPlan.PCCP_Remark2 = Convert.ToString(dr["PCCP_Remark2"]);
            if (dr["PCCP_CurStep"] != DBNull.Value) pC_CPlan.PCCP_CurStep = Convert.ToString(dr["PCCP_CurStep"]);
            if (dr["PCCP_NextStep"] != DBNull.Value) pC_CPlan.PCCP_NextStep = Convert.ToString(dr["PCCP_NextStep"]);
            if (dr["PCCP_Owner"] != DBNull.Value) pC_CPlan.PCCP_Owner = Convert.ToString(dr["PCCP_Owner"]);
            if (dr["Stat"] != DBNull.Value) pC_CPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_CPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_CPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_CPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) pC_CPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pC_CPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["LastAuditor"] != DBNull.Value) pC_CPlan.LastAuditor = Convert.ToString(dr["LastAuditor"]);
            if (dr["LastAuditDate"] != DBNull.Value) pC_CPlan.LastAuditDate = Convert.ToDateTime(dr["LastAuditDate"]);
            if (dr["PCCP_Udef1"] != DBNull.Value) pC_CPlan.PCCP_Udef1 = Convert.ToString(dr["PCCP_Udef1"]);
            if (dr["PCCP_Udef2"] != DBNull.Value) pC_CPlan.PCCP_Udef2 = Convert.ToString(dr["PCCP_Udef2"]);
            if (dr["PCCP_Udef3"] != DBNull.Value) pC_CPlan.PCCP_Udef3 = Convert.ToString(dr["PCCP_Udef3"]);
            if (dr["PCCP_Udef4"] != DBNull.Value) pC_CPlan.PCCP_Udef4 = Convert.ToString(dr["PCCP_Udef4"]);
            if (dr["PCCP_Udef5"] != DBNull.Value) pC_CPlan.PCCP_Udef5 = Convert.ToString(dr["PCCP_Udef5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_CPlan;
      }
      /// <summary>
      /// 获取指定的PC_CPlan对象集合
      /// </summary>
      public List<PC_CPlan> GetListByWhere(string strCondition)
      {
         List<PC_CPlan> ret = new List<PC_CPlan>();
         string sql = "SELECT  PCCP_ID,PCCP_Code,PCCP_CustomerCode,PCCP_CName,PCCP_CCode,PCCP_ProjectCode,PCCP_ProjectName,PCCP_Address,PCCP_Part,PCCP_ProdName,PCCP_Level,PCCP_Impervious,PCCP_Volume,PCCP_Slump,PCCP_SubmitDate,PCCP_BeginTime,PCCP_SPC,PCCP_Request1,PCCP_Request2,PCCP_Request3,PCCP_Request4,PCCP_Request5,PCCP_Transpot,PCCP_Stat,PCCP_Remark1,PCCP_Remark2,PCCP_CurStep,PCCP_NextStep,PCCP_Owner,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,LastAuditor,LastAuditDate,PCCP_Udef1,PCCP_Udef2,PCCP_Udef3,PCCP_Udef4,PCCP_Udef5 FROM PC_CPlan WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_CPlan pC_CPlan = new PC_CPlan();
            if (dr["PCCP_ID"] != DBNull.Value) pC_CPlan.PCCP_ID = Convert.ToDecimal(dr["PCCP_ID"]);
            if (dr["PCCP_Code"] != DBNull.Value) pC_CPlan.PCCP_Code = Convert.ToString(dr["PCCP_Code"]);
            if (dr["PCCP_CustomerCode"] != DBNull.Value) pC_CPlan.PCCP_CustomerCode = Convert.ToString(dr["PCCP_CustomerCode"]);
            if (dr["PCCP_CName"] != DBNull.Value) pC_CPlan.PCCP_CName = Convert.ToString(dr["PCCP_CName"]);
            if (dr["PCCP_CCode"] != DBNull.Value) pC_CPlan.PCCP_CCode = Convert.ToString(dr["PCCP_CCode"]);
            if (dr["PCCP_ProjectCode"] != DBNull.Value) pC_CPlan.PCCP_ProjectCode = Convert.ToString(dr["PCCP_ProjectCode"]);
            if (dr["PCCP_ProjectName"] != DBNull.Value) pC_CPlan.PCCP_ProjectName = Convert.ToString(dr["PCCP_ProjectName"]);
            if (dr["PCCP_Address"] != DBNull.Value) pC_CPlan.PCCP_Address = Convert.ToString(dr["PCCP_Address"]);
            if (dr["PCCP_Part"] != DBNull.Value) pC_CPlan.PCCP_Part = Convert.ToString(dr["PCCP_Part"]);
            if (dr["PCCP_ProdName"] != DBNull.Value) pC_CPlan.PCCP_ProdName = Convert.ToString(dr["PCCP_ProdName"]);
            if (dr["PCCP_Level"] != DBNull.Value) pC_CPlan.PCCP_Level = Convert.ToString(dr["PCCP_Level"]);
            if (dr["PCCP_Impervious"] != DBNull.Value) pC_CPlan.PCCP_Impervious = Convert.ToString(dr["PCCP_Impervious"]);
            if (dr["PCCP_Volume"] != DBNull.Value) pC_CPlan.PCCP_Volume = Convert.ToInt32(dr["PCCP_Volume"]);
            if (dr["PCCP_Slump"] != DBNull.Value) pC_CPlan.PCCP_Slump = Convert.ToString(dr["PCCP_Slump"]);
            if (dr["PCCP_SubmitDate"] != DBNull.Value) pC_CPlan.PCCP_SubmitDate = Convert.ToDateTime(dr["PCCP_SubmitDate"]);
            if (dr["PCCP_BeginTime"] != DBNull.Value) pC_CPlan.PCCP_BeginTime = Convert.ToDateTime(dr["PCCP_BeginTime"]);
            if (dr["PCCP_SPC"] != DBNull.Value) pC_CPlan.PCCP_SPC = Convert.ToString(dr["PCCP_SPC"]);
            if (dr["PCCP_Request1"] != DBNull.Value) pC_CPlan.PCCP_Request1 = Convert.ToString(dr["PCCP_Request1"]);
            if (dr["PCCP_Request2"] != DBNull.Value) pC_CPlan.PCCP_Request2 = Convert.ToString(dr["PCCP_Request2"]);
            if (dr["PCCP_Request3"] != DBNull.Value) pC_CPlan.PCCP_Request3 = Convert.ToString(dr["PCCP_Request3"]);
            if (dr["PCCP_Request4"] != DBNull.Value) pC_CPlan.PCCP_Request4 = Convert.ToString(dr["PCCP_Request4"]);
            if (dr["PCCP_Request5"] != DBNull.Value) pC_CPlan.PCCP_Request5 = Convert.ToString(dr["PCCP_Request5"]);
            if (dr["PCCP_Transpot"] != DBNull.Value) pC_CPlan.PCCP_Transpot = Convert.ToString(dr["PCCP_Transpot"]);
            if (dr["PCCP_Stat"] != DBNull.Value) pC_CPlan.PCCP_Stat = Convert.ToString(dr["PCCP_Stat"]);
            if (dr["PCCP_Remark1"] != DBNull.Value) pC_CPlan.PCCP_Remark1 = Convert.ToString(dr["PCCP_Remark1"]);
            if (dr["PCCP_Remark2"] != DBNull.Value) pC_CPlan.PCCP_Remark2 = Convert.ToString(dr["PCCP_Remark2"]);
            if (dr["PCCP_CurStep"] != DBNull.Value) pC_CPlan.PCCP_CurStep = Convert.ToString(dr["PCCP_CurStep"]);
            if (dr["PCCP_NextStep"] != DBNull.Value) pC_CPlan.PCCP_NextStep = Convert.ToString(dr["PCCP_NextStep"]);
            if (dr["PCCP_Owner"] != DBNull.Value) pC_CPlan.PCCP_Owner = Convert.ToString(dr["PCCP_Owner"]);
            if (dr["Stat"] != DBNull.Value) pC_CPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_CPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_CPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_CPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) pC_CPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pC_CPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["LastAuditor"] != DBNull.Value) pC_CPlan.LastAuditor = Convert.ToString(dr["LastAuditor"]);
            if (dr["LastAuditDate"] != DBNull.Value) pC_CPlan.LastAuditDate = Convert.ToDateTime(dr["LastAuditDate"]);
            if (dr["PCCP_Udef1"] != DBNull.Value) pC_CPlan.PCCP_Udef1 = Convert.ToString(dr["PCCP_Udef1"]);
            if (dr["PCCP_Udef2"] != DBNull.Value) pC_CPlan.PCCP_Udef2 = Convert.ToString(dr["PCCP_Udef2"]);
            if (dr["PCCP_Udef3"] != DBNull.Value) pC_CPlan.PCCP_Udef3 = Convert.ToString(dr["PCCP_Udef3"]);
            if (dr["PCCP_Udef4"] != DBNull.Value) pC_CPlan.PCCP_Udef4 = Convert.ToString(dr["PCCP_Udef4"]);
            if (dr["PCCP_Udef5"] != DBNull.Value) pC_CPlan.PCCP_Udef5 = Convert.ToString(dr["PCCP_Udef5"]);
            ret.Add(pC_CPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PC_CPlan对象(即:一条记录
      /// </summary>
      public List<PC_CPlan> GetAll()
      {
         List<PC_CPlan> ret = new List<PC_CPlan>();
         string sql = "SELECT  PCCP_ID,PCCP_Code,PCCP_CustomerCode,PCCP_CName,PCCP_CCode,PCCP_ProjectCode,PCCP_ProjectName,PCCP_Address,PCCP_Part,PCCP_ProdName,PCCP_Level,PCCP_Impervious,PCCP_Volume,PCCP_Slump,PCCP_SubmitDate,PCCP_BeginTime,PCCP_SPC,PCCP_Request1,PCCP_Request2,PCCP_Request3,PCCP_Request4,PCCP_Request5,PCCP_Transpot,PCCP_Stat,PCCP_Remark1,PCCP_Remark2,PCCP_CurStep,PCCP_NextStep,PCCP_Owner,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,LastAuditor,LastAuditDate,PCCP_Udef1,PCCP_Udef2,PCCP_Udef3,PCCP_Udef4,PCCP_Udef5 FROM PC_CPlan where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCCP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_CPlan pC_CPlan = new PC_CPlan();
            if (dr["PCCP_ID"] != DBNull.Value) pC_CPlan.PCCP_ID = Convert.ToDecimal(dr["PCCP_ID"]);
            if (dr["PCCP_Code"] != DBNull.Value) pC_CPlan.PCCP_Code = Convert.ToString(dr["PCCP_Code"]);
            if (dr["PCCP_CustomerCode"] != DBNull.Value) pC_CPlan.PCCP_CustomerCode = Convert.ToString(dr["PCCP_CustomerCode"]);
            if (dr["PCCP_CName"] != DBNull.Value) pC_CPlan.PCCP_CName = Convert.ToString(dr["PCCP_CName"]);
            if (dr["PCCP_CCode"] != DBNull.Value) pC_CPlan.PCCP_CCode = Convert.ToString(dr["PCCP_CCode"]);
            if (dr["PCCP_ProjectCode"] != DBNull.Value) pC_CPlan.PCCP_ProjectCode = Convert.ToString(dr["PCCP_ProjectCode"]);
            if (dr["PCCP_ProjectName"] != DBNull.Value) pC_CPlan.PCCP_ProjectName = Convert.ToString(dr["PCCP_ProjectName"]);
            if (dr["PCCP_Address"] != DBNull.Value) pC_CPlan.PCCP_Address = Convert.ToString(dr["PCCP_Address"]);
            if (dr["PCCP_Part"] != DBNull.Value) pC_CPlan.PCCP_Part = Convert.ToString(dr["PCCP_Part"]);
            if (dr["PCCP_ProdName"] != DBNull.Value) pC_CPlan.PCCP_ProdName = Convert.ToString(dr["PCCP_ProdName"]);
            if (dr["PCCP_Level"] != DBNull.Value) pC_CPlan.PCCP_Level = Convert.ToString(dr["PCCP_Level"]);
            if (dr["PCCP_Impervious"] != DBNull.Value) pC_CPlan.PCCP_Impervious = Convert.ToString(dr["PCCP_Impervious"]);
            if (dr["PCCP_Volume"] != DBNull.Value) pC_CPlan.PCCP_Volume = Convert.ToInt32(dr["PCCP_Volume"]);
            if (dr["PCCP_Slump"] != DBNull.Value) pC_CPlan.PCCP_Slump = Convert.ToString(dr["PCCP_Slump"]);
            if (dr["PCCP_SubmitDate"] != DBNull.Value) pC_CPlan.PCCP_SubmitDate = Convert.ToDateTime(dr["PCCP_SubmitDate"]);
            if (dr["PCCP_BeginTime"] != DBNull.Value) pC_CPlan.PCCP_BeginTime = Convert.ToDateTime(dr["PCCP_BeginTime"]);
            if (dr["PCCP_SPC"] != DBNull.Value) pC_CPlan.PCCP_SPC = Convert.ToString(dr["PCCP_SPC"]);
            if (dr["PCCP_Request1"] != DBNull.Value) pC_CPlan.PCCP_Request1 = Convert.ToString(dr["PCCP_Request1"]);
            if (dr["PCCP_Request2"] != DBNull.Value) pC_CPlan.PCCP_Request2 = Convert.ToString(dr["PCCP_Request2"]);
            if (dr["PCCP_Request3"] != DBNull.Value) pC_CPlan.PCCP_Request3 = Convert.ToString(dr["PCCP_Request3"]);
            if (dr["PCCP_Request4"] != DBNull.Value) pC_CPlan.PCCP_Request4 = Convert.ToString(dr["PCCP_Request4"]);
            if (dr["PCCP_Request5"] != DBNull.Value) pC_CPlan.PCCP_Request5 = Convert.ToString(dr["PCCP_Request5"]);
            if (dr["PCCP_Transpot"] != DBNull.Value) pC_CPlan.PCCP_Transpot = Convert.ToString(dr["PCCP_Transpot"]);
            if (dr["PCCP_Stat"] != DBNull.Value) pC_CPlan.PCCP_Stat = Convert.ToString(dr["PCCP_Stat"]);
            if (dr["PCCP_Remark1"] != DBNull.Value) pC_CPlan.PCCP_Remark1 = Convert.ToString(dr["PCCP_Remark1"]);
            if (dr["PCCP_Remark2"] != DBNull.Value) pC_CPlan.PCCP_Remark2 = Convert.ToString(dr["PCCP_Remark2"]);
            if (dr["PCCP_CurStep"] != DBNull.Value) pC_CPlan.PCCP_CurStep = Convert.ToString(dr["PCCP_CurStep"]);
            if (dr["PCCP_NextStep"] != DBNull.Value) pC_CPlan.PCCP_NextStep = Convert.ToString(dr["PCCP_NextStep"]);
            if (dr["PCCP_Owner"] != DBNull.Value) pC_CPlan.PCCP_Owner = Convert.ToString(dr["PCCP_Owner"]);
            if (dr["Stat"] != DBNull.Value) pC_CPlan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_CPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_CPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_CPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) pC_CPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pC_CPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["LastAuditor"] != DBNull.Value) pC_CPlan.LastAuditor = Convert.ToString(dr["LastAuditor"]);
            if (dr["LastAuditDate"] != DBNull.Value) pC_CPlan.LastAuditDate = Convert.ToDateTime(dr["LastAuditDate"]);
            if (dr["PCCP_Udef1"] != DBNull.Value) pC_CPlan.PCCP_Udef1 = Convert.ToString(dr["PCCP_Udef1"]);
            if (dr["PCCP_Udef2"] != DBNull.Value) pC_CPlan.PCCP_Udef2 = Convert.ToString(dr["PCCP_Udef2"]);
            if (dr["PCCP_Udef3"] != DBNull.Value) pC_CPlan.PCCP_Udef3 = Convert.ToString(dr["PCCP_Udef3"]);
            if (dr["PCCP_Udef4"] != DBNull.Value) pC_CPlan.PCCP_Udef4 = Convert.ToString(dr["PCCP_Udef4"]);
            if (dr["PCCP_Udef5"] != DBNull.Value) pC_CPlan.PCCP_Udef5 = Convert.ToString(dr["PCCP_Udef5"]);
            ret.Add(pC_CPlan);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
