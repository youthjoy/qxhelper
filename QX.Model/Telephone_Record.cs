using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 电话登记记录
   /// </summary>
   [Serializable]
   public partial class Telephone_Record
   {
      /// <summary>
      /// 电话记录序号
      /// </summary>
      private decimal teleRecord_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_ID_IsChanged=false;
      /// <summary>
      /// 电话记录序号
      /// </summary>
      public decimal TeleRecord_ID
      {
         get{ return teleRecord_ID; }
         set{ teleRecord_ID = value; teleRecord_ID_IsChanged=true; }
      }
      /// <summary>
      /// 电话记录序号
      /// </summary>
      public bool TeleRecord_ID_IsChanged
      {
         get{ return teleRecord_ID_IsChanged; }
         set{ teleRecord_ID_IsChanged = value; }
      }
      /// <summary>
      /// 电话记录编码
      /// </summary>
      private string teleRecord_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Code_IsChanged=false;
      /// <summary>
      /// 电话记录编码
      /// </summary>
      public string TeleRecord_Code
      {
         get{ return teleRecord_Code; }
         set{ teleRecord_Code = value; teleRecord_Code_IsChanged=true; }
      }
      /// <summary>
      /// 电话记录编码
      /// </summary>
      public bool TeleRecord_Code_IsChanged
      {
         get{ return teleRecord_Code_IsChanged; }
         set{ teleRecord_Code_IsChanged = value; }
      }
      /// <summary>
      /// 电话记录日期
      /// </summary>
      private DateTime teleRecord_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Date_IsChanged=false;
      /// <summary>
      /// 电话记录日期
      /// </summary>
      public DateTime TeleRecord_Date
      {
         get{ return teleRecord_Date; }
         set{ teleRecord_Date = value; teleRecord_Date_IsChanged=true; }
      }
      /// <summary>
      /// 电话记录日期
      /// </summary>
      public bool TeleRecord_Date_IsChanged
      {
         get{ return teleRecord_Date_IsChanged; }
         set{ teleRecord_Date_IsChanged = value; }
      }
      /// <summary>
      /// 电话类别
      /// </summary>
      private string teleRecord_Category;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Category_IsChanged=false;
      /// <summary>
      /// 电话类别
      /// </summary>
      public string TeleRecord_Category
      {
         get{ return teleRecord_Category; }
         set{ teleRecord_Category = value; teleRecord_Category_IsChanged=true; }
      }
      /// <summary>
      /// 电话类别
      /// </summary>
      public bool TeleRecord_Category_IsChanged
      {
         get{ return teleRecord_Category_IsChanged; }
         set{ teleRecord_Category_IsChanged = value; }
      }
      /// <summary>
      /// 内容
      /// </summary>
      private string teleRecord_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Content_IsChanged=false;
      /// <summary>
      /// 内容
      /// </summary>
      public string TeleRecord_Content
      {
         get{ return teleRecord_Content; }
         set{ teleRecord_Content = value; teleRecord_Content_IsChanged=true; }
      }
      /// <summary>
      /// 内容
      /// </summary>
      public bool TeleRecord_Content_IsChanged
      {
         get{ return teleRecord_Content_IsChanged; }
         set{ teleRecord_Content_IsChanged = value; }
      }
      /// <summary>
      /// 经手单位
      /// </summary>
      private string teleRecord_OpTarget;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_OpTarget_IsChanged=false;
      /// <summary>
      /// 经手单位
      /// </summary>
      public string TeleRecord_OpTarget
      {
         get{ return teleRecord_OpTarget; }
         set{ teleRecord_OpTarget = value; teleRecord_OpTarget_IsChanged=true; }
      }
      /// <summary>
      /// 经手单位
      /// </summary>
      public bool TeleRecord_OpTarget_IsChanged
      {
         get{ return teleRecord_OpTarget_IsChanged; }
         set{ teleRecord_OpTarget_IsChanged = value; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      private string teleRecord_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Operator_IsChanged=false;
      /// <summary>
      /// 经手人
      /// </summary>
      public string TeleRecord_Operator
      {
         get{ return teleRecord_Operator; }
         set{ teleRecord_Operator = value; teleRecord_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      public bool TeleRecord_Operator_IsChanged
      {
         get{ return teleRecord_Operator_IsChanged; }
         set{ teleRecord_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 经手时间
      /// </summary>
      private DateTime teleRecord_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_OpDate_IsChanged=false;
      /// <summary>
      /// 经手时间
      /// </summary>
      public DateTime TeleRecord_OpDate
      {
         get{ return teleRecord_OpDate; }
         set{ teleRecord_OpDate = value; teleRecord_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 经手时间
      /// </summary>
      public bool TeleRecord_OpDate_IsChanged
      {
         get{ return teleRecord_OpDate_IsChanged; }
         set{ teleRecord_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string teleRecord_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_User_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string TeleRecord_User
      {
         get{ return teleRecord_User; }
         set{ teleRecord_User = value; teleRecord_User_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool TeleRecord_User_IsChanged
      {
         get{ return teleRecord_User_IsChanged; }
         set{ teleRecord_User_IsChanged = value; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      private DateTime teleRecord_UseDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_UseDate_IsChanged=false;
      /// <summary>
      /// 操作时间
      /// </summary>
      public DateTime TeleRecord_UseDate
      {
         get{ return teleRecord_UseDate; }
         set{ teleRecord_UseDate = value; teleRecord_UseDate_IsChanged=true; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      public bool TeleRecord_UseDate_IsChanged
      {
         get{ return teleRecord_UseDate_IsChanged; }
         set{ teleRecord_UseDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string teleRecord_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string TeleRecord_Remark
      {
         get{ return teleRecord_Remark; }
         set{ teleRecord_Remark = value; teleRecord_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool TeleRecord_Remark_IsChanged
      {
         get{ return teleRecord_Remark_IsChanged; }
         set{ teleRecord_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string teleRecord_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string TeleRecord_Company
      {
         get{ return teleRecord_Company; }
         set{ teleRecord_Company = value; teleRecord_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool TeleRecord_Company_IsChanged
      {
         get{ return teleRecord_Company_IsChanged; }
         set{ teleRecord_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string teleRecord_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string TeleRecord_Dept
      {
         get{ return teleRecord_Dept; }
         set{ teleRecord_Dept = value; teleRecord_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool TeleRecord_Dept_IsChanged
      {
         get{ return teleRecord_Dept_IsChanged; }
         set{ teleRecord_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string teleRecord_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool teleRecord_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string TeleRecord_iType
      {
         get{ return teleRecord_iType; }
         set{ teleRecord_iType = value; teleRecord_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool TeleRecord_iType_IsChanged
      {
         get{ return teleRecord_iType_IsChanged; }
         set{ teleRecord_iType_IsChanged = value; }
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
