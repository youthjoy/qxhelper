using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 环保费用记录
   /// </summary>
   [Serializable]
   public partial class Environment_Cost
   {
      /// <summary>
      /// 费用记录序号
      /// </summary>
      private decimal eP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_ID_IsChanged=false;
      /// <summary>
      /// 费用记录序号
      /// </summary>
      [MetaData("EP_ID","费用记录序号")]
      public decimal EP_ID
      {
         get{ return eP_ID; }
         set{ eP_ID = value; eP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 费用记录序号
      /// </summary>
      public bool EP_ID_IsChanged
      {
         get{ return eP_ID_IsChanged; }
         set{ eP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 费用记录编码
      /// </summary>
      private string eP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Code_IsChanged=false;
      /// <summary>
      /// 费用记录编码
      /// </summary>
      [MetaData("EP_Code","费用记录编码")]
      [StringLength(20, ErrorMessage = "费用记录编码长度不能超过20个字符")]
      public string EP_Code
      {
         get{ return eP_Code; }
         set{ eP_Code = value; eP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 费用记录编码
      /// </summary>
      public bool EP_Code_IsChanged
      {
         get{ return eP_Code_IsChanged; }
         set{ eP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string eP_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      [MetaData("EP_Company","所属公司")]
      [StringLength(50, ErrorMessage = "所属公司长度不能超过50个字符")]
      public string EP_Company
      {
         get{ return eP_Company; }
         set{ eP_Company = value; eP_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool EP_Company_IsChanged
      {
         get{ return eP_Company_IsChanged; }
         set{ eP_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string eP_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      [MetaData("EP_Dept","所属部门")]
      [StringLength(20, ErrorMessage = "所属部门长度不能超过20个字符")]
      public string EP_Dept
      {
         get{ return eP_Dept; }
         set{ eP_Dept = value; eP_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool EP_Dept_IsChanged
      {
         get{ return eP_Dept_IsChanged; }
         set{ eP_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 缴费时间段开始时间
      /// </summary>
      private DateTime eP_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_BeginDate_IsChanged=false;
      /// <summary>
      /// 缴费时间段开始时间
      /// </summary>
      [MetaData("EP_BeginDate","缴费时间段开始时间")]
      public DateTime EP_BeginDate
      {
         get{ return eP_BeginDate; }
         set{ eP_BeginDate = value; eP_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 缴费时间段开始时间
      /// </summary>
      public bool EP_BeginDate_IsChanged
      {
         get{ return eP_BeginDate_IsChanged; }
         set{ eP_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 缴费时间段结束时间
      /// </summary>
      private DateTime eP_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_EndDate_IsChanged=false;
      /// <summary>
      /// 缴费时间段结束时间
      /// </summary>
      [MetaData("EP_EndDate","缴费时间段结束时间")]
      public DateTime EP_EndDate
      {
         get{ return eP_EndDate; }
         set{ eP_EndDate = value; eP_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 缴费时间段结束时间
      /// </summary>
      public bool EP_EndDate_IsChanged
      {
         get{ return eP_EndDate_IsChanged; }
         set{ eP_EndDate_IsChanged = value; }
      }
      /// <summary>
      /// 费用名称
      /// </summary>
      private string eP_CostName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_CostName_IsChanged=false;
      /// <summary>
      /// 费用名称
      /// </summary>
      [MetaData("EP_CostName","费用名称")]
      [StringLength(20, ErrorMessage = "费用名称长度不能超过20个字符")]
      public string EP_CostName
      {
         get{ return eP_CostName; }
         set{ eP_CostName = value; eP_CostName_IsChanged=true; }
      }
      /// <summary>
      /// 费用名称
      /// </summary>
      public bool EP_CostName_IsChanged
      {
         get{ return eP_CostName_IsChanged; }
         set{ eP_CostName_IsChanged = value; }
      }
      /// <summary>
      /// 费用金额
      /// </summary>
      private decimal eP_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Cost_IsChanged=false;
      /// <summary>
      /// 费用金额
      /// </summary>
      [MetaData("EP_Cost","费用金额")]
      public decimal EP_Cost
      {
         get{ return eP_Cost; }
         set{ eP_Cost = value; eP_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 费用金额
      /// </summary>
      public bool EP_Cost_IsChanged
      {
         get{ return eP_Cost_IsChanged; }
         set{ eP_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 经办人
      /// </summary>
      private string eP_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Operator_IsChanged=false;
      /// <summary>
      /// 经办人
      /// </summary>
      [MetaData("EP_Operator","经办人")]
      [StringLength(20, ErrorMessage = "经办人长度不能超过20个字符")]
      public string EP_Operator
      {
         get{ return eP_Operator; }
         set{ eP_Operator = value; eP_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经办人
      /// </summary>
      public bool EP_Operator_IsChanged
      {
         get{ return eP_Operator_IsChanged; }
         set{ eP_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string eP_Auditor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Auditor_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      [MetaData("EP_Auditor","审核人")]
      [StringLength(20, ErrorMessage = "审核人长度不能超过20个字符")]
      public string EP_Auditor
      {
         get{ return eP_Auditor; }
         set{ eP_Auditor = value; eP_Auditor_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool EP_Auditor_IsChanged
      {
         get{ return eP_Auditor_IsChanged; }
         set{ eP_Auditor_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string eP_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eP_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      [MetaData("EP_Remark","备注")]
      [StringLength(200, ErrorMessage = "备注长度不能超过200个字符")]
      public string EP_Remark
      {
         get{ return eP_Remark; }
         set{ eP_Remark = value; eP_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool EP_Remark_IsChanged
      {
         get{ return eP_Remark_IsChanged; }
         set{ eP_Remark_IsChanged = value; }
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
      [MetaData("Stat","状态")]
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
      [MetaData("CreateDate","创建时间")]
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
      [MetaData("UpdateDate","更新时间")]
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
      [MetaData("DeleteDate","删除时间")]
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
