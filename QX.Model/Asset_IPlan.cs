using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 固定资产检修计划细表
   /// </summary>
   [Serializable]
   public partial class Asset_IPlan
   {
      /// <summary>
      /// 固定资产检修细表ID
      /// </summary>
      private decimal aIP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_ID_IsChanged=false;
      /// <summary>
      /// 固定资产检修细表ID
      /// </summary>
      public decimal AIP_ID
      {
         get{ return aIP_ID; }
         set{ aIP_ID = value; aIP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产检修细表ID
      /// </summary>
      public bool AIP_ID_IsChanged
      {
         get{ return aIP_ID_IsChanged; }
         set{ aIP_ID_IsChanged = value; }
      }
      private string aIP_Code;
      private bool aIP_Code_IsChanged=false;
      public string AIP_Code
      {
         get{ return aIP_Code; }
         set{ aIP_Code = value; aIP_Code_IsChanged=true; }
      }
      public bool AIP_Code_IsChanged
      {
         get{ return aIP_Code_IsChanged; }
         set{ aIP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产检修主表编码
      /// </summary>
      private string aIP_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_MCode_IsChanged=false;
      /// <summary>
      /// 固定资产检修主表编码
      /// </summary>
      public string AIP_MCode
      {
         get{ return aIP_MCode; }
         set{ aIP_MCode = value; aIP_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产检修主表编码
      /// </summary>
      public bool AIP_MCode_IsChanged
      {
         get{ return aIP_MCode_IsChanged; }
         set{ aIP_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产编码
      /// </summary>
      private string aIP_FCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_FCode_IsChanged=false;
      /// <summary>
      /// 固定资产编码
      /// </summary>
      public string AIP_FCode
      {
         get{ return aIP_FCode; }
         set{ aIP_FCode = value; aIP_FCode_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产编码
      /// </summary>
      public bool AIP_FCode_IsChanged
      {
         get{ return aIP_FCode_IsChanged; }
         set{ aIP_FCode_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产名称
      /// </summary>
      private string aIP_FName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_FName_IsChanged=false;
      /// <summary>
      /// 固定资产名称
      /// </summary>
      public string AIP_FName
      {
         get{ return aIP_FName; }
         set{ aIP_FName = value; aIP_FName_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产名称
      /// </summary>
      public bool AIP_FName_IsChanged
      {
         get{ return aIP_FName_IsChanged; }
         set{ aIP_FName_IsChanged = value; }
      }
      /// <summary>
      /// 计划检修时间
      /// </summary>
      private DateTime aIP_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_PDate_IsChanged=false;
      /// <summary>
      /// 计划检修时间
      /// </summary>
      public DateTime AIP_PDate
      {
         get{ return aIP_PDate; }
         set{ aIP_PDate = value; aIP_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 计划检修时间
      /// </summary>
      public bool AIP_PDate_IsChanged
      {
         get{ return aIP_PDate_IsChanged; }
         set{ aIP_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 资产使用公司
      /// </summary>
      private string aIP_UCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_UCompany_IsChanged=false;
      /// <summary>
      /// 资产使用公司
      /// </summary>
      public string AIP_UCompany
      {
         get{ return aIP_UCompany; }
         set{ aIP_UCompany = value; aIP_UCompany_IsChanged=true; }
      }
      /// <summary>
      /// 资产使用公司
      /// </summary>
      public bool AIP_UCompany_IsChanged
      {
         get{ return aIP_UCompany_IsChanged; }
         set{ aIP_UCompany_IsChanged = value; }
      }
      /// <summary>
      /// 资产使用部门
      /// </summary>
      private string aIP_UDepartment;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_UDepartment_IsChanged=false;
      /// <summary>
      /// 资产使用部门
      /// </summary>
      public string AIP_UDepartment
      {
         get{ return aIP_UDepartment; }
         set{ aIP_UDepartment = value; aIP_UDepartment_IsChanged=true; }
      }
      /// <summary>
      /// 资产使用部门
      /// </summary>
      public bool AIP_UDepartment_IsChanged
      {
         get{ return aIP_UDepartment_IsChanged; }
         set{ aIP_UDepartment_IsChanged = value; }
      }
      /// <summary>
      /// 资产使用人
      /// </summary>
      private string aIP_UOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_UOwner_IsChanged=false;
      /// <summary>
      /// 资产使用人
      /// </summary>
      public string AIP_UOwner
      {
         get{ return aIP_UOwner; }
         set{ aIP_UOwner = value; aIP_UOwner_IsChanged=true; }
      }
      /// <summary>
      /// 资产使用人
      /// </summary>
      public bool AIP_UOwner_IsChanged
      {
         get{ return aIP_UOwner_IsChanged; }
         set{ aIP_UOwner_IsChanged = value; }
      }
      /// <summary>
      /// 计划执行人
      /// </summary>
      private string aIP_PExecute;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_PExecute_IsChanged=false;
      /// <summary>
      /// 计划执行人
      /// </summary>
      public string AIP_PExecute
      {
         get{ return aIP_PExecute; }
         set{ aIP_PExecute = value; aIP_PExecute_IsChanged=true; }
      }
      /// <summary>
      /// 计划执行人
      /// </summary>
      public bool AIP_PExecute_IsChanged
      {
         get{ return aIP_PExecute_IsChanged; }
         set{ aIP_PExecute_IsChanged = value; }
      }
      /// <summary>
      /// 计划执行部门
      /// </summary>
      private string aIP_PDepartment;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aIP_PDepartment_IsChanged=false;
      /// <summary>
      /// 计划执行部门
      /// </summary>
      public string AIP_PDepartment
      {
         get{ return aIP_PDepartment; }
         set{ aIP_PDepartment = value; aIP_PDepartment_IsChanged=true; }
      }
      /// <summary>
      /// 计划执行部门
      /// </summary>
      public bool AIP_PDepartment_IsChanged
      {
         get{ return aIP_PDepartment_IsChanged; }
         set{ aIP_PDepartment_IsChanged = value; }
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
      private string aIP_Status;
      private bool aIP_Status_IsChanged=false;
      public string AIP_Status
      {
         get{ return aIP_Status; }
         set{ aIP_Status = value; aIP_Status_IsChanged=true; }
      }
      public bool AIP_Status_IsChanged
      {
         get{ return aIP_Status_IsChanged; }
         set{ aIP_Status_IsChanged = value; }
      }
      private string aIP_Bak;
      private bool aIP_Bak_IsChanged=false;
      public string AIP_Bak
      {
         get{ return aIP_Bak; }
         set{ aIP_Bak = value; aIP_Bak_IsChanged=true; }
      }
      public bool AIP_Bak_IsChanged
      {
         get{ return aIP_Bak_IsChanged; }
         set{ aIP_Bak_IsChanged = value; }
      }
   }
}
