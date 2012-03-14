using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 单据参考依赖关系
   /// </summary>
   [Serializable]
   public partial class Sys_Rec_RefDepend
   {
      private decimal refDepend_ID;
      private bool refDepend_ID_IsChanged=false;
      public decimal RefDepend_ID
      {
         get{ return refDepend_ID; }
         set{ refDepend_ID = value; refDepend_ID_IsChanged=true; }
      }
      public bool RefDepend_ID_IsChanged
      {
         get{ return refDepend_ID_IsChanged; }
         set{ refDepend_ID_IsChanged = value; }
      }
      private string refDepend_Code;
      private bool refDepend_Code_IsChanged=false;
      public string RefDepend_Code
      {
         get{ return refDepend_Code; }
         set{ refDepend_Code = value; refDepend_Code_IsChanged=true; }
      }
      public bool RefDepend_Code_IsChanged
      {
         get{ return refDepend_Code_IsChanged; }
         set{ refDepend_Code_IsChanged = value; }
      }
      private string refDepend_Type;
      private bool refDepend_Type_IsChanged=false;
      public string RefDepend_Type
      {
         get{ return refDepend_Type; }
         set{ refDepend_Type = value; refDepend_Type_IsChanged=true; }
      }
      public bool RefDepend_Type_IsChanged
      {
         get{ return refDepend_Type_IsChanged; }
         set{ refDepend_Type_IsChanged = value; }
      }
      private string refDepend_Object;
      private bool refDepend_Object_IsChanged=false;
      public string RefDepend_Object
      {
         get{ return refDepend_Object; }
         set{ refDepend_Object = value; refDepend_Object_IsChanged=true; }
      }
      public bool RefDepend_Object_IsChanged
      {
         get{ return refDepend_Object_IsChanged; }
         set{ refDepend_Object_IsChanged = value; }
      }
      private string refDepend_ObjectName;
      private bool refDepend_ObjectName_IsChanged=false;
      public string RefDepend_ObjectName
      {
         get{ return refDepend_ObjectName; }
         set{ refDepend_ObjectName = value; refDepend_ObjectName_IsChanged=true; }
      }
      public bool RefDepend_ObjectName_IsChanged
      {
         get{ return refDepend_ObjectName_IsChanged; }
         set{ refDepend_ObjectName_IsChanged = value; }
      }
      private string refDepend_ShowMain;
      private bool refDepend_ShowMain_IsChanged=false;
      public string RefDepend_ShowMain
      {
         get{ return refDepend_ShowMain; }
         set{ refDepend_ShowMain = value; refDepend_ShowMain_IsChanged=true; }
      }
      public bool RefDepend_ShowMain_IsChanged
      {
         get{ return refDepend_ShowMain_IsChanged; }
         set{ refDepend_ShowMain_IsChanged = value; }
      }
      private string refDepend_ShowOther;
      private bool refDepend_ShowOther_IsChanged=false;
      public string RefDepend_ShowOther
      {
         get{ return refDepend_ShowOther; }
         set{ refDepend_ShowOther = value; refDepend_ShowOther_IsChanged=true; }
      }
      public bool RefDepend_ShowOther_IsChanged
      {
         get{ return refDepend_ShowOther_IsChanged; }
         set{ refDepend_ShowOther_IsChanged = value; }
      }
      private string refDepend_ShowName;
      private bool refDepend_ShowName_IsChanged=false;
      public string RefDepend_ShowName
      {
         get{ return refDepend_ShowName; }
         set{ refDepend_ShowName = value; refDepend_ShowName_IsChanged=true; }
      }
      public bool RefDepend_ShowName_IsChanged
      {
         get{ return refDepend_ShowName_IsChanged; }
         set{ refDepend_ShowName_IsChanged = value; }
      }
      private string refDepend_UDEF1;
      private bool refDepend_UDEF1_IsChanged=false;
      public string RefDepend_UDEF1
      {
         get{ return refDepend_UDEF1; }
         set{ refDepend_UDEF1 = value; refDepend_UDEF1_IsChanged=true; }
      }
      public bool RefDepend_UDEF1_IsChanged
      {
         get{ return refDepend_UDEF1_IsChanged; }
         set{ refDepend_UDEF1_IsChanged = value; }
      }
      private string refDepend_UDEF2;
      private bool refDepend_UDEF2_IsChanged=false;
      public string RefDepend_UDEF2
      {
         get{ return refDepend_UDEF2; }
         set{ refDepend_UDEF2 = value; refDepend_UDEF2_IsChanged=true; }
      }
      public bool RefDepend_UDEF2_IsChanged
      {
         get{ return refDepend_UDEF2_IsChanged; }
         set{ refDepend_UDEF2_IsChanged = value; }
      }
      private string refDepend_UDEF3;
      private bool refDepend_UDEF3_IsChanged=false;
      public string RefDepend_UDEF3
      {
         get{ return refDepend_UDEF3; }
         set{ refDepend_UDEF3 = value; refDepend_UDEF3_IsChanged=true; }
      }
      public bool RefDepend_UDEF3_IsChanged
      {
         get{ return refDepend_UDEF3_IsChanged; }
         set{ refDepend_UDEF3_IsChanged = value; }
      }
      private string refDepend_UDEF4;
      private bool refDepend_UDEF4_IsChanged=false;
      public string RefDepend_UDEF4
      {
         get{ return refDepend_UDEF4; }
         set{ refDepend_UDEF4 = value; refDepend_UDEF4_IsChanged=true; }
      }
      public bool RefDepend_UDEF4_IsChanged
      {
         get{ return refDepend_UDEF4_IsChanged; }
         set{ refDepend_UDEF4_IsChanged = value; }
      }
      private string refDepend_UDEF5;
      private bool refDepend_UDEF5_IsChanged=false;
      public string RefDepend_UDEF5
      {
         get{ return refDepend_UDEF5; }
         set{ refDepend_UDEF5 = value; refDepend_UDEF5_IsChanged=true; }
      }
      public bool RefDepend_UDEF5_IsChanged
      {
         get{ return refDepend_UDEF5_IsChanged; }
         set{ refDepend_UDEF5_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private string refDepend_UDEF6;
      private bool refDepend_UDEF6_IsChanged=false;
      public string RefDepend_UDEF6
      {
         get{ return refDepend_UDEF6; }
         set{ refDepend_UDEF6 = value; refDepend_UDEF6_IsChanged=true; }
      }
      public bool RefDepend_UDEF6_IsChanged
      {
         get{ return refDepend_UDEF6_IsChanged; }
         set{ refDepend_UDEF6_IsChanged = value; }
      }
      private string refDepend_UDEF7;
      private bool refDepend_UDEF7_IsChanged=false;
      public string RefDepend_UDEF7
      {
         get{ return refDepend_UDEF7; }
         set{ refDepend_UDEF7 = value; refDepend_UDEF7_IsChanged=true; }
      }
      public bool RefDepend_UDEF7_IsChanged
      {
         get{ return refDepend_UDEF7_IsChanged; }
         set{ refDepend_UDEF7_IsChanged = value; }
      }
      private string refDepend_UDEF8;
      private bool refDepend_UDEF8_IsChanged=false;
      public string RefDepend_UDEF8
      {
         get{ return refDepend_UDEF8; }
         set{ refDepend_UDEF8 = value; refDepend_UDEF8_IsChanged=true; }
      }
      public bool RefDepend_UDEF8_IsChanged
      {
         get{ return refDepend_UDEF8_IsChanged; }
         set{ refDepend_UDEF8_IsChanged = value; }
      }
      private string refDepend_UDEF9;
      private bool refDepend_UDEF9_IsChanged=false;
      public string RefDepend_UDEF9
      {
         get{ return refDepend_UDEF9; }
         set{ refDepend_UDEF9 = value; refDepend_UDEF9_IsChanged=true; }
      }
      public bool RefDepend_UDEF9_IsChanged
      {
         get{ return refDepend_UDEF9_IsChanged; }
         set{ refDepend_UDEF9_IsChanged = value; }
      }
      private string refDepend_UDEF10;
      private bool refDepend_UDEF10_IsChanged=false;
      public string RefDepend_UDEF10
      {
         get{ return refDepend_UDEF10; }
         set{ refDepend_UDEF10 = value; refDepend_UDEF10_IsChanged=true; }
      }
      public bool RefDepend_UDEF10_IsChanged
      {
         get{ return refDepend_UDEF10_IsChanged; }
         set{ refDepend_UDEF10_IsChanged = value; }
      }
      private int refDepend_ConfFlag;
      private bool refDepend_ConfFlag_IsChanged=false;
      public int RefDepend_ConfFlag
      {
         get{ return refDepend_ConfFlag; }
         set{ refDepend_ConfFlag = value; refDepend_ConfFlag_IsChanged=true; }
      }
      public bool RefDepend_ConfFlag_IsChanged
      {
         get{ return refDepend_ConfFlag_IsChanged; }
         set{ refDepend_ConfFlag_IsChanged = value; }
      }
      private string refDepend_UDEF11;
      private bool refDepend_UDEF11_IsChanged=false;
      public string RefDepend_UDEF11
      {
         get{ return refDepend_UDEF11; }
         set{ refDepend_UDEF11 = value; refDepend_UDEF11_IsChanged=true; }
      }
      public bool RefDepend_UDEF11_IsChanged
      {
         get{ return refDepend_UDEF11_IsChanged; }
         set{ refDepend_UDEF11_IsChanged = value; }
      }
      private string refDepend_UDEF12;
      private bool refDepend_UDEF12_IsChanged=false;
      public string RefDepend_UDEF12
      {
         get{ return refDepend_UDEF12; }
         set{ refDepend_UDEF12 = value; refDepend_UDEF12_IsChanged=true; }
      }
      public bool RefDepend_UDEF12_IsChanged
      {
         get{ return refDepend_UDEF12_IsChanged; }
         set{ refDepend_UDEF12_IsChanged = value; }
      }
      private string refDepend_UDEF13;
      private bool refDepend_UDEF13_IsChanged=false;
      public string RefDepend_UDEF13
      {
         get{ return refDepend_UDEF13; }
         set{ refDepend_UDEF13 = value; refDepend_UDEF13_IsChanged=true; }
      }
      public bool RefDepend_UDEF13_IsChanged
      {
         get{ return refDepend_UDEF13_IsChanged; }
         set{ refDepend_UDEF13_IsChanged = value; }
      }
      private string refDepend_UDEF14;
      private bool refDepend_UDEF14_IsChanged=false;
      public string RefDepend_UDEF14
      {
         get{ return refDepend_UDEF14; }
         set{ refDepend_UDEF14 = value; refDepend_UDEF14_IsChanged=true; }
      }
      public bool RefDepend_UDEF14_IsChanged
      {
         get{ return refDepend_UDEF14_IsChanged; }
         set{ refDepend_UDEF14_IsChanged = value; }
      }
      private string refDepend_UDEF15;
      private bool refDepend_UDEF15_IsChanged=false;
      public string RefDepend_UDEF15
      {
         get{ return refDepend_UDEF15; }
         set{ refDepend_UDEF15 = value; refDepend_UDEF15_IsChanged=true; }
      }
      public bool RefDepend_UDEF15_IsChanged
      {
         get{ return refDepend_UDEF15_IsChanged; }
         set{ refDepend_UDEF15_IsChanged = value; }
      }
      private string refDepend_UDEF16;
      private bool refDepend_UDEF16_IsChanged=false;
      public string RefDepend_UDEF16
      {
         get{ return refDepend_UDEF16; }
         set{ refDepend_UDEF16 = value; refDepend_UDEF16_IsChanged=true; }
      }
      public bool RefDepend_UDEF16_IsChanged
      {
         get{ return refDepend_UDEF16_IsChanged; }
         set{ refDepend_UDEF16_IsChanged = value; }
      }
      private string refDepend_UDEF17;
      private bool refDepend_UDEF17_IsChanged=false;
      public string RefDepend_UDEF17
      {
         get{ return refDepend_UDEF17; }
         set{ refDepend_UDEF17 = value; refDepend_UDEF17_IsChanged=true; }
      }
      public bool RefDepend_UDEF17_IsChanged
      {
         get{ return refDepend_UDEF17_IsChanged; }
         set{ refDepend_UDEF17_IsChanged = value; }
      }
      private string refDepend_UDEF18;
      private bool refDepend_UDEF18_IsChanged=false;
      public string RefDepend_UDEF18
      {
         get{ return refDepend_UDEF18; }
         set{ refDepend_UDEF18 = value; refDepend_UDEF18_IsChanged=true; }
      }
      public bool RefDepend_UDEF18_IsChanged
      {
         get{ return refDepend_UDEF18_IsChanged; }
         set{ refDepend_UDEF18_IsChanged = value; }
      }
      private string refDepend_UDEF19;
      private bool refDepend_UDEF19_IsChanged=false;
      public string RefDepend_UDEF19
      {
         get{ return refDepend_UDEF19; }
         set{ refDepend_UDEF19 = value; refDepend_UDEF19_IsChanged=true; }
      }
      public bool RefDepend_UDEF19_IsChanged
      {
         get{ return refDepend_UDEF19_IsChanged; }
         set{ refDepend_UDEF19_IsChanged = value; }
      }
      private string refDepend_UDEF20;
      private bool refDepend_UDEF20_IsChanged=false;
      public string RefDepend_UDEF20
      {
         get{ return refDepend_UDEF20; }
         set{ refDepend_UDEF20 = value; refDepend_UDEF20_IsChanged=true; }
      }
      public bool RefDepend_UDEF20_IsChanged
      {
         get{ return refDepend_UDEF20_IsChanged; }
         set{ refDepend_UDEF20_IsChanged = value; }
      }
   }
}
