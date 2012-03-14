using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 系统消息
   /// </summary>
   [Serializable]
   public partial class Sys_Annoce
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
      private string eL_Type;
      private bool eL_Type_IsChanged=false;
      public string EL_Type
      {
         get{ return eL_Type; }
         set{ eL_Type = value; eL_Type_IsChanged=true; }
      }
      public bool EL_Type_IsChanged
      {
         get{ return eL_Type_IsChanged; }
         set{ eL_Type_IsChanged = value; }
      }
      private string eL_User;
      private bool eL_User_IsChanged=false;
      public string EL_User
      {
         get{ return eL_User; }
         set{ eL_User = value; eL_User_IsChanged=true; }
      }
      public bool EL_User_IsChanged
      {
         get{ return eL_User_IsChanged; }
         set{ eL_User_IsChanged = value; }
      }
      private string eL_Dept;
      private bool eL_Dept_IsChanged=false;
      public string EL_Dept
      {
         get{ return eL_Dept; }
         set{ eL_Dept = value; eL_Dept_IsChanged=true; }
      }
      public bool EL_Dept_IsChanged
      {
         get{ return eL_Dept_IsChanged; }
         set{ eL_Dept_IsChanged = value; }
      }
      private string eL_Title;
      private bool eL_Title_IsChanged=false;
      public string EL_Title
      {
         get{ return eL_Title; }
         set{ eL_Title = value; eL_Title_IsChanged=true; }
      }
      public bool EL_Title_IsChanged
      {
         get{ return eL_Title_IsChanged; }
         set{ eL_Title_IsChanged = value; }
      }
      private string eL_Msg;
      private bool eL_Msg_IsChanged=false;
      public string EL_Msg
      {
         get{ return eL_Msg; }
         set{ eL_Msg = value; eL_Msg_IsChanged=true; }
      }
      public bool EL_Msg_IsChanged
      {
         get{ return eL_Msg_IsChanged; }
         set{ eL_Msg_IsChanged = value; }
      }
      private string eL_URL;
      private bool eL_URL_IsChanged=false;
      public string EL_URL
      {
         get{ return eL_URL; }
         set{ eL_URL = value; eL_URL_IsChanged=true; }
      }
      public bool EL_URL_IsChanged
      {
         get{ return eL_URL_IsChanged; }
         set{ eL_URL_IsChanged = value; }
      }
      private DateTime eL_StartDate;
      private bool eL_StartDate_IsChanged=false;
      public DateTime EL_StartDate
      {
         get{ return eL_StartDate; }
         set{ eL_StartDate = value; eL_StartDate_IsChanged=true; }
      }
      public bool EL_StartDate_IsChanged
      {
         get{ return eL_StartDate_IsChanged; }
         set{ eL_StartDate_IsChanged = value; }
      }
      private DateTime eL_EndDate;
      private bool eL_EndDate_IsChanged=false;
      public DateTime EL_EndDate
      {
         get{ return eL_EndDate; }
         set{ eL_EndDate = value; eL_EndDate_IsChanged=true; }
      }
      public bool EL_EndDate_IsChanged
      {
         get{ return eL_EndDate_IsChanged; }
         set{ eL_EndDate_IsChanged = value; }
      }
   }
}
