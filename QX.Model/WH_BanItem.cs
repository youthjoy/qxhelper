using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
    /// 盘点物料列表 
   /// </summary>
   [Serializable]
   public partial class WH_BanItem
   {
      /// <summary>
      /// 盘点物料序号
      /// </summary>
      private decimal wHBI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_ID_IsChanged=false;
      /// <summary>
      /// 盘点物料序号
      /// </summary>
      public decimal WHBI_ID
      {
         get{ return wHBI_ID; }
         set{ wHBI_ID = value; wHBI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 盘点物料序号
      /// </summary>
      public bool WHBI_ID_IsChanged
      {
         get{ return wHBI_ID_IsChanged; }
         set{ wHBI_ID_IsChanged = value; }
      }
      private string wHBI_Code;
      private bool wHBI_Code_IsChanged=false;
      public string WHBI_Code
      {
         get{ return wHBI_Code; }
         set{ wHBI_Code = value; wHBI_Code_IsChanged=true; }
      }
      public bool WHBI_Code_IsChanged
      {
         get{ return wHBI_Code_IsChanged; }
         set{ wHBI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 盘点主表编码
      /// </summary>
      private string wHBI_BCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_BCode_IsChanged=false;
      /// <summary>
      /// 盘点主表编码
      /// </summary>
      public string WHBI_BCode
      {
         get{ return wHBI_BCode; }
         set{ wHBI_BCode = value; wHBI_BCode_IsChanged=true; }
      }
      /// <summary>
      /// 盘点主表编码
      /// </summary>
      public bool WHBI_BCode_IsChanged
      {
         get{ return wHBI_BCode_IsChanged; }
         set{ wHBI_BCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓库
      /// </summary>
      private string wHBI_WCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_WCode_IsChanged=false;
      /// <summary>
      /// 仓库
      /// </summary>
      public string WHBI_WCode
      {
         get{ return wHBI_WCode; }
         set{ wHBI_WCode = value; wHBI_WCode_IsChanged=true; }
      }
      /// <summary>
      /// 仓库
      /// </summary>
      public bool WHBI_WCode_IsChanged
      {
         get{ return wHBI_WCode_IsChanged; }
         set{ wHBI_WCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      private string wHBI_WName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_WName_IsChanged=false;
      /// <summary>
      /// 仓库名称
      /// </summary>
      public string WHBI_WName
      {
         get{ return wHBI_WName; }
         set{ wHBI_WName = value; wHBI_WName_IsChanged=true; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      public bool WHBI_WName_IsChanged
      {
         get{ return wHBI_WName_IsChanged; }
         set{ wHBI_WName_IsChanged = value; }
      }
      /// <summary>
      /// 货位
      /// </summary>
      private string wHBI_WNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_WNo_IsChanged=false;
      /// <summary>
      /// 货位
      /// </summary>
      public string WHBI_WNo
      {
         get{ return wHBI_WNo; }
         set{ wHBI_WNo = value; wHBI_WNo_IsChanged=true; }
      }
      /// <summary>
      /// 货位
      /// </summary>
      public bool WHBI_WNo_IsChanged
      {
         get{ return wHBI_WNo_IsChanged; }
         set{ wHBI_WNo_IsChanged = value; }
      }
      /// <summary>
      /// 货位名称
      /// </summary>
      private string wHBI_WNoName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_WNoName_IsChanged=false;
      /// <summary>
      /// 货位名称
      /// </summary>
      public string WHBI_WNoName
      {
         get{ return wHBI_WNoName; }
         set{ wHBI_WNoName = value; wHBI_WNoName_IsChanged=true; }
      }
      /// <summary>
      /// 货位名称
      /// </summary>
      public bool WHBI_WNoName_IsChanged
      {
         get{ return wHBI_WNoName_IsChanged; }
         set{ wHBI_WNoName_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string wHBI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string WHBI_MCode
      {
         get{ return wHBI_MCode; }
         set{ wHBI_MCode = value; wHBI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool WHBI_MCode_IsChanged
      {
         get{ return wHBI_MCode_IsChanged; }
         set{ wHBI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string wHBI_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string WHBI_MName
      {
         get{ return wHBI_MName; }
         set{ wHBI_MName = value; wHBI_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool WHBI_MName_IsChanged
      {
         get{ return wHBI_MName_IsChanged; }
         set{ wHBI_MName_IsChanged = value; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      private string wHBI_MSpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_MSpec_IsChanged=false;
      /// <summary>
      /// 规格型号
      /// </summary>
      public string WHBI_MSpec
      {
         get{ return wHBI_MSpec; }
         set{ wHBI_MSpec = value; wHBI_MSpec_IsChanged=true; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      public bool WHBI_MSpec_IsChanged
      {
         get{ return wHBI_MSpec_IsChanged; }
         set{ wHBI_MSpec_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string wHBI_MUnit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_MUnit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string WHBI_MUnit
      {
         get{ return wHBI_MUnit; }
         set{ wHBI_MUnit = value; wHBI_MUnit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool WHBI_MUnit_IsChanged
      {
         get{ return wHBI_MUnit_IsChanged; }
         set{ wHBI_MUnit_IsChanged = value; }
      }
      /// <summary>
      /// 实际数量
      /// </summary>
      private decimal wHBI_RNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_RNum_IsChanged=false;
      /// <summary>
      /// 实际数量
      /// </summary>
      public decimal WHBI_RNum
      {
         get{ return wHBI_RNum; }
         set{ wHBI_RNum = value; wHBI_RNum_IsChanged=true; }
      }
      /// <summary>
      /// 实际数量
      /// </summary>
      public bool WHBI_RNum_IsChanged
      {
         get{ return wHBI_RNum_IsChanged; }
         set{ wHBI_RNum_IsChanged = value; }
      }
      /// <summary>
      /// 盘点数量
      /// </summary>
      private decimal wHBI_BNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_BNum_IsChanged=false;
      /// <summary>
      /// 盘点数量
      /// </summary>
      public decimal WHBI_BNum
      {
         get{ return wHBI_BNum; }
         set{ wHBI_BNum = value; wHBI_BNum_IsChanged=true; }
      }
      /// <summary>
      /// 盘点数量
      /// </summary>
      public bool WHBI_BNum_IsChanged
      {
         get{ return wHBI_BNum_IsChanged; }
         set{ wHBI_BNum_IsChanged = value; }
      }
      /// <summary>
      /// 盘盈
      /// </summary>
      private decimal wHBI_MNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_MNum_IsChanged=false;
      /// <summary>
      /// 盘盈
      /// </summary>
      public decimal WHBI_MNum
      {
         get{ return wHBI_MNum; }
         set{ wHBI_MNum = value; wHBI_MNum_IsChanged=true; }
      }
      /// <summary>
      /// 盘盈
      /// </summary>
      public bool WHBI_MNum_IsChanged
      {
         get{ return wHBI_MNum_IsChanged; }
         set{ wHBI_MNum_IsChanged = value; }
      }
      /// <summary>
      /// 盘亏
      /// </summary>
      private decimal wHBI_LNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_LNum_IsChanged=false;
      /// <summary>
      /// 盘亏
      /// </summary>
      public decimal WHBI_LNum
      {
         get{ return wHBI_LNum; }
         set{ wHBI_LNum = value; wHBI_LNum_IsChanged=true; }
      }
      /// <summary>
      /// 盘亏
      /// </summary>
      public bool WHBI_LNum_IsChanged
      {
         get{ return wHBI_LNum_IsChanged; }
         set{ wHBI_LNum_IsChanged = value; }
      }
      /// <summary>
      /// 盘点方式
      /// </summary>
      private string wHBI_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_Type_IsChanged=false;
      /// <summary>
      /// 盘点方式
      /// </summary>
      public string WHBI_Type
      {
         get{ return wHBI_Type; }
         set{ wHBI_Type = value; wHBI_Type_IsChanged=true; }
      }
      /// <summary>
      /// 盘点方式
      /// </summary>
      public bool WHBI_Type_IsChanged
      {
         get{ return wHBI_Type_IsChanged; }
         set{ wHBI_Type_IsChanged = value; }
      }
      /// <summary>
      /// 盘点结果类型
      /// </summary>
      private string wHBI_RType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_RType_IsChanged=false;
      /// <summary>
      /// 盘点结果类型
      /// </summary>
      public string WHBI_RType
      {
         get{ return wHBI_RType; }
         set{ wHBI_RType = value; wHBI_RType_IsChanged=true; }
      }
      /// <summary>
      /// 盘点结果类型
      /// </summary>
      public bool WHBI_RType_IsChanged
      {
         get{ return wHBI_RType_IsChanged; }
         set{ wHBI_RType_IsChanged = value; }
      }
      /// <summary>
      /// 盘点时间
      /// </summary>
      private DateTime wHBI_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_Date_IsChanged=false;
      /// <summary>
      /// 盘点时间
      /// </summary>
      public DateTime WHBI_Date
      {
         get{ return wHBI_Date; }
         set{ wHBI_Date = value; wHBI_Date_IsChanged=true; }
      }
      /// <summary>
      /// 盘点时间
      /// </summary>
      public bool WHBI_Date_IsChanged
      {
         get{ return wHBI_Date_IsChanged; }
         set{ wHBI_Date_IsChanged = value; }
      }
      /// <summary>
      /// 盘点人
      /// </summary>
      private string wHBI_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_Owner_IsChanged=false;
      /// <summary>
      /// 盘点人
      /// </summary>
      public string WHBI_Owner
      {
         get{ return wHBI_Owner; }
         set{ wHBI_Owner = value; wHBI_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 盘点人
      /// </summary>
      public bool WHBI_Owner_IsChanged
      {
         get{ return wHBI_Owner_IsChanged; }
         set{ wHBI_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string wHBI_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBI_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string WHBI_Bak
      {
         get{ return wHBI_Bak; }
         set{ wHBI_Bak = value; wHBI_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool WHBI_Bak_IsChanged
      {
         get{ return wHBI_Bak_IsChanged; }
         set{ wHBI_Bak_IsChanged = value; }
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
