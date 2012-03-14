using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Assets_Apply
   {
      private decimal assetsApply_ID;
      private bool assetsApply_ID_IsChanged=false;
      public decimal AssetsApply_ID
      {
         get{ return assetsApply_ID; }
         set{ assetsApply_ID = value; assetsApply_ID_IsChanged=true; }
      }
      public bool AssetsApply_ID_IsChanged
      {
         get{ return assetsApply_ID_IsChanged; }
         set{ assetsApply_ID_IsChanged = value; }
      }
      private string assetsApply_Code;
      private bool assetsApply_Code_IsChanged=false;
      public string AssetsApply_Code
      {
         get{ return assetsApply_Code; }
         set{ assetsApply_Code = value; assetsApply_Code_IsChanged=true; }
      }
      public bool AssetsApply_Code_IsChanged
      {
         get{ return assetsApply_Code_IsChanged; }
         set{ assetsApply_Code_IsChanged = value; }
      }
      private string assetsApply_AppPerson;
      private bool assetsApply_AppPerson_IsChanged=false;
      public string AssetsApply_AppPerson
      {
         get{ return assetsApply_AppPerson; }
         set{ assetsApply_AppPerson = value; assetsApply_AppPerson_IsChanged=true; }
      }
      public bool AssetsApply_AppPerson_IsChanged
      {
         get{ return assetsApply_AppPerson_IsChanged; }
         set{ assetsApply_AppPerson_IsChanged = value; }
      }
      private string assetsApply_AppDept;
      private bool assetsApply_AppDept_IsChanged=false;
      public string AssetsApply_AppDept
      {
         get{ return assetsApply_AppDept; }
         set{ assetsApply_AppDept = value; assetsApply_AppDept_IsChanged=true; }
      }
      public bool AssetsApply_AppDept_IsChanged
      {
         get{ return assetsApply_AppDept_IsChanged; }
         set{ assetsApply_AppDept_IsChanged = value; }
      }
      private string assetsApply_AppName;
      private bool assetsApply_AppName_IsChanged=false;
      public string AssetsApply_AppName
      {
         get{ return assetsApply_AppName; }
         set{ assetsApply_AppName = value; assetsApply_AppName_IsChanged=true; }
      }
      public bool AssetsApply_AppName_IsChanged
      {
         get{ return assetsApply_AppName_IsChanged; }
         set{ assetsApply_AppName_IsChanged = value; }
      }
      private string assetsApply_Parameter;
      private bool assetsApply_Parameter_IsChanged=false;
      public string AssetsApply_Parameter
      {
         get{ return assetsApply_Parameter; }
         set{ assetsApply_Parameter = value; assetsApply_Parameter_IsChanged=true; }
      }
      public bool AssetsApply_Parameter_IsChanged
      {
         get{ return assetsApply_Parameter_IsChanged; }
         set{ assetsApply_Parameter_IsChanged = value; }
      }
      private string assetsApply_Description;
      private bool assetsApply_Description_IsChanged=false;
      public string AssetsApply_Description
      {
         get{ return assetsApply_Description; }
         set{ assetsApply_Description = value; assetsApply_Description_IsChanged=true; }
      }
      public bool AssetsApply_Description_IsChanged
      {
         get{ return assetsApply_Description_IsChanged; }
         set{ assetsApply_Description_IsChanged = value; }
      }
      private int assetsApply_AppCount;
      private bool assetsApply_AppCount_IsChanged=false;
      public int AssetsApply_AppCount
      {
         get{ return assetsApply_AppCount; }
         set{ assetsApply_AppCount = value; assetsApply_AppCount_IsChanged=true; }
      }
      public bool AssetsApply_AppCount_IsChanged
      {
         get{ return assetsApply_AppCount_IsChanged; }
         set{ assetsApply_AppCount_IsChanged = value; }
      }
      private string assetsApply_Type;
      private bool assetsApply_Type_IsChanged=false;
      public string AssetsApply_Type
      {
         get{ return assetsApply_Type; }
         set{ assetsApply_Type = value; assetsApply_Type_IsChanged=true; }
      }
      public bool AssetsApply_Type_IsChanged
      {
         get{ return assetsApply_Type_IsChanged; }
         set{ assetsApply_Type_IsChanged = value; }
      }
      private string assetsApply_AppType;
      private bool assetsApply_AppType_IsChanged=false;
      public string AssetsApply_AppType
      {
         get{ return assetsApply_AppType; }
         set{ assetsApply_AppType = value; assetsApply_AppType_IsChanged=true; }
      }
      public bool AssetsApply_AppType_IsChanged
      {
         get{ return assetsApply_AppType_IsChanged; }
         set{ assetsApply_AppType_IsChanged = value; }
      }
      private DateTime assetsApply_Date;
      private bool assetsApply_Date_IsChanged=false;
      public DateTime AssetsApply_Date
      {
         get{ return assetsApply_Date; }
         set{ assetsApply_Date = value; assetsApply_Date_IsChanged=true; }
      }
      public bool AssetsApply_Date_IsChanged
      {
         get{ return assetsApply_Date_IsChanged; }
         set{ assetsApply_Date_IsChanged = value; }
      }
      private string assetsApply_AudistStat;
      private bool assetsApply_AudistStat_IsChanged=false;
      public string AssetsApply_AudistStat
      {
         get{ return assetsApply_AudistStat; }
         set{ assetsApply_AudistStat = value; assetsApply_AudistStat_IsChanged=true; }
      }
      public bool AssetsApply_AudistStat_IsChanged
      {
         get{ return assetsApply_AudistStat_IsChanged; }
         set{ assetsApply_AudistStat_IsChanged = value; }
      }
      private string assetsApply_Stat;
      private bool assetsApply_Stat_IsChanged=false;
      public string AssetsApply_Stat
      {
         get{ return assetsApply_Stat; }
         set{ assetsApply_Stat = value; assetsApply_Stat_IsChanged=true; }
      }
      public bool AssetsApply_Stat_IsChanged
      {
         get{ return assetsApply_Stat_IsChanged; }
         set{ assetsApply_Stat_IsChanged = value; }
      }
      private string assetsApply_Remark;
      private bool assetsApply_Remark_IsChanged=false;
      public string AssetsApply_Remark
      {
         get{ return assetsApply_Remark; }
         set{ assetsApply_Remark = value; assetsApply_Remark_IsChanged=true; }
      }
      public bool AssetsApply_Remark_IsChanged
      {
         get{ return assetsApply_Remark_IsChanged; }
         set{ assetsApply_Remark_IsChanged = value; }
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
   }
}
