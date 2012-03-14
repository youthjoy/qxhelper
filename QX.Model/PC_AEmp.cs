using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产人员安排
   /// </summary>
   [Serializable]
   public partial class PC_AEmp
   {
      private decimal pCAE_ID;
      private bool pCAE_ID_IsChanged=false;
      public decimal PCAE_ID
      {
         get{ return pCAE_ID; }
         set{ pCAE_ID = value; pCAE_ID_IsChanged=true; }
      }
      public bool PCAE_ID_IsChanged
      {
         get{ return pCAE_ID_IsChanged; }
         set{ pCAE_ID_IsChanged = value; }
      }
      private string pCAE_PCode;
      private bool pCAE_PCode_IsChanged=false;
      public string PCAE_PCode
      {
         get{ return pCAE_PCode; }
         set{ pCAE_PCode = value; pCAE_PCode_IsChanged=true; }
      }
      public bool PCAE_PCode_IsChanged
      {
         get{ return pCAE_PCode_IsChanged; }
         set{ pCAE_PCode_IsChanged = value; }
      }
      private string pCAE_ACode;
      private bool pCAE_ACode_IsChanged=false;
      public string PCAE_ACode
      {
         get{ return pCAE_ACode; }
         set{ pCAE_ACode = value; pCAE_ACode_IsChanged=true; }
      }
      public bool PCAE_ACode_IsChanged
      {
         get{ return pCAE_ACode_IsChanged; }
         set{ pCAE_ACode_IsChanged = value; }
      }
      private string pCAE_Type;
      private bool pCAE_Type_IsChanged=false;
      public string PCAE_Type
      {
         get{ return pCAE_Type; }
         set{ pCAE_Type = value; pCAE_Type_IsChanged=true; }
      }
      public bool PCAE_Type_IsChanged
      {
         get{ return pCAE_Type_IsChanged; }
         set{ pCAE_Type_IsChanged = value; }
      }
      private string pCAE_ECode;
      private bool pCAE_ECode_IsChanged=false;
      public string PCAE_ECode
      {
         get{ return pCAE_ECode; }
         set{ pCAE_ECode = value; pCAE_ECode_IsChanged=true; }
      }
      public bool PCAE_ECode_IsChanged
      {
         get{ return pCAE_ECode_IsChanged; }
         set{ pCAE_ECode_IsChanged = value; }
      }
      private string pCAE_EName;
      private bool pCAE_EName_IsChanged=false;
      public string PCAE_EName
      {
         get{ return pCAE_EName; }
         set{ pCAE_EName = value; pCAE_EName_IsChanged=true; }
      }
      public bool PCAE_EName_IsChanged
      {
         get{ return pCAE_EName_IsChanged; }
         set{ pCAE_EName_IsChanged = value; }
      }
      private string pCAE_EContact;
      private bool pCAE_EContact_IsChanged=false;
      public string PCAE_EContact
      {
         get{ return pCAE_EContact; }
         set{ pCAE_EContact = value; pCAE_EContact_IsChanged=true; }
      }
      public bool PCAE_EContact_IsChanged
      {
         get{ return pCAE_EContact_IsChanged; }
         set{ pCAE_EContact_IsChanged = value; }
      }
      private DateTime pCAE_RDate;
      private bool pCAE_RDate_IsChanged=false;
      public DateTime PCAE_RDate
      {
         get{ return pCAE_RDate; }
         set{ pCAE_RDate = value; pCAE_RDate_IsChanged=true; }
      }
      public bool PCAE_RDate_IsChanged
      {
         get{ return pCAE_RDate_IsChanged; }
         set{ pCAE_RDate_IsChanged = value; }
      }
      private DateTime pCAE_LDate;
      private bool pCAE_LDate_IsChanged=false;
      public DateTime PCAE_LDate
      {
         get{ return pCAE_LDate; }
         set{ pCAE_LDate = value; pCAE_LDate_IsChanged=true; }
      }
      public bool PCAE_LDate_IsChanged
      {
         get{ return pCAE_LDate_IsChanged; }
         set{ pCAE_LDate_IsChanged = value; }
      }
      private int pCAE_Num;
      private bool pCAE_Num_IsChanged=false;
      public int PCAE_Num
      {
         get{ return pCAE_Num; }
         set{ pCAE_Num = value; pCAE_Num_IsChanged=true; }
      }
      public bool PCAE_Num_IsChanged
      {
         get{ return pCAE_Num_IsChanged; }
         set{ pCAE_Num_IsChanged = value; }
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
