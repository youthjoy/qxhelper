using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_CompHistory
   {
      private decimal cH_ID;
      private bool cH_ID_IsChanged=false;
      public decimal CH_ID
      {
         get{ return cH_ID; }
         set{ cH_ID = value; cH_ID_IsChanged=true; }
      }
      public bool CH_ID_IsChanged
      {
         get{ return cH_ID_IsChanged; }
         set{ cH_ID_IsChanged = value; }
      }
      private string cH_Code;
      private bool cH_Code_IsChanged=false;
      public string CH_Code
      {
         get{ return cH_Code; }
         set{ cH_Code = value; cH_Code_IsChanged=true; }
      }
      public bool CH_Code_IsChanged
      {
         get{ return cH_Code_IsChanged; }
         set{ cH_Code_IsChanged = value; }
      }
      private string cH_CompCode;
      private bool cH_CompCode_IsChanged=false;
      public string CH_CompCode
      {
         get{ return cH_CompCode; }
         set{ cH_CompCode = value; cH_CompCode_IsChanged=true; }
      }
      public bool CH_CompCode_IsChanged
      {
         get{ return cH_CompCode_IsChanged; }
         set{ cH_CompCode_IsChanged = value; }
      }
      private string cH_Auditor;
      private bool cH_Auditor_IsChanged=false;
      public string CH_Auditor
      {
         get{ return cH_Auditor; }
         set{ cH_Auditor = value; cH_Auditor_IsChanged=true; }
      }
      public bool CH_Auditor_IsChanged
      {
         get{ return cH_Auditor_IsChanged; }
         set{ cH_Auditor_IsChanged = value; }
      }
      private string cH_AuditorName;
      private bool cH_AuditorName_IsChanged=false;
      public string CH_AuditorName
      {
         get{ return cH_AuditorName; }
         set{ cH_AuditorName = value; cH_AuditorName_IsChanged=true; }
      }
      public bool CH_AuditorName_IsChanged
      {
         get{ return cH_AuditorName_IsChanged; }
         set{ cH_AuditorName_IsChanged = value; }
      }
      private DateTime cH_Date;
      private bool cH_Date_IsChanged=false;
      public DateTime CH_Date
      {
         get{ return cH_Date; }
         set{ cH_Date = value; cH_Date_IsChanged=true; }
      }
      public bool CH_Date_IsChanged
      {
         get{ return cH_Date_IsChanged; }
         set{ cH_Date_IsChanged = value; }
      }
      private string cH_FilePath;
      private bool cH_FilePath_IsChanged=false;
      public string CH_FilePath
      {
         get{ return cH_FilePath; }
         set{ cH_FilePath = value; cH_FilePath_IsChanged=true; }
      }
      public bool CH_FilePath_IsChanged
      {
         get{ return cH_FilePath_IsChanged; }
         set{ cH_FilePath_IsChanged = value; }
      }
      private string cH_Type;
      private bool cH_Type_IsChanged=false;
      public string CH_Type
      {
         get{ return cH_Type; }
         set{ cH_Type = value; cH_Type_IsChanged=true; }
      }
      public bool CH_Type_IsChanged
      {
         get{ return cH_Type_IsChanged; }
         set{ cH_Type_IsChanged = value; }
      }
      private string cH_iType;
      private bool cH_iType_IsChanged=false;
      public string CH_iType
      {
         get{ return cH_iType; }
         set{ cH_iType = value; cH_iType_IsChanged=true; }
      }
      public bool CH_iType_IsChanged
      {
         get{ return cH_iType_IsChanged; }
         set{ cH_iType_IsChanged = value; }
      }
      private string cH_Stat;
      private bool cH_Stat_IsChanged=false;
      public string CH_Stat
      {
         get{ return cH_Stat; }
         set{ cH_Stat = value; cH_Stat_IsChanged=true; }
      }
      public bool CH_Stat_IsChanged
      {
         get{ return cH_Stat_IsChanged; }
         set{ cH_Stat_IsChanged = value; }
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
   }
}
