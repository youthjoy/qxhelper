using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 摆放植物列表
   /// </summary>
   [Serializable]
   public partial class Plant_Record
   {
      /// <summary>
      /// 摆放植物序号
      /// </summary>
      private decimal pR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_ID_IsChanged=false;
      /// <summary>
      /// 摆放植物序号
      /// </summary>
      public decimal PR_ID
      {
         get{ return pR_ID; }
         set{ pR_ID = value; pR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 摆放植物序号
      /// </summary>
      public bool PR_ID_IsChanged
      {
         get{ return pR_ID_IsChanged; }
         set{ pR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 摆放植物编码
      /// </summary>
      private string pR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Code_IsChanged=false;
      /// <summary>
      /// 摆放植物编码
      /// </summary>
      public string PR_Code
      {
         get{ return pR_Code; }
         set{ pR_Code = value; pR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 摆放植物编码
      /// </summary>
      public bool PR_Code_IsChanged
      {
         get{ return pR_Code_IsChanged; }
         set{ pR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string pR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string PR_Company
      {
         get{ return pR_Company; }
         set{ pR_Company = value; pR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool PR_Company_IsChanged
      {
         get{ return pR_Company_IsChanged; }
         set{ pR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string pR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Dept_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string PR_Dept
      {
         get{ return pR_Dept; }
         set{ pR_Dept = value; pR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool PR_Dept_IsChanged
      {
         get{ return pR_Dept_IsChanged; }
         set{ pR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 摆放楼层
      /// </summary>
      private string pR_Floor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Floor_IsChanged=false;
      /// <summary>
      /// 摆放楼层
      /// </summary>
      public string PR_Floor
      {
         get{ return pR_Floor; }
         set{ pR_Floor = value; pR_Floor_IsChanged=true; }
      }
      /// <summary>
      /// 摆放楼层
      /// </summary>
      public bool PR_Floor_IsChanged
      {
         get{ return pR_Floor_IsChanged; }
         set{ pR_Floor_IsChanged = value; }
      }
      /// <summary>
      /// 摆放位置
      /// </summary>
      private string pR_Position;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Position_IsChanged=false;
      /// <summary>
      /// 摆放位置
      /// </summary>
      public string PR_Position
      {
         get{ return pR_Position; }
         set{ pR_Position = value; pR_Position_IsChanged=true; }
      }
      /// <summary>
      /// 摆放位置
      /// </summary>
      public bool PR_Position_IsChanged
      {
         get{ return pR_Position_IsChanged; }
         set{ pR_Position_IsChanged = value; }
      }
      /// <summary>
      /// 植物种类名称
      /// </summary>
      private string pR_Category;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Category_IsChanged=false;
      /// <summary>
      /// 植物种类名称
      /// </summary>
      public string PR_Category
      {
         get{ return pR_Category; }
         set{ pR_Category = value; pR_Category_IsChanged=true; }
      }
      /// <summary>
      /// 植物种类名称
      /// </summary>
      public bool PR_Category_IsChanged
      {
         get{ return pR_Category_IsChanged; }
         set{ pR_Category_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int pR_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Count_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int PR_Count
      {
         get{ return pR_Count; }
         set{ pR_Count = value; pR_Count_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool PR_Count_IsChanged
      {
         get{ return pR_Count_IsChanged; }
         set{ pR_Count_IsChanged = value; }
      }
      /// <summary>
      /// 租摆价
      /// </summary>
      private decimal pR_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Price_IsChanged=false;
      /// <summary>
      /// 租摆价
      /// </summary>
      public decimal PR_Price
      {
         get{ return pR_Price; }
         set{ pR_Price = value; pR_Price_IsChanged=true; }
      }
      /// <summary>
      /// 租摆价
      /// </summary>
      public bool PR_Price_IsChanged
      {
         get{ return pR_Price_IsChanged; }
         set{ pR_Price_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal pR_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Amount_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal PR_Amount
      {
         get{ return pR_Amount; }
         set{ pR_Amount = value; pR_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool PR_Amount_IsChanged
      {
         get{ return pR_Amount_IsChanged; }
         set{ pR_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 起始时间
      /// </summary>
      private DateTime pR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pR_Date_IsChanged=false;
      /// <summary>
      /// 起始时间
      /// </summary>
      public DateTime PR_Date
      {
         get{ return pR_Date; }
         set{ pR_Date = value; pR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 起始时间
      /// </summary>
      public bool PR_Date_IsChanged
      {
         get{ return pR_Date_IsChanged; }
         set{ pR_Date_IsChanged = value; }
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
