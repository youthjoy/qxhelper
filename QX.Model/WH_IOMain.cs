using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料出库主表
   /// </summary>
   [Serializable]
   public partial class WH_IOMain
   {
      /// <summary>
      /// 出库单ID
      /// </summary>
      private decimal wHIOM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_ID_IsChanged=false;
      /// <summary>
      /// 出库单ID
      /// </summary>
      public decimal WHIOM_ID
      {
         get{ return wHIOM_ID; }
         set{ wHIOM_ID = value; wHIOM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 出库单ID
      /// </summary>
      public bool WHIOM_ID_IsChanged
      {
         get{ return wHIOM_ID_IsChanged; }
         set{ wHIOM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 出库单类型
      /// </summary>
      private string wHIOM_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Type_IsChanged=false;
      /// <summary>
      /// 出库单类型
      /// </summary>
      public string WHIOM_Type
      {
         get{ return wHIOM_Type; }
         set{ wHIOM_Type = value; wHIOM_Type_IsChanged=true; }
      }
      /// <summary>
      /// 出库单类型
      /// </summary>
      public bool WHIOM_Type_IsChanged
      {
         get{ return wHIOM_Type_IsChanged; }
         set{ wHIOM_Type_IsChanged = value; }
      }
      /// <summary>
      /// 出库单编码
      /// </summary>
      private string wHIOM_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Code_IsChanged=false;
      /// <summary>
      /// 出库单编码
      /// </summary>
      public string WHIOM_Code
      {
         get{ return wHIOM_Code; }
         set{ wHIOM_Code = value; wHIOM_Code_IsChanged=true; }
      }
      /// <summary>
      /// 出库单编码
      /// </summary>
      public bool WHIOM_Code_IsChanged
      {
         get{ return wHIOM_Code_IsChanged; }
         set{ wHIOM_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单据名称
      /// </summary>
      private string wHIOM_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Title_IsChanged=false;
      /// <summary>
      /// 单据名称
      /// </summary>
      public string WHIOM_Title
      {
         get{ return wHIOM_Title; }
         set{ wHIOM_Title = value; wHIOM_Title_IsChanged=true; }
      }
      /// <summary>
      /// 单据名称
      /// </summary>
      public bool WHIOM_Title_IsChanged
      {
         get{ return wHIOM_Title_IsChanged; }
         set{ wHIOM_Title_IsChanged = value; }
      }
      private string wHIOM_CompanyCode;
      private bool wHIOM_CompanyCode_IsChanged=false;
      public string WHIOM_CompanyCode
      {
         get{ return wHIOM_CompanyCode; }
         set{ wHIOM_CompanyCode = value; wHIOM_CompanyCode_IsChanged=true; }
      }
      public bool WHIOM_CompanyCode_IsChanged
      {
         get{ return wHIOM_CompanyCode_IsChanged; }
         set{ wHIOM_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string wHIOM_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string WHIOM_Company
      {
         get{ return wHIOM_Company; }
         set{ wHIOM_Company = value; wHIOM_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool WHIOM_Company_IsChanged
      {
         get{ return wHIOM_Company_IsChanged; }
         set{ wHIOM_Company_IsChanged = value; }
      }
      private string wHIOM_DepartmentCode;
      private bool wHIOM_DepartmentCode_IsChanged=false;
      public string WHIOM_DepartmentCode
      {
         get{ return wHIOM_DepartmentCode; }
         set{ wHIOM_DepartmentCode = value; wHIOM_DepartmentCode_IsChanged=true; }
      }
      public bool WHIOM_DepartmentCode_IsChanged
      {
         get{ return wHIOM_DepartmentCode_IsChanged; }
         set{ wHIOM_DepartmentCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string wHIOM_Department;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Department_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string WHIOM_Department
      {
         get{ return wHIOM_Department; }
         set{ wHIOM_Department = value; wHIOM_Department_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool WHIOM_Department_IsChanged
      {
         get{ return wHIOM_Department_IsChanged; }
         set{ wHIOM_Department_IsChanged = value; }
      }
      /// <summary>
      /// 申请领用人
      /// </summary>
      private string wHIOM_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Owner_IsChanged=false;
      /// <summary>
      /// 申请领用人
      /// </summary>
      public string WHIOM_Owner
      {
         get{ return wHIOM_Owner; }
         set{ wHIOM_Owner = value; wHIOM_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 申请领用人
      /// </summary>
      public bool WHIOM_Owner_IsChanged
      {
         get{ return wHIOM_Owner_IsChanged; }
         set{ wHIOM_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      private string wHIOM_State;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_State_IsChanged=false;
      /// <summary>
      /// 单据状态
      /// </summary>
      public string WHIOM_State
      {
         get{ return wHIOM_State; }
         set{ wHIOM_State = value; wHIOM_State_IsChanged=true; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      public bool WHIOM_State_IsChanged
      {
         get{ return wHIOM_State_IsChanged; }
         set{ wHIOM_State_IsChanged = value; }
      }
      /// <summary>
      /// 过账日期
      /// </summary>
      private DateTime wHIOM_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_PDate_IsChanged=false;
      /// <summary>
      /// 过账日期
      /// </summary>
      public DateTime WHIOM_PDate
      {
         get{ return wHIOM_PDate; }
         set{ wHIOM_PDate = value; wHIOM_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 过账日期
      /// </summary>
      public bool WHIOM_PDate_IsChanged
      {
         get{ return wHIOM_PDate_IsChanged; }
         set{ wHIOM_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      private DateTime wHIOM_IDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_IDate_IsChanged=false;
      /// <summary>
      /// 交货日期
      /// </summary>
      public DateTime WHIOM_IDate
      {
         get{ return wHIOM_IDate; }
         set{ wHIOM_IDate = value; wHIOM_IDate_IsChanged=true; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      public bool WHIOM_IDate_IsChanged
      {
         get{ return wHIOM_IDate_IsChanged; }
         set{ wHIOM_IDate_IsChanged = value; }
      }
      /// <summary>
      /// 单据日期
      /// </summary>
      private DateTime wHIOM_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_RDate_IsChanged=false;
      /// <summary>
      /// 单据日期
      /// </summary>
      public DateTime WHIOM_RDate
      {
         get{ return wHIOM_RDate; }
         set{ wHIOM_RDate = value; wHIOM_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 单据日期
      /// </summary>
      public bool WHIOM_RDate_IsChanged
      {
         get{ return wHIOM_RDate_IsChanged; }
         set{ wHIOM_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 库管员
      /// </summary>
      private string wHIOM_WOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_WOwner_IsChanged=false;
      /// <summary>
      /// 库管员
      /// </summary>
      public string WHIOM_WOwner
      {
         get{ return wHIOM_WOwner; }
         set{ wHIOM_WOwner = value; wHIOM_WOwner_IsChanged=true; }
      }
      /// <summary>
      /// 库管员
      /// </summary>
      public bool WHIOM_WOwner_IsChanged
      {
         get{ return wHIOM_WOwner_IsChanged; }
         set{ wHIOM_WOwner_IsChanged = value; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      private string wHIOM_BOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_BOwner_IsChanged=false;
      /// <summary>
      /// 业务负责人
      /// </summary>
      public string WHIOM_BOwner
      {
         get{ return wHIOM_BOwner; }
         set{ wHIOM_BOwner = value; wHIOM_BOwner_IsChanged=true; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      public bool WHIOM_BOwner_IsChanged
      {
         get{ return wHIOM_BOwner_IsChanged; }
         set{ wHIOM_BOwner_IsChanged = value; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      private decimal wHIOM_TranFee;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_TranFee_IsChanged=false;
      /// <summary>
      /// 运费
      /// </summary>
      public decimal WHIOM_TranFee
      {
         get{ return wHIOM_TranFee; }
         set{ wHIOM_TranFee = value; wHIOM_TranFee_IsChanged=true; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      public bool WHIOM_TranFee_IsChanged
      {
         get{ return wHIOM_TranFee_IsChanged; }
         set{ wHIOM_TranFee_IsChanged = value; }
      }
      /// <summary>
      /// 折扣率
      /// </summary>
      private decimal wHIOM_DisCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_DisCount_IsChanged=false;
      /// <summary>
      /// 折扣率
      /// </summary>
      public decimal WHIOM_DisCount
      {
         get{ return wHIOM_DisCount; }
         set{ wHIOM_DisCount = value; wHIOM_DisCount_IsChanged=true; }
      }
      /// <summary>
      /// 折扣率
      /// </summary>
      public bool WHIOM_DisCount_IsChanged
      {
         get{ return wHIOM_DisCount_IsChanged; }
         set{ wHIOM_DisCount_IsChanged = value; }
      }
      /// <summary>
      /// 折扣金额
      /// </summary>
      private decimal wHIOM_DisSum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_DisSum_IsChanged=false;
      /// <summary>
      /// 折扣金额
      /// </summary>
      public decimal WHIOM_DisSum
      {
         get{ return wHIOM_DisSum; }
         set{ wHIOM_DisSum = value; wHIOM_DisSum_IsChanged=true; }
      }
      /// <summary>
      /// 折扣金额
      /// </summary>
      public bool WHIOM_DisSum_IsChanged
      {
         get{ return wHIOM_DisSum_IsChanged; }
         set{ wHIOM_DisSum_IsChanged = value; }
      }
      /// <summary>
      /// 税收金额
      /// </summary>
      private decimal wHIOM_Tax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Tax_IsChanged=false;
      /// <summary>
      /// 税收金额
      /// </summary>
      public decimal WHIOM_Tax
      {
         get{ return wHIOM_Tax; }
         set{ wHIOM_Tax = value; wHIOM_Tax_IsChanged=true; }
      }
      /// <summary>
      /// 税收金额
      /// </summary>
      public bool WHIOM_Tax_IsChanged
      {
         get{ return wHIOM_Tax_IsChanged; }
         set{ wHIOM_Tax_IsChanged = value; }
      }
      /// <summary>
      /// 单据金额
      /// </summary>
      private decimal wHIOM_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Sum_IsChanged=false;
      /// <summary>
      /// 单据金额
      /// </summary>
      public decimal WHIOM_Sum
      {
         get{ return wHIOM_Sum; }
         set{ wHIOM_Sum = value; wHIOM_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 单据金额
      /// </summary>
      public bool WHIOM_Sum_IsChanged
      {
         get{ return wHIOM_Sum_IsChanged; }
         set{ wHIOM_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 项目标示
      /// </summary>
      private string wHIOM_Project;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_Project_IsChanged=false;
      /// <summary>
      /// 项目标示
      /// </summary>
      public string WHIOM_Project
      {
         get{ return wHIOM_Project; }
         set{ wHIOM_Project = value; wHIOM_Project_IsChanged=true; }
      }
      /// <summary>
      /// 项目标示
      /// </summary>
      public bool WHIOM_Project_IsChanged
      {
         get{ return wHIOM_Project_IsChanged; }
         set{ wHIOM_Project_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据类型
      /// </summary>
      private string wHIOM_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_RefType_IsChanged=false;
      /// <summary>
      /// 关联单据类型
      /// </summary>
      public string WHIOM_RefType
      {
         get{ return wHIOM_RefType; }
         set{ wHIOM_RefType = value; wHIOM_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据类型
      /// </summary>
      public bool WHIOM_RefType_IsChanged
      {
         get{ return wHIOM_RefType_IsChanged; }
         set{ wHIOM_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据编码
      /// </summary>
      private string wHIOM_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOM_RefCode_IsChanged=false;
      /// <summary>
      /// 关联单据编码
      /// </summary>
      public string WHIOM_RefCode
      {
         get{ return wHIOM_RefCode; }
         set{ wHIOM_RefCode = value; wHIOM_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据编码
      /// </summary>
      public bool WHIOM_RefCode_IsChanged
      {
         get{ return wHIOM_RefCode_IsChanged; }
         set{ wHIOM_RefCode_IsChanged = value; }
      }
      private string wHIOM_Bak;
      private bool wHIOM_Bak_IsChanged=false;
      public string WHIOM_Bak
      {
         get{ return wHIOM_Bak; }
         set{ wHIOM_Bak = value; wHIOM_Bak_IsChanged=true; }
      }
      public bool WHIOM_Bak_IsChanged
      {
         get{ return wHIOM_Bak_IsChanged; }
         set{ wHIOM_Bak_IsChanged = value; }
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
      private string wHIOM_IType;
      private bool wHIOM_IType_IsChanged=false;
      public string WHIOM_IType
      {
         get{ return wHIOM_IType; }
         set{ wHIOM_IType = value; wHIOM_IType_IsChanged=true; }
      }
      public bool WHIOM_IType_IsChanged
      {
         get{ return wHIOM_IType_IsChanged; }
         set{ wHIOM_IType_IsChanged = value; }
      }
      private string wHIOM_UDEF1;
      private bool wHIOM_UDEF1_IsChanged=false;
      public string WHIOM_UDEF1
      {
         get{ return wHIOM_UDEF1; }
         set{ wHIOM_UDEF1 = value; wHIOM_UDEF1_IsChanged=true; }
      }
      public bool WHIOM_UDEF1_IsChanged
      {
         get{ return wHIOM_UDEF1_IsChanged; }
         set{ wHIOM_UDEF1_IsChanged = value; }
      }
      private string wHIOM_UDEF2;
      private bool wHIOM_UDEF2_IsChanged=false;
      public string WHIOM_UDEF2
      {
         get{ return wHIOM_UDEF2; }
         set{ wHIOM_UDEF2 = value; wHIOM_UDEF2_IsChanged=true; }
      }
      public bool WHIOM_UDEF2_IsChanged
      {
         get{ return wHIOM_UDEF2_IsChanged; }
         set{ wHIOM_UDEF2_IsChanged = value; }
      }
      private string wHIOM_UDEF3;
      private bool wHIOM_UDEF3_IsChanged=false;
      public string WHIOM_UDEF3
      {
         get{ return wHIOM_UDEF3; }
         set{ wHIOM_UDEF3 = value; wHIOM_UDEF3_IsChanged=true; }
      }
      public bool WHIOM_UDEF3_IsChanged
      {
         get{ return wHIOM_UDEF3_IsChanged; }
         set{ wHIOM_UDEF3_IsChanged = value; }
      }
      private string wHIOM_UDEF4;
      private bool wHIOM_UDEF4_IsChanged=false;
      public string WHIOM_UDEF4
      {
         get{ return wHIOM_UDEF4; }
         set{ wHIOM_UDEF4 = value; wHIOM_UDEF4_IsChanged=true; }
      }
      public bool WHIOM_UDEF4_IsChanged
      {
         get{ return wHIOM_UDEF4_IsChanged; }
         set{ wHIOM_UDEF4_IsChanged = value; }
      }
      private string wHIOM_UDEF5;
      private bool wHIOM_UDEF5_IsChanged=false;
      public string WHIOM_UDEF5
      {
         get{ return wHIOM_UDEF5; }
         set{ wHIOM_UDEF5 = value; wHIOM_UDEF5_IsChanged=true; }
      }
      public bool WHIOM_UDEF5_IsChanged
      {
         get{ return wHIOM_UDEF5_IsChanged; }
         set{ wHIOM_UDEF5_IsChanged = value; }
      }
      private string wHIOM_UDEF6;
      private bool wHIOM_UDEF6_IsChanged=false;
      public string WHIOM_UDEF6
      {
         get{ return wHIOM_UDEF6; }
         set{ wHIOM_UDEF6 = value; wHIOM_UDEF6_IsChanged=true; }
      }
      public bool WHIOM_UDEF6_IsChanged
      {
         get{ return wHIOM_UDEF6_IsChanged; }
         set{ wHIOM_UDEF6_IsChanged = value; }
      }
      private string wHIOM_UDEF7;
      private bool wHIOM_UDEF7_IsChanged=false;
      public string WHIOM_UDEF7
      {
         get{ return wHIOM_UDEF7; }
         set{ wHIOM_UDEF7 = value; wHIOM_UDEF7_IsChanged=true; }
      }
      public bool WHIOM_UDEF7_IsChanged
      {
         get{ return wHIOM_UDEF7_IsChanged; }
         set{ wHIOM_UDEF7_IsChanged = value; }
      }
      private string wHIOM_UDEF8;
      private bool wHIOM_UDEF8_IsChanged=false;
      public string WHIOM_UDEF8
      {
         get{ return wHIOM_UDEF8; }
         set{ wHIOM_UDEF8 = value; wHIOM_UDEF8_IsChanged=true; }
      }
      public bool WHIOM_UDEF8_IsChanged
      {
         get{ return wHIOM_UDEF8_IsChanged; }
         set{ wHIOM_UDEF8_IsChanged = value; }
      }
      private string wHIOM_UDEF9;
      private bool wHIOM_UDEF9_IsChanged=false;
      public string WHIOM_UDEF9
      {
         get{ return wHIOM_UDEF9; }
         set{ wHIOM_UDEF9 = value; wHIOM_UDEF9_IsChanged=true; }
      }
      public bool WHIOM_UDEF9_IsChanged
      {
         get{ return wHIOM_UDEF9_IsChanged; }
         set{ wHIOM_UDEF9_IsChanged = value; }
      }
      private string wHIOM_UDEF10;
      private bool wHIOM_UDEF10_IsChanged=false;
      public string WHIOM_UDEF10
      {
         get{ return wHIOM_UDEF10; }
         set{ wHIOM_UDEF10 = value; wHIOM_UDEF10_IsChanged=true; }
      }
      public bool WHIOM_UDEF10_IsChanged
      {
         get{ return wHIOM_UDEF10_IsChanged; }
         set{ wHIOM_UDEF10_IsChanged = value; }
      }
      private string wHIOM_Operator;
      private bool wHIOM_Operator_IsChanged=false;
      public string WHIOM_Operator
      {
         get{ return wHIOM_Operator; }
         set{ wHIOM_Operator = value; wHIOM_Operator_IsChanged=true; }
      }
      public bool WHIOM_Operator_IsChanged
      {
         get{ return wHIOM_Operator_IsChanged; }
         set{ wHIOM_Operator_IsChanged = value; }
      }
      private string wHIOM_OCode;
      private bool wHIOM_OCode_IsChanged=false;
      public string WHIOM_OCode
      {
         get{ return wHIOM_OCode; }
         set{ wHIOM_OCode = value; wHIOM_OCode_IsChanged=true; }
      }
      public bool WHIOM_OCode_IsChanged
      {
         get{ return wHIOM_OCode_IsChanged; }
         set{ wHIOM_OCode_IsChanged = value; }
      }
      private DateTime wHIOM_OpDate;
      private bool wHIOM_OpDate_IsChanged=false;
      public DateTime WHIOM_OpDate
      {
         get{ return wHIOM_OpDate; }
         set{ wHIOM_OpDate = value; wHIOM_OpDate_IsChanged=true; }
      }
      public bool WHIOM_OpDate_IsChanged
      {
         get{ return wHIOM_OpDate_IsChanged; }
         set{ wHIOM_OpDate_IsChanged = value; }
      }
      private string wHIOM_OwnerCode;
      private bool wHIOM_OwnerCode_IsChanged=false;
      public string WHIOM_OwnerCode
      {
         get{ return wHIOM_OwnerCode; }
         set{ wHIOM_OwnerCode = value; wHIOM_OwnerCode_IsChanged=true; }
      }
      public bool WHIOM_OwnerCode_IsChanged
      {
         get{ return wHIOM_OwnerCode_IsChanged; }
         set{ wHIOM_OwnerCode_IsChanged = value; }
      }
   }
}
