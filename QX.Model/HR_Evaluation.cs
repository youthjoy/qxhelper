using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 考评信息
   /// </summary>
   [Serializable]
   public partial class HR_Evaluation
   {
      /// <summary>
      /// 考评序号
      /// </summary>
      private decimal eva_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_ID_IsChanged=false;
      /// <summary>
      /// 考评序号
      /// </summary>
      public decimal Eva_ID
      {
         get{ return eva_ID; }
         set{ eva_ID = value; eva_ID_IsChanged=true; }
      }
      /// <summary>
      /// 考评序号
      /// </summary>
      public bool Eva_ID_IsChanged
      {
         get{ return eva_ID_IsChanged; }
         set{ eva_ID_IsChanged = value; }
      }
      private string eva_Code;
      private bool eva_Code_IsChanged=false;
      public string Eva_Code
      {
         get{ return eva_Code; }
         set{ eva_Code = value; eva_Code_IsChanged=true; }
      }
      public bool Eva_Code_IsChanged
      {
         get{ return eva_Code_IsChanged; }
         set{ eva_Code_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string eva_StuffCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_StuffCode_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string Eva_StuffCode
      {
         get{ return eva_StuffCode; }
         set{ eva_StuffCode = value; eva_StuffCode_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool Eva_StuffCode_IsChanged
      {
         get{ return eva_StuffCode_IsChanged; }
         set{ eva_StuffCode_IsChanged = value; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      private string eva_StuffName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_StuffName_IsChanged=false;
      /// <summary>
      /// 员工姓名
      /// </summary>
      public string Eva_StuffName
      {
         get{ return eva_StuffName; }
         set{ eva_StuffName = value; eva_StuffName_IsChanged=true; }
      }
      /// <summary>
      /// 员工姓名
      /// </summary>
      public bool Eva_StuffName_IsChanged
      {
         get{ return eva_StuffName_IsChanged; }
         set{ eva_StuffName_IsChanged = value; }
      }
      /// <summary>
      /// 考评日期
      /// </summary>
      private DateTime eva_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_Date_IsChanged=false;
      /// <summary>
      /// 考评日期
      /// </summary>
      public DateTime Eva_Date
      {
         get{ return eva_Date; }
         set{ eva_Date = value; eva_Date_IsChanged=true; }
      }
      /// <summary>
      /// 考评日期
      /// </summary>
      public bool Eva_Date_IsChanged
      {
         get{ return eva_Date_IsChanged; }
         set{ eva_Date_IsChanged = value; }
      }
      /// <summary>
      /// 考评记录
      /// </summary>
      private string eva_Records;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_Records_IsChanged=false;
      /// <summary>
      /// 考评记录
      /// </summary>
      public string Eva_Records
      {
         get{ return eva_Records; }
         set{ eva_Records = value; eva_Records_IsChanged=true; }
      }
      /// <summary>
      /// 考评记录
      /// </summary>
      public bool Eva_Records_IsChanged
      {
         get{ return eva_Records_IsChanged; }
         set{ eva_Records_IsChanged = value; }
      }
      /// <summary>
      /// 考评总结
      /// </summary>
      private string eva_Conclusion;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_Conclusion_IsChanged=false;
      /// <summary>
      /// 考评总结
      /// </summary>
      public string Eva_Conclusion
      {
         get{ return eva_Conclusion; }
         set{ eva_Conclusion = value; eva_Conclusion_IsChanged=true; }
      }
      /// <summary>
      /// 考评总结
      /// </summary>
      public bool Eva_Conclusion_IsChanged
      {
         get{ return eva_Conclusion_IsChanged; }
         set{ eva_Conclusion_IsChanged = value; }
      }
      /// <summary>
      /// 考评人
      /// </summary>
      private string eva_Manager;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_Manager_IsChanged=false;
      /// <summary>
      /// 考评人
      /// </summary>
      public string Eva_Manager
      {
         get{ return eva_Manager; }
         set{ eva_Manager = value; eva_Manager_IsChanged=true; }
      }
      /// <summary>
      /// 考评人
      /// </summary>
      public bool Eva_Manager_IsChanged
      {
         get{ return eva_Manager_IsChanged; }
         set{ eva_Manager_IsChanged = value; }
      }
      /// <summary>
      /// 考评等级
      /// </summary>
      private string eva_Level;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_Level_IsChanged=false;
      /// <summary>
      /// 考评等级
      /// </summary>
      public string Eva_Level
      {
         get{ return eva_Level; }
         set{ eva_Level = value; eva_Level_IsChanged=true; }
      }
      /// <summary>
      /// 考评等级
      /// </summary>
      public bool Eva_Level_IsChanged
      {
         get{ return eva_Level_IsChanged; }
         set{ eva_Level_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string eva_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool eva_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Eva_Bak
      {
         get{ return eva_Bak; }
         set{ eva_Bak = value; eva_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Eva_Bak_IsChanged
      {
         get{ return eva_Bak_IsChanged; }
         set{ eva_Bak_IsChanged = value; }
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
