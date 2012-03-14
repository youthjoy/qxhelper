using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class TC_SJComp
   {
      private decimal tCJ_ID;
      private bool tCJ_ID_IsChanged=false;
      public decimal TCJ_ID
      {
         get{ return tCJ_ID; }
         set{ tCJ_ID = value; tCJ_ID_IsChanged=true; }
      }
      public bool TCJ_ID_IsChanged
      {
         get{ return tCJ_ID_IsChanged; }
         set{ tCJ_ID_IsChanged = value; }
      }
      private string tCJ_Code;
      private bool tCJ_Code_IsChanged=false;
      public string TCJ_Code
      {
         get{ return tCJ_Code; }
         set{ tCJ_Code = value; tCJ_Code_IsChanged=true; }
      }
      public bool TCJ_Code_IsChanged
      {
         get{ return tCJ_Code_IsChanged; }
         set{ tCJ_Code_IsChanged = value; }
      }
      private string tCJ_Name;
      private bool tCJ_Name_IsChanged=false;
      public string TCJ_Name
      {
         get{ return tCJ_Name; }
         set{ tCJ_Name = value; tCJ_Name_IsChanged=true; }
      }
      public bool TCJ_Name_IsChanged
      {
         get{ return tCJ_Name_IsChanged; }
         set{ tCJ_Name_IsChanged = value; }
      }
      private string tCJ_PLine;
      private bool tCJ_PLine_IsChanged=false;
      public string TCJ_PLine
      {
         get{ return tCJ_PLine; }
         set{ tCJ_PLine = value; tCJ_PLine_IsChanged=true; }
      }
      public bool TCJ_PLine_IsChanged
      {
         get{ return tCJ_PLine_IsChanged; }
         set{ tCJ_PLine_IsChanged = value; }
      }
      private string tCJ_Stat;
      private bool tCJ_Stat_IsChanged=false;
      public string TCJ_Stat
      {
         get{ return tCJ_Stat; }
         set{ tCJ_Stat = value; tCJ_Stat_IsChanged=true; }
      }
      public bool TCJ_Stat_IsChanged
      {
         get{ return tCJ_Stat_IsChanged; }
         set{ tCJ_Stat_IsChanged = value; }
      }
      /// <summary>
      /// ??
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// ??
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// ??
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
      private string tCJ_Udef1;
      private bool tCJ_Udef1_IsChanged=false;
      public string TCJ_Udef1
      {
         get{ return tCJ_Udef1; }
         set{ tCJ_Udef1 = value; tCJ_Udef1_IsChanged=true; }
      }
      public bool TCJ_Udef1_IsChanged
      {
         get{ return tCJ_Udef1_IsChanged; }
         set{ tCJ_Udef1_IsChanged = value; }
      }
      private string tCJ_Udef2;
      private bool tCJ_Udef2_IsChanged=false;
      public string TCJ_Udef2
      {
         get{ return tCJ_Udef2; }
         set{ tCJ_Udef2 = value; tCJ_Udef2_IsChanged=true; }
      }
      public bool TCJ_Udef2_IsChanged
      {
         get{ return tCJ_Udef2_IsChanged; }
         set{ tCJ_Udef2_IsChanged = value; }
      }
      private string tCJ_Udef3;
      private bool tCJ_Udef3_IsChanged=false;
      public string TCJ_Udef3
      {
         get{ return tCJ_Udef3; }
         set{ tCJ_Udef3 = value; tCJ_Udef3_IsChanged=true; }
      }
      public bool TCJ_Udef3_IsChanged
      {
         get{ return tCJ_Udef3_IsChanged; }
         set{ tCJ_Udef3_IsChanged = value; }
      }
      private string tCJ_Udef4;
      private bool tCJ_Udef4_IsChanged=false;
      public string TCJ_Udef4
      {
         get{ return tCJ_Udef4; }
         set{ tCJ_Udef4 = value; tCJ_Udef4_IsChanged=true; }
      }
      public bool TCJ_Udef4_IsChanged
      {
         get{ return tCJ_Udef4_IsChanged; }
         set{ tCJ_Udef4_IsChanged = value; }
      }
      private string tCJ_Udef5;
      private bool tCJ_Udef5_IsChanged=false;
      public string TCJ_Udef5
      {
         get{ return tCJ_Udef5; }
         set{ tCJ_Udef5 = value; tCJ_Udef5_IsChanged=true; }
      }
      public bool TCJ_Udef5_IsChanged
      {
         get{ return tCJ_Udef5_IsChanged; }
         set{ tCJ_Udef5_IsChanged = value; }
      }
   }
}
