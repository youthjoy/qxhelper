using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PC_WError
   {
      private decimal pCWE_ID;
      private bool pCWE_ID_IsChanged=false;
      public decimal PCWE_ID
      {
         get{ return pCWE_ID; }
         set{ pCWE_ID = value; pCWE_ID_IsChanged=true; }
      }
      public bool PCWE_ID_IsChanged
      {
         get{ return pCWE_ID_IsChanged; }
         set{ pCWE_ID_IsChanged = value; }
      }
      private string pCWE_Code;
      private bool pCWE_Code_IsChanged=false;
      public string PCWE_Code
      {
         get{ return pCWE_Code; }
         set{ pCWE_Code = value; pCWE_Code_IsChanged=true; }
      }
      public bool PCWE_Code_IsChanged
      {
         get{ return pCWE_Code_IsChanged; }
         set{ pCWE_Code_IsChanged = value; }
      }
      private string pCWE_Module;
      private bool pCWE_Module_IsChanged=false;
      public string PCWE_Module
      {
         get{ return pCWE_Module; }
         set{ pCWE_Module = value; pCWE_Module_IsChanged=true; }
      }
      public bool PCWE_Module_IsChanged
      {
         get{ return pCWE_Module_IsChanged; }
         set{ pCWE_Module_IsChanged = value; }
      }
      private string pCWE_WHCode;
      private bool pCWE_WHCode_IsChanged=false;
      public string PCWE_WHCode
      {
         get{ return pCWE_WHCode; }
         set{ pCWE_WHCode = value; pCWE_WHCode_IsChanged=true; }
      }
      public bool PCWE_WHCode_IsChanged
      {
         get{ return pCWE_WHCode_IsChanged; }
         set{ pCWE_WHCode_IsChanged = value; }
      }
      private string pCWE_WHName;
      private bool pCWE_WHName_IsChanged=false;
      public string PCWE_WHName
      {
         get{ return pCWE_WHName; }
         set{ pCWE_WHName = value; pCWE_WHName_IsChanged=true; }
      }
      public bool PCWE_WHName_IsChanged
      {
         get{ return pCWE_WHName_IsChanged; }
         set{ pCWE_WHName_IsChanged = value; }
      }
      private string pCWE_MCode;
      private bool pCWE_MCode_IsChanged=false;
      public string PCWE_MCode
      {
         get{ return pCWE_MCode; }
         set{ pCWE_MCode = value; pCWE_MCode_IsChanged=true; }
      }
      public bool PCWE_MCode_IsChanged
      {
         get{ return pCWE_MCode_IsChanged; }
         set{ pCWE_MCode_IsChanged = value; }
      }
      private string pCWE_MName;
      private bool pCWE_MName_IsChanged=false;
      public string PCWE_MName
      {
         get{ return pCWE_MName; }
         set{ pCWE_MName = value; pCWE_MName_IsChanged=true; }
      }
      public bool PCWE_MName_IsChanged
      {
         get{ return pCWE_MName_IsChanged; }
         set{ pCWE_MName_IsChanged = value; }
      }
      private string pCWE_Unit;
      private bool pCWE_Unit_IsChanged=false;
      public string PCWE_Unit
      {
         get{ return pCWE_Unit; }
         set{ pCWE_Unit = value; pCWE_Unit_IsChanged=true; }
      }
      public bool PCWE_Unit_IsChanged
      {
         get{ return pCWE_Unit_IsChanged; }
         set{ pCWE_Unit_IsChanged = value; }
      }
      private decimal pCWE_Num;
      private bool pCWE_Num_IsChanged=false;
      public decimal PCWE_Num
      {
         get{ return pCWE_Num; }
         set{ pCWE_Num = value; pCWE_Num_IsChanged=true; }
      }
      public bool PCWE_Num_IsChanged
      {
         get{ return pCWE_Num_IsChanged; }
         set{ pCWE_Num_IsChanged = value; }
      }
      private string pCWE_Operator;
      private bool pCWE_Operator_IsChanged=false;
      public string PCWE_Operator
      {
         get{ return pCWE_Operator; }
         set{ pCWE_Operator = value; pCWE_Operator_IsChanged=true; }
      }
      public bool PCWE_Operator_IsChanged
      {
         get{ return pCWE_Operator_IsChanged; }
         set{ pCWE_Operator_IsChanged = value; }
      }
      private DateTime pCWE_OpDate;
      private bool pCWE_OpDate_IsChanged=false;
      public DateTime PCWE_OpDate
      {
         get{ return pCWE_OpDate; }
         set{ pCWE_OpDate = value; pCWE_OpDate_IsChanged=true; }
      }
      public bool PCWE_OpDate_IsChanged
      {
         get{ return pCWE_OpDate_IsChanged; }
         set{ pCWE_OpDate_IsChanged = value; }
      }
      private string pCWE_Bak;
      private bool pCWE_Bak_IsChanged=false;
      public string PCWE_Bak
      {
         get{ return pCWE_Bak; }
         set{ pCWE_Bak = value; pCWE_Bak_IsChanged=true; }
      }
      public bool PCWE_Bak_IsChanged
      {
         get{ return pCWE_Bak_IsChanged; }
         set{ pCWE_Bak_IsChanged = value; }
      }
      /// <summary>
      /// ??
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// ??
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// ??
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
