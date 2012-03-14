using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 事故调查报告
   /// </summary>
   [Serializable]
   public partial class Accident_Record
   {
      /// <summary>
      /// 事故调查记录序号
      /// </summary>
      private decimal aR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_ID_IsChanged=false;
      /// <summary>
      /// 事故调查记录序号
      /// </summary>
      public decimal AR_ID
      {
         get{ return aR_ID; }
         set{ aR_ID = value; aR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 事故调查记录序号
      /// </summary>
      public bool AR_ID_IsChanged
      {
         get{ return aR_ID_IsChanged; }
         set{ aR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 记录编码
      /// </summary>
      private string aR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Code_IsChanged=false;
      /// <summary>
      /// 记录编码
      /// </summary>
      public string AR_Code
      {
         get{ return aR_Code; }
         set{ aR_Code = value; aR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 记录编码
      /// </summary>
      public bool AR_Code_IsChanged
      {
         get{ return aR_Code_IsChanged; }
         set{ aR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 事故类别
      /// </summary>
      private string aR_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Type_IsChanged=false;
      /// <summary>
      /// 事故类别
      /// </summary>
      public string AR_Type
      {
         get{ return aR_Type; }
         set{ aR_Type = value; aR_Type_IsChanged=true; }
      }
      /// <summary>
      /// 事故类别
      /// </summary>
      public bool AR_Type_IsChanged
      {
         get{ return aR_Type_IsChanged; }
         set{ aR_Type_IsChanged = value; }
      }
      /// <summary>
      /// 事故时间
      /// </summary>
      private DateTime aR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Date_IsChanged=false;
      /// <summary>
      /// 事故时间
      /// </summary>
      public DateTime AR_Date
      {
         get{ return aR_Date; }
         set{ aR_Date = value; aR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 事故时间
      /// </summary>
      public bool AR_Date_IsChanged
      {
         get{ return aR_Date_IsChanged; }
         set{ aR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 调查时间
      /// </summary>
      private DateTime aR_CheckDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_CheckDate_IsChanged=false;
      /// <summary>
      /// 调查时间
      /// </summary>
      public DateTime AR_CheckDate
      {
         get{ return aR_CheckDate; }
         set{ aR_CheckDate = value; aR_CheckDate_IsChanged=true; }
      }
      /// <summary>
      /// 调查时间
      /// </summary>
      public bool AR_CheckDate_IsChanged
      {
         get{ return aR_CheckDate_IsChanged; }
         set{ aR_CheckDate_IsChanged = value; }
      }
      /// <summary>
      /// 受伤人员
      /// </summary>
      private string aR_Injurer;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Injurer_IsChanged=false;
      /// <summary>
      /// 受伤人员
      /// </summary>
      public string AR_Injurer
      {
         get{ return aR_Injurer; }
         set{ aR_Injurer = value; aR_Injurer_IsChanged=true; }
      }
      /// <summary>
      /// 受伤人员
      /// </summary>
      public bool AR_Injurer_IsChanged
      {
         get{ return aR_Injurer_IsChanged; }
         set{ aR_Injurer_IsChanged = value; }
      }
      /// <summary>
      /// 经过描述
      /// </summary>
      private string aR_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Content_IsChanged=false;
      /// <summary>
      /// 经过描述
      /// </summary>
      public string AR_Content
      {
         get{ return aR_Content; }
         set{ aR_Content = value; aR_Content_IsChanged=true; }
      }
      /// <summary>
      /// 经过描述
      /// </summary>
      public bool AR_Content_IsChanged
      {
         get{ return aR_Content_IsChanged; }
         set{ aR_Content_IsChanged = value; }
      }
      /// <summary>
      /// 事故直接原因
      /// </summary>
      private string aR_MainReason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_MainReason_IsChanged=false;
      /// <summary>
      /// 事故直接原因
      /// </summary>
      public string AR_MainReason
      {
         get{ return aR_MainReason; }
         set{ aR_MainReason = value; aR_MainReason_IsChanged=true; }
      }
      /// <summary>
      /// 事故直接原因
      /// </summary>
      public bool AR_MainReason_IsChanged
      {
         get{ return aR_MainReason_IsChanged; }
         set{ aR_MainReason_IsChanged = value; }
      }
      /// <summary>
      /// 事故间接原因
      /// </summary>
      private string aR_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Reason_IsChanged=false;
      /// <summary>
      /// 事故间接原因
      /// </summary>
      public string AR_Reason
      {
         get{ return aR_Reason; }
         set{ aR_Reason = value; aR_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 事故间接原因
      /// </summary>
      public bool AR_Reason_IsChanged
      {
         get{ return aR_Reason_IsChanged; }
         set{ aR_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 事故性质认定
      /// </summary>
      private string aR_Identification;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Identification_IsChanged=false;
      /// <summary>
      /// 事故性质认定
      /// </summary>
      public string AR_Identification
      {
         get{ return aR_Identification; }
         set{ aR_Identification = value; aR_Identification_IsChanged=true; }
      }
      /// <summary>
      /// 事故性质认定
      /// </summary>
      public bool AR_Identification_IsChanged
      {
         get{ return aR_Identification_IsChanged; }
         set{ aR_Identification_IsChanged = value; }
      }
      /// <summary>
      /// 整改措施
      /// </summary>
      private string aR_Rectification;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Rectification_IsChanged=false;
      /// <summary>
      /// 整改措施
      /// </summary>
      public string AR_Rectification
      {
         get{ return aR_Rectification; }
         set{ aR_Rectification = value; aR_Rectification_IsChanged=true; }
      }
      /// <summary>
      /// 整改措施
      /// </summary>
      public bool AR_Rectification_IsChanged
      {
         get{ return aR_Rectification_IsChanged; }
         set{ aR_Rectification_IsChanged = value; }
      }
      /// <summary>
      /// 整改计划完成时间
      /// </summary>
      private DateTime aR_RectificationDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_RectificationDate_IsChanged=false;
      /// <summary>
      /// 整改计划完成时间
      /// </summary>
      public DateTime AR_RectificationDate
      {
         get{ return aR_RectificationDate; }
         set{ aR_RectificationDate = value; aR_RectificationDate_IsChanged=true; }
      }
      /// <summary>
      /// 整改计划完成时间
      /// </summary>
      public bool AR_RectificationDate_IsChanged
      {
         get{ return aR_RectificationDate_IsChanged; }
         set{ aR_RectificationDate_IsChanged = value; }
      }
      /// <summary>
      /// 实施负责人
      /// </summary>
      private string aR_RectificationPerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_RectificationPerson_IsChanged=false;
      /// <summary>
      /// 实施负责人
      /// </summary>
      public string AR_RectificationPerson
      {
         get{ return aR_RectificationPerson; }
         set{ aR_RectificationPerson = value; aR_RectificationPerson_IsChanged=true; }
      }
      /// <summary>
      /// 实施负责人
      /// </summary>
      public bool AR_RectificationPerson_IsChanged
      {
         get{ return aR_RectificationPerson_IsChanged; }
         set{ aR_RectificationPerson_IsChanged = value; }
      }
      /// <summary>
      /// 防范整改实施情况
      /// </summary>
      private string aR_RectificationContent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_RectificationContent_IsChanged=false;
      /// <summary>
      /// 防范整改实施情况
      /// </summary>
      public string AR_RectificationContent
      {
         get{ return aR_RectificationContent; }
         set{ aR_RectificationContent = value; aR_RectificationContent_IsChanged=true; }
      }
      /// <summary>
      /// 防范整改实施情况
      /// </summary>
      public bool AR_RectificationContent_IsChanged
      {
         get{ return aR_RectificationContent_IsChanged; }
         set{ aR_RectificationContent_IsChanged = value; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      private string aR_Duty;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Duty_IsChanged=false;
      /// <summary>
      /// 责任人
      /// </summary>
      public string AR_Duty
      {
         get{ return aR_Duty; }
         set{ aR_Duty = value; aR_Duty_IsChanged=true; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      public bool AR_Duty_IsChanged
      {
         get{ return aR_Duty_IsChanged; }
         set{ aR_Duty_IsChanged = value; }
      }
      /// <summary>
      /// 部门负责人
      /// </summary>
      private string aR_DutyDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_DutyDept_IsChanged=false;
      /// <summary>
      /// 部门负责人
      /// </summary>
      public string AR_DutyDept
      {
         get{ return aR_DutyDept; }
         set{ aR_DutyDept = value; aR_DutyDept_IsChanged=true; }
      }
      /// <summary>
      /// 部门负责人
      /// </summary>
      public bool AR_DutyDept_IsChanged
      {
         get{ return aR_DutyDept_IsChanged; }
         set{ aR_DutyDept_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string aR_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string AR_iType
      {
         get{ return aR_iType; }
         set{ aR_iType = value; aR_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool AR_iType_IsChanged
      {
         get{ return aR_iType_IsChanged; }
         set{ aR_iType_IsChanged = value; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      private string aR_AuditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_AuditStat_IsChanged=false;
      /// <summary>
      /// 当前状态
      /// </summary>
      public string AR_AuditStat
      {
         get{ return aR_AuditStat; }
         set{ aR_AuditStat = value; aR_AuditStat_IsChanged=true; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      public bool AR_AuditStat_IsChanged
      {
         get{ return aR_AuditStat_IsChanged; }
         set{ aR_AuditStat_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string aR_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Stat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string AR_Stat
      {
         get{ return aR_Stat; }
         set{ aR_Stat = value; aR_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool AR_Stat_IsChanged
      {
         get{ return aR_Stat_IsChanged; }
         set{ aR_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string aR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string AR_Remark
      {
         get{ return aR_Remark; }
         set{ aR_Remark = value; aR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool AR_Remark_IsChanged
      {
         get{ return aR_Remark_IsChanged; }
         set{ aR_Remark_IsChanged = value; }
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
   }
}
