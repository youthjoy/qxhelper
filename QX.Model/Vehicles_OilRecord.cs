using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 后勤车辆加油记录
   /// </summary>
   [Serializable]
   public partial class Vehicles_OilRecord
   {
      /// <summary>
      /// 加油记录序号
      /// </summary>
      private decimal vOR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_ID_IsChanged=false;
      /// <summary>
      /// 加油记录序号
      /// </summary>
      public decimal VOR_ID
      {
         get{ return vOR_ID; }
         set{ vOR_ID = value; vOR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 加油记录序号
      /// </summary>
      public bool VOR_ID_IsChanged
      {
         get{ return vOR_ID_IsChanged; }
         set{ vOR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 加油记录编码
      /// </summary>
      private string vOR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Code_IsChanged=false;
      /// <summary>
      /// 加油记录编码
      /// </summary>
      public string VOR_Code
      {
         get{ return vOR_Code; }
         set{ vOR_Code = value; vOR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 加油记录编码
      /// </summary>
      public bool VOR_Code_IsChanged
      {
         get{ return vOR_Code_IsChanged; }
         set{ vOR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 加油车牌号
      /// </summary>
      private string vOR_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 加油车牌号
      /// </summary>
      public string VOR_VehiclesNo
      {
         get{ return vOR_VehiclesNo; }
         set{ vOR_VehiclesNo = value; vOR_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 加油车牌号
      /// </summary>
      public bool VOR_VehiclesNo_IsChanged
      {
         get{ return vOR_VehiclesNo_IsChanged; }
         set{ vOR_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 加油车辆编码
      /// </summary>
      private string vOR_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 加油车辆编码
      /// </summary>
      public string VOR_VehiclesCode
      {
         get{ return vOR_VehiclesCode; }
         set{ vOR_VehiclesCode = value; vOR_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 加油车辆编码
      /// </summary>
      public bool VOR_VehiclesCode_IsChanged
      {
         get{ return vOR_VehiclesCode_IsChanged; }
         set{ vOR_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 实际加油金额
      /// </summary>
      private decimal vOR_RealCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_RealCost_IsChanged=false;
      /// <summary>
      /// 实际加油金额
      /// </summary>
      public decimal VOR_RealCost
      {
         get{ return vOR_RealCost; }
         set{ vOR_RealCost = value; vOR_RealCost_IsChanged=true; }
      }
      /// <summary>
      /// 实际加油金额
      /// </summary>
      public bool VOR_RealCost_IsChanged
      {
         get{ return vOR_RealCost_IsChanged; }
         set{ vOR_RealCost_IsChanged = value; }
      }
      /// <summary>
      /// 账面加油金额
      /// </summary>
      private decimal vOR_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Cost_IsChanged=false;
      /// <summary>
      /// 账面加油金额
      /// </summary>
      public decimal VOR_Cost
      {
         get{ return vOR_Cost; }
         set{ vOR_Cost = value; vOR_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 账面加油金额
      /// </summary>
      public bool VOR_Cost_IsChanged
      {
         get{ return vOR_Cost_IsChanged; }
         set{ vOR_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 加油数量
      /// </summary>
      private decimal vOR_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Count_IsChanged=false;
      /// <summary>
      /// 加油数量
      /// </summary>
      public decimal VOR_Count
      {
         get{ return vOR_Count; }
         set{ vOR_Count = value; vOR_Count_IsChanged=true; }
      }
      /// <summary>
      /// 加油数量
      /// </summary>
      public bool VOR_Count_IsChanged
      {
         get{ return vOR_Count_IsChanged; }
         set{ vOR_Count_IsChanged = value; }
      }
      /// <summary>
      /// 返点金额
      /// </summary>
      private decimal vOR_ReturnMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_ReturnMoney_IsChanged=false;
      /// <summary>
      /// 返点金额
      /// </summary>
      public decimal VOR_ReturnMoney
      {
         get{ return vOR_ReturnMoney; }
         set{ vOR_ReturnMoney = value; vOR_ReturnMoney_IsChanged=true; }
      }
      /// <summary>
      /// 返点金额
      /// </summary>
      public bool VOR_ReturnMoney_IsChanged
      {
         get{ return vOR_ReturnMoney_IsChanged; }
         set{ vOR_ReturnMoney_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string vOR_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string VOR_Unit
      {
         get{ return vOR_Unit; }
         set{ vOR_Unit = value; vOR_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool VOR_Unit_IsChanged
      {
         get{ return vOR_Unit_IsChanged; }
         set{ vOR_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 加油里程
      /// </summary>
      private decimal vOR_Mile;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Mile_IsChanged=false;
      /// <summary>
      /// 加油里程
      /// </summary>
      public decimal VOR_Mile
      {
         get{ return vOR_Mile; }
         set{ vOR_Mile = value; vOR_Mile_IsChanged=true; }
      }
      /// <summary>
      /// 加油里程
      /// </summary>
      public bool VOR_Mile_IsChanged
      {
         get{ return vOR_Mile_IsChanged; }
         set{ vOR_Mile_IsChanged = value; }
      }
      /// <summary>
      /// 加油时间
      /// </summary>
      private DateTime vOR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Date_IsChanged=false;
      /// <summary>
      /// 加油时间
      /// </summary>
      public DateTime VOR_Date
      {
         get{ return vOR_Date; }
         set{ vOR_Date = value; vOR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 加油时间
      /// </summary>
      public bool VOR_Date_IsChanged
      {
         get{ return vOR_Date_IsChanged; }
         set{ vOR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vOR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string VOR_Company
      {
         get{ return vOR_Company; }
         set{ vOR_Company = value; vOR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool VOR_Company_IsChanged
      {
         get{ return vOR_Company_IsChanged; }
         set{ vOR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vOR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string VOR_Dept
      {
         get{ return vOR_Dept; }
         set{ vOR_Dept = value; vOR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool VOR_Dept_IsChanged
      {
         get{ return vOR_Dept_IsChanged; }
         set{ vOR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vOR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vOR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string VOR_Remark
      {
         get{ return vOR_Remark; }
         set{ vOR_Remark = value; vOR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool VOR_Remark_IsChanged
      {
         get{ return vOR_Remark_IsChanged; }
         set{ vOR_Remark_IsChanged = value; }
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
      private string vOR_itype;
      private bool vOR_itype_IsChanged=false;
      public string VOR_itype
      {
         get{ return vOR_itype; }
         set{ vOR_itype = value; vOR_itype_IsChanged=true; }
      }
      public bool VOR_itype_IsChanged
      {
         get{ return vOR_itype_IsChanged; }
         set{ vOR_itype_IsChanged = value; }
      }
      private string vOR_TCode;
      private bool vOR_TCode_IsChanged=false;
      public string VOR_TCode
      {
         get{ return vOR_TCode; }
         set{ vOR_TCode = value; vOR_TCode_IsChanged=true; }
      }
      public bool VOR_TCode_IsChanged
      {
         get{ return vOR_TCode_IsChanged; }
         set{ vOR_TCode_IsChanged = value; }
      }
      private string vOR_CompanyCode;
      private bool vOR_CompanyCode_IsChanged=false;
      public string VOR_CompanyCode
      {
         get{ return vOR_CompanyCode; }
         set{ vOR_CompanyCode = value; vOR_CompanyCode_IsChanged=true; }
      }
      public bool VOR_CompanyCode_IsChanged
      {
         get{ return vOR_CompanyCode_IsChanged; }
         set{ vOR_CompanyCode_IsChanged = value; }
      }
      private string vOR_DeptCode;
      private bool vOR_DeptCode_IsChanged=false;
      public string VOR_DeptCode
      {
         get{ return vOR_DeptCode; }
         set{ vOR_DeptCode = value; vOR_DeptCode_IsChanged=true; }
      }
      public bool VOR_DeptCode_IsChanged
      {
         get{ return vOR_DeptCode_IsChanged; }
         set{ vOR_DeptCode_IsChanged = value; }
      }
   }
}
