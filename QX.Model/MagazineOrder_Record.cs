using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 报刊杂志订阅情况
   /// </summary>
   [Serializable]
   public partial class MagazineOrder_Record
   {
      /// <summary>
      /// 订阅记录序号
      /// </summary>
      private decimal mOR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_ID_IsChanged=false;
      /// <summary>
      /// 订阅记录序号
      /// </summary>
      public decimal MOR_ID
      {
         get{ return mOR_ID; }
         set{ mOR_ID = value; mOR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 订阅记录序号
      /// </summary>
      public bool MOR_ID_IsChanged
      {
         get{ return mOR_ID_IsChanged; }
         set{ mOR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 订阅编码
      /// </summary>
      private string mOR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Code_IsChanged=false;
      /// <summary>
      /// 订阅编码
      /// </summary>
      public string MOR_Code
      {
         get{ return mOR_Code; }
         set{ mOR_Code = value; mOR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 订阅编码
      /// </summary>
      public bool MOR_Code_IsChanged
      {
         get{ return mOR_Code_IsChanged; }
         set{ mOR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string mOR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Company_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string MOR_Company
      {
         get{ return mOR_Company; }
         set{ mOR_Company = value; mOR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool MOR_Company_IsChanged
      {
         get{ return mOR_Company_IsChanged; }
         set{ mOR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string mOR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Dept_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string MOR_Dept
      {
         get{ return mOR_Dept; }
         set{ mOR_Dept = value; mOR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool MOR_Dept_IsChanged
      {
         get{ return mOR_Dept_IsChanged; }
         set{ mOR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 报刊杂志名称
      /// </summary>
      private string mOR_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Name_IsChanged=false;
      /// <summary>
      /// 报刊杂志名称
      /// </summary>
      public string MOR_Name
      {
         get{ return mOR_Name; }
         set{ mOR_Name = value; mOR_Name_IsChanged=true; }
      }
      /// <summary>
      /// 报刊杂志名称
      /// </summary>
      public bool MOR_Name_IsChanged
      {
         get{ return mOR_Name_IsChanged; }
         set{ mOR_Name_IsChanged = value; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      private int mOR_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Count_IsChanged=false;
      /// <summary>
      /// 份数
      /// </summary>
      public int MOR_Count
      {
         get{ return mOR_Count; }
         set{ mOR_Count = value; mOR_Count_IsChanged=true; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      public bool MOR_Count_IsChanged
      {
         get{ return mOR_Count_IsChanged; }
         set{ mOR_Count_IsChanged = value; }
      }
      /// <summary>
      /// 刊期
      /// </summary>
      private string mOR_Issue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Issue_IsChanged=false;
      /// <summary>
      /// 刊期
      /// </summary>
      public string MOR_Issue
      {
         get{ return mOR_Issue; }
         set{ mOR_Issue = value; mOR_Issue_IsChanged=true; }
      }
      /// <summary>
      /// 刊期
      /// </summary>
      public bool MOR_Issue_IsChanged
      {
         get{ return mOR_Issue_IsChanged; }
         set{ mOR_Issue_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string mOR_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string MOR_Unit
      {
         get{ return mOR_Unit; }
         set{ mOR_Unit = value; mOR_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool MOR_Unit_IsChanged
      {
         get{ return mOR_Unit_IsChanged; }
         set{ mOR_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 全年价
      /// </summary>
      private decimal mOR_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Price_IsChanged=false;
      /// <summary>
      /// 全年价
      /// </summary>
      public decimal MOR_Price
      {
         get{ return mOR_Price; }
         set{ mOR_Price = value; mOR_Price_IsChanged=true; }
      }
      /// <summary>
      /// 全年价
      /// </summary>
      public bool MOR_Price_IsChanged
      {
         get{ return mOR_Price_IsChanged; }
         set{ mOR_Price_IsChanged = value; }
      }
      /// <summary>
      /// 邮发代号
      /// </summary>
      private string mOR_PostalCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_PostalCode_IsChanged=false;
      /// <summary>
      /// 邮发代号
      /// </summary>
      public string MOR_PostalCode
      {
         get{ return mOR_PostalCode; }
         set{ mOR_PostalCode = value; mOR_PostalCode_IsChanged=true; }
      }
      /// <summary>
      /// 邮发代号
      /// </summary>
      public bool MOR_PostalCode_IsChanged
      {
         get{ return mOR_PostalCode_IsChanged; }
         set{ mOR_PostalCode_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string mOR_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string MOR_iType
      {
         get{ return mOR_iType; }
         set{ mOR_iType = value; mOR_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool MOR_iType_IsChanged
      {
         get{ return mOR_iType_IsChanged; }
         set{ mOR_iType_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string mOR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mOR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string MOR_Remark
      {
         get{ return mOR_Remark; }
         set{ mOR_Remark = value; mOR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool MOR_Remark_IsChanged
      {
         get{ return mOR_Remark_IsChanged; }
         set{ mOR_Remark_IsChanged = value; }
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
