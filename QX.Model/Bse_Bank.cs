using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 银行信息
   /// </summary>
   [Serializable]
   public partial class Bse_Bank
   {
      /// <summary>
      /// 银行序号
      /// </summary>
      private decimal bank_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bank_ID_IsChanged=false;
      /// <summary>
      /// 银行序号
      /// </summary>
      public decimal Bank_ID
      {
         get{ return bank_ID; }
         set{ bank_ID = value; bank_ID_IsChanged=true; }
      }
      /// <summary>
      /// 银行序号
      /// </summary>
      public bool Bank_ID_IsChanged
      {
         get{ return bank_ID_IsChanged; }
         set{ bank_ID_IsChanged = value; }
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
      /// 银行编码
      /// </summary>
      private string bank_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bank_Code_IsChanged=false;
      /// <summary>
      /// 银行编码
      /// </summary>
      public string Bank_Code
      {
         get{ return bank_Code; }
         set{ bank_Code = value; bank_Code_IsChanged=true; }
      }
      /// <summary>
      /// 银行编码
      /// </summary>
      public bool Bank_Code_IsChanged
      {
         get{ return bank_Code_IsChanged; }
         set{ bank_Code_IsChanged = value; }
      }
      /// <summary>
      /// 银行名称
      /// </summary>
      private string bank_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bank_Name_IsChanged=false;
      /// <summary>
      /// 银行名称
      /// </summary>
      public string Bank_Name
      {
         get{ return bank_Name; }
         set{ bank_Name = value; bank_Name_IsChanged=true; }
      }
      /// <summary>
      /// 银行名称
      /// </summary>
      public bool Bank_Name_IsChanged
      {
         get{ return bank_Name_IsChanged; }
         set{ bank_Name_IsChanged = value; }
      }
      /// <summary>
      /// 支行地址
      /// </summary>
      private string bank_Branch;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bank_Branch_IsChanged=false;
      /// <summary>
      /// 支行地址
      /// </summary>
      public string Bank_Branch
      {
         get{ return bank_Branch; }
         set{ bank_Branch = value; bank_Branch_IsChanged=true; }
      }
      /// <summary>
      /// 支行地址
      /// </summary>
      public bool Bank_Branch_IsChanged
      {
         get{ return bank_Branch_IsChanged; }
         set{ bank_Branch_IsChanged = value; }
      }
      /// <summary>
      /// 银行帐号
      /// </summary>
      private string bank_Card;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bank_Card_IsChanged=false;
      /// <summary>
      /// 银行帐号
      /// </summary>
      public string Bank_Card
      {
         get{ return bank_Card; }
         set{ bank_Card = value; bank_Card_IsChanged=true; }
      }
      /// <summary>
      /// 银行帐号
      /// </summary>
      public bool Bank_Card_IsChanged
      {
         get{ return bank_Card_IsChanged; }
         set{ bank_Card_IsChanged = value; }
      }
      /// <summary>
      /// 银行户主
      /// </summary>
      private string bank_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bank_User_IsChanged=false;
      /// <summary>
      /// 银行户主
      /// </summary>
      public string Bank_User
      {
         get{ return bank_User; }
         set{ bank_User = value; bank_User_IsChanged=true; }
      }
      /// <summary>
      /// 银行户主
      /// </summary>
      public bool Bank_User_IsChanged
      {
         get{ return bank_User_IsChanged; }
         set{ bank_User_IsChanged = value; }
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
      private string bank_BranchName;
      private bool bank_BranchName_IsChanged=false;
      public string Bank_BranchName
      {
         get{ return bank_BranchName; }
         set{ bank_BranchName = value; bank_BranchName_IsChanged=true; }
      }
      public bool Bank_BranchName_IsChanged
      {
         get{ return bank_BranchName_IsChanged; }
         set{ bank_BranchName_IsChanged = value; }
      }
   }
}
