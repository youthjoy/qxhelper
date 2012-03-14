using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 个人经历
   /// </summary>
   [Serializable]
   public partial class HR_Experience
   {
      /// <summary>
      /// 经历序号
      /// </summary>
      private decimal eX_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_ID_IsChanged=false;
      /// <summary>
      /// 经历序号
      /// </summary>
      public decimal EX_ID
      {
         get{ return eX_ID; }
         set{ eX_ID = value; eX_ID_IsChanged=true; }
      }
      /// <summary>
      /// 经历序号
      /// </summary>
      public bool EX_ID_IsChanged
      {
         get{ return eX_ID_IsChanged; }
         set{ eX_ID_IsChanged = value; }
      }
      private string eX_Code;
      private bool eX_Code_IsChanged=false;
      public string EX_Code
      {
         get{ return eX_Code; }
         set{ eX_Code = value; eX_Code_IsChanged=true; }
      }
      public bool EX_Code_IsChanged
      {
         get{ return eX_Code_IsChanged; }
         set{ eX_Code_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string eX_StuffCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_StuffCode_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string EX_StuffCode
      {
         get{ return eX_StuffCode; }
         set{ eX_StuffCode = value; eX_StuffCode_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool EX_StuffCode_IsChanged
      {
         get{ return eX_StuffCode_IsChanged; }
         set{ eX_StuffCode_IsChanged = value; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      private string eX_StuffName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_StuffName_IsChanged=false;
      /// <summary>
      /// 员工姓名
      /// </summary>
      public string EX_StuffName
      {
         get{ return eX_StuffName; }
         set{ eX_StuffName = value; eX_StuffName_IsChanged=true; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      public bool EX_StuffName_IsChanged
      {
         get{ return eX_StuffName_IsChanged; }
         set{ eX_StuffName_IsChanged = value; }
      }
      /// <summary>
      /// 经历类型
      /// </summary>
      private string eX_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_Type_IsChanged=false;
      /// <summary>
      /// 经历类型
      /// </summary>
      public string EX_Type
      {
         get{ return eX_Type; }
         set{ eX_Type = value; eX_Type_IsChanged=true; }
      }
      /// <summary>
      /// 经历类型
      /// </summary>
      public bool EX_Type_IsChanged
      {
         get{ return eX_Type_IsChanged; }
         set{ eX_Type_IsChanged = value; }
      }
      /// <summary>
      /// 经历单位
      /// </summary>
      private string eX_Corrp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_Corrp_IsChanged=false;
      /// <summary>
      /// 经历单位
      /// </summary>
      public string EX_Corrp
      {
         get{ return eX_Corrp; }
         set{ eX_Corrp = value; eX_Corrp_IsChanged=true; }
      }
      /// <summary>
      /// 经历单位
      /// </summary>
      public bool EX_Corrp_IsChanged
      {
         get{ return eX_Corrp_IsChanged; }
         set{ eX_Corrp_IsChanged = value; }
      }
      /// <summary>
      /// 经历职位
      /// </summary>
      private string eX_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_Title_IsChanged=false;
      /// <summary>
      /// 经历职位
      /// </summary>
      public string EX_Title
      {
         get{ return eX_Title; }
         set{ eX_Title = value; eX_Title_IsChanged=true; }
      }
      /// <summary>
      /// 经历职位
      /// </summary>
      public bool EX_Title_IsChanged
      {
         get{ return eX_Title_IsChanged; }
         set{ eX_Title_IsChanged = value; }
      }
      /// <summary>
      /// 简介
      /// </summary>
      private string eX_Intro;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_Intro_IsChanged=false;
      /// <summary>
      /// 简介
      /// </summary>
      public string EX_Intro
      {
         get{ return eX_Intro; }
         set{ eX_Intro = value; eX_Intro_IsChanged=true; }
      }
      /// <summary>
      /// 简介
      /// </summary>
      public bool EX_Intro_IsChanged
      {
         get{ return eX_Intro_IsChanged; }
         set{ eX_Intro_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string eX_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string EX_Bak
      {
         get{ return eX_Bak; }
         set{ eX_Bak = value; eX_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool EX_Bak_IsChanged
      {
         get{ return eX_Bak_IsChanged; }
         set{ eX_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 开始时间
      /// </summary>
      private DateTime eX_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_Start_IsChanged=false;
      /// <summary>
      /// 开始时间
      /// </summary>
      public DateTime EX_Start
      {
         get{ return eX_Start; }
         set{ eX_Start = value; eX_Start_IsChanged=true; }
      }
      /// <summary>
      /// 开始时间
      /// </summary>
      public bool EX_Start_IsChanged
      {
         get{ return eX_Start_IsChanged; }
         set{ eX_Start_IsChanged = value; }
      }
      /// <summary>
      /// 结束时间
      /// </summary>
      private DateTime eX_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eX_End_IsChanged=false;
      /// <summary>
      /// 结束时间
      /// </summary>
      public DateTime EX_End
      {
         get{ return eX_End; }
         set{ eX_End = value; eX_End_IsChanged=true; }
      }
      /// <summary>
      /// 结束时间
      /// </summary>
      public bool EX_End_IsChanged
      {
         get{ return eX_End_IsChanged; }
         set{ eX_End_IsChanged = value; }
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
