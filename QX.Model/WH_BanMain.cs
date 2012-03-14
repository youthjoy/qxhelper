using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 盘点管理
   /// </summary>
   [Serializable]
   public partial class WH_BanMain
   {
      /// <summary>
      /// 盘点计划序号
      /// </summary>
      private decimal wHBM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_ID_IsChanged=false;
      /// <summary>
      /// 盘点计划序号
      /// </summary>
      public decimal WHBM_ID
      {
         get{ return wHBM_ID; }
         set{ wHBM_ID = value; wHBM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 盘点计划序号
      /// </summary>
      public bool WHBM_ID_IsChanged
      {
         get{ return wHBM_ID_IsChanged; }
         set{ wHBM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 盘点计划编码
      /// </summary>
      private string wHBM_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_Code_IsChanged=false;
      /// <summary>
      /// 盘点计划编码
      /// </summary>
      public string WHBM_Code
      {
         get{ return wHBM_Code; }
         set{ wHBM_Code = value; wHBM_Code_IsChanged=true; }
      }
      /// <summary>
      /// 盘点计划编码
      /// </summary>
      public bool WHBM_Code_IsChanged
      {
         get{ return wHBM_Code_IsChanged; }
         set{ wHBM_Code_IsChanged = value; }
      }
      /// <summary>
      /// 盘点计划名称
      /// </summary>
      private string wHBM_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_Name_IsChanged=false;
      /// <summary>
      /// 盘点计划名称
      /// </summary>
      public string WHBM_Name
      {
         get{ return wHBM_Name; }
         set{ wHBM_Name = value; wHBM_Name_IsChanged=true; }
      }
      /// <summary>
      /// 盘点计划名称
      /// </summary>
      public bool WHBM_Name_IsChanged
      {
         get{ return wHBM_Name_IsChanged; }
         set{ wHBM_Name_IsChanged = value; }
      }
      /// <summary>
      /// 盘点仓库编码
      /// </summary>
      private string wHBM_WCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_WCode_IsChanged=false;
      /// <summary>
      /// 盘点仓库编码
      /// </summary>
      public string WHBM_WCode
      {
         get{ return wHBM_WCode; }
         set{ wHBM_WCode = value; wHBM_WCode_IsChanged=true; }
      }
      /// <summary>
      /// 盘点仓库编码
      /// </summary>
      public bool WHBM_WCode_IsChanged
      {
         get{ return wHBM_WCode_IsChanged; }
         set{ wHBM_WCode_IsChanged = value; }
      }
      /// <summary>
      /// 盘点仓库名称
      /// </summary>
      private string wHBM_WName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_WName_IsChanged=false;
      /// <summary>
      /// 盘点仓库名称
      /// </summary>
      public string WHBM_WName
      {
         get{ return wHBM_WName; }
         set{ wHBM_WName = value; wHBM_WName_IsChanged=true; }
      }
      /// <summary>
      /// 盘点仓库名称
      /// </summary>
      public bool WHBM_WName_IsChanged
      {
         get{ return wHBM_WName_IsChanged; }
         set{ wHBM_WName_IsChanged = value; }
      }
      /// <summary>
      /// 仓库公司
      /// </summary>
      private string wHBM_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_Company_IsChanged=false;
      /// <summary>
      /// 仓库公司
      /// </summary>
      public string WHBM_Company
      {
         get{ return wHBM_Company; }
         set{ wHBM_Company = value; wHBM_Company_IsChanged=true; }
      }
      /// <summary>
      /// 仓库公司
      /// </summary>
      public bool WHBM_Company_IsChanged
      {
         get{ return wHBM_Company_IsChanged; }
         set{ wHBM_Company_IsChanged = value; }
      }
      /// <summary>
      /// 公司编码
      /// </summary>
      private string wHBM_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_CompanyCode_IsChanged=false;
      /// <summary>
      /// 公司编码
      /// </summary>
      public string WHBM_CompanyCode
      {
         get{ return wHBM_CompanyCode; }
         set{ wHBM_CompanyCode = value; wHBM_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 公司编码
      /// </summary>
      public bool WHBM_CompanyCode_IsChanged
      {
         get{ return wHBM_CompanyCode_IsChanged; }
         set{ wHBM_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 计划盘点时间
      /// </summary>
      private DateTime wHBM_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_PDate_IsChanged=false;
      /// <summary>
      /// 计划盘点时间
      /// </summary>
      public DateTime WHBM_PDate
      {
         get{ return wHBM_PDate; }
         set{ wHBM_PDate = value; wHBM_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 计划盘点时间
      /// </summary>
      public bool WHBM_PDate_IsChanged
      {
         get{ return wHBM_PDate_IsChanged; }
         set{ wHBM_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 实际盘点时间
      /// </summary>
      private DateTime wHBM_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_RDate_IsChanged=false;
      /// <summary>
      /// 实际盘点时间
      /// </summary>
      public DateTime WHBM_RDate
      {
         get{ return wHBM_RDate; }
         set{ wHBM_RDate = value; wHBM_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 实际盘点时间
      /// </summary>
      public bool WHBM_RDate_IsChanged
      {
         get{ return wHBM_RDate_IsChanged; }
         set{ wHBM_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 盘点库管
      /// </summary>
      private string wHBM_WOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_WOwner_IsChanged=false;
      /// <summary>
      /// 盘点库管
      /// </summary>
      public string WHBM_WOwner
      {
         get{ return wHBM_WOwner; }
         set{ wHBM_WOwner = value; wHBM_WOwner_IsChanged=true; }
      }
      /// <summary>
      /// 盘点库管
      /// </summary>
      public bool WHBM_WOwner_IsChanged
      {
         get{ return wHBM_WOwner_IsChanged; }
         set{ wHBM_WOwner_IsChanged = value; }
      }
      /// <summary>
      /// 财务参与人
      /// </summary>
      private string wHBM_FOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_FOwner_IsChanged=false;
      /// <summary>
      /// 财务参与人
      /// </summary>
      public string WHBM_FOwner
      {
         get{ return wHBM_FOwner; }
         set{ wHBM_FOwner = value; wHBM_FOwner_IsChanged=true; }
      }
      /// <summary>
      /// 财务参与人
      /// </summary>
      public bool WHBM_FOwner_IsChanged
      {
         get{ return wHBM_FOwner_IsChanged; }
         set{ wHBM_FOwner_IsChanged = value; }
      }
      /// <summary>
      /// 其他参与人
      /// </summary>
      private string wHBM_OOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_OOwner_IsChanged=false;
      /// <summary>
      /// 其他参与人
      /// </summary>
      public string WHBM_OOwner
      {
         get{ return wHBM_OOwner; }
         set{ wHBM_OOwner = value; wHBM_OOwner_IsChanged=true; }
      }
      /// <summary>
      /// 其他参与人
      /// </summary>
      public bool WHBM_OOwner_IsChanged
      {
         get{ return wHBM_OOwner_IsChanged; }
         set{ wHBM_OOwner_IsChanged = value; }
      }
      /// <summary>
      /// 盘点方式
      /// </summary>
      private string wHBM_BType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_BType_IsChanged=false;
      /// <summary>
      /// 盘点方式
      /// </summary>
      public string WHBM_BType
      {
         get{ return wHBM_BType; }
         set{ wHBM_BType = value; wHBM_BType_IsChanged=true; }
      }
      /// <summary>
      /// 盘点方式
      /// </summary>
      public bool WHBM_BType_IsChanged
      {
         get{ return wHBM_BType_IsChanged; }
         set{ wHBM_BType_IsChanged = value; }
      }
      /// <summary>
      /// 盘点表打印次数
      /// </summary>
      private int wHBM_iBanCopy;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_iBanCopy_IsChanged=false;
      /// <summary>
      /// 盘点表打印次数
      /// </summary>
      public int WHBM_iBanCopy
      {
         get{ return wHBM_iBanCopy; }
         set{ wHBM_iBanCopy = value; wHBM_iBanCopy_IsChanged=true; }
      }
      /// <summary>
      /// 盘点表打印次数
      /// </summary>
      public bool WHBM_iBanCopy_IsChanged
      {
         get{ return wHBM_iBanCopy_IsChanged; }
         set{ wHBM_iBanCopy_IsChanged = value; }
      }
      /// <summary>
      /// 是否已录入盘点数据
      /// </summary>
      private string wHBM_IsInput;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_IsInput_IsChanged=false;
      /// <summary>
      /// 是否已录入盘点数据
      /// </summary>
      public string WHBM_IsInput
      {
         get{ return wHBM_IsInput; }
         set{ wHBM_IsInput = value; wHBM_IsInput_IsChanged=true; }
      }
      /// <summary>
      /// 是否已录入盘点数据
      /// </summary>
      public bool WHBM_IsInput_IsChanged
      {
         get{ return wHBM_IsInput_IsChanged; }
         set{ wHBM_IsInput_IsChanged = value; }
      }
      /// <summary>
      /// 是否计算盈亏
      /// </summary>
      private string wHBM_IsBanced;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_IsBanced_IsChanged=false;
      /// <summary>
      /// 是否计算盈亏
      /// </summary>
      public string WHBM_IsBanced
      {
         get{ return wHBM_IsBanced; }
         set{ wHBM_IsBanced = value; wHBM_IsBanced_IsChanged=true; }
      }
      /// <summary>
      /// 是否计算盈亏
      /// </summary>
      public bool WHBM_IsBanced_IsChanged
      {
         get{ return wHBM_IsBanced_IsChanged; }
         set{ wHBM_IsBanced_IsChanged = value; }
      }
      /// <summary>
      /// 是否处理完毕
      /// </summary>
      private string wHBM_IsDonw;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_IsDonw_IsChanged=false;
      /// <summary>
      /// 是否处理完毕
      /// </summary>
      public string WHBM_IsDonw
      {
         get{ return wHBM_IsDonw; }
         set{ wHBM_IsDonw = value; wHBM_IsDonw_IsChanged=true; }
      }
      /// <summary>
      /// 是否处理完毕
      /// </summary>
      public bool WHBM_IsDonw_IsChanged
      {
         get{ return wHBM_IsDonw_IsChanged; }
         set{ wHBM_IsDonw_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string wHBM_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHBM_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string WHBM_Remark
      {
         get{ return wHBM_Remark; }
         set{ wHBM_Remark = value; wHBM_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool WHBM_Remark_IsChanged
      {
         get{ return wHBM_Remark_IsChanged; }
         set{ wHBM_Remark_IsChanged = value; }
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
