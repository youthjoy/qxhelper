using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 会议通知
   /// </summary>
   [Serializable]
   public partial class Meeting_Record
   {
      /// <summary>
      /// 会议记录ID
      /// </summary>
      private decimal hRetal_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_ID_IsChanged=false;
      /// <summary>
      /// 会议记录ID
      /// </summary>
      public decimal HRetal_ID
      {
         get{ return hRetal_ID; }
         set{ hRetal_ID = value; hRetal_ID_IsChanged=true; }
      }
      /// <summary>
      /// 会议记录ID
      /// </summary>
      public bool HRetal_ID_IsChanged
      {
         get{ return hRetal_ID_IsChanged; }
         set{ hRetal_ID_IsChanged = value; }
      }
      /// <summary>
      /// 会议记录编码
      /// </summary>
      private string hRetal_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Code_IsChanged=false;
      /// <summary>
      /// 会议记录编码
      /// </summary>
      public string HRetal_Code
      {
         get{ return hRetal_Code; }
         set{ hRetal_Code = value; hRetal_Code_IsChanged=true; }
      }
      /// <summary>
      /// 会议记录编码
      /// </summary>
      public bool HRetal_Code_IsChanged
      {
         get{ return hRetal_Code_IsChanged; }
         set{ hRetal_Code_IsChanged = value; }
      }
      /// <summary>
      /// 会议时间
      /// </summary>
      private DateTime hRetal_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Date_IsChanged=false;
      /// <summary>
      /// 会议时间
      /// </summary>
      public DateTime HRetal_Date
      {
         get{ return hRetal_Date; }
         set{ hRetal_Date = value; hRetal_Date_IsChanged=true; }
      }
      /// <summary>
      /// 会议时间
      /// </summary>
      public bool HRetal_Date_IsChanged
      {
         get{ return hRetal_Date_IsChanged; }
         set{ hRetal_Date_IsChanged = value; }
      }
      /// <summary>
      /// 会议地点
      /// </summary>
      private string hRetal_Locale;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Locale_IsChanged=false;
      /// <summary>
      /// 会议地点
      /// </summary>
      public string HRetal_Locale
      {
         get{ return hRetal_Locale; }
         set{ hRetal_Locale = value; hRetal_Locale_IsChanged=true; }
      }
      /// <summary>
      /// 会议地点
      /// </summary>
      public bool HRetal_Locale_IsChanged
      {
         get{ return hRetal_Locale_IsChanged; }
         set{ hRetal_Locale_IsChanged = value; }
      }
      /// <summary>
      /// 会议标题
      /// </summary>
      private string hRetal_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Title_IsChanged=false;
      /// <summary>
      /// 会议标题
      /// </summary>
      public string HRetal_Title
      {
         get{ return hRetal_Title; }
         set{ hRetal_Title = value; hRetal_Title_IsChanged=true; }
      }
      /// <summary>
      /// 会议标题
      /// </summary>
      public bool HRetal_Title_IsChanged
      {
         get{ return hRetal_Title_IsChanged; }
         set{ hRetal_Title_IsChanged = value; }
      }
      /// <summary>
      /// 会议内容简介
      /// </summary>
      private string hRetal_Intro;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Intro_IsChanged=false;
      /// <summary>
      /// 会议内容简介
      /// </summary>
      public string HRetal_Intro
      {
         get{ return hRetal_Intro; }
         set{ hRetal_Intro = value; hRetal_Intro_IsChanged=true; }
      }
      /// <summary>
      /// 会议内容简介
      /// </summary>
      public bool HRetal_Intro_IsChanged
      {
         get{ return hRetal_Intro_IsChanged; }
         set{ hRetal_Intro_IsChanged = value; }
      }
      /// <summary>
      /// 会议参与人员
      /// </summary>
      private string hRetal_Handler;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Handler_IsChanged=false;
      /// <summary>
      /// 会议参与人员
      /// </summary>
      public string HRetal_Handler
      {
         get{ return hRetal_Handler; }
         set{ hRetal_Handler = value; hRetal_Handler_IsChanged=true; }
      }
      /// <summary>
      /// 会议参与人员
      /// </summary>
      public bool HRetal_Handler_IsChanged
      {
         get{ return hRetal_Handler_IsChanged; }
         set{ hRetal_Handler_IsChanged = value; }
      }
      /// <summary>
      /// 会议主要内容
      /// </summary>
      private string hRetal_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Content_IsChanged=false;
      /// <summary>
      /// 会议主要内容
      /// </summary>
      public string HRetal_Content
      {
         get{ return hRetal_Content; }
         set{ hRetal_Content = value; hRetal_Content_IsChanged=true; }
      }
      /// <summary>
      /// 会议主要内容
      /// </summary>
      public bool HRetal_Content_IsChanged
      {
         get{ return hRetal_Content_IsChanged; }
         set{ hRetal_Content_IsChanged = value; }
      }
      /// <summary>
      /// 会议类型
      /// </summary>
      private string hRetal_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRetal_Type_IsChanged=false;
      /// <summary>
      /// 会议类型
      /// </summary>
      public string HRetal_Type
      {
         get{ return hRetal_Type; }
         set{ hRetal_Type = value; hRetal_Type_IsChanged=true; }
      }
      /// <summary>
      /// 会议类型
      /// </summary>
      public bool HRetal_Type_IsChanged
      {
         get{ return hRetal_Type_IsChanged; }
         set{ hRetal_Type_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string hRental_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string HRental_Dept
      {
         get{ return hRental_Dept; }
         set{ hRental_Dept = value; hRental_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool HRental_Dept_IsChanged
      {
         get{ return hRental_Dept_IsChanged; }
         set{ hRental_Dept_IsChanged = value; }
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
