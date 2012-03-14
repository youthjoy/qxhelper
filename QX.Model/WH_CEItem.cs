using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 供应商评分
   /// </summary>
   [Serializable]
   public partial class WH_CEItem
   {
      /// <summary>
      /// 评分序号
      /// </summary>
      private decimal cEI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_ID_IsChanged=false;
      /// <summary>
      /// 评分序号
      /// </summary>
      public decimal CEI_ID
      {
         get{ return cEI_ID; }
         set{ cEI_ID = value; cEI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 评分序号
      /// </summary>
      public bool CEI_ID_IsChanged
      {
         get{ return cEI_ID_IsChanged; }
         set{ cEI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 评分编码
      /// </summary>
      private string cEI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Code_IsChanged=false;
      /// <summary>
      /// 评分编码
      /// </summary>
      public string CEI_Code
      {
         get{ return cEI_Code; }
         set{ cEI_Code = value; cEI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 评分编码
      /// </summary>
      public bool CEI_Code_IsChanged
      {
         get{ return cEI_Code_IsChanged; }
         set{ cEI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string cEI_CustCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_CustCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string CEI_CustCode
      {
         get{ return cEI_CustCode; }
         set{ cEI_CustCode = value; cEI_CustCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool CEI_CustCode_IsChanged
      {
         get{ return cEI_CustCode_IsChanged; }
         set{ cEI_CustCode_IsChanged = value; }
      }
      /// <summary>
      /// 评分模块
      /// </summary>
      private string cEI_Key;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Key_IsChanged=false;
      /// <summary>
      /// 评分模块
      /// </summary>
      public string CEI_Key
      {
         get{ return cEI_Key; }
         set{ cEI_Key = value; cEI_Key_IsChanged=true; }
      }
      /// <summary>
      /// 评分模块
      /// </summary>
      public bool CEI_Key_IsChanged
      {
         get{ return cEI_Key_IsChanged; }
         set{ cEI_Key_IsChanged = value; }
      }
      /// <summary>
      /// 评分模块名称
      /// </summary>
      private string cEI_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Name_IsChanged=false;
      /// <summary>
      /// 评分模块名称
      /// </summary>
      public string CEI_Name
      {
         get{ return cEI_Name; }
         set{ cEI_Name = value; cEI_Name_IsChanged=true; }
      }
      /// <summary>
      /// 评分模块名称
      /// </summary>
      public bool CEI_Name_IsChanged
      {
         get{ return cEI_Name_IsChanged; }
         set{ cEI_Name_IsChanged = value; }
      }
      /// <summary>
      /// 评分数值
      /// </summary>
      private int cEI_Value;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Value_IsChanged=false;
      /// <summary>
      /// 评分数值
      /// </summary>
      public int CEI_Value
      {
         get{ return cEI_Value; }
         set{ cEI_Value = value; cEI_Value_IsChanged=true; }
      }
      /// <summary>
      /// 评分数值
      /// </summary>
      public bool CEI_Value_IsChanged
      {
         get{ return cEI_Value_IsChanged; }
         set{ cEI_Value_IsChanged = value; }
      }
      /// <summary>
      /// 评分描述
      /// </summary>
      private string cEI_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Content_IsChanged=false;
      /// <summary>
      /// 评分描述
      /// </summary>
      public string CEI_Content
      {
         get{ return cEI_Content; }
         set{ cEI_Content = value; cEI_Content_IsChanged=true; }
      }
      /// <summary>
      /// 评分描述
      /// </summary>
      public bool CEI_Content_IsChanged
      {
         get{ return cEI_Content_IsChanged; }
         set{ cEI_Content_IsChanged = value; }
      }
      /// <summary>
      /// 评分人
      /// </summary>
      private string cEI_Stuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Stuff_IsChanged=false;
      /// <summary>
      /// 评分人
      /// </summary>
      public string CEI_Stuff
      {
         get{ return cEI_Stuff; }
         set{ cEI_Stuff = value; cEI_Stuff_IsChanged=true; }
      }
      /// <summary>
      /// 评分人
      /// </summary>
      public bool CEI_Stuff_IsChanged
      {
         get{ return cEI_Stuff_IsChanged; }
         set{ cEI_Stuff_IsChanged = value; }
      }
      /// <summary>
      /// 评分部门
      /// </summary>
      private string cEI_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Dept_IsChanged=false;
      /// <summary>
      /// 评分部门
      /// </summary>
      public string CEI_Dept
      {
         get{ return cEI_Dept; }
         set{ cEI_Dept = value; cEI_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 评分部门
      /// </summary>
      public bool CEI_Dept_IsChanged
      {
         get{ return cEI_Dept_IsChanged; }
         set{ cEI_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 评分日期
      /// </summary>
      private DateTime cEI_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Date_IsChanged=false;
      /// <summary>
      /// 评分日期
      /// </summary>
      public DateTime CEI_Date
      {
         get{ return cEI_Date; }
         set{ cEI_Date = value; cEI_Date_IsChanged=true; }
      }
      /// <summary>
      /// 评分日期
      /// </summary>
      public bool CEI_Date_IsChanged
      {
         get{ return cEI_Date_IsChanged; }
         set{ cEI_Date_IsChanged = value; }
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
      /// 排序
      /// </summary>
      private int cEI_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cEI_Order_IsChanged=false;
      /// <summary>
      /// 排序
      /// </summary>
      public int CEI_Order
      {
         get{ return cEI_Order; }
         set{ cEI_Order = value; cEI_Order_IsChanged=true; }
      }
      /// <summary>
      /// 排序
      /// </summary>
      public bool CEI_Order_IsChanged
      {
         get{ return cEI_Order_IsChanged; }
         set{ cEI_Order_IsChanged = value; }
      }
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
   }
}
