using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_Group
   {
      private decimal gP_ID;
      private bool gP_ID_IsChanged=false;
      public decimal GP_ID
      {
         get{ return gP_ID; }
         set{ gP_ID = value; gP_ID_IsChanged=true; }
      }
      public bool GP_ID_IsChanged
      {
         get{ return gP_ID_IsChanged; }
         set{ gP_ID_IsChanged = value; }
      }
      private string gP_Code;
      private bool gP_Code_IsChanged=false;
      public string GP_Code
      {
         get{ return gP_Code; }
         set{ gP_Code = value; gP_Code_IsChanged=true; }
      }
      public bool GP_Code_IsChanged
      {
         get{ return gP_Code_IsChanged; }
         set{ gP_Code_IsChanged = value; }
      }
      private string gP_Name;
      private bool gP_Name_IsChanged=false;
      public string GP_Name
      {
         get{ return gP_Name; }
         set{ gP_Name = value; gP_Name_IsChanged=true; }
      }
      public bool GP_Name_IsChanged
      {
         get{ return gP_Name_IsChanged; }
         set{ gP_Name_IsChanged = value; }
      }
      private string gP_iType;
      private bool gP_iType_IsChanged=false;
      public string GP_iType
      {
         get{ return gP_iType; }
         set{ gP_iType = value; gP_iType_IsChanged=true; }
      }
      public bool GP_iType_IsChanged
      {
         get{ return gP_iType_IsChanged; }
         set{ gP_iType_IsChanged = value; }
      }
      private string gP_Creator;
      private bool gP_Creator_IsChanged=false;
      public string GP_Creator
      {
         get{ return gP_Creator; }
         set{ gP_Creator = value; gP_Creator_IsChanged=true; }
      }
      public bool GP_Creator_IsChanged
      {
         get{ return gP_Creator_IsChanged; }
         set{ gP_Creator_IsChanged = value; }
      }
      private string gP_CreatorName;
      private bool gP_CreatorName_IsChanged=false;
      public string GP_CreatorName
      {
         get{ return gP_CreatorName; }
         set{ gP_CreatorName = value; gP_CreatorName_IsChanged=true; }
      }
      public bool GP_CreatorName_IsChanged
      {
         get{ return gP_CreatorName_IsChanged; }
         set{ gP_CreatorName_IsChanged = value; }
      }
      private DateTime gP_Date;
      private bool gP_Date_IsChanged=false;
      public DateTime GP_Date
      {
         get{ return gP_Date; }
         set{ gP_Date = value; gP_Date_IsChanged=true; }
      }
      public bool GP_Date_IsChanged
      {
         get{ return gP_Date_IsChanged; }
         set{ gP_Date_IsChanged = value; }
      }
      private string gP_Type;
      private bool gP_Type_IsChanged=false;
      public string GP_Type
      {
         get{ return gP_Type; }
         set{ gP_Type = value; gP_Type_IsChanged=true; }
      }
      public bool GP_Type_IsChanged
      {
         get{ return gP_Type_IsChanged; }
         set{ gP_Type_IsChanged = value; }
      }
      private string gP_TypeName;
      private bool gP_TypeName_IsChanged=false;
      public string GP_TypeName
      {
         get{ return gP_TypeName; }
         set{ gP_TypeName = value; gP_TypeName_IsChanged=true; }
      }
      public bool GP_TypeName_IsChanged
      {
         get{ return gP_TypeName_IsChanged; }
         set{ gP_TypeName_IsChanged = value; }
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
