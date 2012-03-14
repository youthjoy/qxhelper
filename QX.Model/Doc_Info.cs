using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Doc_Info
   {
      private decimal doc_ID;
      private bool doc_ID_IsChanged=false;
      public decimal Doc_ID
      {
         get{ return doc_ID; }
         set{ doc_ID = value; doc_ID_IsChanged=true; }
      }
      public bool Doc_ID_IsChanged
      {
         get{ return doc_ID_IsChanged; }
         set{ doc_ID_IsChanged = value; }
      }
      private string doc_Code;
      private bool doc_Code_IsChanged=false;
      public string Doc_Code
      {
         get{ return doc_Code; }
         set{ doc_Code = value; doc_Code_IsChanged=true; }
      }
      public bool Doc_Code_IsChanged
      {
         get{ return doc_Code_IsChanged; }
         set{ doc_Code_IsChanged = value; }
      }
      private string doc_Type;
      private bool doc_Type_IsChanged=false;
      public string Doc_Type
      {
         get{ return doc_Type; }
         set{ doc_Type = value; doc_Type_IsChanged=true; }
      }
      public bool Doc_Type_IsChanged
      {
         get{ return doc_Type_IsChanged; }
         set{ doc_Type_IsChanged = value; }
      }
      private string doc_TypeName;
      private bool doc_TypeName_IsChanged=false;
      public string Doc_TypeName
      {
         get{ return doc_TypeName; }
         set{ doc_TypeName = value; doc_TypeName_IsChanged=true; }
      }
      public bool Doc_TypeName_IsChanged
      {
         get{ return doc_TypeName_IsChanged; }
         set{ doc_TypeName_IsChanged = value; }
      }
      private string doc_No;
      private bool doc_No_IsChanged=false;
      public string Doc_No
      {
         get{ return doc_No; }
         set{ doc_No = value; doc_No_IsChanged=true; }
      }
      public bool Doc_No_IsChanged
      {
         get{ return doc_No_IsChanged; }
         set{ doc_No_IsChanged = value; }
      }
      private string doc_IsBusyName;
      private bool doc_IsBusyName_IsChanged=false;
      public string Doc_IsBusyName
      {
         get{ return doc_IsBusyName; }
         set{ doc_IsBusyName = value; doc_IsBusyName_IsChanged=true; }
      }
      public bool Doc_IsBusyName_IsChanged
      {
         get{ return doc_IsBusyName_IsChanged; }
         set{ doc_IsBusyName_IsChanged = value; }
      }
      private string doc_IsBusy;
      private bool doc_IsBusy_IsChanged=false;
      public string Doc_IsBusy
      {
         get{ return doc_IsBusy; }
         set{ doc_IsBusy = value; doc_IsBusy_IsChanged=true; }
      }
      public bool Doc_IsBusy_IsChanged
      {
         get{ return doc_IsBusy_IsChanged; }
         set{ doc_IsBusy_IsChanged = value; }
      }
      private string doc_Level;
      private bool doc_Level_IsChanged=false;
      public string Doc_Level
      {
         get{ return doc_Level; }
         set{ doc_Level = value; doc_Level_IsChanged=true; }
      }
      public bool Doc_Level_IsChanged
      {
         get{ return doc_Level_IsChanged; }
         set{ doc_Level_IsChanged = value; }
      }
      private string doc_LevelName;
      private bool doc_LevelName_IsChanged=false;
      public string Doc_LevelName
      {
         get{ return doc_LevelName; }
         set{ doc_LevelName = value; doc_LevelName_IsChanged=true; }
      }
      public bool Doc_LevelName_IsChanged
      {
         get{ return doc_LevelName_IsChanged; }
         set{ doc_LevelName_IsChanged = value; }
      }
      private string doc_Title;
      private bool doc_Title_IsChanged=false;
      public string Doc_Title
      {
         get{ return doc_Title; }
         set{ doc_Title = value; doc_Title_IsChanged=true; }
      }
      public bool Doc_Title_IsChanged
      {
         get{ return doc_Title_IsChanged; }
         set{ doc_Title_IsChanged = value; }
      }
      private string doc_Object;
      private bool doc_Object_IsChanged=false;
      public string Doc_Object
      {
         get{ return doc_Object; }
         set{ doc_Object = value; doc_Object_IsChanged=true; }
      }
      public bool Doc_Object_IsChanged
      {
         get{ return doc_Object_IsChanged; }
         set{ doc_Object_IsChanged = value; }
      }
      private string doc_Cate;
      private bool doc_Cate_IsChanged=false;
      public string Doc_Cate
      {
         get{ return doc_Cate; }
         set{ doc_Cate = value; doc_Cate_IsChanged=true; }
      }
      public bool Doc_Cate_IsChanged
      {
         get{ return doc_Cate_IsChanged; }
         set{ doc_Cate_IsChanged = value; }
      }
      private string doc_CateName;
      private bool doc_CateName_IsChanged=false;
      public string Doc_CateName
      {
         get{ return doc_CateName; }
         set{ doc_CateName = value; doc_CateName_IsChanged=true; }
      }
      public bool Doc_CateName_IsChanged
      {
         get{ return doc_CateName_IsChanged; }
         set{ doc_CateName_IsChanged = value; }
      }
      private string doc_Creator;
      private bool doc_Creator_IsChanged=false;
      public string Doc_Creator
      {
         get{ return doc_Creator; }
         set{ doc_Creator = value; doc_Creator_IsChanged=true; }
      }
      public bool Doc_Creator_IsChanged
      {
         get{ return doc_Creator_IsChanged; }
         set{ doc_Creator_IsChanged = value; }
      }
      private string doc_CreatorName;
      private bool doc_CreatorName_IsChanged=false;
      public string Doc_CreatorName
      {
         get{ return doc_CreatorName; }
         set{ doc_CreatorName = value; doc_CreatorName_IsChanged=true; }
      }
      public bool Doc_CreatorName_IsChanged
      {
         get{ return doc_CreatorName_IsChanged; }
         set{ doc_CreatorName_IsChanged = value; }
      }
      private string doc_DpCode;
      private bool doc_DpCode_IsChanged=false;
      public string Doc_DpCode
      {
         get{ return doc_DpCode; }
         set{ doc_DpCode = value; doc_DpCode_IsChanged=true; }
      }
      public bool Doc_DpCode_IsChanged
      {
         get{ return doc_DpCode_IsChanged; }
         set{ doc_DpCode_IsChanged = value; }
      }
      private string doc_DpName;
      private bool doc_DpName_IsChanged=false;
      public string Doc_DpName
      {
         get{ return doc_DpName; }
         set{ doc_DpName = value; doc_DpName_IsChanged=true; }
      }
      public bool Doc_DpName_IsChanged
      {
         get{ return doc_DpName_IsChanged; }
         set{ doc_DpName_IsChanged = value; }
      }
      private string doc_MainTitle;
      private bool doc_MainTitle_IsChanged=false;
      public string Doc_MainTitle
      {
         get{ return doc_MainTitle; }
         set{ doc_MainTitle = value; doc_MainTitle_IsChanged=true; }
      }
      public bool Doc_MainTitle_IsChanged
      {
         get{ return doc_MainTitle_IsChanged; }
         set{ doc_MainTitle_IsChanged = value; }
      }
      private string doc_CC;
      private bool doc_CC_IsChanged=false;
      public string Doc_CC
      {
         get{ return doc_CC; }
         set{ doc_CC = value; doc_CC_IsChanged=true; }
      }
      public bool Doc_CC_IsChanged
      {
         get{ return doc_CC_IsChanged; }
         set{ doc_CC_IsChanged = value; }
      }
      private string doc_Content;
      private bool doc_Content_IsChanged=false;
      public string Doc_Content
      {
         get{ return doc_Content; }
         set{ doc_Content = value; doc_Content_IsChanged=true; }
      }
      public bool Doc_Content_IsChanged
      {
         get{ return doc_Content_IsChanged; }
         set{ doc_Content_IsChanged = value; }
      }
      private DateTime doc_Date;
      private bool doc_Date_IsChanged=false;
      public DateTime Doc_Date
      {
         get{ return doc_Date; }
         set{ doc_Date = value; doc_Date_IsChanged=true; }
      }
      public bool Doc_Date_IsChanged
      {
         get{ return doc_Date_IsChanged; }
         set{ doc_Date_IsChanged = value; }
      }
      private int doc_Num;
      private bool doc_Num_IsChanged=false;
      public int Doc_Num
      {
         get{ return doc_Num; }
         set{ doc_Num = value; doc_Num_IsChanged=true; }
      }
      public bool Doc_Num_IsChanged
      {
         get{ return doc_Num_IsChanged; }
         set{ doc_Num_IsChanged = value; }
      }
      private string doc_Opinion;
      private bool doc_Opinion_IsChanged=false;
      public string Doc_Opinion
      {
         get{ return doc_Opinion; }
         set{ doc_Opinion = value; doc_Opinion_IsChanged=true; }
      }
      public bool Doc_Opinion_IsChanged
      {
         get{ return doc_Opinion_IsChanged; }
         set{ doc_Opinion_IsChanged = value; }
      }
      private string doc_Stat;
      private bool doc_Stat_IsChanged=false;
      public string Doc_Stat
      {
         get{ return doc_Stat; }
         set{ doc_Stat = value; doc_Stat_IsChanged=true; }
      }
      public bool Doc_Stat_IsChanged
      {
         get{ return doc_Stat_IsChanged; }
         set{ doc_Stat_IsChanged = value; }
      }
      private string doc_RefDoc;
      private bool doc_RefDoc_IsChanged=false;
      public string Doc_RefDoc
      {
         get{ return doc_RefDoc; }
         set{ doc_RefDoc = value; doc_RefDoc_IsChanged=true; }
      }
      public bool Doc_RefDoc_IsChanged
      {
         get{ return doc_RefDoc_IsChanged; }
         set{ doc_RefDoc_IsChanged = value; }
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
   }
}
