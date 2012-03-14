using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 标准配合比信息
   /// </summary>
   [Serializable]
   public partial class TC_SComp
   {
      private decimal tCS_ID;
      private bool tCS_ID_IsChanged=false;
      public decimal TCS_ID
      {
         get{ return tCS_ID; }
         set{ tCS_ID = value; tCS_ID_IsChanged=true; }
      }
      public bool TCS_ID_IsChanged
      {
         get{ return tCS_ID_IsChanged; }
         set{ tCS_ID_IsChanged = value; }
      }
      /// <summary>
      /// 配合比编号
      /// </summary>
      private string tCS_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_Code_IsChanged=false;
      /// <summary>
      /// 配合比编号
      /// </summary>
      public string TCS_Code
      {
         get{ return tCS_Code; }
         set{ tCS_Code = value; tCS_Code_IsChanged=true; }
      }
      /// <summary>
      /// 配合比编号
      /// </summary>
      public bool TCS_Code_IsChanged
      {
         get{ return tCS_Code_IsChanged; }
         set{ tCS_Code_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string tCS_Lev;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_Lev_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string TCS_Lev
      {
         get{ return tCS_Lev; }
         set{ tCS_Lev = value; tCS_Lev_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool TCS_Lev_IsChanged
      {
         get{ return tCS_Lev_IsChanged; }
         set{ tCS_Lev_IsChanged = value; }
      }
      private string tCS_IMLEVEL;
      private bool tCS_IMLEVEL_IsChanged=false;
      public string TCS_IMLEVEL
      {
         get{ return tCS_IMLEVEL; }
         set{ tCS_IMLEVEL = value; tCS_IMLEVEL_IsChanged=true; }
      }
      public bool TCS_IMLEVEL_IsChanged
      {
         get{ return tCS_IMLEVEL_IsChanged; }
         set{ tCS_IMLEVEL_IsChanged = value; }
      }
      /// <summary>
      /// 内部标示
      /// </summary>
      private string tCS_Idt;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_Idt_IsChanged=false;
      /// <summary>
      /// 内部标示
      /// </summary>
      public string TCS_Idt
      {
         get{ return tCS_Idt; }
         set{ tCS_Idt = value; tCS_Idt_IsChanged=true; }
      }
      /// <summary>
      /// 内部标示
      /// </summary>
      public bool TCS_Idt_IsChanged
      {
         get{ return tCS_Idt_IsChanged; }
         set{ tCS_Idt_IsChanged = value; }
      }
      /// <summary>
      /// 生效开始时间
      /// </summary>
      private DateTime tCS_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_Start_IsChanged=false;
      /// <summary>
      /// 生效开始时间
      /// </summary>
      public DateTime TCS_Start
      {
         get{ return tCS_Start; }
         set{ tCS_Start = value; tCS_Start_IsChanged=true; }
      }
      /// <summary>
      /// 生效开始时间
      /// </summary>
      public bool TCS_Start_IsChanged
      {
         get{ return tCS_Start_IsChanged; }
         set{ tCS_Start_IsChanged = value; }
      }
      /// <summary>
      /// 生效结束时间
      /// </summary>
      private DateTime tCS_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_End_IsChanged=false;
      /// <summary>
      /// 生效结束时间
      /// </summary>
      public DateTime TCS_End
      {
         get{ return tCS_End; }
         set{ tCS_End = value; tCS_End_IsChanged=true; }
      }
      /// <summary>
      /// 生效结束时间
      /// </summary>
      public bool TCS_End_IsChanged
      {
         get{ return tCS_End_IsChanged; }
         set{ tCS_End_IsChanged = value; }
      }
      /// <summary>
      /// 容重
      /// </summary>
      private decimal tCS_Weight;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_Weight_IsChanged=false;
      /// <summary>
      /// 容重
      /// </summary>
      public decimal TCS_Weight
      {
         get{ return tCS_Weight; }
         set{ tCS_Weight = value; tCS_Weight_IsChanged=true; }
      }
      /// <summary>
      /// 容重
      /// </summary>
      public bool TCS_Weight_IsChanged
      {
         get{ return tCS_Weight_IsChanged; }
         set{ tCS_Weight_IsChanged = value; }
      }
      /// <summary>
      /// 配合比状态
      /// </summary>
      private string tCS_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_Status_IsChanged=false;
      /// <summary>
      /// 配合比状态
      /// </summary>
      public string TCS_Status
      {
         get{ return tCS_Status; }
         set{ tCS_Status = value; tCS_Status_IsChanged=true; }
      }
      /// <summary>
      /// 配合比状态
      /// </summary>
      public bool TCS_Status_IsChanged
      {
         get{ return tCS_Status_IsChanged; }
         set{ tCS_Status_IsChanged = value; }
      }
      /// <summary>
      /// 配合比内部类型
      /// </summary>
      private string tCS_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCS_iType_IsChanged=false;
      /// <summary>
      /// 配合比内部类型
      /// </summary>
      public string TCS_iType
      {
         get{ return tCS_iType; }
         set{ tCS_iType = value; tCS_iType_IsChanged=true; }
      }
      /// <summary>
      /// 配合比内部类型
      /// </summary>
      public bool TCS_iType_IsChanged
      {
         get{ return tCS_iType_IsChanged; }
         set{ tCS_iType_IsChanged = value; }
      }
      private int tCS_Version;
      private bool tCS_Version_IsChanged=false;
      public int TCS_Version
      {
         get{ return tCS_Version; }
         set{ tCS_Version = value; tCS_Version_IsChanged=true; }
      }
      public bool TCS_Version_IsChanged
      {
         get{ return tCS_Version_IsChanged; }
         set{ tCS_Version_IsChanged = value; }
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
      private string tCS_RefType;
      private bool tCS_RefType_IsChanged=false;
      public string TCS_RefType
      {
         get{ return tCS_RefType; }
         set{ tCS_RefType = value; tCS_RefType_IsChanged=true; }
      }
      public bool TCS_RefType_IsChanged
      {
         get{ return tCS_RefType_IsChanged; }
         set{ tCS_RefType_IsChanged = value; }
      }
      private string tCS_RefCode;
      private bool tCS_RefCode_IsChanged=false;
      public string TCS_RefCode
      {
         get{ return tCS_RefCode; }
         set{ tCS_RefCode = value; tCS_RefCode_IsChanged=true; }
      }
      public bool TCS_RefCode_IsChanged
      {
         get{ return tCS_RefCode_IsChanged; }
         set{ tCS_RefCode_IsChanged = value; }
      }
      private string tCS_Udef1;
      private bool tCS_Udef1_IsChanged=false;
      public string TCS_Udef1
      {
         get{ return tCS_Udef1; }
         set{ tCS_Udef1 = value; tCS_Udef1_IsChanged=true; }
      }
      public bool TCS_Udef1_IsChanged
      {
         get{ return tCS_Udef1_IsChanged; }
         set{ tCS_Udef1_IsChanged = value; }
      }
      private string tCS_Udef2;
      private bool tCS_Udef2_IsChanged=false;
      public string TCS_Udef2
      {
         get{ return tCS_Udef2; }
         set{ tCS_Udef2 = value; tCS_Udef2_IsChanged=true; }
      }
      public bool TCS_Udef2_IsChanged
      {
         get{ return tCS_Udef2_IsChanged; }
         set{ tCS_Udef2_IsChanged = value; }
      }
      private string tCS_Udef3;
      private bool tCS_Udef3_IsChanged=false;
      public string TCS_Udef3
      {
         get{ return tCS_Udef3; }
         set{ tCS_Udef3 = value; tCS_Udef3_IsChanged=true; }
      }
      public bool TCS_Udef3_IsChanged
      {
         get{ return tCS_Udef3_IsChanged; }
         set{ tCS_Udef3_IsChanged = value; }
      }
   }
}
