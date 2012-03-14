using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Vehicles_Maintain
   {
      /// <summary>
      /// 保养记录序号
      /// </summary>
      private decimal vM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_ID_IsChanged=false;
      /// <summary>
      /// 保养记录序号
      /// </summary>
      public decimal VM_ID
      {
         get{ return vM_ID; }
         set{ vM_ID = value; vM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 保养记录序号
      /// </summary>
      public bool VM_ID_IsChanged
      {
         get{ return vM_ID_IsChanged; }
         set{ vM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 保养记录编码
      /// </summary>
      private string vM_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_Code_IsChanged=false;
      /// <summary>
      /// 保养记录编码
      /// </summary>
      public string VM_Code
      {
         get{ return vM_Code; }
         set{ vM_Code = value; vM_Code_IsChanged=true; }
      }
      /// <summary>
      /// 保养记录编码
      /// </summary>
      public bool VM_Code_IsChanged
      {
         get{ return vM_Code_IsChanged; }
         set{ vM_Code_IsChanged = value; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      private string vM_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 车辆编码
      /// </summary>
      public string VM_VehiclesCode
      {
         get{ return vM_VehiclesCode; }
         set{ vM_VehiclesCode = value; vM_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      public bool VM_VehiclesCode_IsChanged
      {
         get{ return vM_VehiclesCode_IsChanged; }
         set{ vM_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      private string vM_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 车牌号
      /// </summary>
      public string VM_VehiclesNo
      {
         get{ return vM_VehiclesNo; }
         set{ vM_VehiclesNo = value; vM_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      public bool VM_VehiclesNo_IsChanged
      {
         get{ return vM_VehiclesNo_IsChanged; }
         set{ vM_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 保养标准
      /// </summary>
      private string vM_Standard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_Standard_IsChanged=false;
      /// <summary>
      /// 保养标准
      /// </summary>
      public string VM_Standard
      {
         get{ return vM_Standard; }
         set{ vM_Standard = value; vM_Standard_IsChanged=true; }
      }
      /// <summary>
      /// 保养标准
      /// </summary>
      public bool VM_Standard_IsChanged
      {
         get{ return vM_Standard_IsChanged; }
         set{ vM_Standard_IsChanged = value; }
      }
      /// <summary>
      /// 上次保养时间
      /// </summary>
      private DateTime vM_LastDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_LastDate_IsChanged=false;
      /// <summary>
      /// 上次保养时间
      /// </summary>
      public DateTime VM_LastDate
      {
         get{ return vM_LastDate; }
         set{ vM_LastDate = value; vM_LastDate_IsChanged=true; }
      }
      /// <summary>
      /// 上次保养时间
      /// </summary>
      public bool VM_LastDate_IsChanged
      {
         get{ return vM_LastDate_IsChanged; }
         set{ vM_LastDate_IsChanged = value; }
      }
      /// <summary>
      /// 下次保养时间
      /// </summary>
      private DateTime vM_NextDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_NextDate_IsChanged=false;
      /// <summary>
      /// 下次保养时间
      /// </summary>
      public DateTime VM_NextDate
      {
         get{ return vM_NextDate; }
         set{ vM_NextDate = value; vM_NextDate_IsChanged=true; }
      }
      /// <summary>
      /// 下次保养时间
      /// </summary>
      public bool VM_NextDate_IsChanged
      {
         get{ return vM_NextDate_IsChanged; }
         set{ vM_NextDate_IsChanged = value; }
      }
      /// <summary>
      /// 下次保养里程
      /// </summary>
      private float vM_NextMileage;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_NextMileage_IsChanged=false;
      /// <summary>
      /// 下次保养里程
      /// </summary>
      public float VM_NextMileage
      {
         get{ return vM_NextMileage; }
         set{ vM_NextMileage = value; vM_NextMileage_IsChanged=true; }
      }
      /// <summary>
      /// 下次保养里程
      /// </summary>
      public bool VM_NextMileage_IsChanged
      {
         get{ return vM_NextMileage_IsChanged; }
         set{ vM_NextMileage_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vM_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string VM_Company
      {
         get{ return vM_Company; }
         set{ vM_Company = value; vM_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool VM_Company_IsChanged
      {
         get{ return vM_Company_IsChanged; }
         set{ vM_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vM_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string VM_Dept
      {
         get{ return vM_Dept; }
         set{ vM_Dept = value; vM_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool VM_Dept_IsChanged
      {
         get{ return vM_Dept_IsChanged; }
         set{ vM_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vM_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vM_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string VM_Remark
      {
         get{ return vM_Remark; }
         set{ vM_Remark = value; vM_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool VM_Remark_IsChanged
      {
         get{ return vM_Remark_IsChanged; }
         set{ vM_Remark_IsChanged = value; }
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
