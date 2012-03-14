using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 维修申请
   /// </summary>
   [Serializable]
   public partial class Asset_MApply
   {
      /// <summary>
      /// 维修申请序号
      /// </summary>
      private decimal aMA_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_ID_IsChanged=false;
      /// <summary>
      /// 维修申请序号
      /// </summary>
      public decimal AMA_ID
      {
         get{ return aMA_ID; }
         set{ aMA_ID = value; aMA_ID_IsChanged=true; }
      }
      /// <summary>
      /// 维修申请序号
      /// </summary>
      public bool AMA_ID_IsChanged
      {
         get{ return aMA_ID_IsChanged; }
         set{ aMA_ID_IsChanged = value; }
      }
      /// <summary>
      /// 维修申请编码
      /// </summary>
      private string aMA_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Code_IsChanged=false;
      /// <summary>
      /// 维修申请编码
      /// </summary>
      public string AMA_Code
      {
         get{ return aMA_Code; }
         set{ aMA_Code = value; aMA_Code_IsChanged=true; }
      }
      /// <summary>
      /// 维修申请编码
      /// </summary>
      public bool AMA_Code_IsChanged
      {
         get{ return aMA_Code_IsChanged; }
         set{ aMA_Code_IsChanged = value; }
      }
      /// <summary>
      /// 故障设备编码
      /// </summary>
      private string aMA_FCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_FCode_IsChanged=false;
      /// <summary>
      /// 故障设备编码
      /// </summary>
      public string AMA_FCode
      {
         get{ return aMA_FCode; }
         set{ aMA_FCode = value; aMA_FCode_IsChanged=true; }
      }
      /// <summary>
      /// 故障设备编码
      /// </summary>
      public bool AMA_FCode_IsChanged
      {
         get{ return aMA_FCode_IsChanged; }
         set{ aMA_FCode_IsChanged = value; }
      }
      /// <summary>
      /// 故障设备名称
      /// </summary>
      private string aMA_FName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_FName_IsChanged=false;
      /// <summary>
      /// 故障设备名称
      /// </summary>
      public string AMA_FName
      {
         get{ return aMA_FName; }
         set{ aMA_FName = value; aMA_FName_IsChanged=true; }
      }
      /// <summary>
      /// 故障设备名称
      /// </summary>
      public bool AMA_FName_IsChanged
      {
         get{ return aMA_FName_IsChanged; }
         set{ aMA_FName_IsChanged = value; }
      }
      /// <summary>
      /// 故障设备名称
      /// </summary>
      private string aMA_FSpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_FSpec_IsChanged=false;
      /// <summary>
      /// 故障设备名称
      /// </summary>
      public string AMA_FSpec
      {
         get{ return aMA_FSpec; }
         set{ aMA_FSpec = value; aMA_FSpec_IsChanged=true; }
      }
      /// <summary>
      /// 故障设备名称
      /// </summary>
      public bool AMA_FSpec_IsChanged
      {
         get{ return aMA_FSpec_IsChanged; }
         set{ aMA_FSpec_IsChanged = value; }
      }
      /// <summary>
      /// 资产所属公司
      /// </summary>
      private string aMA_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Company_IsChanged=false;
      /// <summary>
      /// 资产所属公司
      /// </summary>
      public string AMA_Company
      {
         get{ return aMA_Company; }
         set{ aMA_Company = value; aMA_Company_IsChanged=true; }
      }
      /// <summary>
      /// 资产所属公司
      /// </summary>
      public bool AMA_Company_IsChanged
      {
         get{ return aMA_Company_IsChanged; }
         set{ aMA_Company_IsChanged = value; }
      }
      /// <summary>
      /// 资产所属部门
      /// </summary>
      private string aMA_Department;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Department_IsChanged=false;
      /// <summary>
      /// 资产所属部门
      /// </summary>
      public string AMA_Department
      {
         get{ return aMA_Department; }
         set{ aMA_Department = value; aMA_Department_IsChanged=true; }
      }
      /// <summary>
      /// 资产所属部门
      /// </summary>
      public bool AMA_Department_IsChanged
      {
         get{ return aMA_Department_IsChanged; }
         set{ aMA_Department_IsChanged = value; }
      }
      /// <summary>
      /// 故障发生原因
      /// </summary>
      private string aMA_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Reason_IsChanged=false;
      /// <summary>
      /// 故障发生原因
      /// </summary>
      public string AMA_Reason
      {
         get{ return aMA_Reason; }
         set{ aMA_Reason = value; aMA_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 故障发生原因
      /// </summary>
      public bool AMA_Reason_IsChanged
      {
         get{ return aMA_Reason_IsChanged; }
         set{ aMA_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 故障描述
      /// </summary>
      private string aMA_Description;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Description_IsChanged=false;
      /// <summary>
      /// 故障描述
      /// </summary>
      public string AMA_Description
      {
         get{ return aMA_Description; }
         set{ aMA_Description = value; aMA_Description_IsChanged=true; }
      }
      /// <summary>
      /// 故障描述
      /// </summary>
      public bool AMA_Description_IsChanged
      {
         get{ return aMA_Description_IsChanged; }
         set{ aMA_Description_IsChanged = value; }
      }
      /// <summary>
      /// 故障发生时间
      /// </summary>
      private DateTime aMA_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Date_IsChanged=false;
      /// <summary>
      /// 故障发生时间
      /// </summary>
      public DateTime AMA_Date
      {
         get{ return aMA_Date; }
         set{ aMA_Date = value; aMA_Date_IsChanged=true; }
      }
      /// <summary>
      /// 故障发生时间
      /// </summary>
      public bool AMA_Date_IsChanged
      {
         get{ return aMA_Date_IsChanged; }
         set{ aMA_Date_IsChanged = value; }
      }
      private decimal aMA_TimeCost;
      private bool aMA_TimeCost_IsChanged=false;
      public decimal AMA_TimeCost
      {
         get{ return aMA_TimeCost; }
         set{ aMA_TimeCost = value; aMA_TimeCost_IsChanged=true; }
      }
      public bool AMA_TimeCost_IsChanged
      {
         get{ return aMA_TimeCost_IsChanged; }
         set{ aMA_TimeCost_IsChanged = value; }
      }
      /// <summary>
      /// 故障报修申请人
      /// </summary>
      private string aMA_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Owner_IsChanged=false;
      /// <summary>
      /// 故障报修申请人
      /// </summary>
      public string AMA_Owner
      {
         get{ return aMA_Owner; }
         set{ aMA_Owner = value; aMA_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 故障报修申请人
      /// </summary>
      public bool AMA_Owner_IsChanged
      {
         get{ return aMA_Owner_IsChanged; }
         set{ aMA_Owner_IsChanged = value; }
      }
      private string aMA_OwnerCode;
      private bool aMA_OwnerCode_IsChanged=false;
      public string AMA_OwnerCode
      {
         get{ return aMA_OwnerCode; }
         set{ aMA_OwnerCode = value; aMA_OwnerCode_IsChanged=true; }
      }
      public bool AMA_OwnerCode_IsChanged
      {
         get{ return aMA_OwnerCode_IsChanged; }
         set{ aMA_OwnerCode_IsChanged = value; }
      }
      /// <summary>
      /// 报修时间
      /// </summary>
      private DateTime aMA_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_OpDate_IsChanged=false;
      /// <summary>
      /// 报修时间
      /// </summary>
      public DateTime AMA_OpDate
      {
         get{ return aMA_OpDate; }
         set{ aMA_OpDate = value; aMA_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 报修时间
      /// </summary>
      public bool AMA_OpDate_IsChanged
      {
         get{ return aMA_OpDate_IsChanged; }
         set{ aMA_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 接修时间
      /// </summary>
      private DateTime aMA_ReceiveDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_ReceiveDate_IsChanged=false;
      /// <summary>
      /// 接修时间
      /// </summary>
      public DateTime AMA_ReceiveDate
      {
         get{ return aMA_ReceiveDate; }
         set{ aMA_ReceiveDate = value; aMA_ReceiveDate_IsChanged=true; }
      }
      /// <summary>
      /// 接修时间
      /// </summary>
      public bool AMA_ReceiveDate_IsChanged
      {
         get{ return aMA_ReceiveDate_IsChanged; }
         set{ aMA_ReceiveDate_IsChanged = value; }
      }
      /// <summary>
      /// 报修操作人
      /// </summary>
      private string aMA_OperatorCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_OperatorCode_IsChanged=false;
      /// <summary>
      /// 报修操作人
      /// </summary>
      public string AMA_OperatorCode
      {
         get{ return aMA_OperatorCode; }
         set{ aMA_OperatorCode = value; aMA_OperatorCode_IsChanged=true; }
      }
      /// <summary>
      /// 报修操作人
      /// </summary>
      public bool AMA_OperatorCode_IsChanged
      {
         get{ return aMA_OperatorCode_IsChanged; }
         set{ aMA_OperatorCode_IsChanged = value; }
      }
      /// <summary>
      /// 报修操作人
      /// </summary>
      private string aMA_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Operator_IsChanged=false;
      /// <summary>
      /// 报修操作人
      /// </summary>
      public string AMA_Operator
      {
         get{ return aMA_Operator; }
         set{ aMA_Operator = value; aMA_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 报修操作人
      /// </summary>
      public bool AMA_Operator_IsChanged
      {
         get{ return aMA_Operator_IsChanged; }
         set{ aMA_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 处理方式
      /// </summary>
      private string aMA_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Content_IsChanged=false;
      /// <summary>
      /// 处理方式
      /// </summary>
      public string AMA_Content
      {
         get{ return aMA_Content; }
         set{ aMA_Content = value; aMA_Content_IsChanged=true; }
      }
      /// <summary>
      /// 处理方式
      /// </summary>
      public bool AMA_Content_IsChanged
      {
         get{ return aMA_Content_IsChanged; }
         set{ aMA_Content_IsChanged = value; }
      }
      private string aMA_OStatus;
      private bool aMA_OStatus_IsChanged=false;
      public string AMA_OStatus
      {
         get{ return aMA_OStatus; }
         set{ aMA_OStatus = value; aMA_OStatus_IsChanged=true; }
      }
      public bool AMA_OStatus_IsChanged
      {
         get{ return aMA_OStatus_IsChanged; }
         set{ aMA_OStatus_IsChanged = value; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      private string aMA_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Stat_IsChanged=false;
      /// <summary>
      /// 当前状态
      /// </summary>
      public string AMA_Stat
      {
         get{ return aMA_Stat; }
         set{ aMA_Stat = value; aMA_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      public bool AMA_Stat_IsChanged
      {
         get{ return aMA_Stat_IsChanged; }
         set{ aMA_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 当前审核状态
      /// </summary>
      private string auditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditStat_IsChanged=false;
      /// <summary>
      /// 当前审核状态
      /// </summary>
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核状态
      /// </summary>
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string aMA_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string AMA_Remark
      {
         get{ return aMA_Remark; }
         set{ aMA_Remark = value; aMA_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool AMA_Remark_IsChanged
      {
         get{ return aMA_Remark_IsChanged; }
         set{ aMA_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 申请类别
      /// </summary>
      private string aMA_ApplyType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_ApplyType_IsChanged=false;
      /// <summary>
      /// 申请类别
      /// </summary>
      public string AMA_ApplyType
      {
         get{ return aMA_ApplyType; }
         set{ aMA_ApplyType = value; aMA_ApplyType_IsChanged=true; }
      }
      /// <summary>
      /// 申请类别
      /// </summary>
      public bool AMA_ApplyType_IsChanged
      {
         get{ return aMA_ApplyType_IsChanged; }
         set{ aMA_ApplyType_IsChanged = value; }
      }
      /// <summary>
      /// 维修类别
      /// </summary>
      private string aMA_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_Type_IsChanged=false;
      /// <summary>
      /// 维修类别
      /// </summary>
      public string AMA_Type
      {
         get{ return aMA_Type; }
         set{ aMA_Type = value; aMA_Type_IsChanged=true; }
      }
      /// <summary>
      /// 维修类别
      /// </summary>
      public bool AMA_Type_IsChanged
      {
         get{ return aMA_Type_IsChanged; }
         set{ aMA_Type_IsChanged = value; }
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
      /// <summary>
      /// 维修申请编码
      /// </summary>
      private string aMA_name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aMA_name_IsChanged=false;
      /// <summary>
      /// 维修申请编码
      /// </summary>
      public string AMA_name
      {
         get{ return aMA_name; }
         set{ aMA_name = value; aMA_name_IsChanged=true; }
      }
      /// <summary>
      /// 维修申请编码
      /// </summary>
      public bool AMA_name_IsChanged
      {
         get{ return aMA_name_IsChanged; }
         set{ aMA_name_IsChanged = value; }
      }
      private string aMA_CompanyCode;
      private bool aMA_CompanyCode_IsChanged=false;
      public string AMA_CompanyCode
      {
         get{ return aMA_CompanyCode; }
         set{ aMA_CompanyCode = value; aMA_CompanyCode_IsChanged=true; }
      }
      public bool AMA_CompanyCode_IsChanged
      {
         get{ return aMA_CompanyCode_IsChanged; }
         set{ aMA_CompanyCode_IsChanged = value; }
      }
      private string aMA_DeptCode;
      private bool aMA_DeptCode_IsChanged=false;
      public string AMA_DeptCode
      {
         get{ return aMA_DeptCode; }
         set{ aMA_DeptCode = value; aMA_DeptCode_IsChanged=true; }
      }
      public bool AMA_DeptCode_IsChanged
      {
         get{ return aMA_DeptCode_IsChanged; }
         set{ aMA_DeptCode_IsChanged = value; }
      }
   }
}
