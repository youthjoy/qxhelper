using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PCD_Queue
   {
      private Int64 pCDO_ID;
      private bool pCDO_ID_IsChanged=false;
      public Int64 PCDO_ID
      {
         get{ return pCDO_ID; }
         set{ pCDO_ID = value; pCDO_ID_IsChanged=true; }
      }
      public bool PCDO_ID_IsChanged
      {
         get{ return pCDO_ID_IsChanged; }
         set{ pCDO_ID_IsChanged = value; }
      }
      private string pCDO_PlanCode;
      private bool pCDO_PlanCode_IsChanged=false;
      public string PCDO_PlanCode
      {
         get{ return pCDO_PlanCode; }
         set{ pCDO_PlanCode = value; pCDO_PlanCode_IsChanged=true; }
      }
      public bool PCDO_PlanCode_IsChanged
      {
         get{ return pCDO_PlanCode_IsChanged; }
         set{ pCDO_PlanCode_IsChanged = value; }
      }
      private string pCDO_NCode;
      private bool pCDO_NCode_IsChanged=false;
      public string PCDO_NCode
      {
         get{ return pCDO_NCode; }
         set{ pCDO_NCode = value; pCDO_NCode_IsChanged=true; }
      }
      public bool PCDO_NCode_IsChanged
      {
         get{ return pCDO_NCode_IsChanged; }
         set{ pCDO_NCode_IsChanged = value; }
      }
      private int pCDO_Order;
      private bool pCDO_Order_IsChanged=false;
      public int PCDO_Order
      {
         get{ return pCDO_Order; }
         set{ pCDO_Order = value; pCDO_Order_IsChanged=true; }
      }
      public bool PCDO_Order_IsChanged
      {
         get{ return pCDO_Order_IsChanged; }
         set{ pCDO_Order_IsChanged = value; }
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
   }
}
