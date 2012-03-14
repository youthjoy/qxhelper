using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 销售合同基本信息
   /// </summary>
   [Serializable]
   public partial class SD_Contract
   {
      /// <summary>
      /// 合同基本信息序号
      /// </summary>
      private decimal sDC_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_ID_IsChanged=false;
      /// <summary>
      /// 合同基本信息序号
      /// </summary>
      public decimal SDC_ID
      {
         get{ return sDC_ID; }
         set{ sDC_ID = value; sDC_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同基本信息序号
      /// </summary>
      public bool SDC_ID_IsChanged
      {
         get{ return sDC_ID_IsChanged; }
         set{ sDC_ID_IsChanged = value; }
      }
      /// <summary>
      /// 合同类别
      /// </summary>
      private string sDC_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_iType_IsChanged=false;
      /// <summary>
      /// 合同类别
      /// </summary>
      public string SDC_iType
      {
         get{ return sDC_iType; }
         set{ sDC_iType = value; sDC_iType_IsChanged=true; }
      }
      /// <summary>
      /// 合同类别
      /// </summary>
      public bool SDC_iType_IsChanged
      {
         get{ return sDC_iType_IsChanged; }
         set{ sDC_iType_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string sDC_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Code_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string SDC_Code
      {
         get{ return sDC_Code; }
         set{ sDC_Code = value; sDC_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool SDC_Code_IsChanged
      {
         get{ return sDC_Code_IsChanged; }
         set{ sDC_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string sDC_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_CName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string SDC_CName
      {
         get{ return sDC_CName; }
         set{ sDC_CName = value; sDC_CName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool SDC_CName_IsChanged
      {
         get{ return sDC_CName_IsChanged; }
         set{ sDC_CName_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDC_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDC_CCode
      {
         get{ return sDC_CCode; }
         set{ sDC_CCode = value; sDC_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDC_CCode_IsChanged
      {
         get{ return sDC_CCode_IsChanged; }
         set{ sDC_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 签约时间
      /// </summary>
      private DateTime sDC_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Date_IsChanged=false;
      /// <summary>
      /// 签约时间
      /// </summary>
      public DateTime SDC_Date
      {
         get{ return sDC_Date; }
         set{ sDC_Date = value; sDC_Date_IsChanged=true; }
      }
      /// <summary>
      /// 签约时间
      /// </summary>
      public bool SDC_Date_IsChanged
      {
         get{ return sDC_Date_IsChanged; }
         set{ sDC_Date_IsChanged = value; }
      }
      /// <summary>
      /// 签约地点
      /// </summary>
      private string sDC_Place;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Place_IsChanged=false;
      /// <summary>
      /// 签约地点
      /// </summary>
      public string SDC_Place
      {
         get{ return sDC_Place; }
         set{ sDC_Place = value; sDC_Place_IsChanged=true; }
      }
      /// <summary>
      /// 签约地点
      /// </summary>
      public bool SDC_Place_IsChanged
      {
         get{ return sDC_Place_IsChanged; }
         set{ sDC_Place_IsChanged = value; }
      }
      /// <summary>
      /// 签约人编码
      /// </summary>
      private string sC_OwnerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sC_OwnerCode_IsChanged=false;
      /// <summary>
      /// 签约人编码
      /// </summary>
      public string SC_OwnerCode
      {
         get{ return sC_OwnerCode; }
         set{ sC_OwnerCode = value; sC_OwnerCode_IsChanged=true; }
      }
      /// <summary>
      /// 签约人编码
      /// </summary>
      public bool SC_OwnerCode_IsChanged
      {
         get{ return sC_OwnerCode_IsChanged; }
         set{ sC_OwnerCode_IsChanged = value; }
      }
      /// <summary>
      /// 签约人
      /// </summary>
      private string sDC_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Owner_IsChanged=false;
      /// <summary>
      /// 签约人
      /// </summary>
      public string SDC_Owner
      {
         get{ return sDC_Owner; }
         set{ sDC_Owner = value; sDC_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 签约人
      /// </summary>
      public bool SDC_Owner_IsChanged
      {
         get{ return sDC_Owner_IsChanged; }
         set{ sDC_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 签约公司
      /// </summary>
      private string sDC_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Dept_IsChanged=false;
      /// <summary>
      /// 签约公司
      /// </summary>
      public string SDC_Dept
      {
         get{ return sDC_Dept; }
         set{ sDC_Dept = value; sDC_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 签约公司
      /// </summary>
      public bool SDC_Dept_IsChanged
      {
         get{ return sDC_Dept_IsChanged; }
         set{ sDC_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 合同开始时间
      /// </summary>
      private DateTime sDC_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Start_IsChanged=false;
      /// <summary>
      /// 合同开始时间
      /// </summary>
      public DateTime SDC_Start
      {
         get{ return sDC_Start; }
         set{ sDC_Start = value; sDC_Start_IsChanged=true; }
      }
      /// <summary>
      /// 合同开始时间
      /// </summary>
      public bool SDC_Start_IsChanged
      {
         get{ return sDC_Start_IsChanged; }
         set{ sDC_Start_IsChanged = value; }
      }
      /// <summary>
      /// 合同结束时间
      /// </summary>
      private DateTime sDC_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_End_IsChanged=false;
      /// <summary>
      /// 合同结束时间
      /// </summary>
      public DateTime SDC_End
      {
         get{ return sDC_End; }
         set{ sDC_End = value; sDC_End_IsChanged=true; }
      }
      /// <summary>
      /// 合同结束时间
      /// </summary>
      public bool SDC_End_IsChanged
      {
         get{ return sDC_End_IsChanged; }
         set{ sDC_End_IsChanged = value; }
      }
      /// <summary>
      /// 合同执行人编码
      /// </summary>
      private string sDC_EOwnerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_EOwnerCode_IsChanged=false;
      /// <summary>
      /// 合同执行人编码
      /// </summary>
      public string SDC_EOwnerCode
      {
         get{ return sDC_EOwnerCode; }
         set{ sDC_EOwnerCode = value; sDC_EOwnerCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同执行人编码
      /// </summary>
      public bool SDC_EOwnerCode_IsChanged
      {
         get{ return sDC_EOwnerCode_IsChanged; }
         set{ sDC_EOwnerCode_IsChanged = value; }
      }
      /// <summary>
      /// 合同执行人
      /// </summary>
      private string sDC_EOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_EOwner_IsChanged=false;
      /// <summary>
      /// 合同执行人
      /// </summary>
      public string SDC_EOwner
      {
         get{ return sDC_EOwner; }
         set{ sDC_EOwner = value; sDC_EOwner_IsChanged=true; }
      }
      /// <summary>
      /// 合同执行人
      /// </summary>
      public bool SDC_EOwner_IsChanged
      {
         get{ return sDC_EOwner_IsChanged; }
         set{ sDC_EOwner_IsChanged = value; }
      }
      /// <summary>
      /// 合同方量
      /// </summary>
      private int sDC_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Num_IsChanged=false;
      /// <summary>
      /// 合同方量
      /// </summary>
      public int SDC_Num
      {
         get{ return sDC_Num; }
         set{ sDC_Num = value; sDC_Num_IsChanged=true; }
      }
      /// <summary>
      /// 合同方量
      /// </summary>
      public bool SDC_Num_IsChanged
      {
         get{ return sDC_Num_IsChanged; }
         set{ sDC_Num_IsChanged = value; }
      }
      /// <summary>
      /// 技术提供方
      /// </summary>
      private string sDC_TechDecision;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_TechDecision_IsChanged=false;
      /// <summary>
      /// 技术提供方
      /// </summary>
      public string SDC_TechDecision
      {
         get{ return sDC_TechDecision; }
         set{ sDC_TechDecision = value; sDC_TechDecision_IsChanged=true; }
      }
      /// <summary>
      /// 技术提供方
      /// </summary>
      public bool SDC_TechDecision_IsChanged
      {
         get{ return sDC_TechDecision_IsChanged; }
         set{ sDC_TechDecision_IsChanged = value; }
      }
      /// <summary>
      /// 技术关联编码
      /// </summary>
      private string sDC_TechCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_TechCode_IsChanged=false;
      /// <summary>
      /// 技术关联编码
      /// </summary>
      public string SDC_TechCode
      {
         get{ return sDC_TechCode; }
         set{ sDC_TechCode = value; sDC_TechCode_IsChanged=true; }
      }
      /// <summary>
      /// 技术关联编码
      /// </summary>
      public bool SDC_TechCode_IsChanged
      {
         get{ return sDC_TechCode_IsChanged; }
         set{ sDC_TechCode_IsChanged = value; }
      }
      /// <summary>
      /// 结算方式
      /// </summary>
      private string sDC_PayContent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_PayContent_IsChanged=false;
      /// <summary>
      /// 结算方式
      /// </summary>
      public string SDC_PayContent
      {
         get{ return sDC_PayContent; }
         set{ sDC_PayContent = value; sDC_PayContent_IsChanged=true; }
      }
      /// <summary>
      /// 结算方式
      /// </summary>
      public bool SDC_PayContent_IsChanged
      {
         get{ return sDC_PayContent_IsChanged; }
         set{ sDC_PayContent_IsChanged = value; }
      }
      /// <summary>
      /// 合同单位负责人
      /// </summary>
      private string sDC_COwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_COwner_IsChanged=false;
      /// <summary>
      /// 合同单位负责人
      /// </summary>
      public string SDC_COwner
      {
         get{ return sDC_COwner; }
         set{ sDC_COwner = value; sDC_COwner_IsChanged=true; }
      }
      /// <summary>
      /// 合同单位负责人
      /// </summary>
      public bool SDC_COwner_IsChanged
      {
         get{ return sDC_COwner_IsChanged; }
         set{ sDC_COwner_IsChanged = value; }
      }
      /// <summary>
      /// 合同单位联系方式
      /// </summary>
      private string sDC_CContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_CContact_IsChanged=false;
      /// <summary>
      /// 合同单位联系方式
      /// </summary>
      public string SDC_CContact
      {
         get{ return sDC_CContact; }
         set{ sDC_CContact = value; sDC_CContact_IsChanged=true; }
      }
      /// <summary>
      /// 合同单位联系方式
      /// </summary>
      public bool SDC_CContact_IsChanged
      {
         get{ return sDC_CContact_IsChanged; }
         set{ sDC_CContact_IsChanged = value; }
      }
      /// <summary>
      /// 合同范围
      /// </summary>
      private string sDC_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Content_IsChanged=false;
      /// <summary>
      /// 合同范围
      /// </summary>
      public string SDC_Content
      {
         get{ return sDC_Content; }
         set{ sDC_Content = value; sDC_Content_IsChanged=true; }
      }
      /// <summary>
      /// 合同范围
      /// </summary>
      public bool SDC_Content_IsChanged
      {
         get{ return sDC_Content_IsChanged; }
         set{ sDC_Content_IsChanged = value; }
      }
      /// <summary>
      /// 工程情况
      /// </summary>
      private string sDC_Description;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Description_IsChanged=false;
      /// <summary>
      /// 工程情况
      /// </summary>
      public string SDC_Description
      {
         get{ return sDC_Description; }
         set{ sDC_Description = value; sDC_Description_IsChanged=true; }
      }
      /// <summary>
      /// 工程情况
      /// </summary>
      public bool SDC_Description_IsChanged
      {
         get{ return sDC_Description_IsChanged; }
         set{ sDC_Description_IsChanged = value; }
      }
      /// <summary>
      /// 信控方式
      /// </summary>
      private string sDC_Control;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Control_IsChanged=false;
      /// <summary>
      /// 信控方式
      /// </summary>
      public string SDC_Control
      {
         get{ return sDC_Control; }
         set{ sDC_Control = value; sDC_Control_IsChanged=true; }
      }
      /// <summary>
      /// 信控方式
      /// </summary>
      public bool SDC_Control_IsChanged
      {
         get{ return sDC_Control_IsChanged; }
         set{ sDC_Control_IsChanged = value; }
      }
      /// <summary>
      /// 是否甲供
      /// </summary>
      private string sDC_IsAFor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_IsAFor_IsChanged=false;
      /// <summary>
      /// 是否甲供
      /// </summary>
      public string SDC_IsAFor
      {
         get{ return sDC_IsAFor; }
         set{ sDC_IsAFor = value; sDC_IsAFor_IsChanged=true; }
      }
      /// <summary>
      /// 是否甲供
      /// </summary>
      public bool SDC_IsAFor_IsChanged
      {
         get{ return sDC_IsAFor_IsChanged; }
         set{ sDC_IsAFor_IsChanged = value; }
      }
      private string audit1CurAudit;
      private bool audit1CurAudit_IsChanged=false;
      public string Audit1CurAudit
      {
         get{ return audit1CurAudit; }
         set{ audit1CurAudit = value; audit1CurAudit_IsChanged=true; }
      }
      public bool Audit1CurAudit_IsChanged
      {
         get{ return audit1CurAudit_IsChanged; }
         set{ audit1CurAudit_IsChanged = value; }
      }
      /// <summary>
      /// 技术评审状态
      /// </summary>
      private string audit1Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool audit1Stat_IsChanged=false;
      /// <summary>
      /// 技术评审状态
      /// </summary>
      public string Audit1Stat
      {
         get{ return audit1Stat; }
         set{ audit1Stat = value; audit1Stat_IsChanged=true; }
      }
      /// <summary>
      /// 技术评审状态
      /// </summary>
      public bool Audit1Stat_IsChanged
      {
         get{ return audit1Stat_IsChanged; }
         set{ audit1Stat_IsChanged = value; }
      }
      private DateTime audit1Date;
      private bool audit1Date_IsChanged=false;
      public DateTime Audit1Date
      {
         get{ return audit1Date; }
         set{ audit1Date = value; audit1Date_IsChanged=true; }
      }
      public bool Audit1Date_IsChanged
      {
         get{ return audit1Date_IsChanged; }
         set{ audit1Date_IsChanged = value; }
      }
      private string audit1Owner;
      private bool audit1Owner_IsChanged=false;
      public string Audit1Owner
      {
         get{ return audit1Owner; }
         set{ audit1Owner = value; audit1Owner_IsChanged=true; }
      }
      public bool Audit1Owner_IsChanged
      {
         get{ return audit1Owner_IsChanged; }
         set{ audit1Owner_IsChanged = value; }
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
      /// 技术评审状态
      /// </summary>
      private string auditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditStat_IsChanged=false;
      /// <summary>
      /// 技术评审状态
      /// </summary>
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      /// <summary>
      /// 技术评审状态
      /// </summary>
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private DateTime auditDate;
      private bool auditDate_IsChanged=false;
      public DateTime AuditDate
      {
         get{ return auditDate; }
         set{ auditDate = value; auditDate_IsChanged=true; }
      }
      public bool AuditDate_IsChanged
      {
         get{ return auditDate_IsChanged; }
         set{ auditDate_IsChanged = value; }
      }
      private string auditOwner;
      private bool auditOwner_IsChanged=false;
      public string AuditOwner
      {
         get{ return auditOwner; }
         set{ auditOwner = value; auditOwner_IsChanged=true; }
      }
      public bool AuditOwner_IsChanged
      {
         get{ return auditOwner_IsChanged; }
         set{ auditOwner_IsChanged = value; }
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
      private string createOwner;
      private bool createOwner_IsChanged=false;
      public string CreateOwner
      {
         get{ return createOwner; }
         set{ createOwner = value; createOwner_IsChanged=true; }
      }
      public bool CreateOwner_IsChanged
      {
         get{ return createOwner_IsChanged; }
         set{ createOwner_IsChanged = value; }
      }
      private string sDC_Stat;
      private bool sDC_Stat_IsChanged=false;
      public string SDC_Stat
      {
         get{ return sDC_Stat; }
         set{ sDC_Stat = value; sDC_Stat_IsChanged=true; }
      }
      public bool SDC_Stat_IsChanged
      {
         get{ return sDC_Stat_IsChanged; }
         set{ sDC_Stat_IsChanged = value; }
      }
      private string sDC_Type;
      private bool sDC_Type_IsChanged=false;
      public string SDC_Type
      {
         get{ return sDC_Type; }
         set{ sDC_Type = value; sDC_Type_IsChanged=true; }
      }
      public bool SDC_Type_IsChanged
      {
         get{ return sDC_Type_IsChanged; }
         set{ sDC_Type_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string sDC_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string SDC_Company
      {
         get{ return sDC_Company; }
         set{ sDC_Company = value; sDC_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool SDC_Company_IsChanged
      {
         get{ return sDC_Company_IsChanged; }
         set{ sDC_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string sDC_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_CompanyCode_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string SDC_CompanyCode
      {
         get{ return sDC_CompanyCode; }
         set{ sDC_CompanyCode = value; sDC_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool SDC_CompanyCode_IsChanged
      {
         get{ return sDC_CompanyCode_IsChanged; }
         set{ sDC_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 累计发货方量
      /// </summary>
      private string sDC_TotalSend;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_TotalSend_IsChanged=false;
      /// <summary>
      /// 累计发货方量
      /// </summary>
      public string SDC_TotalSend
      {
         get{ return sDC_TotalSend; }
         set{ sDC_TotalSend = value; sDC_TotalSend_IsChanged=true; }
      }
      /// <summary>
      /// 累计发货方量
      /// </summary>
      public bool SDC_TotalSend_IsChanged
      {
         get{ return sDC_TotalSend_IsChanged; }
         set{ sDC_TotalSend_IsChanged = value; }
      }
      /// <summary>
      /// 最后一车方量
      /// </summary>
      private string sDC_LastSend;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_LastSend_IsChanged=false;
      /// <summary>
      /// 最后一车方量
      /// </summary>
      public string SDC_LastSend
      {
         get{ return sDC_LastSend; }
         set{ sDC_LastSend = value; sDC_LastSend_IsChanged=true; }
      }
      /// <summary>
      /// 最后一车方量
      /// </summary>
      public bool SDC_LastSend_IsChanged
      {
         get{ return sDC_LastSend_IsChanged; }
         set{ sDC_LastSend_IsChanged = value; }
      }
      /// <summary>
      /// 最后一车时间
      /// </summary>
      private DateTime sDC_LastDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_LastDate_IsChanged=false;
      /// <summary>
      /// 最后一车时间
      /// </summary>
      public DateTime SDC_LastDate
      {
         get{ return sDC_LastDate; }
         set{ sDC_LastDate = value; sDC_LastDate_IsChanged=true; }
      }
      /// <summary>
      /// 最后一车时间
      /// </summary>
      public bool SDC_LastDate_IsChanged
      {
         get{ return sDC_LastDate_IsChanged; }
         set{ sDC_LastDate_IsChanged = value; }
      }
      /// <summary>
      /// 累计退货方量
      /// </summary>
      private string sDC_Return;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_Return_IsChanged=false;
      /// <summary>
      /// 累计退货方量
      /// </summary>
      public string SDC_Return
      {
         get{ return sDC_Return; }
         set{ sDC_Return = value; sDC_Return_IsChanged=true; }
      }
      /// <summary>
      /// 累计退货方量
      /// </summary>
      public bool SDC_Return_IsChanged
      {
         get{ return sDC_Return_IsChanged; }
         set{ sDC_Return_IsChanged = value; }
      }
      /// <summary>
      /// 供货起时
      /// </summary>
      private DateTime sDC_StartSend;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_StartSend_IsChanged=false;
      /// <summary>
      /// 供货起时
      /// </summary>
      public DateTime SDC_StartSend
      {
         get{ return sDC_StartSend; }
         set{ sDC_StartSend = value; sDC_StartSend_IsChanged=true; }
      }
      /// <summary>
      /// 供货起时
      /// </summary>
      public bool SDC_StartSend_IsChanged
      {
         get{ return sDC_StartSend_IsChanged; }
         set{ sDC_StartSend_IsChanged = value; }
      }
      /// <summary>
      /// 供货止时
      /// </summary>
      private DateTime sDC_EndSend;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_EndSend_IsChanged=false;
      /// <summary>
      /// 供货止时
      /// </summary>
      public DateTime SDC_EndSend
      {
         get{ return sDC_EndSend; }
         set{ sDC_EndSend = value; sDC_EndSend_IsChanged=true; }
      }
      /// <summary>
      /// 供货止时
      /// </summary>
      public bool SDC_EndSend_IsChanged
      {
         get{ return sDC_EndSend_IsChanged; }
         set{ sDC_EndSend_IsChanged = value; }
      }
      /// <summary>
      /// 供货累计时间
      /// </summary>
      private string sDC_TotalDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_TotalDate_IsChanged=false;
      /// <summary>
      /// 供货累计时间
      /// </summary>
      public string SDC_TotalDate
      {
         get{ return sDC_TotalDate; }
         set{ sDC_TotalDate = value; sDC_TotalDate_IsChanged=true; }
      }
      /// <summary>
      /// 供货累计时间
      /// </summary>
      public bool SDC_TotalDate_IsChanged
      {
         get{ return sDC_TotalDate_IsChanged; }
         set{ sDC_TotalDate_IsChanged = value; }
      }
      /// <summary>
      /// 合同约定方量
      /// </summary>
      private string sDC_AgreeQuantity;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_AgreeQuantity_IsChanged=false;
      /// <summary>
      /// 合同约定方量
      /// </summary>
      public string SDC_AgreeQuantity
      {
         get{ return sDC_AgreeQuantity; }
         set{ sDC_AgreeQuantity = value; sDC_AgreeQuantity_IsChanged=true; }
      }
      /// <summary>
      /// 合同约定方量
      /// </summary>
      public bool SDC_AgreeQuantity_IsChanged
      {
         get{ return sDC_AgreeQuantity_IsChanged; }
         set{ sDC_AgreeQuantity_IsChanged = value; }
      }
      /// <summary>
      /// 计划方量
      /// </summary>
      private string sDC_PlanQuantity;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_PlanQuantity_IsChanged=false;
      /// <summary>
      /// 计划方量
      /// </summary>
      public string SDC_PlanQuantity
      {
         get{ return sDC_PlanQuantity; }
         set{ sDC_PlanQuantity = value; sDC_PlanQuantity_IsChanged=true; }
      }
      /// <summary>
      /// 计划方量
      /// </summary>
      public bool SDC_PlanQuantity_IsChanged
      {
         get{ return sDC_PlanQuantity_IsChanged; }
         set{ sDC_PlanQuantity_IsChanged = value; }
      }
      /// <summary>
      /// 实际供应量
      /// </summary>
      private string sDC_SupQuantity;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_SupQuantity_IsChanged=false;
      /// <summary>
      /// 实际供应量
      /// </summary>
      public string SDC_SupQuantity
      {
         get{ return sDC_SupQuantity; }
         set{ sDC_SupQuantity = value; sDC_SupQuantity_IsChanged=true; }
      }
      /// <summary>
      /// 实际供应量
      /// </summary>
      public bool SDC_SupQuantity_IsChanged
      {
         get{ return sDC_SupQuantity_IsChanged; }
         set{ sDC_SupQuantity_IsChanged = value; }
      }
      /// <summary>
      /// 累计货款金额
      /// </summary>
      private decimal sDC_TotalMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_TotalMoney_IsChanged=false;
      /// <summary>
      /// 累计货款金额
      /// </summary>
      public decimal SDC_TotalMoney
      {
         get{ return sDC_TotalMoney; }
         set{ sDC_TotalMoney = value; sDC_TotalMoney_IsChanged=true; }
      }
      /// <summary>
      /// 累计货款金额
      /// </summary>
      public bool SDC_TotalMoney_IsChanged
      {
         get{ return sDC_TotalMoney_IsChanged; }
         set{ sDC_TotalMoney_IsChanged = value; }
      }
      /// <summary>
      /// 累计付款金额
      /// </summary>
      private decimal sDC_PayMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_PayMoney_IsChanged=false;
      /// <summary>
      /// 累计付款金额
      /// </summary>
      public decimal SDC_PayMoney
      {
         get{ return sDC_PayMoney; }
         set{ sDC_PayMoney = value; sDC_PayMoney_IsChanged=true; }
      }
      /// <summary>
      /// 累计付款金额
      /// </summary>
      public bool SDC_PayMoney_IsChanged
      {
         get{ return sDC_PayMoney_IsChanged; }
         set{ sDC_PayMoney_IsChanged = value; }
      }
      /// <summary>
      /// 累计应付金额
      /// </summary>
      private decimal sDC_SPayMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDC_SPayMoney_IsChanged=false;
      /// <summary>
      /// 累计应付金额
      /// </summary>
      public decimal SDC_SPayMoney
      {
         get{ return sDC_SPayMoney; }
         set{ sDC_SPayMoney = value; sDC_SPayMoney_IsChanged=true; }
      }
      /// <summary>
      /// 累计应付金额
      /// </summary>
      public bool SDC_SPayMoney_IsChanged
      {
         get{ return sDC_SPayMoney_IsChanged; }
         set{ sDC_SPayMoney_IsChanged = value; }
      }
      private string sDC_PayType;
      private bool sDC_PayType_IsChanged=false;
      public string SDC_PayType
      {
         get{ return sDC_PayType; }
         set{ sDC_PayType = value; sDC_PayType_IsChanged=true; }
      }
      public bool SDC_PayType_IsChanged
      {
         get{ return sDC_PayType_IsChanged; }
         set{ sDC_PayType_IsChanged = value; }
      }
      private string sDC_BType;
      private bool sDC_BType_IsChanged=false;
      public string SDC_BType
      {
         get{ return sDC_BType; }
         set{ sDC_BType = value; sDC_BType_IsChanged=true; }
      }
      public bool SDC_BType_IsChanged
      {
         get{ return sDC_BType_IsChanged; }
         set{ sDC_BType_IsChanged = value; }
      }
      private string sDC_BTypeName;
      private bool sDC_BTypeName_IsChanged=false;
      public string SDC_BTypeName
      {
         get{ return sDC_BTypeName; }
         set{ sDC_BTypeName = value; sDC_BTypeName_IsChanged=true; }
      }
      public bool SDC_BTypeName_IsChanged
      {
         get{ return sDC_BTypeName_IsChanged; }
         set{ sDC_BTypeName_IsChanged = value; }
      }
   }
}
