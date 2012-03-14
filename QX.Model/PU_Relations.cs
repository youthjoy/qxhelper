using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PU_Relations
   {
      private Int64 pUR_ID;
      private bool pUR_ID_IsChanged=false;
      public Int64 PUR_ID
      {
         get{ return pUR_ID; }
         set{ pUR_ID = value; pUR_ID_IsChanged=true; }
      }
      public bool PUR_ID_IsChanged
      {
         get{ return pUR_ID_IsChanged; }
         set{ pUR_ID_IsChanged = value; }
      }
      private string pUR_SRCode;
      private bool pUR_SRCode_IsChanged=false;
      public string PUR_SRCode
      {
         get{ return pUR_SRCode; }
         set{ pUR_SRCode = value; pUR_SRCode_IsChanged=true; }
      }
      public bool PUR_SRCode_IsChanged
      {
         get{ return pUR_SRCode_IsChanged; }
         set{ pUR_SRCode_IsChanged = value; }
      }
      private string pUR_SRTpe;
      private bool pUR_SRTpe_IsChanged=false;
      public string PUR_SRTpe
      {
         get{ return pUR_SRTpe; }
         set{ pUR_SRTpe = value; pUR_SRTpe_IsChanged=true; }
      }
      public bool PUR_SRTpe_IsChanged
      {
         get{ return pUR_SRTpe_IsChanged; }
         set{ pUR_SRTpe_IsChanged = value; }
      }
      private string pUR_RCode;
      private bool pUR_RCode_IsChanged=false;
      public string PUR_RCode
      {
         get{ return pUR_RCode; }
         set{ pUR_RCode = value; pUR_RCode_IsChanged=true; }
      }
      public bool PUR_RCode_IsChanged
      {
         get{ return pUR_RCode_IsChanged; }
         set{ pUR_RCode_IsChanged = value; }
      }
      private string pUR_RType;
      private bool pUR_RType_IsChanged=false;
      public string PUR_RType
      {
         get{ return pUR_RType; }
         set{ pUR_RType = value; pUR_RType_IsChanged=true; }
      }
      public bool PUR_RType_IsChanged
      {
         get{ return pUR_RType_IsChanged; }
         set{ pUR_RType_IsChanged = value; }
      }
      private string pUR_MCode;
      private bool pUR_MCode_IsChanged=false;
      public string PUR_MCode
      {
         get{ return pUR_MCode; }
         set{ pUR_MCode = value; pUR_MCode_IsChanged=true; }
      }
      public bool PUR_MCode_IsChanged
      {
         get{ return pUR_MCode_IsChanged; }
         set{ pUR_MCode_IsChanged = value; }
      }
      private decimal pUR_SNum;
      private bool pUR_SNum_IsChanged=false;
      public decimal PUR_SNum
      {
         get{ return pUR_SNum; }
         set{ pUR_SNum = value; pUR_SNum_IsChanged=true; }
      }
      public bool PUR_SNum_IsChanged
      {
         get{ return pUR_SNum_IsChanged; }
         set{ pUR_SNum_IsChanged = value; }
      }
      private decimal pUR_Num;
      private bool pUR_Num_IsChanged=false;
      public decimal PUR_Num
      {
         get{ return pUR_Num; }
         set{ pUR_Num = value; pUR_Num_IsChanged=true; }
      }
      public bool PUR_Num_IsChanged
      {
         get{ return pUR_Num_IsChanged; }
         set{ pUR_Num_IsChanged = value; }
      }
      private DateTime pUR_Date;
      private bool pUR_Date_IsChanged=false;
      public DateTime PUR_Date
      {
         get{ return pUR_Date; }
         set{ pUR_Date = value; pUR_Date_IsChanged=true; }
      }
      public bool PUR_Date_IsChanged
      {
         get{ return pUR_Date_IsChanged; }
         set{ pUR_Date_IsChanged = value; }
      }
      private string pUR_Owner;
      private bool pUR_Owner_IsChanged=false;
      public string PUR_Owner
      {
         get{ return pUR_Owner; }
         set{ pUR_Owner = value; pUR_Owner_IsChanged=true; }
      }
      public bool PUR_Owner_IsChanged
      {
         get{ return pUR_Owner_IsChanged; }
         set{ pUR_Owner_IsChanged = value; }
      }
      private string pUR_OwnerCode;
      private bool pUR_OwnerCode_IsChanged=false;
      public string PUR_OwnerCode
      {
         get{ return pUR_OwnerCode; }
         set{ pUR_OwnerCode = value; pUR_OwnerCode_IsChanged=true; }
      }
      public bool PUR_OwnerCode_IsChanged
      {
         get{ return pUR_OwnerCode_IsChanged; }
         set{ pUR_OwnerCode_IsChanged = value; }
      }
      private string pUR_Udef1;
      private bool pUR_Udef1_IsChanged=false;
      public string PUR_Udef1
      {
         get{ return pUR_Udef1; }
         set{ pUR_Udef1 = value; pUR_Udef1_IsChanged=true; }
      }
      public bool PUR_Udef1_IsChanged
      {
         get{ return pUR_Udef1_IsChanged; }
         set{ pUR_Udef1_IsChanged = value; }
      }
      private string pUR_Udef2;
      private bool pUR_Udef2_IsChanged=false;
      public string PUR_Udef2
      {
         get{ return pUR_Udef2; }
         set{ pUR_Udef2 = value; pUR_Udef2_IsChanged=true; }
      }
      public bool PUR_Udef2_IsChanged
      {
         get{ return pUR_Udef2_IsChanged; }
         set{ pUR_Udef2_IsChanged = value; }
      }
      private string pUR_Udef3;
      private bool pUR_Udef3_IsChanged=false;
      public string PUR_Udef3
      {
         get{ return pUR_Udef3; }
         set{ pUR_Udef3 = value; pUR_Udef3_IsChanged=true; }
      }
      public bool PUR_Udef3_IsChanged
      {
         get{ return pUR_Udef3_IsChanged; }
         set{ pUR_Udef3_IsChanged = value; }
      }
      private string pUR_Udef4;
      private bool pUR_Udef4_IsChanged=false;
      public string PUR_Udef4
      {
         get{ return pUR_Udef4; }
         set{ pUR_Udef4 = value; pUR_Udef4_IsChanged=true; }
      }
      public bool PUR_Udef4_IsChanged
      {
         get{ return pUR_Udef4_IsChanged; }
         set{ pUR_Udef4_IsChanged = value; }
      }
      private string pUR_Udef5;
      private bool pUR_Udef5_IsChanged=false;
      public string PUR_Udef5
      {
         get{ return pUR_Udef5; }
         set{ pUR_Udef5 = value; pUR_Udef5_IsChanged=true; }
      }
      public bool PUR_Udef5_IsChanged
      {
         get{ return pUR_Udef5_IsChanged; }
         set{ pUR_Udef5_IsChanged = value; }
      }
      private string stat;
      private bool stat_IsChanged=false;
      public string Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
