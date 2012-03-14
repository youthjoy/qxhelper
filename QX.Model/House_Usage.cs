using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 租赁房屋使用明细
   /// </summary>
   [Serializable]
   public partial class House_Usage
   {
      /// <summary>
      /// 房屋使用明细序号
      /// </summary>
      private decimal hUsage_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_ID_IsChanged=false;
      /// <summary>
      /// 房屋使用明细序号
      /// </summary>
      public decimal HUsage_ID
      {
         get{ return hUsage_ID; }
         set{ hUsage_ID = value; hUsage_ID_IsChanged=true; }
      }
      /// <summary>
      /// 房屋使用明细序号
      /// </summary>
      public bool HUsage_ID_IsChanged
      {
         get{ return hUsage_ID_IsChanged; }
         set{ hUsage_ID_IsChanged = value; }
      }
      /// <summary>
      /// 房屋使用明细编码
      /// </summary>
      private string hUsage_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_Code_IsChanged=false;
      /// <summary>
      /// 房屋使用明细编码
      /// </summary>
      public string HUsage_Code
      {
         get{ return hUsage_Code; }
         set{ hUsage_Code = value; hUsage_Code_IsChanged=true; }
      }
      /// <summary>
      /// 房屋使用明细编码
      /// </summary>
      public bool HUsage_Code_IsChanged
      {
         get{ return hUsage_Code_IsChanged; }
         set{ hUsage_Code_IsChanged = value; }
      }
      /// <summary>
      /// 租赁房屋编码
      /// </summary>
      private string hUsage_HRentalCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_HRentalCode_IsChanged=false;
      /// <summary>
      /// 租赁房屋编码
      /// </summary>
      public string HUsage_HRentalCode
      {
         get{ return hUsage_HRentalCode; }
         set{ hUsage_HRentalCode = value; hUsage_HRentalCode_IsChanged=true; }
      }
      /// <summary>
      /// 租赁房屋编码
      /// </summary>
      public bool HUsage_HRentalCode_IsChanged
      {
         get{ return hUsage_HRentalCode_IsChanged; }
         set{ hUsage_HRentalCode_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string hUsage_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_User_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string HUsage_User
      {
         get{ return hUsage_User; }
         set{ hUsage_User = value; hUsage_User_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool HUsage_User_IsChanged
      {
         get{ return hUsage_User_IsChanged; }
         set{ hUsage_User_IsChanged = value; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      private string hUsage_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_Type_IsChanged=false;
      /// <summary>
      /// 使用类型
      /// </summary>
      public string HUsage_Type
      {
         get{ return hUsage_Type; }
         set{ hUsage_Type = value; hUsage_Type_IsChanged=true; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      public bool HUsage_Type_IsChanged
      {
         get{ return hUsage_Type_IsChanged; }
         set{ hUsage_Type_IsChanged = value; }
      }
      /// <summary>
      /// 使用开始时间
      /// </summary>
      private DateTime hUsage_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_BeginDate_IsChanged=false;
      /// <summary>
      /// 使用开始时间
      /// </summary>
      public DateTime HUsage_BeginDate
      {
         get{ return hUsage_BeginDate; }
         set{ hUsage_BeginDate = value; hUsage_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 使用开始时间
      /// </summary>
      public bool HUsage_BeginDate_IsChanged
      {
         get{ return hUsage_BeginDate_IsChanged; }
         set{ hUsage_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 使用结束时间
      /// </summary>
      private DateTime hUsage_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_EndDate_IsChanged=false;
      /// <summary>
      /// 使用结束时间
      /// </summary>
      public DateTime HUsage_EndDate
      {
         get{ return hUsage_EndDate; }
         set{ hUsage_EndDate = value; hUsage_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 使用结束时间
      /// </summary>
      public bool HUsage_EndDate_IsChanged
      {
         get{ return hUsage_EndDate_IsChanged; }
         set{ hUsage_EndDate_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string hUsage_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string HUsage_Company
      {
         get{ return hUsage_Company; }
         set{ hUsage_Company = value; hUsage_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool HUsage_Company_IsChanged
      {
         get{ return hUsage_Company_IsChanged; }
         set{ hUsage_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string hUsage_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string HUsage_Dept
      {
         get{ return hUsage_Dept; }
         set{ hUsage_Dept = value; hUsage_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool HUsage_Dept_IsChanged
      {
         get{ return hUsage_Dept_IsChanged; }
         set{ hUsage_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string hUsage_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hUsage_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string HUsage_Remark
      {
         get{ return hUsage_Remark; }
         set{ hUsage_Remark = value; hUsage_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool HUsage_Remark_IsChanged
      {
         get{ return hUsage_Remark_IsChanged; }
         set{ hUsage_Remark_IsChanged = value; }
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
