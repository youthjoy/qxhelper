using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_File
   {
      private decimal cF_ID;
      private bool cF_ID_IsChanged=false;
      public decimal CF_ID
      {
         get{ return cF_ID; }
         set{ cF_ID = value; cF_ID_IsChanged=true; }
      }
      public bool CF_ID_IsChanged
      {
         get{ return cF_ID_IsChanged; }
         set{ cF_ID_IsChanged = value; }
      }
      private string cF_Code;
      private bool cF_Code_IsChanged=false;
      public string CF_Code
      {
         get{ return cF_Code; }
         set{ cF_Code = value; cF_Code_IsChanged=true; }
      }
      public bool CF_Code_IsChanged
      {
         get{ return cF_Code_IsChanged; }
         set{ cF_Code_IsChanged = value; }
      }
      private string cF_Name;
      private bool cF_Name_IsChanged=false;
      public string CF_Name
      {
         get{ return cF_Name; }
         set{ cF_Name = value; cF_Name_IsChanged=true; }
      }
      public bool CF_Name_IsChanged
      {
         get{ return cF_Name_IsChanged; }
         set{ cF_Name_IsChanged = value; }
      }
      private string cF_Path;
      private bool cF_Path_IsChanged=false;
      public string CF_Path
      {
         get{ return cF_Path; }
         set{ cF_Path = value; cF_Path_IsChanged=true; }
      }
      public bool CF_Path_IsChanged
      {
         get{ return cF_Path_IsChanged; }
         set{ cF_Path_IsChanged = value; }
      }
      private string cF_Cate;
      private bool cF_Cate_IsChanged=false;
      public string CF_Cate
      {
         get{ return cF_Cate; }
         set{ cF_Cate = value; cF_Cate_IsChanged=true; }
      }
      public bool CF_Cate_IsChanged
      {
         get{ return cF_Cate_IsChanged; }
         set{ cF_Cate_IsChanged = value; }
      }
      private string cF_CateName;
      private bool cF_CateName_IsChanged=false;
      public string CF_CateName
      {
         get{ return cF_CateName; }
         set{ cF_CateName = value; cF_CateName_IsChanged=true; }
      }
      public bool CF_CateName_IsChanged
      {
         get{ return cF_CateName_IsChanged; }
         set{ cF_CateName_IsChanged = value; }
      }
      private string cF_Type;
      private bool cF_Type_IsChanged=false;
      public string CF_Type
      {
         get{ return cF_Type; }
         set{ cF_Type = value; cF_Type_IsChanged=true; }
      }
      public bool CF_Type_IsChanged
      {
         get{ return cF_Type_IsChanged; }
         set{ cF_Type_IsChanged = value; }
      }
      private string cF_TypeName;
      private bool cF_TypeName_IsChanged=false;
      public string CF_TypeName
      {
         get{ return cF_TypeName; }
         set{ cF_TypeName = value; cF_TypeName_IsChanged=true; }
      }
      public bool CF_TypeName_IsChanged
      {
         get{ return cF_TypeName_IsChanged; }
         set{ cF_TypeName_IsChanged = value; }
      }
      private string cF_iType;
      private bool cF_iType_IsChanged=false;
      public string CF_iType
      {
         get{ return cF_iType; }
         set{ cF_iType = value; cF_iType_IsChanged=true; }
      }
      public bool CF_iType_IsChanged
      {
         get{ return cF_iType_IsChanged; }
         set{ cF_iType_IsChanged = value; }
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
      private string cF_Bak;
      private bool cF_Bak_IsChanged=false;
      public string CF_Bak
      {
         get{ return cF_Bak; }
         set{ cF_Bak = value; cF_Bak_IsChanged=true; }
      }
      public bool CF_Bak_IsChanged
      {
         get{ return cF_Bak_IsChanged; }
         set{ cF_Bak_IsChanged = value; }
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
      private string cF_Creator;
      private bool cF_Creator_IsChanged=false;
      public string CF_Creator
      {
         get{ return cF_Creator; }
         set{ cF_Creator = value; cF_Creator_IsChanged=true; }
      }
      public bool CF_Creator_IsChanged
      {
         get{ return cF_Creator_IsChanged; }
         set{ cF_Creator_IsChanged = value; }
      }
      private string cF_CreatorName;
      private bool cF_CreatorName_IsChanged=false;
      public string CF_CreatorName
      {
         get{ return cF_CreatorName; }
         set{ cF_CreatorName = value; cF_CreatorName_IsChanged=true; }
      }
      public bool CF_CreatorName_IsChanged
      {
         get{ return cF_CreatorName_IsChanged; }
         set{ cF_CreatorName_IsChanged = value; }
      }
   }
}
