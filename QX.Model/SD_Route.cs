using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 路线规划明细
   /// </summary>
   [Serializable]
   public partial class SD_Route
   {
      private decimal sR_ID;
      private bool sR_ID_IsChanged=false;
      public decimal SR_ID
      {
         get{ return sR_ID; }
         set{ sR_ID = value; sR_ID_IsChanged=true; }
      }
      public bool SR_ID_IsChanged
      {
         get{ return sR_ID_IsChanged; }
         set{ sR_ID_IsChanged = value; }
      }
      private string sR_Code;
      private bool sR_Code_IsChanged=false;
      public string SR_Code
      {
         get{ return sR_Code; }
         set{ sR_Code = value; sR_Code_IsChanged=true; }
      }
      public bool SR_Code_IsChanged
      {
         get{ return sR_Code_IsChanged; }
         set{ sR_Code_IsChanged = value; }
      }
      private decimal sR_Longtitude;
      private bool sR_Longtitude_IsChanged=false;
      public decimal SR_Longtitude
      {
         get{ return sR_Longtitude; }
         set{ sR_Longtitude = value; sR_Longtitude_IsChanged=true; }
      }
      public bool SR_Longtitude_IsChanged
      {
         get{ return sR_Longtitude_IsChanged; }
         set{ sR_Longtitude_IsChanged = value; }
      }
      private decimal sR_Latitude;
      private bool sR_Latitude_IsChanged=false;
      public decimal SR_Latitude
      {
         get{ return sR_Latitude; }
         set{ sR_Latitude = value; sR_Latitude_IsChanged=true; }
      }
      public bool SR_Latitude_IsChanged
      {
         get{ return sR_Latitude_IsChanged; }
         set{ sR_Latitude_IsChanged = value; }
      }
      private string sR_UDEF_1;
      private bool sR_UDEF_1_IsChanged=false;
      public string SR_UDEF_1
      {
         get{ return sR_UDEF_1; }
         set{ sR_UDEF_1 = value; sR_UDEF_1_IsChanged=true; }
      }
      public bool SR_UDEF_1_IsChanged
      {
         get{ return sR_UDEF_1_IsChanged; }
         set{ sR_UDEF_1_IsChanged = value; }
      }
      private string sR_UDEF_2;
      private bool sR_UDEF_2_IsChanged=false;
      public string SR_UDEF_2
      {
         get{ return sR_UDEF_2; }
         set{ sR_UDEF_2 = value; sR_UDEF_2_IsChanged=true; }
      }
      public bool SR_UDEF_2_IsChanged
      {
         get{ return sR_UDEF_2_IsChanged; }
         set{ sR_UDEF_2_IsChanged = value; }
      }
      private string sR_UDEF_3;
      private bool sR_UDEF_3_IsChanged=false;
      public string SR_UDEF_3
      {
         get{ return sR_UDEF_3; }
         set{ sR_UDEF_3 = value; sR_UDEF_3_IsChanged=true; }
      }
      public bool SR_UDEF_3_IsChanged
      {
         get{ return sR_UDEF_3_IsChanged; }
         set{ sR_UDEF_3_IsChanged = value; }
      }
      private string sR_UDEF_4;
      private bool sR_UDEF_4_IsChanged=false;
      public string SR_UDEF_4
      {
         get{ return sR_UDEF_4; }
         set{ sR_UDEF_4 = value; sR_UDEF_4_IsChanged=true; }
      }
      public bool SR_UDEF_4_IsChanged
      {
         get{ return sR_UDEF_4_IsChanged; }
         set{ sR_UDEF_4_IsChanged = value; }
      }
      private string sR_UDEF_5;
      private bool sR_UDEF_5_IsChanged=false;
      public string SR_UDEF_5
      {
         get{ return sR_UDEF_5; }
         set{ sR_UDEF_5 = value; sR_UDEF_5_IsChanged=true; }
      }
      public bool SR_UDEF_5_IsChanged
      {
         get{ return sR_UDEF_5_IsChanged; }
         set{ sR_UDEF_5_IsChanged = value; }
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
