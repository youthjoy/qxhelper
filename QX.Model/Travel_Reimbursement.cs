using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 出差报销管理
   /// </summary>
   [Serializable]
   public partial class Travel_Reimbursement
   {
      /// <summary>
      /// 报销记录序号
      /// </summary>
      private decimal reimbursement_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_ID_IsChanged=false;
      /// <summary>
      /// 报销记录序号
      /// </summary>
      public decimal Reimbursement_ID
      {
         get{ return reimbursement_ID; }
         set{ reimbursement_ID = value; reimbursement_ID_IsChanged=true; }
      }
      /// <summary>
      /// 报销记录序号
      /// </summary>
      public bool Reimbursement_ID_IsChanged
      {
         get{ return reimbursement_ID_IsChanged; }
         set{ reimbursement_ID_IsChanged = value; }
      }
      /// <summary>
      /// 报销记录编码
      /// </summary>
      private string reimbursement_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Code_IsChanged=false;
      /// <summary>
      /// 报销记录编码
      /// </summary>
      public string Reimbursement_Code
      {
         get{ return reimbursement_Code; }
         set{ reimbursement_Code = value; reimbursement_Code_IsChanged=true; }
      }
      /// <summary>
      /// 报销记录编码
      /// </summary>
      public bool Reimbursement_Code_IsChanged
      {
         get{ return reimbursement_Code_IsChanged; }
         set{ reimbursement_Code_IsChanged = value; }
      }
      /// <summary>
      /// 出差记录编码
      /// </summary>
      private string reimbursement_TravelCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_TravelCode_IsChanged=false;
      /// <summary>
      /// 出差记录编码
      /// </summary>
      public string Reimbursement_TravelCode
      {
         get{ return reimbursement_TravelCode; }
         set{ reimbursement_TravelCode = value; reimbursement_TravelCode_IsChanged=true; }
      }
      /// <summary>
      /// 出差记录编码
      /// </summary>
      public bool Reimbursement_TravelCode_IsChanged
      {
         get{ return reimbursement_TravelCode_IsChanged; }
         set{ reimbursement_TravelCode_IsChanged = value; }
      }
      /// <summary>
      /// 报销费用名称
      /// </summary>
      private string reimbursement_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Name_IsChanged=false;
      /// <summary>
      /// 报销费用名称
      /// </summary>
      public string Reimbursement_Name
      {
         get{ return reimbursement_Name; }
         set{ reimbursement_Name = value; reimbursement_Name_IsChanged=true; }
      }
      /// <summary>
      /// 报销费用名称
      /// </summary>
      public bool Reimbursement_Name_IsChanged
      {
         get{ return reimbursement_Name_IsChanged; }
         set{ reimbursement_Name_IsChanged = value; }
      }
      /// <summary>
      /// 摘要
      /// </summary>
      private decimal reimbursement_Abstract;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Abstract_IsChanged=false;
      /// <summary>
      /// 摘要
      /// </summary>
      public decimal Reimbursement_Abstract
      {
         get{ return reimbursement_Abstract; }
         set{ reimbursement_Abstract = value; reimbursement_Abstract_IsChanged=true; }
      }
      /// <summary>
      /// 摘要
      /// </summary>
      public bool Reimbursement_Abstract_IsChanged
      {
         get{ return reimbursement_Abstract_IsChanged; }
         set{ reimbursement_Abstract_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private string reimbursement_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Cost_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public string Reimbursement_Cost
      {
         get{ return reimbursement_Cost; }
         set{ reimbursement_Cost = value; reimbursement_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool Reimbursement_Cost_IsChanged
      {
         get{ return reimbursement_Cost_IsChanged; }
         set{ reimbursement_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 报销申请人
      /// </summary>
      private string reimbursement_ApplicantCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_ApplicantCode_IsChanged=false;
      /// <summary>
      /// 报销申请人
      /// </summary>
      public string Reimbursement_ApplicantCode
      {
         get{ return reimbursement_ApplicantCode; }
         set{ reimbursement_ApplicantCode = value; reimbursement_ApplicantCode_IsChanged=true; }
      }
      /// <summary>
      /// 报销申请人
      /// </summary>
      public bool Reimbursement_ApplicantCode_IsChanged
      {
         get{ return reimbursement_ApplicantCode_IsChanged; }
         set{ reimbursement_ApplicantCode_IsChanged = value; }
      }
      /// <summary>
      /// 报销申请人名称
      /// </summary>
      private string reimbursement__ApplicantName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement__ApplicantName_IsChanged=false;
      /// <summary>
      /// 报销申请人名称
      /// </summary>
      public string Reimbursement__ApplicantName
      {
         get{ return reimbursement__ApplicantName; }
         set{ reimbursement__ApplicantName = value; reimbursement__ApplicantName_IsChanged=true; }
      }
      /// <summary>
      /// 报销申请人名称
      /// </summary>
      public bool Reimbursement__ApplicantName_IsChanged
      {
         get{ return reimbursement__ApplicantName_IsChanged; }
         set{ reimbursement__ApplicantName_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string reimbursement_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string Reimbursement_Dept
      {
         get{ return reimbursement_Dept; }
         set{ reimbursement_Dept = value; reimbursement_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool Reimbursement_Dept_IsChanged
      {
         get{ return reimbursement_Dept_IsChanged; }
         set{ reimbursement_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string reimbursement_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string Reimbursement_Company
      {
         get{ return reimbursement_Company; }
         set{ reimbursement_Company = value; reimbursement_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool Reimbursement_Company_IsChanged
      {
         get{ return reimbursement_Company_IsChanged; }
         set{ reimbursement_Company_IsChanged = value; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      private string reimbursement_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Stat_IsChanged=false;
      /// <summary>
      /// 当前状态
      /// </summary>
      public string Reimbursement_Stat
      {
         get{ return reimbursement_Stat; }
         set{ reimbursement_Stat = value; reimbursement_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      public bool Reimbursement_Stat_IsChanged
      {
         get{ return reimbursement_Stat_IsChanged; }
         set{ reimbursement_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string reimbursement_AuditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_AuditStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string Reimbursement_AuditStat
      {
         get{ return reimbursement_AuditStat; }
         set{ reimbursement_AuditStat = value; reimbursement_AuditStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool Reimbursement_AuditStat_IsChanged
      {
         get{ return reimbursement_AuditStat_IsChanged; }
         set{ reimbursement_AuditStat_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string reimbursement_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool reimbursement_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Reimbursement_Remark
      {
         get{ return reimbursement_Remark; }
         set{ reimbursement_Remark = value; reimbursement_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Reimbursement_Remark_IsChanged
      {
         get{ return reimbursement_Remark_IsChanged; }
         set{ reimbursement_Remark_IsChanged = value; }
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
