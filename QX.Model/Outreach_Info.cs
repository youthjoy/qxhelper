using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 外联单位管理
   /// </summary>
   [Serializable]
   public partial class Outreach_Info
   {
      /// <summary>
      /// 外联单位信息序号
      /// </summary>
      private decimal oI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_ID_IsChanged=false;
      /// <summary>
      /// 外联单位信息序号
      /// </summary>
      public decimal OI_ID
      {
         get{ return oI_ID; }
         set{ oI_ID = value; oI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 外联单位信息序号
      /// </summary>
      public bool OI_ID_IsChanged
      {
         get{ return oI_ID_IsChanged; }
         set{ oI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 外联单位信息编码
      /// </summary>
      private string oI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Code_IsChanged=false;
      /// <summary>
      /// 外联单位信息编码
      /// </summary>
      public string OI_Code
      {
         get{ return oI_Code; }
         set{ oI_Code = value; oI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 外联单位信息编码
      /// </summary>
      public bool OI_Code_IsChanged
      {
         get{ return oI_Code_IsChanged; }
         set{ oI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单位名称
      /// </summary>
      private string oI_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Name_IsChanged=false;
      /// <summary>
      /// 单位名称
      /// </summary>
      public string OI_Name
      {
         get{ return oI_Name; }
         set{ oI_Name = value; oI_Name_IsChanged=true; }
      }
      /// <summary>
      /// 单位名称
      /// </summary>
      public bool OI_Name_IsChanged
      {
         get{ return oI_Name_IsChanged; }
         set{ oI_Name_IsChanged = value; }
      }
      /// <summary>
      /// 单位地址
      /// </summary>
      private string oI_Address;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Address_IsChanged=false;
      /// <summary>
      /// 单位地址
      /// </summary>
      public string OI_Address
      {
         get{ return oI_Address; }
         set{ oI_Address = value; oI_Address_IsChanged=true; }
      }
      /// <summary>
      /// 单位地址
      /// </summary>
      public bool OI_Address_IsChanged
      {
         get{ return oI_Address_IsChanged; }
         set{ oI_Address_IsChanged = value; }
      }
      /// <summary>
      /// 单位联系电话
      /// </summary>
      private string oI_Telephone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Telephone_IsChanged=false;
      /// <summary>
      /// 单位联系电话
      /// </summary>
      public string OI_Telephone
      {
         get{ return oI_Telephone; }
         set{ oI_Telephone = value; oI_Telephone_IsChanged=true; }
      }
      /// <summary>
      /// 单位联系电话
      /// </summary>
      public bool OI_Telephone_IsChanged
      {
         get{ return oI_Telephone_IsChanged; }
         set{ oI_Telephone_IsChanged = value; }
      }
      /// <summary>
      /// 单位类型
      /// </summary>
      private string oI_CompanyType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_CompanyType_IsChanged=false;
      /// <summary>
      /// 单位类型
      /// </summary>
      public string OI_CompanyType
      {
         get{ return oI_CompanyType; }
         set{ oI_CompanyType = value; oI_CompanyType_IsChanged=true; }
      }
      /// <summary>
      /// 单位类型
      /// </summary>
      public bool OI_CompanyType_IsChanged
      {
         get{ return oI_CompanyType_IsChanged; }
         set{ oI_CompanyType_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string oI_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string OI_iType
      {
         get{ return oI_iType; }
         set{ oI_iType = value; oI_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool OI_iType_IsChanged
      {
         get{ return oI_iType_IsChanged; }
         set{ oI_iType_IsChanged = value; }
      }
      /// <summary>
      /// 主要联系人
      /// </summary>
      private string oI_MainContactor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_MainContactor_IsChanged=false;
      /// <summary>
      /// 主要联系人
      /// </summary>
      public string OI_MainContactor
      {
         get{ return oI_MainContactor; }
         set{ oI_MainContactor = value; oI_MainContactor_IsChanged=true; }
      }
      /// <summary>
      /// 主要联系人
      /// </summary>
      public bool OI_MainContactor_IsChanged
      {
         get{ return oI_MainContactor_IsChanged; }
         set{ oI_MainContactor_IsChanged = value; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      private string oI_ContactPhone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_ContactPhone_IsChanged=false;
      /// <summary>
      /// 联系电话
      /// </summary>
      public string OI_ContactPhone
      {
         get{ return oI_ContactPhone; }
         set{ oI_ContactPhone = value; oI_ContactPhone_IsChanged=true; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      public bool OI_ContactPhone_IsChanged
      {
         get{ return oI_ContactPhone_IsChanged; }
         set{ oI_ContactPhone_IsChanged = value; }
      }
      /// <summary>
      /// 联系人
      /// </summary>
      private string oI_Contactor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Contactor_IsChanged=false;
      /// <summary>
      /// 联系人
      /// </summary>
      public string OI_Contactor
      {
         get{ return oI_Contactor; }
         set{ oI_Contactor = value; oI_Contactor_IsChanged=true; }
      }
      /// <summary>
      /// 联系人
      /// </summary>
      public bool OI_Contactor_IsChanged
      {
         get{ return oI_Contactor_IsChanged; }
         set{ oI_Contactor_IsChanged = value; }
      }
      /// <summary>
      /// 附件
      /// </summary>
      private string ol_Attachment;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool ol_Attachment_IsChanged=false;
      /// <summary>
      /// 附件
      /// </summary>
      public string Ol_Attachment
      {
         get{ return ol_Attachment; }
         set{ ol_Attachment = value; ol_Attachment_IsChanged=true; }
      }
      /// <summary>
      /// 附件
      /// </summary>
      public bool Ol_Attachment_IsChanged
      {
         get{ return ol_Attachment_IsChanged; }
         set{ ol_Attachment_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string oI_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string OI_Remark
      {
         get{ return oI_Remark; }
         set{ oI_Remark = value; oI_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool OI_Remark_IsChanged
      {
         get{ return oI_Remark_IsChanged; }
         set{ oI_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 所属单位
      /// </summary>
      private string oI_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Company_IsChanged=false;
      /// <summary>
      /// 所属单位
      /// </summary>
      public string OI_Company
      {
         get{ return oI_Company; }
         set{ oI_Company = value; oI_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属单位
      /// </summary>
      public bool OI_Company_IsChanged
      {
         get{ return oI_Company_IsChanged; }
         set{ oI_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string oI_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oI_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string OI_Dept
      {
         get{ return oI_Dept; }
         set{ oI_Dept = value; oI_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool OI_Dept_IsChanged
      {
         get{ return oI_Dept_IsChanged; }
         set{ oI_Dept_IsChanged = value; }
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
