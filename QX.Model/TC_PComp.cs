using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产配比信息
   /// </summary>
   [Serializable]
   public partial class TC_PComp
   {
      private decimal tCPC_ID;
      private bool tCPC_ID_IsChanged=false;
      public decimal TCPC_ID
      {
         get{ return tCPC_ID; }
         set{ tCPC_ID = value; tCPC_ID_IsChanged=true; }
      }
      public bool TCPC_ID_IsChanged
      {
         get{ return tCPC_ID_IsChanged; }
         set{ tCPC_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产配比编号
      /// </summary>
      private string tCPC_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Code_IsChanged=false;
      /// <summary>
      /// 生产配比编号
      /// </summary>
      public string TCPC_Code
      {
         get{ return tCPC_Code; }
         set{ tCPC_Code = value; tCPC_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产配比编号
      /// </summary>
      public bool TCPC_Code_IsChanged
      {
         get{ return tCPC_Code_IsChanged; }
         set{ tCPC_Code_IsChanged = value; }
      }
      /// <summary>
      /// 配比名称
      /// </summary>
      private string tCPC_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Name_IsChanged=false;
      /// <summary>
      /// 配比名称
      /// </summary>
      public string TCPC_Name
      {
         get{ return tCPC_Name; }
         set{ tCPC_Name = value; tCPC_Name_IsChanged=true; }
      }
      /// <summary>
      /// 配比名称
      /// </summary>
      public bool TCPC_Name_IsChanged
      {
         get{ return tCPC_Name_IsChanged; }
         set{ tCPC_Name_IsChanged = value; }
      }
      /// <summary>
      /// 配比类型
      /// </summary>
      private string tCPC_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Type_IsChanged=false;
      /// <summary>
      /// 配比类型
      /// </summary>
      public string TCPC_Type
      {
         get{ return tCPC_Type; }
         set{ tCPC_Type = value; tCPC_Type_IsChanged=true; }
      }
      /// <summary>
      /// 配比类型
      /// </summary>
      public bool TCPC_Type_IsChanged
      {
         get{ return tCPC_Type_IsChanged; }
         set{ tCPC_Type_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string tCPC_Lev;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Lev_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string TCPC_Lev
      {
         get{ return tCPC_Lev; }
         set{ tCPC_Lev = value; tCPC_Lev_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool TCPC_Lev_IsChanged
      {
         get{ return tCPC_Lev_IsChanged; }
         set{ tCPC_Lev_IsChanged = value; }
      }
      private string tCPC_IMLEVEL;
      private bool tCPC_IMLEVEL_IsChanged=false;
      public string TCPC_IMLEVEL
      {
         get{ return tCPC_IMLEVEL; }
         set{ tCPC_IMLEVEL = value; tCPC_IMLEVEL_IsChanged=true; }
      }
      public bool TCPC_IMLEVEL_IsChanged
      {
         get{ return tCPC_IMLEVEL_IsChanged; }
         set{ tCPC_IMLEVEL_IsChanged = value; }
      }
      /// <summary>
      /// 日期
      /// </summary>
      private string tCPC_Day;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Day_IsChanged=false;
      /// <summary>
      /// 日期
      /// </summary>
      public string TCPC_Day
      {
         get{ return tCPC_Day; }
         set{ tCPC_Day = value; tCPC_Day_IsChanged=true; }
      }
      /// <summary>
      /// 日期
      /// </summary>
      public bool TCPC_Day_IsChanged
      {
         get{ return tCPC_Day_IsChanged; }
         set{ tCPC_Day_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌站
      /// </summary>
      private string tCPC_Station;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Station_IsChanged=false;
      /// <summary>
      /// 搅拌站
      /// </summary>
      public string TCPC_Station
      {
         get{ return tCPC_Station; }
         set{ tCPC_Station = value; tCPC_Station_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌站
      /// </summary>
      public bool TCPC_Station_IsChanged
      {
         get{ return tCPC_Station_IsChanged; }
         set{ tCPC_Station_IsChanged = value; }
      }
      /// <summary>
      /// 生产线
      /// </summary>
      private string tCPC_Line;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Line_IsChanged=false;
      /// <summary>
      /// 生产线
      /// </summary>
      public string TCPC_Line
      {
         get{ return tCPC_Line; }
         set{ tCPC_Line = value; tCPC_Line_IsChanged=true; }
      }
      /// <summary>
      /// 生产线
      /// </summary>
      public bool TCPC_Line_IsChanged
      {
         get{ return tCPC_Line_IsChanged; }
         set{ tCPC_Line_IsChanged = value; }
      }
      /// <summary>
      /// 计划编号
      /// </summary>
      private string tCPC_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_PCode_IsChanged=false;
      /// <summary>
      /// 计划编号
      /// </summary>
      public string TCPC_PCode
      {
         get{ return tCPC_PCode; }
         set{ tCPC_PCode = value; tCPC_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 计划编号
      /// </summary>
      public bool TCPC_PCode_IsChanged
      {
         get{ return tCPC_PCode_IsChanged; }
         set{ tCPC_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 制定人
      /// </summary>
      private string tCPC_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Owner_IsChanged=false;
      /// <summary>
      /// 制定人
      /// </summary>
      public string TCPC_Owner
      {
         get{ return tCPC_Owner; }
         set{ tCPC_Owner = value; tCPC_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 制定人
      /// </summary>
      public bool TCPC_Owner_IsChanged
      {
         get{ return tCPC_Owner_IsChanged; }
         set{ tCPC_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 制定时间
      /// </summary>
      private DateTime tCPC_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Date_IsChanged=false;
      /// <summary>
      /// 制定时间
      /// </summary>
      public DateTime TCPC_Date
      {
         get{ return tCPC_Date; }
         set{ tCPC_Date = value; tCPC_Date_IsChanged=true; }
      }
      /// <summary>
      /// 制定时间
      /// </summary>
      public bool TCPC_Date_IsChanged
      {
         get{ return tCPC_Date_IsChanged; }
         set{ tCPC_Date_IsChanged = value; }
      }
      /// <summary>
      /// 版本号
      /// </summary>
      private int tCPC_IsCurrent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_IsCurrent_IsChanged=false;
      /// <summary>
      /// 版本号
      /// </summary>
      public int TCPC_IsCurrent
      {
         get{ return tCPC_IsCurrent; }
         set{ tCPC_IsCurrent = value; tCPC_IsCurrent_IsChanged=true; }
      }
      /// <summary>
      /// 版本号
      /// </summary>
      public bool TCPC_IsCurrent_IsChanged
      {
         get{ return tCPC_IsCurrent_IsChanged; }
         set{ tCPC_IsCurrent_IsChanged = value; }
      }
      /// <summary>
      /// 参考标准配比
      /// </summary>
      private string tCPC_RefSTCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_RefSTCode_IsChanged=false;
      /// <summary>
      /// 参考标准配比
      /// </summary>
      public string TCPC_RefSTCode
      {
         get{ return tCPC_RefSTCode; }
         set{ tCPC_RefSTCode = value; tCPC_RefSTCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考标准配比
      /// </summary>
      public bool TCPC_RefSTCode_IsChanged
      {
         get{ return tCPC_RefSTCode_IsChanged; }
         set{ tCPC_RefSTCode_IsChanged = value; }
      }
      /// <summary>
      /// 其他参考类型
      /// </summary>
      private string tCPC_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_RefType_IsChanged=false;
      /// <summary>
      /// 其他参考类型
      /// </summary>
      public string TCPC_RefType
      {
         get{ return tCPC_RefType; }
         set{ tCPC_RefType = value; tCPC_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 其他参考类型
      /// </summary>
      public bool TCPC_RefType_IsChanged
      {
         get{ return tCPC_RefType_IsChanged; }
         set{ tCPC_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 参考配比
      /// </summary>
      private string tCPC_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_RefCode_IsChanged=false;
      /// <summary>
      /// 参考配比
      /// </summary>
      public string TCPC_RefCode
      {
         get{ return tCPC_RefCode; }
         set{ tCPC_RefCode = value; tCPC_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考配比
      /// </summary>
      public bool TCPC_RefCode_IsChanged
      {
         get{ return tCPC_RefCode_IsChanged; }
         set{ tCPC_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 配比重量
      /// </summary>
      private decimal tCPC_Weight;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_Weight_IsChanged=false;
      /// <summary>
      /// 配比重量
      /// </summary>
      public decimal TCPC_Weight
      {
         get{ return tCPC_Weight; }
         set{ tCPC_Weight = value; tCPC_Weight_IsChanged=true; }
      }
      /// <summary>
      /// 配比重量
      /// </summary>
      public bool TCPC_Weight_IsChanged
      {
         get{ return tCPC_Weight_IsChanged; }
         set{ tCPC_Weight_IsChanged = value; }
      }
      /// <summary>
      /// 造壳时间
      /// </summary>
      private int tCPC_ZDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_ZDate_IsChanged=false;
      /// <summary>
      /// 造壳时间
      /// </summary>
      public int TCPC_ZDate
      {
         get{ return tCPC_ZDate; }
         set{ tCPC_ZDate = value; tCPC_ZDate_IsChanged=true; }
      }
      /// <summary>
      /// 造壳时间
      /// </summary>
      public bool TCPC_ZDate_IsChanged
      {
         get{ return tCPC_ZDate_IsChanged; }
         set{ tCPC_ZDate_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌时间
      /// </summary>
      private int tCPC_JDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPC_JDate_IsChanged=false;
      /// <summary>
      /// 搅拌时间
      /// </summary>
      public int TCPC_JDate
      {
         get{ return tCPC_JDate; }
         set{ tCPC_JDate = value; tCPC_JDate_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌时间
      /// </summary>
      public bool TCPC_JDate_IsChanged
      {
         get{ return tCPC_JDate_IsChanged; }
         set{ tCPC_JDate_IsChanged = value; }
      }
      private string auditStat;
      private bool auditStat_IsChanged=false;
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private string auditCurAudit;
      private bool auditCurAudit_IsChanged=false;
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
      private string tCPC_Udef1;
      private bool tCPC_Udef1_IsChanged=false;
      public string TCPC_Udef1
      {
         get{ return tCPC_Udef1; }
         set{ tCPC_Udef1 = value; tCPC_Udef1_IsChanged=true; }
      }
      public bool TCPC_Udef1_IsChanged
      {
         get{ return tCPC_Udef1_IsChanged; }
         set{ tCPC_Udef1_IsChanged = value; }
      }
      private string tCPC_Udef2;
      private bool tCPC_Udef2_IsChanged=false;
      public string TCPC_Udef2
      {
         get{ return tCPC_Udef2; }
         set{ tCPC_Udef2 = value; tCPC_Udef2_IsChanged=true; }
      }
      public bool TCPC_Udef2_IsChanged
      {
         get{ return tCPC_Udef2_IsChanged; }
         set{ tCPC_Udef2_IsChanged = value; }
      }
      private string tCPC_Udef3;
      private bool tCPC_Udef3_IsChanged=false;
      public string TCPC_Udef3
      {
         get{ return tCPC_Udef3; }
         set{ tCPC_Udef3 = value; tCPC_Udef3_IsChanged=true; }
      }
      public bool TCPC_Udef3_IsChanged
      {
         get{ return tCPC_Udef3_IsChanged; }
         set{ tCPC_Udef3_IsChanged = value; }
      }
   }
}
