using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 固定资产信息表
   /// </summary>
   [Serializable]
   public partial class Asset_Infomation
   {
      /// <summary>
      /// 固定资产序号
      /// </summary>
      private decimal aInfo_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_ID_IsChanged=false;
      /// <summary>
      /// 固定资产序号
      /// </summary>
      public decimal AInfo_ID
      {
         get{ return aInfo_ID; }
         set{ aInfo_ID = value; aInfo_ID_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产序号
      /// </summary>
      public bool AInfo_ID_IsChanged
      {
         get{ return aInfo_ID_IsChanged; }
         set{ aInfo_ID_IsChanged = value; }
      }
      /// <summary>
      /// 资产编码
      /// </summary>
      private string aInfo_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Code_IsChanged=false;
      /// <summary>
      /// 资产编码
      /// </summary>
      public string AInfo_Code
      {
         get{ return aInfo_Code; }
         set{ aInfo_Code = value; aInfo_Code_IsChanged=true; }
      }
      /// <summary>
      /// 资产编码
      /// </summary>
      public bool AInfo_Code_IsChanged
      {
         get{ return aInfo_Code_IsChanged; }
         set{ aInfo_Code_IsChanged = value; }
      }
      /// <summary>
      /// 资产名称
      /// </summary>
      private string aInfo_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Name_IsChanged=false;
      /// <summary>
      /// 资产名称
      /// </summary>
      public string AInfo_Name
      {
         get{ return aInfo_Name; }
         set{ aInfo_Name = value; aInfo_Name_IsChanged=true; }
      }
      /// <summary>
      /// 资产名称
      /// </summary>
      public bool AInfo_Name_IsChanged
      {
         get{ return aInfo_Name_IsChanged; }
         set{ aInfo_Name_IsChanged = value; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      private string aInfo_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Spec_IsChanged=false;
      /// <summary>
      /// 规格型号
      /// </summary>
      public string AInfo_Spec
      {
         get{ return aInfo_Spec; }
         set{ aInfo_Spec = value; aInfo_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      public bool AInfo_Spec_IsChanged
      {
         get{ return aInfo_Spec_IsChanged; }
         set{ aInfo_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 技术参数
      /// </summary>
      private string aInfo_Tech;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Tech_IsChanged=false;
      /// <summary>
      /// 技术参数
      /// </summary>
      public string AInfo_Tech
      {
         get{ return aInfo_Tech; }
         set{ aInfo_Tech = value; aInfo_Tech_IsChanged=true; }
      }
      /// <summary>
      /// 技术参数
      /// </summary>
      public bool AInfo_Tech_IsChanged
      {
         get{ return aInfo_Tech_IsChanged; }
         set{ aInfo_Tech_IsChanged = value; }
      }
      /// <summary>
      /// 技术附件
      /// </summary>
      private string aInfo_TAttach;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_TAttach_IsChanged=false;
      /// <summary>
      /// 技术附件
      /// </summary>
      public string AInfo_TAttach
      {
         get{ return aInfo_TAttach; }
         set{ aInfo_TAttach = value; aInfo_TAttach_IsChanged=true; }
      }
      /// <summary>
      /// 技术附件
      /// </summary>
      public bool AInfo_TAttach_IsChanged
      {
         get{ return aInfo_TAttach_IsChanged; }
         set{ aInfo_TAttach_IsChanged = value; }
      }
      /// <summary>
      /// 相关组件
      /// </summary>
      private string aInfo_RefComp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_RefComp_IsChanged=false;
      /// <summary>
      /// 相关组件
      /// </summary>
      public string AInfo_RefComp
      {
         get{ return aInfo_RefComp; }
         set{ aInfo_RefComp = value; aInfo_RefComp_IsChanged=true; }
      }
      /// <summary>
      /// 相关组件
      /// </summary>
      public bool AInfo_RefComp_IsChanged
      {
         get{ return aInfo_RefComp_IsChanged; }
         set{ aInfo_RefComp_IsChanged = value; }
      }
      /// <summary>
      /// 制造商
      /// </summary>
      private string aInfo_Manu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Manu_IsChanged=false;
      /// <summary>
      /// 制造商
      /// </summary>
      public string AInfo_Manu
      {
         get{ return aInfo_Manu; }
         set{ aInfo_Manu = value; aInfo_Manu_IsChanged=true; }
      }
      /// <summary>
      /// 制造商
      /// </summary>
      public bool AInfo_Manu_IsChanged
      {
         get{ return aInfo_Manu_IsChanged; }
         set{ aInfo_Manu_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal aInfo_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Price_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal AInfo_Price
      {
         get{ return aInfo_Price; }
         set{ aInfo_Price = value; aInfo_Price_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool AInfo_Price_IsChanged
      {
         get{ return aInfo_Price_IsChanged; }
         set{ aInfo_Price_IsChanged = value; }
      }
      /// <summary>
      /// 购买时间
      /// </summary>
      private DateTime aInfo_BuyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_BuyDate_IsChanged=false;
      /// <summary>
      /// 购买时间
      /// </summary>
      public DateTime AInfo_BuyDate
      {
         get{ return aInfo_BuyDate; }
         set{ aInfo_BuyDate = value; aInfo_BuyDate_IsChanged=true; }
      }
      /// <summary>
      /// 购买时间
      /// </summary>
      public bool AInfo_BuyDate_IsChanged
      {
         get{ return aInfo_BuyDate_IsChanged; }
         set{ aInfo_BuyDate_IsChanged = value; }
      }
      /// <summary>
      /// 生产日期
      /// </summary>
      private string aInfo_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_PDate_IsChanged=false;
      /// <summary>
      /// 生产日期
      /// </summary>
      public string AInfo_PDate
      {
         get{ return aInfo_PDate; }
         set{ aInfo_PDate = value; aInfo_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 生产日期
      /// </summary>
      public bool AInfo_PDate_IsChanged
      {
         get{ return aInfo_PDate_IsChanged; }
         set{ aInfo_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string aInfo_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string AInfo_SCode
      {
         get{ return aInfo_SCode; }
         set{ aInfo_SCode = value; aInfo_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool AInfo_SCode_IsChanged
      {
         get{ return aInfo_SCode_IsChanged; }
         set{ aInfo_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string aInfo_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_CCode_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string AInfo_CCode
      {
         get{ return aInfo_CCode; }
         set{ aInfo_CCode = value; aInfo_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool AInfo_CCode_IsChanged
      {
         get{ return aInfo_CCode_IsChanged; }
         set{ aInfo_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 资产类别
      /// </summary>
      private string aInfo_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Type_IsChanged=false;
      /// <summary>
      /// 资产类别
      /// </summary>
      public string AInfo_Type
      {
         get{ return aInfo_Type; }
         set{ aInfo_Type = value; aInfo_Type_IsChanged=true; }
      }
      /// <summary>
      /// 资产类别
      /// </summary>
      public bool AInfo_Type_IsChanged
      {
         get{ return aInfo_Type_IsChanged; }
         set{ aInfo_Type_IsChanged = value; }
      }
      private string aInfo_Type_Temp;
      private bool aInfo_Type_Temp_IsChanged=false;
      public string AInfo_Type_Temp
      {
         get{ return aInfo_Type_Temp; }
         set{ aInfo_Type_Temp = value; aInfo_Type_Temp_IsChanged=true; }
      }
      public bool AInfo_Type_Temp_IsChanged
      {
         get{ return aInfo_Type_Temp_IsChanged; }
         set{ aInfo_Type_Temp_IsChanged = value; }
      }
      /// <summary>
      /// 资产内部类别
      /// </summary>
      private string aInfo_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_iType_IsChanged=false;
      /// <summary>
      /// 资产内部类别
      /// </summary>
      public string AInfo_iType
      {
         get{ return aInfo_iType; }
         set{ aInfo_iType = value; aInfo_iType_IsChanged=true; }
      }
      /// <summary>
      /// 资产内部类别
      /// </summary>
      public bool AInfo_iType_IsChanged
      {
         get{ return aInfo_iType_IsChanged; }
         set{ aInfo_iType_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string aInfo_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_CompanyCode_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string AInfo_CompanyCode
      {
         get{ return aInfo_CompanyCode; }
         set{ aInfo_CompanyCode = value; aInfo_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool AInfo_CompanyCode_IsChanged
      {
         get{ return aInfo_CompanyCode_IsChanged; }
         set{ aInfo_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string aInfo_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string AInfo_Company
      {
         get{ return aInfo_Company; }
         set{ aInfo_Company = value; aInfo_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool AInfo_Company_IsChanged
      {
         get{ return aInfo_Company_IsChanged; }
         set{ aInfo_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string aInfo_DepartmentCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_DepartmentCode_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string AInfo_DepartmentCode
      {
         get{ return aInfo_DepartmentCode; }
         set{ aInfo_DepartmentCode = value; aInfo_DepartmentCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool AInfo_DepartmentCode_IsChanged
      {
         get{ return aInfo_DepartmentCode_IsChanged; }
         set{ aInfo_DepartmentCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string aInfo_Department;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Department_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string AInfo_Department
      {
         get{ return aInfo_Department; }
         set{ aInfo_Department = value; aInfo_Department_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool AInfo_Department_IsChanged
      {
         get{ return aInfo_Department_IsChanged; }
         set{ aInfo_Department_IsChanged = value; }
      }
      /// <summary>
      /// 资产状态
      /// </summary>
      private string aInfo_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_Status_IsChanged=false;
      /// <summary>
      /// 资产状态
      /// </summary>
      public string AInfo_Status
      {
         get{ return aInfo_Status; }
         set{ aInfo_Status = value; aInfo_Status_IsChanged=true; }
      }
      /// <summary>
      /// 资产状态
      /// </summary>
      public bool AInfo_Status_IsChanged
      {
         get{ return aInfo_Status_IsChanged; }
         set{ aInfo_Status_IsChanged = value; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      private string aInfo_UCompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UCompanyCode_IsChanged=false;
      /// <summary>
      /// 使用公司
      /// </summary>
      public string AInfo_UCompanyCode
      {
         get{ return aInfo_UCompanyCode; }
         set{ aInfo_UCompanyCode = value; aInfo_UCompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      public bool AInfo_UCompanyCode_IsChanged
      {
         get{ return aInfo_UCompanyCode_IsChanged; }
         set{ aInfo_UCompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      private string aInfo_UCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UCompany_IsChanged=false;
      /// <summary>
      /// 使用公司
      /// </summary>
      public string AInfo_UCompany
      {
         get{ return aInfo_UCompany; }
         set{ aInfo_UCompany = value; aInfo_UCompany_IsChanged=true; }
      }
      /// <summary>
      /// 使用公司
      /// </summary>
      public bool AInfo_UCompany_IsChanged
      {
         get{ return aInfo_UCompany_IsChanged; }
         set{ aInfo_UCompany_IsChanged = value; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      private string aInfo_UDepartmentCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UDepartmentCode_IsChanged=false;
      /// <summary>
      /// 使用部门
      /// </summary>
      public string AInfo_UDepartmentCode
      {
         get{ return aInfo_UDepartmentCode; }
         set{ aInfo_UDepartmentCode = value; aInfo_UDepartmentCode_IsChanged=true; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      public bool AInfo_UDepartmentCode_IsChanged
      {
         get{ return aInfo_UDepartmentCode_IsChanged; }
         set{ aInfo_UDepartmentCode_IsChanged = value; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      private string aInfo_UDepartment;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UDepartment_IsChanged=false;
      /// <summary>
      /// 使用部门
      /// </summary>
      public string AInfo_UDepartment
      {
         get{ return aInfo_UDepartment; }
         set{ aInfo_UDepartment = value; aInfo_UDepartment_IsChanged=true; }
      }
      /// <summary>
      /// 使用部门
      /// </summary>
      public bool AInfo_UDepartment_IsChanged
      {
         get{ return aInfo_UDepartment_IsChanged; }
         set{ aInfo_UDepartment_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string aInfo_UOwnerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UOwnerCode_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string AInfo_UOwnerCode
      {
         get{ return aInfo_UOwnerCode; }
         set{ aInfo_UOwnerCode = value; aInfo_UOwnerCode_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool AInfo_UOwnerCode_IsChanged
      {
         get{ return aInfo_UOwnerCode_IsChanged; }
         set{ aInfo_UOwnerCode_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string aInfo_UOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UOwner_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string AInfo_UOwner
      {
         get{ return aInfo_UOwner; }
         set{ aInfo_UOwner = value; aInfo_UOwner_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool AInfo_UOwner_IsChanged
      {
         get{ return aInfo_UOwner_IsChanged; }
         set{ aInfo_UOwner_IsChanged = value; }
      }
      /// <summary>
      /// 开始使用时间
      /// </summary>
      private DateTime aInfo_UStart;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aInfo_UStart_IsChanged=false;
      /// <summary>
      /// 开始使用时间
      /// </summary>
      public DateTime AInfo_UStart
      {
         get{ return aInfo_UStart; }
         set{ aInfo_UStart = value; aInfo_UStart_IsChanged=true; }
      }
      /// <summary>
      /// 开始使用时间
      /// </summary>
      public bool AInfo_UStart_IsChanged
      {
         get{ return aInfo_UStart_IsChanged; }
         set{ aInfo_UStart_IsChanged = value; }
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
      private string aInfo_Unit;
      private bool aInfo_Unit_IsChanged=false;
      public string AInfo_Unit
      {
         get{ return aInfo_Unit; }
         set{ aInfo_Unit = value; aInfo_Unit_IsChanged=true; }
      }
      public bool AInfo_Unit_IsChanged
      {
         get{ return aInfo_Unit_IsChanged; }
         set{ aInfo_Unit_IsChanged = value; }
      }
      private string aInfo_BOwnerCode;
      private bool aInfo_BOwnerCode_IsChanged=false;
      public string AInfo_BOwnerCode
      {
         get{ return aInfo_BOwnerCode; }
         set{ aInfo_BOwnerCode = value; aInfo_BOwnerCode_IsChanged=true; }
      }
      public bool AInfo_BOwnerCode_IsChanged
      {
         get{ return aInfo_BOwnerCode_IsChanged; }
         set{ aInfo_BOwnerCode_IsChanged = value; }
      }
      private string aInfo_BOwner;
      private bool aInfo_BOwner_IsChanged=false;
      public string AInfo_BOwner
      {
         get{ return aInfo_BOwner; }
         set{ aInfo_BOwner = value; aInfo_BOwner_IsChanged=true; }
      }
      public bool AInfo_BOwner_IsChanged
      {
         get{ return aInfo_BOwner_IsChanged; }
         set{ aInfo_BOwner_IsChanged = value; }
      }
      private string aInfo_Value;
      private bool aInfo_Value_IsChanged=false;
      public string AInfo_Value
      {
         get{ return aInfo_Value; }
         set{ aInfo_Value = value; aInfo_Value_IsChanged=true; }
      }
      public bool AInfo_Value_IsChanged
      {
         get{ return aInfo_Value_IsChanged; }
         set{ aInfo_Value_IsChanged = value; }
      }
      private string aInfo_Addr;
      private bool aInfo_Addr_IsChanged=false;
      public string AInfo_Addr
      {
         get{ return aInfo_Addr; }
         set{ aInfo_Addr = value; aInfo_Addr_IsChanged=true; }
      }
      public bool AInfo_Addr_IsChanged
      {
         get{ return aInfo_Addr_IsChanged; }
         set{ aInfo_Addr_IsChanged = value; }
      }
   }
}
