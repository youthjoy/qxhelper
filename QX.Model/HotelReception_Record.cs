using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 宾馆招待
   /// </summary>
   [Serializable]
   public partial class HotelReception_Record
   {
      /// <summary>
      /// 记录编号
      /// </summary>
      private decimal hRR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_ID_IsChanged=false;
      /// <summary>
      /// 记录编号
      /// </summary>
      public decimal HRR_ID
      {
         get{ return hRR_ID; }
         set{ hRR_ID = value; hRR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 记录编号
      /// </summary>
      public bool HRR_ID_IsChanged
      {
         get{ return hRR_ID_IsChanged; }
         set{ hRR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 宾馆招待记录编码
      /// </summary>
      private string hRR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Code_IsChanged=false;
      /// <summary>
      /// 宾馆招待记录编码
      /// </summary>
      public string HRR_Code
      {
         get{ return hRR_Code; }
         set{ hRR_Code = value; hRR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 宾馆招待记录编码
      /// </summary>
      public bool HRR_Code_IsChanged
      {
         get{ return hRR_Code_IsChanged; }
         set{ hRR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 住宿等级
      /// </summary>
      private string hRR_Level;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Level_IsChanged=false;
      /// <summary>
      /// 住宿等级
      /// </summary>
      public string HRR_Level
      {
         get{ return hRR_Level; }
         set{ hRR_Level = value; hRR_Level_IsChanged=true; }
      }
      /// <summary>
      /// 住宿等级
      /// </summary>
      public bool HRR_Level_IsChanged
      {
         get{ return hRR_Level_IsChanged; }
         set{ hRR_Level_IsChanged = value; }
      }
      /// <summary>
      /// 招待时间
      /// </summary>
      private DateTime hRR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Date_IsChanged=false;
      /// <summary>
      /// 招待时间
      /// </summary>
      public DateTime HRR_Date
      {
         get{ return hRR_Date; }
         set{ hRR_Date = value; hRR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 招待时间
      /// </summary>
      public bool HRR_Date_IsChanged
      {
         get{ return hRR_Date_IsChanged; }
         set{ hRR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 酒店名称
      /// </summary>
      private string hRR_HotelName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_HotelName_IsChanged=false;
      /// <summary>
      /// 酒店名称
      /// </summary>
      public string HRR_HotelName
      {
         get{ return hRR_HotelName; }
         set{ hRR_HotelName = value; hRR_HotelName_IsChanged=true; }
      }
      /// <summary>
      /// 酒店名称
      /// </summary>
      public bool HRR_HotelName_IsChanged
      {
         get{ return hRR_HotelName_IsChanged; }
         set{ hRR_HotelName_IsChanged = value; }
      }
      /// <summary>
      /// 招待单位
      /// </summary>
      private string hRR_ObjectCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_ObjectCompany_IsChanged=false;
      /// <summary>
      /// 招待单位
      /// </summary>
      public string HRR_ObjectCompany
      {
         get{ return hRR_ObjectCompany; }
         set{ hRR_ObjectCompany = value; hRR_ObjectCompany_IsChanged=true; }
      }
      /// <summary>
      /// 招待单位
      /// </summary>
      public bool HRR_ObjectCompany_IsChanged
      {
         get{ return hRR_ObjectCompany_IsChanged; }
         set{ hRR_ObjectCompany_IsChanged = value; }
      }
      /// <summary>
      /// 招待人员
      /// </summary>
      private string hRR_Persons;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Persons_IsChanged=false;
      /// <summary>
      /// 招待人员
      /// </summary>
      public string HRR_Persons
      {
         get{ return hRR_Persons; }
         set{ hRR_Persons = value; hRR_Persons_IsChanged=true; }
      }
      /// <summary>
      /// 招待人员
      /// </summary>
      public bool HRR_Persons_IsChanged
      {
         get{ return hRR_Persons_IsChanged; }
         set{ hRR_Persons_IsChanged = value; }
      }
      /// <summary>
      /// 人数
      /// </summary>
      private int hRR_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Num_IsChanged=false;
      /// <summary>
      /// 人数
      /// </summary>
      public int HRR_Num
      {
         get{ return hRR_Num; }
         set{ hRR_Num = value; hRR_Num_IsChanged=true; }
      }
      /// <summary>
      /// 人数
      /// </summary>
      public bool HRR_Num_IsChanged
      {
         get{ return hRR_Num_IsChanged; }
         set{ hRR_Num_IsChanged = value; }
      }
      /// <summary>
      /// 天数
      /// </summary>
      private int hRR_Days;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Days_IsChanged=false;
      /// <summary>
      /// 天数
      /// </summary>
      public int HRR_Days
      {
         get{ return hRR_Days; }
         set{ hRR_Days = value; hRR_Days_IsChanged=true; }
      }
      /// <summary>
      /// 天数
      /// </summary>
      public bool HRR_Days_IsChanged
      {
         get{ return hRR_Days_IsChanged; }
         set{ hRR_Days_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal hRR_Money;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Money_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal HRR_Money
      {
         get{ return hRR_Money; }
         set{ hRR_Money = value; hRR_Money_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool HRR_Money_IsChanged
      {
         get{ return hRR_Money_IsChanged; }
         set{ hRR_Money_IsChanged = value; }
      }
      /// <summary>
      /// 事由
      /// </summary>
      private string hRR_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Reason_IsChanged=false;
      /// <summary>
      /// 事由
      /// </summary>
      public string HRR_Reason
      {
         get{ return hRR_Reason; }
         set{ hRR_Reason = value; hRR_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 事由
      /// </summary>
      public bool HRR_Reason_IsChanged
      {
         get{ return hRR_Reason_IsChanged; }
         set{ hRR_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      private string hRR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Operator_IsChanged=false;
      /// <summary>
      /// 经手人
      /// </summary>
      public string HRR_Operator
      {
         get{ return hRR_Operator; }
         set{ hRR_Operator = value; hRR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      public bool HRR_Operator_IsChanged
      {
         get{ return hRR_Operator_IsChanged; }
         set{ hRR_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      private string hRR_Handler;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Handler_IsChanged=false;
      /// <summary>
      /// 制单人
      /// </summary>
      public string HRR_Handler
      {
         get{ return hRR_Handler; }
         set{ hRR_Handler = value; hRR_Handler_IsChanged=true; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      public bool HRR_Handler_IsChanged
      {
         get{ return hRR_Handler_IsChanged; }
         set{ hRR_Handler_IsChanged = value; }
      }
      /// <summary>
      /// 制单时间
      /// </summary>
      private DateTime hRR_HandleDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_HandleDate_IsChanged=false;
      /// <summary>
      /// 制单时间
      /// </summary>
      public DateTime HRR_HandleDate
      {
         get{ return hRR_HandleDate; }
         set{ hRR_HandleDate = value; hRR_HandleDate_IsChanged=true; }
      }
      /// <summary>
      /// 制单时间
      /// </summary>
      public bool HRR_HandleDate_IsChanged
      {
         get{ return hRR_HandleDate_IsChanged; }
         set{ hRR_HandleDate_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string hRR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string HRR_Company
      {
         get{ return hRR_Company; }
         set{ hRR_Company = value; hRR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool HRR_Company_IsChanged
      {
         get{ return hRR_Company_IsChanged; }
         set{ hRR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string hRR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string HRR_Dept
      {
         get{ return hRR_Dept; }
         set{ hRR_Dept = value; hRR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool HRR_Dept_IsChanged
      {
         get{ return hRR_Dept_IsChanged; }
         set{ hRR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private string hRR_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRR_Stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public string HRR_Stat
      {
         get{ return hRR_Stat; }
         set{ hRR_Stat = value; hRR_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool HRR_Stat_IsChanged
      {
         get{ return hRR_Stat_IsChanged; }
         set{ hRR_Stat_IsChanged = value; }
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
