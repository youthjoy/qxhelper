using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料出库细表
   /// </summary>
   [Serializable]
   public partial class WH_IOItem
   {
      /// <summary>
      /// 物料出库细表ID
      /// </summary>
      private decimal wHIOI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_ID_IsChanged=false;
      /// <summary>
      /// 物料出库细表ID
      /// </summary>
      public decimal WHIOI_ID
      {
         get{ return wHIOI_ID; }
         set{ wHIOI_ID = value; wHIOI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 物料出库细表ID
      /// </summary>
      public bool WHIOI_ID_IsChanged
      {
         get{ return wHIOI_ID_IsChanged; }
         set{ wHIOI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 物料出库细表编码
      /// </summary>
      private string wHIOI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_Code_IsChanged=false;
      /// <summary>
      /// 物料出库细表编码
      /// </summary>
      public string WHIOI_Code
      {
         get{ return wHIOI_Code; }
         set{ wHIOI_Code = value; wHIOI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 物料出库细表编码
      /// </summary>
      public bool WHIOI_Code_IsChanged
      {
         get{ return wHIOI_Code_IsChanged; }
         set{ wHIOI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 物料出库单据编码
      /// </summary>
      private string wHIOI_MainCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MainCode_IsChanged=false;
      /// <summary>
      /// 物料出库单据编码
      /// </summary>
      public string WHIOI_MainCode
      {
         get{ return wHIOI_MainCode; }
         set{ wHIOI_MainCode = value; wHIOI_MainCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料出库单据编码
      /// </summary>
      public bool WHIOI_MainCode_IsChanged
      {
         get{ return wHIOI_MainCode_IsChanged; }
         set{ wHIOI_MainCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string wHIOI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string WHIOI_MCode
      {
         get{ return wHIOI_MCode; }
         set{ wHIOI_MCode = value; wHIOI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool WHIOI_MCode_IsChanged
      {
         get{ return wHIOI_MCode_IsChanged; }
         set{ wHIOI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string wHIOI_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string WHIOI_MName
      {
         get{ return wHIOI_MName; }
         set{ wHIOI_MName = value; wHIOI_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool WHIOI_MName_IsChanged
      {
         get{ return wHIOI_MName_IsChanged; }
         set{ wHIOI_MName_IsChanged = value; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      private string wHIOI_MSpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MSpec_IsChanged=false;
      /// <summary>
      /// 规格型号
      /// </summary>
      public string WHIOI_MSpec
      {
         get{ return wHIOI_MSpec; }
         set{ wHIOI_MSpec = value; wHIOI_MSpec_IsChanged=true; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      public bool WHIOI_MSpec_IsChanged
      {
         get{ return wHIOI_MSpec_IsChanged; }
         set{ wHIOI_MSpec_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string wHIOI_MUnit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MUnit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string WHIOI_MUnit
      {
         get{ return wHIOI_MUnit; }
         set{ wHIOI_MUnit = value; wHIOI_MUnit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool WHIOI_MUnit_IsChanged
      {
         get{ return wHIOI_MUnit_IsChanged; }
         set{ wHIOI_MUnit_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private decimal wHIOI_MNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MNum_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public decimal WHIOI_MNum
      {
         get{ return wHIOI_MNum; }
         set{ wHIOI_MNum = value; wHIOI_MNum_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool WHIOI_MNum_IsChanged
      {
         get{ return wHIOI_MNum_IsChanged; }
         set{ wHIOI_MNum_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal wHIOI_MPrice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_MPrice_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal WHIOI_MPrice
      {
         get{ return wHIOI_MPrice; }
         set{ wHIOI_MPrice = value; wHIOI_MPrice_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool WHIOI_MPrice_IsChanged
      {
         get{ return wHIOI_MPrice_IsChanged; }
         set{ wHIOI_MPrice_IsChanged = value; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      private string wHIOI_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_Company_IsChanged=false;
      /// <summary>
      /// 使用公司
      /// </summary>
      public string WHIOI_Company
      {
         get{ return wHIOI_Company; }
         set{ wHIOI_Company = value; wHIOI_Company_IsChanged=true; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      public bool WHIOI_Company_IsChanged
      {
         get{ return wHIOI_Company_IsChanged; }
         set{ wHIOI_Company_IsChanged = value; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      private string wHIOI_Department;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_Department_IsChanged=false;
      /// <summary>
      /// 使用部门
      /// </summary>
      public string WHIOI_Department
      {
         get{ return wHIOI_Department; }
         set{ wHIOI_Department = value; wHIOI_Department_IsChanged=true; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      public bool WHIOI_Department_IsChanged
      {
         get{ return wHIOI_Department_IsChanged; }
         set{ wHIOI_Department_IsChanged = value; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      private string wHIOI_UType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_UType_IsChanged=false;
      /// <summary>
      /// 使用类型
      /// </summary>
      public string WHIOI_UType
      {
         get{ return wHIOI_UType; }
         set{ wHIOI_UType = value; wHIOI_UType_IsChanged=true; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      public bool WHIOI_UType_IsChanged
      {
         get{ return wHIOI_UType_IsChanged; }
         set{ wHIOI_UType_IsChanged = value; }
      }
      /// <summary>
      /// 使用人/设备
      /// </summary>
      private string wHIOI_UOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_UOwner_IsChanged=false;
      /// <summary>
      /// 使用人/设备
      /// </summary>
      public string WHIOI_UOwner
      {
         get{ return wHIOI_UOwner; }
         set{ wHIOI_UOwner = value; wHIOI_UOwner_IsChanged=true; }
      }
      /// <summary>
      /// 使用人/设备
      /// </summary>
      public bool WHIOI_UOwner_IsChanged
      {
         get{ return wHIOI_UOwner_IsChanged; }
         set{ wHIOI_UOwner_IsChanged = value; }
      }
      private string wHIOI_UOwnerCode;
      private bool wHIOI_UOwnerCode_IsChanged=false;
      public string WHIOI_UOwnerCode
      {
         get{ return wHIOI_UOwnerCode; }
         set{ wHIOI_UOwnerCode = value; wHIOI_UOwnerCode_IsChanged=true; }
      }
      public bool WHIOI_UOwnerCode_IsChanged
      {
         get{ return wHIOI_UOwnerCode_IsChanged; }
         set{ wHIOI_UOwnerCode_IsChanged = value; }
      }
      /// <summary>
      /// 领用时间
      /// </summary>
      private DateTime wHIOI_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHIOI_Date_IsChanged=false;
      /// <summary>
      /// 领用时间
      /// </summary>
      public DateTime WHIOI_Date
      {
         get{ return wHIOI_Date; }
         set{ wHIOI_Date = value; wHIOI_Date_IsChanged=true; }
      }
      /// <summary>
      /// 领用时间
      /// </summary>
      public bool WHIOI_Date_IsChanged
      {
         get{ return wHIOI_Date_IsChanged; }
         set{ wHIOI_Date_IsChanged = value; }
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
      private string wHIOM_Code;
      private bool wHIOM_Code_IsChanged=false;
      public string WHIOM_Code
      {
         get{ return wHIOM_Code; }
         set{ wHIOM_Code = value; wHIOM_Code_IsChanged=true; }
      }
      public bool WHIOM_Code_IsChanged
      {
         get{ return wHIOM_Code_IsChanged; }
         set{ wHIOM_Code_IsChanged = value; }
      }
      private string wHIOI_RefWName;
      private bool wHIOI_RefWName_IsChanged=false;
      public string WHIOI_RefWName
      {
         get{ return wHIOI_RefWName; }
         set{ wHIOI_RefWName = value; wHIOI_RefWName_IsChanged=true; }
      }
      public bool WHIOI_RefWName_IsChanged
      {
         get{ return wHIOI_RefWName_IsChanged; }
         set{ wHIOI_RefWName_IsChanged = value; }
      }
      private string wHIOI_RefWCode;
      private bool wHIOI_RefWCode_IsChanged=false;
      public string WHIOI_RefWCode
      {
         get{ return wHIOI_RefWCode; }
         set{ wHIOI_RefWCode = value; wHIOI_RefWCode_IsChanged=true; }
      }
      public bool WHIOI_RefWCode_IsChanged
      {
         get{ return wHIOI_RefWCode_IsChanged; }
         set{ wHIOI_RefWCode_IsChanged = value; }
      }
      private string wHIOI_RefWNo;
      private bool wHIOI_RefWNo_IsChanged=false;
      public string WHIOI_RefWNo
      {
         get{ return wHIOI_RefWNo; }
         set{ wHIOI_RefWNo = value; wHIOI_RefWNo_IsChanged=true; }
      }
      public bool WHIOI_RefWNo_IsChanged
      {
         get{ return wHIOI_RefWNo_IsChanged; }
         set{ wHIOI_RefWNo_IsChanged = value; }
      }
      private string wHIOI_RefWNoName;
      private bool wHIOI_RefWNoName_IsChanged=false;
      public string WHIOI_RefWNoName
      {
         get{ return wHIOI_RefWNoName; }
         set{ wHIOI_RefWNoName = value; wHIOI_RefWNoName_IsChanged=true; }
      }
      public bool WHIOI_RefWNoName_IsChanged
      {
         get{ return wHIOI_RefWNoName_IsChanged; }
         set{ wHIOI_RefWNoName_IsChanged = value; }
      }
      private string wHIOI_Udef1;
      private bool wHIOI_Udef1_IsChanged=false;
      public string WHIOI_Udef1
      {
         get{ return wHIOI_Udef1; }
         set{ wHIOI_Udef1 = value; wHIOI_Udef1_IsChanged=true; }
      }
      public bool WHIOI_Udef1_IsChanged
      {
         get{ return wHIOI_Udef1_IsChanged; }
         set{ wHIOI_Udef1_IsChanged = value; }
      }
      private string wHIOI_Udef2;
      private bool wHIOI_Udef2_IsChanged=false;
      public string WHIOI_Udef2
      {
         get{ return wHIOI_Udef2; }
         set{ wHIOI_Udef2 = value; wHIOI_Udef2_IsChanged=true; }
      }
      public bool WHIOI_Udef2_IsChanged
      {
         get{ return wHIOI_Udef2_IsChanged; }
         set{ wHIOI_Udef2_IsChanged = value; }
      }
      private string wHIOI_Udef3;
      private bool wHIOI_Udef3_IsChanged=false;
      public string WHIOI_Udef3
      {
         get{ return wHIOI_Udef3; }
         set{ wHIOI_Udef3 = value; wHIOI_Udef3_IsChanged=true; }
      }
      public bool WHIOI_Udef3_IsChanged
      {
         get{ return wHIOI_Udef3_IsChanged; }
         set{ wHIOI_Udef3_IsChanged = value; }
      }
      private string wHIOI_Udef4;
      private bool wHIOI_Udef4_IsChanged=false;
      public string WHIOI_Udef4
      {
         get{ return wHIOI_Udef4; }
         set{ wHIOI_Udef4 = value; wHIOI_Udef4_IsChanged=true; }
      }
      public bool WHIOI_Udef4_IsChanged
      {
         get{ return wHIOI_Udef4_IsChanged; }
         set{ wHIOI_Udef4_IsChanged = value; }
      }
      private string wHIOI_Udef5;
      private bool wHIOI_Udef5_IsChanged=false;
      public string WHIOI_Udef5
      {
         get{ return wHIOI_Udef5; }
         set{ wHIOI_Udef5 = value; wHIOI_Udef5_IsChanged=true; }
      }
      public bool WHIOI_Udef5_IsChanged
      {
         get{ return wHIOI_Udef5_IsChanged; }
         set{ wHIOI_Udef5_IsChanged = value; }
      }
      private string wHIOI_CCompany;
      private bool wHIOI_CCompany_IsChanged=false;
      public string WHIOI_CCompany
      {
         get{ return wHIOI_CCompany; }
         set{ wHIOI_CCompany = value; wHIOI_CCompany_IsChanged=true; }
      }
      public bool WHIOI_CCompany_IsChanged
      {
         get{ return wHIOI_CCompany_IsChanged; }
         set{ wHIOI_CCompany_IsChanged = value; }
      }
      private string wHIOI_CCompanyCode;
      private bool wHIOI_CCompanyCode_IsChanged=false;
      public string WHIOI_CCompanyCode
      {
         get{ return wHIOI_CCompanyCode; }
         set{ wHIOI_CCompanyCode = value; wHIOI_CCompanyCode_IsChanged=true; }
      }
      public bool WHIOI_CCompanyCode_IsChanged
      {
         get{ return wHIOI_CCompanyCode_IsChanged; }
         set{ wHIOI_CCompanyCode_IsChanged = value; }
      }
      private string wHIOI_CDept;
      private bool wHIOI_CDept_IsChanged=false;
      public string WHIOI_CDept
      {
         get{ return wHIOI_CDept; }
         set{ wHIOI_CDept = value; wHIOI_CDept_IsChanged=true; }
      }
      public bool WHIOI_CDept_IsChanged
      {
         get{ return wHIOI_CDept_IsChanged; }
         set{ wHIOI_CDept_IsChanged = value; }
      }
      private string wHIOI_CDeptCode;
      private bool wHIOI_CDeptCode_IsChanged=false;
      public string WHIOI_CDeptCode
      {
         get{ return wHIOI_CDeptCode; }
         set{ wHIOI_CDeptCode = value; wHIOI_CDeptCode_IsChanged=true; }
      }
      public bool WHIOI_CDeptCode_IsChanged
      {
         get{ return wHIOI_CDeptCode_IsChanged; }
         set{ wHIOI_CDeptCode_IsChanged = value; }
      }
      private string wHIOI_UDEF6;
      private bool wHIOI_UDEF6_IsChanged=false;
      public string WHIOI_UDEF6
      {
         get{ return wHIOI_UDEF6; }
         set{ wHIOI_UDEF6 = value; wHIOI_UDEF6_IsChanged=true; }
      }
      public bool WHIOI_UDEF6_IsChanged
      {
         get{ return wHIOI_UDEF6_IsChanged; }
         set{ wHIOI_UDEF6_IsChanged = value; }
      }
      private string wHIOI_UDEF7;
      private bool wHIOI_UDEF7_IsChanged=false;
      public string WHIOI_UDEF7
      {
         get{ return wHIOI_UDEF7; }
         set{ wHIOI_UDEF7 = value; wHIOI_UDEF7_IsChanged=true; }
      }
      public bool WHIOI_UDEF7_IsChanged
      {
         get{ return wHIOI_UDEF7_IsChanged; }
         set{ wHIOI_UDEF7_IsChanged = value; }
      }
      private string wHIOI_UDEF8;
      private bool wHIOI_UDEF8_IsChanged=false;
      public string WHIOI_UDEF8
      {
         get{ return wHIOI_UDEF8; }
         set{ wHIOI_UDEF8 = value; wHIOI_UDEF8_IsChanged=true; }
      }
      public bool WHIOI_UDEF8_IsChanged
      {
         get{ return wHIOI_UDEF8_IsChanged; }
         set{ wHIOI_UDEF8_IsChanged = value; }
      }
      private string wHIOI_UDEF9;
      private bool wHIOI_UDEF9_IsChanged=false;
      public string WHIOI_UDEF9
      {
         get{ return wHIOI_UDEF9; }
         set{ wHIOI_UDEF9 = value; wHIOI_UDEF9_IsChanged=true; }
      }
      public bool WHIOI_UDEF9_IsChanged
      {
         get{ return wHIOI_UDEF9_IsChanged; }
         set{ wHIOI_UDEF9_IsChanged = value; }
      }
      private string wHIOI_UDEF10;
      private bool wHIOI_UDEF10_IsChanged=false;
      public string WHIOI_UDEF10
      {
         get{ return wHIOI_UDEF10; }
         set{ wHIOI_UDEF10 = value; wHIOI_UDEF10_IsChanged=true; }
      }
      public bool WHIOI_UDEF10_IsChanged
      {
         get{ return wHIOI_UDEF10_IsChanged; }
         set{ wHIOI_UDEF10_IsChanged = value; }
      }
      private decimal wHIOI_Num1;
      private bool wHIOI_Num1_IsChanged=false;
      public decimal WHIOI_Num1
      {
         get{ return wHIOI_Num1; }
         set{ wHIOI_Num1 = value; wHIOI_Num1_IsChanged=true; }
      }
      public bool WHIOI_Num1_IsChanged
      {
         get{ return wHIOI_Num1_IsChanged; }
         set{ wHIOI_Num1_IsChanged = value; }
      }
      private decimal wHIOI_Num2;
      private bool wHIOI_Num2_IsChanged=false;
      public decimal WHIOI_Num2
      {
         get{ return wHIOI_Num2; }
         set{ wHIOI_Num2 = value; wHIOI_Num2_IsChanged=true; }
      }
      public bool WHIOI_Num2_IsChanged
      {
         get{ return wHIOI_Num2_IsChanged; }
         set{ wHIOI_Num2_IsChanged = value; }
      }
      private decimal wHIOI_Num3;
      private bool wHIOI_Num3_IsChanged=false;
      public decimal WHIOI_Num3
      {
         get{ return wHIOI_Num3; }
         set{ wHIOI_Num3 = value; wHIOI_Num3_IsChanged=true; }
      }
      public bool WHIOI_Num3_IsChanged
      {
         get{ return wHIOI_Num3_IsChanged; }
         set{ wHIOI_Num3_IsChanged = value; }
      }
      private decimal wHIOI_Num4;
      private bool wHIOI_Num4_IsChanged=false;
      public decimal WHIOI_Num4
      {
         get{ return wHIOI_Num4; }
         set{ wHIOI_Num4 = value; wHIOI_Num4_IsChanged=true; }
      }
      public bool WHIOI_Num4_IsChanged
      {
         get{ return wHIOI_Num4_IsChanged; }
         set{ wHIOI_Num4_IsChanged = value; }
      }
      private decimal wHIOI_Num5;
      private bool wHIOI_Num5_IsChanged=false;
      public decimal WHIOI_Num5
      {
         get{ return wHIOI_Num5; }
         set{ wHIOI_Num5 = value; wHIOI_Num5_IsChanged=true; }
      }
      public bool WHIOI_Num5_IsChanged
      {
         get{ return wHIOI_Num5_IsChanged; }
         set{ wHIOI_Num5_IsChanged = value; }
      }
   }
}
