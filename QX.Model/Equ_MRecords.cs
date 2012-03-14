using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 设备检修记录
   /// </summary>
   [Serializable]
   public partial class Equ_MRecords
   {
      /// <summary>
      /// 检修序号
      /// </summary>
      private decimal mR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_ID_IsChanged=false;
      /// <summary>
      /// 检修序号
      /// </summary>
      public decimal MR_ID
      {
         get{ return mR_ID; }
         set{ mR_ID = value; mR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 检修序号
      /// </summary>
      public bool MR_ID_IsChanged
      {
         get{ return mR_ID_IsChanged; }
         set{ mR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 设备编码
      /// </summary>
      private string mR_ECode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_ECode_IsChanged=false;
      /// <summary>
      /// 设备编码
      /// </summary>
      public string MR_ECode
      {
         get{ return mR_ECode; }
         set{ mR_ECode = value; mR_ECode_IsChanged=true; }
      }
      /// <summary>
      /// 设备编码
      /// </summary>
      public bool MR_ECode_IsChanged
      {
         get{ return mR_ECode_IsChanged; }
         set{ mR_ECode_IsChanged = value; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      private string mR_EName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_EName_IsChanged=false;
      /// <summary>
      /// 设备名称
      /// </summary>
      public string MR_EName
      {
         get{ return mR_EName; }
         set{ mR_EName = value; mR_EName_IsChanged=true; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      public bool MR_EName_IsChanged
      {
         get{ return mR_EName_IsChanged; }
         set{ mR_EName_IsChanged = value; }
      }
      /// <summary>
      /// 检修开始时间
      /// </summary>
      private DateTime mR_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Start_IsChanged=false;
      /// <summary>
      /// 检修开始时间
      /// </summary>
      public DateTime MR_Start
      {
         get{ return mR_Start; }
         set{ mR_Start = value; mR_Start_IsChanged=true; }
      }
      /// <summary>
      /// 检修开始时间
      /// </summary>
      public bool MR_Start_IsChanged
      {
         get{ return mR_Start_IsChanged; }
         set{ mR_Start_IsChanged = value; }
      }
      /// <summary>
      /// 检修结束时间
      /// </summary>
      private DateTime mR_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_End_IsChanged=false;
      /// <summary>
      /// 检修结束时间
      /// </summary>
      public DateTime MR_End
      {
         get{ return mR_End; }
         set{ mR_End = value; mR_End_IsChanged=true; }
      }
      /// <summary>
      /// 检修结束时间
      /// </summary>
      public bool MR_End_IsChanged
      {
         get{ return mR_End_IsChanged; }
         set{ mR_End_IsChanged = value; }
      }
      /// <summary>
      /// 故障模式
      /// </summary>
      private string mR_FType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_FType_IsChanged=false;
      /// <summary>
      /// 故障模式
      /// </summary>
      public string MR_FType
      {
         get{ return mR_FType; }
         set{ mR_FType = value; mR_FType_IsChanged=true; }
      }
      /// <summary>
      /// 故障模式
      /// </summary>
      public bool MR_FType_IsChanged
      {
         get{ return mR_FType_IsChanged; }
         set{ mR_FType_IsChanged = value; }
      }
      /// <summary>
      /// 更换零件说明
      /// </summary>
      private string mR_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Content_IsChanged=false;
      /// <summary>
      /// 更换零件说明
      /// </summary>
      public string MR_Content
      {
         get{ return mR_Content; }
         set{ mR_Content = value; mR_Content_IsChanged=true; }
      }
      /// <summary>
      /// 更换零件说明
      /// </summary>
      public bool MR_Content_IsChanged
      {
         get{ return mR_Content_IsChanged; }
         set{ mR_Content_IsChanged = value; }
      }
      /// <summary>
      /// 检修人
      /// </summary>
      private string mR_MStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_MStuff_IsChanged=false;
      /// <summary>
      /// 检修人
      /// </summary>
      public string MR_MStuff
      {
         get{ return mR_MStuff; }
         set{ mR_MStuff = value; mR_MStuff_IsChanged=true; }
      }
      /// <summary>
      /// 检修人
      /// </summary>
      public bool MR_MStuff_IsChanged
      {
         get{ return mR_MStuff_IsChanged; }
         set{ mR_MStuff_IsChanged = value; }
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
      /// 备注
      /// </summary>
      private string mR_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string MR_Bak
      {
         get{ return mR_Bak; }
         set{ mR_Bak = value; mR_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool MR_Bak_IsChanged
      {
         get{ return mR_Bak_IsChanged; }
         set{ mR_Bak_IsChanged = value; }
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
      /// <summary>
      /// 参考计划编码
      /// </summary>
      private string mR_MPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_MPCode_IsChanged=false;
      /// <summary>
      /// 参考计划编码
      /// </summary>
      public string MR_MPCode
      {
         get{ return mR_MPCode; }
         set{ mR_MPCode = value; mR_MPCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考计划编码
      /// </summary>
      public bool MR_MPCode_IsChanged
      {
         get{ return mR_MPCode_IsChanged; }
         set{ mR_MPCode_IsChanged = value; }
      }
      /// <summary>
      /// 检修记录类型
      /// </summary>
      private string mR_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Type_IsChanged=false;
      /// <summary>
      /// 检修记录类型
      /// </summary>
      public string MR_Type
      {
         get{ return mR_Type; }
         set{ mR_Type = value; mR_Type_IsChanged=true; }
      }
      /// <summary>
      /// 检修记录类型
      /// </summary>
      public bool MR_Type_IsChanged
      {
         get{ return mR_Type_IsChanged; }
         set{ mR_Type_IsChanged = value; }
      }
   }
}
