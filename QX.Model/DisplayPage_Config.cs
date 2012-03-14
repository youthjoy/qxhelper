using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class DisplayPage_Config
   {
      private decimal dCP_ID;
      private bool dCP_ID_IsChanged=false;
      public decimal DCP_ID
      {
         get{ return dCP_ID; }
         set{ dCP_ID = value; dCP_ID_IsChanged=true; }
      }
      public bool DCP_ID_IsChanged
      {
         get{ return dCP_ID_IsChanged; }
         set{ dCP_ID_IsChanged = value; }
      }
      private string dCP_ModuleName;
      private bool dCP_ModuleName_IsChanged=false;
      public string DCP_ModuleName
      {
         get{ return dCP_ModuleName; }
         set{ dCP_ModuleName = value; dCP_ModuleName_IsChanged=true; }
      }
      public bool DCP_ModuleName_IsChanged
      {
         get{ return dCP_ModuleName_IsChanged; }
         set{ dCP_ModuleName_IsChanged = value; }
      }
      private string dCP_ControlID;
      private bool dCP_ControlID_IsChanged=false;
      public string DCP_ControlID
      {
         get{ return dCP_ControlID; }
         set{ dCP_ControlID = value; dCP_ControlID_IsChanged=true; }
      }
      public bool DCP_ControlID_IsChanged
      {
         get{ return dCP_ControlID_IsChanged; }
         set{ dCP_ControlID_IsChanged = value; }
      }
      private string dCP_Label;
      private bool dCP_Label_IsChanged=false;
      public string DCP_Label
      {
         get{ return dCP_Label; }
         set{ dCP_Label = value; dCP_Label_IsChanged=true; }
      }
      public bool DCP_Label_IsChanged
      {
         get{ return dCP_Label_IsChanged; }
         set{ dCP_Label_IsChanged = value; }
      }
      private string dCP_ControlType;
      private bool dCP_ControlType_IsChanged=false;
      public string DCP_ControlType
      {
         get{ return dCP_ControlType; }
         set{ dCP_ControlType = value; dCP_ControlType_IsChanged=true; }
      }
      public bool DCP_ControlType_IsChanged
      {
         get{ return dCP_ControlType_IsChanged; }
         set{ dCP_ControlType_IsChanged = value; }
      }
      private string dCP_Type;
      private bool dCP_Type_IsChanged=false;
      public string DCP_Type
      {
         get{ return dCP_Type; }
         set{ dCP_Type = value; dCP_Type_IsChanged=true; }
      }
      public bool DCP_Type_IsChanged
      {
         get{ return dCP_Type_IsChanged; }
         set{ dCP_Type_IsChanged = value; }
      }
      private string dCP_Style;
      private bool dCP_Style_IsChanged=false;
      public string DCP_Style
      {
         get{ return dCP_Style; }
         set{ dCP_Style = value; dCP_Style_IsChanged=true; }
      }
      public bool DCP_Style_IsChanged
      {
         get{ return dCP_Style_IsChanged; }
         set{ dCP_Style_IsChanged = value; }
      }
      private int dCP_Order;
      private bool dCP_Order_IsChanged=false;
      public int DCP_Order
      {
         get{ return dCP_Order; }
         set{ dCP_Order = value; dCP_Order_IsChanged=true; }
      }
      public bool DCP_Order_IsChanged
      {
         get{ return dCP_Order_IsChanged; }
         set{ dCP_Order_IsChanged = value; }
      }
      private int dCP_IsHidden;
      private bool dCP_IsHidden_IsChanged=false;
      public int DCP_IsHidden
      {
         get{ return dCP_IsHidden; }
         set{ dCP_IsHidden = value; dCP_IsHidden_IsChanged=true; }
      }
      public bool DCP_IsHidden_IsChanged
      {
         get{ return dCP_IsHidden_IsChanged; }
         set{ dCP_IsHidden_IsChanged = value; }
      }
      private int dCP_IsReadonly;
      private bool dCP_IsReadonly_IsChanged=false;
      public int DCP_IsReadonly
      {
         get{ return dCP_IsReadonly; }
         set{ dCP_IsReadonly = value; dCP_IsReadonly_IsChanged=true; }
      }
      public bool DCP_IsReadonly_IsChanged
      {
         get{ return dCP_IsReadonly_IsChanged; }
         set{ dCP_IsReadonly_IsChanged = value; }
      }
      private string dCP_UDef1;
      private bool dCP_UDef1_IsChanged=false;
      public string DCP_UDef1
      {
         get{ return dCP_UDef1; }
         set{ dCP_UDef1 = value; dCP_UDef1_IsChanged=true; }
      }
      public bool DCP_UDef1_IsChanged
      {
         get{ return dCP_UDef1_IsChanged; }
         set{ dCP_UDef1_IsChanged = value; }
      }
      private string dCP_UDef2;
      private bool dCP_UDef2_IsChanged=false;
      public string DCP_UDef2
      {
         get{ return dCP_UDef2; }
         set{ dCP_UDef2 = value; dCP_UDef2_IsChanged=true; }
      }
      public bool DCP_UDef2_IsChanged
      {
         get{ return dCP_UDef2_IsChanged; }
         set{ dCP_UDef2_IsChanged = value; }
      }
      private string dCP_PageName;
      private bool dCP_PageName_IsChanged=false;
      public string DCP_PageName
      {
         get{ return dCP_PageName; }
         set{ dCP_PageName = value; dCP_PageName_IsChanged=true; }
      }
      public bool DCP_PageName_IsChanged
      {
         get{ return dCP_PageName_IsChanged; }
         set{ dCP_PageName_IsChanged = value; }
      }
      private DateTime dCP_CreateTime;
      private bool dCP_CreateTime_IsChanged=false;
      public DateTime DCP_CreateTime
      {
         get{ return dCP_CreateTime; }
         set{ dCP_CreateTime = value; dCP_CreateTime_IsChanged=true; }
      }
      public bool DCP_CreateTime_IsChanged
      {
         get{ return dCP_CreateTime_IsChanged; }
         set{ dCP_CreateTime_IsChanged = value; }
      }
      private string dCP_Model;
      private bool dCP_Model_IsChanged=false;
      public string DCP_Model
      {
         get{ return dCP_Model; }
         set{ dCP_Model = value; dCP_Model_IsChanged=true; }
      }
      public bool DCP_Model_IsChanged
      {
         get{ return dCP_Model_IsChanged; }
         set{ dCP_Model_IsChanged = value; }
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
