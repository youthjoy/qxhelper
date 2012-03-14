using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 印刷品明细表
   /// </summary>
   [Serializable]
   public partial class Print_Record
   {
      /// <summary>
      /// 印刷品记录序号
      /// </summary>
      private decimal print_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_ID_IsChanged=false;
      /// <summary>
      /// 印刷品记录序号
      /// </summary>
      public decimal Print_ID
      {
         get{ return print_ID; }
         set{ print_ID = value; print_ID_IsChanged=true; }
      }
      /// <summary>
      /// 印刷品记录序号
      /// </summary>
      public bool Print_ID_IsChanged
      {
         get{ return print_ID_IsChanged; }
         set{ print_ID_IsChanged = value; }
      }
      /// <summary>
      /// 印刷品记录编码
      /// </summary>
      private string print_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Code_IsChanged=false;
      /// <summary>
      /// 印刷品记录编码
      /// </summary>
      public string Print_Code
      {
         get{ return print_Code; }
         set{ print_Code = value; print_Code_IsChanged=true; }
      }
      /// <summary>
      /// 印刷品记录编码
      /// </summary>
      public bool Print_Code_IsChanged
      {
         get{ return print_Code_IsChanged; }
         set{ print_Code_IsChanged = value; }
      }
      /// <summary>
      /// 印刷时间
      /// </summary>
      private DateTime print_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Date_IsChanged=false;
      /// <summary>
      /// 印刷时间
      /// </summary>
      public DateTime Print_Date
      {
         get{ return print_Date; }
         set{ print_Date = value; print_Date_IsChanged=true; }
      }
      /// <summary>
      /// 印刷时间
      /// </summary>
      public bool Print_Date_IsChanged
      {
         get{ return print_Date_IsChanged; }
         set{ print_Date_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string print_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string Print_Company
      {
         get{ return print_Company; }
         set{ print_Company = value; print_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool Print_Company_IsChanged
      {
         get{ return print_Company_IsChanged; }
         set{ print_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string print_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string Print_Dept
      {
         get{ return print_Dept; }
         set{ print_Dept = value; print_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool Print_Dept_IsChanged
      {
         get{ return print_Dept_IsChanged; }
         set{ print_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 印刷品名称
      /// </summary>
      private string print_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Name_IsChanged=false;
      /// <summary>
      /// 印刷品名称
      /// </summary>
      public string Print_Name
      {
         get{ return print_Name; }
         set{ print_Name = value; print_Name_IsChanged=true; }
      }
      /// <summary>
      /// 印刷品名称
      /// </summary>
      public bool Print_Name_IsChanged
      {
         get{ return print_Name_IsChanged; }
         set{ print_Name_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int print_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Count_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int Print_Count
      {
         get{ return print_Count; }
         set{ print_Count = value; print_Count_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool Print_Count_IsChanged
      {
         get{ return print_Count_IsChanged; }
         set{ print_Count_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string print_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string Print_Unit
      {
         get{ return print_Unit; }
         set{ print_Unit = value; print_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool Print_Unit_IsChanged
      {
         get{ return print_Unit_IsChanged; }
         set{ print_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal print_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Cost_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal Print_Cost
      {
         get{ return print_Cost; }
         set{ print_Cost = value; print_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool Print_Cost_IsChanged
      {
         get{ return print_Cost_IsChanged; }
         set{ print_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string print_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool print_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Print_Remark
      {
         get{ return print_Remark; }
         set{ print_Remark = value; print_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Print_Remark_IsChanged
      {
         get{ return print_Remark_IsChanged; }
         set{ print_Remark_IsChanged = value; }
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
