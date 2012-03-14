using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 出差登记表
   /// </summary>
   [Serializable]
   public partial class Travel_Record
   {
      /// <summary>
      /// 出差登记记录序号
      /// </summary>
      private decimal tR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_ID_IsChanged=false;
      /// <summary>
      /// 出差登记记录序号
      /// </summary>
      public decimal TR_ID
      {
         get{ return tR_ID; }
         set{ tR_ID = value; tR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 出差登记记录序号
      /// </summary>
      public bool TR_ID_IsChanged
      {
         get{ return tR_ID_IsChanged; }
         set{ tR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 出差人所属公司
      /// </summary>
      private string tR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Company_IsChanged=false;
      /// <summary>
      /// 出差人所属公司
      /// </summary>
      public string TR_Company
      {
         get{ return tR_Company; }
         set{ tR_Company = value; tR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 出差人所属公司
      /// </summary>
      public bool TR_Company_IsChanged
      {
         get{ return tR_Company_IsChanged; }
         set{ tR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 出差人所属部门
      /// </summary>
      private string tR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Dept_IsChanged=false;
      /// <summary>
      /// 出差人所属部门
      /// </summary>
      public string TR_Dept
      {
         get{ return tR_Dept; }
         set{ tR_Dept = value; tR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 出差人所属部门
      /// </summary>
      public bool TR_Dept_IsChanged
      {
         get{ return tR_Dept_IsChanged; }
         set{ tR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 姓名
      /// </summary>
      private string tR_UserName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_UserName_IsChanged=false;
      /// <summary>
      /// 姓名
      /// </summary>
      public string TR_UserName
      {
         get{ return tR_UserName; }
         set{ tR_UserName = value; tR_UserName_IsChanged=true; }
      }
      /// <summary>
      /// 姓名
      /// </summary>
      public bool TR_UserName_IsChanged
      {
         get{ return tR_UserName_IsChanged; }
         set{ tR_UserName_IsChanged = value; }
      }
      /// <summary>
      /// 出差事由
      /// </summary>
      private string tR_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Reason_IsChanged=false;
      /// <summary>
      /// 出差事由
      /// </summary>
      public string TR_Reason
      {
         get{ return tR_Reason; }
         set{ tR_Reason = value; tR_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 出差事由
      /// </summary>
      public bool TR_Reason_IsChanged
      {
         get{ return tR_Reason_IsChanged; }
         set{ tR_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 出差地点
      /// </summary>
      private string tR_Place;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Place_IsChanged=false;
      /// <summary>
      /// 出差地点
      /// </summary>
      public string TR_Place
      {
         get{ return tR_Place; }
         set{ tR_Place = value; tR_Place_IsChanged=true; }
      }
      /// <summary>
      /// 出差地点
      /// </summary>
      public bool TR_Place_IsChanged
      {
         get{ return tR_Place_IsChanged; }
         set{ tR_Place_IsChanged = value; }
      }
      /// <summary>
      /// 出差往返时间
      /// </summary>
      private DateTime tR_BackDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_BackDate_IsChanged=false;
      /// <summary>
      /// 出差往返时间
      /// </summary>
      public DateTime TR_BackDate
      {
         get{ return tR_BackDate; }
         set{ tR_BackDate = value; tR_BackDate_IsChanged=true; }
      }
      /// <summary>
      /// 出差往返时间
      /// </summary>
      public bool TR_BackDate_IsChanged
      {
         get{ return tR_BackDate_IsChanged; }
         set{ tR_BackDate_IsChanged = value; }
      }
      /// <summary>
      /// 预借差旅费
      /// </summary>
      private decimal tR_EstimateCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_EstimateCost_IsChanged=false;
      /// <summary>
      /// 预借差旅费
      /// </summary>
      public decimal TR_EstimateCost
      {
         get{ return tR_EstimateCost; }
         set{ tR_EstimateCost = value; tR_EstimateCost_IsChanged=true; }
      }
      /// <summary>
      /// 预借差旅费
      /// </summary>
      public bool TR_EstimateCost_IsChanged
      {
         get{ return tR_EstimateCost_IsChanged; }
         set{ tR_EstimateCost_IsChanged = value; }
      }
      /// <summary>
      /// 乘坐交通工具
      /// </summary>
      private string tR_Transport;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Transport_IsChanged=false;
      /// <summary>
      /// 乘坐交通工具
      /// </summary>
      public string TR_Transport
      {
         get{ return tR_Transport; }
         set{ tR_Transport = value; tR_Transport_IsChanged=true; }
      }
      /// <summary>
      /// 乘坐交通工具
      /// </summary>
      public bool TR_Transport_IsChanged
      {
         get{ return tR_Transport_IsChanged; }
         set{ tR_Transport_IsChanged = value; }
      }
      /// <summary>
      /// 登记时间
      /// </summary>
      private DateTime tR_RegisterDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_RegisterDate_IsChanged=false;
      /// <summary>
      /// 登记时间
      /// </summary>
      public DateTime TR_RegisterDate
      {
         get{ return tR_RegisterDate; }
         set{ tR_RegisterDate = value; tR_RegisterDate_IsChanged=true; }
      }
      /// <summary>
      /// 登记时间
      /// </summary>
      public bool TR_RegisterDate_IsChanged
      {
         get{ return tR_RegisterDate_IsChanged; }
         set{ tR_RegisterDate_IsChanged = value; }
      }
      /// <summary>
      /// 订票时间
      /// </summary>
      private DateTime tR_OrderDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_OrderDate_IsChanged=false;
      /// <summary>
      /// 订票时间
      /// </summary>
      public DateTime TR_OrderDate
      {
         get{ return tR_OrderDate; }
         set{ tR_OrderDate = value; tR_OrderDate_IsChanged=true; }
      }
      /// <summary>
      /// 订票时间
      /// </summary>
      public bool TR_OrderDate_IsChanged
      {
         get{ return tR_OrderDate_IsChanged; }
         set{ tR_OrderDate_IsChanged = value; }
      }
      /// <summary>
      /// 航班（列车）日期
      /// </summary>
      private DateTime tR_TransportDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_TransportDate_IsChanged=false;
      /// <summary>
      /// 航班（列车）日期
      /// </summary>
      public DateTime TR_TransportDate
      {
         get{ return tR_TransportDate; }
         set{ tR_TransportDate = value; tR_TransportDate_IsChanged=true; }
      }
      /// <summary>
      /// 航班（列车）日期
      /// </summary>
      public bool TR_TransportDate_IsChanged
      {
         get{ return tR_TransportDate_IsChanged; }
         set{ tR_TransportDate_IsChanged = value; }
      }
      /// <summary>
      /// 航班（列车）号
      /// </summary>
      private string tR_TransportNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_TransportNo_IsChanged=false;
      /// <summary>
      /// 航班（列车）号
      /// </summary>
      public string TR_TransportNo
      {
         get{ return tR_TransportNo; }
         set{ tR_TransportNo = value; tR_TransportNo_IsChanged=true; }
      }
      /// <summary>
      /// 航班（列车）号
      /// </summary>
      public bool TR_TransportNo_IsChanged
      {
         get{ return tR_TransportNo_IsChanged; }
         set{ tR_TransportNo_IsChanged = value; }
      }
      /// <summary>
      /// 往返地点
      /// </summary>
      private string tR_BackPlace;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_BackPlace_IsChanged=false;
      /// <summary>
      /// 往返地点
      /// </summary>
      public string TR_BackPlace
      {
         get{ return tR_BackPlace; }
         set{ tR_BackPlace = value; tR_BackPlace_IsChanged=true; }
      }
      /// <summary>
      /// 往返地点
      /// </summary>
      public bool TR_BackPlace_IsChanged
      {
         get{ return tR_BackPlace_IsChanged; }
         set{ tR_BackPlace_IsChanged = value; }
      }
      /// <summary>
      /// 起始时间
      /// </summary>
      private DateTime tR_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_BeginDate_IsChanged=false;
      /// <summary>
      /// 起始时间
      /// </summary>
      public DateTime TR_BeginDate
      {
         get{ return tR_BeginDate; }
         set{ tR_BeginDate = value; tR_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 起始时间
      /// </summary>
      public bool TR_BeginDate_IsChanged
      {
         get{ return tR_BeginDate_IsChanged; }
         set{ tR_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 票价
      /// </summary>
      private decimal tR_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Price_IsChanged=false;
      /// <summary>
      /// 票价
      /// </summary>
      public decimal TR_Price
      {
         get{ return tR_Price; }
         set{ tR_Price = value; tR_Price_IsChanged=true; }
      }
      /// <summary>
      /// 票价
      /// </summary>
      public bool TR_Price_IsChanged
      {
         get{ return tR_Price_IsChanged; }
         set{ tR_Price_IsChanged = value; }
      }
      /// <summary>
      /// 登记记录状态
      /// </summary>
      private string tR_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Stat_IsChanged=false;
      /// <summary>
      /// 登记记录状态
      /// </summary>
      public string TR_Stat
      {
         get{ return tR_Stat; }
         set{ tR_Stat = value; tR_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 登记记录状态
      /// </summary>
      public bool TR_Stat_IsChanged
      {
         get{ return tR_Stat_IsChanged; }
         set{ tR_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string tR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string TR_Remark
      {
         get{ return tR_Remark; }
         set{ tR_Remark = value; tR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool TR_Remark_IsChanged
      {
         get{ return tR_Remark_IsChanged; }
         set{ tR_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      private string tR_CurrentStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_CurrentStat_IsChanged=false;
      /// <summary>
      /// 当前状态
      /// </summary>
      public string TR_CurrentStat
      {
         get{ return tR_CurrentStat; }
         set{ tR_CurrentStat = value; tR_CurrentStat_IsChanged=true; }
      }
      /// <summary>
      /// 当前状态
      /// </summary>
      public bool TR_CurrentStat_IsChanged
      {
         get{ return tR_CurrentStat_IsChanged; }
         set{ tR_CurrentStat_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string tR_AuditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tR_AuditStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string TR_AuditStat
      {
         get{ return tR_AuditStat; }
         set{ tR_AuditStat = value; tR_AuditStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool TR_AuditStat_IsChanged
      {
         get{ return tR_AuditStat_IsChanged; }
         set{ tR_AuditStat_IsChanged = value; }
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
