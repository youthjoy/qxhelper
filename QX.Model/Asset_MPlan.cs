using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 固定资产检修计划
   /// </summary>
   [Serializable]
   public partial class Asset_MPlan
   {
      /// <summary>
      /// 计划列表序号
      /// </summary>
      private decimal aMP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMP_ID_IsChanged=false;
      /// <summary>
      /// 计划列表序号
      /// </summary>
      public decimal AMP_ID
      {
         get{ return aMP_ID; }
         set{ aMP_ID = value; aMP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 计划列表序号
      /// </summary>
      public bool AMP_ID_IsChanged
      {
         get{ return aMP_ID_IsChanged; }
         set{ aMP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      private string aMP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMP_Code_IsChanged=false;
      /// <summary>
      /// 计划编码
      /// </summary>
      public string AMP_Code
      {
         get{ return aMP_Code; }
         set{ aMP_Code = value; aMP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      public bool AMP_Code_IsChanged
      {
         get{ return aMP_Code_IsChanged; }
         set{ aMP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 计划名称
      /// </summary>
      private string aMP_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMP_Name_IsChanged=false;
      /// <summary>
      /// 计划名称
      /// </summary>
      public string AMP_Name
      {
         get{ return aMP_Name; }
         set{ aMP_Name = value; aMP_Name_IsChanged=true; }
      }
      /// <summary>
      /// 计划名称
      /// </summary>
      public bool AMP_Name_IsChanged
      {
         get{ return aMP_Name_IsChanged; }
         set{ aMP_Name_IsChanged = value; }
      }
      /// <summary>
      /// 计划人
      /// </summary>
      private string aMP_Stuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMP_Stuff_IsChanged=false;
      /// <summary>
      /// 计划人
      /// </summary>
      public string AMP_Stuff
      {
         get{ return aMP_Stuff; }
         set{ aMP_Stuff = value; aMP_Stuff_IsChanged=true; }
      }
      /// <summary>
      /// 计划人
      /// </summary>
      public bool AMP_Stuff_IsChanged
      {
         get{ return aMP_Stuff_IsChanged; }
         set{ aMP_Stuff_IsChanged = value; }
      }
      /// <summary>
      /// 计划开始时间
      /// </summary>
      private DateTime aMP_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMP_Start_IsChanged=false;
      /// <summary>
      /// 计划开始时间
      /// </summary>
      public DateTime AMP_Start
      {
         get{ return aMP_Start; }
         set{ aMP_Start = value; aMP_Start_IsChanged=true; }
      }
      /// <summary>
      /// 计划开始时间
      /// </summary>
      public bool AMP_Start_IsChanged
      {
         get{ return aMP_Start_IsChanged; }
         set{ aMP_Start_IsChanged = value; }
      }
      /// <summary>
      /// 计划结束时间
      /// </summary>
      private DateTime aMP_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMP_End_IsChanged=false;
      /// <summary>
      /// 计划结束时间
      /// </summary>
      public DateTime AMP_End
      {
         get{ return aMP_End; }
         set{ aMP_End = value; aMP_End_IsChanged=true; }
      }
      /// <summary>
      /// 计划结束时间
      /// </summary>
      public bool AMP_End_IsChanged
      {
         get{ return aMP_End_IsChanged; }
         set{ aMP_End_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string verifyStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyStuff_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string VerifyStuff
      {
         get{ return verifyStuff; }
         set{ verifyStuff = value; verifyStuff_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool VerifyStuff_IsChanged
      {
         get{ return verifyStuff_IsChanged; }
         set{ verifyStuff_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string auditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime verifyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyDate_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime VerifyDate
      {
         get{ return verifyDate; }
         set{ verifyDate = value; verifyDate_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool VerifyDate_IsChanged
      {
         get{ return verifyDate_IsChanged; }
         set{ verifyDate_IsChanged = value; }
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
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createDate_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime updateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool updateDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime deleteDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool deleteDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
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
      private string aMP_Type;
      private bool aMP_Type_IsChanged=false;
      public string AMP_Type
      {
         get{ return aMP_Type; }
         set{ aMP_Type = value; aMP_Type_IsChanged=true; }
      }
      public bool AMP_Type_IsChanged
      {
         get{ return aMP_Type_IsChanged; }
         set{ aMP_Type_IsChanged = value; }
      }
      private string aMP_Company;
      private bool aMP_Company_IsChanged=false;
      public string AMP_Company
      {
         get{ return aMP_Company; }
         set{ aMP_Company = value; aMP_Company_IsChanged=true; }
      }
      public bool AMP_Company_IsChanged
      {
         get{ return aMP_Company_IsChanged; }
         set{ aMP_Company_IsChanged = value; }
      }
      private string aMP_Dept;
      private bool aMP_Dept_IsChanged=false;
      public string AMP_Dept
      {
         get{ return aMP_Dept; }
         set{ aMP_Dept = value; aMP_Dept_IsChanged=true; }
      }
      public bool AMP_Dept_IsChanged
      {
         get{ return aMP_Dept_IsChanged; }
         set{ aMP_Dept_IsChanged = value; }
      }
   }
}
