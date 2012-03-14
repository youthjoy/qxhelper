using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 用户在线列表
   /// </summary>
   [Serializable]
   public partial class Sys_OnlineUser
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
      private string eL_UserCode;
      private bool eL_UserCode_IsChanged=false;
      public string EL_UserCode
      {
         get{ return eL_UserCode; }
         set{ eL_UserCode = value; eL_UserCode_IsChanged=true; }
      }
      public bool EL_UserCode_IsChanged
      {
         get{ return eL_UserCode_IsChanged; }
         set{ eL_UserCode_IsChanged = value; }
      }
      private string eL_IP;
      private bool eL_IP_IsChanged=false;
      public string EL_IP
      {
         get{ return eL_IP; }
         set{ eL_IP = value; eL_IP_IsChanged=true; }
      }
      public bool EL_IP_IsChanged
      {
         get{ return eL_IP_IsChanged; }
         set{ eL_IP_IsChanged = value; }
      }
      private decimal eL_DateSpan;
      private bool eL_DateSpan_IsChanged=false;
      public decimal EL_DateSpan
      {
         get{ return eL_DateSpan; }
         set{ eL_DateSpan = value; eL_DateSpan_IsChanged=true; }
      }
      public bool EL_DateSpan_IsChanged
      {
         get{ return eL_DateSpan_IsChanged; }
         set{ eL_DateSpan_IsChanged = value; }
      }
   }
}
