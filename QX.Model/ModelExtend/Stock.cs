using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    /// <summary>
    /// 页面入库模型
    /// </summary>
    public class StockInModel
    {
        /// <summary>
        /// 供应商编码
        /// </summary>
        public string SBI_SCode { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string WHP_SName { get; set; }
        /// <summary>
        /// 供应商联系人
        /// </summary>
        public string MV_RefKey { get; set; }
        /// <summary>
        /// 参考单据编码
        /// </summary>
        public string MV_RefRecord { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string Warehouse_Code { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string Warehouse_Name { get; set; }
        /// <summary>
        /// 单据编码
        /// </summary>
        public string MV_RecordCode { get; set; }
        /// <summary>
        /// 供应商参考号
        /// </summary>
        public string MV_CustRef { get; set; }

    }
    /// <summary>
    /// 页面出库类型
    /// </summary>
    public class StockOutModel{
        /// <summary>
        /// 参考单据
        /// </summary>
        public string RM_RefCode { get; set; }
        /// <summary>
        /// 领用部门
        /// </summary>
        public string MVI_CostDept { get; set; }
        /// <summary>
        /// 领用人
        /// </summary>
        public string MVI_CostStuff { get; set; }
        /// <summary>
        /// 领用时间
        /// </summary>
        public string MVI_CostDate { get; set; }
        /// <summary>
        /// 领用单据编码
        /// </summary>
        public string MV_RecordCode { get; set; }
    }

    public class StockCModel
    {
        /// <summary>
        /// 库存序号
        /// </summary>
        private int mW_ID;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_ID_IsChanged = false;
        /// <summary>
        /// 库存序号
        /// </summary>
        [MetaData("MW_ID", "库存序号")]
        public int MW_ID
        {
            get { return mW_ID; }
            set { mW_ID = value; mW_ID_IsChanged = true; }
        }
        /// <summary>
        /// 库存序号
        /// </summary>
        public bool MW_ID_IsChanged
        {
            get { return mW_ID_IsChanged; }
            set { mW_ID_IsChanged = value; }
        }
        /// <summary>
        /// 仓库代码
        /// </summary>
        private string mW_WarehouseCode;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_WarehouseCode_IsChanged = false;
        /// <summary>
        /// 仓库代码
        /// </summary>
        [MetaData("MW_WarehouseCode", "仓库代码")]
        public string MW_WarehouseCode
        {
            get { return mW_WarehouseCode; }
            set { mW_WarehouseCode = value; mW_WarehouseCode_IsChanged = true; }
        }
        /// <summary>
        /// 仓库代码
        /// </summary>
        public bool MW_WarehouseCode_IsChanged
        {
            get { return mW_WarehouseCode_IsChanged; }
            set { mW_WarehouseCode_IsChanged = value; }
        }
        /// <summary>
        /// 仓库名称
        /// </summary>
        private string mW_WarehouseName;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_WarehouseName_IsChanged = false;
        /// <summary>
        /// 仓库名称
        /// </summary>
        [MetaData("MW_WarehouseName", "仓库名称")]
        public string MW_WarehouseName
        {
            get { return mW_WarehouseName; }
            set { mW_WarehouseName = value; mW_WarehouseName_IsChanged = true; }
        }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public bool MW_WarehouseName_IsChanged
        {
            get { return mW_WarehouseName_IsChanged; }
            set { mW_WarehouseName_IsChanged = value; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        private string mW_MCode;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_MCode_IsChanged = false;
        /// <summary>
        /// 物料编码
        /// </summary>
        [MetaData("MW_MCode", "物料编码")]
        public string MW_MCode
        {
            get { return mW_MCode; }
            set { mW_MCode = value; mW_MCode_IsChanged = true; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public bool MW_MCode_IsChanged
        {
            get { return mW_MCode_IsChanged; }
            set { mW_MCode_IsChanged = value; }
        }
        /// <summary>
        /// 已锁定
        /// </summary>
        private string mW_IsLock;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_IsLock_IsChanged = false;
        /// <summary>
        /// 已锁定
        /// </summary>
        [MetaData("MW_IsLock", "已锁定")]
        public string MW_IsLock
        {
            get { return mW_IsLock; }
            set { mW_IsLock = value; mW_IsLock_IsChanged = true; }
        }
        /// <summary>
        /// 已锁定
        /// </summary>
        public bool MW_IsLock_IsChanged
        {
            get { return mW_IsLock_IsChanged; }
            set { mW_IsLock_IsChanged = value; }
        }
        /// <summary>
        /// 库存
        /// </summary>
        private int mW_StockNum;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_StockNum_IsChanged = false;
        /// <summary>
        /// 库存
        /// </summary>
        [MetaData("MW_StockNum", "库存")]
        public int MW_StockNum
        {
            get { return mW_StockNum; }
            set { mW_StockNum = value; mW_StockNum_IsChanged = true; }
        }
        /// <summary>
        /// 库存
        /// </summary>
        public bool MW_StockNum_IsChanged
        {
            get { return mW_StockNum_IsChanged; }
            set { mW_StockNum_IsChanged = value; }
        }
        /// <summary>
        /// 已承诺
        /// </summary>
        private int mW_IsPromise;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_IsPromise_IsChanged = false;
        /// <summary>
        /// 已承诺
        /// </summary>
        [MetaData("MW_IsPromise", "已承诺")]
        public int MW_IsPromise
        {
            get { return mW_IsPromise; }
            set { mW_IsPromise = value; mW_IsPromise_IsChanged = true; }
        }
        /// <summary>
        /// 已承诺
        /// </summary>
        public bool MW_IsPromise_IsChanged
        {
            get { return mW_IsPromise_IsChanged; }
            set { mW_IsPromise_IsChanged = value; }
        }
        /// <summary>
        /// 已订购
        /// </summary>
        private int mW_IsOrder;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_IsOrder_IsChanged = false;
        /// <summary>
        /// 已订购
        /// </summary>
        [MetaData("MW_IsOrder", "已订购")]
        public int MW_IsOrder
        {
            get { return mW_IsOrder; }
            set { mW_IsOrder = value; mW_IsOrder_IsChanged = true; }
        }
        /// <summary>
        /// 已订购
        /// </summary>
        public bool MW_IsOrder_IsChanged
        {
            get { return mW_IsOrder_IsChanged; }
            set { mW_IsOrder_IsChanged = value; }
        }
        /// <summary>
        /// 可用的
        /// </summary>
        private int mW_IsAble;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_IsAble_IsChanged = false;
        /// <summary>
        /// 可用的
        /// </summary>
        [MetaData("MW_IsAble", "可用的")]
        public int MW_IsAble
        {
            get { return mW_IsAble; }
            set { mW_IsAble = value; mW_IsAble_IsChanged = true; }
        }
        /// <summary>
        /// 可用的
        /// </summary>
        public bool MW_IsAble_IsChanged
        {
            get { return mW_IsAble_IsChanged; }
            set { mW_IsAble_IsChanged = value; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        private int stat;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool stat_IsChanged = false;
        /// <summary>
        /// 状态
        /// </summary>
        [MetaData("Stat", "状态")]
        public int Stat
        {
            get { return stat; }
            set { stat = value; stat_IsChanged = true; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public bool Stat_IsChanged
        {
            get { return stat_IsChanged; }
            set { stat_IsChanged = value; }
        }
        /// <summary>
        /// 库存最大值
        /// </summary>
        private int mW_High;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_High_IsChanged = false;
        /// <summary>
        /// 库存最大值
        /// </summary>
        [MetaData("MW_High", "库存最大值")]
        public int MW_High
        {
            get { return mW_High; }
            set { mW_High = value; mW_High_IsChanged = true; }
        }
        /// <summary>
        /// 库存最大值
        /// </summary>
        public bool MW_High_IsChanged
        {
            get { return mW_High_IsChanged; }
            set { mW_High_IsChanged = value; }
        }
        /// <summary>
        /// 库存最小值
        /// </summary>
        private int mW_Low;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mW_Low_IsChanged = false;
        /// <summary>
        /// 库存最小值
        /// </summary>
        [MetaData("MW_Low", "库存最小值")]
        public int MW_Low
        {
            get { return mW_Low; }
            set { mW_Low = value; mW_Low_IsChanged = true; }
        }
        /// <summary>
        /// 库存最小值
        /// </summary>
        public bool MW_Low_IsChanged
        {
            get { return mW_Low_IsChanged; }
            set { mW_Low_IsChanged = value; }
        }

        /// <summary>
        /// 物料序号
        /// </summary>
        private int mD_ID;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_ID_IsChanged = false;
        /// <summary>
        /// 物料序号
        /// </summary>
        [MetaData("MD_ID", "物料序号")]
        public int MD_ID
        {
            get { return mD_ID; }
            set { mD_ID = value; mD_ID_IsChanged = true; }
        }
        /// <summary>
        /// 物料序号
        /// </summary>
        public bool MD_ID_IsChanged
        {
            get { return mD_ID_IsChanged; }
            set { mD_ID_IsChanged = value; }
        }
        /// <summary>
        /// 物料编号
        /// </summary>
        private string mD_MCode;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_MCode_IsChanged = false;
        /// <summary>
        /// 物料编号
        /// </summary>
        [MetaData("MD_MCode", "物料编号")]
        public string MD_MCode
        {
            get { return mD_MCode; }
            set { mD_MCode = value; mD_MCode_IsChanged = true; }
        }
        /// <summary>
        /// 物料编号
        /// </summary>
        public bool MD_MCode_IsChanged
        {
            get { return mD_MCode_IsChanged; }
            set { mD_MCode_IsChanged = value; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        private string mD_Name;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Name_IsChanged = false;
        /// <summary>
        /// 物料名称
        /// </summary>
        [MetaData("MD_Name", "物料名称")]
        public string MD_Name
        {
            get { return mD_Name; }
            set { mD_Name = value; mD_Name_IsChanged = true; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public bool MD_Name_IsChanged
        {
            get { return mD_Name_IsChanged; }
            set { mD_Name_IsChanged = value; }
        }
        /// <summary>
        /// 条形码
        /// </summary>
        private string mD_Barcode;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Barcode_IsChanged = false;
        /// <summary>
        /// 条形码
        /// </summary>
        [MetaData("MD_Barcode", "条形码")]
        public string MD_Barcode
        {
            get { return mD_Barcode; }
            set { mD_Barcode = value; mD_Barcode_IsChanged = true; }
        }
        /// <summary>
        /// 条形码
        /// </summary>
        public bool MD_Barcode_IsChanged
        {
            get { return mD_Barcode_IsChanged; }
            set { mD_Barcode_IsChanged = value; }
        }
        /// <summary>
        /// 物料组
        /// </summary>
        private string mD_Group;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Group_IsChanged = false;
        /// <summary>
        /// 物料组
        /// </summary>
        [MetaData("MD_Group", "物料组")]
        public string MD_Group
        {
            get { return mD_Group; }
            set { mD_Group = value; mD_Group_IsChanged = true; }
        }
        /// <summary>
        /// 物料组
        /// </summary>
        public bool MD_Group_IsChanged
        {
            get { return mD_Group_IsChanged; }
            set { mD_Group_IsChanged = value; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        private string mD_PriceList;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_PriceList_IsChanged = false;
        /// <summary>
        /// 价格
        /// </summary>
        [MetaData("MD_PriceList", "价格")]
        public string MD_PriceList
        {
            get { return mD_PriceList; }
            set { mD_PriceList = value; mD_PriceList_IsChanged = true; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        public bool MD_PriceList_IsChanged
        {
            get { return mD_PriceList_IsChanged; }
            set { mD_PriceList_IsChanged = value; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        private int mD_Num;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Num_IsChanged = false;
        /// <summary>
        /// 数量
        /// </summary>
        [MetaData("MD_Num", "数量")]
        public int MD_Num
        {
            get { return mD_Num; }
            set { mD_Num = value; mD_Num_IsChanged = true; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public bool MD_Num_IsChanged
        {
            get { return mD_Num_IsChanged; }
            set { mD_Num_IsChanged = value; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        private string mD_Unit;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Unit_IsChanged = false;
        /// <summary>
        /// 单位
        /// </summary>
        [MetaData("MD_Unit", "单位")]
        public string MD_Unit
        {
            get { return mD_Unit; }
            set { mD_Unit = value; mD_Unit_IsChanged = true; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public bool MD_Unit_IsChanged
        {
            get { return mD_Unit_IsChanged; }
            set { mD_Unit_IsChanged = value; }
        }
        /// <summary>
        /// 制造厂商
        /// </summary>
        private string mD_Factory;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Factory_IsChanged = false;
        /// <summary>
        /// 制造厂商
        /// </summary>
        [MetaData("MD_Factory", "制造厂商")]
        public string MD_Factory
        {
            get { return mD_Factory; }
            set { mD_Factory = value; mD_Factory_IsChanged = true; }
        }
        /// <summary>
        /// 制造厂商
        /// </summary>
        public bool MD_Factory_IsChanged
        {
            get { return mD_Factory_IsChanged; }
            set { mD_Factory_IsChanged = value; }
        }
        /// <summary>
        /// 存货度量单位
        /// </summary>
        private string mD_Units;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Units_IsChanged = false;
        /// <summary>
        /// 存货度量单位
        /// </summary>
        [MetaData("MD_Units", "存货度量单位")]
        public string MD_Units
        {
            get { return mD_Units; }
            set { mD_Units = value; mD_Units_IsChanged = true; }
        }
        /// <summary>
        /// 存货度量单位
        /// </summary>
        public bool MD_Units_IsChanged
        {
            get { return mD_Units_IsChanged; }
            set { mD_Units_IsChanged = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        private string mD_Bak;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Bak_IsChanged = false;
        /// <summary>
        /// 备注
        /// </summary>
        [MetaData("MD_Bak", "备注")]
        public string MD_Bak
        {
            get { return mD_Bak; }
            set { mD_Bak = value; mD_Bak_IsChanged = true; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public bool MD_Bak_IsChanged
        {
            get { return mD_Bak_IsChanged; }
            set { mD_Bak_IsChanged = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        private DateTime createTime;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool createTime_IsChanged = false;
        /// <summary>
        /// 创建时间
        /// </summary>
        [MetaData("CreateTime", "创建时间")]
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; createTime_IsChanged = true; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public bool CreateTime_IsChanged
        {
            get { return createTime_IsChanged; }
            set { createTime_IsChanged = value; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        private DateTime uPTDate;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool uPTDate_IsChanged = false;
        /// <summary>
        /// 更新时间
        /// </summary>
        [MetaData("UPTDate", "更新时间")]
        public DateTime UPTDate
        {
            get { return uPTDate; }
            set { uPTDate = value; uPTDate_IsChanged = true; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public bool UPTDate_IsChanged
        {
            get { return uPTDate_IsChanged; }
            set { uPTDate_IsChanged = value; }
        }
        /// <summary>
        /// 删除时间
        /// </summary>
        private DateTime dELDate;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool dELDate_IsChanged = false;
        /// <summary>
        /// 删除时间
        /// </summary>
        [MetaData("DELDate", "删除时间")]
        public DateTime DELDate
        {
            get { return dELDate; }
            set { dELDate = value; dELDate_IsChanged = true; }
        }
        /// <summary>
        /// 删除时间
        /// </summary>
        public bool DELDate_IsChanged
        {
            get { return dELDate_IsChanged; }
            set { dELDate_IsChanged = value; }
        }  
        /// <summary>
        /// 规格
        /// </summary>
        private string mD_Spec;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool mD_Spec_IsChanged = false;
        /// <summary>
        /// 规格
        /// </summary>
        [MetaData("MD_Spec", "规格")]
        public string MD_Spec
        {
            get { return mD_Spec; }
            set { mD_Spec = value; mD_Spec_IsChanged = true; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public bool MD_Spec_IsChanged
        {
            get { return mD_Spec_IsChanged; }
            set { mD_Spec_IsChanged = value; }
        }
    }
}
