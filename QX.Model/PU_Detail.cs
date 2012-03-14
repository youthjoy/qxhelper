using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 供应商往来细表
   /// </summary>
   [Serializable]
   public partial class PU_Detail
   {
      /// <summary>
      /// 采购细表ID
      /// </summary>
      private decimal pUD_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_ID_IsChanged=false;
      /// <summary>
      /// 采购细表ID
      /// </summary>
      public decimal PUD_ID
      {
         get{ return pUD_ID; }
         set{ pUD_ID = value; pUD_ID_IsChanged=true; }
      }
      /// <summary>
      /// 采购细表ID
      /// </summary>
      public bool PUD_ID_IsChanged
      {
         get{ return pUD_ID_IsChanged; }
         set{ pUD_ID_IsChanged = value; }
      }
      /// <summary>
      /// 采购细表编码
      /// </summary>
      private string pUD_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Code_IsChanged=false;
      /// <summary>
      /// 采购细表编码
      /// </summary>
      public string PUD_Code
      {
         get{ return pUD_Code; }
         set{ pUD_Code = value; pUD_Code_IsChanged=true; }
      }
      /// <summary>
      /// 采购细表编码
      /// </summary>
      public bool PUD_Code_IsChanged
      {
         get{ return pUD_Code_IsChanged; }
         set{ pUD_Code_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string pUD_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string PUD_MCode
      {
         get{ return pUD_MCode; }
         set{ pUD_MCode = value; pUD_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool PUD_MCode_IsChanged
      {
         get{ return pUD_MCode_IsChanged; }
         set{ pUD_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string pUD_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string PUD_MName
      {
         get{ return pUD_MName; }
         set{ pUD_MName = value; pUD_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool PUD_MName_IsChanged
      {
         get{ return pUD_MName_IsChanged; }
         set{ pUD_MName_IsChanged = value; }
      }
      /// <summary>
      /// 物料规格
      /// </summary>
      private string pUD_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Spec_IsChanged=false;
      /// <summary>
      /// 物料规格
      /// </summary>
      public string PUD_Spec
      {
         get{ return pUD_Spec; }
         set{ pUD_Spec = value; pUD_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 物料规格
      /// </summary>
      public bool PUD_Spec_IsChanged
      {
         get{ return pUD_Spec_IsChanged; }
         set{ pUD_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string pUD_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string PUD_Unit
      {
         get{ return pUD_Unit; }
         set{ pUD_Unit = value; pUD_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool PUD_Unit_IsChanged
      {
         get{ return pUD_Unit_IsChanged; }
         set{ pUD_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal pUD_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Price_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal PUD_Price
      {
         get{ return pUD_Price; }
         set{ pUD_Price = value; pUD_Price_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool PUD_Price_IsChanged
      {
         get{ return pUD_Price_IsChanged; }
         set{ pUD_Price_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private decimal pUD_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public decimal PUD_Num
      {
         get{ return pUD_Num; }
         set{ pUD_Num = value; pUD_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool PUD_Num_IsChanged
      {
         get{ return pUD_Num_IsChanged; }
         set{ pUD_Num_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pUD_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PUD_Bak
      {
         get{ return pUD_Bak; }
         set{ pUD_Bak = value; pUD_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PUD_Bak_IsChanged
      {
         get{ return pUD_Bak_IsChanged; }
         set{ pUD_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      private string pUD_RType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_RType_IsChanged=false;
      /// <summary>
      /// 单据类型
      /// </summary>
      public string PUD_RType
      {
         get{ return pUD_RType; }
         set{ pUD_RType = value; pUD_RType_IsChanged=true; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      public bool PUD_RType_IsChanged
      {
         get{ return pUD_RType_IsChanged; }
         set{ pUD_RType_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string pUD_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_RCode_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string PUD_RCode
      {
         get{ return pUD_RCode; }
         set{ pUD_RCode = value; pUD_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool PUD_RCode_IsChanged
      {
         get{ return pUD_RCode_IsChanged; }
         set{ pUD_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 库存仓库
      /// </summary>
      private string pUD_RefWCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_RefWCode_IsChanged=false;
      /// <summary>
      /// 库存仓库
      /// </summary>
      public string PUD_RefWCode
      {
         get{ return pUD_RefWCode; }
         set{ pUD_RefWCode = value; pUD_RefWCode_IsChanged=true; }
      }
      /// <summary>
      /// 库存仓库
      /// </summary>
      public bool PUD_RefWCode_IsChanged
      {
         get{ return pUD_RefWCode_IsChanged; }
         set{ pUD_RefWCode_IsChanged = value; }
      }
      /// <summary>
      /// 库存仓号
      /// </summary>
      private string pUD_RefWNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_RefWNo_IsChanged=false;
      /// <summary>
      /// 库存仓号
      /// </summary>
      public string PUD_RefWNo
      {
         get{ return pUD_RefWNo; }
         set{ pUD_RefWNo = value; pUD_RefWNo_IsChanged=true; }
      }
      /// <summary>
      /// 库存仓号
      /// </summary>
      public bool PUD_RefWNo_IsChanged
      {
         get{ return pUD_RefWNo_IsChanged; }
         set{ pUD_RefWNo_IsChanged = value; }
      }
      /// <summary>
      /// 库存仓库名称
      /// </summary>
      private string pUD_RefWName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_RefWName_IsChanged=false;
      /// <summary>
      /// 库存仓库名称
      /// </summary>
      public string PUD_RefWName
      {
         get{ return pUD_RefWName; }
         set{ pUD_RefWName = value; pUD_RefWName_IsChanged=true; }
      }
      /// <summary>
      /// 库存仓库名称
      /// </summary>
      public bool PUD_RefWName_IsChanged
      {
         get{ return pUD_RefWName_IsChanged; }
         set{ pUD_RefWName_IsChanged = value; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      private decimal pUD_Tranfee;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pUD_Tranfee_IsChanged=false;
      /// <summary>
      /// 运费
      /// </summary>
      public decimal PUD_Tranfee
      {
         get{ return pUD_Tranfee; }
         set{ pUD_Tranfee = value; pUD_Tranfee_IsChanged=true; }
      }
      /// <summary>
      /// 运费
      /// </summary>
      public bool PUD_Tranfee_IsChanged
      {
         get{ return pUD_Tranfee_IsChanged; }
         set{ pUD_Tranfee_IsChanged = value; }
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
      private decimal pUD_DNum;
      private bool pUD_DNum_IsChanged=false;
      public decimal PUD_DNum
      {
         get{ return pUD_DNum; }
         set{ pUD_DNum = value; pUD_DNum_IsChanged=true; }
      }
      public bool PUD_DNum_IsChanged
      {
         get{ return pUD_DNum_IsChanged; }
         set{ pUD_DNum_IsChanged = value; }
      }
      private string pUD_DStatus;
      private bool pUD_DStatus_IsChanged=false;
      public string PUD_DStatus
      {
         get{ return pUD_DStatus; }
         set{ pUD_DStatus = value; pUD_DStatus_IsChanged=true; }
      }
      public bool PUD_DStatus_IsChanged
      {
         get{ return pUD_DStatus_IsChanged; }
         set{ pUD_DStatus_IsChanged = value; }
      }
      private string pUD_RefWNoName;
      private bool pUD_RefWNoName_IsChanged=false;
      public string PUD_RefWNoName
      {
         get{ return pUD_RefWNoName; }
         set{ pUD_RefWNoName = value; pUD_RefWNoName_IsChanged=true; }
      }
      public bool PUD_RefWNoName_IsChanged
      {
         get{ return pUD_RefWNoName_IsChanged; }
         set{ pUD_RefWNoName_IsChanged = value; }
      }
      private string pUD_Udef1;
      private bool pUD_Udef1_IsChanged=false;
      public string PUD_Udef1
      {
         get{ return pUD_Udef1; }
         set{ pUD_Udef1 = value; pUD_Udef1_IsChanged=true; }
      }
      public bool PUD_Udef1_IsChanged
      {
         get{ return pUD_Udef1_IsChanged; }
         set{ pUD_Udef1_IsChanged = value; }
      }
      private string pUD_Udef2;
      private bool pUD_Udef2_IsChanged=false;
      public string PUD_Udef2
      {
         get{ return pUD_Udef2; }
         set{ pUD_Udef2 = value; pUD_Udef2_IsChanged=true; }
      }
      public bool PUD_Udef2_IsChanged
      {
         get{ return pUD_Udef2_IsChanged; }
         set{ pUD_Udef2_IsChanged = value; }
      }
      private string pUD_Udef3;
      private bool pUD_Udef3_IsChanged=false;
      public string PUD_Udef3
      {
         get{ return pUD_Udef3; }
         set{ pUD_Udef3 = value; pUD_Udef3_IsChanged=true; }
      }
      public bool PUD_Udef3_IsChanged
      {
         get{ return pUD_Udef3_IsChanged; }
         set{ pUD_Udef3_IsChanged = value; }
      }
      private string pUD_Udef4;
      private bool pUD_Udef4_IsChanged=false;
      public string PUD_Udef4
      {
         get{ return pUD_Udef4; }
         set{ pUD_Udef4 = value; pUD_Udef4_IsChanged=true; }
      }
      public bool PUD_Udef4_IsChanged
      {
         get{ return pUD_Udef4_IsChanged; }
         set{ pUD_Udef4_IsChanged = value; }
      }
      private string pUD_Udef5;
      private bool pUD_Udef5_IsChanged=false;
      public string PUD_Udef5
      {
         get{ return pUD_Udef5; }
         set{ pUD_Udef5 = value; pUD_Udef5_IsChanged=true; }
      }
      public bool PUD_Udef5_IsChanged
      {
         get{ return pUD_Udef5_IsChanged; }
         set{ pUD_Udef5_IsChanged = value; }
      }
      private string pUD_Udef6;
      private bool pUD_Udef6_IsChanged=false;
      public string PUD_Udef6
      {
         get{ return pUD_Udef6; }
         set{ pUD_Udef6 = value; pUD_Udef6_IsChanged=true; }
      }
      public bool PUD_Udef6_IsChanged
      {
         get{ return pUD_Udef6_IsChanged; }
         set{ pUD_Udef6_IsChanged = value; }
      }
      private string pUD_Udef7;
      private bool pUD_Udef7_IsChanged=false;
      public string PUD_Udef7
      {
         get{ return pUD_Udef7; }
         set{ pUD_Udef7 = value; pUD_Udef7_IsChanged=true; }
      }
      public bool PUD_Udef7_IsChanged
      {
         get{ return pUD_Udef7_IsChanged; }
         set{ pUD_Udef7_IsChanged = value; }
      }
      private string pUD_Udef8;
      private bool pUD_Udef8_IsChanged=false;
      public string PUD_Udef8
      {
         get{ return pUD_Udef8; }
         set{ pUD_Udef8 = value; pUD_Udef8_IsChanged=true; }
      }
      public bool PUD_Udef8_IsChanged
      {
         get{ return pUD_Udef8_IsChanged; }
         set{ pUD_Udef8_IsChanged = value; }
      }
      private string pUD_Udef9;
      private bool pUD_Udef9_IsChanged=false;
      public string PUD_Udef9
      {
         get{ return pUD_Udef9; }
         set{ pUD_Udef9 = value; pUD_Udef9_IsChanged=true; }
      }
      public bool PUD_Udef9_IsChanged
      {
         get{ return pUD_Udef9_IsChanged; }
         set{ pUD_Udef9_IsChanged = value; }
      }
      private string pUD_Udef10;
      private bool pUD_Udef10_IsChanged=false;
      public string PUD_Udef10
      {
         get{ return pUD_Udef10; }
         set{ pUD_Udef10 = value; pUD_Udef10_IsChanged=true; }
      }
      public bool PUD_Udef10_IsChanged
      {
         get{ return pUD_Udef10_IsChanged; }
         set{ pUD_Udef10_IsChanged = value; }
      }
      private string pUD_CCompany;
      private bool pUD_CCompany_IsChanged=false;
      public string PUD_CCompany
      {
         get{ return pUD_CCompany; }
         set{ pUD_CCompany = value; pUD_CCompany_IsChanged=true; }
      }
      public bool PUD_CCompany_IsChanged
      {
         get{ return pUD_CCompany_IsChanged; }
         set{ pUD_CCompany_IsChanged = value; }
      }
      private string pUD_CCompanyCode;
      private bool pUD_CCompanyCode_IsChanged=false;
      public string PUD_CCompanyCode
      {
         get{ return pUD_CCompanyCode; }
         set{ pUD_CCompanyCode = value; pUD_CCompanyCode_IsChanged=true; }
      }
      public bool PUD_CCompanyCode_IsChanged
      {
         get{ return pUD_CCompanyCode_IsChanged; }
         set{ pUD_CCompanyCode_IsChanged = value; }
      }
      private string pUD_Dept;
      private bool pUD_Dept_IsChanged=false;
      public string PUD_Dept
      {
         get{ return pUD_Dept; }
         set{ pUD_Dept = value; pUD_Dept_IsChanged=true; }
      }
      public bool PUD_Dept_IsChanged
      {
         get{ return pUD_Dept_IsChanged; }
         set{ pUD_Dept_IsChanged = value; }
      }
      private string pUD_DeptCode;
      private bool pUD_DeptCode_IsChanged=false;
      public string PUD_DeptCode
      {
         get{ return pUD_DeptCode; }
         set{ pUD_DeptCode = value; pUD_DeptCode_IsChanged=true; }
      }
      public bool PUD_DeptCode_IsChanged
      {
         get{ return pUD_DeptCode_IsChanged; }
         set{ pUD_DeptCode_IsChanged = value; }
      }
      private DateTime pUD_RDate;
      private bool pUD_RDate_IsChanged=false;
      public DateTime PUD_RDate
      {
         get{ return pUD_RDate; }
         set{ pUD_RDate = value; pUD_RDate_IsChanged=true; }
      }
      public bool PUD_RDate_IsChanged
      {
         get{ return pUD_RDate_IsChanged; }
         set{ pUD_RDate_IsChanged = value; }
      }
      private string pUD_SupCode;
      private bool pUD_SupCode_IsChanged=false;
      public string PUD_SupCode
      {
         get{ return pUD_SupCode; }
         set{ pUD_SupCode = value; pUD_SupCode_IsChanged=true; }
      }
      public bool PUD_SupCode_IsChanged
      {
         get{ return pUD_SupCode_IsChanged; }
         set{ pUD_SupCode_IsChanged = value; }
      }
      private string pUD_SupName;
      private bool pUD_SupName_IsChanged=false;
      public string PUD_SupName
      {
         get{ return pUD_SupName; }
         set{ pUD_SupName = value; pUD_SupName_IsChanged=true; }
      }
      public bool PUD_SupName_IsChanged
      {
         get{ return pUD_SupName_IsChanged; }
         set{ pUD_SupName_IsChanged = value; }
      }
      private decimal pUD_Num1;
      private bool pUD_Num1_IsChanged=false;
      public decimal PUD_Num1
      {
         get{ return pUD_Num1; }
         set{ pUD_Num1 = value; pUD_Num1_IsChanged=true; }
      }
      public bool PUD_Num1_IsChanged
      {
         get{ return pUD_Num1_IsChanged; }
         set{ pUD_Num1_IsChanged = value; }
      }
      private decimal pUD_Num2;
      private bool pUD_Num2_IsChanged=false;
      public decimal PUD_Num2
      {
         get{ return pUD_Num2; }
         set{ pUD_Num2 = value; pUD_Num2_IsChanged=true; }
      }
      public bool PUD_Num2_IsChanged
      {
         get{ return pUD_Num2_IsChanged; }
         set{ pUD_Num2_IsChanged = value; }
      }
      private decimal pUD_Num3;
      private bool pUD_Num3_IsChanged=false;
      public decimal PUD_Num3
      {
         get{ return pUD_Num3; }
         set{ pUD_Num3 = value; pUD_Num3_IsChanged=true; }
      }
      public bool PUD_Num3_IsChanged
      {
         get{ return pUD_Num3_IsChanged; }
         set{ pUD_Num3_IsChanged = value; }
      }
      private decimal pUD_Num4;
      private bool pUD_Num4_IsChanged=false;
      public decimal PUD_Num4
      {
         get{ return pUD_Num4; }
         set{ pUD_Num4 = value; pUD_Num4_IsChanged=true; }
      }
      public bool PUD_Num4_IsChanged
      {
         get{ return pUD_Num4_IsChanged; }
         set{ pUD_Num4_IsChanged = value; }
      }
      private decimal pUD_Num5;
      private bool pUD_Num5_IsChanged=false;
      public decimal PUD_Num5
      {
         get{ return pUD_Num5; }
         set{ pUD_Num5 = value; pUD_Num5_IsChanged=true; }
      }
      public bool PUD_Num5_IsChanged
      {
         get{ return pUD_Num5_IsChanged; }
         set{ pUD_Num5_IsChanged = value; }
      }
      private decimal pUD_RevNum;
      private bool pUD_RevNum_IsChanged=false;
      public decimal PUD_RevNum
      {
         get{ return pUD_RevNum; }
         set{ pUD_RevNum = value; pUD_RevNum_IsChanged=true; }
      }
      public bool PUD_RevNum_IsChanged
      {
         get{ return pUD_RevNum_IsChanged; }
         set{ pUD_RevNum_IsChanged = value; }
      }
      private string pUD_UEqu;
      private bool pUD_UEqu_IsChanged=false;
      public string PUD_UEqu
      {
         get{ return pUD_UEqu; }
         set{ pUD_UEqu = value; pUD_UEqu_IsChanged=true; }
      }
      public bool PUD_UEqu_IsChanged
      {
         get{ return pUD_UEqu_IsChanged; }
         set{ pUD_UEqu_IsChanged = value; }
      }
      private string pUD_UsetType;
      private bool pUD_UsetType_IsChanged=false;
      public string PUD_UsetType
      {
         get{ return pUD_UsetType; }
         set{ pUD_UsetType = value; pUD_UsetType_IsChanged=true; }
      }
      public bool PUD_UsetType_IsChanged
      {
         get{ return pUD_UsetType_IsChanged; }
         set{ pUD_UsetType_IsChanged = value; }
      }
      private int pUD_RevCount;
      private bool pUD_RevCount_IsChanged=false;
      public int PUD_RevCount
      {
         get{ return pUD_RevCount; }
         set{ pUD_RevCount = value; pUD_RevCount_IsChanged=true; }
      }
      public bool PUD_RevCount_IsChanged
      {
         get{ return pUD_RevCount_IsChanged; }
         set{ pUD_RevCount_IsChanged = value; }
      }
   }
}
