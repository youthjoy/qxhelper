using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 房屋租赁费用明细
   /// </summary>
   [Serializable]
   public partial class House_Cost
   {
      /// <summary>
      /// 房屋费用明细序号
      /// </summary>
      private decimal hCost_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_ID_IsChanged=false;
      /// <summary>
      /// 房屋费用明细序号
      /// </summary>
      public decimal HCost_ID
      {
         get{ return hCost_ID; }
         set{ hCost_ID = value; hCost_ID_IsChanged=true; }
      }
      /// <summary>
      /// 房屋费用明细序号
      /// </summary>
      public bool HCost_ID_IsChanged
      {
         get{ return hCost_ID_IsChanged; }
         set{ hCost_ID_IsChanged = value; }
      }
      /// <summary>
      /// 房屋费用明细编码
      /// </summary>
      private string hCost_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_Code_IsChanged=false;
      /// <summary>
      /// 房屋费用明细编码
      /// </summary>
      public string HCost_Code
      {
         get{ return hCost_Code; }
         set{ hCost_Code = value; hCost_Code_IsChanged=true; }
      }
      /// <summary>
      /// 房屋费用明细编码
      /// </summary>
      public bool HCost_Code_IsChanged
      {
         get{ return hCost_Code_IsChanged; }
         set{ hCost_Code_IsChanged = value; }
      }
      /// <summary>
      /// 房屋租赁编码
      /// </summary>
      private string hCost_HRentalCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_HRentalCode_IsChanged=false;
      /// <summary>
      /// 房屋租赁编码
      /// </summary>
      public string HCost_HRentalCode
      {
         get{ return hCost_HRentalCode; }
         set{ hCost_HRentalCode = value; hCost_HRentalCode_IsChanged=true; }
      }
      /// <summary>
      /// 房屋租赁编码
      /// </summary>
      public bool HCost_HRentalCode_IsChanged
      {
         get{ return hCost_HRentalCode_IsChanged; }
         set{ hCost_HRentalCode_IsChanged = value; }
      }
      /// <summary>
      /// 房屋地址
      /// </summary>
      private string hCost_HousePosition;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_HousePosition_IsChanged=false;
      /// <summary>
      /// 房屋地址
      /// </summary>
      public string HCost_HousePosition
      {
         get{ return hCost_HousePosition; }
         set{ hCost_HousePosition = value; hCost_HousePosition_IsChanged=true; }
      }
      /// <summary>
      /// 房屋地址
      /// </summary>
      public bool HCost_HousePosition_IsChanged
      {
         get{ return hCost_HousePosition_IsChanged; }
         set{ hCost_HousePosition_IsChanged = value; }
      }
      /// <summary>
      /// 缴费月份
      /// </summary>
      private DateTime hCost_PayMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_PayMonth_IsChanged=false;
      /// <summary>
      /// 缴费月份
      /// </summary>
      public DateTime HCost_PayMonth
      {
         get{ return hCost_PayMonth; }
         set{ hCost_PayMonth = value; hCost_PayMonth_IsChanged=true; }
      }
      /// <summary>
      /// 缴费月份
      /// </summary>
      public bool HCost_PayMonth_IsChanged
      {
         get{ return hCost_PayMonth_IsChanged; }
         set{ hCost_PayMonth_IsChanged = value; }
      }
      /// <summary>
      /// 费用名称
      /// </summary>
      private string hCost_CostName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_CostName_IsChanged=false;
      /// <summary>
      /// 费用名称
      /// </summary>
      public string HCost_CostName
      {
         get{ return hCost_CostName; }
         set{ hCost_CostName = value; hCost_CostName_IsChanged=true; }
      }
      /// <summary>
      /// 费用名称
      /// </summary>
      public bool HCost_CostName_IsChanged
      {
         get{ return hCost_CostName_IsChanged; }
         set{ hCost_CostName_IsChanged = value; }
      }
      /// <summary>
      /// 费用编码
      /// </summary>
      private string hCost_CostCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_CostCode_IsChanged=false;
      /// <summary>
      /// 费用编码
      /// </summary>
      public string HCost_CostCode
      {
         get{ return hCost_CostCode; }
         set{ hCost_CostCode = value; hCost_CostCode_IsChanged=true; }
      }
      /// <summary>
      /// 费用编码
      /// </summary>
      public bool HCost_CostCode_IsChanged
      {
         get{ return hCost_CostCode_IsChanged; }
         set{ hCost_CostCode_IsChanged = value; }
      }
      /// <summary>
      /// 费用金额
      /// </summary>
      private decimal hCost_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_Cost_IsChanged=false;
      /// <summary>
      /// 费用金额
      /// </summary>
      public decimal HCost_Cost
      {
         get{ return hCost_Cost; }
         set{ hCost_Cost = value; hCost_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 费用金额
      /// </summary>
      public bool HCost_Cost_IsChanged
      {
         get{ return hCost_Cost_IsChanged; }
         set{ hCost_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string hCost_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string HCost_Remark
      {
         get{ return hCost_Remark; }
         set{ hCost_Remark = value; hCost_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool HCost_Remark_IsChanged
      {
         get{ return hCost_Remark_IsChanged; }
         set{ hCost_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string hCost_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_User_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string HCost_User
      {
         get{ return hCost_User; }
         set{ hCost_User = value; hCost_User_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool HCost_User_IsChanged
      {
         get{ return hCost_User_IsChanged; }
         set{ hCost_User_IsChanged = value; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      private string hCost_UseType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_UseType_IsChanged=false;
      /// <summary>
      /// 使用类型
      /// </summary>
      public string HCost_UseType
      {
         get{ return hCost_UseType; }
         set{ hCost_UseType = value; hCost_UseType_IsChanged=true; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      public bool HCost_UseType_IsChanged
      {
         get{ return hCost_UseType_IsChanged; }
         set{ hCost_UseType_IsChanged = value; }
      }
      /// <summary>
      /// 费用开始时间
      /// </summary>
      private DateTime hCost_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_BeginDate_IsChanged=false;
      /// <summary>
      /// 费用开始时间
      /// </summary>
      public DateTime HCost_BeginDate
      {
         get{ return hCost_BeginDate; }
         set{ hCost_BeginDate = value; hCost_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 费用开始时间
      /// </summary>
      public bool HCost_BeginDate_IsChanged
      {
         get{ return hCost_BeginDate_IsChanged; }
         set{ hCost_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 费用结束时间
      /// </summary>
      private DateTime hCost_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hCost_EndDate_IsChanged=false;
      /// <summary>
      /// 费用结束时间
      /// </summary>
      public DateTime HCost_EndDate
      {
         get{ return hCost_EndDate; }
         set{ hCost_EndDate = value; hCost_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 费用结束时间
      /// </summary>
      public bool HCost_EndDate_IsChanged
      {
         get{ return hCost_EndDate_IsChanged; }
         set{ hCost_EndDate_IsChanged = value; }
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
      private string hCost_Company;
      private bool hCost_Company_IsChanged=false;
      public string HCost_Company
      {
         get{ return hCost_Company; }
         set{ hCost_Company = value; hCost_Company_IsChanged=true; }
      }
      public bool HCost_Company_IsChanged
      {
         get{ return hCost_Company_IsChanged; }
         set{ hCost_Company_IsChanged = value; }
      }
      private string hCost_Dept;
      private bool hCost_Dept_IsChanged=false;
      public string HCost_Dept
      {
         get{ return hCost_Dept; }
         set{ hCost_Dept = value; hCost_Dept_IsChanged=true; }
      }
      public bool HCost_Dept_IsChanged
      {
         get{ return hCost_Dept_IsChanged; }
         set{ hCost_Dept_IsChanged = value; }
      }
   }
}
