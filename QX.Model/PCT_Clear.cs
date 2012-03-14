using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 打罐记录
   /// </summary>
   [Serializable]
   public partial class PCT_Clear
   {
      private decimal pCTC_ID;
      private bool pCTC_ID_IsChanged=false;
      public decimal PCTC_ID
      {
         get{ return pCTC_ID; }
         set{ pCTC_ID = value; pCTC_ID_IsChanged=true; }
      }
      public bool PCTC_ID_IsChanged
      {
         get{ return pCTC_ID_IsChanged; }
         set{ pCTC_ID_IsChanged = value; }
      }
      private string pCTC_Code;
      private bool pCTC_Code_IsChanged=false;
      public string PCTC_Code
      {
         get{ return pCTC_Code; }
         set{ pCTC_Code = value; pCTC_Code_IsChanged=true; }
      }
      public bool PCTC_Code_IsChanged
      {
         get{ return pCTC_Code_IsChanged; }
         set{ pCTC_Code_IsChanged = value; }
      }
      private string pCTC_GCode;
      private bool pCTC_GCode_IsChanged=false;
      public string PCTC_GCode
      {
         get{ return pCTC_GCode; }
         set{ pCTC_GCode = value; pCTC_GCode_IsChanged=true; }
      }
      public bool PCTC_GCode_IsChanged
      {
         get{ return pCTC_GCode_IsChanged; }
         set{ pCTC_GCode_IsChanged = value; }
      }
      private string pCTC_GNo;
      private bool pCTC_GNo_IsChanged=false;
      public string PCTC_GNo
      {
         get{ return pCTC_GNo; }
         set{ pCTC_GNo = value; pCTC_GNo_IsChanged=true; }
      }
      public bool PCTC_GNo_IsChanged
      {
         get{ return pCTC_GNo_IsChanged; }
         set{ pCTC_GNo_IsChanged = value; }
      }
      private string pCTC_BBak;
      private bool pCTC_BBak_IsChanged=false;
      public string PCTC_BBak
      {
         get{ return pCTC_BBak; }
         set{ pCTC_BBak = value; pCTC_BBak_IsChanged=true; }
      }
      public bool PCTC_BBak_IsChanged
      {
         get{ return pCTC_BBak_IsChanged; }
         set{ pCTC_BBak_IsChanged = value; }
      }
      private float pCTC_BWeight;
      private bool pCTC_BWeight_IsChanged=false;
      public float PCTC_BWeight
      {
         get{ return pCTC_BWeight; }
         set{ pCTC_BWeight = value; pCTC_BWeight_IsChanged=true; }
      }
      public bool PCTC_BWeight_IsChanged
      {
         get{ return pCTC_BWeight_IsChanged; }
         set{ pCTC_BWeight_IsChanged = value; }
      }
      private string pCTC_ABak;
      private bool pCTC_ABak_IsChanged=false;
      public string PCTC_ABak
      {
         get{ return pCTC_ABak; }
         set{ pCTC_ABak = value; pCTC_ABak_IsChanged=true; }
      }
      public bool PCTC_ABak_IsChanged
      {
         get{ return pCTC_ABak_IsChanged; }
         set{ pCTC_ABak_IsChanged = value; }
      }
      private float pCTC_AWeight;
      private bool pCTC_AWeight_IsChanged=false;
      public float PCTC_AWeight
      {
         get{ return pCTC_AWeight; }
         set{ pCTC_AWeight = value; pCTC_AWeight_IsChanged=true; }
      }
      public bool PCTC_AWeight_IsChanged
      {
         get{ return pCTC_AWeight_IsChanged; }
         set{ pCTC_AWeight_IsChanged = value; }
      }
      private string pCTC_Unit;
      private bool pCTC_Unit_IsChanged=false;
      public string PCTC_Unit
      {
         get{ return pCTC_Unit; }
         set{ pCTC_Unit = value; pCTC_Unit_IsChanged=true; }
      }
      public bool PCTC_Unit_IsChanged
      {
         get{ return pCTC_Unit_IsChanged; }
         set{ pCTC_Unit_IsChanged = value; }
      }
      private DateTime pCTC_Date;
      private bool pCTC_Date_IsChanged=false;
      public DateTime PCTC_Date
      {
         get{ return pCTC_Date; }
         set{ pCTC_Date = value; pCTC_Date_IsChanged=true; }
      }
      public bool PCTC_Date_IsChanged
      {
         get{ return pCTC_Date_IsChanged; }
         set{ pCTC_Date_IsChanged = value; }
      }
      private string pCTC_Bak;
      private bool pCTC_Bak_IsChanged=false;
      public string PCTC_Bak
      {
         get{ return pCTC_Bak; }
         set{ pCTC_Bak = value; pCTC_Bak_IsChanged=true; }
      }
      public bool PCTC_Bak_IsChanged
      {
         get{ return pCTC_Bak_IsChanged; }
         set{ pCTC_Bak_IsChanged = value; }
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
      private string pCTC_iType;
      private bool pCTC_iType_IsChanged=false;
      public string PCTC_iType
      {
         get{ return pCTC_iType; }
         set{ pCTC_iType = value; pCTC_iType_IsChanged=true; }
      }
      public bool PCTC_iType_IsChanged
      {
         get{ return pCTC_iType_IsChanged; }
         set{ pCTC_iType_IsChanged = value; }
      }
      private string pCTC_TCode;
      private bool pCTC_TCode_IsChanged=false;
      public string PCTC_TCode
      {
         get{ return pCTC_TCode; }
         set{ pCTC_TCode = value; pCTC_TCode_IsChanged=true; }
      }
      public bool PCTC_TCode_IsChanged
      {
         get{ return pCTC_TCode_IsChanged; }
         set{ pCTC_TCode_IsChanged = value; }
      }
      private string pCTC_Udef2;
      private bool pCTC_Udef2_IsChanged=false;
      public string PCTC_Udef2
      {
         get{ return pCTC_Udef2; }
         set{ pCTC_Udef2 = value; pCTC_Udef2_IsChanged=true; }
      }
      public bool PCTC_Udef2_IsChanged
      {
         get{ return pCTC_Udef2_IsChanged; }
         set{ pCTC_Udef2_IsChanged = value; }
      }
      private string pCTC_Udef3;
      private bool pCTC_Udef3_IsChanged=false;
      public string PCTC_Udef3
      {
         get{ return pCTC_Udef3; }
         set{ pCTC_Udef3 = value; pCTC_Udef3_IsChanged=true; }
      }
      public bool PCTC_Udef3_IsChanged
      {
         get{ return pCTC_Udef3_IsChanged; }
         set{ pCTC_Udef3_IsChanged = value; }
      }
   }
}
