using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 库存转储信息
   /// </summary>
   [Serializable]
   public partial class WH_Dump
   {
      /// <summary>
      /// 转储信息序号
      /// </summary>
      private decimal mDump_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_ID_IsChanged=false;
      /// <summary>
      /// 转储信息序号
      /// </summary>
      public decimal MDump_ID
      {
         get{ return mDump_ID; }
         set{ mDump_ID = value; mDump_ID_IsChanged=true; }
      }
      /// <summary>
      /// 转储信息序号
      /// </summary>
      public bool MDump_ID_IsChanged
      {
         get{ return mDump_ID_IsChanged; }
         set{ mDump_ID_IsChanged = value; }
      }
      /// <summary>
      /// 转储信息编码
      /// </summary>
      private string mDump_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Code_IsChanged=false;
      /// <summary>
      /// 转储信息编码
      /// </summary>
      public string MDump_Code
      {
         get{ return mDump_Code; }
         set{ mDump_Code = value; mDump_Code_IsChanged=true; }
      }
      /// <summary>
      /// 转储信息编码
      /// </summary>
      public bool MDump_Code_IsChanged
      {
         get{ return mDump_Code_IsChanged; }
         set{ mDump_Code_IsChanged = value; }
      }
      /// <summary>
      /// 转储物料编码
      /// </summary>
      private string mDump_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_MCode_IsChanged=false;
      /// <summary>
      /// 转储物料编码
      /// </summary>
      public string MDump_MCode
      {
         get{ return mDump_MCode; }
         set{ mDump_MCode = value; mDump_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 转储物料编码
      /// </summary>
      public bool MDump_MCode_IsChanged
      {
         get{ return mDump_MCode_IsChanged; }
         set{ mDump_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string mDump_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string MDump_MName
      {
         get{ return mDump_MName; }
         set{ mDump_MName = value; mDump_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool MDump_MName_IsChanged
      {
         get{ return mDump_MName_IsChanged; }
         set{ mDump_MName_IsChanged = value; }
      }
      /// <summary>
      /// 物料描述
      /// </summary>
      private string mDump_Description;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Description_IsChanged=false;
      /// <summary>
      /// 物料描述
      /// </summary>
      public string MDump_Description
      {
         get{ return mDump_Description; }
         set{ mDump_Description = value; mDump_Description_IsChanged=true; }
      }
      /// <summary>
      /// 物料描述
      /// </summary>
      public bool MDump_Description_IsChanged
      {
         get{ return mDump_Description_IsChanged; }
         set{ mDump_Description_IsChanged = value; }
      }
      /// <summary>
      /// 原仓库名称
      /// </summary>
      private string mDump_OldWarehouseName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_OldWarehouseName_IsChanged=false;
      /// <summary>
      /// 原仓库名称
      /// </summary>
      public string MDump_OldWarehouseName
      {
         get{ return mDump_OldWarehouseName; }
         set{ mDump_OldWarehouseName = value; mDump_OldWarehouseName_IsChanged=true; }
      }
      /// <summary>
      /// 原仓库名称
      /// </summary>
      public bool MDump_OldWarehouseName_IsChanged
      {
         get{ return mDump_OldWarehouseName_IsChanged; }
         set{ mDump_OldWarehouseName_IsChanged = value; }
      }
      /// <summary>
      /// 原仓库
      /// </summary>
      private string mDump_OldWarehouse;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_OldWarehouse_IsChanged=false;
      /// <summary>
      /// 原仓库
      /// </summary>
      public string MDump_OldWarehouse
      {
         get{ return mDump_OldWarehouse; }
         set{ mDump_OldWarehouse = value; mDump_OldWarehouse_IsChanged=true; }
      }
      /// <summary>
      /// 原仓库
      /// </summary>
      public bool MDump_OldWarehouse_IsChanged
      {
         get{ return mDump_OldWarehouse_IsChanged; }
         set{ mDump_OldWarehouse_IsChanged = value; }
      }
      /// <summary>
      /// 原货位名称
      /// </summary>
      private string mDump_OldWNoName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_OldWNoName_IsChanged=false;
      /// <summary>
      /// 原货位名称
      /// </summary>
      public string MDump_OldWNoName
      {
         get{ return mDump_OldWNoName; }
         set{ mDump_OldWNoName = value; mDump_OldWNoName_IsChanged=true; }
      }
      /// <summary>
      /// 原货位名称
      /// </summary>
      public bool MDump_OldWNoName_IsChanged
      {
         get{ return mDump_OldWNoName_IsChanged; }
         set{ mDump_OldWNoName_IsChanged = value; }
      }
      /// <summary>
      /// 原货位
      /// </summary>
      private string mDump_OldWNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_OldWNo_IsChanged=false;
      /// <summary>
      /// 原货位
      /// </summary>
      public string MDump_OldWNo
      {
         get{ return mDump_OldWNo; }
         set{ mDump_OldWNo = value; mDump_OldWNo_IsChanged=true; }
      }
      /// <summary>
      /// 原货位
      /// </summary>
      public bool MDump_OldWNo_IsChanged
      {
         get{ return mDump_OldWNo_IsChanged; }
         set{ mDump_OldWNo_IsChanged = value; }
      }
      /// <summary>
      /// 目标仓库名称
      /// </summary>
      private string mDump_WarehouseName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_WarehouseName_IsChanged=false;
      /// <summary>
      /// 目标仓库名称
      /// </summary>
      public string MDump_WarehouseName
      {
         get{ return mDump_WarehouseName; }
         set{ mDump_WarehouseName = value; mDump_WarehouseName_IsChanged=true; }
      }
      /// <summary>
      /// 目标仓库名称
      /// </summary>
      public bool MDump_WarehouseName_IsChanged
      {
         get{ return mDump_WarehouseName_IsChanged; }
         set{ mDump_WarehouseName_IsChanged = value; }
      }
      /// <summary>
      /// 目标仓库
      /// </summary>
      private string mDump_Warehourse;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Warehourse_IsChanged=false;
      /// <summary>
      /// 目标仓库
      /// </summary>
      public string MDump_Warehourse
      {
         get{ return mDump_Warehourse; }
         set{ mDump_Warehourse = value; mDump_Warehourse_IsChanged=true; }
      }
      /// <summary>
      /// 目标仓库
      /// </summary>
      public bool MDump_Warehourse_IsChanged
      {
         get{ return mDump_Warehourse_IsChanged; }
         set{ mDump_Warehourse_IsChanged = value; }
      }
      private string mDump_WNoName;
      private bool mDump_WNoName_IsChanged=false;
      public string MDump_WNoName
      {
         get{ return mDump_WNoName; }
         set{ mDump_WNoName = value; mDump_WNoName_IsChanged=true; }
      }
      public bool MDump_WNoName_IsChanged
      {
         get{ return mDump_WNoName_IsChanged; }
         set{ mDump_WNoName_IsChanged = value; }
      }
      private string mDump_WNo;
      private bool mDump_WNo_IsChanged=false;
      public string MDump_WNo
      {
         get{ return mDump_WNo; }
         set{ mDump_WNo = value; mDump_WNo_IsChanged=true; }
      }
      public bool MDump_WNo_IsChanged
      {
         get{ return mDump_WNo_IsChanged; }
         set{ mDump_WNo_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private decimal mDump_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Count_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public decimal MDump_Count
      {
         get{ return mDump_Count; }
         set{ mDump_Count = value; mDump_Count_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool MDump_Count_IsChanged
      {
         get{ return mDump_Count_IsChanged; }
         set{ mDump_Count_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string mDump_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string MDump_Unit
      {
         get{ return mDump_Unit; }
         set{ mDump_Unit = value; mDump_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool MDump_Unit_IsChanged
      {
         get{ return mDump_Unit_IsChanged; }
         set{ mDump_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 转储时间
      /// </summary>
      private DateTime mDump_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Date_IsChanged=false;
      /// <summary>
      /// 转储时间
      /// </summary>
      public DateTime MDump_Date
      {
         get{ return mDump_Date; }
         set{ mDump_Date = value; mDump_Date_IsChanged=true; }
      }
      /// <summary>
      /// 转储时间
      /// </summary>
      public bool MDump_Date_IsChanged
      {
         get{ return mDump_Date_IsChanged; }
         set{ mDump_Date_IsChanged = value; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      private string mDump_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Operator_IsChanged=false;
      /// <summary>
      /// 经手人
      /// </summary>
      public string MDump_Operator
      {
         get{ return mDump_Operator; }
         set{ mDump_Operator = value; mDump_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      public bool MDump_Operator_IsChanged
      {
         get{ return mDump_Operator_IsChanged; }
         set{ mDump_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string mDump_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mDump_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string MDump_Remark
      {
         get{ return mDump_Remark; }
         set{ mDump_Remark = value; mDump_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool MDump_Remark_IsChanged
      {
         get{ return mDump_Remark_IsChanged; }
         set{ mDump_Remark_IsChanged = value; }
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
      private decimal mDump_OldCount;
      private bool mDump_OldCount_IsChanged=false;
      public decimal MDump_OldCount
      {
         get{ return mDump_OldCount; }
         set{ mDump_OldCount = value; mDump_OldCount_IsChanged=true; }
      }
      public bool MDump_OldCount_IsChanged
      {
         get{ return mDump_OldCount_IsChanged; }
         set{ mDump_OldCount_IsChanged = value; }
      }
      private string mDump_Company;
      private bool mDump_Company_IsChanged=false;
      public string MDump_Company
      {
         get{ return mDump_Company; }
         set{ mDump_Company = value; mDump_Company_IsChanged=true; }
      }
      public bool MDump_Company_IsChanged
      {
         get{ return mDump_Company_IsChanged; }
         set{ mDump_Company_IsChanged = value; }
      }
      private string mDump_CompanyCode;
      private bool mDump_CompanyCode_IsChanged=false;
      public string MDump_CompanyCode
      {
         get{ return mDump_CompanyCode; }
         set{ mDump_CompanyCode = value; mDump_CompanyCode_IsChanged=true; }
      }
      public bool MDump_CompanyCode_IsChanged
      {
         get{ return mDump_CompanyCode_IsChanged; }
         set{ mDump_CompanyCode_IsChanged = value; }
      }
   }
}
