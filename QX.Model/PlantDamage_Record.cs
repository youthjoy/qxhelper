using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 摆放植物损坏列表
   /// </summary>
   [Serializable]
   public partial class PlantDamage_Record
   {
      /// <summary>
      /// 损坏信息序号
      /// </summary>
      private decimal pDR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_ID_IsChanged=false;
      /// <summary>
      /// 损坏信息序号
      /// </summary>
      public decimal PDR_ID
      {
         get{ return pDR_ID; }
         set{ pDR_ID = value; pDR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 损坏信息序号
      /// </summary>
      public bool PDR_ID_IsChanged
      {
         get{ return pDR_ID_IsChanged; }
         set{ pDR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 损坏信息编码
      /// </summary>
      private string pDR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Code_IsChanged=false;
      /// <summary>
      /// 损坏信息编码
      /// </summary>
      public string PDR_Code
      {
         get{ return pDR_Code; }
         set{ pDR_Code = value; pDR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 损坏信息编码
      /// </summary>
      public bool PDR_Code_IsChanged
      {
         get{ return pDR_Code_IsChanged; }
         set{ pDR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 登记日期
      /// </summary>
      private DateTime pDR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Date_IsChanged=false;
      /// <summary>
      /// 登记日期
      /// </summary>
      public DateTime PDR_Date
      {
         get{ return pDR_Date; }
         set{ pDR_Date = value; pDR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 登记日期
      /// </summary>
      public bool PDR_Date_IsChanged
      {
         get{ return pDR_Date_IsChanged; }
         set{ pDR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string pDR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string PDR_Company
      {
         get{ return pDR_Company; }
         set{ pDR_Company = value; pDR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool PDR_Company_IsChanged
      {
         get{ return pDR_Company_IsChanged; }
         set{ pDR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string pDR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string PDR_Dept
      {
         get{ return pDR_Dept; }
         set{ pDR_Dept = value; pDR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool PDR_Dept_IsChanged
      {
         get{ return pDR_Dept_IsChanged; }
         set{ pDR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 品名
      /// </summary>
      private string pDR_PlantName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_PlantName_IsChanged=false;
      /// <summary>
      /// 品名
      /// </summary>
      public string PDR_PlantName
      {
         get{ return pDR_PlantName; }
         set{ pDR_PlantName = value; pDR_PlantName_IsChanged=true; }
      }
      /// <summary>
      /// 品名
      /// </summary>
      public bool PDR_PlantName_IsChanged
      {
         get{ return pDR_PlantName_IsChanged; }
         set{ pDR_PlantName_IsChanged = value; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      private decimal pDR_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Price_IsChanged=false;
      /// <summary>
      /// 单价
      /// </summary>
      public decimal PDR_Price
      {
         get{ return pDR_Price; }
         set{ pDR_Price = value; pDR_Price_IsChanged=true; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      public bool PDR_Price_IsChanged
      {
         get{ return pDR_Price_IsChanged; }
         set{ pDR_Price_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int pDR_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Count_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int PDR_Count
      {
         get{ return pDR_Count; }
         set{ pDR_Count = value; pDR_Count_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool PDR_Count_IsChanged
      {
         get{ return pDR_Count_IsChanged; }
         set{ pDR_Count_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal pDR_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Amount_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal PDR_Amount
      {
         get{ return pDR_Amount; }
         set{ pDR_Amount = value; pDR_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool PDR_Amount_IsChanged
      {
         get{ return pDR_Amount_IsChanged; }
         set{ pDR_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 损坏原因
      /// </summary>
      private string pDR_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pDR_Reason_IsChanged=false;
      /// <summary>
      /// 损坏原因
      /// </summary>
      public string PDR_Reason
      {
         get{ return pDR_Reason; }
         set{ pDR_Reason = value; pDR_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 损坏原因
      /// </summary>
      public bool PDR_Reason_IsChanged
      {
         get{ return pDR_Reason_IsChanged; }
         set{ pDR_Reason_IsChanged = value; }
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
      private string pR_Position;
      private bool pR_Position_IsChanged=false;
      public string PR_Position
      {
         get{ return pR_Position; }
         set{ pR_Position = value; pR_Position_IsChanged=true; }
      }
      public bool PR_Position_IsChanged
      {
         get{ return pR_Position_IsChanged; }
         set{ pR_Position_IsChanged = value; }
      }
      private string pDR_PlantCode;
      private bool pDR_PlantCode_IsChanged=false;
      public string PDR_PlantCode
      {
         get{ return pDR_PlantCode; }
         set{ pDR_PlantCode = value; pDR_PlantCode_IsChanged=true; }
      }
      public bool PDR_PlantCode_IsChanged
      {
         get{ return pDR_PlantCode_IsChanged; }
         set{ pDR_PlantCode_IsChanged = value; }
      }
   }
}
