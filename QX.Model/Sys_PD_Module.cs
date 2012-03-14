using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Sys_PD_Module
   {
      private Int64 sPM_ID;
      private bool sPM_ID_IsChanged=false;
      [MetaData("SPM_ID","")]
      public Int64 SPM_ID
      {
         get{ return sPM_ID; }
         set{ sPM_ID = value; sPM_ID_IsChanged=true; }
      }
      public bool SPM_ID_IsChanged
      {
         get{ return sPM_ID_IsChanged; }
         set{ sPM_ID_IsChanged = value; }
      }
      private string sPM_Module;
      private bool sPM_Module_IsChanged=false;
      [MetaData("SPM_Module","")]
      [StringLength(50, ErrorMessage = "长度不能超过50个字符")]
      public string SPM_Module
      {
         get{ return sPM_Module; }
         set{ sPM_Module = value; sPM_Module_IsChanged=true; }
      }
      public bool SPM_Module_IsChanged
      {
         get{ return sPM_Module_IsChanged; }
         set{ sPM_Module_IsChanged = value; }
      }
      private string sPM_LPrefix;
      private bool sPM_LPrefix_IsChanged=false;
      [MetaData("SPM_LPrefix","")]
      [StringLength(5, ErrorMessage = "长度不能超过5个字符")]
      public string SPM_LPrefix
      {
         get{ return sPM_LPrefix; }
         set{ sPM_LPrefix = value; sPM_LPrefix_IsChanged=true; }
      }
      public bool SPM_LPrefix_IsChanged
      {
         get{ return sPM_LPrefix_IsChanged; }
         set{ sPM_LPrefix_IsChanged = value; }
      }
      private string sPM_Name;
      private bool sPM_Name_IsChanged=false;
      [MetaData("SPM_Name","")]
      [StringLength(50, ErrorMessage = "长度不能超过50个字符")]
      public string SPM_Name
      {
         get{ return sPM_Name; }
         set{ sPM_Name = value; sPM_Name_IsChanged=true; }
      }
      public bool SPM_Name_IsChanged
      {
         get{ return sPM_Name_IsChanged; }
         set{ sPM_Name_IsChanged = value; }
      }
      private int sPM_LX;
      private bool sPM_LX_IsChanged=false;
      [MetaData("SPM_LX","")]
      public int SPM_LX
      {
         get{ return sPM_LX; }
         set{ sPM_LX = value; sPM_LX_IsChanged=true; }
      }
      public bool SPM_LX_IsChanged
      {
         get{ return sPM_LX_IsChanged; }
         set{ sPM_LX_IsChanged = value; }
      }
      private int sPM_LY;
      private bool sPM_LY_IsChanged=false;
      [MetaData("SPM_LY","")]
      public int SPM_LY
      {
         get{ return sPM_LY; }
         set{ sPM_LY = value; sPM_LY_IsChanged=true; }
      }
      public bool SPM_LY_IsChanged
      {
         get{ return sPM_LY_IsChanged; }
         set{ sPM_LY_IsChanged = value; }
      }
      private int sPM_TX;
      private bool sPM_TX_IsChanged=false;
      [MetaData("SPM_TX","")]
      public int SPM_TX
      {
         get{ return sPM_TX; }
         set{ sPM_TX = value; sPM_TX_IsChanged=true; }
      }
      public bool SPM_TX_IsChanged
      {
         get{ return sPM_TX_IsChanged; }
         set{ sPM_TX_IsChanged = value; }
      }
      private int sPM_TY;
      private bool sPM_TY_IsChanged=false;
      [MetaData("SPM_TY","")]
      public int SPM_TY
      {
         get{ return sPM_TY; }
         set{ sPM_TY = value; sPM_TY_IsChanged=true; }
      }
      public bool SPM_TY_IsChanged
      {
         get{ return sPM_TY_IsChanged; }
         set{ sPM_TY_IsChanged = value; }
      }
      private int sPM_LI;
      private bool sPM_LI_IsChanged=false;
      [MetaData("SPM_LI","")]
      public int SPM_LI
      {
         get{ return sPM_LI; }
         set{ sPM_LI = value; sPM_LI_IsChanged=true; }
      }
      public bool SPM_LI_IsChanged
      {
         get{ return sPM_LI_IsChanged; }
         set{ sPM_LI_IsChanged = value; }
      }
      private int sPM_TI;
      private bool sPM_TI_IsChanged=false;
      [MetaData("SPM_TI","")]
      public int SPM_TI
      {
         get{ return sPM_TI; }
         set{ sPM_TI = value; sPM_TI_IsChanged=true; }
      }
      public bool SPM_TI_IsChanged
      {
         get{ return sPM_TI_IsChanged; }
         set{ sPM_TI_IsChanged = value; }
      }
      private int sPM_CNum;
      private bool sPM_CNum_IsChanged=false;
      [MetaData("SPM_CNum","")]
      public int SPM_CNum
      {
         get{ return sPM_CNum; }
         set{ sPM_CNum = value; sPM_CNum_IsChanged=true; }
      }
      public bool SPM_CNum_IsChanged
      {
         get{ return sPM_CNum_IsChanged; }
         set{ sPM_CNum_IsChanged = value; }
      }
      private string sPM_TPrefix;
      private bool sPM_TPrefix_IsChanged=false;
      [MetaData("SPM_TPrefix","")]
      [StringLength(5, ErrorMessage = "长度不能超过5个字符")]
      public string SPM_TPrefix
      {
         get{ return sPM_TPrefix; }
         set{ sPM_TPrefix = value; sPM_TPrefix_IsChanged=true; }
      }
      public bool SPM_TPrefix_IsChanged
      {
         get{ return sPM_TPrefix_IsChanged; }
         set{ sPM_TPrefix_IsChanged = value; }
      }
      private int sPM_Height;
      private bool sPM_Height_IsChanged=false;
      [MetaData("SPM_Height","")]
      public int SPM_Height
      {
         get{ return sPM_Height; }
         set{ sPM_Height = value; sPM_Height_IsChanged=true; }
      }
      public bool SPM_Height_IsChanged
      {
         get{ return sPM_Height_IsChanged; }
         set{ sPM_Height_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      [MetaData("Stat","")]
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
