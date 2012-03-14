using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 考勤信息
   /// </summary>
   [Serializable]
   public partial class HR_TimeSheet
   {
      /// <summary>
      /// 考勤序号
      /// </summary>
      private decimal tS_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_ID_IsChanged=false;
      /// <summary>
      /// 考勤序号
      /// </summary>
      public decimal TS_ID
      {
         get{ return tS_ID; }
         set{ tS_ID = value; tS_ID_IsChanged=true; }
      }
      /// <summary>
      /// 考勤序号
      /// </summary>
      public bool TS_ID_IsChanged
      {
         get{ return tS_ID_IsChanged; }
         set{ tS_ID_IsChanged = value; }
      }
      /// <summary>
      /// 考勤编码
      /// </summary>
      private string tS_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_Code_IsChanged=false;
      /// <summary>
      /// 考勤编码
      /// </summary>
      public string TS_Code
      {
         get{ return tS_Code; }
         set{ tS_Code = value; tS_Code_IsChanged=true; }
      }
      /// <summary>
      /// 考勤编码
      /// </summary>
      public bool TS_Code_IsChanged
      {
         get{ return tS_Code_IsChanged; }
         set{ tS_Code_IsChanged = value; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      private string tS_StuffName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_StuffName_IsChanged=false;
      /// <summary>
      /// 员工姓名
      /// </summary>
      public string TS_StuffName
      {
         get{ return tS_StuffName; }
         set{ tS_StuffName = value; tS_StuffName_IsChanged=true; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      public bool TS_StuffName_IsChanged
      {
         get{ return tS_StuffName_IsChanged; }
         set{ tS_StuffName_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string tS_StuffCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_StuffCode_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string TS_StuffCode
      {
         get{ return tS_StuffCode; }
         set{ tS_StuffCode = value; tS_StuffCode_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool TS_StuffCode_IsChanged
      {
         get{ return tS_StuffCode_IsChanged; }
         set{ tS_StuffCode_IsChanged = value; }
      }
      /// <summary>
      /// 考勤类型
      /// </summary>
      private string tS_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_Type_IsChanged=false;
      /// <summary>
      /// 考勤类型
      /// </summary>
      public string TS_Type
      {
         get{ return tS_Type; }
         set{ tS_Type = value; tS_Type_IsChanged=true; }
      }
      /// <summary>
      /// 考勤类型
      /// </summary>
      public bool TS_Type_IsChanged
      {
         get{ return tS_Type_IsChanged; }
         set{ tS_Type_IsChanged = value; }
      }
      private string tS_TypeName;
      private bool tS_TypeName_IsChanged=false;
      public string TS_TypeName
      {
         get{ return tS_TypeName; }
         set{ tS_TypeName = value; tS_TypeName_IsChanged=true; }
      }
      public bool TS_TypeName_IsChanged
      {
         get{ return tS_TypeName_IsChanged; }
         set{ tS_TypeName_IsChanged = value; }
      }
      /// <summary>
      /// 开始时间
      /// </summary>
      private DateTime tS_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_Start_IsChanged=false;
      /// <summary>
      /// 开始时间
      /// </summary>
      public DateTime TS_Start
      {
         get{ return tS_Start; }
         set{ tS_Start = value; tS_Start_IsChanged=true; }
      }
      /// <summary>
      /// 开始时间
      /// </summary>
      public bool TS_Start_IsChanged
      {
         get{ return tS_Start_IsChanged; }
         set{ tS_Start_IsChanged = value; }
      }
      /// <summary>
      /// 结束时间
      /// </summary>
      private DateTime tS_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_End_IsChanged=false;
      /// <summary>
      /// 结束时间
      /// </summary>
      public DateTime TS_End
      {
         get{ return tS_End; }
         set{ tS_End = value; tS_End_IsChanged=true; }
      }
      /// <summary>
      /// 结束时间
      /// </summary>
      public bool TS_End_IsChanged
      {
         get{ return tS_End_IsChanged; }
         set{ tS_End_IsChanged = value; }
      }
      /// <summary>
      /// 工时
      /// </summary>
      private Int64 tS_Total;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_Total_IsChanged=false;
      /// <summary>
      /// 工时
      /// </summary>
      public Int64 TS_Total
      {
         get{ return tS_Total; }
         set{ tS_Total = value; tS_Total_IsChanged=true; }
      }
      /// <summary>
      /// 工时
      /// </summary>
      public bool TS_Total_IsChanged
      {
         get{ return tS_Total_IsChanged; }
         set{ tS_Total_IsChanged = value; }
      }
      /// <summary>
      /// 理由
      /// </summary>
      private string tS_Matter;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tS_Matter_IsChanged=false;
      /// <summary>
      /// 理由
      /// </summary>
      public string TS_Matter
      {
         get{ return tS_Matter; }
         set{ tS_Matter = value; tS_Matter_IsChanged=true; }
      }
      /// <summary>
      /// 理由
      /// </summary>
      public bool TS_Matter_IsChanged
      {
         get{ return tS_Matter_IsChanged; }
         set{ tS_Matter_IsChanged = value; }
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
      /// 下一审核状态
      /// </summary>
      private string verifyNext;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyNext_IsChanged=false;
      /// <summary>
      /// 下一审核状态
      /// </summary>
      public string VerifyNext
      {
         get{ return verifyNext; }
         set{ verifyNext = value; verifyNext_IsChanged=true; }
      }
      /// <summary>
      /// 下一审核状态
      /// </summary>
      public bool VerifyNext_IsChanged
      {
         get{ return verifyNext_IsChanged; }
         set{ verifyNext_IsChanged = value; }
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
