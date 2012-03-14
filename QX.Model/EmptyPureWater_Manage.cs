using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 纯净水空桶管理
   /// </summary>
   [Serializable]
   public partial class EmptyPureWater_Manage
   {
      /// <summary>
      /// 纯净水空桶记录序号
      /// </summary>
      private decimal ePW_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_ID_IsChanged=false;
      /// <summary>
      /// 纯净水空桶记录序号
      /// </summary>
      public decimal EPW_ID
      {
         get{ return ePW_ID; }
         set{ ePW_ID = value; ePW_ID_IsChanged=true; }
      }
      /// <summary>
      /// 纯净水空桶记录序号
      /// </summary>
      public bool EPW_ID_IsChanged
      {
         get{ return ePW_ID_IsChanged; }
         set{ ePW_ID_IsChanged = value; }
      }
      /// <summary>
      /// 纯净水空桶记录编码
      /// </summary>
      private string ePW_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_Code_IsChanged=false;
      /// <summary>
      /// 纯净水空桶记录编码
      /// </summary>
      public string EPW_Code
      {
         get{ return ePW_Code; }
         set{ ePW_Code = value; ePW_Code_IsChanged=true; }
      }
      /// <summary>
      /// 纯净水空桶记录编码
      /// </summary>
      public bool EPW_Code_IsChanged
      {
         get{ return ePW_Code_IsChanged; }
         set{ ePW_Code_IsChanged = value; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      private string ePW_Duty;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_Duty_IsChanged=false;
      /// <summary>
      /// 责任人
      /// </summary>
      public string EPW_Duty
      {
         get{ return ePW_Duty; }
         set{ ePW_Duty = value; ePW_Duty_IsChanged=true; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      public bool EPW_Duty_IsChanged
      {
         get{ return ePW_Duty_IsChanged; }
         set{ ePW_Duty_IsChanged = value; }
      }
      /// <summary>
      /// 空桶位置
      /// </summary>
      private string ePW_EmptyPosition;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_EmptyPosition_IsChanged=false;
      /// <summary>
      /// 空桶位置
      /// </summary>
      public string EPW_EmptyPosition
      {
         get{ return ePW_EmptyPosition; }
         set{ ePW_EmptyPosition = value; ePW_EmptyPosition_IsChanged=true; }
      }
      /// <summary>
      /// 空桶位置
      /// </summary>
      public bool EPW_EmptyPosition_IsChanged
      {
         get{ return ePW_EmptyPosition_IsChanged; }
         set{ ePW_EmptyPosition_IsChanged = value; }
      }
      /// <summary>
      /// 空桶数量
      /// </summary>
      private int ePW_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_Count_IsChanged=false;
      /// <summary>
      /// 空桶数量
      /// </summary>
      public int EPW_Count
      {
         get{ return ePW_Count; }
         set{ ePW_Count = value; ePW_Count_IsChanged=true; }
      }
      /// <summary>
      /// 空桶数量
      /// </summary>
      public bool EPW_Count_IsChanged
      {
         get{ return ePW_Count_IsChanged; }
         set{ ePW_Count_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string ePW_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string EPW_Remark
      {
         get{ return ePW_Remark; }
         set{ ePW_Remark = value; ePW_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool EPW_Remark_IsChanged
      {
         get{ return ePW_Remark_IsChanged; }
         set{ ePW_Remark_IsChanged = value; }
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
      /// <summary>
      /// 所属公司
      /// </summary>
      private string ePW_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string EPW_Company
      {
         get{ return ePW_Company; }
         set{ ePW_Company = value; ePW_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool EPW_Company_IsChanged
      {
         get{ return ePW_Company_IsChanged; }
         set{ ePW_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string ePW_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ePW_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string EPW_Dept
      {
         get{ return ePW_Dept; }
         set{ ePW_Dept = value; ePW_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool EPW_Dept_IsChanged
      {
         get{ return ePW_Dept_IsChanged; }
         set{ ePW_Dept_IsChanged = value; }
      }
   }
}
