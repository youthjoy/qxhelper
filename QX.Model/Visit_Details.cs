using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 客户回访明细
   /// </summary>
   [Serializable]
   public partial class Visit_Details
   {
      /// <summary>
      /// 回访明细序号
      /// </summary>
      private decimal cVDetails_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cVDetails_ID_IsChanged=false;
      /// <summary>
      /// 回访明细序号
      /// </summary>
      public decimal CVDetails_ID
      {
         get{ return cVDetails_ID; }
         set{ cVDetails_ID = value; cVDetails_ID_IsChanged=true; }
      }
      /// <summary>
      /// 回访明细序号
      /// </summary>
      public bool CVDetails_ID_IsChanged
      {
         get{ return cVDetails_ID_IsChanged; }
         set{ cVDetails_ID_IsChanged = value; }
      }
      /// <summary>
      /// 回访明细编码
      /// </summary>
      private string cVDetails_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cVDetails_Code_IsChanged=false;
      /// <summary>
      /// 回访明细编码
      /// </summary>
      public string CVDetails_Code
      {
         get{ return cVDetails_Code; }
         set{ cVDetails_Code = value; cVDetails_Code_IsChanged=true; }
      }
      /// <summary>
      /// 回访明细编码
      /// </summary>
      public bool CVDetails_Code_IsChanged
      {
         get{ return cVDetails_Code_IsChanged; }
         set{ cVDetails_Code_IsChanged = value; }
      }
      /// <summary>
      /// 回访记录编码
      /// </summary>
      private string cVDetails_CVCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cVDetails_CVCode_IsChanged=false;
      /// <summary>
      /// 回访记录编码
      /// </summary>
      public string CVDetails_CVCode
      {
         get{ return cVDetails_CVCode; }
         set{ cVDetails_CVCode = value; cVDetails_CVCode_IsChanged=true; }
      }
      /// <summary>
      /// 回访记录编码
      /// </summary>
      public bool CVDetails_CVCode_IsChanged
      {
         get{ return cVDetails_CVCode_IsChanged; }
         set{ cVDetails_CVCode_IsChanged = value; }
      }
      /// <summary>
      /// 服务项目
      /// </summary>
      private string cVDetails_Item;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cVDetails_Item_IsChanged=false;
      /// <summary>
      /// 服务项目
      /// </summary>
      public string CVDetails_Item
      {
         get{ return cVDetails_Item; }
         set{ cVDetails_Item = value; cVDetails_Item_IsChanged=true; }
      }
      /// <summary>
      /// 服务项目
      /// </summary>
      public bool CVDetails_Item_IsChanged
      {
         get{ return cVDetails_Item_IsChanged; }
         set{ cVDetails_Item_IsChanged = value; }
      }
      /// <summary>
      /// 服务评价等级
      /// </summary>
      private string cVDetails_Rating;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cVDetails_Rating_IsChanged=false;
      /// <summary>
      /// 服务评价等级
      /// </summary>
      public string CVDetails_Rating
      {
         get{ return cVDetails_Rating; }
         set{ cVDetails_Rating = value; cVDetails_Rating_IsChanged=true; }
      }
      /// <summary>
      /// 服务评价等级
      /// </summary>
      public bool CVDetails_Rating_IsChanged
      {
         get{ return cVDetails_Rating_IsChanged; }
         set{ cVDetails_Rating_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cVDetails_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cVDetails_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CVDetails_Remark
      {
         get{ return cVDetails_Remark; }
         set{ cVDetails_Remark = value; cVDetails_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CVDetails_Remark_IsChanged
      {
         get{ return cVDetails_Remark_IsChanged; }
         set{ cVDetails_Remark_IsChanged = value; }
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
