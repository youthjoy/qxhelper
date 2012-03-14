using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 附件信息
   /// </summary>
   [Serializable]
   public partial class Bse_Attachments
   {
      /// <summary>
      /// 附件序号
      /// </summary>
      private decimal aT_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_ID_IsChanged=false;
      /// <summary>
      /// 附件序号
      /// </summary>
      public decimal AT_ID
      {
         get{ return aT_ID; }
         set{ aT_ID = value; aT_ID_IsChanged=true; }
      }
      /// <summary>
      /// 附件序号
      /// </summary>
      public bool AT_ID_IsChanged
      {
         get{ return aT_ID_IsChanged; }
         set{ aT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      private string module_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Code_IsChanged=false;
      /// <summary>
      /// 模块编码
      /// </summary>
      public string Module_Code
      {
         get{ return module_Code; }
         set{ module_Code = value; module_Code_IsChanged=true; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      public bool Module_Code_IsChanged
      {
         get{ return module_Code_IsChanged; }
         set{ module_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string record_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool record_ID_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string Record_ID
      {
         get{ return record_ID; }
         set{ record_ID = value; record_ID_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool Record_ID_IsChanged
      {
         get{ return record_ID_IsChanged; }
         set{ record_ID_IsChanged = value; }
      }
      /// <summary>
      /// 附件名称
      /// </summary>
      private string aT_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Name_IsChanged=false;
      /// <summary>
      /// 附件名称
      /// </summary>
      public string AT_Name
      {
         get{ return aT_Name; }
         set{ aT_Name = value; aT_Name_IsChanged=true; }
      }
      /// <summary>
      /// 附件名称
      /// </summary>
      public bool AT_Name_IsChanged
      {
         get{ return aT_Name_IsChanged; }
         set{ aT_Name_IsChanged = value; }
      }
      private string aT_URL;
      private bool aT_URL_IsChanged=false;
      public string AT_URL
      {
         get{ return aT_URL; }
         set{ aT_URL = value; aT_URL_IsChanged=true; }
      }
      public bool AT_URL_IsChanged
      {
         get{ return aT_URL_IsChanged; }
         set{ aT_URL_IsChanged = value; }
      }
      /// <summary>
      /// 附件创建时间
      /// </summary>
      private DateTime aT_CDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_CDate_IsChanged=false;
      /// <summary>
      /// 附件创建时间
      /// </summary>
      public DateTime AT_CDate
      {
         get{ return aT_CDate; }
         set{ aT_CDate = value; aT_CDate_IsChanged=true; }
      }
      /// <summary>
      /// 附件创建时间
      /// </summary>
      public bool AT_CDate_IsChanged
      {
         get{ return aT_CDate_IsChanged; }
         set{ aT_CDate_IsChanged = value; }
      }
      /// <summary>
      /// 附件更新时间
      /// </summary>
      private DateTime aT_UDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_UDate_IsChanged=false;
      /// <summary>
      /// 附件更新时间
      /// </summary>
      public DateTime AT_UDate
      {
         get{ return aT_UDate; }
         set{ aT_UDate = value; aT_UDate_IsChanged=true; }
      }
      /// <summary>
      /// 附件更新时间
      /// </summary>
      public bool AT_UDate_IsChanged
      {
         get{ return aT_UDate_IsChanged; }
         set{ aT_UDate_IsChanged = value; }
      }
      /// <summary>
      /// 附件创建人
      /// </summary>
      private string aT_Creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Creator_IsChanged=false;
      /// <summary>
      /// 附件创建人
      /// </summary>
      public string AT_Creator
      {
         get{ return aT_Creator; }
         set{ aT_Creator = value; aT_Creator_IsChanged=true; }
      }
      /// <summary>
      /// 附件创建人
      /// </summary>
      public bool AT_Creator_IsChanged
      {
         get{ return aT_Creator_IsChanged; }
         set{ aT_Creator_IsChanged = value; }
      }
      /// <summary>
      /// 附件更新人
      /// </summary>
      private string aT_Updator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Updator_IsChanged=false;
      /// <summary>
      /// 附件更新人
      /// </summary>
      public string AT_Updator
      {
         get{ return aT_Updator; }
         set{ aT_Updator = value; aT_Updator_IsChanged=true; }
      }
      /// <summary>
      /// 附件更新人
      /// </summary>
      public bool AT_Updator_IsChanged
      {
         get{ return aT_Updator_IsChanged; }
         set{ aT_Updator_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private string aT_Code;
      private bool aT_Code_IsChanged=false;
      public string AT_Code
      {
         get{ return aT_Code; }
         set{ aT_Code = value; aT_Code_IsChanged=true; }
      }
      public bool AT_Code_IsChanged
      {
         get{ return aT_Code_IsChanged; }
         set{ aT_Code_IsChanged = value; }
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
      private string aT_Description;
      private bool aT_Description_IsChanged=false;
      public string AT_Description
      {
         get{ return aT_Description; }
         set{ aT_Description = value; aT_Description_IsChanged=true; }
      }
      public bool AT_Description_IsChanged
      {
         get{ return aT_Description_IsChanged; }
         set{ aT_Description_IsChanged = value; }
      }
   }
}
