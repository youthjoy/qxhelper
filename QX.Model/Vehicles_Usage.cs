using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 后勤车辆外派记录
   /// </summary>
   [Serializable]
   public partial class Vehicles_Usage
   {
      /// <summary>
      /// 外派记录序号
      /// </summary>
      private decimal usage_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_ID_IsChanged=false;
      /// <summary>
      /// 外派记录序号
      /// </summary>
      public decimal Usage_ID
      {
         get{ return usage_ID; }
         set{ usage_ID = value; usage_ID_IsChanged=true; }
      }
      /// <summary>
      /// 外派记录序号
      /// </summary>
      public bool Usage_ID_IsChanged
      {
         get{ return usage_ID_IsChanged; }
         set{ usage_ID_IsChanged = value; }
      }
      /// <summary>
      /// 外派记录编码
      /// </summary>
      private string usage_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Code_IsChanged=false;
      /// <summary>
      /// 外派记录编码
      /// </summary>
      public string Usage_Code
      {
         get{ return usage_Code; }
         set{ usage_Code = value; usage_Code_IsChanged=true; }
      }
      /// <summary>
      /// 外派记录编码
      /// </summary>
      public bool Usage_Code_IsChanged
      {
         get{ return usage_Code_IsChanged; }
         set{ usage_Code_IsChanged = value; }
      }
      /// <summary>
      /// 外派车辆车牌号
      /// </summary>
      private string usage_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 外派车辆车牌号
      /// </summary>
      public string Usage_VehiclesNo
      {
         get{ return usage_VehiclesNo; }
         set{ usage_VehiclesNo = value; usage_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 外派车辆车牌号
      /// </summary>
      public bool Usage_VehiclesNo_IsChanged
      {
         get{ return usage_VehiclesNo_IsChanged; }
         set{ usage_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 外派车辆编码
      /// </summary>
      private string usage_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 外派车辆编码
      /// </summary>
      public string Usage_VehiclesCode
      {
         get{ return usage_VehiclesCode; }
         set{ usage_VehiclesCode = value; usage_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 外派车辆编码
      /// </summary>
      public bool Usage_VehiclesCode_IsChanged
      {
         get{ return usage_VehiclesCode_IsChanged; }
         set{ usage_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 外派车辆时间
      /// </summary>
      private DateTime usage_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Date_IsChanged=false;
      /// <summary>
      /// 外派车辆时间
      /// </summary>
      public DateTime Usage_Date
      {
         get{ return usage_Date; }
         set{ usage_Date = value; usage_Date_IsChanged=true; }
      }
      /// <summary>
      /// 外派车辆时间
      /// </summary>
      public bool Usage_Date_IsChanged
      {
         get{ return usage_Date_IsChanged; }
         set{ usage_Date_IsChanged = value; }
      }
      /// <summary>
      /// 用车部门
      /// </summary>
      private string usage_UseDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_UseDept_IsChanged=false;
      /// <summary>
      /// 用车部门
      /// </summary>
      public string Usage_UseDept
      {
         get{ return usage_UseDept; }
         set{ usage_UseDept = value; usage_UseDept_IsChanged=true; }
      }
      /// <summary>
      /// 用车部门
      /// </summary>
      public bool Usage_UseDept_IsChanged
      {
         get{ return usage_UseDept_IsChanged; }
         set{ usage_UseDept_IsChanged = value; }
      }
      /// <summary>
      /// 用车人
      /// </summary>
      private string usage_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_User_IsChanged=false;
      /// <summary>
      /// 用车人
      /// </summary>
      public string Usage_User
      {
         get{ return usage_User; }
         set{ usage_User = value; usage_User_IsChanged=true; }
      }
      /// <summary>
      /// 用车人
      /// </summary>
      public bool Usage_User_IsChanged
      {
         get{ return usage_User_IsChanged; }
         set{ usage_User_IsChanged = value; }
      }
      /// <summary>
      /// 外派车辆所属公司
      /// </summary>
      private string usage_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Company_IsChanged=false;
      /// <summary>
      /// 外派车辆所属公司
      /// </summary>
      public string Usage_Company
      {
         get{ return usage_Company; }
         set{ usage_Company = value; usage_Company_IsChanged=true; }
      }
      /// <summary>
      /// 外派车辆所属公司
      /// </summary>
      public bool Usage_Company_IsChanged
      {
         get{ return usage_Company_IsChanged; }
         set{ usage_Company_IsChanged = value; }
      }
      /// <summary>
      /// 外派所属部门
      /// </summary>
      private string usage_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Dept_IsChanged=false;
      /// <summary>
      /// 外派所属部门
      /// </summary>
      public string Usage_Dept
      {
         get{ return usage_Dept; }
         set{ usage_Dept = value; usage_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 外派所属部门
      /// </summary>
      public bool Usage_Dept_IsChanged
      {
         get{ return usage_Dept_IsChanged; }
         set{ usage_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 事由
      /// </summary>
      private string usage_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Reason_IsChanged=false;
      /// <summary>
      /// 事由
      /// </summary>
      public string Usage_Reason
      {
         get{ return usage_Reason; }
         set{ usage_Reason = value; usage_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 事由
      /// </summary>
      public bool Usage_Reason_IsChanged
      {
         get{ return usage_Reason_IsChanged; }
         set{ usage_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 路桥费
      /// </summary>
      private decimal usage_RoadCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_RoadCost_IsChanged=false;
      /// <summary>
      /// 路桥费
      /// </summary>
      public decimal Usage_RoadCost
      {
         get{ return usage_RoadCost; }
         set{ usage_RoadCost = value; usage_RoadCost_IsChanged=true; }
      }
      /// <summary>
      /// 路桥费
      /// </summary>
      public bool Usage_RoadCost_IsChanged
      {
         get{ return usage_RoadCost_IsChanged; }
         set{ usage_RoadCost_IsChanged = value; }
      }
      /// <summary>
      /// 停车费
      /// </summary>
      private decimal usage_ParkingCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_ParkingCost_IsChanged=false;
      /// <summary>
      /// 停车费
      /// </summary>
      public decimal Usage_ParkingCost
      {
         get{ return usage_ParkingCost; }
         set{ usage_ParkingCost = value; usage_ParkingCost_IsChanged=true; }
      }
      /// <summary>
      /// 停车费
      /// </summary>
      public bool Usage_ParkingCost_IsChanged
      {
         get{ return usage_ParkingCost_IsChanged; }
         set{ usage_ParkingCost_IsChanged = value; }
      }
      /// <summary>
      /// 差旅费
      /// </summary>
      private decimal usage_TravelCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_TravelCost_IsChanged=false;
      /// <summary>
      /// 差旅费
      /// </summary>
      public decimal Usage_TravelCost
      {
         get{ return usage_TravelCost; }
         set{ usage_TravelCost = value; usage_TravelCost_IsChanged=true; }
      }
      /// <summary>
      /// 差旅费
      /// </summary>
      public bool Usage_TravelCost_IsChanged
      {
         get{ return usage_TravelCost_IsChanged; }
         set{ usage_TravelCost_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶人
      /// </summary>
      private string usage_Pilot;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Pilot_IsChanged=false;
      /// <summary>
      /// 驾驶人
      /// </summary>
      public string Usage_Pilot
      {
         get{ return usage_Pilot; }
         set{ usage_Pilot = value; usage_Pilot_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶人
      /// </summary>
      public bool Usage_Pilot_IsChanged
      {
         get{ return usage_Pilot_IsChanged; }
         set{ usage_Pilot_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string usage_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool usage_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Usage_Remark
      {
         get{ return usage_Remark; }
         set{ usage_Remark = value; usage_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Usage_Remark_IsChanged
      {
         get{ return usage_Remark_IsChanged; }
         set{ usage_Remark_IsChanged = value; }
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
