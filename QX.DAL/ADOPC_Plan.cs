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
   /// 生产计划
   /// </summary>
   [Serializable]
   public partial class ADOPC_Plan
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产计划 PC_Plan对象(即:一条记录)
      /// </summary>
      public int Add(PC_Plan pC_Plan)
      {
         string sql = "INSERT INTO PC_Plan (PCP_PCode,PCP_SCode,PCP_Name,PCP_CPCode,PCP_PRCode,PCP_CCode,PCP_Part,PCP_Slump,PCP_Addr,PCP_IsPipe,PCP_PLCode,PCP_Leve,PCP_Impervious,PCP_SPC,PCP_Special1,PCP_Special2,PCP_Special3,PCP_Special4,PCP_Special5,PCP_PDate,PCP_RDate,PCP_POwner,PCP_POwnerName,PCP_Date,PCP_CureStep,PCP_NextStep,PCP_IsTech,PCP_IsStart,PCP_PMNum,PCP_PUNum,PCP_PINum,PCP_PJNum,PCP_PTNum,PCP_PWNum,PCP_PPNum,PCP_PRNum,PCP_PTRNum,PCP_PPRNum,PCP_PPMNum,PCP_PTMNum,PCP_TechType,PCP_Limit,PCP_Frequence,PCP_LastDate,PCP_LastNo,PCP_Transpot,PCP_Order,PCP_DBack,PCP_Status,PCP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCP_Udef1,PCP_Udef2,PCP_Udef3,PCP_Udef4,PCP_Udef5,PCP_Udef6,PCP_Udef7,AuditCurAudit,AuditStat,PCP_LNum,PCP_ANum,PCP_Price,PCP_Sum,PCP_TankerFee,PCP_PumpFee,PCP_Operator,PCP_Schdule,PCP_Station,PCP_StatonName) VALUES (@PCP_PCode,@PCP_SCode,@PCP_Name,@PCP_CPCode,@PCP_PRCode,@PCP_CCode,@PCP_Part,@PCP_Slump,@PCP_Addr,@PCP_IsPipe,@PCP_PLCode,@PCP_Leve,@PCP_Impervious,@PCP_SPC,@PCP_Special1,@PCP_Special2,@PCP_Special3,@PCP_Special4,@PCP_Special5,@PCP_PDate,@PCP_RDate,@PCP_POwner,@PCP_POwnerName,@PCP_Date,@PCP_CureStep,@PCP_NextStep,@PCP_IsTech,@PCP_IsStart,@PCP_PMNum,@PCP_PUNum,@PCP_PINum,@PCP_PJNum,@PCP_PTNum,@PCP_PWNum,@PCP_PPNum,@PCP_PRNum,@PCP_PTRNum,@PCP_PPRNum,@PCP_PPMNum,@PCP_PTMNum,@PCP_TechType,@PCP_Limit,@PCP_Frequence,@PCP_LastDate,@PCP_LastNo,@PCP_Transpot,@PCP_Order,@PCP_DBack,@PCP_Status,@PCP_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCP_Udef1,@PCP_Udef2,@PCP_Udef3,@PCP_Udef4,@PCP_Udef5,@PCP_Udef6,@PCP_Udef7,@AuditCurAudit,@AuditStat,@PCP_LNum,@PCP_ANum,@PCP_Price,@PCP_Sum,@PCP_TankerFee,@PCP_PumpFee,@PCP_Operator,@PCP_Schdule,@PCP_Station,@PCP_StatonName)";
         if (string.IsNullOrEmpty(pC_Plan.PCP_PCode))
         {
            idb.AddParameter("@PCP_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PCode", pC_Plan.PCP_PCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_SCode))
         {
            idb.AddParameter("@PCP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_SCode", pC_Plan.PCP_SCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Name))
         {
            idb.AddParameter("@PCP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Name", pC_Plan.PCP_Name);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_CPCode))
         {
            idb.AddParameter("@PCP_CPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CPCode", pC_Plan.PCP_CPCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PRCode))
         {
            idb.AddParameter("@PCP_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PRCode", pC_Plan.PCP_PRCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_CCode))
         {
            idb.AddParameter("@PCP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CCode", pC_Plan.PCP_CCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Part))
         {
            idb.AddParameter("@PCP_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Part", pC_Plan.PCP_Part);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Slump))
         {
            idb.AddParameter("@PCP_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Slump", pC_Plan.PCP_Slump);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Addr))
         {
            idb.AddParameter("@PCP_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Addr", pC_Plan.PCP_Addr);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_IsPipe))
         {
            idb.AddParameter("@PCP_IsPipe", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_IsPipe", pC_Plan.PCP_IsPipe);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PLCode))
         {
            idb.AddParameter("@PCP_PLCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PLCode", pC_Plan.PCP_PLCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Leve))
         {
            idb.AddParameter("@PCP_Leve", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Leve", pC_Plan.PCP_Leve);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Impervious))
         {
            idb.AddParameter("@PCP_Impervious", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Impervious", pC_Plan.PCP_Impervious);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_SPC))
         {
            idb.AddParameter("@PCP_SPC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_SPC", pC_Plan.PCP_SPC);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special1))
         {
            idb.AddParameter("@PCP_Special1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special1", pC_Plan.PCP_Special1);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special2))
         {
            idb.AddParameter("@PCP_Special2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special2", pC_Plan.PCP_Special2);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special3))
         {
            idb.AddParameter("@PCP_Special3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special3", pC_Plan.PCP_Special3);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special4))
         {
            idb.AddParameter("@PCP_Special4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special4", pC_Plan.PCP_Special4);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special5))
         {
            idb.AddParameter("@PCP_Special5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special5", pC_Plan.PCP_Special5);
         }
         if (pC_Plan.PCP_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PDate", pC_Plan.PCP_PDate);
         }
         if (pC_Plan.PCP_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_RDate", pC_Plan.PCP_RDate);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_POwner))
         {
            idb.AddParameter("@PCP_POwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_POwner", pC_Plan.PCP_POwner);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_POwnerName))
         {
            idb.AddParameter("@PCP_POwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_POwnerName", pC_Plan.PCP_POwnerName);
         }
         if (pC_Plan.PCP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Date", pC_Plan.PCP_Date);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_CureStep))
         {
            idb.AddParameter("@PCP_CureStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CureStep", pC_Plan.PCP_CureStep);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_NextStep))
         {
            idb.AddParameter("@PCP_NextStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_NextStep", pC_Plan.PCP_NextStep);
         }
         if (pC_Plan.PCP_IsTech == 0)
         {
            idb.AddParameter("@PCP_IsTech", 0);
         }
         else
         {
            idb.AddParameter("@PCP_IsTech", pC_Plan.PCP_IsTech);
         }
         if (pC_Plan.PCP_IsStart == 0)
         {
            idb.AddParameter("@PCP_IsStart", 0);
         }
         else
         {
            idb.AddParameter("@PCP_IsStart", pC_Plan.PCP_IsStart);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PMNum))
         {
            idb.AddParameter("@PCP_PMNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PMNum", pC_Plan.PCP_PMNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PUNum))
         {
            idb.AddParameter("@PCP_PUNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PUNum", pC_Plan.PCP_PUNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PINum))
         {
            idb.AddParameter("@PCP_PINum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PINum", pC_Plan.PCP_PINum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PJNum))
         {
            idb.AddParameter("@PCP_PJNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PJNum", pC_Plan.PCP_PJNum);
         }
         if (pC_Plan.PCP_PTNum == 0)
         {
            idb.AddParameter("@PCP_PTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTNum", pC_Plan.PCP_PTNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PWNum))
         {
            idb.AddParameter("@PCP_PWNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PWNum", pC_Plan.PCP_PWNum);
         }
         if (pC_Plan.PCP_PPNum == 0)
         {
            idb.AddParameter("@PCP_PPNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPNum", pC_Plan.PCP_PPNum);
         }
         if (pC_Plan.PCP_PRNum == 0)
         {
            idb.AddParameter("@PCP_PRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PRNum", pC_Plan.PCP_PRNum);
         }
         if (pC_Plan.PCP_PTRNum == 0)
         {
            idb.AddParameter("@PCP_PTRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTRNum", pC_Plan.PCP_PTRNum);
         }
         if (pC_Plan.PCP_PPRNum == 0)
         {
            idb.AddParameter("@PCP_PPRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPRNum", pC_Plan.PCP_PPRNum);
         }
         if (pC_Plan.PCP_PPMNum == 0)
         {
            idb.AddParameter("@PCP_PPMNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPMNum", pC_Plan.PCP_PPMNum);
         }
         if (pC_Plan.PCP_PTMNum == 0)
         {
            idb.AddParameter("@PCP_PTMNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTMNum", pC_Plan.PCP_PTMNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_TechType))
         {
            idb.AddParameter("@PCP_TechType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_TechType", pC_Plan.PCP_TechType);
         }
         if (pC_Plan.PCP_Limit == 0)
         {
            idb.AddParameter("@PCP_Limit", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Limit", pC_Plan.PCP_Limit);
         }
         if (pC_Plan.PCP_Frequence == 0)
         {
            idb.AddParameter("@PCP_Frequence", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Frequence", pC_Plan.PCP_Frequence);
         }
         if (pC_Plan.PCP_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_LastDate", pC_Plan.PCP_LastDate);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_LastNo))
         {
            idb.AddParameter("@PCP_LastNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_LastNo", pC_Plan.PCP_LastNo);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Transpot))
         {
            idb.AddParameter("@PCP_Transpot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Transpot", pC_Plan.PCP_Transpot);
         }
         if (pC_Plan.PCP_Order == 0)
         {
            idb.AddParameter("@PCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Order", pC_Plan.PCP_Order);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_DBack))
         {
            idb.AddParameter("@PCP_DBack", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_DBack", pC_Plan.PCP_DBack);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Status))
         {
            idb.AddParameter("@PCP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Status", pC_Plan.PCP_Status);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Bak))
         {
            idb.AddParameter("@PCP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Bak", pC_Plan.PCP_Bak);
         }
         if (pC_Plan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Plan.Stat);
         }
         if (pC_Plan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Plan.CreateDate);
         }
         if (pC_Plan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Plan.UpdateDate);
         }
         if (pC_Plan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Plan.DeleteDate);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef1))
         {
            idb.AddParameter("@PCP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef1", pC_Plan.PCP_Udef1);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef2))
         {
            idb.AddParameter("@PCP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef2", pC_Plan.PCP_Udef2);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef3))
         {
            idb.AddParameter("@PCP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef3", pC_Plan.PCP_Udef3);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef4))
         {
            idb.AddParameter("@PCP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef4", pC_Plan.PCP_Udef4);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef5))
         {
            idb.AddParameter("@PCP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef5", pC_Plan.PCP_Udef5);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef6))
         {
            idb.AddParameter("@PCP_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef6", pC_Plan.PCP_Udef6);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef7))
         {
            idb.AddParameter("@PCP_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef7", pC_Plan.PCP_Udef7);
         }
         if (string.IsNullOrEmpty(pC_Plan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pC_Plan.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(pC_Plan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pC_Plan.AuditStat);
         }
         if (pC_Plan.PCP_LNum == 0)
         {
            idb.AddParameter("@PCP_LNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_LNum", pC_Plan.PCP_LNum);
         }
         if (pC_Plan.PCP_ANum == 0)
         {
            idb.AddParameter("@PCP_ANum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_ANum", pC_Plan.PCP_ANum);
         }
         if (pC_Plan.PCP_Price == 0)
         {
            idb.AddParameter("@PCP_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Price", pC_Plan.PCP_Price);
         }
         if (pC_Plan.PCP_Sum == 0)
         {
            idb.AddParameter("@PCP_Sum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Sum", pC_Plan.PCP_Sum);
         }
         if (pC_Plan.PCP_TankerFee == 0)
         {
            idb.AddParameter("@PCP_TankerFee", 0);
         }
         else
         {
            idb.AddParameter("@PCP_TankerFee", pC_Plan.PCP_TankerFee);
         }
         if (pC_Plan.PCP_PumpFee == 0)
         {
            idb.AddParameter("@PCP_PumpFee", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PumpFee", pC_Plan.PCP_PumpFee);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Operator))
         {
            idb.AddParameter("@PCP_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Operator", pC_Plan.PCP_Operator);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Schdule))
         {
            idb.AddParameter("@PCP_Schdule", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Schdule", pC_Plan.PCP_Schdule);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Station))
         {
            idb.AddParameter("@PCP_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Station", pC_Plan.PCP_Station);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_StatonName))
         {
            idb.AddParameter("@PCP_StatonName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_StatonName", pC_Plan.PCP_StatonName);
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
      /// 添加生产计划 PC_Plan对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_Plan pC_Plan)
      {
         string sql = "INSERT INTO PC_Plan (PCP_PCode,PCP_SCode,PCP_Name,PCP_CPCode,PCP_PRCode,PCP_CCode,PCP_Part,PCP_Slump,PCP_Addr,PCP_IsPipe,PCP_PLCode,PCP_Leve,PCP_Impervious,PCP_SPC,PCP_Special1,PCP_Special2,PCP_Special3,PCP_Special4,PCP_Special5,PCP_PDate,PCP_RDate,PCP_POwner,PCP_POwnerName,PCP_Date,PCP_CureStep,PCP_NextStep,PCP_IsTech,PCP_IsStart,PCP_PMNum,PCP_PUNum,PCP_PINum,PCP_PJNum,PCP_PTNum,PCP_PWNum,PCP_PPNum,PCP_PRNum,PCP_PTRNum,PCP_PPRNum,PCP_PPMNum,PCP_PTMNum,PCP_TechType,PCP_Limit,PCP_Frequence,PCP_LastDate,PCP_LastNo,PCP_Transpot,PCP_Order,PCP_DBack,PCP_Status,PCP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCP_Udef1,PCP_Udef2,PCP_Udef3,PCP_Udef4,PCP_Udef5,PCP_Udef6,PCP_Udef7,AuditCurAudit,AuditStat,PCP_LNum,PCP_ANum,PCP_Price,PCP_Sum,PCP_TankerFee,PCP_PumpFee,PCP_Operator,PCP_Schdule,PCP_Station,PCP_StatonName) VALUES (@PCP_PCode,@PCP_SCode,@PCP_Name,@PCP_CPCode,@PCP_PRCode,@PCP_CCode,@PCP_Part,@PCP_Slump,@PCP_Addr,@PCP_IsPipe,@PCP_PLCode,@PCP_Leve,@PCP_Impervious,@PCP_SPC,@PCP_Special1,@PCP_Special2,@PCP_Special3,@PCP_Special4,@PCP_Special5,@PCP_PDate,@PCP_RDate,@PCP_POwner,@PCP_POwnerName,@PCP_Date,@PCP_CureStep,@PCP_NextStep,@PCP_IsTech,@PCP_IsStart,@PCP_PMNum,@PCP_PUNum,@PCP_PINum,@PCP_PJNum,@PCP_PTNum,@PCP_PWNum,@PCP_PPNum,@PCP_PRNum,@PCP_PTRNum,@PCP_PPRNum,@PCP_PPMNum,@PCP_PTMNum,@PCP_TechType,@PCP_Limit,@PCP_Frequence,@PCP_LastDate,@PCP_LastNo,@PCP_Transpot,@PCP_Order,@PCP_DBack,@PCP_Status,@PCP_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCP_Udef1,@PCP_Udef2,@PCP_Udef3,@PCP_Udef4,@PCP_Udef5,@PCP_Udef6,@PCP_Udef7,@AuditCurAudit,@AuditStat,@PCP_LNum,@PCP_ANum,@PCP_Price,@PCP_Sum,@PCP_TankerFee,@PCP_PumpFee,@PCP_Operator,@PCP_Schdule,@PCP_Station,@PCP_StatonName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_Plan.PCP_PCode))
         {
            idb.AddParameter("@PCP_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PCode", pC_Plan.PCP_PCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_SCode))
         {
            idb.AddParameter("@PCP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_SCode", pC_Plan.PCP_SCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Name))
         {
            idb.AddParameter("@PCP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Name", pC_Plan.PCP_Name);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_CPCode))
         {
            idb.AddParameter("@PCP_CPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CPCode", pC_Plan.PCP_CPCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PRCode))
         {
            idb.AddParameter("@PCP_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PRCode", pC_Plan.PCP_PRCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_CCode))
         {
            idb.AddParameter("@PCP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CCode", pC_Plan.PCP_CCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Part))
         {
            idb.AddParameter("@PCP_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Part", pC_Plan.PCP_Part);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Slump))
         {
            idb.AddParameter("@PCP_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Slump", pC_Plan.PCP_Slump);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Addr))
         {
            idb.AddParameter("@PCP_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Addr", pC_Plan.PCP_Addr);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_IsPipe))
         {
            idb.AddParameter("@PCP_IsPipe", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_IsPipe", pC_Plan.PCP_IsPipe);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PLCode))
         {
            idb.AddParameter("@PCP_PLCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PLCode", pC_Plan.PCP_PLCode);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Leve))
         {
            idb.AddParameter("@PCP_Leve", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Leve", pC_Plan.PCP_Leve);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Impervious))
         {
            idb.AddParameter("@PCP_Impervious", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Impervious", pC_Plan.PCP_Impervious);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_SPC))
         {
            idb.AddParameter("@PCP_SPC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_SPC", pC_Plan.PCP_SPC);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special1))
         {
            idb.AddParameter("@PCP_Special1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special1", pC_Plan.PCP_Special1);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special2))
         {
            idb.AddParameter("@PCP_Special2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special2", pC_Plan.PCP_Special2);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special3))
         {
            idb.AddParameter("@PCP_Special3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special3", pC_Plan.PCP_Special3);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special4))
         {
            idb.AddParameter("@PCP_Special4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special4", pC_Plan.PCP_Special4);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special5))
         {
            idb.AddParameter("@PCP_Special5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special5", pC_Plan.PCP_Special5);
         }
         if (pC_Plan.PCP_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PDate", pC_Plan.PCP_PDate);
         }
         if (pC_Plan.PCP_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_RDate", pC_Plan.PCP_RDate);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_POwner))
         {
            idb.AddParameter("@PCP_POwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_POwner", pC_Plan.PCP_POwner);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_POwnerName))
         {
            idb.AddParameter("@PCP_POwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_POwnerName", pC_Plan.PCP_POwnerName);
         }
         if (pC_Plan.PCP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Date", pC_Plan.PCP_Date);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_CureStep))
         {
            idb.AddParameter("@PCP_CureStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CureStep", pC_Plan.PCP_CureStep);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_NextStep))
         {
            idb.AddParameter("@PCP_NextStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_NextStep", pC_Plan.PCP_NextStep);
         }
         if (pC_Plan.PCP_IsTech == 0)
         {
            idb.AddParameter("@PCP_IsTech", 0);
         }
         else
         {
            idb.AddParameter("@PCP_IsTech", pC_Plan.PCP_IsTech);
         }
         if (pC_Plan.PCP_IsStart == 0)
         {
            idb.AddParameter("@PCP_IsStart", 0);
         }
         else
         {
            idb.AddParameter("@PCP_IsStart", pC_Plan.PCP_IsStart);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PMNum))
         {
            idb.AddParameter("@PCP_PMNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PMNum", pC_Plan.PCP_PMNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PUNum))
         {
            idb.AddParameter("@PCP_PUNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PUNum", pC_Plan.PCP_PUNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PINum))
         {
            idb.AddParameter("@PCP_PINum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PINum", pC_Plan.PCP_PINum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PJNum))
         {
            idb.AddParameter("@PCP_PJNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PJNum", pC_Plan.PCP_PJNum);
         }
         if (pC_Plan.PCP_PTNum == 0)
         {
            idb.AddParameter("@PCP_PTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTNum", pC_Plan.PCP_PTNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_PWNum))
         {
            idb.AddParameter("@PCP_PWNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PWNum", pC_Plan.PCP_PWNum);
         }
         if (pC_Plan.PCP_PPNum == 0)
         {
            idb.AddParameter("@PCP_PPNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPNum", pC_Plan.PCP_PPNum);
         }
         if (pC_Plan.PCP_PRNum == 0)
         {
            idb.AddParameter("@PCP_PRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PRNum", pC_Plan.PCP_PRNum);
         }
         if (pC_Plan.PCP_PTRNum == 0)
         {
            idb.AddParameter("@PCP_PTRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTRNum", pC_Plan.PCP_PTRNum);
         }
         if (pC_Plan.PCP_PPRNum == 0)
         {
            idb.AddParameter("@PCP_PPRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPRNum", pC_Plan.PCP_PPRNum);
         }
         if (pC_Plan.PCP_PPMNum == 0)
         {
            idb.AddParameter("@PCP_PPMNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPMNum", pC_Plan.PCP_PPMNum);
         }
         if (pC_Plan.PCP_PTMNum == 0)
         {
            idb.AddParameter("@PCP_PTMNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTMNum", pC_Plan.PCP_PTMNum);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_TechType))
         {
            idb.AddParameter("@PCP_TechType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_TechType", pC_Plan.PCP_TechType);
         }
         if (pC_Plan.PCP_Limit == 0)
         {
            idb.AddParameter("@PCP_Limit", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Limit", pC_Plan.PCP_Limit);
         }
         if (pC_Plan.PCP_Frequence == 0)
         {
            idb.AddParameter("@PCP_Frequence", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Frequence", pC_Plan.PCP_Frequence);
         }
         if (pC_Plan.PCP_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_LastDate", pC_Plan.PCP_LastDate);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_LastNo))
         {
            idb.AddParameter("@PCP_LastNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_LastNo", pC_Plan.PCP_LastNo);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Transpot))
         {
            idb.AddParameter("@PCP_Transpot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Transpot", pC_Plan.PCP_Transpot);
         }
         if (pC_Plan.PCP_Order == 0)
         {
            idb.AddParameter("@PCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Order", pC_Plan.PCP_Order);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_DBack))
         {
            idb.AddParameter("@PCP_DBack", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_DBack", pC_Plan.PCP_DBack);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Status))
         {
            idb.AddParameter("@PCP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Status", pC_Plan.PCP_Status);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Bak))
         {
            idb.AddParameter("@PCP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Bak", pC_Plan.PCP_Bak);
         }
         if (pC_Plan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Plan.Stat);
         }
         if (pC_Plan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Plan.CreateDate);
         }
         if (pC_Plan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Plan.UpdateDate);
         }
         if (pC_Plan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Plan.DeleteDate);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef1))
         {
            idb.AddParameter("@PCP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef1", pC_Plan.PCP_Udef1);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef2))
         {
            idb.AddParameter("@PCP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef2", pC_Plan.PCP_Udef2);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef3))
         {
            idb.AddParameter("@PCP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef3", pC_Plan.PCP_Udef3);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef4))
         {
            idb.AddParameter("@PCP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef4", pC_Plan.PCP_Udef4);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef5))
         {
            idb.AddParameter("@PCP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef5", pC_Plan.PCP_Udef5);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef6))
         {
            idb.AddParameter("@PCP_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef6", pC_Plan.PCP_Udef6);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef7))
         {
            idb.AddParameter("@PCP_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef7", pC_Plan.PCP_Udef7);
         }
         if (string.IsNullOrEmpty(pC_Plan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pC_Plan.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(pC_Plan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pC_Plan.AuditStat);
         }
         if (pC_Plan.PCP_LNum == 0)
         {
            idb.AddParameter("@PCP_LNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_LNum", pC_Plan.PCP_LNum);
         }
         if (pC_Plan.PCP_ANum == 0)
         {
            idb.AddParameter("@PCP_ANum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_ANum", pC_Plan.PCP_ANum);
         }
         if (pC_Plan.PCP_Price == 0)
         {
            idb.AddParameter("@PCP_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Price", pC_Plan.PCP_Price);
         }
         if (pC_Plan.PCP_Sum == 0)
         {
            idb.AddParameter("@PCP_Sum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Sum", pC_Plan.PCP_Sum);
         }
         if (pC_Plan.PCP_TankerFee == 0)
         {
            idb.AddParameter("@PCP_TankerFee", 0);
         }
         else
         {
            idb.AddParameter("@PCP_TankerFee", pC_Plan.PCP_TankerFee);
         }
         if (pC_Plan.PCP_PumpFee == 0)
         {
            idb.AddParameter("@PCP_PumpFee", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PumpFee", pC_Plan.PCP_PumpFee);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Operator))
         {
            idb.AddParameter("@PCP_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Operator", pC_Plan.PCP_Operator);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Schdule))
         {
            idb.AddParameter("@PCP_Schdule", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Schdule", pC_Plan.PCP_Schdule);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_Station))
         {
            idb.AddParameter("@PCP_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Station", pC_Plan.PCP_Station);
         }
         if (string.IsNullOrEmpty(pC_Plan.PCP_StatonName))
         {
            idb.AddParameter("@PCP_StatonName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_StatonName", pC_Plan.PCP_StatonName);
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
      /// 更新生产计划 PC_Plan对象(即:一条记录
      /// </summary>
      public int Update(PC_Plan pC_Plan)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_Plan       SET ");
            if(pC_Plan.PCP_PCode_IsChanged){sbParameter.Append("PCP_PCode=@PCP_PCode, ");}
      if(pC_Plan.PCP_SCode_IsChanged){sbParameter.Append("PCP_SCode=@PCP_SCode, ");}
      if(pC_Plan.PCP_Name_IsChanged){sbParameter.Append("PCP_Name=@PCP_Name, ");}
      if(pC_Plan.PCP_CPCode_IsChanged){sbParameter.Append("PCP_CPCode=@PCP_CPCode, ");}
      if(pC_Plan.PCP_PRCode_IsChanged){sbParameter.Append("PCP_PRCode=@PCP_PRCode, ");}
      if(pC_Plan.PCP_CCode_IsChanged){sbParameter.Append("PCP_CCode=@PCP_CCode, ");}
      if(pC_Plan.PCP_Part_IsChanged){sbParameter.Append("PCP_Part=@PCP_Part, ");}
      if(pC_Plan.PCP_Slump_IsChanged){sbParameter.Append("PCP_Slump=@PCP_Slump, ");}
      if(pC_Plan.PCP_Addr_IsChanged){sbParameter.Append("PCP_Addr=@PCP_Addr, ");}
      if(pC_Plan.PCP_IsPipe_IsChanged){sbParameter.Append("PCP_IsPipe=@PCP_IsPipe, ");}
      if(pC_Plan.PCP_PLCode_IsChanged){sbParameter.Append("PCP_PLCode=@PCP_PLCode, ");}
      if(pC_Plan.PCP_Leve_IsChanged){sbParameter.Append("PCP_Leve=@PCP_Leve, ");}
      if(pC_Plan.PCP_Impervious_IsChanged){sbParameter.Append("PCP_Impervious=@PCP_Impervious, ");}
      if(pC_Plan.PCP_SPC_IsChanged){sbParameter.Append("PCP_SPC=@PCP_SPC, ");}
      if(pC_Plan.PCP_Special1_IsChanged){sbParameter.Append("PCP_Special1=@PCP_Special1, ");}
      if(pC_Plan.PCP_Special2_IsChanged){sbParameter.Append("PCP_Special2=@PCP_Special2, ");}
      if(pC_Plan.PCP_Special3_IsChanged){sbParameter.Append("PCP_Special3=@PCP_Special3, ");}
      if(pC_Plan.PCP_Special4_IsChanged){sbParameter.Append("PCP_Special4=@PCP_Special4, ");}
      if(pC_Plan.PCP_Special5_IsChanged){sbParameter.Append("PCP_Special5=@PCP_Special5, ");}
      if(pC_Plan.PCP_PDate_IsChanged){sbParameter.Append("PCP_PDate=@PCP_PDate, ");}
      if(pC_Plan.PCP_RDate_IsChanged){sbParameter.Append("PCP_RDate=@PCP_RDate, ");}
      if(pC_Plan.PCP_POwner_IsChanged){sbParameter.Append("PCP_POwner=@PCP_POwner, ");}
      if(pC_Plan.PCP_POwnerName_IsChanged){sbParameter.Append("PCP_POwnerName=@PCP_POwnerName, ");}
      if(pC_Plan.PCP_Date_IsChanged){sbParameter.Append("PCP_Date=@PCP_Date, ");}
      if(pC_Plan.PCP_CureStep_IsChanged){sbParameter.Append("PCP_CureStep=@PCP_CureStep, ");}
      if(pC_Plan.PCP_NextStep_IsChanged){sbParameter.Append("PCP_NextStep=@PCP_NextStep, ");}
      if(pC_Plan.PCP_IsTech_IsChanged){sbParameter.Append("PCP_IsTech=@PCP_IsTech, ");}
      if(pC_Plan.PCP_IsStart_IsChanged){sbParameter.Append("PCP_IsStart=@PCP_IsStart, ");}
      if(pC_Plan.PCP_PMNum_IsChanged){sbParameter.Append("PCP_PMNum=@PCP_PMNum, ");}
      if(pC_Plan.PCP_PUNum_IsChanged){sbParameter.Append("PCP_PUNum=@PCP_PUNum, ");}
      if(pC_Plan.PCP_PINum_IsChanged){sbParameter.Append("PCP_PINum=@PCP_PINum, ");}
      if(pC_Plan.PCP_PJNum_IsChanged){sbParameter.Append("PCP_PJNum=@PCP_PJNum, ");}
      if(pC_Plan.PCP_PTNum_IsChanged){sbParameter.Append("PCP_PTNum=@PCP_PTNum, ");}
      if(pC_Plan.PCP_PWNum_IsChanged){sbParameter.Append("PCP_PWNum=@PCP_PWNum, ");}
      if(pC_Plan.PCP_PPNum_IsChanged){sbParameter.Append("PCP_PPNum=@PCP_PPNum, ");}
      if(pC_Plan.PCP_PRNum_IsChanged){sbParameter.Append("PCP_PRNum=@PCP_PRNum, ");}
      if(pC_Plan.PCP_PTRNum_IsChanged){sbParameter.Append("PCP_PTRNum=@PCP_PTRNum, ");}
      if(pC_Plan.PCP_PPRNum_IsChanged){sbParameter.Append("PCP_PPRNum=@PCP_PPRNum, ");}
      if(pC_Plan.PCP_PPMNum_IsChanged){sbParameter.Append("PCP_PPMNum=@PCP_PPMNum, ");}
      if(pC_Plan.PCP_PTMNum_IsChanged){sbParameter.Append("PCP_PTMNum=@PCP_PTMNum, ");}
      if(pC_Plan.PCP_TechType_IsChanged){sbParameter.Append("PCP_TechType=@PCP_TechType, ");}
      if(pC_Plan.PCP_Limit_IsChanged){sbParameter.Append("PCP_Limit=@PCP_Limit, ");}
      if(pC_Plan.PCP_Frequence_IsChanged){sbParameter.Append("PCP_Frequence=@PCP_Frequence, ");}
      if(pC_Plan.PCP_LastDate_IsChanged){sbParameter.Append("PCP_LastDate=@PCP_LastDate, ");}
      if(pC_Plan.PCP_LastNo_IsChanged){sbParameter.Append("PCP_LastNo=@PCP_LastNo, ");}
      if(pC_Plan.PCP_Transpot_IsChanged){sbParameter.Append("PCP_Transpot=@PCP_Transpot, ");}
      if(pC_Plan.PCP_Order_IsChanged){sbParameter.Append("PCP_Order=@PCP_Order, ");}
      if(pC_Plan.PCP_DBack_IsChanged){sbParameter.Append("PCP_DBack=@PCP_DBack, ");}
      if(pC_Plan.PCP_Status_IsChanged){sbParameter.Append("PCP_Status=@PCP_Status, ");}
      if(pC_Plan.PCP_Bak_IsChanged){sbParameter.Append("PCP_Bak=@PCP_Bak, ");}
      if(pC_Plan.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_Plan.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_Plan.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_Plan.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pC_Plan.PCP_Udef1_IsChanged){sbParameter.Append("PCP_Udef1=@PCP_Udef1, ");}
      if(pC_Plan.PCP_Udef2_IsChanged){sbParameter.Append("PCP_Udef2=@PCP_Udef2, ");}
      if(pC_Plan.PCP_Udef3_IsChanged){sbParameter.Append("PCP_Udef3=@PCP_Udef3, ");}
      if(pC_Plan.PCP_Udef4_IsChanged){sbParameter.Append("PCP_Udef4=@PCP_Udef4, ");}
      if(pC_Plan.PCP_Udef5_IsChanged){sbParameter.Append("PCP_Udef5=@PCP_Udef5, ");}
      if(pC_Plan.PCP_Udef6_IsChanged){sbParameter.Append("PCP_Udef6=@PCP_Udef6, ");}
      if(pC_Plan.PCP_Udef7_IsChanged){sbParameter.Append("PCP_Udef7=@PCP_Udef7, ");}
      if(pC_Plan.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(pC_Plan.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(pC_Plan.PCP_LNum_IsChanged){sbParameter.Append("PCP_LNum=@PCP_LNum, ");}
      if(pC_Plan.PCP_ANum_IsChanged){sbParameter.Append("PCP_ANum=@PCP_ANum, ");}
      if(pC_Plan.PCP_Price_IsChanged){sbParameter.Append("PCP_Price=@PCP_Price, ");}
      if(pC_Plan.PCP_Sum_IsChanged){sbParameter.Append("PCP_Sum=@PCP_Sum, ");}
      if(pC_Plan.PCP_TankerFee_IsChanged){sbParameter.Append("PCP_TankerFee=@PCP_TankerFee, ");}
      if(pC_Plan.PCP_PumpFee_IsChanged){sbParameter.Append("PCP_PumpFee=@PCP_PumpFee, ");}
      if(pC_Plan.PCP_Operator_IsChanged){sbParameter.Append("PCP_Operator=@PCP_Operator, ");}
      if(pC_Plan.PCP_Schdule_IsChanged){sbParameter.Append("PCP_Schdule=@PCP_Schdule, ");}
      if(pC_Plan.PCP_Station_IsChanged){sbParameter.Append("PCP_Station=@PCP_Station, ");}
      if(pC_Plan.PCP_StatonName_IsChanged){sbParameter.Append("PCP_StatonName=@PCP_StatonName ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCP_ID=@PCP_ID; " );
      string sql=sb.ToString();
         if(pC_Plan.PCP_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PCode))
         {
            idb.AddParameter("@PCP_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PCode", pC_Plan.PCP_PCode);
         }
          }
         if(pC_Plan.PCP_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_SCode))
         {
            idb.AddParameter("@PCP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_SCode", pC_Plan.PCP_SCode);
         }
          }
         if(pC_Plan.PCP_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Name))
         {
            idb.AddParameter("@PCP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Name", pC_Plan.PCP_Name);
         }
          }
         if(pC_Plan.PCP_CPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_CPCode))
         {
            idb.AddParameter("@PCP_CPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CPCode", pC_Plan.PCP_CPCode);
         }
          }
         if(pC_Plan.PCP_PRCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PRCode))
         {
            idb.AddParameter("@PCP_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PRCode", pC_Plan.PCP_PRCode);
         }
          }
         if(pC_Plan.PCP_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_CCode))
         {
            idb.AddParameter("@PCP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CCode", pC_Plan.PCP_CCode);
         }
          }
         if(pC_Plan.PCP_Part_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Part))
         {
            idb.AddParameter("@PCP_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Part", pC_Plan.PCP_Part);
         }
          }
         if(pC_Plan.PCP_Slump_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Slump))
         {
            idb.AddParameter("@PCP_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Slump", pC_Plan.PCP_Slump);
         }
          }
         if(pC_Plan.PCP_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Addr))
         {
            idb.AddParameter("@PCP_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Addr", pC_Plan.PCP_Addr);
         }
          }
         if(pC_Plan.PCP_IsPipe_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_IsPipe))
         {
            idb.AddParameter("@PCP_IsPipe", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_IsPipe", pC_Plan.PCP_IsPipe);
         }
          }
         if(pC_Plan.PCP_PLCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PLCode))
         {
            idb.AddParameter("@PCP_PLCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PLCode", pC_Plan.PCP_PLCode);
         }
          }
         if(pC_Plan.PCP_Leve_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Leve))
         {
            idb.AddParameter("@PCP_Leve", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Leve", pC_Plan.PCP_Leve);
         }
          }
         if(pC_Plan.PCP_Impervious_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Impervious))
         {
            idb.AddParameter("@PCP_Impervious", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Impervious", pC_Plan.PCP_Impervious);
         }
          }
         if(pC_Plan.PCP_SPC_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_SPC))
         {
            idb.AddParameter("@PCP_SPC", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_SPC", pC_Plan.PCP_SPC);
         }
          }
         if(pC_Plan.PCP_Special1_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special1))
         {
            idb.AddParameter("@PCP_Special1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special1", pC_Plan.PCP_Special1);
         }
          }
         if(pC_Plan.PCP_Special2_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special2))
         {
            idb.AddParameter("@PCP_Special2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special2", pC_Plan.PCP_Special2);
         }
          }
         if(pC_Plan.PCP_Special3_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special3))
         {
            idb.AddParameter("@PCP_Special3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special3", pC_Plan.PCP_Special3);
         }
          }
         if(pC_Plan.PCP_Special4_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special4))
         {
            idb.AddParameter("@PCP_Special4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special4", pC_Plan.PCP_Special4);
         }
          }
         if(pC_Plan.PCP_Special5_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Special5))
         {
            idb.AddParameter("@PCP_Special5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Special5", pC_Plan.PCP_Special5);
         }
          }
         if(pC_Plan.PCP_PDate_IsChanged)
         {
         if (pC_Plan.PCP_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PDate", pC_Plan.PCP_PDate);
         }
          }
         if(pC_Plan.PCP_RDate_IsChanged)
         {
         if (pC_Plan.PCP_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_RDate", pC_Plan.PCP_RDate);
         }
          }
         if(pC_Plan.PCP_POwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_POwner))
         {
            idb.AddParameter("@PCP_POwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_POwner", pC_Plan.PCP_POwner);
         }
          }
         if(pC_Plan.PCP_POwnerName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_POwnerName))
         {
            idb.AddParameter("@PCP_POwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_POwnerName", pC_Plan.PCP_POwnerName);
         }
          }
         if(pC_Plan.PCP_Date_IsChanged)
         {
         if (pC_Plan.PCP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Date", pC_Plan.PCP_Date);
         }
          }
         if(pC_Plan.PCP_CureStep_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_CureStep))
         {
            idb.AddParameter("@PCP_CureStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_CureStep", pC_Plan.PCP_CureStep);
         }
          }
         if(pC_Plan.PCP_NextStep_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_NextStep))
         {
            idb.AddParameter("@PCP_NextStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_NextStep", pC_Plan.PCP_NextStep);
         }
          }
         if(pC_Plan.PCP_IsTech_IsChanged)
         {
         if (pC_Plan.PCP_IsTech == 0)
         {
            idb.AddParameter("@PCP_IsTech", 0);
         }
         else
         {
            idb.AddParameter("@PCP_IsTech", pC_Plan.PCP_IsTech);
         }
          }
         if(pC_Plan.PCP_IsStart_IsChanged)
         {
         if (pC_Plan.PCP_IsStart == 0)
         {
            idb.AddParameter("@PCP_IsStart", 0);
         }
         else
         {
            idb.AddParameter("@PCP_IsStart", pC_Plan.PCP_IsStart);
         }
          }
         if(pC_Plan.PCP_PMNum_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PMNum))
         {
            idb.AddParameter("@PCP_PMNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PMNum", pC_Plan.PCP_PMNum);
         }
          }
         if(pC_Plan.PCP_PUNum_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PUNum))
         {
            idb.AddParameter("@PCP_PUNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PUNum", pC_Plan.PCP_PUNum);
         }
          }
         if(pC_Plan.PCP_PINum_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PINum))
         {
            idb.AddParameter("@PCP_PINum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PINum", pC_Plan.PCP_PINum);
         }
          }
         if(pC_Plan.PCP_PJNum_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PJNum))
         {
            idb.AddParameter("@PCP_PJNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PJNum", pC_Plan.PCP_PJNum);
         }
          }
         if(pC_Plan.PCP_PTNum_IsChanged)
         {
         if (pC_Plan.PCP_PTNum == 0)
         {
            idb.AddParameter("@PCP_PTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTNum", pC_Plan.PCP_PTNum);
         }
          }
         if(pC_Plan.PCP_PWNum_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_PWNum))
         {
            idb.AddParameter("@PCP_PWNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_PWNum", pC_Plan.PCP_PWNum);
         }
          }
         if(pC_Plan.PCP_PPNum_IsChanged)
         {
         if (pC_Plan.PCP_PPNum == 0)
         {
            idb.AddParameter("@PCP_PPNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPNum", pC_Plan.PCP_PPNum);
         }
          }
         if(pC_Plan.PCP_PRNum_IsChanged)
         {
         if (pC_Plan.PCP_PRNum == 0)
         {
            idb.AddParameter("@PCP_PRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PRNum", pC_Plan.PCP_PRNum);
         }
          }
         if(pC_Plan.PCP_PTRNum_IsChanged)
         {
         if (pC_Plan.PCP_PTRNum == 0)
         {
            idb.AddParameter("@PCP_PTRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTRNum", pC_Plan.PCP_PTRNum);
         }
          }
         if(pC_Plan.PCP_PPRNum_IsChanged)
         {
         if (pC_Plan.PCP_PPRNum == 0)
         {
            idb.AddParameter("@PCP_PPRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPRNum", pC_Plan.PCP_PPRNum);
         }
          }
         if(pC_Plan.PCP_PPMNum_IsChanged)
         {
         if (pC_Plan.PCP_PPMNum == 0)
         {
            idb.AddParameter("@PCP_PPMNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PPMNum", pC_Plan.PCP_PPMNum);
         }
          }
         if(pC_Plan.PCP_PTMNum_IsChanged)
         {
         if (pC_Plan.PCP_PTMNum == 0)
         {
            idb.AddParameter("@PCP_PTMNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PTMNum", pC_Plan.PCP_PTMNum);
         }
          }
         if(pC_Plan.PCP_TechType_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_TechType))
         {
            idb.AddParameter("@PCP_TechType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_TechType", pC_Plan.PCP_TechType);
         }
          }
         if(pC_Plan.PCP_Limit_IsChanged)
         {
         if (pC_Plan.PCP_Limit == 0)
         {
            idb.AddParameter("@PCP_Limit", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Limit", pC_Plan.PCP_Limit);
         }
          }
         if(pC_Plan.PCP_Frequence_IsChanged)
         {
         if (pC_Plan.PCP_Frequence == 0)
         {
            idb.AddParameter("@PCP_Frequence", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Frequence", pC_Plan.PCP_Frequence);
         }
          }
         if(pC_Plan.PCP_LastDate_IsChanged)
         {
         if (pC_Plan.PCP_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCP_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_LastDate", pC_Plan.PCP_LastDate);
         }
          }
         if(pC_Plan.PCP_LastNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_LastNo))
         {
            idb.AddParameter("@PCP_LastNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_LastNo", pC_Plan.PCP_LastNo);
         }
          }
         if(pC_Plan.PCP_Transpot_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Transpot))
         {
            idb.AddParameter("@PCP_Transpot", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Transpot", pC_Plan.PCP_Transpot);
         }
          }
         if(pC_Plan.PCP_Order_IsChanged)
         {
         if (pC_Plan.PCP_Order == 0)
         {
            idb.AddParameter("@PCP_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Order", pC_Plan.PCP_Order);
         }
          }
         if(pC_Plan.PCP_DBack_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_DBack))
         {
            idb.AddParameter("@PCP_DBack", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_DBack", pC_Plan.PCP_DBack);
         }
          }
         if(pC_Plan.PCP_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Status))
         {
            idb.AddParameter("@PCP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Status", pC_Plan.PCP_Status);
         }
          }
         if(pC_Plan.PCP_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Bak))
         {
            idb.AddParameter("@PCP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Bak", pC_Plan.PCP_Bak);
         }
          }
         if(pC_Plan.Stat_IsChanged)
         {
         if (pC_Plan.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Plan.Stat);
         }
          }
         if(pC_Plan.CreateDate_IsChanged)
         {
         if (pC_Plan.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Plan.CreateDate);
         }
          }
         if(pC_Plan.UpdateDate_IsChanged)
         {
         if (pC_Plan.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Plan.UpdateDate);
         }
          }
         if(pC_Plan.DeleteDate_IsChanged)
         {
         if (pC_Plan.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Plan.DeleteDate);
         }
          }
         if(pC_Plan.PCP_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef1))
         {
            idb.AddParameter("@PCP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef1", pC_Plan.PCP_Udef1);
         }
          }
         if(pC_Plan.PCP_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef2))
         {
            idb.AddParameter("@PCP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef2", pC_Plan.PCP_Udef2);
         }
          }
         if(pC_Plan.PCP_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef3))
         {
            idb.AddParameter("@PCP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef3", pC_Plan.PCP_Udef3);
         }
          }
         if(pC_Plan.PCP_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef4))
         {
            idb.AddParameter("@PCP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef4", pC_Plan.PCP_Udef4);
         }
          }
         if(pC_Plan.PCP_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef5))
         {
            idb.AddParameter("@PCP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef5", pC_Plan.PCP_Udef5);
         }
          }
         if(pC_Plan.PCP_Udef6_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef6))
         {
            idb.AddParameter("@PCP_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef6", pC_Plan.PCP_Udef6);
         }
          }
         if(pC_Plan.PCP_Udef7_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Udef7))
         {
            idb.AddParameter("@PCP_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Udef7", pC_Plan.PCP_Udef7);
         }
          }
         if(pC_Plan.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pC_Plan.AuditCurAudit);
         }
          }
         if(pC_Plan.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pC_Plan.AuditStat);
         }
          }
         if(pC_Plan.PCP_LNum_IsChanged)
         {
         if (pC_Plan.PCP_LNum == 0)
         {
            idb.AddParameter("@PCP_LNum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_LNum", pC_Plan.PCP_LNum);
         }
          }
         if(pC_Plan.PCP_ANum_IsChanged)
         {
         if (pC_Plan.PCP_ANum == 0)
         {
            idb.AddParameter("@PCP_ANum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_ANum", pC_Plan.PCP_ANum);
         }
          }
         if(pC_Plan.PCP_Price_IsChanged)
         {
         if (pC_Plan.PCP_Price == 0)
         {
            idb.AddParameter("@PCP_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Price", pC_Plan.PCP_Price);
         }
          }
         if(pC_Plan.PCP_Sum_IsChanged)
         {
         if (pC_Plan.PCP_Sum == 0)
         {
            idb.AddParameter("@PCP_Sum", 0);
         }
         else
         {
            idb.AddParameter("@PCP_Sum", pC_Plan.PCP_Sum);
         }
          }
         if(pC_Plan.PCP_TankerFee_IsChanged)
         {
         if (pC_Plan.PCP_TankerFee == 0)
         {
            idb.AddParameter("@PCP_TankerFee", 0);
         }
         else
         {
            idb.AddParameter("@PCP_TankerFee", pC_Plan.PCP_TankerFee);
         }
          }
         if(pC_Plan.PCP_PumpFee_IsChanged)
         {
         if (pC_Plan.PCP_PumpFee == 0)
         {
            idb.AddParameter("@PCP_PumpFee", 0);
         }
         else
         {
            idb.AddParameter("@PCP_PumpFee", pC_Plan.PCP_PumpFee);
         }
          }
         if(pC_Plan.PCP_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Operator))
         {
            idb.AddParameter("@PCP_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Operator", pC_Plan.PCP_Operator);
         }
          }
         if(pC_Plan.PCP_Schdule_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Schdule))
         {
            idb.AddParameter("@PCP_Schdule", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Schdule", pC_Plan.PCP_Schdule);
         }
          }
         if(pC_Plan.PCP_Station_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_Station))
         {
            idb.AddParameter("@PCP_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_Station", pC_Plan.PCP_Station);
         }
          }
         if(pC_Plan.PCP_StatonName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Plan.PCP_StatonName))
         {
            idb.AddParameter("@PCP_StatonName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCP_StatonName", pC_Plan.PCP_StatonName);
         }
          }

         idb.AddParameter("@PCP_ID", pC_Plan.PCP_ID);

           
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
      /// 删除生产计划 PC_Plan对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCP_ID)
      {
         string sql = "DELETE PC_Plan WHERE 1=1  AND PCP_ID=@PCP_ID ";
         idb.AddParameter("@PCP_ID", pCP_ID);

           
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
      /// 获取指定的生产计划 PC_Plan对象(即:一条记录
      /// </summary>
      public PC_Plan GetByKey(decimal pCP_ID)
      {
         PC_Plan pC_Plan = new PC_Plan();
         string sql = "SELECT  PCP_ID,PCP_PCode,PCP_SCode,PCP_Name,PCP_CPCode,PCP_PRCode,PCP_CCode,PCP_Part,PCP_Slump,PCP_Addr,PCP_IsPipe,PCP_PLCode,PCP_Leve,PCP_Impervious,PCP_SPC,PCP_Special1,PCP_Special2,PCP_Special3,PCP_Special4,PCP_Special5,PCP_PDate,PCP_RDate,PCP_POwner,PCP_POwnerName,PCP_Date,PCP_CureStep,PCP_NextStep,PCP_IsTech,PCP_IsStart,PCP_PMNum,PCP_PUNum,PCP_PINum,PCP_PJNum,PCP_PTNum,PCP_PWNum,PCP_PPNum,PCP_PRNum,PCP_PTRNum,PCP_PPRNum,PCP_PPMNum,PCP_PTMNum,PCP_TechType,PCP_Limit,PCP_Frequence,PCP_LastDate,PCP_LastNo,PCP_Transpot,PCP_Order,PCP_DBack,PCP_Status,PCP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCP_Udef1,PCP_Udef2,PCP_Udef3,PCP_Udef4,PCP_Udef5,PCP_Udef6,PCP_Udef7,AuditCurAudit,AuditStat,PCP_LNum,PCP_ANum,PCP_Price,PCP_Sum,PCP_TankerFee,PCP_PumpFee,PCP_Operator,PCP_Schdule,PCP_Station,PCP_StatonName FROM PC_Plan WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCP_ID=@PCP_ID ";
         idb.AddParameter("@PCP_ID", pCP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCP_ID"] != DBNull.Value) pC_Plan.PCP_ID = Convert.ToDecimal(dr["PCP_ID"]);
            if (dr["PCP_PCode"] != DBNull.Value) pC_Plan.PCP_PCode = Convert.ToString(dr["PCP_PCode"]);
            if (dr["PCP_SCode"] != DBNull.Value) pC_Plan.PCP_SCode = Convert.ToString(dr["PCP_SCode"]);
            if (dr["PCP_Name"] != DBNull.Value) pC_Plan.PCP_Name = Convert.ToString(dr["PCP_Name"]);
            if (dr["PCP_CPCode"] != DBNull.Value) pC_Plan.PCP_CPCode = Convert.ToString(dr["PCP_CPCode"]);
            if (dr["PCP_PRCode"] != DBNull.Value) pC_Plan.PCP_PRCode = Convert.ToString(dr["PCP_PRCode"]);
            if (dr["PCP_CCode"] != DBNull.Value) pC_Plan.PCP_CCode = Convert.ToString(dr["PCP_CCode"]);
            if (dr["PCP_Part"] != DBNull.Value) pC_Plan.PCP_Part = Convert.ToString(dr["PCP_Part"]);
            if (dr["PCP_Slump"] != DBNull.Value) pC_Plan.PCP_Slump = Convert.ToString(dr["PCP_Slump"]);
            if (dr["PCP_Addr"] != DBNull.Value) pC_Plan.PCP_Addr = Convert.ToString(dr["PCP_Addr"]);
            if (dr["PCP_IsPipe"] != DBNull.Value) pC_Plan.PCP_IsPipe = Convert.ToString(dr["PCP_IsPipe"]);
            if (dr["PCP_PLCode"] != DBNull.Value) pC_Plan.PCP_PLCode = Convert.ToString(dr["PCP_PLCode"]);
            if (dr["PCP_Leve"] != DBNull.Value) pC_Plan.PCP_Leve = Convert.ToString(dr["PCP_Leve"]);
            if (dr["PCP_Impervious"] != DBNull.Value) pC_Plan.PCP_Impervious = Convert.ToString(dr["PCP_Impervious"]);
            if (dr["PCP_SPC"] != DBNull.Value) pC_Plan.PCP_SPC = Convert.ToString(dr["PCP_SPC"]);
            if (dr["PCP_Special1"] != DBNull.Value) pC_Plan.PCP_Special1 = Convert.ToString(dr["PCP_Special1"]);
            if (dr["PCP_Special2"] != DBNull.Value) pC_Plan.PCP_Special2 = Convert.ToString(dr["PCP_Special2"]);
            if (dr["PCP_Special3"] != DBNull.Value) pC_Plan.PCP_Special3 = Convert.ToString(dr["PCP_Special3"]);
            if (dr["PCP_Special4"] != DBNull.Value) pC_Plan.PCP_Special4 = Convert.ToString(dr["PCP_Special4"]);
            if (dr["PCP_Special5"] != DBNull.Value) pC_Plan.PCP_Special5 = Convert.ToString(dr["PCP_Special5"]);
            if (dr["PCP_PDate"] != DBNull.Value) pC_Plan.PCP_PDate = Convert.ToDateTime(dr["PCP_PDate"]);
            if (dr["PCP_RDate"] != DBNull.Value) pC_Plan.PCP_RDate = Convert.ToDateTime(dr["PCP_RDate"]);
            if (dr["PCP_POwner"] != DBNull.Value) pC_Plan.PCP_POwner = Convert.ToString(dr["PCP_POwner"]);
            if (dr["PCP_POwnerName"] != DBNull.Value) pC_Plan.PCP_POwnerName = Convert.ToString(dr["PCP_POwnerName"]);
            if (dr["PCP_Date"] != DBNull.Value) pC_Plan.PCP_Date = Convert.ToDateTime(dr["PCP_Date"]);
            if (dr["PCP_CureStep"] != DBNull.Value) pC_Plan.PCP_CureStep = Convert.ToString(dr["PCP_CureStep"]);
            if (dr["PCP_NextStep"] != DBNull.Value) pC_Plan.PCP_NextStep = Convert.ToString(dr["PCP_NextStep"]);
            if (dr["PCP_IsTech"] != DBNull.Value) pC_Plan.PCP_IsTech = Convert.ToInt32(dr["PCP_IsTech"]);
            if (dr["PCP_IsStart"] != DBNull.Value) pC_Plan.PCP_IsStart = Convert.ToInt32(dr["PCP_IsStart"]);
            if (dr["PCP_PMNum"] != DBNull.Value) pC_Plan.PCP_PMNum = Convert.ToString(dr["PCP_PMNum"]);
            if (dr["PCP_PUNum"] != DBNull.Value) pC_Plan.PCP_PUNum = Convert.ToString(dr["PCP_PUNum"]);
            if (dr["PCP_PINum"] != DBNull.Value) pC_Plan.PCP_PINum = Convert.ToString(dr["PCP_PINum"]);
            if (dr["PCP_PJNum"] != DBNull.Value) pC_Plan.PCP_PJNum = Convert.ToString(dr["PCP_PJNum"]);
            if (dr["PCP_PTNum"] != DBNull.Value) pC_Plan.PCP_PTNum = Convert.ToInt32(dr["PCP_PTNum"]);
            if (dr["PCP_PWNum"] != DBNull.Value) pC_Plan.PCP_PWNum = Convert.ToString(dr["PCP_PWNum"]);
            if (dr["PCP_PPNum"] != DBNull.Value) pC_Plan.PCP_PPNum = Convert.ToDecimal(dr["PCP_PPNum"]);
            if (dr["PCP_PRNum"] != DBNull.Value) pC_Plan.PCP_PRNum = Convert.ToDecimal(dr["PCP_PRNum"]);
            if (dr["PCP_PTRNum"] != DBNull.Value) pC_Plan.PCP_PTRNum = Convert.ToInt32(dr["PCP_PTRNum"]);
            if (dr["PCP_PPRNum"] != DBNull.Value) pC_Plan.PCP_PPRNum = Convert.ToDecimal(dr["PCP_PPRNum"]);
            if (dr["PCP_PPMNum"] != DBNull.Value) pC_Plan.PCP_PPMNum = Convert.ToDecimal(dr["PCP_PPMNum"]);
            if (dr["PCP_PTMNum"] != DBNull.Value) pC_Plan.PCP_PTMNum = Convert.ToDecimal(dr["PCP_PTMNum"]);
            if (dr["PCP_TechType"] != DBNull.Value) pC_Plan.PCP_TechType = Convert.ToString(dr["PCP_TechType"]);
            if (dr["PCP_Limit"] != DBNull.Value) pC_Plan.PCP_Limit = Convert.ToDecimal(dr["PCP_Limit"]);
            if (dr["PCP_Frequence"] != DBNull.Value) pC_Plan.PCP_Frequence = Convert.ToInt32(dr["PCP_Frequence"]);
            if (dr["PCP_LastDate"] != DBNull.Value) pC_Plan.PCP_LastDate = Convert.ToDateTime(dr["PCP_LastDate"]);
            if (dr["PCP_LastNo"] != DBNull.Value) pC_Plan.PCP_LastNo = Convert.ToString(dr["PCP_LastNo"]);
            if (dr["PCP_Transpot"] != DBNull.Value) pC_Plan.PCP_Transpot = Convert.ToString(dr["PCP_Transpot"]);
            if (dr["PCP_Order"] != DBNull.Value) pC_Plan.PCP_Order = Convert.ToInt32(dr["PCP_Order"]);
            if (dr["PCP_DBack"] != DBNull.Value) pC_Plan.PCP_DBack = Convert.ToString(dr["PCP_DBack"]);
            if (dr["PCP_Status"] != DBNull.Value) pC_Plan.PCP_Status = Convert.ToString(dr["PCP_Status"]);
            if (dr["PCP_Bak"] != DBNull.Value) pC_Plan.PCP_Bak = Convert.ToString(dr["PCP_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_Plan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Plan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Plan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Plan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCP_Udef1"] != DBNull.Value) pC_Plan.PCP_Udef1 = Convert.ToString(dr["PCP_Udef1"]);
            if (dr["PCP_Udef2"] != DBNull.Value) pC_Plan.PCP_Udef2 = Convert.ToString(dr["PCP_Udef2"]);
            if (dr["PCP_Udef3"] != DBNull.Value) pC_Plan.PCP_Udef3 = Convert.ToString(dr["PCP_Udef3"]);
            if (dr["PCP_Udef4"] != DBNull.Value) pC_Plan.PCP_Udef4 = Convert.ToString(dr["PCP_Udef4"]);
            if (dr["PCP_Udef5"] != DBNull.Value) pC_Plan.PCP_Udef5 = Convert.ToString(dr["PCP_Udef5"]);
            if (dr["PCP_Udef6"] != DBNull.Value) pC_Plan.PCP_Udef6 = Convert.ToString(dr["PCP_Udef6"]);
            if (dr["PCP_Udef7"] != DBNull.Value) pC_Plan.PCP_Udef7 = Convert.ToString(dr["PCP_Udef7"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pC_Plan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditStat"] != DBNull.Value) pC_Plan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["PCP_LNum"] != DBNull.Value) pC_Plan.PCP_LNum = Convert.ToDecimal(dr["PCP_LNum"]);
            if (dr["PCP_ANum"] != DBNull.Value) pC_Plan.PCP_ANum = Convert.ToDecimal(dr["PCP_ANum"]);
            if (dr["PCP_Price"] != DBNull.Value) pC_Plan.PCP_Price = Convert.ToDecimal(dr["PCP_Price"]);
            if (dr["PCP_Sum"] != DBNull.Value) pC_Plan.PCP_Sum = Convert.ToDecimal(dr["PCP_Sum"]);
            if (dr["PCP_TankerFee"] != DBNull.Value) pC_Plan.PCP_TankerFee = Convert.ToDecimal(dr["PCP_TankerFee"]);
            if (dr["PCP_PumpFee"] != DBNull.Value) pC_Plan.PCP_PumpFee = Convert.ToDecimal(dr["PCP_PumpFee"]);
            if (dr["PCP_Operator"] != DBNull.Value) pC_Plan.PCP_Operator = Convert.ToString(dr["PCP_Operator"]);
            if (dr["PCP_Schdule"] != DBNull.Value) pC_Plan.PCP_Schdule = Convert.ToString(dr["PCP_Schdule"]);
            if (dr["PCP_Station"] != DBNull.Value) pC_Plan.PCP_Station = Convert.ToString(dr["PCP_Station"]);
            if (dr["PCP_StatonName"] != DBNull.Value) pC_Plan.PCP_StatonName = Convert.ToString(dr["PCP_StatonName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_Plan;
      }
      /// <summary>
      /// 获取指定的生产计划 PC_Plan对象集合
      /// </summary>
      public List<PC_Plan> GetListByWhere(string strCondition)
      {
         List<PC_Plan> ret = new List<PC_Plan>();
         string sql = "SELECT  PCP_ID,PCP_PCode,PCP_SCode,PCP_Name,PCP_CPCode,PCP_PRCode,PCP_CCode,PCP_Part,PCP_Slump,PCP_Addr,PCP_IsPipe,PCP_PLCode,PCP_Leve,PCP_Impervious,PCP_SPC,PCP_Special1,PCP_Special2,PCP_Special3,PCP_Special4,PCP_Special5,PCP_PDate,PCP_RDate,PCP_POwner,PCP_POwnerName,PCP_Date,PCP_CureStep,PCP_NextStep,PCP_IsTech,PCP_IsStart,PCP_PMNum,PCP_PUNum,PCP_PINum,PCP_PJNum,PCP_PTNum,PCP_PWNum,PCP_PPNum,PCP_PRNum,PCP_PTRNum,PCP_PPRNum,PCP_PPMNum,PCP_PTMNum,PCP_TechType,PCP_Limit,PCP_Frequence,PCP_LastDate,PCP_LastNo,PCP_Transpot,PCP_Order,PCP_DBack,PCP_Status,PCP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCP_Udef1,PCP_Udef2,PCP_Udef3,PCP_Udef4,PCP_Udef5,PCP_Udef6,PCP_Udef7,AuditCurAudit,AuditStat,PCP_LNum,PCP_ANum,PCP_Price,PCP_Sum,PCP_TankerFee,PCP_PumpFee,PCP_Operator,PCP_Schdule,PCP_Station,PCP_StatonName FROM PC_Plan WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_Plan pC_Plan = new PC_Plan();
            if (dr["PCP_ID"] != DBNull.Value) pC_Plan.PCP_ID = Convert.ToDecimal(dr["PCP_ID"]);
            if (dr["PCP_PCode"] != DBNull.Value) pC_Plan.PCP_PCode = Convert.ToString(dr["PCP_PCode"]);
            if (dr["PCP_SCode"] != DBNull.Value) pC_Plan.PCP_SCode = Convert.ToString(dr["PCP_SCode"]);
            if (dr["PCP_Name"] != DBNull.Value) pC_Plan.PCP_Name = Convert.ToString(dr["PCP_Name"]);
            if (dr["PCP_CPCode"] != DBNull.Value) pC_Plan.PCP_CPCode = Convert.ToString(dr["PCP_CPCode"]);
            if (dr["PCP_PRCode"] != DBNull.Value) pC_Plan.PCP_PRCode = Convert.ToString(dr["PCP_PRCode"]);
            if (dr["PCP_CCode"] != DBNull.Value) pC_Plan.PCP_CCode = Convert.ToString(dr["PCP_CCode"]);
            if (dr["PCP_Part"] != DBNull.Value) pC_Plan.PCP_Part = Convert.ToString(dr["PCP_Part"]);
            if (dr["PCP_Slump"] != DBNull.Value) pC_Plan.PCP_Slump = Convert.ToString(dr["PCP_Slump"]);
            if (dr["PCP_Addr"] != DBNull.Value) pC_Plan.PCP_Addr = Convert.ToString(dr["PCP_Addr"]);
            if (dr["PCP_IsPipe"] != DBNull.Value) pC_Plan.PCP_IsPipe = Convert.ToString(dr["PCP_IsPipe"]);
            if (dr["PCP_PLCode"] != DBNull.Value) pC_Plan.PCP_PLCode = Convert.ToString(dr["PCP_PLCode"]);
            if (dr["PCP_Leve"] != DBNull.Value) pC_Plan.PCP_Leve = Convert.ToString(dr["PCP_Leve"]);
            if (dr["PCP_Impervious"] != DBNull.Value) pC_Plan.PCP_Impervious = Convert.ToString(dr["PCP_Impervious"]);
            if (dr["PCP_SPC"] != DBNull.Value) pC_Plan.PCP_SPC = Convert.ToString(dr["PCP_SPC"]);
            if (dr["PCP_Special1"] != DBNull.Value) pC_Plan.PCP_Special1 = Convert.ToString(dr["PCP_Special1"]);
            if (dr["PCP_Special2"] != DBNull.Value) pC_Plan.PCP_Special2 = Convert.ToString(dr["PCP_Special2"]);
            if (dr["PCP_Special3"] != DBNull.Value) pC_Plan.PCP_Special3 = Convert.ToString(dr["PCP_Special3"]);
            if (dr["PCP_Special4"] != DBNull.Value) pC_Plan.PCP_Special4 = Convert.ToString(dr["PCP_Special4"]);
            if (dr["PCP_Special5"] != DBNull.Value) pC_Plan.PCP_Special5 = Convert.ToString(dr["PCP_Special5"]);
            if (dr["PCP_PDate"] != DBNull.Value) pC_Plan.PCP_PDate = Convert.ToDateTime(dr["PCP_PDate"]);
            if (dr["PCP_RDate"] != DBNull.Value) pC_Plan.PCP_RDate = Convert.ToDateTime(dr["PCP_RDate"]);
            if (dr["PCP_POwner"] != DBNull.Value) pC_Plan.PCP_POwner = Convert.ToString(dr["PCP_POwner"]);
            if (dr["PCP_POwnerName"] != DBNull.Value) pC_Plan.PCP_POwnerName = Convert.ToString(dr["PCP_POwnerName"]);
            if (dr["PCP_Date"] != DBNull.Value) pC_Plan.PCP_Date = Convert.ToDateTime(dr["PCP_Date"]);
            if (dr["PCP_CureStep"] != DBNull.Value) pC_Plan.PCP_CureStep = Convert.ToString(dr["PCP_CureStep"]);
            if (dr["PCP_NextStep"] != DBNull.Value) pC_Plan.PCP_NextStep = Convert.ToString(dr["PCP_NextStep"]);
            if (dr["PCP_IsTech"] != DBNull.Value) pC_Plan.PCP_IsTech = Convert.ToInt32(dr["PCP_IsTech"]);
            if (dr["PCP_IsStart"] != DBNull.Value) pC_Plan.PCP_IsStart = Convert.ToInt32(dr["PCP_IsStart"]);
            if (dr["PCP_PMNum"] != DBNull.Value) pC_Plan.PCP_PMNum = Convert.ToString(dr["PCP_PMNum"]);
            if (dr["PCP_PUNum"] != DBNull.Value) pC_Plan.PCP_PUNum = Convert.ToString(dr["PCP_PUNum"]);
            if (dr["PCP_PINum"] != DBNull.Value) pC_Plan.PCP_PINum = Convert.ToString(dr["PCP_PINum"]);
            if (dr["PCP_PJNum"] != DBNull.Value) pC_Plan.PCP_PJNum = Convert.ToString(dr["PCP_PJNum"]);
            if (dr["PCP_PTNum"] != DBNull.Value) pC_Plan.PCP_PTNum = Convert.ToInt32(dr["PCP_PTNum"]);
            if (dr["PCP_PWNum"] != DBNull.Value) pC_Plan.PCP_PWNum = Convert.ToString(dr["PCP_PWNum"]);
            if (dr["PCP_PPNum"] != DBNull.Value) pC_Plan.PCP_PPNum = Convert.ToDecimal(dr["PCP_PPNum"]);
            if (dr["PCP_PRNum"] != DBNull.Value) pC_Plan.PCP_PRNum = Convert.ToDecimal(dr["PCP_PRNum"]);
            if (dr["PCP_PTRNum"] != DBNull.Value) pC_Plan.PCP_PTRNum = Convert.ToInt32(dr["PCP_PTRNum"]);
            if (dr["PCP_PPRNum"] != DBNull.Value) pC_Plan.PCP_PPRNum = Convert.ToDecimal(dr["PCP_PPRNum"]);
            if (dr["PCP_PPMNum"] != DBNull.Value) pC_Plan.PCP_PPMNum = Convert.ToDecimal(dr["PCP_PPMNum"]);
            if (dr["PCP_PTMNum"] != DBNull.Value) pC_Plan.PCP_PTMNum = Convert.ToDecimal(dr["PCP_PTMNum"]);
            if (dr["PCP_TechType"] != DBNull.Value) pC_Plan.PCP_TechType = Convert.ToString(dr["PCP_TechType"]);
            if (dr["PCP_Limit"] != DBNull.Value) pC_Plan.PCP_Limit = Convert.ToDecimal(dr["PCP_Limit"]);
            if (dr["PCP_Frequence"] != DBNull.Value) pC_Plan.PCP_Frequence = Convert.ToInt32(dr["PCP_Frequence"]);
            if (dr["PCP_LastDate"] != DBNull.Value) pC_Plan.PCP_LastDate = Convert.ToDateTime(dr["PCP_LastDate"]);
            if (dr["PCP_LastNo"] != DBNull.Value) pC_Plan.PCP_LastNo = Convert.ToString(dr["PCP_LastNo"]);
            if (dr["PCP_Transpot"] != DBNull.Value) pC_Plan.PCP_Transpot = Convert.ToString(dr["PCP_Transpot"]);
            if (dr["PCP_Order"] != DBNull.Value) pC_Plan.PCP_Order = Convert.ToInt32(dr["PCP_Order"]);
            if (dr["PCP_DBack"] != DBNull.Value) pC_Plan.PCP_DBack = Convert.ToString(dr["PCP_DBack"]);
            if (dr["PCP_Status"] != DBNull.Value) pC_Plan.PCP_Status = Convert.ToString(dr["PCP_Status"]);
            if (dr["PCP_Bak"] != DBNull.Value) pC_Plan.PCP_Bak = Convert.ToString(dr["PCP_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_Plan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Plan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Plan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Plan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCP_Udef1"] != DBNull.Value) pC_Plan.PCP_Udef1 = Convert.ToString(dr["PCP_Udef1"]);
            if (dr["PCP_Udef2"] != DBNull.Value) pC_Plan.PCP_Udef2 = Convert.ToString(dr["PCP_Udef2"]);
            if (dr["PCP_Udef3"] != DBNull.Value) pC_Plan.PCP_Udef3 = Convert.ToString(dr["PCP_Udef3"]);
            if (dr["PCP_Udef4"] != DBNull.Value) pC_Plan.PCP_Udef4 = Convert.ToString(dr["PCP_Udef4"]);
            if (dr["PCP_Udef5"] != DBNull.Value) pC_Plan.PCP_Udef5 = Convert.ToString(dr["PCP_Udef5"]);
            if (dr["PCP_Udef6"] != DBNull.Value) pC_Plan.PCP_Udef6 = Convert.ToString(dr["PCP_Udef6"]);
            if (dr["PCP_Udef7"] != DBNull.Value) pC_Plan.PCP_Udef7 = Convert.ToString(dr["PCP_Udef7"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pC_Plan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditStat"] != DBNull.Value) pC_Plan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["PCP_LNum"] != DBNull.Value) pC_Plan.PCP_LNum = Convert.ToDecimal(dr["PCP_LNum"]);
            if (dr["PCP_ANum"] != DBNull.Value) pC_Plan.PCP_ANum = Convert.ToDecimal(dr["PCP_ANum"]);
            if (dr["PCP_Price"] != DBNull.Value) pC_Plan.PCP_Price = Convert.ToDecimal(dr["PCP_Price"]);
            if (dr["PCP_Sum"] != DBNull.Value) pC_Plan.PCP_Sum = Convert.ToDecimal(dr["PCP_Sum"]);
            if (dr["PCP_TankerFee"] != DBNull.Value) pC_Plan.PCP_TankerFee = Convert.ToDecimal(dr["PCP_TankerFee"]);
            if (dr["PCP_PumpFee"] != DBNull.Value) pC_Plan.PCP_PumpFee = Convert.ToDecimal(dr["PCP_PumpFee"]);
            if (dr["PCP_Operator"] != DBNull.Value) pC_Plan.PCP_Operator = Convert.ToString(dr["PCP_Operator"]);
            if (dr["PCP_Schdule"] != DBNull.Value) pC_Plan.PCP_Schdule = Convert.ToString(dr["PCP_Schdule"]);
            if (dr["PCP_Station"] != DBNull.Value) pC_Plan.PCP_Station = Convert.ToString(dr["PCP_Station"]);
            if (dr["PCP_StatonName"] != DBNull.Value) pC_Plan.PCP_StatonName = Convert.ToString(dr["PCP_StatonName"]);
            ret.Add(pC_Plan);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产计划 PC_Plan对象(即:一条记录
      /// </summary>
      public List<PC_Plan> GetAll()
      {
         List<PC_Plan> ret = new List<PC_Plan>();
         string sql = "SELECT  PCP_ID,PCP_PCode,PCP_SCode,PCP_Name,PCP_CPCode,PCP_PRCode,PCP_CCode,PCP_Part,PCP_Slump,PCP_Addr,PCP_IsPipe,PCP_PLCode,PCP_Leve,PCP_Impervious,PCP_SPC,PCP_Special1,PCP_Special2,PCP_Special3,PCP_Special4,PCP_Special5,PCP_PDate,PCP_RDate,PCP_POwner,PCP_POwnerName,PCP_Date,PCP_CureStep,PCP_NextStep,PCP_IsTech,PCP_IsStart,PCP_PMNum,PCP_PUNum,PCP_PINum,PCP_PJNum,PCP_PTNum,PCP_PWNum,PCP_PPNum,PCP_PRNum,PCP_PTRNum,PCP_PPRNum,PCP_PPMNum,PCP_PTMNum,PCP_TechType,PCP_Limit,PCP_Frequence,PCP_LastDate,PCP_LastNo,PCP_Transpot,PCP_Order,PCP_DBack,PCP_Status,PCP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCP_Udef1,PCP_Udef2,PCP_Udef3,PCP_Udef4,PCP_Udef5,PCP_Udef6,PCP_Udef7,AuditCurAudit,AuditStat,PCP_LNum,PCP_ANum,PCP_Price,PCP_Sum,PCP_TankerFee,PCP_PumpFee,PCP_Operator,PCP_Schdule,PCP_Station,PCP_StatonName FROM PC_Plan where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_Plan pC_Plan = new PC_Plan();
            if (dr["PCP_ID"] != DBNull.Value) pC_Plan.PCP_ID = Convert.ToDecimal(dr["PCP_ID"]);
            if (dr["PCP_PCode"] != DBNull.Value) pC_Plan.PCP_PCode = Convert.ToString(dr["PCP_PCode"]);
            if (dr["PCP_SCode"] != DBNull.Value) pC_Plan.PCP_SCode = Convert.ToString(dr["PCP_SCode"]);
            if (dr["PCP_Name"] != DBNull.Value) pC_Plan.PCP_Name = Convert.ToString(dr["PCP_Name"]);
            if (dr["PCP_CPCode"] != DBNull.Value) pC_Plan.PCP_CPCode = Convert.ToString(dr["PCP_CPCode"]);
            if (dr["PCP_PRCode"] != DBNull.Value) pC_Plan.PCP_PRCode = Convert.ToString(dr["PCP_PRCode"]);
            if (dr["PCP_CCode"] != DBNull.Value) pC_Plan.PCP_CCode = Convert.ToString(dr["PCP_CCode"]);
            if (dr["PCP_Part"] != DBNull.Value) pC_Plan.PCP_Part = Convert.ToString(dr["PCP_Part"]);
            if (dr["PCP_Slump"] != DBNull.Value) pC_Plan.PCP_Slump = Convert.ToString(dr["PCP_Slump"]);
            if (dr["PCP_Addr"] != DBNull.Value) pC_Plan.PCP_Addr = Convert.ToString(dr["PCP_Addr"]);
            if (dr["PCP_IsPipe"] != DBNull.Value) pC_Plan.PCP_IsPipe = Convert.ToString(dr["PCP_IsPipe"]);
            if (dr["PCP_PLCode"] != DBNull.Value) pC_Plan.PCP_PLCode = Convert.ToString(dr["PCP_PLCode"]);
            if (dr["PCP_Leve"] != DBNull.Value) pC_Plan.PCP_Leve = Convert.ToString(dr["PCP_Leve"]);
            if (dr["PCP_Impervious"] != DBNull.Value) pC_Plan.PCP_Impervious = Convert.ToString(dr["PCP_Impervious"]);
            if (dr["PCP_SPC"] != DBNull.Value) pC_Plan.PCP_SPC = Convert.ToString(dr["PCP_SPC"]);
            if (dr["PCP_Special1"] != DBNull.Value) pC_Plan.PCP_Special1 = Convert.ToString(dr["PCP_Special1"]);
            if (dr["PCP_Special2"] != DBNull.Value) pC_Plan.PCP_Special2 = Convert.ToString(dr["PCP_Special2"]);
            if (dr["PCP_Special3"] != DBNull.Value) pC_Plan.PCP_Special3 = Convert.ToString(dr["PCP_Special3"]);
            if (dr["PCP_Special4"] != DBNull.Value) pC_Plan.PCP_Special4 = Convert.ToString(dr["PCP_Special4"]);
            if (dr["PCP_Special5"] != DBNull.Value) pC_Plan.PCP_Special5 = Convert.ToString(dr["PCP_Special5"]);
            if (dr["PCP_PDate"] != DBNull.Value) pC_Plan.PCP_PDate = Convert.ToDateTime(dr["PCP_PDate"]);
            if (dr["PCP_RDate"] != DBNull.Value) pC_Plan.PCP_RDate = Convert.ToDateTime(dr["PCP_RDate"]);
            if (dr["PCP_POwner"] != DBNull.Value) pC_Plan.PCP_POwner = Convert.ToString(dr["PCP_POwner"]);
            if (dr["PCP_POwnerName"] != DBNull.Value) pC_Plan.PCP_POwnerName = Convert.ToString(dr["PCP_POwnerName"]);
            if (dr["PCP_Date"] != DBNull.Value) pC_Plan.PCP_Date = Convert.ToDateTime(dr["PCP_Date"]);
            if (dr["PCP_CureStep"] != DBNull.Value) pC_Plan.PCP_CureStep = Convert.ToString(dr["PCP_CureStep"]);
            if (dr["PCP_NextStep"] != DBNull.Value) pC_Plan.PCP_NextStep = Convert.ToString(dr["PCP_NextStep"]);
            if (dr["PCP_IsTech"] != DBNull.Value) pC_Plan.PCP_IsTech = Convert.ToInt32(dr["PCP_IsTech"]);
            if (dr["PCP_IsStart"] != DBNull.Value) pC_Plan.PCP_IsStart = Convert.ToInt32(dr["PCP_IsStart"]);
            if (dr["PCP_PMNum"] != DBNull.Value) pC_Plan.PCP_PMNum = Convert.ToString(dr["PCP_PMNum"]);
            if (dr["PCP_PUNum"] != DBNull.Value) pC_Plan.PCP_PUNum = Convert.ToString(dr["PCP_PUNum"]);
            if (dr["PCP_PINum"] != DBNull.Value) pC_Plan.PCP_PINum = Convert.ToString(dr["PCP_PINum"]);
            if (dr["PCP_PJNum"] != DBNull.Value) pC_Plan.PCP_PJNum = Convert.ToString(dr["PCP_PJNum"]);
            if (dr["PCP_PTNum"] != DBNull.Value) pC_Plan.PCP_PTNum = Convert.ToInt32(dr["PCP_PTNum"]);
            if (dr["PCP_PWNum"] != DBNull.Value) pC_Plan.PCP_PWNum = Convert.ToString(dr["PCP_PWNum"]);
            if (dr["PCP_PPNum"] != DBNull.Value) pC_Plan.PCP_PPNum = Convert.ToDecimal(dr["PCP_PPNum"]);
            if (dr["PCP_PRNum"] != DBNull.Value) pC_Plan.PCP_PRNum = Convert.ToDecimal(dr["PCP_PRNum"]);
            if (dr["PCP_PTRNum"] != DBNull.Value) pC_Plan.PCP_PTRNum = Convert.ToInt32(dr["PCP_PTRNum"]);
            if (dr["PCP_PPRNum"] != DBNull.Value) pC_Plan.PCP_PPRNum = Convert.ToDecimal(dr["PCP_PPRNum"]);
            if (dr["PCP_PPMNum"] != DBNull.Value) pC_Plan.PCP_PPMNum = Convert.ToDecimal(dr["PCP_PPMNum"]);
            if (dr["PCP_PTMNum"] != DBNull.Value) pC_Plan.PCP_PTMNum = Convert.ToDecimal(dr["PCP_PTMNum"]);
            if (dr["PCP_TechType"] != DBNull.Value) pC_Plan.PCP_TechType = Convert.ToString(dr["PCP_TechType"]);
            if (dr["PCP_Limit"] != DBNull.Value) pC_Plan.PCP_Limit = Convert.ToDecimal(dr["PCP_Limit"]);
            if (dr["PCP_Frequence"] != DBNull.Value) pC_Plan.PCP_Frequence = Convert.ToInt32(dr["PCP_Frequence"]);
            if (dr["PCP_LastDate"] != DBNull.Value) pC_Plan.PCP_LastDate = Convert.ToDateTime(dr["PCP_LastDate"]);
            if (dr["PCP_LastNo"] != DBNull.Value) pC_Plan.PCP_LastNo = Convert.ToString(dr["PCP_LastNo"]);
            if (dr["PCP_Transpot"] != DBNull.Value) pC_Plan.PCP_Transpot = Convert.ToString(dr["PCP_Transpot"]);
            if (dr["PCP_Order"] != DBNull.Value) pC_Plan.PCP_Order = Convert.ToInt32(dr["PCP_Order"]);
            if (dr["PCP_DBack"] != DBNull.Value) pC_Plan.PCP_DBack = Convert.ToString(dr["PCP_DBack"]);
            if (dr["PCP_Status"] != DBNull.Value) pC_Plan.PCP_Status = Convert.ToString(dr["PCP_Status"]);
            if (dr["PCP_Bak"] != DBNull.Value) pC_Plan.PCP_Bak = Convert.ToString(dr["PCP_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_Plan.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Plan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Plan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Plan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCP_Udef1"] != DBNull.Value) pC_Plan.PCP_Udef1 = Convert.ToString(dr["PCP_Udef1"]);
            if (dr["PCP_Udef2"] != DBNull.Value) pC_Plan.PCP_Udef2 = Convert.ToString(dr["PCP_Udef2"]);
            if (dr["PCP_Udef3"] != DBNull.Value) pC_Plan.PCP_Udef3 = Convert.ToString(dr["PCP_Udef3"]);
            if (dr["PCP_Udef4"] != DBNull.Value) pC_Plan.PCP_Udef4 = Convert.ToString(dr["PCP_Udef4"]);
            if (dr["PCP_Udef5"] != DBNull.Value) pC_Plan.PCP_Udef5 = Convert.ToString(dr["PCP_Udef5"]);
            if (dr["PCP_Udef6"] != DBNull.Value) pC_Plan.PCP_Udef6 = Convert.ToString(dr["PCP_Udef6"]);
            if (dr["PCP_Udef7"] != DBNull.Value) pC_Plan.PCP_Udef7 = Convert.ToString(dr["PCP_Udef7"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pC_Plan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditStat"] != DBNull.Value) pC_Plan.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["PCP_LNum"] != DBNull.Value) pC_Plan.PCP_LNum = Convert.ToDecimal(dr["PCP_LNum"]);
            if (dr["PCP_ANum"] != DBNull.Value) pC_Plan.PCP_ANum = Convert.ToDecimal(dr["PCP_ANum"]);
            if (dr["PCP_Price"] != DBNull.Value) pC_Plan.PCP_Price = Convert.ToDecimal(dr["PCP_Price"]);
            if (dr["PCP_Sum"] != DBNull.Value) pC_Plan.PCP_Sum = Convert.ToDecimal(dr["PCP_Sum"]);
            if (dr["PCP_TankerFee"] != DBNull.Value) pC_Plan.PCP_TankerFee = Convert.ToDecimal(dr["PCP_TankerFee"]);
            if (dr["PCP_PumpFee"] != DBNull.Value) pC_Plan.PCP_PumpFee = Convert.ToDecimal(dr["PCP_PumpFee"]);
            if (dr["PCP_Operator"] != DBNull.Value) pC_Plan.PCP_Operator = Convert.ToString(dr["PCP_Operator"]);
            if (dr["PCP_Schdule"] != DBNull.Value) pC_Plan.PCP_Schdule = Convert.ToString(dr["PCP_Schdule"]);
            if (dr["PCP_Station"] != DBNull.Value) pC_Plan.PCP_Station = Convert.ToString(dr["PCP_Station"]);
            if (dr["PCP_StatonName"] != DBNull.Value) pC_Plan.PCP_StatonName = Convert.ToString(dr["PCP_StatonName"]);
            ret.Add(pC_Plan);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
