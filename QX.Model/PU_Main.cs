using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 供应商往来主表
   /// </summary>
   [Serializable]
   public partial class PU_Main
   {
      /// <summary>
      /// 采购主表ID
      /// </summary>
      private decimal pUM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_ID_IsChanged=false;
      /// <summary>
      /// 采购主表ID
      /// </summary>
      public decimal PUM_ID
      {
         get{ return pUM_ID; }
         set{ pUM_ID = value; pUM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 采购主表ID
      /// </summary>
      public bool PUM_ID_IsChanged
      {
         get{ return pUM_ID_IsChanged; }
         set{ pUM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      private string pUM_RType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_RType_IsChanged=false;
      /// <summary>
      /// 单据类型
      /// </summary>
      public string PUM_RType
      {
         get{ return pUM_RType; }
         set{ pUM_RType = value; pUM_RType_IsChanged=true; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      public bool PUM_RType_IsChanged
      {
         get{ return pUM_RType_IsChanged; }
         set{ pUM_RType_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string pUM_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_RCode_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string PUM_RCode
      {
         get{ return pUM_RCode; }
         set{ pUM_RCode = value; pUM_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool PUM_RCode_IsChanged
      {
         get{ return pUM_RCode_IsChanged; }
         set{ pUM_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 单据名称
      /// </summary>
      private string pUM_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Title_IsChanged=false;
      /// <summary>
      /// 单据名称
      /// </summary>
      public string PUM_Title
      {
         get{ return pUM_Title; }
         set{ pUM_Title = value; pUM_Title_IsChanged=true; }
      }
      /// <summary>
      /// 单据名称
      /// </summary>
      public bool PUM_Title_IsChanged
      {
         get{ return pUM_Title_IsChanged; }
         set{ pUM_Title_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string pUM_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string PUM_SCode
      {
         get{ return pUM_SCode; }
         set{ pUM_SCode = value; pUM_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool PUM_SCode_IsChanged
      {
         get{ return pUM_SCode_IsChanged; }
         set{ pUM_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string pUM_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_SName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string PUM_SName
      {
         get{ return pUM_SName; }
         set{ pUM_SName = value; pUM_SName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool PUM_SName_IsChanged
      {
         get{ return pUM_SName_IsChanged; }
         set{ pUM_SName_IsChanged = value; }
      }
      /// <summary>
      /// 供应商联系人
      /// </summary>
      private string pUM_SContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_SContact_IsChanged=false;
      /// <summary>
      /// 供应商联系人
      /// </summary>
      public string PUM_SContact
      {
         get{ return pUM_SContact; }
         set{ pUM_SContact = value; pUM_SContact_IsChanged=true; }
      }
      /// <summary>
      /// 供应商联系人
      /// </summary>
      public bool PUM_SContact_IsChanged
      {
         get{ return pUM_SContact_IsChanged; }
         set{ pUM_SContact_IsChanged = value; }
      }
      /// <summary>
      /// 供应商联系电话
      /// </summary>
      private string pUM_STel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_STel_IsChanged=false;
      /// <summary>
      /// 供应商联系电话
      /// </summary>
      public string PUM_STel
      {
         get{ return pUM_STel; }
         set{ pUM_STel = value; pUM_STel_IsChanged=true; }
      }
      /// <summary>
      /// 供应商联系电话
      /// </summary>
      public bool PUM_STel_IsChanged
      {
         get{ return pUM_STel_IsChanged; }
         set{ pUM_STel_IsChanged = value; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      private string pUM_State;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_State_IsChanged=false;
      /// <summary>
      /// 单据状态
      /// </summary>
      public string PUM_State
      {
         get{ return pUM_State; }
         set{ pUM_State = value; pUM_State_IsChanged=true; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      public bool PUM_State_IsChanged
      {
         get{ return pUM_State_IsChanged; }
         set{ pUM_State_IsChanged = value; }
      }
      /// <summary>
      /// 过账日期
      /// </summary>
      private DateTime pUM_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_PDate_IsChanged=false;
      /// <summary>
      /// 过账日期
      /// </summary>
      public DateTime PUM_PDate
      {
         get{ return pUM_PDate; }
         set{ pUM_PDate = value; pUM_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 过账日期
      /// </summary>
      public bool PUM_PDate_IsChanged
      {
         get{ return pUM_PDate_IsChanged; }
         set{ pUM_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      private DateTime pUM_IDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_IDate_IsChanged=false;
      /// <summary>
      /// 交货日期
      /// </summary>
      public DateTime PUM_IDate
      {
         get{ return pUM_IDate; }
         set{ pUM_IDate = value; pUM_IDate_IsChanged=true; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      public bool PUM_IDate_IsChanged
      {
         get{ return pUM_IDate_IsChanged; }
         set{ pUM_IDate_IsChanged = value; }
      }
      /// <summary>
      /// 单据日期
      /// </summary>
      private DateTime pUM_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_RDate_IsChanged=false;
      /// <summary>
      /// 单据日期
      /// </summary>
      public DateTime PUM_RDate
      {
         get{ return pUM_RDate; }
         set{ pUM_RDate = value; pUM_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 单据日期
      /// </summary>
      public bool PUM_RDate_IsChanged
      {
         get{ return pUM_RDate_IsChanged; }
         set{ pUM_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 单据负责人
      /// </summary>
      private string pUM_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Owner_IsChanged=false;
      /// <summary>
      /// 单据负责人
      /// </summary>
      public string PUM_Owner
      {
         get{ return pUM_Owner; }
         set{ pUM_Owner = value; pUM_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 单据负责人
      /// </summary>
      public bool PUM_Owner_IsChanged
      {
         get{ return pUM_Owner_IsChanged; }
         set{ pUM_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      private decimal pUM_Tranfee;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Tranfee_IsChanged=false;
      /// <summary>
      /// 运费
      /// </summary>
      public decimal PUM_Tranfee
      {
         get{ return pUM_Tranfee; }
         set{ pUM_Tranfee = value; pUM_Tranfee_IsChanged=true; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      public bool PUM_Tranfee_IsChanged
      {
         get{ return pUM_Tranfee_IsChanged; }
         set{ pUM_Tranfee_IsChanged = value; }
      }
      /// <summary>
      /// 折扣
      /// </summary>
      private decimal pUM_Discount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Discount_IsChanged=false;
      /// <summary>
      /// 折扣
      /// </summary>
      public decimal PUM_Discount
      {
         get{ return pUM_Discount; }
         set{ pUM_Discount = value; pUM_Discount_IsChanged=true; }
      }
      /// <summary>
      /// 折扣
      /// </summary>
      public bool PUM_Discount_IsChanged
      {
         get{ return pUM_Discount_IsChanged; }
         set{ pUM_Discount_IsChanged = value; }
      }
      /// <summary>
      /// 折扣后金额
      /// </summary>
      private decimal pUM_DisSum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_DisSum_IsChanged=false;
      /// <summary>
      /// 折扣后金额
      /// </summary>
      public decimal PUM_DisSum
      {
         get{ return pUM_DisSum; }
         set{ pUM_DisSum = value; pUM_DisSum_IsChanged=true; }
      }
      /// <summary>
      /// 折扣后金额
      /// </summary>
      public bool PUM_DisSum_IsChanged
      {
         get{ return pUM_DisSum_IsChanged; }
         set{ pUM_DisSum_IsChanged = value; }
      }
      /// <summary>
      /// 税收金额
      /// </summary>
      private decimal pUM_Tax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Tax_IsChanged=false;
      /// <summary>
      /// 税收金额
      /// </summary>
      public decimal PUM_Tax
      {
         get{ return pUM_Tax; }
         set{ pUM_Tax = value; pUM_Tax_IsChanged=true; }
      }
      /// <summary>
      /// 税收金额
      /// </summary>
      public bool PUM_Tax_IsChanged
      {
         get{ return pUM_Tax_IsChanged; }
         set{ pUM_Tax_IsChanged = value; }
      }
      /// <summary>
      /// 应付总金额
      /// </summary>
      private decimal pUM_Payable;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Payable_IsChanged=false;
      /// <summary>
      /// 应付总金额
      /// </summary>
      public decimal PUM_Payable
      {
         get{ return pUM_Payable; }
         set{ pUM_Payable = value; pUM_Payable_IsChanged=true; }
      }
      /// <summary>
      /// 应付总金额
      /// </summary>
      public bool PUM_Payable_IsChanged
      {
         get{ return pUM_Payable_IsChanged; }
         set{ pUM_Payable_IsChanged = value; }
      }
      /// <summary>
      /// 注释
      /// </summary>
      private string pUM_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Bak_IsChanged=false;
      /// <summary>
      /// 注释
      /// </summary>
      public string PUM_Bak
      {
         get{ return pUM_Bak; }
         set{ pUM_Bak = value; pUM_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 注释
      /// </summary>
      public bool PUM_Bak_IsChanged
      {
         get{ return pUM_Bak_IsChanged; }
         set{ pUM_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      private string pUM_BOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_BOwner_IsChanged=false;
      /// <summary>
      /// 业务负责人
      /// </summary>
      public string PUM_BOwner
      {
         get{ return pUM_BOwner; }
         set{ pUM_BOwner = value; pUM_BOwner_IsChanged=true; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      public bool PUM_BOwner_IsChanged
      {
         get{ return pUM_BOwner_IsChanged; }
         set{ pUM_BOwner_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      private string pUM_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_RefType_IsChanged=false;
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public string PUM_RefType
      {
         get{ return pUM_RefType; }
         set{ pUM_RefType = value; pUM_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public bool PUM_RefType_IsChanged
      {
         get{ return pUM_RefType_IsChanged; }
         set{ pUM_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      private string pUM_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_RefCode_IsChanged=false;
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public string PUM_RefCode
      {
         get{ return pUM_RefCode; }
         set{ pUM_RefCode = value; pUM_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public bool PUM_RefCode_IsChanged
      {
         get{ return pUM_RefCode_IsChanged; }
         set{ pUM_RefCode_IsChanged = value; }
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
      /// 当前审核节点
      /// </summary>
      private string auditCurAudit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditCurAudit_IsChanged=false;
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      private string pUM_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Company_IsChanged=false;
      /// <summary>
      /// 使用公司
      /// </summary>
      public string PUM_Company
      {
         get{ return pUM_Company; }
         set{ pUM_Company = value; pUM_Company_IsChanged=true; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      public bool PUM_Company_IsChanged
      {
         get{ return pUM_Company_IsChanged; }
         set{ pUM_Company_IsChanged = value; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      private string pUM_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_Dept_IsChanged=false;
      /// <summary>
      /// 使用部门
      /// </summary>
      public string PUM_Dept
      {
         get{ return pUM_Dept; }
         set{ pUM_Dept = value; pUM_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      public bool PUM_Dept_IsChanged
      {
         get{ return pUM_Dept_IsChanged; }
         set{ pUM_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string pUM_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_User_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string PUM_User
      {
         get{ return pUM_User; }
         set{ pUM_User = value; pUM_User_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool PUM_User_IsChanged
      {
         get{ return pUM_User_IsChanged; }
         set{ pUM_User_IsChanged = value; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      private string pUM_UseType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUM_UseType_IsChanged=false;
      /// <summary>
      /// 使用类型
      /// </summary>
      public string PUM_UseType
      {
         get{ return pUM_UseType; }
         set{ pUM_UseType = value; pUM_UseType_IsChanged=true; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      public bool PUM_UseType_IsChanged
      {
         get{ return pUM_UseType_IsChanged; }
         set{ pUM_UseType_IsChanged = value; }
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
      private string pUM_CompanyCode;
      private bool pUM_CompanyCode_IsChanged=false;
      public string PUM_CompanyCode
      {
         get{ return pUM_CompanyCode; }
         set{ pUM_CompanyCode = value; pUM_CompanyCode_IsChanged=true; }
      }
      public bool PUM_CompanyCode_IsChanged
      {
         get{ return pUM_CompanyCode_IsChanged; }
         set{ pUM_CompanyCode_IsChanged = value; }
      }
      private string pUM_DeptCode;
      private bool pUM_DeptCode_IsChanged=false;
      public string PUM_DeptCode
      {
         get{ return pUM_DeptCode; }
         set{ pUM_DeptCode = value; pUM_DeptCode_IsChanged=true; }
      }
      public bool PUM_DeptCode_IsChanged
      {
         get{ return pUM_DeptCode_IsChanged; }
         set{ pUM_DeptCode_IsChanged = value; }
      }
      private string pUM_Type;
      private bool pUM_Type_IsChanged=false;
      public string PUM_Type
      {
         get{ return pUM_Type; }
         set{ pUM_Type = value; pUM_Type_IsChanged=true; }
      }
      public bool PUM_Type_IsChanged
      {
         get{ return pUM_Type_IsChanged; }
         set{ pUM_Type_IsChanged = value; }
      }
      private string pUM_Operator;
      private bool pUM_Operator_IsChanged=false;
      public string PUM_Operator
      {
         get{ return pUM_Operator; }
         set{ pUM_Operator = value; pUM_Operator_IsChanged=true; }
      }
      public bool PUM_Operator_IsChanged
      {
         get{ return pUM_Operator_IsChanged; }
         set{ pUM_Operator_IsChanged = value; }
      }
      private string pUM_OCode;
      private bool pUM_OCode_IsChanged=false;
      public string PUM_OCode
      {
         get{ return pUM_OCode; }
         set{ pUM_OCode = value; pUM_OCode_IsChanged=true; }
      }
      public bool PUM_OCode_IsChanged
      {
         get{ return pUM_OCode_IsChanged; }
         set{ pUM_OCode_IsChanged = value; }
      }
      private DateTime pUM_OpDate;
      private bool pUM_OpDate_IsChanged=false;
      public DateTime PUM_OpDate
      {
         get{ return pUM_OpDate; }
         set{ pUM_OpDate = value; pUM_OpDate_IsChanged=true; }
      }
      public bool PUM_OpDate_IsChanged
      {
         get{ return pUM_OpDate_IsChanged; }
         set{ pUM_OpDate_IsChanged = value; }
      }
      private string pUM_UDEF1;
      private bool pUM_UDEF1_IsChanged=false;
      public string PUM_UDEF1
      {
         get{ return pUM_UDEF1; }
         set{ pUM_UDEF1 = value; pUM_UDEF1_IsChanged=true; }
      }
      public bool PUM_UDEF1_IsChanged
      {
         get{ return pUM_UDEF1_IsChanged; }
         set{ pUM_UDEF1_IsChanged = value; }
      }
      private string pUM_UDEF2;
      private bool pUM_UDEF2_IsChanged=false;
      public string PUM_UDEF2
      {
         get{ return pUM_UDEF2; }
         set{ pUM_UDEF2 = value; pUM_UDEF2_IsChanged=true; }
      }
      public bool PUM_UDEF2_IsChanged
      {
         get{ return pUM_UDEF2_IsChanged; }
         set{ pUM_UDEF2_IsChanged = value; }
      }
      private string pUM_UDEF3;
      private bool pUM_UDEF3_IsChanged=false;
      public string PUM_UDEF3
      {
         get{ return pUM_UDEF3; }
         set{ pUM_UDEF3 = value; pUM_UDEF3_IsChanged=true; }
      }
      public bool PUM_UDEF3_IsChanged
      {
         get{ return pUM_UDEF3_IsChanged; }
         set{ pUM_UDEF3_IsChanged = value; }
      }
      private string pUM_UDEF4;
      private bool pUM_UDEF4_IsChanged=false;
      public string PUM_UDEF4
      {
         get{ return pUM_UDEF4; }
         set{ pUM_UDEF4 = value; pUM_UDEF4_IsChanged=true; }
      }
      public bool PUM_UDEF4_IsChanged
      {
         get{ return pUM_UDEF4_IsChanged; }
         set{ pUM_UDEF4_IsChanged = value; }
      }
      private string pUM_UDEF5;
      private bool pUM_UDEF5_IsChanged=false;
      public string PUM_UDEF5
      {
         get{ return pUM_UDEF5; }
         set{ pUM_UDEF5 = value; pUM_UDEF5_IsChanged=true; }
      }
      public bool PUM_UDEF5_IsChanged
      {
         get{ return pUM_UDEF5_IsChanged; }
         set{ pUM_UDEF5_IsChanged = value; }
      }
      private string pUM_UDEF6;
      private bool pUM_UDEF6_IsChanged=false;
      public string PUM_UDEF6
      {
         get{ return pUM_UDEF6; }
         set{ pUM_UDEF6 = value; pUM_UDEF6_IsChanged=true; }
      }
      public bool PUM_UDEF6_IsChanged
      {
         get{ return pUM_UDEF6_IsChanged; }
         set{ pUM_UDEF6_IsChanged = value; }
      }
      private string pUM_UDEF7;
      private bool pUM_UDEF7_IsChanged=false;
      public string PUM_UDEF7
      {
         get{ return pUM_UDEF7; }
         set{ pUM_UDEF7 = value; pUM_UDEF7_IsChanged=true; }
      }
      public bool PUM_UDEF7_IsChanged
      {
         get{ return pUM_UDEF7_IsChanged; }
         set{ pUM_UDEF7_IsChanged = value; }
      }
      private string pUM_UDEF8;
      private bool pUM_UDEF8_IsChanged=false;
      public string PUM_UDEF8
      {
         get{ return pUM_UDEF8; }
         set{ pUM_UDEF8 = value; pUM_UDEF8_IsChanged=true; }
      }
      public bool PUM_UDEF8_IsChanged
      {
         get{ return pUM_UDEF8_IsChanged; }
         set{ pUM_UDEF8_IsChanged = value; }
      }
      private string pUM_UDEF9;
      private bool pUM_UDEF9_IsChanged=false;
      public string PUM_UDEF9
      {
         get{ return pUM_UDEF9; }
         set{ pUM_UDEF9 = value; pUM_UDEF9_IsChanged=true; }
      }
      public bool PUM_UDEF9_IsChanged
      {
         get{ return pUM_UDEF9_IsChanged; }
         set{ pUM_UDEF9_IsChanged = value; }
      }
      private string pUM_UDEF10;
      private bool pUM_UDEF10_IsChanged=false;
      public string PUM_UDEF10
      {
         get{ return pUM_UDEF10; }
         set{ pUM_UDEF10 = value; pUM_UDEF10_IsChanged=true; }
      }
      public bool PUM_UDEF10_IsChanged
      {
         get{ return pUM_UDEF10_IsChanged; }
         set{ pUM_UDEF10_IsChanged = value; }
      }
      private string pUM_OwnerCode;
      private bool pUM_OwnerCode_IsChanged=false;
      public string PUM_OwnerCode
      {
         get{ return pUM_OwnerCode; }
         set{ pUM_OwnerCode = value; pUM_OwnerCode_IsChanged=true; }
      }
      public bool PUM_OwnerCode_IsChanged
      {
         get{ return pUM_OwnerCode_IsChanged; }
         set{ pUM_OwnerCode_IsChanged = value; }
      }
   }
}
