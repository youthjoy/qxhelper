using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 语音播报
   /// </summary>
   [Serializable]
   public partial class PCD_Voice
   {
      private decimal pCDV_ID;
      private bool pCDV_ID_IsChanged=false;
      public decimal PCDV_ID
      {
         get{ return pCDV_ID; }
         set{ pCDV_ID = value; pCDV_ID_IsChanged=true; }
      }
      public bool PCDV_ID_IsChanged
      {
         get{ return pCDV_ID_IsChanged; }
         set{ pCDV_ID_IsChanged = value; }
      }
      private string pCDV_Code;
      private bool pCDV_Code_IsChanged=false;
      public string PCDV_Code
      {
         get{ return pCDV_Code; }
         set{ pCDV_Code = value; pCDV_Code_IsChanged=true; }
      }
      public bool PCDV_Code_IsChanged
      {
         get{ return pCDV_Code_IsChanged; }
         set{ pCDV_Code_IsChanged = value; }
      }
      private string pCDV_Type;
      private bool pCDV_Type_IsChanged=false;
      public string PCDV_Type
      {
         get{ return pCDV_Type; }
         set{ pCDV_Type = value; pCDV_Type_IsChanged=true; }
      }
      public bool PCDV_Type_IsChanged
      {
         get{ return pCDV_Type_IsChanged; }
         set{ pCDV_Type_IsChanged = value; }
      }
      private string pCDV_OType;
      private bool pCDV_OType_IsChanged=false;
      public string PCDV_OType
      {
         get{ return pCDV_OType; }
         set{ pCDV_OType = value; pCDV_OType_IsChanged=true; }
      }
      public bool PCDV_OType_IsChanged
      {
         get{ return pCDV_OType_IsChanged; }
         set{ pCDV_OType_IsChanged = value; }
      }
      private string pCDV_Object;
      private bool pCDV_Object_IsChanged=false;
      public string PCDV_Object
      {
         get{ return pCDV_Object; }
         set{ pCDV_Object = value; pCDV_Object_IsChanged=true; }
      }
      public bool PCDV_Object_IsChanged
      {
         get{ return pCDV_Object_IsChanged; }
         set{ pCDV_Object_IsChanged = value; }
      }
      private string pCDV_Content;
      private bool pCDV_Content_IsChanged=false;
      public string PCDV_Content
      {
         get{ return pCDV_Content; }
         set{ pCDV_Content = value; pCDV_Content_IsChanged=true; }
      }
      public bool PCDV_Content_IsChanged
      {
         get{ return pCDV_Content_IsChanged; }
         set{ pCDV_Content_IsChanged = value; }
      }
      private DateTime pCDV_Date;
      private bool pCDV_Date_IsChanged=false;
      public DateTime PCDV_Date
      {
         get{ return pCDV_Date; }
         set{ pCDV_Date = value; pCDV_Date_IsChanged=true; }
      }
      public bool PCDV_Date_IsChanged
      {
         get{ return pCDV_Date_IsChanged; }
         set{ pCDV_Date_IsChanged = value; }
      }
      private DateTime pCDV_ODate;
      private bool pCDV_ODate_IsChanged=false;
      public DateTime PCDV_ODate
      {
         get{ return pCDV_ODate; }
         set{ pCDV_ODate = value; pCDV_ODate_IsChanged=true; }
      }
      public bool PCDV_ODate_IsChanged
      {
         get{ return pCDV_ODate_IsChanged; }
         set{ pCDV_ODate_IsChanged = value; }
      }
      private string pCDV_FType;
      private bool pCDV_FType_IsChanged=false;
      public string PCDV_FType
      {
         get{ return pCDV_FType; }
         set{ pCDV_FType = value; pCDV_FType_IsChanged=true; }
      }
      public bool PCDV_FType_IsChanged
      {
         get{ return pCDV_FType_IsChanged; }
         set{ pCDV_FType_IsChanged = value; }
      }
      private string pCDV_FCode;
      private bool pCDV_FCode_IsChanged=false;
      public string PCDV_FCode
      {
         get{ return pCDV_FCode; }
         set{ pCDV_FCode = value; pCDV_FCode_IsChanged=true; }
      }
      public bool PCDV_FCode_IsChanged
      {
         get{ return pCDV_FCode_IsChanged; }
         set{ pCDV_FCode_IsChanged = value; }
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
