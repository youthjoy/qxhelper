using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 报刊杂志分发记录
   /// </summary>
   [Serializable]
   public partial class Magazine_Distribution
   {
      /// <summary>
      /// 分发记录序号
      /// </summary>
      private decimal mDistributio_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistributio_ID_IsChanged=false;
      /// <summary>
      /// 分发记录序号
      /// </summary>
      public decimal MDistributio_ID
      {
         get{ return mDistributio_ID; }
         set{ mDistributio_ID = value; mDistributio_ID_IsChanged=true; }
      }
      /// <summary>
      /// 分发记录序号
      /// </summary>
      public bool MDistributio_ID_IsChanged
      {
         get{ return mDistributio_ID_IsChanged; }
         set{ mDistributio_ID_IsChanged = value; }
      }
      /// <summary>
      /// 分发记录编码
      /// </summary>
      private string mDistribution_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_Code_IsChanged=false;
      /// <summary>
      /// 分发记录编码
      /// </summary>
      public string MDistribution_Code
      {
         get{ return mDistribution_Code; }
         set{ mDistribution_Code = value; mDistribution_Code_IsChanged=true; }
      }
      /// <summary>
      /// 分发记录编码
      /// </summary>
      public bool MDistribution_Code_IsChanged
      {
         get{ return mDistribution_Code_IsChanged; }
         set{ mDistribution_Code_IsChanged = value; }
      }
      /// <summary>
      /// 分发报刊杂志编码
      /// </summary>
      private string mDistribution_OrderCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_OrderCode_IsChanged=false;
      /// <summary>
      /// 分发报刊杂志编码
      /// </summary>
      public string MDistribution_OrderCode
      {
         get{ return mDistribution_OrderCode; }
         set{ mDistribution_OrderCode = value; mDistribution_OrderCode_IsChanged=true; }
      }
      /// <summary>
      /// 分发报刊杂志编码
      /// </summary>
      public bool MDistribution_OrderCode_IsChanged
      {
         get{ return mDistribution_OrderCode_IsChanged; }
         set{ mDistribution_OrderCode_IsChanged = value; }
      }
      /// <summary>
      /// 分发报刊杂志名称
      /// </summary>
      private string mDistribution_OrderName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_OrderName_IsChanged=false;
      /// <summary>
      /// 分发报刊杂志名称
      /// </summary>
      public string MDistribution_OrderName
      {
         get{ return mDistribution_OrderName; }
         set{ mDistribution_OrderName = value; mDistribution_OrderName_IsChanged=true; }
      }
      /// <summary>
      /// 分发报刊杂志名称
      /// </summary>
      public bool MDistribution_OrderName_IsChanged
      {
         get{ return mDistribution_OrderName_IsChanged; }
         set{ mDistribution_OrderName_IsChanged = value; }
      }
      /// <summary>
      /// 分发部门
      /// </summary>
      private string mDistribution_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_Dept_IsChanged=false;
      /// <summary>
      /// 分发部门
      /// </summary>
      public string MDistribution_Dept
      {
         get{ return mDistribution_Dept; }
         set{ mDistribution_Dept = value; mDistribution_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 分发部门
      /// </summary>
      public bool MDistribution_Dept_IsChanged
      {
         get{ return mDistribution_Dept_IsChanged; }
         set{ mDistribution_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 分发公司
      /// </summary>
      private string mDistribution_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_Company_IsChanged=false;
      /// <summary>
      /// 分发公司
      /// </summary>
      public string MDistribution_Company
      {
         get{ return mDistribution_Company; }
         set{ mDistribution_Company = value; mDistribution_Company_IsChanged=true; }
      }
      /// <summary>
      /// 分发公司
      /// </summary>
      public bool MDistribution_Company_IsChanged
      {
         get{ return mDistribution_Company_IsChanged; }
         set{ mDistribution_Company_IsChanged = value; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      private int mDistribution_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_Count_IsChanged=false;
      /// <summary>
      /// 份数
      /// </summary>
      public int MDistribution_Count
      {
         get{ return mDistribution_Count; }
         set{ mDistribution_Count = value; mDistribution_Count_IsChanged=true; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      public bool MDistribution_Count_IsChanged
      {
         get{ return mDistribution_Count_IsChanged; }
         set{ mDistribution_Count_IsChanged = value; }
      }
      /// <summary>
      /// 分发时间
      /// </summary>
      private int mDistribution_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_Date_IsChanged=false;
      /// <summary>
      /// 分发时间
      /// </summary>
      public int MDistribution_Date
      {
         get{ return mDistribution_Date; }
         set{ mDistribution_Date = value; mDistribution_Date_IsChanged=true; }
      }
      /// <summary>
      /// 分发时间
      /// </summary>
      public bool MDistribution_Date_IsChanged
      {
         get{ return mDistribution_Date_IsChanged; }
         set{ mDistribution_Date_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string mDistribution_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDistribution_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string MDistribution_Remark
      {
         get{ return mDistribution_Remark; }
         set{ mDistribution_Remark = value; mDistribution_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool MDistribution_Remark_IsChanged
      {
         get{ return mDistribution_Remark_IsChanged; }
         set{ mDistribution_Remark_IsChanged = value; }
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
