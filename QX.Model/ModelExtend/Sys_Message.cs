using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Sys_Message
   {
      private Int64 sYM_ID;
      private bool sYM_ID_IsChanged=false;
      public Int64 SYM_ID
      {
         get{ return sYM_ID; }
         set{ sYM_ID = value; sYM_ID_IsChanged=true; }
      }
      public bool SYM_ID_IsChanged
      {
         get{ return sYM_ID_IsChanged; }
         set{ sYM_ID_IsChanged = value; }
      }
      private string sYM_Module;
      private bool sYM_Module_IsChanged=false;
      public string SYM_Module
      {
         get{ return sYM_Module; }
         set{ sYM_Module = value; sYM_Module_IsChanged=true; }
      }
      public bool SYM_Module_IsChanged
      {
         get{ return sYM_Module_IsChanged; }
         set{ sYM_Module_IsChanged = value; }
      }
      private string sYM_Key;
      private bool sYM_Key_IsChanged=false;
      public string SYM_Key
      {
         get{ return sYM_Key; }
         set{ sYM_Key = value; sYM_Key_IsChanged=true; }
      }
      public bool SYM_Key_IsChanged
      {
         get{ return sYM_Key_IsChanged; }
         set{ sYM_Key_IsChanged = value; }
      }
      private string sYM_Content;
      private bool sYM_Content_IsChanged=false;
      public string SYM_Content
      {
         get{ return sYM_Content; }
         set{ sYM_Content = value; sYM_Content_IsChanged=true; }
      }
      public bool SYM_Content_IsChanged
      {
         get{ return sYM_Content_IsChanged; }
         set{ sYM_Content_IsChanged = value; }
      }
      private string sYM_UDef1;
      private bool sYM_UDef1_IsChanged=false;
      public string SYM_UDef1
      {
         get{ return sYM_UDef1; }
         set{ sYM_UDef1 = value; sYM_UDef1_IsChanged=true; }
      }
      public bool SYM_UDef1_IsChanged
      {
         get{ return sYM_UDef1_IsChanged; }
         set{ sYM_UDef1_IsChanged = value; }
      }
      private string sYM_UDef2;
      private bool sYM_UDef2_IsChanged=false;
      public string SYM_UDef2
      {
         get{ return sYM_UDef2; }
         set{ sYM_UDef2 = value; sYM_UDef2_IsChanged=true; }
      }
      public bool SYM_UDef2_IsChanged
      {
         get{ return sYM_UDef2_IsChanged; }
         set{ sYM_UDef2_IsChanged = value; }
      }
      private string sYM_UDef3;
      private bool sYM_UDef3_IsChanged=false;
      public string SYM_UDef3
      {
         get{ return sYM_UDef3; }
         set{ sYM_UDef3 = value; sYM_UDef3_IsChanged=true; }
      }
      public bool SYM_UDef3_IsChanged
      {
         get{ return sYM_UDef3_IsChanged; }
         set{ sYM_UDef3_IsChanged = value; }
      }
      private string sYM_UDef4;
      private bool sYM_UDef4_IsChanged=false;
      public string SYM_UDef4
      {
         get{ return sYM_UDef4; }
         set{ sYM_UDef4 = value; sYM_UDef4_IsChanged=true; }
      }
      public bool SYM_UDef4_IsChanged
      {
         get{ return sYM_UDef4_IsChanged; }
         set{ sYM_UDef4_IsChanged = value; }
      }
      private string sYM_UDef5;
      private bool sYM_UDef5_IsChanged=false;
      public string SYM_UDef5
      {
         get{ return sYM_UDef5; }
         set{ sYM_UDef5 = value; sYM_UDef5_IsChanged=true; }
      }
      public bool SYM_UDef5_IsChanged
      {
         get{ return sYM_UDef5_IsChanged; }
         set{ sYM_UDef5_IsChanged = value; }
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
