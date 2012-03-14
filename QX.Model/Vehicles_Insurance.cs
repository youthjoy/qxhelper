using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆保险记录
   /// </summary>
   [Serializable]
   public partial class Vehicles_Insurance
   {
      /// <summary>
      /// 保险记录序号
      /// </summary>
      private decimal vInsurance_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_ID_IsChanged=false;
      /// <summary>
      /// 保险记录序号
      /// </summary>
      public decimal VInsurance_ID
      {
         get{ return vInsurance_ID; }
         set{ vInsurance_ID = value; vInsurance_ID_IsChanged=true; }
      }
      /// <summary>
      /// 保险记录序号
      /// </summary>
      public bool VInsurance_ID_IsChanged
      {
         get{ return vInsurance_ID_IsChanged; }
         set{ vInsurance_ID_IsChanged = value; }
      }
      /// <summary>
      /// 保险记录编码
      /// </summary>
      private string vInsurance_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Code_IsChanged=false;
      /// <summary>
      /// 保险记录编码
      /// </summary>
      public string VInsurance_Code
      {
         get{ return vInsurance_Code; }
         set{ vInsurance_Code = value; vInsurance_Code_IsChanged=true; }
      }
      /// <summary>
      /// 保险记录编码
      /// </summary>
      public bool VInsurance_Code_IsChanged
      {
         get{ return vInsurance_Code_IsChanged; }
         set{ vInsurance_Code_IsChanged = value; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      private string vInsurance_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 车牌号
      /// </summary>
      public string VInsurance_VehiclesNo
      {
         get{ return vInsurance_VehiclesNo; }
         set{ vInsurance_VehiclesNo = value; vInsurance_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      public bool VInsurance_VehiclesNo_IsChanged
      {
         get{ return vInsurance_VehiclesNo_IsChanged; }
         set{ vInsurance_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 保险项目(字典)
      /// </summary>
      private string vInsurance_Item;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Item_IsChanged=false;
      /// <summary>
      /// 保险项目(字典)
      /// </summary>
      public string VInsurance_Item
      {
         get{ return vInsurance_Item; }
         set{ vInsurance_Item = value; vInsurance_Item_IsChanged=true; }
      }
      /// <summary>
      /// 保险项目(字典)
      /// </summary>
      public bool VInsurance_Item_IsChanged
      {
         get{ return vInsurance_Item_IsChanged; }
         set{ vInsurance_Item_IsChanged = value; }
      }
      /// <summary>
      /// 保险费
      /// </summary>
      private decimal vInsurance_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Cost_IsChanged=false;
      /// <summary>
      /// 保险费
      /// </summary>
      public decimal VInsurance_Cost
      {
         get{ return vInsurance_Cost; }
         set{ vInsurance_Cost = value; vInsurance_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 保险费
      /// </summary>
      public bool VInsurance_Cost_IsChanged
      {
         get{ return vInsurance_Cost_IsChanged; }
         set{ vInsurance_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 保险金额
      /// </summary>
      private decimal vInsurance_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Amount_IsChanged=false;
      /// <summary>
      /// 保险金额
      /// </summary>
      public decimal VInsurance_Amount
      {
         get{ return vInsurance_Amount; }
         set{ vInsurance_Amount = value; vInsurance_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 保险金额
      /// </summary>
      public bool VInsurance_Amount_IsChanged
      {
         get{ return vInsurance_Amount_IsChanged; }
         set{ vInsurance_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 保险办理人
      /// </summary>
      private string vInsurance_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Operator_IsChanged=false;
      /// <summary>
      /// 保险办理人
      /// </summary>
      public string VInsurance_Operator
      {
         get{ return vInsurance_Operator; }
         set{ vInsurance_Operator = value; vInsurance_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 保险办理人
      /// </summary>
      public bool VInsurance_Operator_IsChanged
      {
         get{ return vInsurance_Operator_IsChanged; }
         set{ vInsurance_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 保险起始时间
      /// </summary>
      private DateTime vInsurance_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_BeginDate_IsChanged=false;
      /// <summary>
      /// 保险起始时间
      /// </summary>
      public DateTime VInsurance_BeginDate
      {
         get{ return vInsurance_BeginDate; }
         set{ vInsurance_BeginDate = value; vInsurance_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 保险起始时间
      /// </summary>
      public bool VInsurance_BeginDate_IsChanged
      {
         get{ return vInsurance_BeginDate_IsChanged; }
         set{ vInsurance_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 保险结束时间
      /// </summary>
      private DateTime vInsurance_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_EndDate_IsChanged=false;
      /// <summary>
      /// 保险结束时间
      /// </summary>
      public DateTime VInsurance_EndDate
      {
         get{ return vInsurance_EndDate; }
         set{ vInsurance_EndDate = value; vInsurance_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 保险结束时间
      /// </summary>
      public bool VInsurance_EndDate_IsChanged
      {
         get{ return vInsurance_EndDate_IsChanged; }
         set{ vInsurance_EndDate_IsChanged = value; }
      }
      /// <summary>
      /// 保险到期时间
      /// </summary>
      private DateTime vInsurance_DueDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_DueDate_IsChanged=false;
      /// <summary>
      /// 保险到期时间
      /// </summary>
      public DateTime VInsurance_DueDate
      {
         get{ return vInsurance_DueDate; }
         set{ vInsurance_DueDate = value; vInsurance_DueDate_IsChanged=true; }
      }
      /// <summary>
      /// 保险到期时间
      /// </summary>
      public bool VInsurance_DueDate_IsChanged
      {
         get{ return vInsurance_DueDate_IsChanged; }
         set{ vInsurance_DueDate_IsChanged = value; }
      }
      /// <summary>
      /// 保险公司
      /// </summary>
      private string vInsurance_InsuranceCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_InsuranceCompany_IsChanged=false;
      /// <summary>
      /// 保险公司
      /// </summary>
      public string VInsurance_InsuranceCompany
      {
         get{ return vInsurance_InsuranceCompany; }
         set{ vInsurance_InsuranceCompany = value; vInsurance_InsuranceCompany_IsChanged=true; }
      }
      /// <summary>
      /// 保险公司
      /// </summary>
      public bool VInsurance_InsuranceCompany_IsChanged
      {
         get{ return vInsurance_InsuranceCompany_IsChanged; }
         set{ vInsurance_InsuranceCompany_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vInsurance_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string VInsurance_Company
      {
         get{ return vInsurance_Company; }
         set{ vInsurance_Company = value; vInsurance_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool VInsurance_Company_IsChanged
      {
         get{ return vInsurance_Company_IsChanged; }
         set{ vInsurance_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vInsurance_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string VInsurance_Dept
      {
         get{ return vInsurance_Dept; }
         set{ vInsurance_Dept = value; vInsurance_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool VInsurance_Dept_IsChanged
      {
         get{ return vInsurance_Dept_IsChanged; }
         set{ vInsurance_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vInsurance_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vInsurance_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string VInsurance_Remark
      {
         get{ return vInsurance_Remark; }
         set{ vInsurance_Remark = value; vInsurance_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool VInsurance_Remark_IsChanged
      {
         get{ return vInsurance_Remark_IsChanged; }
         set{ vInsurance_Remark_IsChanged = value; }
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
      private string vInsurance_itype;
      private bool vInsurance_itype_IsChanged=false;
      public string VInsurance_itype
      {
         get{ return vInsurance_itype; }
         set{ vInsurance_itype = value; vInsurance_itype_IsChanged=true; }
      }
      public bool VInsurance_itype_IsChanged
      {
         get{ return vInsurance_itype_IsChanged; }
         set{ vInsurance_itype_IsChanged = value; }
      }
   }
}
