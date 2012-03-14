using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 餐劵招待记录
   /// </summary>
   [Serializable]
   public partial class MealReception_Record
   {
      /// <summary>
      /// 餐劵招待序号
      /// </summary>
      private decimal mR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_ID_IsChanged=false;
      /// <summary>
      /// 餐劵招待序号
      /// </summary>
      public decimal MR_ID
      {
         get{ return mR_ID; }
         set{ mR_ID = value; mR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 餐劵招待序号
      /// </summary>
      public bool MR_ID_IsChanged
      {
         get{ return mR_ID_IsChanged; }
         set{ mR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 餐劵招待编码
      /// </summary>
      private string mR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Code_IsChanged=false;
      /// <summary>
      /// 餐劵招待编码
      /// </summary>
      public string MR_Code
      {
         get{ return mR_Code; }
         set{ mR_Code = value; mR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 餐劵招待编码
      /// </summary>
      public bool MR_Code_IsChanged
      {
         get{ return mR_Code_IsChanged; }
         set{ mR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 招待时间
      /// </summary>
      private DateTime mR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Date_IsChanged=false;
      /// <summary>
      /// 招待时间
      /// </summary>
      public DateTime MR_Date
      {
         get{ return mR_Date; }
         set{ mR_Date = value; mR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 招待时间
      /// </summary>
      public bool MR_Date_IsChanged
      {
         get{ return mR_Date_IsChanged; }
         set{ mR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 招待事由
      /// </summary>
      private string mR_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Reason_IsChanged=false;
      /// <summary>
      /// 招待事由
      /// </summary>
      public string MR_Reason
      {
         get{ return mR_Reason; }
         set{ mR_Reason = value; mR_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 招待事由
      /// </summary>
      public bool MR_Reason_IsChanged
      {
         get{ return mR_Reason_IsChanged; }
         set{ mR_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 张数
      /// </summary>
      private int mR_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Num_IsChanged=false;
      /// <summary>
      /// 张数
      /// </summary>
      public int MR_Num
      {
         get{ return mR_Num; }
         set{ mR_Num = value; mR_Num_IsChanged=true; }
      }
      /// <summary>
      /// 张数
      /// </summary>
      public bool MR_Num_IsChanged
      {
         get{ return mR_Num_IsChanged; }
         set{ mR_Num_IsChanged = value; }
      }
      /// <summary>
      /// 接待单位
      /// </summary>
      private string mR_ObjectiveCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_ObjectiveCompany_IsChanged=false;
      /// <summary>
      /// 接待单位
      /// </summary>
      public string MR_ObjectiveCompany
      {
         get{ return mR_ObjectiveCompany; }
         set{ mR_ObjectiveCompany = value; mR_ObjectiveCompany_IsChanged=true; }
      }
      /// <summary>
      /// 接待单位
      /// </summary>
      public bool MR_ObjectiveCompany_IsChanged
      {
         get{ return mR_ObjectiveCompany_IsChanged; }
         set{ mR_ObjectiveCompany_IsChanged = value; }
      }
      /// <summary>
      /// 接待人员
      /// </summary>
      private string mR_Persons;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Persons_IsChanged=false;
      /// <summary>
      /// 接待人员
      /// </summary>
      public string MR_Persons
      {
         get{ return mR_Persons; }
         set{ mR_Persons = value; mR_Persons_IsChanged=true; }
      }
      /// <summary>
      /// 接待人员
      /// </summary>
      public bool MR_Persons_IsChanged
      {
         get{ return mR_Persons_IsChanged; }
         set{ mR_Persons_IsChanged = value; }
      }
      /// <summary>
      /// 人数
      /// </summary>
      private int mR_PersonNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_PersonNum_IsChanged=false;
      /// <summary>
      /// 人数
      /// </summary>
      public int MR_PersonNum
      {
         get{ return mR_PersonNum; }
         set{ mR_PersonNum = value; mR_PersonNum_IsChanged=true; }
      }
      /// <summary>
      /// 人数
      /// </summary>
      public bool MR_PersonNum_IsChanged
      {
         get{ return mR_PersonNum_IsChanged; }
         set{ mR_PersonNum_IsChanged = value; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      private string mR_Handler;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Handler_IsChanged=false;
      /// <summary>
      /// 经手人
      /// </summary>
      public string MR_Handler
      {
         get{ return mR_Handler; }
         set{ mR_Handler = value; mR_Handler_IsChanged=true; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      public bool MR_Handler_IsChanged
      {
         get{ return mR_Handler_IsChanged; }
         set{ mR_Handler_IsChanged = value; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      private string mR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Operator_IsChanged=false;
      /// <summary>
      /// 制单人
      /// </summary>
      public string MR_Operator
      {
         get{ return mR_Operator; }
         set{ mR_Operator = value; mR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      public bool MR_Operator_IsChanged
      {
         get{ return mR_Operator_IsChanged; }
         set{ mR_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 制单时间
      /// </summary>
      private DateTime mR_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_OpDate_IsChanged=false;
      /// <summary>
      /// 制单时间
      /// </summary>
      public DateTime MR_OpDate
      {
         get{ return mR_OpDate; }
         set{ mR_OpDate = value; mR_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 制单时间
      /// </summary>
      public bool MR_OpDate_IsChanged
      {
         get{ return mR_OpDate_IsChanged; }
         set{ mR_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string mR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string MR_Company
      {
         get{ return mR_Company; }
         set{ mR_Company = value; mR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool MR_Company_IsChanged
      {
         get{ return mR_Company_IsChanged; }
         set{ mR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string mR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string MR_Dept
      {
         get{ return mR_Dept; }
         set{ mR_Dept = value; mR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool MR_Dept_IsChanged
      {
         get{ return mR_Dept_IsChanged; }
         set{ mR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private string mR_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mR_Stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public string MR_Stat
      {
         get{ return mR_Stat; }
         set{ mR_Stat = value; mR_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool MR_Stat_IsChanged
      {
         get{ return mR_Stat_IsChanged; }
         set{ mR_Stat_IsChanged = value; }
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
