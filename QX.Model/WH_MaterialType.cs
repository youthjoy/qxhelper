using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 公司物料类别
   /// </summary>
   [Serializable]
   public partial class WH_MaterialType
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private decimal mT_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public decimal MT_ID
      {
         get{ return mT_ID; }
         set{ mT_ID = value; mT_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool MT_ID_IsChanged
      {
         get{ return mT_ID_IsChanged; }
         set{ mT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 编码
      /// </summary>
      private string mT_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_Code_IsChanged=false;
      /// <summary>
      /// 编码
      /// </summary>
      public string MT_Code
      {
         get{ return mT_Code; }
         set{ mT_Code = value; mT_Code_IsChanged=true; }
      }
      /// <summary>
      /// 编码
      /// </summary>
      public bool MT_Code_IsChanged
      {
         get{ return mT_Code_IsChanged; }
         set{ mT_Code_IsChanged = value; }
      }
      /// <summary>
      /// 类别编码
      /// </summary>
      private string mT_TCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_TCode_IsChanged=false;
      /// <summary>
      /// 类别编码
      /// </summary>
      public string MT_TCode
      {
         get{ return mT_TCode; }
         set{ mT_TCode = value; mT_TCode_IsChanged=true; }
      }
      /// <summary>
      /// 类别编码
      /// </summary>
      public bool MT_TCode_IsChanged
      {
         get{ return mT_TCode_IsChanged; }
         set{ mT_TCode_IsChanged = value; }
      }
      /// <summary>
      /// 类别名称
      /// </summary>
      private string mT_TName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_TName_IsChanged=false;
      /// <summary>
      /// 类别名称
      /// </summary>
      public string MT_TName
      {
         get{ return mT_TName; }
         set{ mT_TName = value; mT_TName_IsChanged=true; }
      }
      /// <summary>
      /// 类别名称
      /// </summary>
      public bool MT_TName_IsChanged
      {
         get{ return mT_TName_IsChanged; }
         set{ mT_TName_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string mT_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string MT_Company
      {
         get{ return mT_Company; }
         set{ mT_Company = value; mT_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool MT_Company_IsChanged
      {
         get{ return mT_Company_IsChanged; }
         set{ mT_Company_IsChanged = value; }
      }
      /// <summary>
      /// 公司编码
      /// </summary>
      private string mT_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_CompanyCode_IsChanged=false;
      /// <summary>
      /// 公司编码
      /// </summary>
      public string MT_CompanyCode
      {
         get{ return mT_CompanyCode; }
         set{ mT_CompanyCode = value; mT_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 公司编码
      /// </summary>
      public bool MT_CompanyCode_IsChanged
      {
         get{ return mT_CompanyCode_IsChanged; }
         set{ mT_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      private string mT_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_Dept_IsChanged=false;
      /// <summary>
      /// 部门名称
      /// </summary>
      public string MT_Dept
      {
         get{ return mT_Dept; }
         set{ mT_Dept = value; mT_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      public bool MT_Dept_IsChanged
      {
         get{ return mT_Dept_IsChanged; }
         set{ mT_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      private string mT_DeptCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_DeptCode_IsChanged=false;
      /// <summary>
      /// 部门编码
      /// </summary>
      public string MT_DeptCode
      {
         get{ return mT_DeptCode; }
         set{ mT_DeptCode = value; mT_DeptCode_IsChanged=true; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      public bool MT_DeptCode_IsChanged
      {
         get{ return mT_DeptCode_IsChanged; }
         set{ mT_DeptCode_IsChanged = value; }
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
      /// 是否有效
      /// </summary>
      private string mT_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mT_Status_IsChanged=false;
      /// <summary>
      /// 是否有效
      /// </summary>
      public string MT_Status
      {
         get{ return mT_Status; }
         set{ mT_Status = value; mT_Status_IsChanged=true; }
      }
      /// <summary>
      /// 是否有效
      /// </summary>
      public bool MT_Status_IsChanged
      {
         get{ return mT_Status_IsChanged; }
         set{ mT_Status_IsChanged = value; }
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
      private string mT_Itype;
      private bool mT_Itype_IsChanged=false;
      public string MT_Itype
      {
         get{ return mT_Itype; }
         set{ mT_Itype = value; mT_Itype_IsChanged=true; }
      }
      public bool MT_Itype_IsChanged
      {
         get{ return mT_Itype_IsChanged; }
         set{ mT_Itype_IsChanged = value; }
      }
      private string mT_Type;
      private bool mT_Type_IsChanged=false;
      public string MT_Type
      {
         get{ return mT_Type; }
         set{ mT_Type = value; mT_Type_IsChanged=true; }
      }
      public bool MT_Type_IsChanged
      {
         get{ return mT_Type_IsChanged; }
         set{ mT_Type_IsChanged = value; }
      }
      private string mT_Employee;
      private bool mT_Employee_IsChanged=false;
      public string MT_Employee
      {
         get{ return mT_Employee; }
         set{ mT_Employee = value; mT_Employee_IsChanged=true; }
      }
      public bool MT_Employee_IsChanged
      {
         get{ return mT_Employee_IsChanged; }
         set{ mT_Employee_IsChanged = value; }
      }
      private string mT_EmployeeName;
      private bool mT_EmployeeName_IsChanged=false;
      public string MT_EmployeeName
      {
         get{ return mT_EmployeeName; }
         set{ mT_EmployeeName = value; mT_EmployeeName_IsChanged=true; }
      }
      public bool MT_EmployeeName_IsChanged
      {
         get{ return mT_EmployeeName_IsChanged; }
         set{ mT_EmployeeName_IsChanged = value; }
      }
      private string mT_TPCode;
      private bool mT_TPCode_IsChanged=false;
      public string MT_TPCode
      {
         get{ return mT_TPCode; }
         set{ mT_TPCode = value; mT_TPCode_IsChanged=true; }
      }
      public bool MT_TPCode_IsChanged
      {
         get{ return mT_TPCode_IsChanged; }
         set{ mT_TPCode_IsChanged = value; }
      }
      private int mT_Order;
      private bool mT_Order_IsChanged=false;
      public int MT_Order
      {
         get{ return mT_Order; }
         set{ mT_Order = value; mT_Order_IsChanged=true; }
      }
      public bool MT_Order_IsChanged
      {
         get{ return mT_Order_IsChanged; }
         set{ mT_Order_IsChanged = value; }
      }
   }
}
