using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 系统注册信息
   /// </summary>
   [Serializable]
   public partial class BSE_SysInfo
   {
      /// <summary>
      /// 系统ID
      /// </summary>
      private decimal sys_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_ID_IsChanged=false;
      /// <summary>
      /// 系统ID
      /// </summary>
      public decimal Sys_ID
      {
         get{ return sys_ID; }
         set{ sys_ID = value; sys_ID_IsChanged=true; }
      }
      /// <summary>
      /// 系统ID
      /// </summary>
      public bool Sys_ID_IsChanged
      {
         get{ return sys_ID_IsChanged; }
         set{ sys_ID_IsChanged = value; }
      }
      private string sys_Code;
      private bool sys_Code_IsChanged=false;
      public string Sys_Code
      {
         get{ return sys_Code; }
         set{ sys_Code = value; sys_Code_IsChanged=true; }
      }
      public bool Sys_Code_IsChanged
      {
         get{ return sys_Code_IsChanged; }
         set{ sys_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单位名称
      /// </summary>
      private string sys_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_CName_IsChanged=false;
      /// <summary>
      /// 单位名称
      /// </summary>
      public string Sys_CName
      {
         get{ return sys_CName; }
         set{ sys_CName = value; sys_CName_IsChanged=true; }
      }
      /// <summary>
      /// 单位名称
      /// </summary>
      public bool Sys_CName_IsChanged
      {
         get{ return sys_CName_IsChanged; }
         set{ sys_CName_IsChanged = value; }
      }
      /// <summary>
      /// 系统名称
      /// </summary>
      private string sys_CSName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_CSName_IsChanged=false;
      /// <summary>
      /// 系统名称
      /// </summary>
      public string Sys_CSName
      {
         get{ return sys_CSName; }
         set{ sys_CSName = value; sys_CSName_IsChanged=true; }
      }
      /// <summary>
      /// 系统名称
      /// </summary>
      public bool Sys_CSName_IsChanged
      {
         get{ return sys_CSName_IsChanged; }
         set{ sys_CSName_IsChanged = value; }
      }
      /// <summary>
      /// 单位简称
      /// </summary>
      private string sys_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_SName_IsChanged=false;
      /// <summary>
      /// 单位简称
      /// </summary>
      public string Sys_SName
      {
         get{ return sys_SName; }
         set{ sys_SName = value; sys_SName_IsChanged=true; }
      }
      /// <summary>
      /// 单位简称
      /// </summary>
      public bool Sys_SName_IsChanged
      {
         get{ return sys_SName_IsChanged; }
         set{ sys_SName_IsChanged = value; }
      }
      /// <summary>
      /// 法人代表
      /// </summary>
      private string sys_COwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_COwner_IsChanged=false;
      /// <summary>
      /// 法人代表
      /// </summary>
      public string Sys_COwner
      {
         get{ return sys_COwner; }
         set{ sys_COwner = value; sys_COwner_IsChanged=true; }
      }
      /// <summary>
      /// 法人代表
      /// </summary>
      public bool Sys_COwner_IsChanged
      {
         get{ return sys_COwner_IsChanged; }
         set{ sys_COwner_IsChanged = value; }
      }
      /// <summary>
      /// 隶属单位
      /// </summary>
      private string sys_OCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_OCompany_IsChanged=false;
      /// <summary>
      /// 隶属单位
      /// </summary>
      public string Sys_OCompany
      {
         get{ return sys_OCompany; }
         set{ sys_OCompany = value; sys_OCompany_IsChanged=true; }
      }
      /// <summary>
      /// 隶属单位
      /// </summary>
      public bool Sys_OCompany_IsChanged
      {
         get{ return sys_OCompany_IsChanged; }
         set{ sys_OCompany_IsChanged = value; }
      }
      /// <summary>
      /// 单位性质
      /// </summary>
      private string sys_CCategory;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_CCategory_IsChanged=false;
      /// <summary>
      /// 单位性质
      /// </summary>
      public string Sys_CCategory
      {
         get{ return sys_CCategory; }
         set{ sys_CCategory = value; sys_CCategory_IsChanged=true; }
      }
      /// <summary>
      /// 单位性质
      /// </summary>
      public bool Sys_CCategory_IsChanged
      {
         get{ return sys_CCategory_IsChanged; }
         set{ sys_CCategory_IsChanged = value; }
      }
      /// <summary>
      /// 行业性质
      /// </summary>
      private string sys_CType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_CType_IsChanged=false;
      /// <summary>
      /// 行业性质
      /// </summary>
      public string Sys_CType
      {
         get{ return sys_CType; }
         set{ sys_CType = value; sys_CType_IsChanged=true; }
      }
      /// <summary>
      /// 行业性质
      /// </summary>
      public bool Sys_CType_IsChanged
      {
         get{ return sys_CType_IsChanged; }
         set{ sys_CType_IsChanged = value; }
      }
      /// <summary>
      /// 所在省
      /// </summary>
      private string sys_Province;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Province_IsChanged=false;
      /// <summary>
      /// 所在省
      /// </summary>
      public string Sys_Province
      {
         get{ return sys_Province; }
         set{ sys_Province = value; sys_Province_IsChanged=true; }
      }
      /// <summary>
      /// 所在省
      /// </summary>
      public bool Sys_Province_IsChanged
      {
         get{ return sys_Province_IsChanged; }
         set{ sys_Province_IsChanged = value; }
      }
      /// <summary>
      /// 所在市
      /// </summary>
      private string sys_City;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_City_IsChanged=false;
      /// <summary>
      /// 所在市
      /// </summary>
      public string Sys_City
      {
         get{ return sys_City; }
         set{ sys_City = value; sys_City_IsChanged=true; }
      }
      /// <summary>
      /// 所在市
      /// </summary>
      public bool Sys_City_IsChanged
      {
         get{ return sys_City_IsChanged; }
         set{ sys_City_IsChanged = value; }
      }
      /// <summary>
      /// 详细地址
      /// </summary>
      private string sys_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Addr_IsChanged=false;
      /// <summary>
      /// 详细地址
      /// </summary>
      public string Sys_Addr
      {
         get{ return sys_Addr; }
         set{ sys_Addr = value; sys_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 详细地址
      /// </summary>
      public bool Sys_Addr_IsChanged
      {
         get{ return sys_Addr_IsChanged; }
         set{ sys_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 邮政编码
      /// </summary>
      private string sys_PostCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_PostCode_IsChanged=false;
      /// <summary>
      /// 邮政编码
      /// </summary>
      public string Sys_PostCode
      {
         get{ return sys_PostCode; }
         set{ sys_PostCode = value; sys_PostCode_IsChanged=true; }
      }
      /// <summary>
      /// 邮政编码
      /// </summary>
      public bool Sys_PostCode_IsChanged
      {
         get{ return sys_PostCode_IsChanged; }
         set{ sys_PostCode_IsChanged = value; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      private string sys_Tel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Tel_IsChanged=false;
      /// <summary>
      /// 联系电话
      /// </summary>
      public string Sys_Tel
      {
         get{ return sys_Tel; }
         set{ sys_Tel = value; sys_Tel_IsChanged=true; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      public bool Sys_Tel_IsChanged
      {
         get{ return sys_Tel_IsChanged; }
         set{ sys_Tel_IsChanged = value; }
      }
      /// <summary>
      /// 传真
      /// </summary>
      private string sys_Fax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Fax_IsChanged=false;
      /// <summary>
      /// 传真
      /// </summary>
      public string Sys_Fax
      {
         get{ return sys_Fax; }
         set{ sys_Fax = value; sys_Fax_IsChanged=true; }
      }
      /// <summary>
      /// 传真
      /// </summary>
      public bool Sys_Fax_IsChanged
      {
         get{ return sys_Fax_IsChanged; }
         set{ sys_Fax_IsChanged = value; }
      }
      /// <summary>
      /// 电子邮件
      /// </summary>
      private string sys_Email;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Email_IsChanged=false;
      /// <summary>
      /// 电子邮件
      /// </summary>
      public string Sys_Email
      {
         get{ return sys_Email; }
         set{ sys_Email = value; sys_Email_IsChanged=true; }
      }
      /// <summary>
      /// 电子邮件
      /// </summary>
      public bool Sys_Email_IsChanged
      {
         get{ return sys_Email_IsChanged; }
         set{ sys_Email_IsChanged = value; }
      }
      /// <summary>
      /// 开户银行
      /// </summary>
      private string sys_BankName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_BankName_IsChanged=false;
      /// <summary>
      /// 开户银行
      /// </summary>
      public string Sys_BankName
      {
         get{ return sys_BankName; }
         set{ sys_BankName = value; sys_BankName_IsChanged=true; }
      }
      /// <summary>
      /// 开户银行
      /// </summary>
      public bool Sys_BankName_IsChanged
      {
         get{ return sys_BankName_IsChanged; }
         set{ sys_BankName_IsChanged = value; }
      }
      /// <summary>
      /// 银行帐号
      /// </summary>
      private string sys_BankAcc;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_BankAcc_IsChanged=false;
      /// <summary>
      /// 银行帐号
      /// </summary>
      public string Sys_BankAcc
      {
         get{ return sys_BankAcc; }
         set{ sys_BankAcc = value; sys_BankAcc_IsChanged=true; }
      }
      /// <summary>
      /// 银行帐号
      /// </summary>
      public bool Sys_BankAcc_IsChanged
      {
         get{ return sys_BankAcc_IsChanged; }
         set{ sys_BankAcc_IsChanged = value; }
      }
      /// <summary>
      /// 纳税号
      /// </summary>
      private string sys_Tax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sys_Tax_IsChanged=false;
      /// <summary>
      /// 纳税号
      /// </summary>
      public string Sys_Tax
      {
         get{ return sys_Tax; }
         set{ sys_Tax = value; sys_Tax_IsChanged=true; }
      }
      /// <summary>
      /// 纳税号
      /// </summary>
      public bool Sys_Tax_IsChanged
      {
         get{ return sys_Tax_IsChanged; }
         set{ sys_Tax_IsChanged = value; }
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
   }
}
