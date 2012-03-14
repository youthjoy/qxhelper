using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 奖惩信息
   /// </summary>
   [Serializable]
   public partial class HR_AA
   {
      /// <summary>
      /// 奖惩序号
      /// </summary>
      private decimal aA_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_ID_IsChanged=false;
      /// <summary>
      /// 奖惩序号
      /// </summary>
      public decimal AA_ID
      {
         get{ return aA_ID; }
         set{ aA_ID = value; aA_ID_IsChanged=true; }
      }
      /// <summary>
      /// 奖惩序号
      /// </summary>
      public bool AA_ID_IsChanged
      {
         get{ return aA_ID_IsChanged; }
         set{ aA_ID_IsChanged = value; }
      }
      /// <summary>
      /// 奖惩编号
      /// </summary>
      private string aA_ICode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_ICode_IsChanged=false;
      /// <summary>
      /// 奖惩编号
      /// </summary>
      public string AA_ICode
      {
         get{ return aA_ICode; }
         set{ aA_ICode = value; aA_ICode_IsChanged=true; }
      }
      /// <summary>
      /// 奖惩编号
      /// </summary>
      public bool AA_ICode_IsChanged
      {
         get{ return aA_ICode_IsChanged; }
         set{ aA_ICode_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string aA_ECde;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_ECde_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string AA_ECde
      {
         get{ return aA_ECde; }
         set{ aA_ECde = value; aA_ECde_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool AA_ECde_IsChanged
      {
         get{ return aA_ECde_IsChanged; }
         set{ aA_ECde_IsChanged = value; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      private string aA_EName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_EName_IsChanged=false;
      /// <summary>
      /// 员工姓名
      /// </summary>
      public string AA_EName
      {
         get{ return aA_EName; }
         set{ aA_EName = value; aA_EName_IsChanged=true; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      public bool AA_EName_IsChanged
      {
         get{ return aA_EName_IsChanged; }
         set{ aA_EName_IsChanged = value; }
      }
      /// <summary>
      /// 奖惩类型
      /// </summary>
      private string aA_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_Type_IsChanged=false;
      /// <summary>
      /// 奖惩类型
      /// </summary>
      public string AA_Type
      {
         get{ return aA_Type; }
         set{ aA_Type = value; aA_Type_IsChanged=true; }
      }
      /// <summary>
      /// 奖惩类型
      /// </summary>
      public bool AA_Type_IsChanged
      {
         get{ return aA_Type_IsChanged; }
         set{ aA_Type_IsChanged = value; }
      }
      /// <summary>
      /// 奖惩时间
      /// </summary>
      private DateTime aA_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_Date_IsChanged=false;
      /// <summary>
      /// 奖惩时间
      /// </summary>
      public DateTime AA_Date
      {
         get{ return aA_Date; }
         set{ aA_Date = value; aA_Date_IsChanged=true; }
      }
      /// <summary>
      /// 奖惩时间
      /// </summary>
      public bool AA_Date_IsChanged
      {
         get{ return aA_Date_IsChanged; }
         set{ aA_Date_IsChanged = value; }
      }
      /// <summary>
      /// 说明
      /// </summary>
      private string aA_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_Content_IsChanged=false;
      /// <summary>
      /// 说明
      /// </summary>
      public string AA_Content
      {
         get{ return aA_Content; }
         set{ aA_Content = value; aA_Content_IsChanged=true; }
      }
      /// <summary>
      /// 说明
      /// </summary>
      public bool AA_Content_IsChanged
      {
         get{ return aA_Content_IsChanged; }
         set{ aA_Content_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private double aA_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aA_Sum_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public double AA_Sum
      {
         get{ return aA_Sum; }
         set{ aA_Sum = value; aA_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool AA_Sum_IsChanged
      {
         get{ return aA_Sum_IsChanged; }
         set{ aA_Sum_IsChanged = value; }
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
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createDate_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime updateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool updateDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime deleteDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool deleteDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
   }
}
