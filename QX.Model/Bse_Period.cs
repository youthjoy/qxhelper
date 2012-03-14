using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 系统账期
   /// </summary>
   [Serializable]
   public partial class Bse_Period
   {
      private decimal bP_ID;
      private bool bP_ID_IsChanged=false;
      public decimal BP_ID
      {
         get{ return bP_ID; }
         set{ bP_ID = value; bP_ID_IsChanged=true; }
      }
      public bool BP_ID_IsChanged
      {
         get{ return bP_ID_IsChanged; }
         set{ bP_ID_IsChanged = value; }
      }
      private string bP_Year;
      private bool bP_Year_IsChanged=false;
      public string BP_Year
      {
         get{ return bP_Year; }
         set{ bP_Year = value; bP_Year_IsChanged=true; }
      }
      public bool BP_Year_IsChanged
      {
         get{ return bP_Year_IsChanged; }
         set{ bP_Year_IsChanged = value; }
      }
      private string bP_Month;
      private bool bP_Month_IsChanged=false;
      public string BP_Month
      {
         get{ return bP_Month; }
         set{ bP_Month = value; bP_Month_IsChanged=true; }
      }
      public bool BP_Month_IsChanged
      {
         get{ return bP_Month_IsChanged; }
         set{ bP_Month_IsChanged = value; }
      }
      private string bP_Code;
      private bool bP_Code_IsChanged=false;
      public string BP_Code
      {
         get{ return bP_Code; }
         set{ bP_Code = value; bP_Code_IsChanged=true; }
      }
      public bool BP_Code_IsChanged
      {
         get{ return bP_Code_IsChanged; }
         set{ bP_Code_IsChanged = value; }
      }
      private DateTime bP_Start;
      private bool bP_Start_IsChanged=false;
      public DateTime BP_Start
      {
         get{ return bP_Start; }
         set{ bP_Start = value; bP_Start_IsChanged=true; }
      }
      public bool BP_Start_IsChanged
      {
         get{ return bP_Start_IsChanged; }
         set{ bP_Start_IsChanged = value; }
      }
      private DateTime bP_End;
      private bool bP_End_IsChanged=false;
      public DateTime BP_End
      {
         get{ return bP_End; }
         set{ bP_End = value; bP_End_IsChanged=true; }
      }
      public bool BP_End_IsChanged
      {
         get{ return bP_End_IsChanged; }
         set{ bP_End_IsChanged = value; }
      }
      private string bP_IsCurrent;
      private bool bP_IsCurrent_IsChanged=false;
      public string BP_IsCurrent
      {
         get{ return bP_IsCurrent; }
         set{ bP_IsCurrent = value; bP_IsCurrent_IsChanged=true; }
      }
      public bool BP_IsCurrent_IsChanged
      {
         get{ return bP_IsCurrent_IsChanged; }
         set{ bP_IsCurrent_IsChanged = value; }
      }
      private string bP_Company;
      private bool bP_Company_IsChanged=false;
      public string BP_Company
      {
         get{ return bP_Company; }
         set{ bP_Company = value; bP_Company_IsChanged=true; }
      }
      public bool BP_Company_IsChanged
      {
         get{ return bP_Company_IsChanged; }
         set{ bP_Company_IsChanged = value; }
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
      private string bP_CompanyCode;
      private bool bP_CompanyCode_IsChanged=false;
      public string BP_CompanyCode
      {
         get{ return bP_CompanyCode; }
         set{ bP_CompanyCode = value; bP_CompanyCode_IsChanged=true; }
      }
      public bool BP_CompanyCode_IsChanged
      {
         get{ return bP_CompanyCode_IsChanged; }
         set{ bP_CompanyCode_IsChanged = value; }
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
