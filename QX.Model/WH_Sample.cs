using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class WH_Sample
   {
      private decimal sample_ID;
      private bool sample_ID_IsChanged=false;
      public decimal Sample_ID
      {
         get{ return sample_ID; }
         set{ sample_ID = value; sample_ID_IsChanged=true; }
      }
      public bool Sample_ID_IsChanged
      {
         get{ return sample_ID_IsChanged; }
         set{ sample_ID_IsChanged = value; }
      }
      private string sample_Code;
      private bool sample_Code_IsChanged=false;
      public string Sample_Code
      {
         get{ return sample_Code; }
         set{ sample_Code = value; sample_Code_IsChanged=true; }
      }
      public bool Sample_Code_IsChanged
      {
         get{ return sample_Code_IsChanged; }
         set{ sample_Code_IsChanged = value; }
      }
      private string sample_Name;
      private bool sample_Name_IsChanged=false;
      public string Sample_Name
      {
         get{ return sample_Name; }
         set{ sample_Name = value; sample_Name_IsChanged=true; }
      }
      public bool Sample_Name_IsChanged
      {
         get{ return sample_Name_IsChanged; }
         set{ sample_Name_IsChanged = value; }
      }
      private int sample_Count;
      private bool sample_Count_IsChanged=false;
      public int Sample_Count
      {
         get{ return sample_Count; }
         set{ sample_Count = value; sample_Count_IsChanged=true; }
      }
      public bool Sample_Count_IsChanged
      {
         get{ return sample_Count_IsChanged; }
         set{ sample_Count_IsChanged = value; }
      }
      private string sample_Unit;
      private bool sample_Unit_IsChanged=false;
      public string Sample_Unit
      {
         get{ return sample_Unit; }
         set{ sample_Unit = value; sample_Unit_IsChanged=true; }
      }
      public bool Sample_Unit_IsChanged
      {
         get{ return sample_Unit_IsChanged; }
         set{ sample_Unit_IsChanged = value; }
      }
      private string sample_Remark;
      private bool sample_Remark_IsChanged=false;
      public string Sample_Remark
      {
         get{ return sample_Remark; }
         set{ sample_Remark = value; sample_Remark_IsChanged=true; }
      }
      public bool Sample_Remark_IsChanged
      {
         get{ return sample_Remark_IsChanged; }
         set{ sample_Remark_IsChanged = value; }
      }
      private string sample_SupplierName;
      private bool sample_SupplierName_IsChanged=false;
      public string Sample_SupplierName
      {
         get{ return sample_SupplierName; }
         set{ sample_SupplierName = value; sample_SupplierName_IsChanged=true; }
      }
      public bool Sample_SupplierName_IsChanged
      {
         get{ return sample_SupplierName_IsChanged; }
         set{ sample_SupplierName_IsChanged = value; }
      }
      private string sample_SupplierCode;
      private bool sample_SupplierCode_IsChanged=false;
      public string Sample_SupplierCode
      {
         get{ return sample_SupplierCode; }
         set{ sample_SupplierCode = value; sample_SupplierCode_IsChanged=true; }
      }
      public bool Sample_SupplierCode_IsChanged
      {
         get{ return sample_SupplierCode_IsChanged; }
         set{ sample_SupplierCode_IsChanged = value; }
      }
      private string sample_SupplierContactor;
      private bool sample_SupplierContactor_IsChanged=false;
      public string Sample_SupplierContactor
      {
         get{ return sample_SupplierContactor; }
         set{ sample_SupplierContactor = value; sample_SupplierContactor_IsChanged=true; }
      }
      public bool Sample_SupplierContactor_IsChanged
      {
         get{ return sample_SupplierContactor_IsChanged; }
         set{ sample_SupplierContactor_IsChanged = value; }
      }
      private string sample_Contact;
      private bool sample_Contact_IsChanged=false;
      public string Sample_Contact
      {
         get{ return sample_Contact; }
         set{ sample_Contact = value; sample_Contact_IsChanged=true; }
      }
      public bool Sample_Contact_IsChanged
      {
         get{ return sample_Contact_IsChanged; }
         set{ sample_Contact_IsChanged = value; }
      }
      private DateTime sample_ComeDate;
      private bool sample_ComeDate_IsChanged=false;
      public DateTime Sample_ComeDate
      {
         get{ return sample_ComeDate; }
         set{ sample_ComeDate = value; sample_ComeDate_IsChanged=true; }
      }
      public bool Sample_ComeDate_IsChanged
      {
         get{ return sample_ComeDate_IsChanged; }
         set{ sample_ComeDate_IsChanged = value; }
      }
      private string sample_Operator;
      private bool sample_Operator_IsChanged=false;
      public string Sample_Operator
      {
         get{ return sample_Operator; }
         set{ sample_Operator = value; sample_Operator_IsChanged=true; }
      }
      public bool Sample_Operator_IsChanged
      {
         get{ return sample_Operator_IsChanged; }
         set{ sample_Operator_IsChanged = value; }
      }
      private DateTime sample_OpDate;
      private bool sample_OpDate_IsChanged=false;
      public DateTime Sample_OpDate
      {
         get{ return sample_OpDate; }
         set{ sample_OpDate = value; sample_OpDate_IsChanged=true; }
      }
      public bool Sample_OpDate_IsChanged
      {
         get{ return sample_OpDate_IsChanged; }
         set{ sample_OpDate_IsChanged = value; }
      }
      private string sample_Company;
      private bool sample_Company_IsChanged=false;
      public string Sample_Company
      {
         get{ return sample_Company; }
         set{ sample_Company = value; sample_Company_IsChanged=true; }
      }
      public bool Sample_Company_IsChanged
      {
         get{ return sample_Company_IsChanged; }
         set{ sample_Company_IsChanged = value; }
      }
      private string sample_Dept;
      private bool sample_Dept_IsChanged=false;
      public string Sample_Dept
      {
         get{ return sample_Dept; }
         set{ sample_Dept = value; sample_Dept_IsChanged=true; }
      }
      public bool Sample_Dept_IsChanged
      {
         get{ return sample_Dept_IsChanged; }
         set{ sample_Dept_IsChanged = value; }
      }
      private string sample_Responer;
      private bool sample_Responer_IsChanged=false;
      public string Sample_Responer
      {
         get{ return sample_Responer; }
         set{ sample_Responer = value; sample_Responer_IsChanged=true; }
      }
      public bool Sample_Responer_IsChanged
      {
         get{ return sample_Responer_IsChanged; }
         set{ sample_Responer_IsChanged = value; }
      }
      private string sample_Feedback;
      private bool sample_Feedback_IsChanged=false;
      public string Sample_Feedback
      {
         get{ return sample_Feedback; }
         set{ sample_Feedback = value; sample_Feedback_IsChanged=true; }
      }
      public bool Sample_Feedback_IsChanged
      {
         get{ return sample_Feedback_IsChanged; }
         set{ sample_Feedback_IsChanged = value; }
      }
      private DateTime sample_FeedbackDate;
      private bool sample_FeedbackDate_IsChanged=false;
      public DateTime Sample_FeedbackDate
      {
         get{ return sample_FeedbackDate; }
         set{ sample_FeedbackDate = value; sample_FeedbackDate_IsChanged=true; }
      }
      public bool Sample_FeedbackDate_IsChanged
      {
         get{ return sample_FeedbackDate_IsChanged; }
         set{ sample_FeedbackDate_IsChanged = value; }
      }
      private string sample_IsRef;
      private bool sample_IsRef_IsChanged=false;
      public string Sample_IsRef
      {
         get{ return sample_IsRef; }
         set{ sample_IsRef = value; sample_IsRef_IsChanged=true; }
      }
      public bool Sample_IsRef_IsChanged
      {
         get{ return sample_IsRef_IsChanged; }
         set{ sample_IsRef_IsChanged = value; }
      }
      private string sample_State;
      private bool sample_State_IsChanged=false;
      public string Sample_State
      {
         get{ return sample_State; }
         set{ sample_State = value; sample_State_IsChanged=true; }
      }
      public bool Sample_State_IsChanged
      {
         get{ return sample_State_IsChanged; }
         set{ sample_State_IsChanged = value; }
      }
      private string sample_Type;
      private bool sample_Type_IsChanged=false;
      public string Sample_Type
      {
         get{ return sample_Type; }
         set{ sample_Type = value; sample_Type_IsChanged=true; }
      }
      public bool Sample_Type_IsChanged
      {
         get{ return sample_Type_IsChanged; }
         set{ sample_Type_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
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
   }
}
