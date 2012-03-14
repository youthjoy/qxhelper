using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 后勤车辆基本信息
   /// </summary>
   [Serializable]
   public partial class Bse_Vehicles
   {
      /// <summary>
      /// 车辆信息序号
      /// </summary>
      private decimal vehicles_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_ID_IsChanged=false;
      /// <summary>
      /// 车辆信息序号
      /// </summary>
      public decimal Vehicles_ID
      {
         get{ return vehicles_ID; }
         set{ vehicles_ID = value; vehicles_ID_IsChanged=true; }
      }
      /// <summary>
      /// 车辆信息序号
      /// </summary>
      public bool Vehicles_ID_IsChanged
      {
         get{ return vehicles_ID_IsChanged; }
         set{ vehicles_ID_IsChanged = value; }
      }
      /// <summary>
      /// 车辆信息编码
      /// </summary>
      private string vehicles_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Code_IsChanged=false;
      /// <summary>
      /// 车辆信息编码
      /// </summary>
      public string Vehicles_Code
      {
         get{ return vehicles_Code; }
         set{ vehicles_Code = value; vehicles_Code_IsChanged=true; }
      }
      /// <summary>
      /// 车辆信息编码
      /// </summary>
      public bool Vehicles_Code_IsChanged
      {
         get{ return vehicles_Code_IsChanged; }
         set{ vehicles_Code_IsChanged = value; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      private string vehicles_No;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_No_IsChanged=false;
      /// <summary>
      /// 车牌号
      /// </summary>
      public string Vehicles_No
      {
         get{ return vehicles_No; }
         set{ vehicles_No = value; vehicles_No_IsChanged=true; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      public bool Vehicles_No_IsChanged
      {
         get{ return vehicles_No_IsChanged; }
         set{ vehicles_No_IsChanged = value; }
      }
      /// <summary>
      /// 车型
      /// </summary>
      private string vehicles_Model;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Model_IsChanged=false;
      /// <summary>
      /// 车型
      /// </summary>
      public string Vehicles_Model
      {
         get{ return vehicles_Model; }
         set{ vehicles_Model = value; vehicles_Model_IsChanged=true; }
      }
      /// <summary>
      /// 车型
      /// </summary>
      public bool Vehicles_Model_IsChanged
      {
         get{ return vehicles_Model_IsChanged; }
         set{ vehicles_Model_IsChanged = value; }
      }
      /// <summary>
      /// 颜色
      /// </summary>
      private string vehicles_Color;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Color_IsChanged=false;
      /// <summary>
      /// 颜色
      /// </summary>
      public string Vehicles_Color
      {
         get{ return vehicles_Color; }
         set{ vehicles_Color = value; vehicles_Color_IsChanged=true; }
      }
      /// <summary>
      /// 颜色
      /// </summary>
      public bool Vehicles_Color_IsChanged
      {
         get{ return vehicles_Color_IsChanged; }
         set{ vehicles_Color_IsChanged = value; }
      }
      /// <summary>
      /// 稳定性
      /// </summary>
      private string vehicles_Stable;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Stable_IsChanged=false;
      /// <summary>
      /// 稳定性
      /// </summary>
      public string Vehicles_Stable
      {
         get{ return vehicles_Stable; }
         set{ vehicles_Stable = value; vehicles_Stable_IsChanged=true; }
      }
      /// <summary>
      /// 稳定性
      /// </summary>
      public bool Vehicles_Stable_IsChanged
      {
         get{ return vehicles_Stable_IsChanged; }
         set{ vehicles_Stable_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vehicles_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string Vehicles_Company
      {
         get{ return vehicles_Company; }
         set{ vehicles_Company = value; vehicles_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool Vehicles_Company_IsChanged
      {
         get{ return vehicles_Company_IsChanged; }
         set{ vehicles_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vehicles_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string Vehicles_Dept
      {
         get{ return vehicles_Dept; }
         set{ vehicles_Dept = value; vehicles_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool Vehicles_Dept_IsChanged
      {
         get{ return vehicles_Dept_IsChanged; }
         set{ vehicles_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vehicles_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vehicles_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Vehicles_Remark
      {
         get{ return vehicles_Remark; }
         set{ vehicles_Remark = value; vehicles_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Vehicles_Remark_IsChanged
      {
         get{ return vehicles_Remark_IsChanged; }
         set{ vehicles_Remark_IsChanged = value; }
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
      private string itype;
      private bool itype_IsChanged=false;
      public string Itype
      {
         get{ return itype; }
         set{ itype = value; itype_IsChanged=true; }
      }
      public bool Itype_IsChanged
      {
         get{ return itype_IsChanged; }
         set{ itype_IsChanged = value; }
      }
   }
}
