using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 固定资产流程
   /// </summary>
   [Serializable]
   public partial class Asset_Process
   {
      /// <summary>
      /// 固定资产流程ID
      /// </summary>
      private decimal aP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_ID_IsChanged=false;
      /// <summary>
      /// 固定资产流程ID
      /// </summary>
      public decimal AP_ID
      {
         get{ return aP_ID; }
         set{ aP_ID = value; aP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产流程ID
      /// </summary>
      public bool AP_ID_IsChanged
      {
         get{ return aP_ID_IsChanged; }
         set{ aP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产流程编码
      /// </summary>
      private string aP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Code_IsChanged=false;
      /// <summary>
      /// 固定资产流程编码
      /// </summary>
      public string AP_Code
      {
         get{ return aP_Code; }
         set{ aP_Code = value; aP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产流程编码
      /// </summary>
      public bool AP_Code_IsChanged
      {
         get{ return aP_Code_IsChanged; }
         set{ aP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      private string aP_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Type_IsChanged=false;
      /// <summary>
      /// 单据类型
      /// </summary>
      public string AP_Type
      {
         get{ return aP_Type; }
         set{ aP_Type = value; aP_Type_IsChanged=true; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      public bool AP_Type_IsChanged
      {
         get{ return aP_Type_IsChanged; }
         set{ aP_Type_IsChanged = value; }
      }
      /// <summary>
      /// 申请名称
      /// </summary>
      private string aP_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Title_IsChanged=false;
      /// <summary>
      /// 申请名称
      /// </summary>
      public string AP_Title
      {
         get{ return aP_Title; }
         set{ aP_Title = value; aP_Title_IsChanged=true; }
      }
      /// <summary>
      /// 申请名称
      /// </summary>
      public bool AP_Title_IsChanged
      {
         get{ return aP_Title_IsChanged; }
         set{ aP_Title_IsChanged = value; }
      }
      /// <summary>
      /// 申请所属公司
      /// </summary>
      private string aP_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Company_IsChanged=false;
      /// <summary>
      /// 申请所属公司
      /// </summary>
      public string AP_Company
      {
         get{ return aP_Company; }
         set{ aP_Company = value; aP_Company_IsChanged=true; }
      }
      /// <summary>
      /// 申请所属公司
      /// </summary>
      public bool AP_Company_IsChanged
      {
         get{ return aP_Company_IsChanged; }
         set{ aP_Company_IsChanged = value; }
      }
      private string aP_CompanyCode;
      private bool aP_CompanyCode_IsChanged=false;
      public string AP_CompanyCode
      {
         get{ return aP_CompanyCode; }
         set{ aP_CompanyCode = value; aP_CompanyCode_IsChanged=true; }
      }
      public bool AP_CompanyCode_IsChanged
      {
         get{ return aP_CompanyCode_IsChanged; }
         set{ aP_CompanyCode_IsChanged = value; }
      }
      private string aP_DepartmentCode;
      private bool aP_DepartmentCode_IsChanged=false;
      public string AP_DepartmentCode
      {
         get{ return aP_DepartmentCode; }
         set{ aP_DepartmentCode = value; aP_DepartmentCode_IsChanged=true; }
      }
      public bool AP_DepartmentCode_IsChanged
      {
         get{ return aP_DepartmentCode_IsChanged; }
         set{ aP_DepartmentCode_IsChanged = value; }
      }
      /// <summary>
      /// 申请所属部门
      /// </summary>
      private string aP_Department;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Department_IsChanged=false;
      /// <summary>
      /// 申请所属部门
      /// </summary>
      public string AP_Department
      {
         get{ return aP_Department; }
         set{ aP_Department = value; aP_Department_IsChanged=true; }
      }
      /// <summary>
      /// 申请所属部门
      /// </summary>
      public bool AP_Department_IsChanged
      {
         get{ return aP_Department_IsChanged; }
         set{ aP_Department_IsChanged = value; }
      }
      /// <summary>
      /// 申请人
      /// </summary>
      private string aP_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Owner_IsChanged=false;
      /// <summary>
      /// 申请人
      /// </summary>
      public string AP_Owner
      {
         get{ return aP_Owner; }
         set{ aP_Owner = value; aP_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 申请人
      /// </summary>
      public bool AP_Owner_IsChanged
      {
         get{ return aP_Owner_IsChanged; }
         set{ aP_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 申请内容
      /// </summary>
      private string aP_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Content_IsChanged=false;
      /// <summary>
      /// 申请内容
      /// </summary>
      public string AP_Content
      {
         get{ return aP_Content; }
         set{ aP_Content = value; aP_Content_IsChanged=true; }
      }
      /// <summary>
      /// 申请内容
      /// </summary>
      public bool AP_Content_IsChanged
      {
         get{ return aP_Content_IsChanged; }
         set{ aP_Content_IsChanged = value; }
      }
      /// <summary>
      /// 关联固定资产编码
      /// </summary>
      private string aP_FCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_FCode_IsChanged=false;
      /// <summary>
      /// 关联固定资产编码
      /// </summary>
      public string AP_FCode
      {
         get{ return aP_FCode; }
         set{ aP_FCode = value; aP_FCode_IsChanged=true; }
      }
      /// <summary>
      /// 关联固定资产编码
      /// </summary>
      public bool AP_FCode_IsChanged
      {
         get{ return aP_FCode_IsChanged; }
         set{ aP_FCode_IsChanged = value; }
      }
      /// <summary>
      /// 关联固定资产名称
      /// </summary>
      private string aP_FName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_FName_IsChanged=false;
      /// <summary>
      /// 关联固定资产名称
      /// </summary>
      public string AP_FName
      {
         get{ return aP_FName; }
         set{ aP_FName = value; aP_FName_IsChanged=true; }
      }
      /// <summary>
      /// 关联固定资产名称
      /// </summary>
      public bool AP_FName_IsChanged
      {
         get{ return aP_FName_IsChanged; }
         set{ aP_FName_IsChanged = value; }
      }
      /// <summary>
      /// 申请原因
      /// </summary>
      private string aP_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Reason_IsChanged=false;
      /// <summary>
      /// 申请原因
      /// </summary>
      public string AP_Reason
      {
         get{ return aP_Reason; }
         set{ aP_Reason = value; aP_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 申请原因
      /// </summary>
      public bool AP_Reason_IsChanged
      {
         get{ return aP_Reason_IsChanged; }
         set{ aP_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 处理结果
      /// </summary>
      private string aP_Conclusion;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aP_Conclusion_IsChanged=false;
      /// <summary>
      /// 处理结果
      /// </summary>
      public string AP_Conclusion
      {
         get{ return aP_Conclusion; }
         set{ aP_Conclusion = value; aP_Conclusion_IsChanged=true; }
      }
      /// <summary>
      /// 处理结果
      /// </summary>
      public bool AP_Conclusion_IsChanged
      {
         get{ return aP_Conclusion_IsChanged; }
         set{ aP_Conclusion_IsChanged = value; }
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
      /// 下一步节点
      /// </summary>
      private string auditCurAudit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditCurAudit_IsChanged=false;
      /// <summary>
      /// 下一步节点
      /// </summary>
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      /// <summary>
      /// 下一步节点
      /// </summary>
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
      private string aP_itype;
      private bool aP_itype_IsChanged=false;
      public string AP_itype
      {
         get{ return aP_itype; }
         set{ aP_itype = value; aP_itype_IsChanged=true; }
      }
      public bool AP_itype_IsChanged
      {
         get{ return aP_itype_IsChanged; }
         set{ aP_itype_IsChanged = value; }
      }
      private string auditStatName;
      private bool auditStatName_IsChanged=false;
      public string AuditStatName
      {
         get{ return auditStatName; }
         set{ auditStatName = value; auditStatName_IsChanged=true; }
      }
      public bool AuditStatName_IsChanged
      {
         get{ return auditStatName_IsChanged; }
         set{ auditStatName_IsChanged = value; }
      }
      private string aP_Status;
      private bool aP_Status_IsChanged=false;
      public string AP_Status
      {
         get{ return aP_Status; }
         set{ aP_Status = value; aP_Status_IsChanged=true; }
      }
      public bool AP_Status_IsChanged
      {
         get{ return aP_Status_IsChanged; }
         set{ aP_Status_IsChanged = value; }
      }
      private string aP_SCode;
      private bool aP_SCode_IsChanged=false;
      public string AP_SCode
      {
         get{ return aP_SCode; }
         set{ aP_SCode = value; aP_SCode_IsChanged=true; }
      }
      public bool AP_SCode_IsChanged
      {
         get{ return aP_SCode_IsChanged; }
         set{ aP_SCode_IsChanged = value; }
      }
      private string aP_SName;
      private bool aP_SName_IsChanged=false;
      public string AP_SName
      {
         get{ return aP_SName; }
         set{ aP_SName = value; aP_SName_IsChanged=true; }
      }
      public bool AP_SName_IsChanged
      {
         get{ return aP_SName_IsChanged; }
         set{ aP_SName_IsChanged = value; }
      }
      private string aP_Contact;
      private bool aP_Contact_IsChanged=false;
      public string AP_Contact
      {
         get{ return aP_Contact; }
         set{ aP_Contact = value; aP_Contact_IsChanged=true; }
      }
      public bool AP_Contact_IsChanged
      {
         get{ return aP_Contact_IsChanged; }
         set{ aP_Contact_IsChanged = value; }
      }
      private string aP_Mobile;
      private bool aP_Mobile_IsChanged=false;
      public string AP_Mobile
      {
         get{ return aP_Mobile; }
         set{ aP_Mobile = value; aP_Mobile_IsChanged=true; }
      }
      public bool AP_Mobile_IsChanged
      {
         get{ return aP_Mobile_IsChanged; }
         set{ aP_Mobile_IsChanged = value; }
      }
   }
}
