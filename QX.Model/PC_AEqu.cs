using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 设备安排
   /// </summary>
   [Serializable]
   public partial class PC_AEqu
   {
      private decimal pCAS_ID;
      private bool pCAS_ID_IsChanged=false;
      public decimal PCAS_ID
      {
         get{ return pCAS_ID; }
         set{ pCAS_ID = value; pCAS_ID_IsChanged=true; }
      }
      public bool PCAS_ID_IsChanged
      {
         get{ return pCAS_ID_IsChanged; }
         set{ pCAS_ID_IsChanged = value; }
      }
      private string pCAS_Code;
      private bool pCAS_Code_IsChanged=false;
      public string PCAS_Code
      {
         get{ return pCAS_Code; }
         set{ pCAS_Code = value; pCAS_Code_IsChanged=true; }
      }
      public bool PCAS_Code_IsChanged
      {
         get{ return pCAS_Code_IsChanged; }
         set{ pCAS_Code_IsChanged = value; }
      }
      private string pCAS_PCode;
      private bool pCAS_PCode_IsChanged=false;
      public string PCAS_PCode
      {
         get{ return pCAS_PCode; }
         set{ pCAS_PCode = value; pCAS_PCode_IsChanged=true; }
      }
      public bool PCAS_PCode_IsChanged
      {
         get{ return pCAS_PCode_IsChanged; }
         set{ pCAS_PCode_IsChanged = value; }
      }
      private string pCAS_Type;
      private bool pCAS_Type_IsChanged=false;
      public string PCAS_Type
      {
         get{ return pCAS_Type; }
         set{ pCAS_Type = value; pCAS_Type_IsChanged=true; }
      }
      public bool PCAS_Type_IsChanged
      {
         get{ return pCAS_Type_IsChanged; }
         set{ pCAS_Type_IsChanged = value; }
      }
      private string pCAS_ECode;
      private bool pCAS_ECode_IsChanged=false;
      public string PCAS_ECode
      {
         get{ return pCAS_ECode; }
         set{ pCAS_ECode = value; pCAS_ECode_IsChanged=true; }
      }
      public bool PCAS_ECode_IsChanged
      {
         get{ return pCAS_ECode_IsChanged; }
         set{ pCAS_ECode_IsChanged = value; }
      }
      private string pCAS_EName;
      private bool pCAS_EName_IsChanged=false;
      public string PCAS_EName
      {
         get{ return pCAS_EName; }
         set{ pCAS_EName = value; pCAS_EName_IsChanged=true; }
      }
      public bool PCAS_EName_IsChanged
      {
         get{ return pCAS_EName_IsChanged; }
         set{ pCAS_EName_IsChanged = value; }
      }
      private string pCAS_Owner;
      private bool pCAS_Owner_IsChanged=false;
      public string PCAS_Owner
      {
         get{ return pCAS_Owner; }
         set{ pCAS_Owner = value; pCAS_Owner_IsChanged=true; }
      }
      public bool PCAS_Owner_IsChanged
      {
         get{ return pCAS_Owner_IsChanged; }
         set{ pCAS_Owner_IsChanged = value; }
      }
      private string pCAS_OContact;
      private bool pCAS_OContact_IsChanged=false;
      public string PCAS_OContact
      {
         get{ return pCAS_OContact; }
         set{ pCAS_OContact = value; pCAS_OContact_IsChanged=true; }
      }
      public bool PCAS_OContact_IsChanged
      {
         get{ return pCAS_OContact_IsChanged; }
         set{ pCAS_OContact_IsChanged = value; }
      }
      private decimal pCAS_Num;
      private bool pCAS_Num_IsChanged=false;
      public decimal PCAS_Num
      {
         get{ return pCAS_Num; }
         set{ pCAS_Num = value; pCAS_Num_IsChanged=true; }
      }
      public bool PCAS_Num_IsChanged
      {
         get{ return pCAS_Num_IsChanged; }
         set{ pCAS_Num_IsChanged = value; }
      }
      private string pCAS_Bak;
      private bool pCAS_Bak_IsChanged=false;
      public string PCAS_Bak
      {
         get{ return pCAS_Bak; }
         set{ pCAS_Bak = value; pCAS_Bak_IsChanged=true; }
      }
      public bool PCAS_Bak_IsChanged
      {
         get{ return pCAS_Bak_IsChanged; }
         set{ pCAS_Bak_IsChanged = value; }
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
