using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Doc_Allot
   {
      private decimal dA_ID;
      private bool dA_ID_IsChanged=false;
      public decimal DA_ID
      {
         get{ return dA_ID; }
         set{ dA_ID = value; dA_ID_IsChanged=true; }
      }
      public bool DA_ID_IsChanged
      {
         get{ return dA_ID_IsChanged; }
         set{ dA_ID_IsChanged = value; }
      }
      private string dA_Code;
      private bool dA_Code_IsChanged=false;
      public string DA_Code
      {
         get{ return dA_Code; }
         set{ dA_Code = value; dA_Code_IsChanged=true; }
      }
      public bool DA_Code_IsChanged
      {
         get{ return dA_Code_IsChanged; }
         set{ dA_Code_IsChanged = value; }
      }
      private string dA_DocCode;
      private bool dA_DocCode_IsChanged=false;
      public string DA_DocCode
      {
         get{ return dA_DocCode; }
         set{ dA_DocCode = value; dA_DocCode_IsChanged=true; }
      }
      public bool DA_DocCode_IsChanged
      {
         get{ return dA_DocCode_IsChanged; }
         set{ dA_DocCode_IsChanged = value; }
      }
      private string dA_Module;
      private bool dA_Module_IsChanged=false;
      public string DA_Module
      {
         get{ return dA_Module; }
         set{ dA_Module = value; dA_Module_IsChanged=true; }
      }
      public bool DA_Module_IsChanged
      {
         get{ return dA_Module_IsChanged; }
         set{ dA_Module_IsChanged = value; }
      }
      private string dA_IsHandle;
      private bool dA_IsHandle_IsChanged=false;
      public string DA_IsHandle
      {
         get{ return dA_IsHandle; }
         set{ dA_IsHandle = value; dA_IsHandle_IsChanged=true; }
      }
      public bool DA_IsHandle_IsChanged
      {
         get{ return dA_IsHandle_IsChanged; }
         set{ dA_IsHandle_IsChanged = value; }
      }
      private string dA_IsHandleName;
      private bool dA_IsHandleName_IsChanged=false;
      public string DA_IsHandleName
      {
         get{ return dA_IsHandleName; }
         set{ dA_IsHandleName = value; dA_IsHandleName_IsChanged=true; }
      }
      public bool DA_IsHandleName_IsChanged
      {
         get{ return dA_IsHandleName_IsChanged; }
         set{ dA_IsHandleName_IsChanged = value; }
      }
      private DateTime dA_Date;
      private bool dA_Date_IsChanged=false;
      public DateTime DA_Date
      {
         get{ return dA_Date; }
         set{ dA_Date = value; dA_Date_IsChanged=true; }
      }
      public bool DA_Date_IsChanged
      {
         get{ return dA_Date_IsChanged; }
         set{ dA_Date_IsChanged = value; }
      }
      private string dA_Opinion;
      private bool dA_Opinion_IsChanged=false;
      public string DA_Opinion
      {
         get{ return dA_Opinion; }
         set{ dA_Opinion = value; dA_Opinion_IsChanged=true; }
      }
      public bool DA_Opinion_IsChanged
      {
         get{ return dA_Opinion_IsChanged; }
         set{ dA_Opinion_IsChanged = value; }
      }
      private string dA_Allot;
      private bool dA_Allot_IsChanged=false;
      public string DA_Allot
      {
         get{ return dA_Allot; }
         set{ dA_Allot = value; dA_Allot_IsChanged=true; }
      }
      public bool DA_Allot_IsChanged
      {
         get{ return dA_Allot_IsChanged; }
         set{ dA_Allot_IsChanged = value; }
      }
      private string dA_Account;
      private bool dA_Account_IsChanged=false;
      public string DA_Account
      {
         get{ return dA_Account; }
         set{ dA_Account = value; dA_Account_IsChanged=true; }
      }
      public bool DA_Account_IsChanged
      {
         get{ return dA_Account_IsChanged; }
         set{ dA_Account_IsChanged = value; }
      }
      private string dA_Type;
      private bool dA_Type_IsChanged=false;
      public string DA_Type
      {
         get{ return dA_Type; }
         set{ dA_Type = value; dA_Type_IsChanged=true; }
      }
      public bool DA_Type_IsChanged
      {
         get{ return dA_Type_IsChanged; }
         set{ dA_Type_IsChanged = value; }
      }
      private string dA_TypeName;
      private bool dA_TypeName_IsChanged=false;
      public string DA_TypeName
      {
         get{ return dA_TypeName; }
         set{ dA_TypeName = value; dA_TypeName_IsChanged=true; }
      }
      public bool DA_TypeName_IsChanged
      {
         get{ return dA_TypeName_IsChanged; }
         set{ dA_TypeName_IsChanged = value; }
      }
      private string dA_iType;
      private bool dA_iType_IsChanged=false;
      public string DA_iType
      {
         get{ return dA_iType; }
         set{ dA_iType = value; dA_iType_IsChanged=true; }
      }
      public bool DA_iType_IsChanged
      {
         get{ return dA_iType_IsChanged; }
         set{ dA_iType_IsChanged = value; }
      }
      private string dA_RefCode;
      private bool dA_RefCode_IsChanged=false;
      public string DA_RefCode
      {
         get{ return dA_RefCode; }
         set{ dA_RefCode = value; dA_RefCode_IsChanged=true; }
      }
      public bool DA_RefCode_IsChanged
      {
         get{ return dA_RefCode_IsChanged; }
         set{ dA_RefCode_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private DateTime createTime;
      private bool createTime_IsChanged=false;
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
      private DateTime updateTime;
      private bool updateTime_IsChanged=false;
      public DateTime UpdateTime
      {
         get{ return updateTime; }
         set{ updateTime = value; updateTime_IsChanged=true; }
      }
      public bool UpdateTime_IsChanged
      {
         get{ return updateTime_IsChanged; }
         set{ updateTime_IsChanged = value; }
      }
      private DateTime deleteTime;
      private bool deleteTime_IsChanged=false;
      public DateTime DeleteTime
      {
         get{ return deleteTime; }
         set{ deleteTime = value; deleteTime_IsChanged=true; }
      }
      public bool DeleteTime_IsChanged
      {
         get{ return deleteTime_IsChanged; }
         set{ deleteTime_IsChanged = value; }
      }
      private string dA_Udef1;
      private bool dA_Udef1_IsChanged=false;
      public string DA_Udef1
      {
         get{ return dA_Udef1; }
         set{ dA_Udef1 = value; dA_Udef1_IsChanged=true; }
      }
      public bool DA_Udef1_IsChanged
      {
         get{ return dA_Udef1_IsChanged; }
         set{ dA_Udef1_IsChanged = value; }
      }
      private string dA_Udef2;
      private bool dA_Udef2_IsChanged=false;
      public string DA_Udef2
      {
         get{ return dA_Udef2; }
         set{ dA_Udef2 = value; dA_Udef2_IsChanged=true; }
      }
      public bool DA_Udef2_IsChanged
      {
         get{ return dA_Udef2_IsChanged; }
         set{ dA_Udef2_IsChanged = value; }
      }
      private string dA_Udef3;
      private bool dA_Udef3_IsChanged=false;
      public string DA_Udef3
      {
         get{ return dA_Udef3; }
         set{ dA_Udef3 = value; dA_Udef3_IsChanged=true; }
      }
      public bool DA_Udef3_IsChanged
      {
         get{ return dA_Udef3_IsChanged; }
         set{ dA_Udef3_IsChanged = value; }
      }
   }
}
