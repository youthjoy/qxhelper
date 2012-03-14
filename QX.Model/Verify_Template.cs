using System;
using System.Data;


namespace QX.Model
{
   /// <summary>
   /// 审核模板
   /// </summary>
   [Serializable]
   public partial class Verify_Template
   {
      /// <summary>
      /// 模板序号
      /// </summary>
      private int vT_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vT_ID_IsChanged=false;
      /// <summary>
      /// 模板序号
      /// </summary>
      [MetaData("VT_ID","模板序号")]
      public int VT_ID
      {
         get{ return vT_ID; }
         set{ vT_ID = value; vT_ID_IsChanged=true; }
      }
      /// <summary>
      /// 模板序号
      /// </summary>
      public bool VT_ID_IsChanged
      {
         get{ return vT_ID_IsChanged; }
         set{ vT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模板关键字
      /// </summary>
      private string vT_Key;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vT_Key_IsChanged=false;
      /// <summary>
      /// 模板关键字
      /// </summary>
      [MetaData("VT_Key","模板关键字")]
      public string VT_Key
      {
         get{ return vT_Key; }
         set{ vT_Key = value; vT_Key_IsChanged=true; }
      }
      /// <summary>
      /// 模板关键字
      /// </summary>
      public bool VT_Key_IsChanged
      {
         get{ return vT_Key_IsChanged; }
         set{ vT_Key_IsChanged = value; }
      }
      /// <summary>
      /// 模板阶段序号
      /// </summary>
      private string vT_No;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vT_No_IsChanged=false;
      /// <summary>
      /// 模板阶段序号
      /// </summary>
      [MetaData("VT_No","模板阶段序号")]
      public string VT_No
      {
         get{ return vT_No; }
         set{ vT_No = value; vT_No_IsChanged=true; }
      }
      /// <summary>
      /// 模板阶段序号
      /// </summary>
      public bool VT_No_IsChanged
      {
         get{ return vT_No_IsChanged; }
         set{ vT_No_IsChanged = value; }
      }
      /// <summary>
      /// 阶段编码
      /// </summary>
      private string verifyNode_Code4;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyNode_Code4_IsChanged=false;
      /// <summary>
      /// 阶段编码
      /// </summary>
      [MetaData("VerifyNode_Code4","阶段编码")]
      public string VerifyNode_Code4
      {
         get{ return verifyNode_Code4; }
         set{ verifyNode_Code4 = value; verifyNode_Code4_IsChanged=true; }
      }
      /// <summary>
      /// 阶段编码
      /// </summary>
      public bool VerifyNode_Code4_IsChanged
      {
         get{ return verifyNode_Code4_IsChanged; }
         set{ verifyNode_Code4_IsChanged = value; }
      }
      /// <summary>
      /// 阶段名称
      /// </summary>
      private string verifyNode_Name3;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyNode_Name3_IsChanged=false;
      /// <summary>
      /// 阶段名称
      /// </summary>
      [MetaData("VerifyNode_Name3","阶段名称")]
      public string VerifyNode_Name3
      {
         get{ return verifyNode_Name3; }
         set{ verifyNode_Name3 = value; verifyNode_Name3_IsChanged=true; }
      }
      /// <summary>
      /// 阶段名称
      /// </summary>
      public bool VerifyNode_Name3_IsChanged
      {
         get{ return verifyNode_Name3_IsChanged; }
         set{ verifyNode_Name3_IsChanged = value; }
      }
      /// <summary>
      /// 类别标识
      /// </summary>
      private int flag;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool flag_IsChanged=false;
      /// <summary>
      /// 类别标识
      /// </summary>
      [MetaData("Flag","类别标识")]
      public int Flag
      {
         get{ return flag; }
         set{ flag = value; flag_IsChanged=true; }
      }
      /// <summary>
      /// 类别标识
      /// </summary>
      public bool Flag_IsChanged
      {
         get{ return flag_IsChanged; }
         set{ flag_IsChanged = value; }
      }
   }
}
