using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Doc_Attachment
   {
      private decimal dat_ID;
      private bool dat_ID_IsChanged=false;
      public decimal Dat_ID
      {
         get{ return dat_ID; }
         set{ dat_ID = value; dat_ID_IsChanged=true; }
      }
      public bool Dat_ID_IsChanged
      {
         get{ return dat_ID_IsChanged; }
         set{ dat_ID_IsChanged = value; }
      }
      private string dat_Code;
      private bool dat_Code_IsChanged=false;
      public string Dat_Code
      {
         get{ return dat_Code; }
         set{ dat_Code = value; dat_Code_IsChanged=true; }
      }
      public bool Dat_Code_IsChanged
      {
         get{ return dat_Code_IsChanged; }
         set{ dat_Code_IsChanged = value; }
      }
      private string dat_Name;
      private bool dat_Name_IsChanged=false;
      public string Dat_Name
      {
         get{ return dat_Name; }
         set{ dat_Name = value; dat_Name_IsChanged=true; }
      }
      public bool Dat_Name_IsChanged
      {
         get{ return dat_Name_IsChanged; }
         set{ dat_Name_IsChanged = value; }
      }
      private string dat_Path;
      private bool dat_Path_IsChanged=false;
      public string Dat_Path
      {
         get{ return dat_Path; }
         set{ dat_Path = value; dat_Path_IsChanged=true; }
      }
      public bool Dat_Path_IsChanged
      {
         get{ return dat_Path_IsChanged; }
         set{ dat_Path_IsChanged = value; }
      }
      private string dat_Module;
      private bool dat_Module_IsChanged=false;
      public string Dat_Module
      {
         get{ return dat_Module; }
         set{ dat_Module = value; dat_Module_IsChanged=true; }
      }
      public bool Dat_Module_IsChanged
      {
         get{ return dat_Module_IsChanged; }
         set{ dat_Module_IsChanged = value; }
      }
      private string dat_RefCode;
      private bool dat_RefCode_IsChanged=false;
      public string Dat_RefCode
      {
         get{ return dat_RefCode; }
         set{ dat_RefCode = value; dat_RefCode_IsChanged=true; }
      }
      public bool Dat_RefCode_IsChanged
      {
         get{ return dat_RefCode_IsChanged; }
         set{ dat_RefCode_IsChanged = value; }
      }
      private string dat_Type;
      private bool dat_Type_IsChanged=false;
      public string Dat_Type
      {
         get{ return dat_Type; }
         set{ dat_Type = value; dat_Type_IsChanged=true; }
      }
      public bool Dat_Type_IsChanged
      {
         get{ return dat_Type_IsChanged; }
         set{ dat_Type_IsChanged = value; }
      }
      private string dat_Stat;
      private bool dat_Stat_IsChanged=false;
      public string Dat_Stat
      {
         get{ return dat_Stat; }
         set{ dat_Stat = value; dat_Stat_IsChanged=true; }
      }
      public bool Dat_Stat_IsChanged
      {
         get{ return dat_Stat_IsChanged; }
         set{ dat_Stat_IsChanged = value; }
      }
      private int dat_Order;
      private bool dat_Order_IsChanged=false;
      public int Dat_Order
      {
         get{ return dat_Order; }
         set{ dat_Order = value; dat_Order_IsChanged=true; }
      }
      public bool Dat_Order_IsChanged
      {
         get{ return dat_Order_IsChanged; }
         set{ dat_Order_IsChanged = value; }
      }
      private DateTime dat_Date;
      private bool dat_Date_IsChanged=false;
      public DateTime Dat_Date
      {
         get{ return dat_Date; }
         set{ dat_Date = value; dat_Date_IsChanged=true; }
      }
      public bool Dat_Date_IsChanged
      {
         get{ return dat_Date_IsChanged; }
         set{ dat_Date_IsChanged = value; }
      }
      private string dat_Creator;
      private bool dat_Creator_IsChanged=false;
      public string Dat_Creator
      {
         get{ return dat_Creator; }
         set{ dat_Creator = value; dat_Creator_IsChanged=true; }
      }
      public bool Dat_Creator_IsChanged
      {
         get{ return dat_Creator_IsChanged; }
         set{ dat_Creator_IsChanged = value; }
      }
      private string dat_CreatorName;
      private bool dat_CreatorName_IsChanged=false;
      public string Dat_CreatorName
      {
         get{ return dat_CreatorName; }
         set{ dat_CreatorName = value; dat_CreatorName_IsChanged=true; }
      }
      public bool Dat_CreatorName_IsChanged
      {
         get{ return dat_CreatorName_IsChanged; }
         set{ dat_CreatorName_IsChanged = value; }
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
