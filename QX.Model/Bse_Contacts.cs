using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 联系人信息
   /// </summary>
   [Serializable]
   public partial class Bse_Contacts
   {
      /// <summary>
      /// 联系人序号
      /// </summary>
      private decimal bContact_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_ID_IsChanged=false;
      /// <summary>
      /// 联系人序号
      /// </summary>
      public decimal BContact_ID
      {
         get{ return bContact_ID; }
         set{ bContact_ID = value; bContact_ID_IsChanged=true; }
      }
      /// <summary>
      /// 联系人序号
      /// </summary>
      public bool BContact_ID_IsChanged
      {
         get{ return bContact_ID_IsChanged; }
         set{ bContact_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      private string module_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Code_IsChanged=false;
      /// <summary>
      /// 模块编码
      /// </summary>
      public string Module_Code
      {
         get{ return module_Code; }
         set{ module_Code = value; module_Code_IsChanged=true; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      public bool Module_Code_IsChanged
      {
         get{ return module_Code_IsChanged; }
         set{ module_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string record_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool record_ID_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string Record_ID
      {
         get{ return record_ID; }
         set{ record_ID = value; record_ID_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool Record_ID_IsChanged
      {
         get{ return record_ID_IsChanged; }
         set{ record_ID_IsChanged = value; }
      }
      /// <summary>
      /// 联系人姓名
      /// </summary>
      private string bContact_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Name_IsChanged=false;
      /// <summary>
      /// 联系人姓名
      /// </summary>
      public string BContact_Name
      {
         get{ return bContact_Name; }
         set{ bContact_Name = value; bContact_Name_IsChanged=true; }
      }
      /// <summary>
      /// 联系人姓名
      /// </summary>
      public bool BContact_Name_IsChanged
      {
         get{ return bContact_Name_IsChanged; }
         set{ bContact_Name_IsChanged = value; }
      }
      /// <summary>
      /// 联系人电话1
      /// </summary>
      private string bContact_Tel1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Tel1_IsChanged=false;
      /// <summary>
      /// 联系人电话1
      /// </summary>
      public string BContact_Tel1
      {
         get{ return bContact_Tel1; }
         set{ bContact_Tel1 = value; bContact_Tel1_IsChanged=true; }
      }
      /// <summary>
      /// 联系人电话1
      /// </summary>
      public bool BContact_Tel1_IsChanged
      {
         get{ return bContact_Tel1_IsChanged; }
         set{ bContact_Tel1_IsChanged = value; }
      }
      /// <summary>
      /// 联系人电话2
      /// </summary>
      private string bContact_Tel2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Tel2_IsChanged=false;
      /// <summary>
      /// 联系人电话2
      /// </summary>
      public string BContact_Tel2
      {
         get{ return bContact_Tel2; }
         set{ bContact_Tel2 = value; bContact_Tel2_IsChanged=true; }
      }
      /// <summary>
      /// 联系人电话2
      /// </summary>
      public bool BContact_Tel2_IsChanged
      {
         get{ return bContact_Tel2_IsChanged; }
         set{ bContact_Tel2_IsChanged = value; }
      }
      /// <summary>
      /// 联系人传真
      /// </summary>
      private string bContact_Fax;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Fax_IsChanged=false;
      /// <summary>
      /// 联系人传真
      /// </summary>
      public string BContact_Fax
      {
         get{ return bContact_Fax; }
         set{ bContact_Fax = value; bContact_Fax_IsChanged=true; }
      }
      /// <summary>
      /// 联系人传真
      /// </summary>
      public bool BContact_Fax_IsChanged
      {
         get{ return bContact_Fax_IsChanged; }
         set{ bContact_Fax_IsChanged = value; }
      }
      /// <summary>
      /// 联系人地址
      /// </summary>
      private string bContact_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Addr_IsChanged=false;
      /// <summary>
      /// 联系人地址
      /// </summary>
      public string BContact_Addr
      {
         get{ return bContact_Addr; }
         set{ bContact_Addr = value; bContact_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 联系人地址
      /// </summary>
      public bool BContact_Addr_IsChanged
      {
         get{ return bContact_Addr_IsChanged; }
         set{ bContact_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 联系人邮件
      /// </summary>
      private string bContact_Email;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Email_IsChanged=false;
      /// <summary>
      /// 联系人邮件
      /// </summary>
      public string BContact_Email
      {
         get{ return bContact_Email; }
         set{ bContact_Email = value; bContact_Email_IsChanged=true; }
      }
      /// <summary>
      /// 联系人邮件
      /// </summary>
      public bool BContact_Email_IsChanged
      {
         get{ return bContact_Email_IsChanged; }
         set{ bContact_Email_IsChanged = value; }
      }
      /// <summary>
      /// 职位
      /// </summary>
      private string bContact_Duty;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Duty_IsChanged=false;
      /// <summary>
      /// 职位
      /// </summary>
      public string BContact_Duty
      {
         get{ return bContact_Duty; }
         set{ bContact_Duty = value; bContact_Duty_IsChanged=true; }
      }
      /// <summary>
      /// 职位
      /// </summary>
      public bool BContact_Duty_IsChanged
      {
         get{ return bContact_Duty_IsChanged; }
         set{ bContact_Duty_IsChanged = value; }
      }
      /// <summary>
      /// 性别
      /// </summary>
      private string bContact_Gender;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Gender_IsChanged=false;
      /// <summary>
      /// 性别
      /// </summary>
      public string BContact_Gender
      {
         get{ return bContact_Gender; }
         set{ bContact_Gender = value; bContact_Gender_IsChanged=true; }
      }
      /// <summary>
      /// 性别
      /// </summary>
      public bool BContact_Gender_IsChanged
      {
         get{ return bContact_Gender_IsChanged; }
         set{ bContact_Gender_IsChanged = value; }
      }
      /// <summary>
      /// 职业
      /// </summary>
      private string bContact_Career;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Career_IsChanged=false;
      /// <summary>
      /// 职业
      /// </summary>
      public string BContact_Career
      {
         get{ return bContact_Career; }
         set{ bContact_Career = value; bContact_Career_IsChanged=true; }
      }
      /// <summary>
      /// 职业
      /// </summary>
      public bool BContact_Career_IsChanged
      {
         get{ return bContact_Career_IsChanged; }
         set{ bContact_Career_IsChanged = value; }
      }
      /// <summary>
      /// 出生日期
      /// </summary>
      private DateTime bContact_Birth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Birth_IsChanged=false;
      /// <summary>
      /// 出生日期
      /// </summary>
      public DateTime BContact_Birth
      {
         get{ return bContact_Birth; }
         set{ bContact_Birth = value; bContact_Birth_IsChanged=true; }
      }
      /// <summary>
      /// 出生日期
      /// </summary>
      public bool BContact_Birth_IsChanged
      {
         get{ return bContact_Birth_IsChanged; }
         set{ bContact_Birth_IsChanged = value; }
      }
      /// <summary>
      /// 出生地
      /// </summary>
      private string bContact_From;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_From_IsChanged=false;
      /// <summary>
      /// 出生地
      /// </summary>
      public string BContact_From
      {
         get{ return bContact_From; }
         set{ bContact_From = value; bContact_From_IsChanged=true; }
      }
      /// <summary>
      /// 出生地
      /// </summary>
      public bool BContact_From_IsChanged
      {
         get{ return bContact_From_IsChanged; }
         set{ bContact_From_IsChanged = value; }
      }
      /// <summary>
      /// 是否默认联系人
      /// </summary>
      private string bContact_IsDefault;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_IsDefault_IsChanged=false;
      /// <summary>
      /// 是否默认联系人
      /// </summary>
      public string BContact_IsDefault
      {
         get{ return bContact_IsDefault; }
         set{ bContact_IsDefault = value; bContact_IsDefault_IsChanged=true; }
      }
      /// <summary>
      /// 是否默认联系人
      /// </summary>
      public bool BContact_IsDefault_IsChanged
      {
         get{ return bContact_IsDefault_IsChanged; }
         set{ bContact_IsDefault_IsChanged = value; }
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
      /// 创建人
      /// </summary>
      private string creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool creator_IsChanged=false;
      /// <summary>
      /// 创建人
      /// </summary>
      public string Creator
      {
         get{ return creator; }
         set{ creator = value; creator_IsChanged=true; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      public bool Creator_IsChanged
      {
         get{ return creator_IsChanged; }
         set{ creator_IsChanged = value; }
      }
      /// <summary>
      /// 备注1
      /// </summary>
      private string bContact_Bak1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Bak1_IsChanged=false;
      /// <summary>
      /// 备注1
      /// </summary>
      public string BContact_Bak1
      {
         get{ return bContact_Bak1; }
         set{ bContact_Bak1 = value; bContact_Bak1_IsChanged=true; }
      }
      /// <summary>
      /// 备注1
      /// </summary>
      public bool BContact_Bak1_IsChanged
      {
         get{ return bContact_Bak1_IsChanged; }
         set{ bContact_Bak1_IsChanged = value; }
      }
      /// <summary>
      /// 备注2
      /// </summary>
      private string bContact_Bak2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bContact_Bak2_IsChanged=false;
      /// <summary>
      /// 备注2
      /// </summary>
      public string BContact_Bak2
      {
         get{ return bContact_Bak2; }
         set{ bContact_Bak2 = value; bContact_Bak2_IsChanged=true; }
      }
      /// <summary>
      /// 备注2
      /// </summary>
      public bool BContact_Bak2_IsChanged
      {
         get{ return bContact_Bak2_IsChanged; }
         set{ bContact_Bak2_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private string bContact_Code;
      private bool bContact_Code_IsChanged=false;
      public string BContact_Code
      {
         get{ return bContact_Code; }
         set{ bContact_Code = value; bContact_Code_IsChanged=true; }
      }
      public bool BContact_Code_IsChanged
      {
         get{ return bContact_Code_IsChanged; }
         set{ bContact_Code_IsChanged = value; }
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
   }
}
