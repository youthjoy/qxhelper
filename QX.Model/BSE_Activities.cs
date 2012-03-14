using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 活动情况
   /// </summary>
   [Serializable]
   public partial class BSE_Activities
   {
      private decimal bAA_ID;
      private bool bAA_ID_IsChanged=false;
      public decimal BAA_ID
      {
         get{ return bAA_ID; }
         set{ bAA_ID = value; bAA_ID_IsChanged=true; }
      }
      public bool BAA_ID_IsChanged
      {
         get{ return bAA_ID_IsChanged; }
         set{ bAA_ID_IsChanged = value; }
      }
      private string bAA_Code;
      private bool bAA_Code_IsChanged=false;
      public string BAA_Code
      {
         get{ return bAA_Code; }
         set{ bAA_Code = value; bAA_Code_IsChanged=true; }
      }
      public bool BAA_Code_IsChanged
      {
         get{ return bAA_Code_IsChanged; }
         set{ bAA_Code_IsChanged = value; }
      }
      private string bAA_Type;
      private bool bAA_Type_IsChanged=false;
      public string BAA_Type
      {
         get{ return bAA_Type; }
         set{ bAA_Type = value; bAA_Type_IsChanged=true; }
      }
      public bool BAA_Type_IsChanged
      {
         get{ return bAA_Type_IsChanged; }
         set{ bAA_Type_IsChanged = value; }
      }
      private string bAA_Category;
      private bool bAA_Category_IsChanged=false;
      public string BAA_Category
      {
         get{ return bAA_Category; }
         set{ bAA_Category = value; bAA_Category_IsChanged=true; }
      }
      public bool BAA_Category_IsChanged
      {
         get{ return bAA_Category_IsChanged; }
         set{ bAA_Category_IsChanged = value; }
      }
      private string bAA_CName;
      private bool bAA_CName_IsChanged=false;
      public string BAA_CName
      {
         get{ return bAA_CName; }
         set{ bAA_CName = value; bAA_CName_IsChanged=true; }
      }
      public bool BAA_CName_IsChanged
      {
         get{ return bAA_CName_IsChanged; }
         set{ bAA_CName_IsChanged = value; }
      }
      private string bAA_CCode;
      private bool bAA_CCode_IsChanged=false;
      public string BAA_CCode
      {
         get{ return bAA_CCode; }
         set{ bAA_CCode = value; bAA_CCode_IsChanged=true; }
      }
      public bool BAA_CCode_IsChanged
      {
         get{ return bAA_CCode_IsChanged; }
         set{ bAA_CCode_IsChanged = value; }
      }
      private string bAA_Owner;
      private bool bAA_Owner_IsChanged=false;
      public string BAA_Owner
      {
         get{ return bAA_Owner; }
         set{ bAA_Owner = value; bAA_Owner_IsChanged=true; }
      }
      public bool BAA_Owner_IsChanged
      {
         get{ return bAA_Owner_IsChanged; }
         set{ bAA_Owner_IsChanged = value; }
      }
      private string bAA_Member;
      private bool bAA_Member_IsChanged=false;
      public string BAA_Member
      {
         get{ return bAA_Member; }
         set{ bAA_Member = value; bAA_Member_IsChanged=true; }
      }
      public bool BAA_Member_IsChanged
      {
         get{ return bAA_Member_IsChanged; }
         set{ bAA_Member_IsChanged = value; }
      }
      private string bAA_Contract;
      private bool bAA_Contract_IsChanged=false;
      public string BAA_Contract
      {
         get{ return bAA_Contract; }
         set{ bAA_Contract = value; bAA_Contract_IsChanged=true; }
      }
      public bool BAA_Contract_IsChanged
      {
         get{ return bAA_Contract_IsChanged; }
         set{ bAA_Contract_IsChanged = value; }
      }
      private string bAA_Tel;
      private bool bAA_Tel_IsChanged=false;
      public string BAA_Tel
      {
         get{ return bAA_Tel; }
         set{ bAA_Tel = value; bAA_Tel_IsChanged=true; }
      }
      public bool BAA_Tel_IsChanged
      {
         get{ return bAA_Tel_IsChanged; }
         set{ bAA_Tel_IsChanged = value; }
      }
      private DateTime bAA_Begin;
      private bool bAA_Begin_IsChanged=false;
      public DateTime BAA_Begin
      {
         get{ return bAA_Begin; }
         set{ bAA_Begin = value; bAA_Begin_IsChanged=true; }
      }
      public bool BAA_Begin_IsChanged
      {
         get{ return bAA_Begin_IsChanged; }
         set{ bAA_Begin_IsChanged = value; }
      }
      private DateTime bAA_End;
      private bool bAA_End_IsChanged=false;
      public DateTime BAA_End
      {
         get{ return bAA_End; }
         set{ bAA_End = value; bAA_End_IsChanged=true; }
      }
      public bool BAA_End_IsChanged
      {
         get{ return bAA_End_IsChanged; }
         set{ bAA_End_IsChanged = value; }
      }
      private int bAA_Period;
      private bool bAA_Period_IsChanged=false;
      public int BAA_Period
      {
         get{ return bAA_Period; }
         set{ bAA_Period = value; bAA_Period_IsChanged=true; }
      }
      public bool BAA_Period_IsChanged
      {
         get{ return bAA_Period_IsChanged; }
         set{ bAA_Period_IsChanged = value; }
      }
      private string bAA_Priority;
      private bool bAA_Priority_IsChanged=false;
      public string BAA_Priority
      {
         get{ return bAA_Priority; }
         set{ bAA_Priority = value; bAA_Priority_IsChanged=true; }
      }
      public bool BAA_Priority_IsChanged
      {
         get{ return bAA_Priority_IsChanged; }
         set{ bAA_Priority_IsChanged = value; }
      }
      private string bAA_Addr;
      private bool bAA_Addr_IsChanged=false;
      public string BAA_Addr
      {
         get{ return bAA_Addr; }
         set{ bAA_Addr = value; bAA_Addr_IsChanged=true; }
      }
      public bool BAA_Addr_IsChanged
      {
         get{ return bAA_Addr_IsChanged; }
         set{ bAA_Addr_IsChanged = value; }
      }
      private DateTime bAA_Reminder;
      private bool bAA_Reminder_IsChanged=false;
      public DateTime BAA_Reminder
      {
         get{ return bAA_Reminder; }
         set{ bAA_Reminder = value; bAA_Reminder_IsChanged=true; }
      }
      public bool BAA_Reminder_IsChanged
      {
         get{ return bAA_Reminder_IsChanged; }
         set{ bAA_Reminder_IsChanged = value; }
      }
      private string bAA_Content;
      private bool bAA_Content_IsChanged=false;
      public string BAA_Content
      {
         get{ return bAA_Content; }
         set{ bAA_Content = value; bAA_Content_IsChanged=true; }
      }
      public bool BAA_Content_IsChanged
      {
         get{ return bAA_Content_IsChanged; }
         set{ bAA_Content_IsChanged = value; }
      }
      private int bAA_Stat;
      private bool bAA_Stat_IsChanged=false;
      public int BAA_Stat
      {
         get{ return bAA_Stat; }
         set{ bAA_Stat = value; bAA_Stat_IsChanged=true; }
      }
      public bool BAA_Stat_IsChanged
      {
         get{ return bAA_Stat_IsChanged; }
         set{ bAA_Stat_IsChanged = value; }
      }
      private string bAA_iType;
      private bool bAA_iType_IsChanged=false;
      public string BAA_iType
      {
         get{ return bAA_iType; }
         set{ bAA_iType = value; bAA_iType_IsChanged=true; }
      }
      public bool BAA_iType_IsChanged
      {
         get{ return bAA_iType_IsChanged; }
         set{ bAA_iType_IsChanged = value; }
      }
      private string bAA_Remark;
      private bool bAA_Remark_IsChanged=false;
      public string BAA_Remark
      {
         get{ return bAA_Remark; }
         set{ bAA_Remark = value; bAA_Remark_IsChanged=true; }
      }
      public bool BAA_Remark_IsChanged
      {
         get{ return bAA_Remark_IsChanged; }
         set{ bAA_Remark_IsChanged = value; }
      }
      private string bAA_RefType;
      private bool bAA_RefType_IsChanged=false;
      public string BAA_RefType
      {
         get{ return bAA_RefType; }
         set{ bAA_RefType = value; bAA_RefType_IsChanged=true; }
      }
      public bool BAA_RefType_IsChanged
      {
         get{ return bAA_RefType_IsChanged; }
         set{ bAA_RefType_IsChanged = value; }
      }
      private string bAA_RefCode;
      private bool bAA_RefCode_IsChanged=false;
      public string BAA_RefCode
      {
         get{ return bAA_RefCode; }
         set{ bAA_RefCode = value; bAA_RefCode_IsChanged=true; }
      }
      public bool BAA_RefCode_IsChanged
      {
         get{ return bAA_RefCode_IsChanged; }
         set{ bAA_RefCode_IsChanged = value; }
      }
   }
}
