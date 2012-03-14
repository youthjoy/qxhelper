using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_Components
   {
      private decimal comp_ID;
      private bool comp_ID_IsChanged=false;
      public decimal Comp_ID
      {
         get{ return comp_ID; }
         set{ comp_ID = value; comp_ID_IsChanged=true; }
      }
      public bool Comp_ID_IsChanged
      {
         get{ return comp_ID_IsChanged; }
         set{ comp_ID_IsChanged = value; }
      }
      private string comp_Code;
      private bool comp_Code_IsChanged=false;
      public string Comp_Code
      {
         get{ return comp_Code; }
         set{ comp_Code = value; comp_Code_IsChanged=true; }
      }
      public bool Comp_Code_IsChanged
      {
         get{ return comp_Code_IsChanged; }
         set{ comp_Code_IsChanged = value; }
      }
      private string comp_CCode;
      private bool comp_CCode_IsChanged=false;
      public string Comp_CCode
      {
         get{ return comp_CCode; }
         set{ comp_CCode = value; comp_CCode_IsChanged=true; }
      }
      public bool Comp_CCode_IsChanged
      {
         get{ return comp_CCode_IsChanged; }
         set{ comp_CCode_IsChanged = value; }
      }
      private string comp_Name;
      private bool comp_Name_IsChanged=false;
      public string Comp_Name
      {
         get{ return comp_Name; }
         set{ comp_Name = value; comp_Name_IsChanged=true; }
      }
      public bool Comp_Name_IsChanged
      {
         get{ return comp_Name_IsChanged; }
         set{ comp_Name_IsChanged = value; }
      }
      private string comp_Type;
      private bool comp_Type_IsChanged=false;
      public string Comp_Type
      {
         get{ return comp_Type; }
         set{ comp_Type = value; comp_Type_IsChanged=true; }
      }
      public bool Comp_Type_IsChanged
      {
         get{ return comp_Type_IsChanged; }
         set{ comp_Type_IsChanged = value; }
      }
      private string comp_TypeName;
      private bool comp_TypeName_IsChanged=false;
      public string Comp_TypeName
      {
         get{ return comp_TypeName; }
         set{ comp_TypeName = value; comp_TypeName_IsChanged=true; }
      }
      public bool Comp_TypeName_IsChanged
      {
         get{ return comp_TypeName_IsChanged; }
         set{ comp_TypeName_IsChanged = value; }
      }
      private string comp_Cate;
      private bool comp_Cate_IsChanged=false;
      public string Comp_Cate
      {
         get{ return comp_Cate; }
         set{ comp_Cate = value; comp_Cate_IsChanged=true; }
      }
      public bool Comp_Cate_IsChanged
      {
         get{ return comp_Cate_IsChanged; }
         set{ comp_Cate_IsChanged = value; }
      }
      private string comp_CateName;
      private bool comp_CateName_IsChanged=false;
      public string Comp_CateName
      {
         get{ return comp_CateName; }
         set{ comp_CateName = value; comp_CateName_IsChanged=true; }
      }
      public bool Comp_CateName_IsChanged
      {
         get{ return comp_CateName_IsChanged; }
         set{ comp_CateName_IsChanged = value; }
      }
      private string comp_Customer;
      private bool comp_Customer_IsChanged=false;
      public string Comp_Customer
      {
         get{ return comp_Customer; }
         set{ comp_Customer = value; comp_Customer_IsChanged=true; }
      }
      public bool Comp_Customer_IsChanged
      {
         get{ return comp_Customer_IsChanged; }
         set{ comp_Customer_IsChanged = value; }
      }
      private string comp_CustomerName;
      private bool comp_CustomerName_IsChanged=false;
      public string Comp_CustomerName
      {
         get{ return comp_CustomerName; }
         set{ comp_CustomerName = value; comp_CustomerName_IsChanged=true; }
      }
      public bool Comp_CustomerName_IsChanged
      {
         get{ return comp_CustomerName_IsChanged; }
         set{ comp_CustomerName_IsChanged = value; }
      }
      private string comp_Stat;
      private bool comp_Stat_IsChanged=false;
      public string Comp_Stat
      {
         get{ return comp_Stat; }
         set{ comp_Stat = value; comp_Stat_IsChanged=true; }
      }
      public bool Comp_Stat_IsChanged
      {
         get{ return comp_Stat_IsChanged; }
         set{ comp_Stat_IsChanged = value; }
      }
      private string comp_Content;
      private bool comp_Content_IsChanged=false;
      public string Comp_Content
      {
         get{ return comp_Content; }
         set{ comp_Content = value; comp_Content_IsChanged=true; }
      }
      public bool Comp_Content_IsChanged
      {
         get{ return comp_Content_IsChanged; }
         set{ comp_Content_IsChanged = value; }
      }
      private string comp_Creator;
      private bool comp_Creator_IsChanged=false;
      public string Comp_Creator
      {
         get{ return comp_Creator; }
         set{ comp_Creator = value; comp_Creator_IsChanged=true; }
      }
      public bool Comp_Creator_IsChanged
      {
         get{ return comp_Creator_IsChanged; }
         set{ comp_Creator_IsChanged = value; }
      }
      private string comp_CreatorName;
      private bool comp_CreatorName_IsChanged=false;
      public string Comp_CreatorName
      {
         get{ return comp_CreatorName; }
         set{ comp_CreatorName = value; comp_CreatorName_IsChanged=true; }
      }
      public bool Comp_CreatorName_IsChanged
      {
         get{ return comp_CreatorName_IsChanged; }
         set{ comp_CreatorName_IsChanged = value; }
      }
      private DateTime comp_Date;
      private bool comp_Date_IsChanged=false;
      public DateTime Comp_Date
      {
         get{ return comp_Date; }
         set{ comp_Date = value; comp_Date_IsChanged=true; }
      }
      public bool Comp_Date_IsChanged
      {
         get{ return comp_Date_IsChanged; }
         set{ comp_Date_IsChanged = value; }
      }
      private string auditStat;
      private bool auditStat_IsChanged=false;
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private string auditCurAudit;
      private bool auditCurAudit_IsChanged=false;
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
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
