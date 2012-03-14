using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 后勤车辆年审记录
   /// </summary>
   [Serializable]
   public partial class Vehicles_Examined
   {
      /// <summary>
      /// 年审记录序号
      /// </summary>
      private decimal vExamined_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_ID_IsChanged=false;
      /// <summary>
      /// 年审记录序号
      /// </summary>
      public decimal VExamined_ID
      {
         get{ return vExamined_ID; }
         set{ vExamined_ID = value; vExamined_ID_IsChanged=true; }
      }
      /// <summary>
      /// 年审记录序号
      /// </summary>
      public bool VExamined_ID_IsChanged
      {
         get{ return vExamined_ID_IsChanged; }
         set{ vExamined_ID_IsChanged = value; }
      }
      /// <summary>
      /// 年审记录编码
      /// </summary>
      private string vExamined_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_Code_IsChanged=false;
      /// <summary>
      /// 年审记录编码
      /// </summary>
      public string VExamined_Code
      {
         get{ return vExamined_Code; }
         set{ vExamined_Code = value; vExamined_Code_IsChanged=true; }
      }
      /// <summary>
      /// 年审记录编码
      /// </summary>
      public bool VExamined_Code_IsChanged
      {
         get{ return vExamined_Code_IsChanged; }
         set{ vExamined_Code_IsChanged = value; }
      }
      /// <summary>
      /// 年审车牌号
      /// </summary>
      private string vExamined_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 年审车牌号
      /// </summary>
      public string VExamined_VehiclesNo
      {
         get{ return vExamined_VehiclesNo; }
         set{ vExamined_VehiclesNo = value; vExamined_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 年审车牌号
      /// </summary>
      public bool VExamined_VehiclesNo_IsChanged
      {
         get{ return vExamined_VehiclesNo_IsChanged; }
         set{ vExamined_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 年审车辆编码
      /// </summary>
      private string vExamined_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 年审车辆编码
      /// </summary>
      public string VExamined_VehiclesCode
      {
         get{ return vExamined_VehiclesCode; }
         set{ vExamined_VehiclesCode = value; vExamined_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 年审车辆编码
      /// </summary>
      public bool VExamined_VehiclesCode_IsChanged
      {
         get{ return vExamined_VehiclesCode_IsChanged; }
         set{ vExamined_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 年审周期
      /// </summary>
      private Int64 vExamined_Cycle;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_Cycle_IsChanged=false;
      /// <summary>
      /// 年审周期
      /// </summary>
      public Int64 VExamined_Cycle
      {
         get{ return vExamined_Cycle; }
         set{ vExamined_Cycle = value; vExamined_Cycle_IsChanged=true; }
      }
      /// <summary>
      /// 年审周期
      /// </summary>
      public bool VExamined_Cycle_IsChanged
      {
         get{ return vExamined_Cycle_IsChanged; }
         set{ vExamined_Cycle_IsChanged = value; }
      }
      /// <summary>
      /// 年审时间
      /// </summary>
      private DateTime vExamined_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_Date_IsChanged=false;
      /// <summary>
      /// 年审时间
      /// </summary>
      public DateTime VExamined_Date
      {
         get{ return vExamined_Date; }
         set{ vExamined_Date = value; vExamined_Date_IsChanged=true; }
      }
      /// <summary>
      /// 年审时间
      /// </summary>
      public bool VExamined_Date_IsChanged
      {
         get{ return vExamined_Date_IsChanged; }
         set{ vExamined_Date_IsChanged = value; }
      }
      /// <summary>
      /// 下次年审时间
      /// </summary>
      private DateTime vExamined_NextDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_NextDate_IsChanged=false;
      /// <summary>
      /// 下次年审时间
      /// </summary>
      public DateTime VExamined_NextDate
      {
         get{ return vExamined_NextDate; }
         set{ vExamined_NextDate = value; vExamined_NextDate_IsChanged=true; }
      }
      /// <summary>
      /// 下次年审时间
      /// </summary>
      public bool VExamined_NextDate_IsChanged
      {
         get{ return vExamined_NextDate_IsChanged; }
         set{ vExamined_NextDate_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vExamined_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string VExamined_Company
      {
         get{ return vExamined_Company; }
         set{ vExamined_Company = value; vExamined_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool VExamined_Company_IsChanged
      {
         get{ return vExamined_Company_IsChanged; }
         set{ vExamined_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vExamined_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string VExamined_Dept
      {
         get{ return vExamined_Dept; }
         set{ vExamined_Dept = value; vExamined_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool VExamined_Dept_IsChanged
      {
         get{ return vExamined_Dept_IsChanged; }
         set{ vExamined_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vExamined_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vExamined_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string VExamined_Remark
      {
         get{ return vExamined_Remark; }
         set{ vExamined_Remark = value; vExamined_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool VExamined_Remark_IsChanged
      {
         get{ return vExamined_Remark_IsChanged; }
         set{ vExamined_Remark_IsChanged = value; }
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
      private string vExamined_itype;
      private bool vExamined_itype_IsChanged=false;
      public string VExamined_itype
      {
         get{ return vExamined_itype; }
         set{ vExamined_itype = value; vExamined_itype_IsChanged=true; }
      }
      public bool VExamined_itype_IsChanged
      {
         get{ return vExamined_itype_IsChanged; }
         set{ vExamined_itype_IsChanged = value; }
      }
   }
}
