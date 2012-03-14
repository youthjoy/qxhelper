using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 固定资产使用记录
   /// </summary>
   [Serializable]
   public partial class Assets_Record
   {
      /// <summary>
      /// 使用记录序号
      /// </summary>
      private decimal aRecord_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_ID_IsChanged=false;
      /// <summary>
      /// 使用记录序号
      /// </summary>
      public decimal ARecord_ID
      {
         get{ return aRecord_ID; }
         set{ aRecord_ID = value; aRecord_ID_IsChanged=true; }
      }
      /// <summary>
      /// 使用记录序号
      /// </summary>
      public bool ARecord_ID_IsChanged
      {
         get{ return aRecord_ID_IsChanged; }
         set{ aRecord_ID_IsChanged = value; }
      }
      /// <summary>
      /// 操作类型
      /// </summary>
      private string aRecord_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_Type_IsChanged=false;
      /// <summary>
      /// 操作类型
      /// </summary>
      public string ARecord_Type
      {
         get{ return aRecord_Type; }
         set{ aRecord_Type = value; aRecord_Type_IsChanged=true; }
      }
      /// <summary>
      /// 操作类型
      /// </summary>
      public bool ARecord_Type_IsChanged
      {
         get{ return aRecord_Type_IsChanged; }
         set{ aRecord_Type_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产使用记录编码
      /// </summary>
      private string aRecord_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_Code_IsChanged=false;
      /// <summary>
      /// 固定资产使用记录编码
      /// </summary>
      public string ARecord_Code
      {
         get{ return aRecord_Code; }
         set{ aRecord_Code = value; aRecord_Code_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产使用记录编码
      /// </summary>
      public bool ARecord_Code_IsChanged
      {
         get{ return aRecord_Code_IsChanged; }
         set{ aRecord_Code_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产编码
      /// </summary>
      private string aRecord_ACode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_ACode_IsChanged=false;
      /// <summary>
      /// 固定资产编码
      /// </summary>
      public string ARecord_ACode
      {
         get{ return aRecord_ACode; }
         set{ aRecord_ACode = value; aRecord_ACode_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产编码
      /// </summary>
      public bool ARecord_ACode_IsChanged
      {
         get{ return aRecord_ACode_IsChanged; }
         set{ aRecord_ACode_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string aRecord_UserCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_UserCode_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string ARecord_UserCode
      {
         get{ return aRecord_UserCode; }
         set{ aRecord_UserCode = value; aRecord_UserCode_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool ARecord_UserCode_IsChanged
      {
         get{ return aRecord_UserCode_IsChanged; }
         set{ aRecord_UserCode_IsChanged = value; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      private string aRecord_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_User_IsChanged=false;
      /// <summary>
      /// 使用人
      /// </summary>
      public string ARecord_User
      {
         get{ return aRecord_User; }
         set{ aRecord_User = value; aRecord_User_IsChanged=true; }
      }
      /// <summary>
      /// 使用人
      /// </summary>
      public bool ARecord_User_IsChanged
      {
         get{ return aRecord_User_IsChanged; }
         set{ aRecord_User_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产使用部门
      /// </summary>
      private string aRecord_UseDeptCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_UseDeptCode_IsChanged=false;
      /// <summary>
      /// 固定资产使用部门
      /// </summary>
      public string ARecord_UseDeptCode
      {
         get{ return aRecord_UseDeptCode; }
         set{ aRecord_UseDeptCode = value; aRecord_UseDeptCode_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产使用部门
      /// </summary>
      public bool ARecord_UseDeptCode_IsChanged
      {
         get{ return aRecord_UseDeptCode_IsChanged; }
         set{ aRecord_UseDeptCode_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产使用部门
      /// </summary>
      private string aRecord_UseDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_UseDept_IsChanged=false;
      /// <summary>
      /// 固定资产使用部门
      /// </summary>
      public string ARecord_UseDept
      {
         get{ return aRecord_UseDept; }
         set{ aRecord_UseDept = value; aRecord_UseDept_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产使用部门
      /// </summary>
      public bool ARecord_UseDept_IsChanged
      {
         get{ return aRecord_UseDept_IsChanged; }
         set{ aRecord_UseDept_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产使用公司
      /// </summary>
      private string aRecord_UseCompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_UseCompanyCode_IsChanged=false;
      /// <summary>
      /// 固定资产使用公司
      /// </summary>
      public string ARecord_UseCompanyCode
      {
         get{ return aRecord_UseCompanyCode; }
         set{ aRecord_UseCompanyCode = value; aRecord_UseCompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产使用公司
      /// </summary>
      public bool ARecord_UseCompanyCode_IsChanged
      {
         get{ return aRecord_UseCompanyCode_IsChanged; }
         set{ aRecord_UseCompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产使用公司
      /// </summary>
      private string aRecord_UseCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_UseCompany_IsChanged=false;
      /// <summary>
      /// 固定资产使用公司
      /// </summary>
      public string ARecord_UseCompany
      {
         get{ return aRecord_UseCompany; }
         set{ aRecord_UseCompany = value; aRecord_UseCompany_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产使用公司
      /// </summary>
      public bool ARecord_UseCompany_IsChanged
      {
         get{ return aRecord_UseCompany_IsChanged; }
         set{ aRecord_UseCompany_IsChanged = value; }
      }
      /// <summary>
      /// 用途
      /// </summary>
      private string aRecord_Usage;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_Usage_IsChanged=false;
      /// <summary>
      /// 用途
      /// </summary>
      public string ARecord_Usage
      {
         get{ return aRecord_Usage; }
         set{ aRecord_Usage = value; aRecord_Usage_IsChanged=true; }
      }
      /// <summary>
      /// 用途
      /// </summary>
      public bool ARecord_Usage_IsChanged
      {
         get{ return aRecord_Usage_IsChanged; }
         set{ aRecord_Usage_IsChanged = value; }
      }
      /// <summary>
      /// 开始使用时间
      /// </summary>
      private DateTime aRecord_BeginDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_BeginDate_IsChanged=false;
      /// <summary>
      /// 开始使用时间
      /// </summary>
      public DateTime ARecord_BeginDate
      {
         get{ return aRecord_BeginDate; }
         set{ aRecord_BeginDate = value; aRecord_BeginDate_IsChanged=true; }
      }
      /// <summary>
      /// 开始使用时间
      /// </summary>
      public bool ARecord_BeginDate_IsChanged
      {
         get{ return aRecord_BeginDate_IsChanged; }
         set{ aRecord_BeginDate_IsChanged = value; }
      }
      /// <summary>
      /// 结束时间
      /// </summary>
      private DateTime aRecord_EndDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_EndDate_IsChanged=false;
      /// <summary>
      /// 结束时间
      /// </summary>
      public DateTime ARecord_EndDate
      {
         get{ return aRecord_EndDate; }
         set{ aRecord_EndDate = value; aRecord_EndDate_IsChanged=true; }
      }
      /// <summary>
      /// 结束时间
      /// </summary>
      public bool ARecord_EndDate_IsChanged
      {
         get{ return aRecord_EndDate_IsChanged; }
         set{ aRecord_EndDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string aRecord_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string ARecord_Remark
      {
         get{ return aRecord_Remark; }
         set{ aRecord_Remark = value; aRecord_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool ARecord_Remark_IsChanged
      {
         get{ return aRecord_Remark_IsChanged; }
         set{ aRecord_Remark_IsChanged = value; }
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
      /// <summary>
      /// 是否归还
      /// </summary>
      private string aRecord_IsReturn;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_IsReturn_IsChanged=false;
      /// <summary>
      /// 是否归还
      /// </summary>
      public string ARecord_IsReturn
      {
         get{ return aRecord_IsReturn; }
         set{ aRecord_IsReturn = value; aRecord_IsReturn_IsChanged=true; }
      }
      /// <summary>
      /// 是否归还
      /// </summary>
      public bool ARecord_IsReturn_IsChanged
      {
         get{ return aRecord_IsReturn_IsChanged; }
         set{ aRecord_IsReturn_IsChanged = value; }
      }
      /// <summary>
      /// 归还日期
      /// </summary>
      private DateTime aRecord_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_RDate_IsChanged=false;
      /// <summary>
      /// 归还日期
      /// </summary>
      public DateTime ARecord_RDate
      {
         get{ return aRecord_RDate; }
         set{ aRecord_RDate = value; aRecord_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 归还日期
      /// </summary>
      public bool ARecord_RDate_IsChanged
      {
         get{ return aRecord_RDate_IsChanged; }
         set{ aRecord_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 归还经手人
      /// </summary>
      private string aRecord_ROwnerName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_ROwnerName_IsChanged=false;
      /// <summary>
      /// 归还经手人
      /// </summary>
      public string ARecord_ROwnerName
      {
         get{ return aRecord_ROwnerName; }
         set{ aRecord_ROwnerName = value; aRecord_ROwnerName_IsChanged=true; }
      }
      /// <summary>
      /// 归还经手人
      /// </summary>
      public bool ARecord_ROwnerName_IsChanged
      {
         get{ return aRecord_ROwnerName_IsChanged; }
         set{ aRecord_ROwnerName_IsChanged = value; }
      }
      /// <summary>
      /// 归还备注
      /// </summary>
      private string aRecord_RBak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_RBak_IsChanged=false;
      /// <summary>
      /// 归还备注
      /// </summary>
      public string ARecord_RBak
      {
         get{ return aRecord_RBak; }
         set{ aRecord_RBak = value; aRecord_RBak_IsChanged=true; }
      }
      /// <summary>
      /// 归还备注
      /// </summary>
      public bool ARecord_RBak_IsChanged
      {
         get{ return aRecord_RBak_IsChanged; }
         set{ aRecord_RBak_IsChanged = value; }
      }
      /// <summary>
      /// 归还经手人编码
      /// </summary>
      private string aRecord_ROwnerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_ROwnerCode_IsChanged=false;
      /// <summary>
      /// 归还经手人编码
      /// </summary>
      public string ARecord_ROwnerCode
      {
         get{ return aRecord_ROwnerCode; }
         set{ aRecord_ROwnerCode = value; aRecord_ROwnerCode_IsChanged=true; }
      }
      /// <summary>
      /// 归还经手人编码
      /// </summary>
      public bool ARecord_ROwnerCode_IsChanged
      {
         get{ return aRecord_ROwnerCode_IsChanged; }
         set{ aRecord_ROwnerCode_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产名称
      /// </summary>
      private string aRecord_AName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_AName_IsChanged=false;
      /// <summary>
      /// 固定资产名称
      /// </summary>
      public string ARecord_AName
      {
         get{ return aRecord_AName; }
         set{ aRecord_AName = value; aRecord_AName_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产名称
      /// </summary>
      public bool ARecord_AName_IsChanged
      {
         get{ return aRecord_AName_IsChanged; }
         set{ aRecord_AName_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产规格型号
      /// </summary>
      private string aRecord_ASpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aRecord_ASpec_IsChanged=false;
      /// <summary>
      /// 固定资产规格型号
      /// </summary>
      public string ARecord_ASpec
      {
         get{ return aRecord_ASpec; }
         set{ aRecord_ASpec = value; aRecord_ASpec_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产规格型号
      /// </summary>
      public bool ARecord_ASpec_IsChanged
      {
         get{ return aRecord_ASpec_IsChanged; }
         set{ aRecord_ASpec_IsChanged = value; }
      }
   }
}
