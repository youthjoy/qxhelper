using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料库存移动信息（出入库，请购单）
   /// </summary>
   [Serializable]
   public partial class WH_MVItem
   {
      /// <summary>
      /// 库存移动ID
      /// </summary>
      private decimal mVI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_ID_IsChanged=false;
      /// <summary>
      /// 库存移动ID
      /// </summary>
      public decimal MVI_ID
      {
         get{ return mVI_ID; }
         set{ mVI_ID = value; mVI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 库存移动ID
      /// </summary>
      public bool MVI_ID_IsChanged
      {
         get{ return mVI_ID_IsChanged; }
         set{ mVI_ID_IsChanged = value; }
      }
      private string mVI_Code;
      private bool mVI_Code_IsChanged=false;
      public string MVI_Code
      {
         get{ return mVI_Code; }
         set{ mVI_Code = value; mVI_Code_IsChanged=true; }
      }
      public bool MVI_Code_IsChanged
      {
         get{ return mVI_Code_IsChanged; }
         set{ mVI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 主单据编码
      /// </summary>
      private string mVI_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_RCode_IsChanged=false;
      /// <summary>
      /// 主单据编码
      /// </summary>
      public string MVI_RCode
      {
         get{ return mVI_RCode; }
         set{ mVI_RCode = value; mVI_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 主单据编码
      /// </summary>
      public bool MVI_RCode_IsChanged
      {
         get{ return mVI_RCode_IsChanged; }
         set{ mVI_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 库存移动类型
      /// </summary>
      private string mVI_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Type_IsChanged=false;
      /// <summary>
      /// 库存移动类型
      /// </summary>
      public string MVI_Type
      {
         get{ return mVI_Type; }
         set{ mVI_Type = value; mVI_Type_IsChanged=true; }
      }
      /// <summary>
      /// 库存移动类型
      /// </summary>
      public bool MVI_Type_IsChanged
      {
         get{ return mVI_Type_IsChanged; }
         set{ mVI_Type_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string mVI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string MVI_MCode
      {
         get{ return mVI_MCode; }
         set{ mVI_MCode = value; mVI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool MVI_MCode_IsChanged
      {
         get{ return mVI_MCode_IsChanged; }
         set{ mVI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      private string mVI_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Spec_IsChanged=false;
      /// <summary>
      /// 规格
      /// </summary>
      public string MVI_Spec
      {
         get{ return mVI_Spec; }
         set{ mVI_Spec = value; mVI_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      public bool MVI_Spec_IsChanged
      {
         get{ return mVI_Spec_IsChanged; }
         set{ mVI_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 供货单位
      /// </summary>
      private string mVI_Sup;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Sup_IsChanged=false;
      /// <summary>
      /// 供货单位
      /// </summary>
      public string MVI_Sup
      {
         get{ return mVI_Sup; }
         set{ mVI_Sup = value; mVI_Sup_IsChanged=true; }
      }
      /// <summary>
      /// 供货单位
      /// </summary>
      public bool MVI_Sup_IsChanged
      {
         get{ return mVI_Sup_IsChanged; }
         set{ mVI_Sup_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int mVI_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int MVI_Num
      {
         get{ return mVI_Num; }
         set{ mVI_Num = value; mVI_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool MVI_Num_IsChanged
      {
         get{ return mVI_Num_IsChanged; }
         set{ mVI_Num_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string mVI_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string MVI_Unit
      {
         get{ return mVI_Unit; }
         set{ mVI_Unit = value; mVI_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool MVI_Unit_IsChanged
      {
         get{ return mVI_Unit_IsChanged; }
         set{ mVI_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 单位价格
      /// </summary>
      private decimal mVI_MDPrice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_MDPrice_IsChanged=false;
      /// <summary>
      /// 单位价格
      /// </summary>
      public decimal MVI_MDPrice
      {
         get{ return mVI_MDPrice; }
         set{ mVI_MDPrice = value; mVI_MDPrice_IsChanged=true; }
      }
      /// <summary>
      /// 单位价格
      /// </summary>
      public bool MVI_MDPrice_IsChanged
      {
         get{ return mVI_MDPrice_IsChanged; }
         set{ mVI_MDPrice_IsChanged = value; }
      }
      /// <summary>
      /// 领用人
      /// </summary>
      private string mVI_CostStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_CostStuff_IsChanged=false;
      /// <summary>
      /// 领用人
      /// </summary>
      public string MVI_CostStuff
      {
         get{ return mVI_CostStuff; }
         set{ mVI_CostStuff = value; mVI_CostStuff_IsChanged=true; }
      }
      /// <summary>
      /// 领用人
      /// </summary>
      public bool MVI_CostStuff_IsChanged
      {
         get{ return mVI_CostStuff_IsChanged; }
         set{ mVI_CostStuff_IsChanged = value; }
      }
      private string mVI_CostStuffCode;
      private bool mVI_CostStuffCode_IsChanged=false;
      public string MVI_CostStuffCode
      {
         get{ return mVI_CostStuffCode; }
         set{ mVI_CostStuffCode = value; mVI_CostStuffCode_IsChanged=true; }
      }
      public bool MVI_CostStuffCode_IsChanged
      {
         get{ return mVI_CostStuffCode_IsChanged; }
         set{ mVI_CostStuffCode_IsChanged = value; }
      }
      /// <summary>
      /// 领用部门
      /// </summary>
      private string mVI_CostDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_CostDept_IsChanged=false;
      /// <summary>
      /// 领用部门
      /// </summary>
      public string MVI_CostDept
      {
         get{ return mVI_CostDept; }
         set{ mVI_CostDept = value; mVI_CostDept_IsChanged=true; }
      }
      /// <summary>
      /// 领用部门
      /// </summary>
      public bool MVI_CostDept_IsChanged
      {
         get{ return mVI_CostDept_IsChanged; }
         set{ mVI_CostDept_IsChanged = value; }
      }
      private string mVI_CostDeptCode;
      private bool mVI_CostDeptCode_IsChanged=false;
      public string MVI_CostDeptCode
      {
         get{ return mVI_CostDeptCode; }
         set{ mVI_CostDeptCode = value; mVI_CostDeptCode_IsChanged=true; }
      }
      public bool MVI_CostDeptCode_IsChanged
      {
         get{ return mVI_CostDeptCode_IsChanged; }
         set{ mVI_CostDeptCode_IsChanged = value; }
      }
      /// <summary>
      /// 对应成本设备
      /// </summary>
      private string mVI_CostEqu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_CostEqu_IsChanged=false;
      /// <summary>
      /// 对应成本设备
      /// </summary>
      public string MVI_CostEqu
      {
         get{ return mVI_CostEqu; }
         set{ mVI_CostEqu = value; mVI_CostEqu_IsChanged=true; }
      }
      /// <summary>
      /// 对应成本设备
      /// </summary>
      public bool MVI_CostEqu_IsChanged
      {
         get{ return mVI_CostEqu_IsChanged; }
         set{ mVI_CostEqu_IsChanged = value; }
      }
      /// <summary>
      /// 领用时间
      /// </summary>
      private DateTime mVI_CostDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_CostDate_IsChanged=false;
      /// <summary>
      /// 领用时间
      /// </summary>
      public DateTime MVI_CostDate
      {
         get{ return mVI_CostDate; }
         set{ mVI_CostDate = value; mVI_CostDate_IsChanged=true; }
      }
      /// <summary>
      /// 领用时间
      /// </summary>
      public bool MVI_CostDate_IsChanged
      {
         get{ return mVI_CostDate_IsChanged; }
         set{ mVI_CostDate_IsChanged = value; }
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
      /// 发票序号
      /// </summary>
      private string wHI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_ID_IsChanged=false;
      /// <summary>
      /// 发票序号
      /// </summary>
      public string WHI_ID
      {
         get{ return wHI_ID; }
         set{ wHI_ID = value; wHI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 发票序号
      /// </summary>
      public bool WHI_ID_IsChanged
      {
         get{ return wHI_ID_IsChanged; }
         set{ wHI_ID_IsChanged = value; }
      }
   }
}
