using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 房屋租赁列表
   /// </summary>
   [Serializable]
   public partial class House_Rental
   {
      /// <summary>
      /// 房屋租赁记录序号
      /// </summary>
      private decimal hRental_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_ID_IsChanged=false;
      /// <summary>
      /// 房屋租赁记录序号
      /// </summary>
      public decimal HRental_ID
      {
         get{ return hRental_ID; }
         set{ hRental_ID = value; hRental_ID_IsChanged=true; }
      }
      /// <summary>
      /// 房屋租赁记录序号
      /// </summary>
      public bool HRental_ID_IsChanged
      {
         get{ return hRental_ID_IsChanged; }
         set{ hRental_ID_IsChanged = value; }
      }
      /// <summary>
      /// 房屋租赁编码
      /// </summary>
      private string hRental_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Code_IsChanged=false;
      /// <summary>
      /// 房屋租赁编码
      /// </summary>
      public string HRental_Code
      {
         get{ return hRental_Code; }
         set{ hRental_Code = value; hRental_Code_IsChanged=true; }
      }
      /// <summary>
      /// 房屋租赁编码
      /// </summary>
      public bool HRental_Code_IsChanged
      {
         get{ return hRental_Code_IsChanged; }
         set{ hRental_Code_IsChanged = value; }
      }
      /// <summary>
      /// 房屋租赁文件名称
      /// </summary>
      private string hRental_FileName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_FileName_IsChanged=false;
      /// <summary>
      /// 房屋租赁文件名称
      /// </summary>
      public string HRental_FileName
      {
         get{ return hRental_FileName; }
         set{ hRental_FileName = value; hRental_FileName_IsChanged=true; }
      }
      /// <summary>
      /// 房屋租赁文件名称
      /// </summary>
      public bool HRental_FileName_IsChanged
      {
         get{ return hRental_FileName_IsChanged; }
         set{ hRental_FileName_IsChanged = value; }
      }
      /// <summary>
      /// 出租方
      /// </summary>
      private string hRental_Rentor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Rentor_IsChanged=false;
      /// <summary>
      /// 出租方
      /// </summary>
      public string HRental_Rentor
      {
         get{ return hRental_Rentor; }
         set{ hRental_Rentor = value; hRental_Rentor_IsChanged=true; }
      }
      /// <summary>
      /// 出租方
      /// </summary>
      public bool HRental_Rentor_IsChanged
      {
         get{ return hRental_Rentor_IsChanged; }
         set{ hRental_Rentor_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal hRental_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Cost_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal HRental_Cost
      {
         get{ return hRental_Cost; }
         set{ hRental_Cost = value; hRental_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool HRental_Cost_IsChanged
      {
         get{ return hRental_Cost_IsChanged; }
         set{ hRental_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string hRental_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string HRental_Unit
      {
         get{ return hRental_Unit; }
         set{ hRental_Unit = value; hRental_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool HRental_Unit_IsChanged
      {
         get{ return hRental_Unit_IsChanged; }
         set{ hRental_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 租赁起始时间
      /// </summary>
      private DateTime hRental_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_BeginDate_IsChanged=false;
      /// <summary>
      /// 租赁起始时间
      /// </summary>
      public DateTime HRental_BeginDate
      {
         get{ return hRental_BeginDate; }
         set{ hRental_BeginDate = value; hRental_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 租赁起始时间
      /// </summary>
      public bool HRental_BeginDate_IsChanged
      {
         get{ return hRental_BeginDate_IsChanged; }
         set{ hRental_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 租赁结束时间
      /// </summary>
      private DateTime hRental_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_EndDate_IsChanged=false;
      /// <summary>
      /// 租赁结束时间
      /// </summary>
      public DateTime HRental_EndDate
      {
         get{ return hRental_EndDate; }
         set{ hRental_EndDate = value; hRental_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 租赁结束时间
      /// </summary>
      public bool HRental_EndDate_IsChanged
      {
         get{ return hRental_EndDate_IsChanged; }
         set{ hRental_EndDate_IsChanged = value; }
      }
      /// <summary>
      /// 租金支付方式
      /// </summary>
      private string hRental_PayType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_PayType_IsChanged=false;
      /// <summary>
      /// 租金支付方式
      /// </summary>
      public string HRental_PayType
      {
         get{ return hRental_PayType; }
         set{ hRental_PayType = value; hRental_PayType_IsChanged=true; }
      }
      /// <summary>
      /// 租金支付方式
      /// </summary>
      public bool HRental_PayType_IsChanged
      {
         get{ return hRental_PayType_IsChanged; }
         set{ hRental_PayType_IsChanged = value; }
      }
      /// <summary>
      /// 房屋名称
      /// </summary>
      private string hRental_HouseName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_HouseName_IsChanged=false;
      /// <summary>
      /// 房屋名称
      /// </summary>
      public string HRental_HouseName
      {
         get{ return hRental_HouseName; }
         set{ hRental_HouseName = value; hRental_HouseName_IsChanged=true; }
      }
      /// <summary>
      /// 房屋名称
      /// </summary>
      public bool HRental_HouseName_IsChanged
      {
         get{ return hRental_HouseName_IsChanged; }
         set{ hRental_HouseName_IsChanged = value; }
      }
      /// <summary>
      /// 房屋地址
      /// </summary>
      private string hRental_HAddress;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_HAddress_IsChanged=false;
      /// <summary>
      /// 房屋地址
      /// </summary>
      public string HRental_HAddress
      {
         get{ return hRental_HAddress; }
         set{ hRental_HAddress = value; hRental_HAddress_IsChanged=true; }
      }
      /// <summary>
      /// 房屋地址
      /// </summary>
      public bool HRental_HAddress_IsChanged
      {
         get{ return hRental_HAddress_IsChanged; }
         set{ hRental_HAddress_IsChanged = value; }
      }
      /// <summary>
      /// 房屋类型
      /// </summary>
      private string hRental_HType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_HType_IsChanged=false;
      /// <summary>
      /// 房屋类型
      /// </summary>
      public string HRental_HType
      {
         get{ return hRental_HType; }
         set{ hRental_HType = value; hRental_HType_IsChanged=true; }
      }
      /// <summary>
      /// 房屋类型
      /// </summary>
      public bool HRental_HType_IsChanged
      {
         get{ return hRental_HType_IsChanged; }
         set{ hRental_HType_IsChanged = value; }
      }
      /// <summary>
      /// 房屋用途类型
      /// </summary>
      private string hRental_HUsageType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_HUsageType_IsChanged=false;
      /// <summary>
      /// 房屋用途类型
      /// </summary>
      public string HRental_HUsageType
      {
         get{ return hRental_HUsageType; }
         set{ hRental_HUsageType = value; hRental_HUsageType_IsChanged=true; }
      }
      /// <summary>
      /// 房屋用途类型
      /// </summary>
      public bool HRental_HUsageType_IsChanged
      {
         get{ return hRental_HUsageType_IsChanged; }
         set{ hRental_HUsageType_IsChanged = value; }
      }
      /// <summary>
      /// 下次缴租时间
      /// </summary>
      private DateTime hRental_NextPayDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_NextPayDate_IsChanged=false;
      /// <summary>
      /// 下次缴租时间
      /// </summary>
      public DateTime HRental_NextPayDate
      {
         get{ return hRental_NextPayDate; }
         set{ hRental_NextPayDate = value; hRental_NextPayDate_IsChanged=true; }
      }
      /// <summary>
      /// 下次缴租时间
      /// </summary>
      public bool HRental_NextPayDate_IsChanged
      {
         get{ return hRental_NextPayDate_IsChanged; }
         set{ hRental_NextPayDate_IsChanged = value; }
      }
      /// <summary>
      /// 年租金
      /// </summary>
      private decimal hRental_YearCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_YearCost_IsChanged=false;
      /// <summary>
      /// 年租金
      /// </summary>
      public decimal HRental_YearCost
      {
         get{ return hRental_YearCost; }
         set{ hRental_YearCost = value; hRental_YearCost_IsChanged=true; }
      }
      /// <summary>
      /// 年租金
      /// </summary>
      public bool HRental_YearCost_IsChanged
      {
         get{ return hRental_YearCost_IsChanged; }
         set{ hRental_YearCost_IsChanged = value; }
      }
      /// <summary>
      /// 已交组金
      /// </summary>
      private decimal hRental_Pay;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Pay_IsChanged=false;
      /// <summary>
      /// 已交组金
      /// </summary>
      public decimal HRental_Pay
      {
         get{ return hRental_Pay; }
         set{ hRental_Pay = value; hRental_Pay_IsChanged=true; }
      }
      /// <summary>
      /// 已交组金
      /// </summary>
      public bool HRental_Pay_IsChanged
      {
         get{ return hRental_Pay_IsChanged; }
         set{ hRental_Pay_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string hRental_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string HRental_Company
      {
         get{ return hRental_Company; }
         set{ hRental_Company = value; hRental_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool HRental_Company_IsChanged
      {
         get{ return hRental_Company_IsChanged; }
         set{ hRental_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string hRental_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string HRental_Dept
      {
         get{ return hRental_Dept; }
         set{ hRental_Dept = value; hRental_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool HRental_Dept_IsChanged
      {
         get{ return hRental_Dept_IsChanged; }
         set{ hRental_Dept_IsChanged = value; }
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
      /// 备注
      /// </summary>
      private string hRental_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRental_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string HRental_Remark
      {
         get{ return hRental_Remark; }
         set{ hRental_Remark = value; hRental_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool HRental_Remark_IsChanged
      {
         get{ return hRental_Remark_IsChanged; }
         set{ hRental_Remark_IsChanged = value; }
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
