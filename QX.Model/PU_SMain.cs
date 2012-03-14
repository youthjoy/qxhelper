using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PU_SMain
   {
      /// <summary>
      /// 单据序号
      /// </summary>
      private decimal pUS_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_ID_IsChanged=false;
      /// <summary>
      /// 单据序号
      /// </summary>
      public decimal PUS_ID
      {
         get{ return pUS_ID; }
         set{ pUS_ID = value; pUS_ID_IsChanged=true; }
      }
      /// <summary>
      /// 单据序号
      /// </summary>
      public bool PUS_ID_IsChanged
      {
         get{ return pUS_ID_IsChanged; }
         set{ pUS_ID_IsChanged = value; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      private string pUS_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Type_IsChanged=false;
      /// <summary>
      /// 单据类型
      /// </summary>
      public string PUS_Type
      {
         get{ return pUS_Type; }
         set{ pUS_Type = value; pUS_Type_IsChanged=true; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      public bool PUS_Type_IsChanged
      {
         get{ return pUS_Type_IsChanged; }
         set{ pUS_Type_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string pUS_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_RCode_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string PUS_RCode
      {
         get{ return pUS_RCode; }
         set{ pUS_RCode = value; pUS_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool PUS_RCode_IsChanged
      {
         get{ return pUS_RCode_IsChanged; }
         set{ pUS_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string pUS_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string PUS_Company
      {
         get{ return pUS_Company; }
         set{ pUS_Company = value; pUS_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool PUS_Company_IsChanged
      {
         get{ return pUS_Company_IsChanged; }
         set{ pUS_Company_IsChanged = value; }
      }
      private string pUS_CompanyName;
      private bool pUS_CompanyName_IsChanged=false;
      public string PUS_CompanyName
      {
         get{ return pUS_CompanyName; }
         set{ pUS_CompanyName = value; pUS_CompanyName_IsChanged=true; }
      }
      public bool PUS_CompanyName_IsChanged
      {
         get{ return pUS_CompanyName_IsChanged; }
         set{ pUS_CompanyName_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string pUS_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string PUS_Dept
      {
         get{ return pUS_Dept; }
         set{ pUS_Dept = value; pUS_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool PUS_Dept_IsChanged
      {
         get{ return pUS_Dept_IsChanged; }
         set{ pUS_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string pUS_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string PUS_MCode
      {
         get{ return pUS_MCode; }
         set{ pUS_MCode = value; pUS_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool PUS_MCode_IsChanged
      {
         get{ return pUS_MCode_IsChanged; }
         set{ pUS_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string pUS_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string PUS_MName
      {
         get{ return pUS_MName; }
         set{ pUS_MName = value; pUS_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool PUS_MName_IsChanged
      {
         get{ return pUS_MName_IsChanged; }
         set{ pUS_MName_IsChanged = value; }
      }
      /// <summary>
      /// 申请人
      /// </summary>
      private string pUS_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Owner_IsChanged=false;
      /// <summary>
      /// 申请人
      /// </summary>
      public string PUS_Owner
      {
         get{ return pUS_Owner; }
         set{ pUS_Owner = value; pUS_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 申请人
      /// </summary>
      public bool PUS_Owner_IsChanged
      {
         get{ return pUS_Owner_IsChanged; }
         set{ pUS_Owner_IsChanged = value; }
      }
      private decimal pUS_Num;
      private bool pUS_Num_IsChanged=false;
      public decimal PUS_Num
      {
         get{ return pUS_Num; }
         set{ pUS_Num = value; pUS_Num_IsChanged=true; }
      }
      public bool PUS_Num_IsChanged
      {
         get{ return pUS_Num_IsChanged; }
         set{ pUS_Num_IsChanged = value; }
      }
      private string pUS_Unit;
      private bool pUS_Unit_IsChanged=false;
      public string PUS_Unit
      {
         get{ return pUS_Unit; }
         set{ pUS_Unit = value; pUS_Unit_IsChanged=true; }
      }
      public bool PUS_Unit_IsChanged
      {
         get{ return pUS_Unit_IsChanged; }
         set{ pUS_Unit_IsChanged = value; }
      }
      private string pUS_Units;
      private bool pUS_Units_IsChanged=false;
      public string PUS_Units
      {
         get{ return pUS_Units; }
         set{ pUS_Units = value; pUS_Units_IsChanged=true; }
      }
      public bool PUS_Units_IsChanged
      {
         get{ return pUS_Units_IsChanged; }
         set{ pUS_Units_IsChanged = value; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      private string pUS_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Stat_IsChanged=false;
      /// <summary>
      /// 单据状态
      /// </summary>
      public string PUS_Stat
      {
         get{ return pUS_Stat; }
         set{ pUS_Stat = value; pUS_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      public bool PUS_Stat_IsChanged
      {
         get{ return pUS_Stat_IsChanged; }
         set{ pUS_Stat_IsChanged = value; }
      }
      private string pUS_Spec;
      private bool pUS_Spec_IsChanged=false;
      public string PUS_Spec
      {
         get{ return pUS_Spec; }
         set{ pUS_Spec = value; pUS_Spec_IsChanged=true; }
      }
      public bool PUS_Spec_IsChanged
      {
         get{ return pUS_Spec_IsChanged; }
         set{ pUS_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 过账日期
      /// </summary>
      private DateTime pUS_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_PDate_IsChanged=false;
      /// <summary>
      /// 过账日期
      /// </summary>
      public DateTime PUS_PDate
      {
         get{ return pUS_PDate; }
         set{ pUS_PDate = value; pUS_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 过账日期
      /// </summary>
      public bool PUS_PDate_IsChanged
      {
         get{ return pUS_PDate_IsChanged; }
         set{ pUS_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      private DateTime pUS_IDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_IDate_IsChanged=false;
      /// <summary>
      /// 交货日期
      /// </summary>
      public DateTime PUS_IDate
      {
         get{ return pUS_IDate; }
         set{ pUS_IDate = value; pUS_IDate_IsChanged=true; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      public bool PUS_IDate_IsChanged
      {
         get{ return pUS_IDate_IsChanged; }
         set{ pUS_IDate_IsChanged = value; }
      }
      /// <summary>
      /// 单据日期
      /// </summary>
      private DateTime pUS_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_RDate_IsChanged=false;
      /// <summary>
      /// 单据日期
      /// </summary>
      public DateTime PUS_RDate
      {
         get{ return pUS_RDate; }
         set{ pUS_RDate = value; pUS_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 单据日期
      /// </summary>
      public bool PUS_RDate_IsChanged
      {
         get{ return pUS_RDate_IsChanged; }
         set{ pUS_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 库管员
      /// </summary>
      private string pUS_WOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_WOwner_IsChanged=false;
      /// <summary>
      /// 库管员
      /// </summary>
      public string PUS_WOwner
      {
         get{ return pUS_WOwner; }
         set{ pUS_WOwner = value; pUS_WOwner_IsChanged=true; }
      }
      /// <summary>
      /// 库管员
      /// </summary>
      public bool PUS_WOwner_IsChanged
      {
         get{ return pUS_WOwner_IsChanged; }
         set{ pUS_WOwner_IsChanged = value; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      private string pUS_BOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_BOwner_IsChanged=false;
      /// <summary>
      /// 业务负责人
      /// </summary>
      public string PUS_BOwner
      {
         get{ return pUS_BOwner; }
         set{ pUS_BOwner = value; pUS_BOwner_IsChanged=true; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      public bool PUS_BOwner_IsChanged
      {
         get{ return pUS_BOwner_IsChanged; }
         set{ pUS_BOwner_IsChanged = value; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      private decimal pUS_TranFee;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_TranFee_IsChanged=false;
      /// <summary>
      /// 运费
      /// </summary>
      public decimal PUS_TranFee
      {
         get{ return pUS_TranFee; }
         set{ pUS_TranFee = value; pUS_TranFee_IsChanged=true; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      public bool PUS_TranFee_IsChanged
      {
         get{ return pUS_TranFee_IsChanged; }
         set{ pUS_TranFee_IsChanged = value; }
      }
      private decimal pUS_Price;
      private bool pUS_Price_IsChanged=false;
      public decimal PUS_Price
      {
         get{ return pUS_Price; }
         set{ pUS_Price = value; pUS_Price_IsChanged=true; }
      }
      public bool PUS_Price_IsChanged
      {
         get{ return pUS_Price_IsChanged; }
         set{ pUS_Price_IsChanged = value; }
      }
      /// <summary>
      /// 单据金额
      /// </summary>
      private decimal pUS_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Sum_IsChanged=false;
      /// <summary>
      /// 单据金额
      /// </summary>
      public decimal PUS_Sum
      {
         get{ return pUS_Sum; }
         set{ pUS_Sum = value; pUS_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 单据金额
      /// </summary>
      public bool PUS_Sum_IsChanged
      {
         get{ return pUS_Sum_IsChanged; }
         set{ pUS_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据类型
      /// </summary>
      private string pUS_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_RefType_IsChanged=false;
      /// <summary>
      /// 关联单据类型
      /// </summary>
      public string PUS_RefType
      {
         get{ return pUS_RefType; }
         set{ pUS_RefType = value; pUS_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据类型
      /// </summary>
      public bool PUS_RefType_IsChanged
      {
         get{ return pUS_RefType_IsChanged; }
         set{ pUS_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据编码
      /// </summary>
      private string pUS_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_RefCode_IsChanged=false;
      /// <summary>
      /// 关联单据编码
      /// </summary>
      public string PUS_RefCode
      {
         get{ return pUS_RefCode; }
         set{ pUS_RefCode = value; pUS_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据编码
      /// </summary>
      public bool PUS_RefCode_IsChanged
      {
         get{ return pUS_RefCode_IsChanged; }
         set{ pUS_RefCode_IsChanged = value; }
      }
      private string pUS_SupType;
      private bool pUS_SupType_IsChanged=false;
      public string PUS_SupType
      {
         get{ return pUS_SupType; }
         set{ pUS_SupType = value; pUS_SupType_IsChanged=true; }
      }
      public bool PUS_SupType_IsChanged
      {
         get{ return pUS_SupType_IsChanged; }
         set{ pUS_SupType_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项1
      /// </summary>
      private string pUS_UDef1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_UDef1_IsChanged=false;
      /// <summary>
      /// 自定义项1
      /// </summary>
      public string PUS_UDef1
      {
         get{ return pUS_UDef1; }
         set{ pUS_UDef1 = value; pUS_UDef1_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项1
      /// </summary>
      public bool PUS_UDef1_IsChanged
      {
         get{ return pUS_UDef1_IsChanged; }
         set{ pUS_UDef1_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项2
      /// </summary>
      private string pUS_UDef2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_UDef2_IsChanged=false;
      /// <summary>
      /// 自定义项2
      /// </summary>
      public string PUS_UDef2
      {
         get{ return pUS_UDef2; }
         set{ pUS_UDef2 = value; pUS_UDef2_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项2
      /// </summary>
      public bool PUS_UDef2_IsChanged
      {
         get{ return pUS_UDef2_IsChanged; }
         set{ pUS_UDef2_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项3
      /// </summary>
      private string pUS_UDef3;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_UDef3_IsChanged=false;
      /// <summary>
      /// 自定义项3
      /// </summary>
      public string PUS_UDef3
      {
         get{ return pUS_UDef3; }
         set{ pUS_UDef3 = value; pUS_UDef3_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项3
      /// </summary>
      public bool PUS_UDef3_IsChanged
      {
         get{ return pUS_UDef3_IsChanged; }
         set{ pUS_UDef3_IsChanged = value; }
      }
      private string pUS_UDef4;
      private bool pUS_UDef4_IsChanged=false;
      public string PUS_UDef4
      {
         get{ return pUS_UDef4; }
         set{ pUS_UDef4 = value; pUS_UDef4_IsChanged=true; }
      }
      public bool PUS_UDef4_IsChanged
      {
         get{ return pUS_UDef4_IsChanged; }
         set{ pUS_UDef4_IsChanged = value; }
      }
      private string pUS_UDef5;
      private bool pUS_UDef5_IsChanged=false;
      public string PUS_UDef5
      {
         get{ return pUS_UDef5; }
         set{ pUS_UDef5 = value; pUS_UDef5_IsChanged=true; }
      }
      public bool PUS_UDef5_IsChanged
      {
         get{ return pUS_UDef5_IsChanged; }
         set{ pUS_UDef5_IsChanged = value; }
      }
      private string pUS_UDef6;
      private bool pUS_UDef6_IsChanged=false;
      public string PUS_UDef6
      {
         get{ return pUS_UDef6; }
         set{ pUS_UDef6 = value; pUS_UDef6_IsChanged=true; }
      }
      public bool PUS_UDef6_IsChanged
      {
         get{ return pUS_UDef6_IsChanged; }
         set{ pUS_UDef6_IsChanged = value; }
      }
      private string pUS_UDef7;
      private bool pUS_UDef7_IsChanged=false;
      public string PUS_UDef7
      {
         get{ return pUS_UDef7; }
         set{ pUS_UDef7 = value; pUS_UDef7_IsChanged=true; }
      }
      public bool PUS_UDef7_IsChanged
      {
         get{ return pUS_UDef7_IsChanged; }
         set{ pUS_UDef7_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pUS_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUS_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PUS_Remark
      {
         get{ return pUS_Remark; }
         set{ pUS_Remark = value; pUS_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PUS_Remark_IsChanged
      {
         get{ return pUS_Remark_IsChanged; }
         set{ pUS_Remark_IsChanged = value; }
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
      /// 审核当前阶段
      /// </summary>
      private string auditCurAudit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditCurAudit_IsChanged=false;
      /// <summary>
      /// 审核当前阶段
      /// </summary>
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      /// <summary>
      /// 审核当前阶段
      /// </summary>
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
   }
}
