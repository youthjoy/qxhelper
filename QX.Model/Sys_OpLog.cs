using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 系统操作日志
   /// </summary>
   [Serializable]
   public partial class Sys_OpLog
   {
      private decimal eL_ID;
      private bool eL_ID_IsChanged=false;
      public decimal EL_ID
      {
         get{ return eL_ID; }
         set{ eL_ID = value; eL_ID_IsChanged=true; }
      }
      public bool EL_ID_IsChanged
      {
         get{ return eL_ID_IsChanged; }
         set{ eL_ID_IsChanged = value; }
      }
      private string eL_Module;
      private bool eL_Module_IsChanged=false;
      public string EL_Module
      {
         get{ return eL_Module; }
         set{ eL_Module = value; eL_Module_IsChanged=true; }
      }
      public bool EL_Module_IsChanged
      {
         get{ return eL_Module_IsChanged; }
         set{ eL_Module_IsChanged = value; }
      }
      private string eL_ModuleName;
      private bool eL_ModuleName_IsChanged=false;
      public string EL_ModuleName
      {
         get{ return eL_ModuleName; }
         set{ eL_ModuleName = value; eL_ModuleName_IsChanged=true; }
      }
      public bool EL_ModuleName_IsChanged
      {
         get{ return eL_ModuleName_IsChanged; }
         set{ eL_ModuleName_IsChanged = value; }
      }
      private DateTime eL_Date;
      private bool eL_Date_IsChanged=false;
      public DateTime EL_Date
      {
         get{ return eL_Date; }
         set{ eL_Date = value; eL_Date_IsChanged=true; }
      }
      public bool EL_Date_IsChanged
      {
         get{ return eL_Date_IsChanged; }
         set{ eL_Date_IsChanged = value; }
      }
      private string eL_Author;
      private bool eL_Author_IsChanged=false;
      public string EL_Author
      {
         get{ return eL_Author; }
         set{ eL_Author = value; eL_Author_IsChanged=true; }
      }
      public bool EL_Author_IsChanged
      {
         get{ return eL_Author_IsChanged; }
         set{ eL_Author_IsChanged = value; }
      }
      private string eL_AuthorName;
      private bool eL_AuthorName_IsChanged=false;
      public string EL_AuthorName
      {
         get{ return eL_AuthorName; }
         set{ eL_AuthorName = value; eL_AuthorName_IsChanged=true; }
      }
      public bool EL_AuthorName_IsChanged
      {
         get{ return eL_AuthorName_IsChanged; }
         set{ eL_AuthorName_IsChanged = value; }
      }
      private string eL_ClientIP;
      private bool eL_ClientIP_IsChanged=false;
      public string EL_ClientIP
      {
         get{ return eL_ClientIP; }
         set{ eL_ClientIP = value; eL_ClientIP_IsChanged=true; }
      }
      public bool EL_ClientIP_IsChanged
      {
         get{ return eL_ClientIP_IsChanged; }
         set{ eL_ClientIP_IsChanged = value; }
      }
      private string eL_RequireURL;
      private bool eL_RequireURL_IsChanged=false;
      public string EL_RequireURL
      {
         get{ return eL_RequireURL; }
         set{ eL_RequireURL = value; eL_RequireURL_IsChanged=true; }
      }
      public bool EL_RequireURL_IsChanged
      {
         get{ return eL_RequireURL_IsChanged; }
         set{ eL_RequireURL_IsChanged = value; }
      }
      private string eL_Message;
      private bool eL_Message_IsChanged=false;
      public string EL_Message
      {
         get{ return eL_Message; }
         set{ eL_Message = value; eL_Message_IsChanged=true; }
      }
      public bool EL_Message_IsChanged
      {
         get{ return eL_Message_IsChanged; }
         set{ eL_Message_IsChanged = value; }
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
