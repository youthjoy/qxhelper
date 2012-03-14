using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 纠正预防措施
   /// </summary>
   [Serializable]
   public partial class Correct_Preventing
   {
      /// <summary>
      /// 纠正措施序号
      /// </summary>
      private decimal correct_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_ID_IsChanged=false;
      /// <summary>
      /// 纠正措施序号
      /// </summary>
      public decimal Correct_ID
      {
         get{ return correct_ID; }
         set{ correct_ID = value; correct_ID_IsChanged=true; }
      }
      /// <summary>
      /// 纠正措施序号
      /// </summary>
      public bool Correct_ID_IsChanged
      {
         get{ return correct_ID_IsChanged; }
         set{ correct_ID_IsChanged = value; }
      }
      /// <summary>
      /// 纠正措施编码
      /// </summary>
      private string correct_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Code_IsChanged=false;
      /// <summary>
      /// 纠正措施编码
      /// </summary>
      public string Correct_Code
      {
         get{ return correct_Code; }
         set{ correct_Code = value; correct_Code_IsChanged=true; }
      }
      /// <summary>
      /// 纠正措施编码
      /// </summary>
      public bool Correct_Code_IsChanged
      {
         get{ return correct_Code_IsChanged; }
         set{ correct_Code_IsChanged = value; }
      }
      /// <summary>
      /// 纠正措施项目
      /// </summary>
      private string correct_Item;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Item_IsChanged=false;
      /// <summary>
      /// 纠正措施项目
      /// </summary>
      public string Correct_Item
      {
         get{ return correct_Item; }
         set{ correct_Item = value; correct_Item_IsChanged=true; }
      }
      /// <summary>
      /// 纠正措施项目
      /// </summary>
      public bool Correct_Item_IsChanged
      {
         get{ return correct_Item_IsChanged; }
         set{ correct_Item_IsChanged = value; }
      }
      /// <summary>
      /// 提出部门
      /// </summary>
      private string correct_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Dept_IsChanged=false;
      /// <summary>
      /// 提出部门
      /// </summary>
      public string Correct_Dept
      {
         get{ return correct_Dept; }
         set{ correct_Dept = value; correct_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 提出部门
      /// </summary>
      public bool Correct_Dept_IsChanged
      {
         get{ return correct_Dept_IsChanged; }
         set{ correct_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 提出时间
      /// </summary>
      private DateTime correct_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Date_IsChanged=false;
      /// <summary>
      /// 提出时间
      /// </summary>
      public DateTime Correct_Date
      {
         get{ return correct_Date; }
         set{ correct_Date = value; correct_Date_IsChanged=true; }
      }
      /// <summary>
      /// 提出时间
      /// </summary>
      public bool Correct_Date_IsChanged
      {
         get{ return correct_Date_IsChanged; }
         set{ correct_Date_IsChanged = value; }
      }
      /// <summary>
      /// 不合格现象
      /// </summary>
      private string correct_WrongAppearance;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_WrongAppearance_IsChanged=false;
      /// <summary>
      /// 不合格现象
      /// </summary>
      public string Correct_WrongAppearance
      {
         get{ return correct_WrongAppearance; }
         set{ correct_WrongAppearance = value; correct_WrongAppearance_IsChanged=true; }
      }
      /// <summary>
      /// 不合格现象
      /// </summary>
      public bool Correct_WrongAppearance_IsChanged
      {
         get{ return correct_WrongAppearance_IsChanged; }
         set{ correct_WrongAppearance_IsChanged = value; }
      }
      /// <summary>
      /// 不合格原因分析
      /// </summary>
      private string correct_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Reason_IsChanged=false;
      /// <summary>
      /// 不合格原因分析
      /// </summary>
      public string Correct_Reason
      {
         get{ return correct_Reason; }
         set{ correct_Reason = value; correct_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 不合格原因分析
      /// </summary>
      public bool Correct_Reason_IsChanged
      {
         get{ return correct_Reason_IsChanged; }
         set{ correct_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 不合格实施计划
      /// </summary>
      private string correct_Plan;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Plan_IsChanged=false;
      /// <summary>
      /// 不合格实施计划
      /// </summary>
      public string Correct_Plan
      {
         get{ return correct_Plan; }
         set{ correct_Plan = value; correct_Plan_IsChanged=true; }
      }
      /// <summary>
      /// 不合格实施计划
      /// </summary>
      public bool Correct_Plan_IsChanged
      {
         get{ return correct_Plan_IsChanged; }
         set{ correct_Plan_IsChanged = value; }
      }
      /// <summary>
      /// 跟踪验证结果
      /// </summary>
      private string correct_TrackResult;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_TrackResult_IsChanged=false;
      /// <summary>
      /// 跟踪验证结果
      /// </summary>
      public string Correct_TrackResult
      {
         get{ return correct_TrackResult; }
         set{ correct_TrackResult = value; correct_TrackResult_IsChanged=true; }
      }
      /// <summary>
      /// 跟踪验证结果
      /// </summary>
      public bool Correct_TrackResult_IsChanged
      {
         get{ return correct_TrackResult_IsChanged; }
         set{ correct_TrackResult_IsChanged = value; }
      }
      /// <summary>
      /// 是否更改有关文件
      /// </summary>
      private string correct_IsModifyFile;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_IsModifyFile_IsChanged=false;
      /// <summary>
      /// 是否更改有关文件
      /// </summary>
      public string Correct_IsModifyFile
      {
         get{ return correct_IsModifyFile; }
         set{ correct_IsModifyFile = value; correct_IsModifyFile_IsChanged=true; }
      }
      /// <summary>
      /// 是否更改有关文件
      /// </summary>
      public bool Correct_IsModifyFile_IsChanged
      {
         get{ return correct_IsModifyFile_IsChanged; }
         set{ correct_IsModifyFile_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string correct_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool correct_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Correct_Remark
      {
         get{ return correct_Remark; }
         set{ correct_Remark = value; correct_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Correct_Remark_IsChanged
      {
         get{ return correct_Remark_IsChanged; }
         set{ correct_Remark_IsChanged = value; }
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
