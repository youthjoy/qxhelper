using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 5S环保处罚记录
   /// </summary>
   [Serializable]
   public partial class SEP_Record
   {
      /// <summary>
      /// 处罚记录序号
      /// </summary>
      private decimal sEPRecord_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_ID_IsChanged=false;
      /// <summary>
      /// 处罚记录序号
      /// </summary>
      public decimal SEPRecord_ID
      {
         get{ return sEPRecord_ID; }
         set{ sEPRecord_ID = value; sEPRecord_ID_IsChanged=true; }
      }
      /// <summary>
      /// 处罚记录序号
      /// </summary>
      public bool SEPRecord_ID_IsChanged
      {
         get{ return sEPRecord_ID_IsChanged; }
         set{ sEPRecord_ID_IsChanged = value; }
      }
      /// <summary>
      /// 处罚记录编码
      /// </summary>
      private string sEPRecord_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Code_IsChanged=false;
      /// <summary>
      /// 处罚记录编码
      /// </summary>
      public string SEPRecord_Code
      {
         get{ return sEPRecord_Code; }
         set{ sEPRecord_Code = value; sEPRecord_Code_IsChanged=true; }
      }
      /// <summary>
      /// 处罚记录编码
      /// </summary>
      public bool SEPRecord_Code_IsChanged
      {
         get{ return sEPRecord_Code_IsChanged; }
         set{ sEPRecord_Code_IsChanged = value; }
      }
      /// <summary>
      /// 时间
      /// </summary>
      private DateTime sEPRecord_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Date_IsChanged=false;
      /// <summary>
      /// 时间
      /// </summary>
      public DateTime SEPRecord_Date
      {
         get{ return sEPRecord_Date; }
         set{ sEPRecord_Date = value; sEPRecord_Date_IsChanged=true; }
      }
      /// <summary>
      /// 时间
      /// </summary>
      public bool SEPRecord_Date_IsChanged
      {
         get{ return sEPRecord_Date_IsChanged; }
         set{ sEPRecord_Date_IsChanged = value; }
      }
      /// <summary>
      /// 事件
      /// </summary>
      private string sEPRecord_Event;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Event_IsChanged=false;
      /// <summary>
      /// 事件
      /// </summary>
      public string SEPRecord_Event
      {
         get{ return sEPRecord_Event; }
         set{ sEPRecord_Event = value; sEPRecord_Event_IsChanged=true; }
      }
      /// <summary>
      /// 事件
      /// </summary>
      public bool SEPRecord_Event_IsChanged
      {
         get{ return sEPRecord_Event_IsChanged; }
         set{ sEPRecord_Event_IsChanged = value; }
      }
      /// <summary>
      /// 处罚内容
      /// </summary>
      private string sEPRecord_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Content_IsChanged=false;
      /// <summary>
      /// 处罚内容
      /// </summary>
      public string SEPRecord_Content
      {
         get{ return sEPRecord_Content; }
         set{ sEPRecord_Content = value; sEPRecord_Content_IsChanged=true; }
      }
      /// <summary>
      /// 处罚内容
      /// </summary>
      public bool SEPRecord_Content_IsChanged
      {
         get{ return sEPRecord_Content_IsChanged; }
         set{ sEPRecord_Content_IsChanged = value; }
      }
      /// <summary>
      /// 处罚落实情况
      /// </summary>
      private string sEPRecord_Result;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Result_IsChanged=false;
      /// <summary>
      /// 处罚落实情况
      /// </summary>
      public string SEPRecord_Result
      {
         get{ return sEPRecord_Result; }
         set{ sEPRecord_Result = value; sEPRecord_Result_IsChanged=true; }
      }
      /// <summary>
      /// 处罚落实情况
      /// </summary>
      public bool SEPRecord_Result_IsChanged
      {
         get{ return sEPRecord_Result_IsChanged; }
         set{ sEPRecord_Result_IsChanged = value; }
      }
      /// <summary>
      /// 环保处理类型
      /// </summary>
      private string sEPRecord_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Type_IsChanged=false;
      /// <summary>
      /// 环保处理类型
      /// </summary>
      public string SEPRecord_Type
      {
         get{ return sEPRecord_Type; }
         set{ sEPRecord_Type = value; sEPRecord_Type_IsChanged=true; }
      }
      /// <summary>
      /// 环保处理类型
      /// </summary>
      public bool SEPRecord_Type_IsChanged
      {
         get{ return sEPRecord_Type_IsChanged; }
         set{ sEPRecord_Type_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sEPRecord_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SEPRecord_Remark
      {
         get{ return sEPRecord_Remark; }
         set{ sEPRecord_Remark = value; sEPRecord_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SEPRecord_Remark_IsChanged
      {
         get{ return sEPRecord_Remark_IsChanged; }
         set{ sEPRecord_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string sEPRecordCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecordCompany_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string SEPRecordCompany
      {
         get{ return sEPRecordCompany; }
         set{ sEPRecordCompany = value; sEPRecordCompany_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool SEPRecordCompany_IsChanged
      {
         get{ return sEPRecordCompany_IsChanged; }
         set{ sEPRecordCompany_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string sEPRecord_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sEPRecord_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string SEPRecord_Dept
      {
         get{ return sEPRecord_Dept; }
         set{ sEPRecord_Dept = value; sEPRecord_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool SEPRecord_Dept_IsChanged
      {
         get{ return sEPRecord_Dept_IsChanged; }
         set{ sEPRecord_Dept_IsChanged = value; }
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
