using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PC_MRItem
   {
      private decimal pCMI_ID;
      private bool pCMI_ID_IsChanged=false;
      public decimal PCMI_ID
      {
         get{ return pCMI_ID; }
         set{ pCMI_ID = value; pCMI_ID_IsChanged=true; }
      }
      public bool PCMI_ID_IsChanged
      {
         get{ return pCMI_ID_IsChanged; }
         set{ pCMI_ID_IsChanged = value; }
      }
      private string pCMI_Code;
      private bool pCMI_Code_IsChanged=false;
      public string PCMI_Code
      {
         get{ return pCMI_Code; }
         set{ pCMI_Code = value; pCMI_Code_IsChanged=true; }
      }
      public bool PCMI_Code_IsChanged
      {
         get{ return pCMI_Code_IsChanged; }
         set{ pCMI_Code_IsChanged = value; }
      }
      private string pCMI_TCode;
      private bool pCMI_TCode_IsChanged=false;
      public string PCMI_TCode
      {
         get{ return pCMI_TCode; }
         set{ pCMI_TCode = value; pCMI_TCode_IsChanged=true; }
      }
      public bool PCMI_TCode_IsChanged
      {
         get{ return pCMI_TCode_IsChanged; }
         set{ pCMI_TCode_IsChanged = value; }
      }
      private string pCMI_WCode;
      private bool pCMI_WCode_IsChanged=false;
      public string PCMI_WCode
      {
         get{ return pCMI_WCode; }
         set{ pCMI_WCode = value; pCMI_WCode_IsChanged=true; }
      }
      public bool PCMI_WCode_IsChanged
      {
         get{ return pCMI_WCode_IsChanged; }
         set{ pCMI_WCode_IsChanged = value; }
      }
      private string pCMI_WNo;
      private bool pCMI_WNo_IsChanged=false;
      public string PCMI_WNo
      {
         get{ return pCMI_WNo; }
         set{ pCMI_WNo = value; pCMI_WNo_IsChanged=true; }
      }
      public bool PCMI_WNo_IsChanged
      {
         get{ return pCMI_WNo_IsChanged; }
         set{ pCMI_WNo_IsChanged = value; }
      }
      private string pCMI_MCode;
      private bool pCMI_MCode_IsChanged=false;
      public string PCMI_MCode
      {
         get{ return pCMI_MCode; }
         set{ pCMI_MCode = value; pCMI_MCode_IsChanged=true; }
      }
      public bool PCMI_MCode_IsChanged
      {
         get{ return pCMI_MCode_IsChanged; }
         set{ pCMI_MCode_IsChanged = value; }
      }
      private string pCMI_MName;
      private bool pCMI_MName_IsChanged=false;
      public string PCMI_MName
      {
         get{ return pCMI_MName; }
         set{ pCMI_MName = value; pCMI_MName_IsChanged=true; }
      }
      public bool PCMI_MName_IsChanged
      {
         get{ return pCMI_MName_IsChanged; }
         set{ pCMI_MName_IsChanged = value; }
      }
      private string pCMI_CCode;
      private bool pCMI_CCode_IsChanged=false;
      public string PCMI_CCode
      {
         get{ return pCMI_CCode; }
         set{ pCMI_CCode = value; pCMI_CCode_IsChanged=true; }
      }
      public bool PCMI_CCode_IsChanged
      {
         get{ return pCMI_CCode_IsChanged; }
         set{ pCMI_CCode_IsChanged = value; }
      }
      private string pCMI_Unit;
      private bool pCMI_Unit_IsChanged=false;
      public string PCMI_Unit
      {
         get{ return pCMI_Unit; }
         set{ pCMI_Unit = value; pCMI_Unit_IsChanged=true; }
      }
      public bool PCMI_Unit_IsChanged
      {
         get{ return pCMI_Unit_IsChanged; }
         set{ pCMI_Unit_IsChanged = value; }
      }
      private string pCMI_Spec;
      private bool pCMI_Spec_IsChanged=false;
      public string PCMI_Spec
      {
         get{ return pCMI_Spec; }
         set{ pCMI_Spec = value; pCMI_Spec_IsChanged=true; }
      }
      public bool PCMI_Spec_IsChanged
      {
         get{ return pCMI_Spec_IsChanged; }
         set{ pCMI_Spec_IsChanged = value; }
      }
      private decimal pCMI_Price;
      private bool pCMI_Price_IsChanged=false;
      public decimal PCMI_Price
      {
         get{ return pCMI_Price; }
         set{ pCMI_Price = value; pCMI_Price_IsChanged=true; }
      }
      public bool PCMI_Price_IsChanged
      {
         get{ return pCMI_Price_IsChanged; }
         set{ pCMI_Price_IsChanged = value; }
      }
      private decimal pCMI_Num;
      private bool pCMI_Num_IsChanged=false;
      public decimal PCMI_Num
      {
         get{ return pCMI_Num; }
         set{ pCMI_Num = value; pCMI_Num_IsChanged=true; }
      }
      public bool PCMI_Num_IsChanged
      {
         get{ return pCMI_Num_IsChanged; }
         set{ pCMI_Num_IsChanged = value; }
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
