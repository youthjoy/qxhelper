using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料库存信息
   /// </summary>
   [Serializable]
   public partial class WH_WMaterial
   {
      /// <summary>
      /// 库存序号
      /// </summary>
      private decimal mW_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_ID_IsChanged=false;
      /// <summary>
      /// 库存序号
      /// </summary>
      public decimal MW_ID
      {
         get{ return mW_ID; }
         set{ mW_ID = value; mW_ID_IsChanged=true; }
      }
      /// <summary>
      /// 库存序号
      /// </summary>
      public bool MW_ID_IsChanged
      {
         get{ return mW_ID_IsChanged; }
         set{ mW_ID_IsChanged = value; }
      }
      /// <summary>
      /// 仓库代码
      /// </summary>
      private string mW_WarehouseCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_WarehouseCode_IsChanged=false;
      /// <summary>
      /// 仓库代码
      /// </summary>
      public string MW_WarehouseCode
      {
         get{ return mW_WarehouseCode; }
         set{ mW_WarehouseCode = value; mW_WarehouseCode_IsChanged=true; }
      }
      /// <summary>
      /// 仓库代码
      /// </summary>
      public bool MW_WarehouseCode_IsChanged
      {
         get{ return mW_WarehouseCode_IsChanged; }
         set{ mW_WarehouseCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      private string mW_WarehouseName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_WarehouseName_IsChanged=false;
      /// <summary>
      /// 仓库名称
      /// </summary>
      public string MW_WarehouseName
      {
         get{ return mW_WarehouseName; }
         set{ mW_WarehouseName = value; mW_WarehouseName_IsChanged=true; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      public bool MW_WarehouseName_IsChanged
      {
         get{ return mW_WarehouseName_IsChanged; }
         set{ mW_WarehouseName_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string mW_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string MW_MCode
      {
         get{ return mW_MCode; }
         set{ mW_MCode = value; mW_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool MW_MCode_IsChanged
      {
         get{ return mW_MCode_IsChanged; }
         set{ mW_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 已锁定
      /// </summary>
      private string mW_IsLock;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_IsLock_IsChanged=false;
      /// <summary>
      /// 已锁定
      /// </summary>
      public string MW_IsLock
      {
         get{ return mW_IsLock; }
         set{ mW_IsLock = value; mW_IsLock_IsChanged=true; }
      }
      /// <summary>
      /// 已锁定
      /// </summary>
      public bool MW_IsLock_IsChanged
      {
         get{ return mW_IsLock_IsChanged; }
         set{ mW_IsLock_IsChanged = value; }
      }
      /// <summary>
      /// 库存
      /// </summary>
      private int mW_StockNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_StockNum_IsChanged=false;
      /// <summary>
      /// 库存
      /// </summary>
      public int MW_StockNum
      {
         get{ return mW_StockNum; }
         set{ mW_StockNum = value; mW_StockNum_IsChanged=true; }
      }
      /// <summary>
      /// 库存
      /// </summary>
      public bool MW_StockNum_IsChanged
      {
         get{ return mW_StockNum_IsChanged; }
         set{ mW_StockNum_IsChanged = value; }
      }
      /// <summary>
      /// 已承诺
      /// </summary>
      private int mW_IsPromise;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_IsPromise_IsChanged=false;
      /// <summary>
      /// 已承诺
      /// </summary>
      public int MW_IsPromise
      {
         get{ return mW_IsPromise; }
         set{ mW_IsPromise = value; mW_IsPromise_IsChanged=true; }
      }
      /// <summary>
      /// 已承诺
      /// </summary>
      public bool MW_IsPromise_IsChanged
      {
         get{ return mW_IsPromise_IsChanged; }
         set{ mW_IsPromise_IsChanged = value; }
      }
      /// <summary>
      /// 已订购
      /// </summary>
      private int mW_IsOrder;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_IsOrder_IsChanged=false;
      /// <summary>
      /// 已订购
      /// </summary>
      public int MW_IsOrder
      {
         get{ return mW_IsOrder; }
         set{ mW_IsOrder = value; mW_IsOrder_IsChanged=true; }
      }
      /// <summary>
      /// 已订购
      /// </summary>
      public bool MW_IsOrder_IsChanged
      {
         get{ return mW_IsOrder_IsChanged; }
         set{ mW_IsOrder_IsChanged = value; }
      }
      /// <summary>
      /// 可用的
      /// </summary>
      private int mW_IsAble;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_IsAble_IsChanged=false;
      /// <summary>
      /// 可用的
      /// </summary>
      public int MW_IsAble
      {
         get{ return mW_IsAble; }
         set{ mW_IsAble = value; mW_IsAble_IsChanged=true; }
      }
      /// <summary>
      /// 可用的
      /// </summary>
      public bool MW_IsAble_IsChanged
      {
         get{ return mW_IsAble_IsChanged; }
         set{ mW_IsAble_IsChanged = value; }
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
      /// 库存最大值
      /// </summary>
      private int mW_High;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_High_IsChanged=false;
      /// <summary>
      /// 库存最大值
      /// </summary>
      public int MW_High
      {
         get{ return mW_High; }
         set{ mW_High = value; mW_High_IsChanged=true; }
      }
      /// <summary>
      /// 库存最大值
      /// </summary>
      public bool MW_High_IsChanged
      {
         get{ return mW_High_IsChanged; }
         set{ mW_High_IsChanged = value; }
      }
      /// <summary>
      /// 库存最小值
      /// </summary>
      private int mW_Low;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mW_Low_IsChanged=false;
      /// <summary>
      /// 库存最小值
      /// </summary>
      public int MW_Low
      {
         get{ return mW_Low; }
         set{ mW_Low = value; mW_Low_IsChanged=true; }
      }
      /// <summary>
      /// 库存最小值
      /// </summary>
      public bool MW_Low_IsChanged
      {
         get{ return mW_Low_IsChanged; }
         set{ mW_Low_IsChanged = value; }
      }
   }
}
