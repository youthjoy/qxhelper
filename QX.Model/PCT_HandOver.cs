using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆交接班
   /// </summary>
   [Serializable]
   public partial class PCT_HandOver
   {
      private decimal pCTH_ID;
      private bool pCTH_ID_IsChanged=false;
      public decimal PCTH_ID
      {
         get{ return pCTH_ID; }
         set{ pCTH_ID = value; pCTH_ID_IsChanged=true; }
      }
      public bool PCTH_ID_IsChanged
      {
         get{ return pCTH_ID_IsChanged; }
         set{ pCTH_ID_IsChanged = value; }
      }
      private string pCTH_Code;
      private bool pCTH_Code_IsChanged=false;
      public string PCTH_Code
      {
         get{ return pCTH_Code; }
         set{ pCTH_Code = value; pCTH_Code_IsChanged=true; }
      }
      public bool PCTH_Code_IsChanged
      {
         get{ return pCTH_Code_IsChanged; }
         set{ pCTH_Code_IsChanged = value; }
      }
      private string pCTH_TCode;
      private bool pCTH_TCode_IsChanged=false;
      public string PCTH_TCode
      {
         get{ return pCTH_TCode; }
         set{ pCTH_TCode = value; pCTH_TCode_IsChanged=true; }
      }
      public bool PCTH_TCode_IsChanged
      {
         get{ return pCTH_TCode_IsChanged; }
         set{ pCTH_TCode_IsChanged = value; }
      }
      private string pCTH_TNo;
      private bool pCTH_TNo_IsChanged=false;
      public string PCTH_TNo
      {
         get{ return pCTH_TNo; }
         set{ pCTH_TNo = value; pCTH_TNo_IsChanged=true; }
      }
      public bool PCTH_TNo_IsChanged
      {
         get{ return pCTH_TNo_IsChanged; }
         set{ pCTH_TNo_IsChanged = value; }
      }
      private string pCTH_TName;
      private bool pCTH_TName_IsChanged=false;
      public string PCTH_TName
      {
         get{ return pCTH_TName; }
         set{ pCTH_TName = value; pCTH_TName_IsChanged=true; }
      }
      public bool PCTH_TName_IsChanged
      {
         get{ return pCTH_TName_IsChanged; }
         set{ pCTH_TName_IsChanged = value; }
      }
      private string pCTH_Type;
      private bool pCTH_Type_IsChanged=false;
      public string PCTH_Type
      {
         get{ return pCTH_Type; }
         set{ pCTH_Type = value; pCTH_Type_IsChanged=true; }
      }
      public bool PCTH_Type_IsChanged
      {
         get{ return pCTH_Type_IsChanged; }
         set{ pCTH_Type_IsChanged = value; }
      }
      private string pCTH_Key;
      private bool pCTH_Key_IsChanged=false;
      public string PCTH_Key
      {
         get{ return pCTH_Key; }
         set{ pCTH_Key = value; pCTH_Key_IsChanged=true; }
      }
      public bool PCTH_Key_IsChanged
      {
         get{ return pCTH_Key_IsChanged; }
         set{ pCTH_Key_IsChanged = value; }
      }
      private string pCTH_LDriver;
      private bool pCTH_LDriver_IsChanged=false;
      public string PCTH_LDriver
      {
         get{ return pCTH_LDriver; }
         set{ pCTH_LDriver = value; pCTH_LDriver_IsChanged=true; }
      }
      public bool PCTH_LDriver_IsChanged
      {
         get{ return pCTH_LDriver_IsChanged; }
         set{ pCTH_LDriver_IsChanged = value; }
      }
      private string pCTH_LDcode;
      private bool pCTH_LDcode_IsChanged=false;
      public string PCTH_LDcode
      {
         get{ return pCTH_LDcode; }
         set{ pCTH_LDcode = value; pCTH_LDcode_IsChanged=true; }
      }
      public bool PCTH_LDcode_IsChanged
      {
         get{ return pCTH_LDcode_IsChanged; }
         set{ pCTH_LDcode_IsChanged = value; }
      }
      private string pCTH_CDriver;
      private bool pCTH_CDriver_IsChanged=false;
      public string PCTH_CDriver
      {
         get{ return pCTH_CDriver; }
         set{ pCTH_CDriver = value; pCTH_CDriver_IsChanged=true; }
      }
      public bool PCTH_CDriver_IsChanged
      {
         get{ return pCTH_CDriver_IsChanged; }
         set{ pCTH_CDriver_IsChanged = value; }
      }
      private string pCTH_CDcode;
      private bool pCTH_CDcode_IsChanged=false;
      public string PCTH_CDcode
      {
         get{ return pCTH_CDcode; }
         set{ pCTH_CDcode = value; pCTH_CDcode_IsChanged=true; }
      }
      public bool PCTH_CDcode_IsChanged
      {
         get{ return pCTH_CDcode_IsChanged; }
         set{ pCTH_CDcode_IsChanged = value; }
      }
      private DateTime pCTH_JDate;
      private bool pCTH_JDate_IsChanged=false;
      public DateTime PCTH_JDate
      {
         get{ return pCTH_JDate; }
         set{ pCTH_JDate = value; pCTH_JDate_IsChanged=true; }
      }
      public bool PCTH_JDate_IsChanged
      {
         get{ return pCTH_JDate_IsChanged; }
         set{ pCTH_JDate_IsChanged = value; }
      }
      private DateTime pCTH_HDate;
      private bool pCTH_HDate_IsChanged=false;
      public DateTime PCTH_HDate
      {
         get{ return pCTH_HDate; }
         set{ pCTH_HDate = value; pCTH_HDate_IsChanged=true; }
      }
      public bool PCTH_HDate_IsChanged
      {
         get{ return pCTH_HDate_IsChanged; }
         set{ pCTH_HDate_IsChanged = value; }
      }
      private string pCTH_CStatus;
      private bool pCTH_CStatus_IsChanged=false;
      public string PCTH_CStatus
      {
         get{ return pCTH_CStatus; }
         set{ pCTH_CStatus = value; pCTH_CStatus_IsChanged=true; }
      }
      public bool PCTH_CStatus_IsChanged
      {
         get{ return pCTH_CStatus_IsChanged; }
         set{ pCTH_CStatus_IsChanged = value; }
      }
      private string pCTH_IsCurrent;
      private bool pCTH_IsCurrent_IsChanged=false;
      public string PCTH_IsCurrent
      {
         get{ return pCTH_IsCurrent; }
         set{ pCTH_IsCurrent = value; pCTH_IsCurrent_IsChanged=true; }
      }
      public bool PCTH_IsCurrent_IsChanged
      {
         get{ return pCTH_IsCurrent_IsChanged; }
         set{ pCTH_IsCurrent_IsChanged = value; }
      }
      private string pCTH_Date;
      private bool pCTH_Date_IsChanged=false;
      public string PCTH_Date
      {
         get{ return pCTH_Date; }
         set{ pCTH_Date = value; pCTH_Date_IsChanged=true; }
      }
      public bool PCTH_Date_IsChanged
      {
         get{ return pCTH_Date_IsChanged; }
         set{ pCTH_Date_IsChanged = value; }
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
