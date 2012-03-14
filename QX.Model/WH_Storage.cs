using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 库存量信息表
   /// </summary>
   [Serializable]
   public partial class WH_Storage
   {
      /// <summary>
      /// 库存信息序号
      /// </summary>
      private decimal storage_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_ID_IsChanged=false;
      /// <summary>
      /// 库存信息序号
      /// </summary>
      public decimal Storage_ID
      {
         get{ return storage_ID; }
         set{ storage_ID = value; storage_ID_IsChanged=true; }
      }
      /// <summary>
      /// 库存信息序号
      /// </summary>
      public bool Storage_ID_IsChanged
      {
         get{ return storage_ID_IsChanged; }
         set{ storage_ID_IsChanged = value; }
      }
      /// <summary>
      /// 库存信息编码
      /// </summary>
      private string storage_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_Code_IsChanged=false;
      /// <summary>
      /// 库存信息编码
      /// </summary>
      public string Storage_Code
      {
         get{ return storage_Code; }
         set{ storage_Code = value; storage_Code_IsChanged=true; }
      }
      /// <summary>
      /// 库存信息编码
      /// </summary>
      public bool Storage_Code_IsChanged
      {
         get{ return storage_Code_IsChanged; }
         set{ storage_Code_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string storage_MaterielCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_MaterielCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string Storage_MaterielCode
      {
         get{ return storage_MaterielCode; }
         set{ storage_MaterielCode = value; storage_MaterielCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool Storage_MaterielCode_IsChanged
      {
         get{ return storage_MaterielCode_IsChanged; }
         set{ storage_MaterielCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓库编码
      /// </summary>
      private string storage_WarehouseCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_WarehouseCode_IsChanged=false;
      /// <summary>
      /// 仓库编码
      /// </summary>
      public string Storage_WarehouseCode
      {
         get{ return storage_WarehouseCode; }
         set{ storage_WarehouseCode = value; storage_WarehouseCode_IsChanged=true; }
      }
      /// <summary>
      /// 仓库编码
      /// </summary>
      public bool Storage_WarehouseCode_IsChanged
      {
         get{ return storage_WarehouseCode_IsChanged; }
         set{ storage_WarehouseCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓库号
      /// </summary>
      private string storage_WarehouseNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_WarehouseNo_IsChanged=false;
      /// <summary>
      /// 仓库号
      /// </summary>
      public string Storage_WarehouseNo
      {
         get{ return storage_WarehouseNo; }
         set{ storage_WarehouseNo = value; storage_WarehouseNo_IsChanged=true; }
      }
      /// <summary>
      /// 仓库号
      /// </summary>
      public bool Storage_WarehouseNo_IsChanged
      {
         get{ return storage_WarehouseNo_IsChanged; }
         set{ storage_WarehouseNo_IsChanged = value; }
      }
      /// <summary>
      /// 库存
      /// </summary>
      private decimal storage_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_Count_IsChanged=false;
      /// <summary>
      /// 库存
      /// </summary>
      public decimal Storage_Count
      {
         get{ return storage_Count; }
         set{ storage_Count = value; storage_Count_IsChanged=true; }
      }
      /// <summary>
      /// 库存
      /// </summary>
      public bool Storage_Count_IsChanged
      {
         get{ return storage_Count_IsChanged; }
         set{ storage_Count_IsChanged = value; }
      }
      /// <summary>
      /// 已承诺
      /// </summary>
      private decimal storage_PromiseCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_PromiseCount_IsChanged=false;
      /// <summary>
      /// 已承诺
      /// </summary>
      public decimal Storage_PromiseCount
      {
         get{ return storage_PromiseCount; }
         set{ storage_PromiseCount = value; storage_PromiseCount_IsChanged=true; }
      }
      /// <summary>
      /// 已承诺
      /// </summary>
      public bool Storage_PromiseCount_IsChanged
      {
         get{ return storage_PromiseCount_IsChanged; }
         set{ storage_PromiseCount_IsChanged = value; }
      }
      /// <summary>
      /// 已订购
      /// </summary>
      private decimal storage_OrderCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_OrderCount_IsChanged=false;
      /// <summary>
      /// 已订购
      /// </summary>
      public decimal Storage_OrderCount
      {
         get{ return storage_OrderCount; }
         set{ storage_OrderCount = value; storage_OrderCount_IsChanged=true; }
      }
      /// <summary>
      /// 已订购
      /// </summary>
      public bool Storage_OrderCount_IsChanged
      {
         get{ return storage_OrderCount_IsChanged; }
         set{ storage_OrderCount_IsChanged = value; }
      }
      /// <summary>
      /// 可用的
      /// </summary>
      private decimal storage_Available;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_Available_IsChanged=false;
      /// <summary>
      /// 可用的
      /// </summary>
      public decimal Storage_Available
      {
         get{ return storage_Available; }
         set{ storage_Available = value; storage_Available_IsChanged=true; }
      }
      /// <summary>
      /// 可用的
      /// </summary>
      public bool Storage_Available_IsChanged
      {
         get{ return storage_Available_IsChanged; }
         set{ storage_Available_IsChanged = value; }
      }
      /// <summary>
      /// 库存最大值
      /// </summary>
      private decimal storage_TNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_TNum_IsChanged=false;
      /// <summary>
      /// 库存最大值
      /// </summary>
      public decimal Storage_TNum
      {
         get{ return storage_TNum; }
         set{ storage_TNum = value; storage_TNum_IsChanged=true; }
      }
      /// <summary>
      /// 库存最大值
      /// </summary>
      public bool Storage_TNum_IsChanged
      {
         get{ return storage_TNum_IsChanged; }
         set{ storage_TNum_IsChanged = value; }
      }
      /// <summary>
      /// 库存最小值
      /// </summary>
      private decimal storage_LNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_LNum_IsChanged=false;
      /// <summary>
      /// 库存最小值
      /// </summary>
      public decimal Storage_LNum
      {
         get{ return storage_LNum; }
         set{ storage_LNum = value; storage_LNum_IsChanged=true; }
      }
      /// <summary>
      /// 库存最小值
      /// </summary>
      public bool Storage_LNum_IsChanged
      {
         get{ return storage_LNum_IsChanged; }
         set{ storage_LNum_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string storage_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Storage_Remark
      {
         get{ return storage_Remark; }
         set{ storage_Remark = value; storage_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Storage_Remark_IsChanged
      {
         get{ return storage_Remark_IsChanged; }
         set{ storage_Remark_IsChanged = value; }
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
      private string storage_Warehouse;
      private bool storage_Warehouse_IsChanged=false;
      public string Storage_Warehouse
      {
         get{ return storage_Warehouse; }
         set{ storage_Warehouse = value; storage_Warehouse_IsChanged=true; }
      }
      public bool Storage_Warehouse_IsChanged
      {
         get{ return storage_Warehouse_IsChanged; }
         set{ storage_Warehouse_IsChanged = value; }
      }
      private string storage_WarehouseNoName;
      private bool storage_WarehouseNoName_IsChanged=false;
      public string Storage_WarehouseNoName
      {
         get{ return storage_WarehouseNoName; }
         set{ storage_WarehouseNoName = value; storage_WarehouseNoName_IsChanged=true; }
      }
      public bool Storage_WarehouseNoName_IsChanged
      {
         get{ return storage_WarehouseNoName_IsChanged; }
         set{ storage_WarehouseNoName_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string storage_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string Storage_Company
      {
         get{ return storage_Company; }
         set{ storage_Company = value; storage_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool Storage_Company_IsChanged
      {
         get{ return storage_Company_IsChanged; }
         set{ storage_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司编码
      /// </summary>
      private string storage_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_CompanyCode_IsChanged=false;
      /// <summary>
      /// 所属公司编码
      /// </summary>
      public string Storage_CompanyCode
      {
         get{ return storage_CompanyCode; }
         set{ storage_CompanyCode = value; storage_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司编码
      /// </summary>
      public bool Storage_CompanyCode_IsChanged
      {
         get{ return storage_CompanyCode_IsChanged; }
         set{ storage_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 经验库存
      /// </summary>
      private decimal storage_Dvalue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool storage_Dvalue_IsChanged=false;
      /// <summary>
      /// 经验库存
      /// </summary>
      public decimal Storage_Dvalue
      {
         get{ return storage_Dvalue; }
         set{ storage_Dvalue = value; storage_Dvalue_IsChanged=true; }
      }
      /// <summary>
      /// 经验库存
      /// </summary>
      public bool Storage_Dvalue_IsChanged
      {
         get{ return storage_Dvalue_IsChanged; }
         set{ storage_Dvalue_IsChanged = value; }
      }
      private decimal storage_Price;
      private bool storage_Price_IsChanged=false;
      public decimal Storage_Price
      {
         get{ return storage_Price; }
         set{ storage_Price = value; storage_Price_IsChanged=true; }
      }
      public bool Storage_Price_IsChanged
      {
         get{ return storage_Price_IsChanged; }
         set{ storage_Price_IsChanged = value; }
      }
      private string storage_UDEF1;
      private bool storage_UDEF1_IsChanged=false;
      public string Storage_UDEF1
      {
         get{ return storage_UDEF1; }
         set{ storage_UDEF1 = value; storage_UDEF1_IsChanged=true; }
      }
      public bool Storage_UDEF1_IsChanged
      {
         get{ return storage_UDEF1_IsChanged; }
         set{ storage_UDEF1_IsChanged = value; }
      }
      private string storage_UDEF2;
      private bool storage_UDEF2_IsChanged=false;
      public string Storage_UDEF2
      {
         get{ return storage_UDEF2; }
         set{ storage_UDEF2 = value; storage_UDEF2_IsChanged=true; }
      }
      public bool Storage_UDEF2_IsChanged
      {
         get{ return storage_UDEF2_IsChanged; }
         set{ storage_UDEF2_IsChanged = value; }
      }
      private string storage_UDEF3;
      private bool storage_UDEF3_IsChanged=false;
      public string Storage_UDEF3
      {
         get{ return storage_UDEF3; }
         set{ storage_UDEF3 = value; storage_UDEF3_IsChanged=true; }
      }
      public bool Storage_UDEF3_IsChanged
      {
         get{ return storage_UDEF3_IsChanged; }
         set{ storage_UDEF3_IsChanged = value; }
      }
      private string storage_UDEF4;
      private bool storage_UDEF4_IsChanged=false;
      public string Storage_UDEF4
      {
         get{ return storage_UDEF4; }
         set{ storage_UDEF4 = value; storage_UDEF4_IsChanged=true; }
      }
      public bool Storage_UDEF4_IsChanged
      {
         get{ return storage_UDEF4_IsChanged; }
         set{ storage_UDEF4_IsChanged = value; }
      }
      private string storage_UDEF5;
      private bool storage_UDEF5_IsChanged=false;
      public string Storage_UDEF5
      {
         get{ return storage_UDEF5; }
         set{ storage_UDEF5 = value; storage_UDEF5_IsChanged=true; }
      }
      public bool Storage_UDEF5_IsChanged
      {
         get{ return storage_UDEF5_IsChanged; }
         set{ storage_UDEF5_IsChanged = value; }
      }
   }
}
