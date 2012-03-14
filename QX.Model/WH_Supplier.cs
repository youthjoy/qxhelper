using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 供应商信息
   /// </summary>
   [Serializable]
   public partial class WH_Supplier
   {
      /// <summary>
      /// 供应商序号
      /// </summary>
      private decimal wHS_IDS;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_IDS_IsChanged=false;
      /// <summary>
      /// 供应商序号
      /// </summary>
      public decimal WHS_IDS
      {
         get{ return wHS_IDS; }
         set{ wHS_IDS = value; wHS_IDS_IsChanged=true; }
      }
      /// <summary>
      /// 供应商序号
      /// </summary>
      public bool WHS_IDS_IsChanged
      {
         get{ return wHS_IDS_IsChanged; }
         set{ wHS_IDS_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string wHS_CustCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_CustCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string WHS_CustCode
      {
         get{ return wHS_CustCode; }
         set{ wHS_CustCode = value; wHS_CustCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool WHS_CustCode_IsChanged
      {
         get{ return wHS_CustCode_IsChanged; }
         set{ wHS_CustCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string wHS_CustName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_CustName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string WHS_CustName
      {
         get{ return wHS_CustName; }
         set{ wHS_CustName = value; wHS_CustName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool WHS_CustName_IsChanged
      {
         get{ return wHS_CustName_IsChanged; }
         set{ wHS_CustName_IsChanged = value; }
      }
      private string wHS_Group;
      private bool wHS_Group_IsChanged=false;
      public string WHS_Group
      {
         get{ return wHS_Group; }
         set{ wHS_Group = value; wHS_Group_IsChanged=true; }
      }
      public bool WHS_Group_IsChanged
      {
         get{ return wHS_Group_IsChanged; }
         set{ wHS_Group_IsChanged = value; }
      }
      /// <summary>
      /// 供应商性质
      /// </summary>
      private string wHS_Property;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Property_IsChanged=false;
      /// <summary>
      /// 供应商性质
      /// </summary>
      public string WHS_Property
      {
         get{ return wHS_Property; }
         set{ wHS_Property = value; wHS_Property_IsChanged=true; }
      }
      /// <summary>
      /// 供应商性质
      /// </summary>
      public bool WHS_Property_IsChanged
      {
         get{ return wHS_Property_IsChanged; }
         set{ wHS_Property_IsChanged = value; }
      }
      /// <summary>
      /// 供应商资质
      /// </summary>
      private string wHS_Aptitude;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Aptitude_IsChanged=false;
      /// <summary>
      /// 供应商资质
      /// </summary>
      public string WHS_Aptitude
      {
         get{ return wHS_Aptitude; }
         set{ wHS_Aptitude = value; wHS_Aptitude_IsChanged=true; }
      }
      /// <summary>
      /// 供应商资质
      /// </summary>
      public bool WHS_Aptitude_IsChanged
      {
         get{ return wHS_Aptitude_IsChanged; }
         set{ wHS_Aptitude_IsChanged = value; }
      }
      /// <summary>
      /// 法人代表
      /// </summary>
      private string wHS_LegalPerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_LegalPerson_IsChanged=false;
      /// <summary>
      /// 法人代表
      /// </summary>
      public string WHS_LegalPerson
      {
         get{ return wHS_LegalPerson; }
         set{ wHS_LegalPerson = value; wHS_LegalPerson_IsChanged=true; }
      }
      /// <summary>
      /// 法人代表
      /// </summary>
      public bool WHS_LegalPerson_IsChanged
      {
         get{ return wHS_LegalPerson_IsChanged; }
         set{ wHS_LegalPerson_IsChanged = value; }
      }
      /// <summary>
      /// 联系人
      /// </summary>
      private string wHS_ContactPerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_ContactPerson_IsChanged=false;
      /// <summary>
      /// 联系人
      /// </summary>
      public string WHS_ContactPerson
      {
         get{ return wHS_ContactPerson; }
         set{ wHS_ContactPerson = value; wHS_ContactPerson_IsChanged=true; }
      }
      /// <summary>
      /// 联系人
      /// </summary>
      public bool WHS_ContactPerson_IsChanged
      {
         get{ return wHS_ContactPerson_IsChanged; }
         set{ wHS_ContactPerson_IsChanged = value; }
      }
      /// <summary>
      /// 座机
      /// </summary>
      private string wHS_Telphone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Telphone_IsChanged=false;
      /// <summary>
      /// 座机
      /// </summary>
      public string WHS_Telphone
      {
         get{ return wHS_Telphone; }
         set{ wHS_Telphone = value; wHS_Telphone_IsChanged=true; }
      }
      /// <summary>
      /// 座机
      /// </summary>
      public bool WHS_Telphone_IsChanged
      {
         get{ return wHS_Telphone_IsChanged; }
         set{ wHS_Telphone_IsChanged = value; }
      }
      /// <summary>
      /// 手机
      /// </summary>
      private string wHS_MobilePhone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_MobilePhone_IsChanged=false;
      /// <summary>
      /// 手机
      /// </summary>
      public string WHS_MobilePhone
      {
         get{ return wHS_MobilePhone; }
         set{ wHS_MobilePhone = value; wHS_MobilePhone_IsChanged=true; }
      }
      /// <summary>
      /// 手机
      /// </summary>
      public bool WHS_MobilePhone_IsChanged
      {
         get{ return wHS_MobilePhone_IsChanged; }
         set{ wHS_MobilePhone_IsChanged = value; }
      }
      /// <summary>
      /// 传真
      /// </summary>
      private string wHS_Fax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Fax_IsChanged=false;
      /// <summary>
      /// 传真
      /// </summary>
      public string WHS_Fax
      {
         get{ return wHS_Fax; }
         set{ wHS_Fax = value; wHS_Fax_IsChanged=true; }
      }
      /// <summary>
      /// 传真
      /// </summary>
      public bool WHS_Fax_IsChanged
      {
         get{ return wHS_Fax_IsChanged; }
         set{ wHS_Fax_IsChanged = value; }
      }
      /// <summary>
      /// 电子邮件
      /// </summary>
      private string wHS_Email;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Email_IsChanged=false;
      /// <summary>
      /// 电子邮件
      /// </summary>
      public string WHS_Email
      {
         get{ return wHS_Email; }
         set{ wHS_Email = value; wHS_Email_IsChanged=true; }
      }
      /// <summary>
      /// 电子邮件
      /// </summary>
      public bool WHS_Email_IsChanged
      {
         get{ return wHS_Email_IsChanged; }
         set{ wHS_Email_IsChanged = value; }
      }
      /// <summary>
      /// 供应商网址
      /// </summary>
      private string wHS_Site;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Site_IsChanged=false;
      /// <summary>
      /// 供应商网址
      /// </summary>
      public string WHS_Site
      {
         get{ return wHS_Site; }
         set{ wHS_Site = value; wHS_Site_IsChanged=true; }
      }
      /// <summary>
      /// 供应商网址
      /// </summary>
      public bool WHS_Site_IsChanged
      {
         get{ return wHS_Site_IsChanged; }
         set{ wHS_Site_IsChanged = value; }
      }
      /// <summary>
      /// 邮编
      /// </summary>
      private string wHS_ZipCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_ZipCode_IsChanged=false;
      /// <summary>
      /// 邮编
      /// </summary>
      public string WHS_ZipCode
      {
         get{ return wHS_ZipCode; }
         set{ wHS_ZipCode = value; wHS_ZipCode_IsChanged=true; }
      }
      /// <summary>
      /// 邮编
      /// </summary>
      public bool WHS_ZipCode_IsChanged
      {
         get{ return wHS_ZipCode_IsChanged; }
         set{ wHS_ZipCode_IsChanged = value; }
      }
      /// <summary>
      /// 介绍
      /// </summary>
      private string wHS_Introduction;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Introduction_IsChanged=false;
      /// <summary>
      /// 介绍
      /// </summary>
      public string WHS_Introduction
      {
         get{ return wHS_Introduction; }
         set{ wHS_Introduction = value; wHS_Introduction_IsChanged=true; }
      }
      /// <summary>
      /// 介绍
      /// </summary>
      public bool WHS_Introduction_IsChanged
      {
         get{ return wHS_Introduction_IsChanged; }
         set{ wHS_Introduction_IsChanged = value; }
      }
      private string wHS_iType;
      private bool wHS_iType_IsChanged=false;
      public string WHS_iType
      {
         get{ return wHS_iType; }
         set{ wHS_iType = value; wHS_iType_IsChanged=true; }
      }
      public bool WHS_iType_IsChanged
      {
         get{ return wHS_iType_IsChanged; }
         set{ wHS_iType_IsChanged = value; }
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
      /// <summary>
      /// 注册资本
      /// </summary>
      private string wHS_Capital;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Capital_IsChanged=false;
      /// <summary>
      /// 注册资本
      /// </summary>
      public string WHS_Capital
      {
         get{ return wHS_Capital; }
         set{ wHS_Capital = value; wHS_Capital_IsChanged=true; }
      }
      /// <summary>
      /// 注册资本
      /// </summary>
      public bool WHS_Capital_IsChanged
      {
         get{ return wHS_Capital_IsChanged; }
         set{ wHS_Capital_IsChanged = value; }
      }
      /// <summary>
      /// 税号
      /// </summary>
      private string wHS_Levy;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Levy_IsChanged=false;
      /// <summary>
      /// 税号
      /// </summary>
      public string WHS_Levy
      {
         get{ return wHS_Levy; }
         set{ wHS_Levy = value; wHS_Levy_IsChanged=true; }
      }
      /// <summary>
      /// 税号
      /// </summary>
      public bool WHS_Levy_IsChanged
      {
         get{ return wHS_Levy_IsChanged; }
         set{ wHS_Levy_IsChanged = value; }
      }
      /// <summary>
      /// 供应商单位名称
      /// </summary>
      private string wHS_UName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_UName_IsChanged=false;
      /// <summary>
      /// 供应商单位名称
      /// </summary>
      public string WHS_UName
      {
         get{ return wHS_UName; }
         set{ wHS_UName = value; wHS_UName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商单位名称
      /// </summary>
      public bool WHS_UName_IsChanged
      {
         get{ return wHS_UName_IsChanged; }
         set{ wHS_UName_IsChanged = value; }
      }
      /// <summary>
      /// 注册地址
      /// </summary>
      private string wHS_Raddress;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Raddress_IsChanged=false;
      /// <summary>
      /// 注册地址
      /// </summary>
      public string WHS_Raddress
      {
         get{ return wHS_Raddress; }
         set{ wHS_Raddress = value; wHS_Raddress_IsChanged=true; }
      }
      /// <summary>
      /// 注册地址
      /// </summary>
      public bool WHS_Raddress_IsChanged
      {
         get{ return wHS_Raddress_IsChanged; }
         set{ wHS_Raddress_IsChanged = value; }
      }
      /// <summary>
      /// 执照开始时间
      /// </summary>
      private DateTime wHS_RBegin;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_RBegin_IsChanged=false;
      /// <summary>
      /// 执照开始时间
      /// </summary>
      public DateTime WHS_RBegin
      {
         get{ return wHS_RBegin; }
         set{ wHS_RBegin = value; wHS_RBegin_IsChanged=true; }
      }
      /// <summary>
      /// 执照开始时间
      /// </summary>
      public bool WHS_RBegin_IsChanged
      {
         get{ return wHS_RBegin_IsChanged; }
         set{ wHS_RBegin_IsChanged = value; }
      }
      /// <summary>
      /// 执照结束时间
      /// </summary>
      private DateTime wHS_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_End_IsChanged=false;
      /// <summary>
      /// 执照结束时间
      /// </summary>
      public DateTime WHS_End
      {
         get{ return wHS_End; }
         set{ wHS_End = value; wHS_End_IsChanged=true; }
      }
      /// <summary>
      /// 执照结束时间
      /// </summary>
      public bool WHS_End_IsChanged
      {
         get{ return wHS_End_IsChanged; }
         set{ wHS_End_IsChanged = value; }
      }
      /// <summary>
      /// 税务登记号
      /// </summary>
      private string wHS_Taxroar;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Taxroar_IsChanged=false;
      /// <summary>
      /// 税务登记号
      /// </summary>
      public string WHS_Taxroar
      {
         get{ return wHS_Taxroar; }
         set{ wHS_Taxroar = value; wHS_Taxroar_IsChanged=true; }
      }
      /// <summary>
      /// 税务登记号
      /// </summary>
      public bool WHS_Taxroar_IsChanged
      {
         get{ return wHS_Taxroar_IsChanged; }
         set{ wHS_Taxroar_IsChanged = value; }
      }
      /// <summary>
      /// 信用等级
      /// </summary>
      private string wHS_Cdegree;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHS_Cdegree_IsChanged=false;
      /// <summary>
      /// 信用等级
      /// </summary>
      public string WHS_Cdegree
      {
         get{ return wHS_Cdegree; }
         set{ wHS_Cdegree = value; wHS_Cdegree_IsChanged=true; }
      }
      /// <summary>
      /// 信用等级
      /// </summary>
      public bool WHS_Cdegree_IsChanged
      {
         get{ return wHS_Cdegree_IsChanged; }
         set{ wHS_Cdegree_IsChanged = value; }
      }
   }
}
