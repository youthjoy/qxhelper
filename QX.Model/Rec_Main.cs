using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 单据主表      没有申请人，部门，时间
   /// </summary>
   [Serializable]
   public partial class Rec_Main
   {
      /// <summary>
      /// 单据序号
      /// </summary>
      private decimal rM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rM_ID_IsChanged=false;
      /// <summary>
      /// 单据序号
      /// </summary>
      public decimal RM_ID
      {
         get{ return rM_ID; }
         set{ rM_ID = value; rM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 单据序号
      /// </summary>
      public bool RM_ID_IsChanged
      {
         get{ return rM_ID_IsChanged; }
         set{ rM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string rM_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rM_Code_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string RM_Code
      {
         get{ return rM_Code; }
         set{ rM_Code = value; rM_Code_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool RM_Code_IsChanged
      {
         get{ return rM_Code_IsChanged; }
         set{ rM_Code_IsChanged = value; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      private string module_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Code_IsChanged=false;
      /// <summary>
      /// 模块编码
      /// </summary>
      public string Module_Code
      {
         get{ return module_Code; }
         set{ module_Code = value; module_Code_IsChanged=true; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      public bool Module_Code_IsChanged
      {
         get{ return module_Code_IsChanged; }
         set{ module_Code_IsChanged = value; }
      }
      /// <summary>
      /// 模块名称
      /// </summary>
      private string module_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Name_IsChanged=false;
      /// <summary>
      /// 模块名称
      /// </summary>
      public string Module_Name
      {
         get{ return module_Name; }
         set{ module_Name = value; module_Name_IsChanged=true; }
      }
      /// <summary>
      /// 模块名称
      /// </summary>
      public bool Module_Name_IsChanged
      {
         get{ return module_Name_IsChanged; }
         set{ module_Name_IsChanged = value; }
      }
      /// <summary>
      /// 单据名称
      /// </summary>
      private string rM_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rM_Name_IsChanged=false;
      /// <summary>
      /// 单据名称
      /// </summary>
      public string RM_Name
      {
         get{ return rM_Name; }
         set{ rM_Name = value; rM_Name_IsChanged=true; }
      }
      /// <summary>
      /// 单据名称
      /// </summary>
      public bool RM_Name_IsChanged
      {
         get{ return rM_Name_IsChanged; }
         set{ rM_Name_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      private string rM_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rM_RefCode_IsChanged=false;
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public string RM_RefCode
      {
         get{ return rM_RefCode; }
         set{ rM_RefCode = value; rM_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public bool RM_RefCode_IsChanged
      {
         get{ return rM_RefCode_IsChanged; }
         set{ rM_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      private string creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool creator_IsChanged=false;
      /// <summary>
      /// 创建人
      /// </summary>
      public string Creator
      {
         get{ return creator; }
         set{ creator = value; creator_IsChanged=true; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      public bool Creator_IsChanged
      {
         get{ return creator_IsChanged; }
         set{ creator_IsChanged = value; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createTime_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
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
   }
}
