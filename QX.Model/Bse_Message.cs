using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_Message
   {
      private decimal msg_ID;
      private bool msg_ID_IsChanged=false;
      public decimal Msg_ID
      {
         get{ return msg_ID; }
         set{ msg_ID = value; msg_ID_IsChanged=true; }
      }
      public bool Msg_ID_IsChanged
      {
         get{ return msg_ID_IsChanged; }
         set{ msg_ID_IsChanged = value; }
      }
      private string msg_Code;
      private bool msg_Code_IsChanged=false;
      public string Msg_Code
      {
         get{ return msg_Code; }
         set{ msg_Code = value; msg_Code_IsChanged=true; }
      }
      public bool Msg_Code_IsChanged
      {
         get{ return msg_Code_IsChanged; }
         set{ msg_Code_IsChanged = value; }
      }
      private string msg_Content;
      private bool msg_Content_IsChanged=false;
      public string Msg_Content
      {
         get{ return msg_Content; }
         set{ msg_Content = value; msg_Content_IsChanged=true; }
      }
      public bool Msg_Content_IsChanged
      {
         get{ return msg_Content_IsChanged; }
         set{ msg_Content_IsChanged = value; }
      }
      private string msg_iType;
      private bool msg_iType_IsChanged=false;
      public string Msg_iType
      {
         get{ return msg_iType; }
         set{ msg_iType = value; msg_iType_IsChanged=true; }
      }
      public bool Msg_iType_IsChanged
      {
         get{ return msg_iType_IsChanged; }
         set{ msg_iType_IsChanged = value; }
      }
      private string msg_Type;
      private bool msg_Type_IsChanged=false;
      public string Msg_Type
      {
         get{ return msg_Type; }
         set{ msg_Type = value; msg_Type_IsChanged=true; }
      }
      public bool Msg_Type_IsChanged
      {
         get{ return msg_Type_IsChanged; }
         set{ msg_Type_IsChanged = value; }
      }
      private string msg_Stat;
      private bool msg_Stat_IsChanged=false;
      public string Msg_Stat
      {
         get{ return msg_Stat; }
         set{ msg_Stat = value; msg_Stat_IsChanged=true; }
      }
      public bool Msg_Stat_IsChanged
      {
         get{ return msg_Stat_IsChanged; }
         set{ msg_Stat_IsChanged = value; }
      }
      private string msg_IsShow;
      private bool msg_IsShow_IsChanged=false;
      public string Msg_IsShow
      {
         get{ return msg_IsShow; }
         set{ msg_IsShow = value; msg_IsShow_IsChanged=true; }
      }
      public bool Msg_IsShow_IsChanged
      {
         get{ return msg_IsShow_IsChanged; }
         set{ msg_IsShow_IsChanged = value; }
      }
      private string msg_IsShowName;
      private bool msg_IsShowName_IsChanged=false;
      public string Msg_IsShowName
      {
         get{ return msg_IsShowName; }
         set{ msg_IsShowName = value; msg_IsShowName_IsChanged=true; }
      }
      public bool Msg_IsShowName_IsChanged
      {
         get{ return msg_IsShowName_IsChanged; }
         set{ msg_IsShowName_IsChanged = value; }
      }
      private string msg_TypeName;
      private bool msg_TypeName_IsChanged=false;
      public string Msg_TypeName
      {
         get{ return msg_TypeName; }
         set{ msg_TypeName = value; msg_TypeName_IsChanged=true; }
      }
      public bool Msg_TypeName_IsChanged
      {
         get{ return msg_TypeName_IsChanged; }
         set{ msg_TypeName_IsChanged = value; }
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
