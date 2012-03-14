using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 摆饰植物更换列表
   /// </summary>
   [Serializable]
   public partial class PlantChanged_Record
   {
      /// <summary>
      /// 植物更换记录序号
      /// </summary>
      private decimal pCR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_ID_IsChanged=false;
      /// <summary>
      /// 植物更换记录序号
      /// </summary>
      public decimal PCR_ID
      {
         get{ return pCR_ID; }
         set{ pCR_ID = value; pCR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 植物更换记录序号
      /// </summary>
      public bool PCR_ID_IsChanged
      {
         get{ return pCR_ID_IsChanged; }
         set{ pCR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 植物更换记录编码
      /// </summary>
      private string pCR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Code_IsChanged=false;
      /// <summary>
      /// 植物更换记录编码
      /// </summary>
      public string PCR_Code
      {
         get{ return pCR_Code; }
         set{ pCR_Code = value; pCR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 植物更换记录编码
      /// </summary>
      public bool PCR_Code_IsChanged
      {
         get{ return pCR_Code_IsChanged; }
         set{ pCR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 更换日期
      /// </summary>
      private DateTime pCR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Date_IsChanged=false;
      /// <summary>
      /// 更换日期
      /// </summary>
      public DateTime PCR_Date
      {
         get{ return pCR_Date; }
         set{ pCR_Date = value; pCR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 更换日期
      /// </summary>
      public bool PCR_Date_IsChanged
      {
         get{ return pCR_Date_IsChanged; }
         set{ pCR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string pCR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string PCR_Dept
      {
         get{ return pCR_Dept; }
         set{ pCR_Dept = value; pCR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool PCR_Dept_IsChanged
      {
         get{ return pCR_Dept_IsChanged; }
         set{ pCR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string pCR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string PCR_Company
      {
         get{ return pCR_Company; }
         set{ pCR_Company = value; pCR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool PCR_Company_IsChanged
      {
         get{ return pCR_Company_IsChanged; }
         set{ pCR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 原品名
      /// </summary>
      private string pCR_OldName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_OldName_IsChanged=false;
      /// <summary>
      /// 原品名
      /// </summary>
      public string PCR_OldName
      {
         get{ return pCR_OldName; }
         set{ pCR_OldName = value; pCR_OldName_IsChanged=true; }
      }
      /// <summary>
      /// 原品名
      /// </summary>
      public bool PCR_OldName_IsChanged
      {
         get{ return pCR_OldName_IsChanged; }
         set{ pCR_OldName_IsChanged = value; }
      }
      /// <summary>
      /// 更换品名
      /// </summary>
      private string pCR_NewName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_NewName_IsChanged=false;
      /// <summary>
      /// 更换品名
      /// </summary>
      public string PCR_NewName
      {
         get{ return pCR_NewName; }
         set{ pCR_NewName = value; pCR_NewName_IsChanged=true; }
      }
      /// <summary>
      /// 更换品名
      /// </summary>
      public bool PCR_NewName_IsChanged
      {
         get{ return pCR_NewName_IsChanged; }
         set{ pCR_NewName_IsChanged = value; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      private decimal pCR_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Price_IsChanged=false;
      /// <summary>
      /// 单价
      /// </summary>
      public decimal PCR_Price
      {
         get{ return pCR_Price; }
         set{ pCR_Price = value; pCR_Price_IsChanged=true; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      public bool PCR_Price_IsChanged
      {
         get{ return pCR_Price_IsChanged; }
         set{ pCR_Price_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int pCR_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Count_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int PCR_Count
      {
         get{ return pCR_Count; }
         set{ pCR_Count = value; pCR_Count_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool PCR_Count_IsChanged
      {
         get{ return pCR_Count_IsChanged; }
         set{ pCR_Count_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal pCR_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Cost_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal PCR_Cost
      {
         get{ return pCR_Cost; }
         set{ pCR_Cost = value; pCR_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool PCR_Cost_IsChanged
      {
         get{ return pCR_Cost_IsChanged; }
         set{ pCR_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 更换人
      /// </summary>
      private string pCR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Operator_IsChanged=false;
      /// <summary>
      /// 更换人
      /// </summary>
      public string PCR_Operator
      {
         get{ return pCR_Operator; }
         set{ pCR_Operator = value; pCR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 更换人
      /// </summary>
      public bool PCR_Operator_IsChanged
      {
         get{ return pCR_Operator_IsChanged; }
         set{ pCR_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pCR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PCR_Remark
      {
         get{ return pCR_Remark; }
         set{ pCR_Remark = value; pCR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PCR_Remark_IsChanged
      {
         get{ return pCR_Remark_IsChanged; }
         set{ pCR_Remark_IsChanged = value; }
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
      private string pR_Position;
      private bool pR_Position_IsChanged=false;
      public string PR_Position
      {
         get{ return pR_Position; }
         set{ pR_Position = value; pR_Position_IsChanged=true; }
      }
      public bool PR_Position_IsChanged
      {
         get{ return pR_Position_IsChanged; }
         set{ pR_Position_IsChanged = value; }
      }
   }
}
