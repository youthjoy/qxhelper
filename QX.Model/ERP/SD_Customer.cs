using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class SD_Customer
   {
      /// <summary>
      /// 客户序号
      /// </summary>
      private Int64 cust_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_ID_IsChanged=false;
      /// <summary>
      /// 客户序号
      /// </summary>
      public Int64 Cust_ID
      {
         get{ return cust_ID; }
         set{ cust_ID = value; cust_ID_IsChanged=true; }
      }
      /// <summary>
      /// 客户序号
      /// </summary>
      public bool Cust_ID_IsChanged
      {
         get{ return cust_ID_IsChanged; }
         set{ cust_ID_IsChanged = value; }
      }
      /// <summary>
      /// 客户编号
      /// </summary>
      private string cust_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Code_IsChanged=false;
      /// <summary>
      /// 客户编号
      /// </summary>
      public string Cust_Code
      {
         get{ return cust_Code; }
         set{ cust_Code = value; cust_Code_IsChanged=true; }
      }
      /// <summary>
      /// 客户编号
      /// </summary>
      public bool Cust_Code_IsChanged
      {
         get{ return cust_Code_IsChanged; }
         set{ cust_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string cust_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Name_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string Cust_Name
      {
         get{ return cust_Name; }
         set{ cust_Name = value; cust_Name_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool Cust_Name_IsChanged
      {
         get{ return cust_Name_IsChanged; }
         set{ cust_Name_IsChanged = value; }
      }
      /// <summary>
      /// 客户地址
      /// </summary>
      private string cust_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Addr_IsChanged=false;
      /// <summary>
      /// 客户地址
      /// </summary>
      public string Cust_Addr
      {
         get{ return cust_Addr; }
         set{ cust_Addr = value; cust_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 客户地址
      /// </summary>
      public bool Cust_Addr_IsChanged
      {
         get{ return cust_Addr_IsChanged; }
         set{ cust_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 常用联系方式
      /// </summary>
      private string cust_Contact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Contact_IsChanged=false;
      /// <summary>
      /// 常用联系方式
      /// </summary>
      public string Cust_Contact
      {
         get{ return cust_Contact; }
         set{ cust_Contact = value; cust_Contact_IsChanged=true; }
      }
      /// <summary>
      /// 常用联系方式
      /// </summary>
      public bool Cust_Contact_IsChanged
      {
         get{ return cust_Contact_IsChanged; }
         set{ cust_Contact_IsChanged = value; }
      }
      /// <summary>
      /// 主要联系人
      /// </summary>
      private string cust_COwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_COwner_IsChanged=false;
      /// <summary>
      /// 主要联系人
      /// </summary>
      public string Cust_COwner
      {
         get{ return cust_COwner; }
         set{ cust_COwner = value; cust_COwner_IsChanged=true; }
      }
      /// <summary>
      /// 主要联系人
      /// </summary>
      public bool Cust_COwner_IsChanged
      {
         get{ return cust_COwner_IsChanged; }
         set{ cust_COwner_IsChanged = value; }
      }
      /// <summary>
      /// 联系人座机
      /// </summary>
      private string cust_CTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_CTel_IsChanged=false;
      /// <summary>
      /// 联系人座机
      /// </summary>
      public string Cust_CTel
      {
         get{ return cust_CTel; }
         set{ cust_CTel = value; cust_CTel_IsChanged=true; }
      }
      /// <summary>
      /// 联系人座机
      /// </summary>
      public bool Cust_CTel_IsChanged
      {
         get{ return cust_CTel_IsChanged; }
         set{ cust_CTel_IsChanged = value; }
      }
      /// <summary>
      /// 联系人手机
      /// </summary>
      private string cust_CMobile;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_CMobile_IsChanged=false;
      /// <summary>
      /// 联系人手机
      /// </summary>
      public string Cust_CMobile
      {
         get{ return cust_CMobile; }
         set{ cust_CMobile = value; cust_CMobile_IsChanged=true; }
      }
      /// <summary>
      /// 联系人手机
      /// </summary>
      public bool Cust_CMobile_IsChanged
      {
         get{ return cust_CMobile_IsChanged; }
         set{ cust_CMobile_IsChanged = value; }
      }
      /// <summary>
      /// 联系邮件
      /// </summary>
      private string cust_CMail;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_CMail_IsChanged=false;
      /// <summary>
      /// 联系邮件
      /// </summary>
      public string Cust_CMail
      {
         get{ return cust_CMail; }
         set{ cust_CMail = value; cust_CMail_IsChanged=true; }
      }
      /// <summary>
      /// 联系邮件
      /// </summary>
      public bool Cust_CMail_IsChanged
      {
         get{ return cust_CMail_IsChanged; }
         set{ cust_CMail_IsChanged = value; }
      }
      /// <summary>
      /// 客户类别编码
      /// </summary>
      private string cust_TypeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_TypeCode_IsChanged=false;
      /// <summary>
      /// 客户类别编码
      /// </summary>
      public string Cust_TypeCode
      {
         get{ return cust_TypeCode; }
         set{ cust_TypeCode = value; cust_TypeCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户类别编码
      /// </summary>
      public bool Cust_TypeCode_IsChanged
      {
         get{ return cust_TypeCode_IsChanged; }
         set{ cust_TypeCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户类别名称
      /// </summary>
      private string cust_TypeName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_TypeName_IsChanged=false;
      /// <summary>
      /// 客户类别名称
      /// </summary>
      public string Cust_TypeName
      {
         get{ return cust_TypeName; }
         set{ cust_TypeName = value; cust_TypeName_IsChanged=true; }
      }
      /// <summary>
      /// 客户类别名称
      /// </summary>
      public bool Cust_TypeName_IsChanged
      {
         get{ return cust_TypeName_IsChanged; }
         set{ cust_TypeName_IsChanged = value; }
      }
      /// <summary>
      /// 录入人
      /// </summary>
      private string cust_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Owner_IsChanged=false;
      /// <summary>
      /// 录入人
      /// </summary>
      public string Cust_Owner
      {
         get{ return cust_Owner; }
         set{ cust_Owner = value; cust_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 录入人
      /// </summary>
      public bool Cust_Owner_IsChanged
      {
         get{ return cust_Owner_IsChanged; }
         set{ cust_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 录入时间
      /// </summary>
      private DateTime cust_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Date_IsChanged=false;
      /// <summary>
      /// 录入时间
      /// </summary>
      public DateTime Cust_Date
      {
         get{ return cust_Date; }
         set{ cust_Date = value; cust_Date_IsChanged=true; }
      }
      /// <summary>
      /// 录入时间
      /// </summary>
      public bool Cust_Date_IsChanged
      {
         get{ return cust_Date_IsChanged; }
         set{ cust_Date_IsChanged = value; }
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
      /// 客户类型
      /// </summary>
      private string cust_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cust_Type_IsChanged=false;
      /// <summary>
      /// 客户类型
      /// </summary>
      public string Cust_Type
      {
         get{ return cust_Type; }
         set{ cust_Type = value; cust_Type_IsChanged=true; }
      }
      /// <summary>
      /// 客户类型
      /// </summary>
      public bool Cust_Type_IsChanged
      {
         get{ return cust_Type_IsChanged; }
         set{ cust_Type_IsChanged = value; }
      }
   }
}
