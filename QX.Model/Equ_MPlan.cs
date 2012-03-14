using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 设备检修计划
   /// </summary>
   [Serializable]
   public partial class Equ_MPlan
   {
      /// <summary>
      /// 计划列表序号
      /// </summary>
      private decimal mP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mP_ID_IsChanged=false;
      /// <summary>
      /// 计划列表序号
      /// </summary>
      public decimal MP_ID
      {
         get{ return mP_ID; }
         set{ mP_ID = value; mP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 计划列表序号
      /// </summary>
      public bool MP_ID_IsChanged
      {
         get{ return mP_ID_IsChanged; }
         set{ mP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      private string mP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mP_Code_IsChanged=false;
      /// <summary>
      /// 计划编码
      /// </summary>
      public string MP_Code
      {
         get{ return mP_Code; }
         set{ mP_Code = value; mP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      public bool MP_Code_IsChanged
      {
         get{ return mP_Code_IsChanged; }
         set{ mP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 计划名称
      /// </summary>
      private string mP_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mP_Name_IsChanged=false;
      /// <summary>
      /// 计划名称
      /// </summary>
      public string MP_Name
      {
         get{ return mP_Name; }
         set{ mP_Name = value; mP_Name_IsChanged=true; }
      }
      /// <summary>
      /// 计划名称
      /// </summary>
      public bool MP_Name_IsChanged
      {
         get{ return mP_Name_IsChanged; }
         set{ mP_Name_IsChanged = value; }
      }
      /// <summary>
      /// 计划人
      /// </summary>
      private string mP_Stuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mP_Stuff_IsChanged=false;
      /// <summary>
      /// 计划人
      /// </summary>
      public string MP_Stuff
      {
         get{ return mP_Stuff; }
         set{ mP_Stuff = value; mP_Stuff_IsChanged=true; }
      }
      /// <summary>
      /// 计划人
      /// </summary>
      public bool MP_Stuff_IsChanged
      {
         get{ return mP_Stuff_IsChanged; }
         set{ mP_Stuff_IsChanged = value; }
      }
      /// <summary>
      /// 计划开始时间
      /// </summary>
      private DateTime mP_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mP_Start_IsChanged=false;
      /// <summary>
      /// 计划开始时间
      /// </summary>
      public DateTime MP_Start
      {
         get{ return mP_Start; }
         set{ mP_Start = value; mP_Start_IsChanged=true; }
      }
      /// <summary>
      /// 计划开始时间
      /// </summary>
      public bool MP_Start_IsChanged
      {
         get{ return mP_Start_IsChanged; }
         set{ mP_Start_IsChanged = value; }
      }
      /// <summary>
      /// 计划结束时间
      /// </summary>
      private DateTime mP_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mP_End_IsChanged=false;
      /// <summary>
      /// 计划结束时间
      /// </summary>
      public DateTime MP_End
      {
         get{ return mP_End; }
         set{ mP_End = value; mP_End_IsChanged=true; }
      }
      /// <summary>
      /// 计划结束时间
      /// </summary>
      public bool MP_End_IsChanged
      {
         get{ return mP_End_IsChanged; }
         set{ mP_End_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string verifyStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyStuff_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string VerifyStuff
      {
         get{ return verifyStuff; }
         set{ verifyStuff = value; verifyStuff_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool VerifyStuff_IsChanged
      {
         get{ return verifyStuff_IsChanged; }
         set{ verifyStuff_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string verifyStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string VerifyStat
      {
         get{ return verifyStat; }
         set{ verifyStat = value; verifyStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool VerifyStat_IsChanged
      {
         get{ return verifyStat_IsChanged; }
         set{ verifyStat_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime verifyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyDate_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime VerifyDate
      {
         get{ return verifyDate; }
         set{ verifyDate = value; verifyDate_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool VerifyDate_IsChanged
      {
         get{ return verifyDate_IsChanged; }
         set{ verifyDate_IsChanged = value; }
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
      private string mP_ECode;
      private bool mP_ECode_IsChanged=false;
      public string MP_ECode
      {
         get{ return mP_ECode; }
         set{ mP_ECode = value; mP_ECode_IsChanged=true; }
      }
      public bool MP_ECode_IsChanged
      {
         get{ return mP_ECode_IsChanged; }
         set{ mP_ECode_IsChanged = value; }
      }
      private string mP_EName;
      private bool mP_EName_IsChanged=false;
      public string MP_EName
      {
         get{ return mP_EName; }
         set{ mP_EName = value; mP_EName_IsChanged=true; }
      }
      public bool MP_EName_IsChanged
      {
         get{ return mP_EName_IsChanged; }
         set{ mP_EName_IsChanged = value; }
      }
   }
}
