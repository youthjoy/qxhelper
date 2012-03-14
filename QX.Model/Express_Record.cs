using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 快件收发表
   /// </summary>
   [Serializable]
   public partial class Express_Record
   {
      /// <summary>
      /// 收发记录序号
      /// </summary>
      private decimal eRecord_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_ID_IsChanged=false;
      /// <summary>
      /// 收发记录序号
      /// </summary>
      public decimal ERecord_ID
      {
         get{ return eRecord_ID; }
         set{ eRecord_ID = value; eRecord_ID_IsChanged=true; }
      }
      /// <summary>
      /// 收发记录序号
      /// </summary>
      public bool ERecord_ID_IsChanged
      {
         get{ return eRecord_ID_IsChanged; }
         set{ eRecord_ID_IsChanged = value; }
      }
      /// <summary>
      /// 收发记录编码
      /// </summary>
      private string eRecord_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Code_IsChanged=false;
      /// <summary>
      /// 收发记录编码
      /// </summary>
      public string ERecord_Code
      {
         get{ return eRecord_Code; }
         set{ eRecord_Code = value; eRecord_Code_IsChanged=true; }
      }
      /// <summary>
      /// 收发记录编码
      /// </summary>
      public bool ERecord_Code_IsChanged
      {
         get{ return eRecord_Code_IsChanged; }
         set{ eRecord_Code_IsChanged = value; }
      }
      /// <summary>
      /// 姓名
      /// </summary>
      private string eRecord_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Name_IsChanged=false;
      /// <summary>
      /// 姓名
      /// </summary>
      public string ERecord_Name
      {
         get{ return eRecord_Name; }
         set{ eRecord_Name = value; eRecord_Name_IsChanged=true; }
      }
      /// <summary>
      /// 姓名
      /// </summary>
      public bool ERecord_Name_IsChanged
      {
         get{ return eRecord_Name_IsChanged; }
         set{ eRecord_Name_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int eRecord_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Count_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int ERecord_Count
      {
         get{ return eRecord_Count; }
         set{ eRecord_Count = value; eRecord_Count_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool ERecord_Count_IsChanged
      {
         get{ return eRecord_Count_IsChanged; }
         set{ eRecord_Count_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string eRecord_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string ERecord_Unit
      {
         get{ return eRecord_Unit; }
         set{ eRecord_Unit = value; eRecord_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool ERecord_Unit_IsChanged
      {
         get{ return eRecord_Unit_IsChanged; }
         set{ eRecord_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 领取日期
      /// </summary>
      private DateTime eRecord_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Date_IsChanged=false;
      /// <summary>
      /// 领取日期
      /// </summary>
      public DateTime ERecord_Date
      {
         get{ return eRecord_Date; }
         set{ eRecord_Date = value; eRecord_Date_IsChanged=true; }
      }
      /// <summary>
      /// 领取日期
      /// </summary>
      public bool ERecord_Date_IsChanged
      {
         get{ return eRecord_Date_IsChanged; }
         set{ eRecord_Date_IsChanged = value; }
      }
      /// <summary>
      /// 领取人
      /// </summary>
      private string eRecord_Person;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Person_IsChanged=false;
      /// <summary>
      /// 领取人
      /// </summary>
      public string ERecord_Person
      {
         get{ return eRecord_Person; }
         set{ eRecord_Person = value; eRecord_Person_IsChanged=true; }
      }
      /// <summary>
      /// 领取人
      /// </summary>
      public bool ERecord_Person_IsChanged
      {
         get{ return eRecord_Person_IsChanged; }
         set{ eRecord_Person_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string eRecord_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string ERecord_Remark
      {
         get{ return eRecord_Remark; }
         set{ eRecord_Remark = value; eRecord_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool ERecord_Remark_IsChanged
      {
         get{ return eRecord_Remark_IsChanged; }
         set{ eRecord_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string eRecord_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string ERecord_Dept
      {
         get{ return eRecord_Dept; }
         set{ eRecord_Dept = value; eRecord_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool ERecord_Dept_IsChanged
      {
         get{ return eRecord_Dept_IsChanged; }
         set{ eRecord_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string eRecord_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eRecord_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string ERecord_Company
      {
         get{ return eRecord_Company; }
         set{ eRecord_Company = value; eRecord_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool ERecord_Company_IsChanged
      {
         get{ return eRecord_Company_IsChanged; }
         set{ eRecord_Company_IsChanged = value; }
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
