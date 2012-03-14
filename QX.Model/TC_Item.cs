using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 试块信息
   /// </summary>
   [Serializable]
   public partial class TC_Item
   {
      private decimal tCI_ID;
      private bool tCI_ID_IsChanged=false;
      public decimal TCI_ID
      {
         get{ return tCI_ID; }
         set{ tCI_ID = value; tCI_ID_IsChanged=true; }
      }
      public bool TCI_ID_IsChanged
      {
         get{ return tCI_ID_IsChanged; }
         set{ tCI_ID_IsChanged = value; }
      }
      private string tCI_Code;
      private bool tCI_Code_IsChanged=false;
      public string TCI_Code
      {
         get{ return tCI_Code; }
         set{ tCI_Code = value; tCI_Code_IsChanged=true; }
      }
      public bool TCI_Code_IsChanged
      {
         get{ return tCI_Code_IsChanged; }
         set{ tCI_Code_IsChanged = value; }
      }
      private string tCI_GroupCode;
      private bool tCI_GroupCode_IsChanged=false;
      public string TCI_GroupCode
      {
         get{ return tCI_GroupCode; }
         set{ tCI_GroupCode = value; tCI_GroupCode_IsChanged=true; }
      }
      public bool TCI_GroupCode_IsChanged
      {
         get{ return tCI_GroupCode_IsChanged; }
         set{ tCI_GroupCode_IsChanged = value; }
      }
      private string tCI_No;
      private bool tCI_No_IsChanged=false;
      public string TCI_No
      {
         get{ return tCI_No; }
         set{ tCI_No = value; tCI_No_IsChanged=true; }
      }
      public bool TCI_No_IsChanged
      {
         get{ return tCI_No_IsChanged; }
         set{ tCI_No_IsChanged = value; }
      }
      private string tCI_VCode;
      private bool tCI_VCode_IsChanged=false;
      public string TCI_VCode
      {
         get{ return tCI_VCode; }
         set{ tCI_VCode = value; tCI_VCode_IsChanged=true; }
      }
      public bool TCI_VCode_IsChanged
      {
         get{ return tCI_VCode_IsChanged; }
         set{ tCI_VCode_IsChanged = value; }
      }
      private string tCI_VName;
      private bool tCI_VName_IsChanged=false;
      public string TCI_VName
      {
         get{ return tCI_VName; }
         set{ tCI_VName = value; tCI_VName_IsChanged=true; }
      }
      public bool TCI_VName_IsChanged
      {
         get{ return tCI_VName_IsChanged; }
         set{ tCI_VName_IsChanged = value; }
      }
      private string tCI_Val;
      private bool tCI_Val_IsChanged=false;
      public string TCI_Val
      {
         get{ return tCI_Val; }
         set{ tCI_Val = value; tCI_Val_IsChanged=true; }
      }
      public bool TCI_Val_IsChanged
      {
         get{ return tCI_Val_IsChanged; }
         set{ tCI_Val_IsChanged = value; }
      }
      private string tCI_MVal;
      private bool tCI_MVal_IsChanged=false;
      public string TCI_MVal
      {
         get{ return tCI_MVal; }
         set{ tCI_MVal = value; tCI_MVal_IsChanged=true; }
      }
      public bool TCI_MVal_IsChanged
      {
         get{ return tCI_MVal_IsChanged; }
         set{ tCI_MVal_IsChanged = value; }
      }
      private string tCI_Base;
      private bool tCI_Base_IsChanged=false;
      public string TCI_Base
      {
         get{ return tCI_Base; }
         set{ tCI_Base = value; tCI_Base_IsChanged=true; }
      }
      public bool TCI_Base_IsChanged
      {
         get{ return tCI_Base_IsChanged; }
         set{ tCI_Base_IsChanged = value; }
      }
      private string tCI_RefValue;
      private bool tCI_RefValue_IsChanged=false;
      public string TCI_RefValue
      {
         get{ return tCI_RefValue; }
         set{ tCI_RefValue = value; tCI_RefValue_IsChanged=true; }
      }
      public bool TCI_RefValue_IsChanged
      {
         get{ return tCI_RefValue_IsChanged; }
         set{ tCI_RefValue_IsChanged = value; }
      }
      private string tCI_Conclusion;
      private bool tCI_Conclusion_IsChanged=false;
      public string TCI_Conclusion
      {
         get{ return tCI_Conclusion; }
         set{ tCI_Conclusion = value; tCI_Conclusion_IsChanged=true; }
      }
      public bool TCI_Conclusion_IsChanged
      {
         get{ return tCI_Conclusion_IsChanged; }
         set{ tCI_Conclusion_IsChanged = value; }
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
