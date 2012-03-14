using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆信息
   /// </summary>
   [Serializable]
   public partial class PCT_Info
   {
      private decimal pCTI_ID;
      private bool pCTI_ID_IsChanged=false;
      public decimal PCTI_ID
      {
         get{ return pCTI_ID; }
         set{ pCTI_ID = value; pCTI_ID_IsChanged=true; }
      }
      public bool PCTI_ID_IsChanged
      {
         get{ return pCTI_ID_IsChanged; }
         set{ pCTI_ID_IsChanged = value; }
      }
      private string pCTI_Code;
      private bool pCTI_Code_IsChanged=false;
      public string PCTI_Code
      {
         get{ return pCTI_Code; }
         set{ pCTI_Code = value; pCTI_Code_IsChanged=true; }
      }
      public bool PCTI_Code_IsChanged
      {
         get{ return pCTI_Code_IsChanged; }
         set{ pCTI_Code_IsChanged = value; }
      }
      private string pCTI_NO;
      private bool pCTI_NO_IsChanged=false;
      public string PCTI_NO
      {
         get{ return pCTI_NO; }
         set{ pCTI_NO = value; pCTI_NO_IsChanged=true; }
      }
      public bool PCTI_NO_IsChanged
      {
         get{ return pCTI_NO_IsChanged; }
         set{ pCTI_NO_IsChanged = value; }
      }
      private string pCTI_TCode;
      private bool pCTI_TCode_IsChanged=false;
      public string PCTI_TCode
      {
         get{ return pCTI_TCode; }
         set{ pCTI_TCode = value; pCTI_TCode_IsChanged=true; }
      }
      public bool PCTI_TCode_IsChanged
      {
         get{ return pCTI_TCode_IsChanged; }
         set{ pCTI_TCode_IsChanged = value; }
      }
      private string pCTI_BCode;
      private bool pCTI_BCode_IsChanged=false;
      public string PCTI_BCode
      {
         get{ return pCTI_BCode; }
         set{ pCTI_BCode = value; pCTI_BCode_IsChanged=true; }
      }
      public bool PCTI_BCode_IsChanged
      {
         get{ return pCTI_BCode_IsChanged; }
         set{ pCTI_BCode_IsChanged = value; }
      }
      private string pCTI_BName;
      private bool pCTI_BName_IsChanged=false;
      public string PCTI_BName
      {
         get{ return pCTI_BName; }
         set{ pCTI_BName = value; pCTI_BName_IsChanged=true; }
      }
      public bool PCTI_BName_IsChanged
      {
         get{ return pCTI_BName_IsChanged; }
         set{ pCTI_BName_IsChanged = value; }
      }
      private string pCTI_Type;
      private bool pCTI_Type_IsChanged=false;
      public string PCTI_Type
      {
         get{ return pCTI_Type; }
         set{ pCTI_Type = value; pCTI_Type_IsChanged=true; }
      }
      public bool PCTI_Type_IsChanged
      {
         get{ return pCTI_Type_IsChanged; }
         set{ pCTI_Type_IsChanged = value; }
      }
      private string pCTI_DCode;
      private bool pCTI_DCode_IsChanged=false;
      public string PCTI_DCode
      {
         get{ return pCTI_DCode; }
         set{ pCTI_DCode = value; pCTI_DCode_IsChanged=true; }
      }
      public bool PCTI_DCode_IsChanged
      {
         get{ return pCTI_DCode_IsChanged; }
         set{ pCTI_DCode_IsChanged = value; }
      }
      private string pCTI_DName;
      private bool pCTI_DName_IsChanged=false;
      public string PCTI_DName
      {
         get{ return pCTI_DName; }
         set{ pCTI_DName = value; pCTI_DName_IsChanged=true; }
      }
      public bool PCTI_DName_IsChanged
      {
         get{ return pCTI_DName_IsChanged; }
         set{ pCTI_DName_IsChanged = value; }
      }
      private decimal pCTI_Tare;
      private bool pCTI_Tare_IsChanged=false;
      public decimal PCTI_Tare
      {
         get{ return pCTI_Tare; }
         set{ pCTI_Tare = value; pCTI_Tare_IsChanged=true; }
      }
      public bool PCTI_Tare_IsChanged
      {
         get{ return pCTI_Tare_IsChanged; }
         set{ pCTI_Tare_IsChanged = value; }
      }
      private decimal pCTI_Gross;
      private bool pCTI_Gross_IsChanged=false;
      public decimal PCTI_Gross
      {
         get{ return pCTI_Gross; }
         set{ pCTI_Gross = value; pCTI_Gross_IsChanged=true; }
      }
      public bool PCTI_Gross_IsChanged
      {
         get{ return pCTI_Gross_IsChanged; }
         set{ pCTI_Gross_IsChanged = value; }
      }
      private decimal pCTI_VTare;
      private bool pCTI_VTare_IsChanged=false;
      public decimal PCTI_VTare
      {
         get{ return pCTI_VTare; }
         set{ pCTI_VTare = value; pCTI_VTare_IsChanged=true; }
      }
      public bool PCTI_VTare_IsChanged
      {
         get{ return pCTI_VTare_IsChanged; }
         set{ pCTI_VTare_IsChanged = value; }
      }
      private decimal pCTI_BTare;
      private bool pCTI_BTare_IsChanged=false;
      public decimal PCTI_BTare
      {
         get{ return pCTI_BTare; }
         set{ pCTI_BTare = value; pCTI_BTare_IsChanged=true; }
      }
      public bool PCTI_BTare_IsChanged
      {
         get{ return pCTI_BTare_IsChanged; }
         set{ pCTI_BTare_IsChanged = value; }
      }
      private string pCTI_Manu;
      private bool pCTI_Manu_IsChanged=false;
      public string PCTI_Manu
      {
         get{ return pCTI_Manu; }
         set{ pCTI_Manu = value; pCTI_Manu_IsChanged=true; }
      }
      public bool PCTI_Manu_IsChanged
      {
         get{ return pCTI_Manu_IsChanged; }
         set{ pCTI_Manu_IsChanged = value; }
      }
      private DateTime pCTI_FDate;
      private bool pCTI_FDate_IsChanged=false;
      public DateTime PCTI_FDate
      {
         get{ return pCTI_FDate; }
         set{ pCTI_FDate = value; pCTI_FDate_IsChanged=true; }
      }
      public bool PCTI_FDate_IsChanged
      {
         get{ return pCTI_FDate_IsChanged; }
         set{ pCTI_FDate_IsChanged = value; }
      }
      private DateTime pCTI_BDate;
      private bool pCTI_BDate_IsChanged=false;
      public DateTime PCTI_BDate
      {
         get{ return pCTI_BDate; }
         set{ pCTI_BDate = value; pCTI_BDate_IsChanged=true; }
      }
      public bool PCTI_BDate_IsChanged
      {
         get{ return pCTI_BDate_IsChanged; }
         set{ pCTI_BDate_IsChanged = value; }
      }
      private string pCTI_Spec;
      private bool pCTI_Spec_IsChanged=false;
      public string PCTI_Spec
      {
         get{ return pCTI_Spec; }
         set{ pCTI_Spec = value; pCTI_Spec_IsChanged=true; }
      }
      public bool PCTI_Spec_IsChanged
      {
         get{ return pCTI_Spec_IsChanged; }
         set{ pCTI_Spec_IsChanged = value; }
      }
      private string pCTI_CompanyCode;
      private bool pCTI_CompanyCode_IsChanged=false;
      public string PCTI_CompanyCode
      {
         get{ return pCTI_CompanyCode; }
         set{ pCTI_CompanyCode = value; pCTI_CompanyCode_IsChanged=true; }
      }
      public bool PCTI_CompanyCode_IsChanged
      {
         get{ return pCTI_CompanyCode_IsChanged; }
         set{ pCTI_CompanyCode_IsChanged = value; }
      }
      private string pCTI_Company;
      private bool pCTI_Company_IsChanged=false;
      public string PCTI_Company
      {
         get{ return pCTI_Company; }
         set{ pCTI_Company = value; pCTI_Company_IsChanged=true; }
      }
      public bool PCTI_Company_IsChanged
      {
         get{ return pCTI_Company_IsChanged; }
         set{ pCTI_Company_IsChanged = value; }
      }
      private string pCTI_DepartmentCode;
      private bool pCTI_DepartmentCode_IsChanged=false;
      public string PCTI_DepartmentCode
      {
         get{ return pCTI_DepartmentCode; }
         set{ pCTI_DepartmentCode = value; pCTI_DepartmentCode_IsChanged=true; }
      }
      public bool PCTI_DepartmentCode_IsChanged
      {
         get{ return pCTI_DepartmentCode_IsChanged; }
         set{ pCTI_DepartmentCode_IsChanged = value; }
      }
      private string pCTI_Department;
      private bool pCTI_Department_IsChanged=false;
      public string PCTI_Department
      {
         get{ return pCTI_Department; }
         set{ pCTI_Department = value; pCTI_Department_IsChanged=true; }
      }
      public bool PCTI_Department_IsChanged
      {
         get{ return pCTI_Department_IsChanged; }
         set{ pCTI_Department_IsChanged = value; }
      }
      private string pCTI_TAttach;
      private bool pCTI_TAttach_IsChanged=false;
      public string PCTI_TAttach
      {
         get{ return pCTI_TAttach; }
         set{ pCTI_TAttach = value; pCTI_TAttach_IsChanged=true; }
      }
      public bool PCTI_TAttach_IsChanged
      {
         get{ return pCTI_TAttach_IsChanged; }
         set{ pCTI_TAttach_IsChanged = value; }
      }
      private string pCTI_Tech;
      private bool pCTI_Tech_IsChanged=false;
      public string PCTI_Tech
      {
         get{ return pCTI_Tech; }
         set{ pCTI_Tech = value; pCTI_Tech_IsChanged=true; }
      }
      public bool PCTI_Tech_IsChanged
      {
         get{ return pCTI_Tech_IsChanged; }
         set{ pCTI_Tech_IsChanged = value; }
      }
      private string pCTI_iType;
      private bool pCTI_iType_IsChanged=false;
      public string PCTI_iType
      {
         get{ return pCTI_iType; }
         set{ pCTI_iType = value; pCTI_iType_IsChanged=true; }
      }
      public bool PCTI_iType_IsChanged
      {
         get{ return pCTI_iType_IsChanged; }
         set{ pCTI_iType_IsChanged = value; }
      }
      private string pCTI_Status;
      private bool pCTI_Status_IsChanged=false;
      public string PCTI_Status
      {
         get{ return pCTI_Status; }
         set{ pCTI_Status = value; pCTI_Status_IsChanged=true; }
      }
      public bool PCTI_Status_IsChanged
      {
         get{ return pCTI_Status_IsChanged; }
         set{ pCTI_Status_IsChanged = value; }
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
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
      private string pCTI_LStatus;
      private bool pCTI_LStatus_IsChanged=false;
      public string PCTI_LStatus
      {
         get{ return pCTI_LStatus; }
         set{ pCTI_LStatus = value; pCTI_LStatus_IsChanged=true; }
      }
      public bool PCTI_LStatus_IsChanged
      {
         get{ return pCTI_LStatus_IsChanged; }
         set{ pCTI_LStatus_IsChanged = value; }
      }
      private string pCTI_Addr;
      private bool pCTI_Addr_IsChanged=false;
      public string PCTI_Addr
      {
         get{ return pCTI_Addr; }
         set{ pCTI_Addr = value; pCTI_Addr_IsChanged=true; }
      }
      public bool PCTI_Addr_IsChanged
      {
         get{ return pCTI_Addr_IsChanged; }
         set{ pCTI_Addr_IsChanged = value; }
      }
      private string pCTI_Address;
      private bool pCTI_Address_IsChanged=false;
      public string PCTI_Address
      {
         get{ return pCTI_Address; }
         set{ pCTI_Address = value; pCTI_Address_IsChanged=true; }
      }
      public bool PCTI_Address_IsChanged
      {
         get{ return pCTI_Address_IsChanged; }
         set{ pCTI_Address_IsChanged = value; }
      }
      private string pCTI_Udef1;
      private bool pCTI_Udef1_IsChanged=false;
      public string PCTI_Udef1
      {
         get{ return pCTI_Udef1; }
         set{ pCTI_Udef1 = value; pCTI_Udef1_IsChanged=true; }
      }
      public bool PCTI_Udef1_IsChanged
      {
         get{ return pCTI_Udef1_IsChanged; }
         set{ pCTI_Udef1_IsChanged = value; }
      }
      private string pCTI_Udef2;
      private bool pCTI_Udef2_IsChanged=false;
      public string PCTI_Udef2
      {
         get{ return pCTI_Udef2; }
         set{ pCTI_Udef2 = value; pCTI_Udef2_IsChanged=true; }
      }
      public bool PCTI_Udef2_IsChanged
      {
         get{ return pCTI_Udef2_IsChanged; }
         set{ pCTI_Udef2_IsChanged = value; }
      }
      private string pCTI_Udef3;
      private bool pCTI_Udef3_IsChanged=false;
      public string PCTI_Udef3
      {
         get{ return pCTI_Udef3; }
         set{ pCTI_Udef3 = value; pCTI_Udef3_IsChanged=true; }
      }
      public bool PCTI_Udef3_IsChanged
      {
         get{ return pCTI_Udef3_IsChanged; }
         set{ pCTI_Udef3_IsChanged = value; }
      }
      private string pCTI_Udef4;
      private bool pCTI_Udef4_IsChanged=false;
      public string PCTI_Udef4
      {
         get{ return pCTI_Udef4; }
         set{ pCTI_Udef4 = value; pCTI_Udef4_IsChanged=true; }
      }
      public bool PCTI_Udef4_IsChanged
      {
         get{ return pCTI_Udef4_IsChanged; }
         set{ pCTI_Udef4_IsChanged = value; }
      }
      private string pCTI_Udef5;
      private bool pCTI_Udef5_IsChanged=false;
      public string PCTI_Udef5
      {
         get{ return pCTI_Udef5; }
         set{ pCTI_Udef5 = value; pCTI_Udef5_IsChanged=true; }
      }
      public bool PCTI_Udef5_IsChanged
      {
         get{ return pCTI_Udef5_IsChanged; }
         set{ pCTI_Udef5_IsChanged = value; }
      }
   }
}
