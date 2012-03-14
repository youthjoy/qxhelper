using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 后勤车辆维修记录
   /// </summary>
   [Serializable]
   public partial class Vehicles_Repair
   {
      /// <summary>
      /// 维修记录序号
      /// </summary>
      private decimal vRepair_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_ID_IsChanged=false;
      /// <summary>
      /// 维修记录序号
      /// </summary>
      public decimal VRepair_ID
      {
         get{ return vRepair_ID; }
         set{ vRepair_ID = value; vRepair_ID_IsChanged=true; }
      }
      /// <summary>
      /// 维修记录序号
      /// </summary>
      public bool VRepair_ID_IsChanged
      {
         get{ return vRepair_ID_IsChanged; }
         set{ vRepair_ID_IsChanged = value; }
      }
      /// <summary>
      /// 维修记录编码
      /// </summary>
      private string vRepair_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Code_IsChanged=false;
      /// <summary>
      /// 维修记录编码
      /// </summary>
      public string VRepair_Code
      {
         get{ return vRepair_Code; }
         set{ vRepair_Code = value; vRepair_Code_IsChanged=true; }
      }
      /// <summary>
      /// 维修记录编码
      /// </summary>
      public bool VRepair_Code_IsChanged
      {
         get{ return vRepair_Code_IsChanged; }
         set{ vRepair_Code_IsChanged = value; }
      }
      /// <summary>
      /// 维修车牌号
      /// </summary>
      private string vRepair_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 维修车牌号
      /// </summary>
      public string VRepair_VehiclesNo
      {
         get{ return vRepair_VehiclesNo; }
         set{ vRepair_VehiclesNo = value; vRepair_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 维修车牌号
      /// </summary>
      public bool VRepair_VehiclesNo_IsChanged
      {
         get{ return vRepair_VehiclesNo_IsChanged; }
         set{ vRepair_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 维修车辆编码
      /// </summary>
      private string vRepair_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 维修车辆编码
      /// </summary>
      public string VRepair_VehiclesCode
      {
         get{ return vRepair_VehiclesCode; }
         set{ vRepair_VehiclesCode = value; vRepair_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 维修车辆编码
      /// </summary>
      public bool VRepair_VehiclesCode_IsChanged
      {
         get{ return vRepair_VehiclesCode_IsChanged; }
         set{ vRepair_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 维修时间
      /// </summary>
      private string vRepair_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Date_IsChanged=false;
      /// <summary>
      /// 维修时间
      /// </summary>
      public string VRepair_Date
      {
         get{ return vRepair_Date; }
         set{ vRepair_Date = value; vRepair_Date_IsChanged=true; }
      }
      /// <summary>
      /// 维修时间
      /// </summary>
      public bool VRepair_Date_IsChanged
      {
         get{ return vRepair_Date_IsChanged; }
         set{ vRepair_Date_IsChanged = value; }
      }
      /// <summary>
      /// 维修项目
      /// </summary>
      private string vRepair_Object;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Object_IsChanged=false;
      /// <summary>
      /// 维修项目
      /// </summary>
      public string VRepair_Object
      {
         get{ return vRepair_Object; }
         set{ vRepair_Object = value; vRepair_Object_IsChanged=true; }
      }
      /// <summary>
      /// 维修项目
      /// </summary>
      public bool VRepair_Object_IsChanged
      {
         get{ return vRepair_Object_IsChanged; }
         set{ vRepair_Object_IsChanged = value; }
      }
      /// <summary>
      /// 所用材料
      /// </summary>
      private string vRepair_Material;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Material_IsChanged=false;
      /// <summary>
      /// 所用材料
      /// </summary>
      public string VRepair_Material
      {
         get{ return vRepair_Material; }
         set{ vRepair_Material = value; vRepair_Material_IsChanged=true; }
      }
      /// <summary>
      /// 所用材料
      /// </summary>
      public bool VRepair_Material_IsChanged
      {
         get{ return vRepair_Material_IsChanged; }
         set{ vRepair_Material_IsChanged = value; }
      }
      /// <summary>
      /// 工时
      /// </summary>
      private float vRepair_TimeCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_TimeCost_IsChanged=false;
      /// <summary>
      /// 工时
      /// </summary>
      public float VRepair_TimeCost
      {
         get{ return vRepair_TimeCost; }
         set{ vRepair_TimeCost = value; vRepair_TimeCost_IsChanged=true; }
      }
      /// <summary>
      /// 工时
      /// </summary>
      public bool VRepair_TimeCost_IsChanged
      {
         get{ return vRepair_TimeCost_IsChanged; }
         set{ vRepair_TimeCost_IsChanged = value; }
      }
      /// <summary>
      /// 修理费
      /// </summary>
      private string vRepair_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Cost_IsChanged=false;
      /// <summary>
      /// 修理费
      /// </summary>
      public string VRepair_Cost
      {
         get{ return vRepair_Cost; }
         set{ vRepair_Cost = value; vRepair_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 修理费
      /// </summary>
      public bool VRepair_Cost_IsChanged
      {
         get{ return vRepair_Cost_IsChanged; }
         set{ vRepair_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 修车单位
      /// </summary>
      private string vRepair_Position;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Position_IsChanged=false;
      /// <summary>
      /// 修车单位
      /// </summary>
      public string VRepair_Position
      {
         get{ return vRepair_Position; }
         set{ vRepair_Position = value; vRepair_Position_IsChanged=true; }
      }
      /// <summary>
      /// 修车单位
      /// </summary>
      public bool VRepair_Position_IsChanged
      {
         get{ return vRepair_Position_IsChanged; }
         set{ vRepair_Position_IsChanged = value; }
      }
      /// <summary>
      /// 送修人
      /// </summary>
      private string vRepair_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Operator_IsChanged=false;
      /// <summary>
      /// 送修人
      /// </summary>
      public string VRepair_Operator
      {
         get{ return vRepair_Operator; }
         set{ vRepair_Operator = value; vRepair_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 送修人
      /// </summary>
      public bool VRepair_Operator_IsChanged
      {
         get{ return vRepair_Operator_IsChanged; }
         set{ vRepair_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vRepair_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string VRepair_Company
      {
         get{ return vRepair_Company; }
         set{ vRepair_Company = value; vRepair_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool VRepair_Company_IsChanged
      {
         get{ return vRepair_Company_IsChanged; }
         set{ vRepair_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vRepair_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string VRepair_Dept
      {
         get{ return vRepair_Dept; }
         set{ vRepair_Dept = value; vRepair_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool VRepair_Dept_IsChanged
      {
         get{ return vRepair_Dept_IsChanged; }
         set{ vRepair_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vRepair_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vRepair_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string VRepair_Remark
      {
         get{ return vRepair_Remark; }
         set{ vRepair_Remark = value; vRepair_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool VRepair_Remark_IsChanged
      {
         get{ return vRepair_Remark_IsChanged; }
         set{ vRepair_Remark_IsChanged = value; }
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
      private string vRepair_itype;
      private bool vRepair_itype_IsChanged=false;
      public string VRepair_itype
      {
         get{ return vRepair_itype; }
         set{ vRepair_itype = value; vRepair_itype_IsChanged=true; }
      }
      public bool VRepair_itype_IsChanged
      {
         get{ return vRepair_itype_IsChanged; }
         set{ vRepair_itype_IsChanged = value; }
      }
   }
}
