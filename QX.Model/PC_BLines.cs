using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产线基本信息
   /// </summary>
   [Serializable]
   public partial class PC_BLines
   {
      private decimal pCBL_ID;
      private bool pCBL_ID_IsChanged=false;
      public decimal PCBL_ID
      {
         get{ return pCBL_ID; }
         set{ pCBL_ID = value; pCBL_ID_IsChanged=true; }
      }
      public bool PCBL_ID_IsChanged
      {
         get{ return pCBL_ID_IsChanged; }
         set{ pCBL_ID_IsChanged = value; }
      }
      private string pCBL_Code;
      private bool pCBL_Code_IsChanged=false;
      public string PCBL_Code
      {
         get{ return pCBL_Code; }
         set{ pCBL_Code = value; pCBL_Code_IsChanged=true; }
      }
      public bool PCBL_Code_IsChanged
      {
         get{ return pCBL_Code_IsChanged; }
         set{ pCBL_Code_IsChanged = value; }
      }
      private string pCBL_SCode;
      private bool pCBL_SCode_IsChanged=false;
      public string PCBL_SCode
      {
         get{ return pCBL_SCode; }
         set{ pCBL_SCode = value; pCBL_SCode_IsChanged=true; }
      }
      public bool PCBL_SCode_IsChanged
      {
         get{ return pCBL_SCode_IsChanged; }
         set{ pCBL_SCode_IsChanged = value; }
      }
      private string pCBL_Name;
      private bool pCBL_Name_IsChanged=false;
      public string PCBL_Name
      {
         get{ return pCBL_Name; }
         set{ pCBL_Name = value; pCBL_Name_IsChanged=true; }
      }
      public bool PCBL_Name_IsChanged
      {
         get{ return pCBL_Name_IsChanged; }
         set{ pCBL_Name_IsChanged = value; }
      }
      private string pCBL_Description;
      private bool pCBL_Description_IsChanged=false;
      public string PCBL_Description
      {
         get{ return pCBL_Description; }
         set{ pCBL_Description = value; pCBL_Description_IsChanged=true; }
      }
      public bool PCBL_Description_IsChanged
      {
         get{ return pCBL_Description_IsChanged; }
         set{ pCBL_Description_IsChanged = value; }
      }
      private string pCBL_Remark;
      private bool pCBL_Remark_IsChanged=false;
      public string PCBL_Remark
      {
         get{ return pCBL_Remark; }
         set{ pCBL_Remark = value; pCBL_Remark_IsChanged=true; }
      }
      public bool PCBL_Remark_IsChanged
      {
         get{ return pCBL_Remark_IsChanged; }
         set{ pCBL_Remark_IsChanged = value; }
      }
      private string pCBL_Stat;
      private bool pCBL_Stat_IsChanged=false;
      public string PCBL_Stat
      {
         get{ return pCBL_Stat; }
         set{ pCBL_Stat = value; pCBL_Stat_IsChanged=true; }
      }
      public bool PCBL_Stat_IsChanged
      {
         get{ return pCBL_Stat_IsChanged; }
         set{ pCBL_Stat_IsChanged = value; }
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
