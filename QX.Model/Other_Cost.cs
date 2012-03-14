using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 费用交纳明细(环保费用，其他费用)
   /// </summary>
   [Serializable]
   public partial class Other_Cost
   {
      /// <summary>
      /// 费用交纳明细序号
      /// </summary>
      private decimal otherCost_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_ID_IsChanged=false;
      /// <summary>
      /// 费用交纳明细序号
      /// </summary>
      public decimal OtherCost_ID
      {
         get{ return otherCost_ID; }
         set{ otherCost_ID = value; otherCost_ID_IsChanged=true; }
      }
      /// <summary>
      /// 费用交纳明细序号
      /// </summary>
      public bool OtherCost_ID_IsChanged
      {
         get{ return otherCost_ID_IsChanged; }
         set{ otherCost_ID_IsChanged = value; }
      }
      /// <summary>
      /// 费用交纳明细编码
      /// </summary>
      private string otherCost_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Code_IsChanged=false;
      /// <summary>
      /// 费用交纳明细编码
      /// </summary>
      public string OtherCost_Code
      {
         get{ return otherCost_Code; }
         set{ otherCost_Code = value; otherCost_Code_IsChanged=true; }
      }
      /// <summary>
      /// 费用交纳明细编码
      /// </summary>
      public bool OtherCost_Code_IsChanged
      {
         get{ return otherCost_Code_IsChanged; }
         set{ otherCost_Code_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal otherCost_Money;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Money_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal OtherCost_Money
      {
         get{ return otherCost_Money; }
         set{ otherCost_Money = value; otherCost_Money_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool OtherCost_Money_IsChanged
      {
         get{ return otherCost_Money_IsChanged; }
         set{ otherCost_Money_IsChanged = value; }
      }
      /// <summary>
      /// 交纳时间
      /// </summary>
      private DateTime otherCost_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Date_IsChanged=false;
      /// <summary>
      /// 交纳时间
      /// </summary>
      public DateTime OtherCost_Date
      {
         get{ return otherCost_Date; }
         set{ otherCost_Date = value; otherCost_Date_IsChanged=true; }
      }
      /// <summary>
      /// 交纳时间
      /// </summary>
      public bool OtherCost_Date_IsChanged
      {
         get{ return otherCost_Date_IsChanged; }
         set{ otherCost_Date_IsChanged = value; }
      }
      /// <summary>
      /// 交纳类别
      /// </summary>
      private string otherCost_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Type_IsChanged=false;
      /// <summary>
      /// 交纳类别
      /// </summary>
      public string OtherCost_Type
      {
         get{ return otherCost_Type; }
         set{ otherCost_Type = value; otherCost_Type_IsChanged=true; }
      }
      /// <summary>
      /// 交纳类别
      /// </summary>
      public bool OtherCost_Type_IsChanged
      {
         get{ return otherCost_Type_IsChanged; }
         set{ otherCost_Type_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string otherCost_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string OtherCost_Remark
      {
         get{ return otherCost_Remark; }
         set{ otherCost_Remark = value; otherCost_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool OtherCost_Remark_IsChanged
      {
         get{ return otherCost_Remark_IsChanged; }
         set{ otherCost_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 费用用途
      /// </summary>
      private string otherCost_Usage;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Usage_IsChanged=false;
      /// <summary>
      /// 费用用途
      /// </summary>
      public string OtherCost_Usage
      {
         get{ return otherCost_Usage; }
         set{ otherCost_Usage = value; otherCost_Usage_IsChanged=true; }
      }
      /// <summary>
      /// 费用用途
      /// </summary>
      public bool OtherCost_Usage_IsChanged
      {
         get{ return otherCost_Usage_IsChanged; }
         set{ otherCost_Usage_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string otherCost_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string OtherCost_Company
      {
         get{ return otherCost_Company; }
         set{ otherCost_Company = value; otherCost_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool OtherCost_Company_IsChanged
      {
         get{ return otherCost_Company_IsChanged; }
         set{ otherCost_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string otherCost_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string OtherCost_Dept
      {
         get{ return otherCost_Dept; }
         set{ otherCost_Dept = value; otherCost_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool OtherCost_Dept_IsChanged
      {
         get{ return otherCost_Dept_IsChanged; }
         set{ otherCost_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 缴费时间段开始时间
      /// </summary>
      private DateTime otherCost_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_BeginDate_IsChanged=false;
      /// <summary>
      /// 缴费时间段开始时间
      /// </summary>
      public DateTime OtherCost_BeginDate
      {
         get{ return otherCost_BeginDate; }
         set{ otherCost_BeginDate = value; otherCost_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 缴费时间段开始时间
      /// </summary>
      public bool OtherCost_BeginDate_IsChanged
      {
         get{ return otherCost_BeginDate_IsChanged; }
         set{ otherCost_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 缴费时间段结束时间
      /// </summary>
      private DateTime otherCost_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_EndDate_IsChanged=false;
      /// <summary>
      /// 缴费时间段结束时间
      /// </summary>
      public DateTime OtherCost_EndDate
      {
         get{ return otherCost_EndDate; }
         set{ otherCost_EndDate = value; otherCost_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 缴费时间段结束时间
      /// </summary>
      public bool OtherCost_EndDate_IsChanged
      {
         get{ return otherCost_EndDate_IsChanged; }
         set{ otherCost_EndDate_IsChanged = value; }
      }
      /// <summary>
      /// 经办人
      /// </summary>
      private string otherCost_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Operator_IsChanged=false;
      /// <summary>
      /// 经办人
      /// </summary>
      public string OtherCost_Operator
      {
         get{ return otherCost_Operator; }
         set{ otherCost_Operator = value; otherCost_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经办人
      /// </summary>
      public bool OtherCost_Operator_IsChanged
      {
         get{ return otherCost_Operator_IsChanged; }
         set{ otherCost_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 经办时间
      /// </summary>
      private DateTime otherCost_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_OpDate_IsChanged=false;
      /// <summary>
      /// 经办时间
      /// </summary>
      public DateTime OtherCost_OpDate
      {
         get{ return otherCost_OpDate; }
         set{ otherCost_OpDate = value; otherCost_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 经办时间
      /// </summary>
      public bool OtherCost_OpDate_IsChanged
      {
         get{ return otherCost_OpDate_IsChanged; }
         set{ otherCost_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string otherCost_Auditor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_Auditor_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string OtherCost_Auditor
      {
         get{ return otherCost_Auditor; }
         set{ otherCost_Auditor = value; otherCost_Auditor_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool OtherCost_Auditor_IsChanged
      {
         get{ return otherCost_Auditor_IsChanged; }
         set{ otherCost_Auditor_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime otherCost_AuditDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool otherCost_AuditDate_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime OtherCost_AuditDate
      {
         get{ return otherCost_AuditDate; }
         set{ otherCost_AuditDate = value; otherCost_AuditDate_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool OtherCost_AuditDate_IsChanged
      {
         get{ return otherCost_AuditDate_IsChanged; }
         set{ otherCost_AuditDate_IsChanged = value; }
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
