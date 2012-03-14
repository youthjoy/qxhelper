using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_Address
   {
      /// <summary>
      /// 地址信息序号
      /// </summary>
      private decimal bAddress_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_ID_IsChanged=false;
      /// <summary>
      /// 地址信息序号
      /// </summary>
      public decimal BAddress_ID
      {
         get{ return bAddress_ID; }
         set{ bAddress_ID = value; bAddress_ID_IsChanged=true; }
      }
      /// <summary>
      /// 地址信息序号
      /// </summary>
      public bool BAddress_ID_IsChanged
      {
         get{ return bAddress_ID_IsChanged; }
         set{ bAddress_ID_IsChanged = value; }
      }
      /// <summary>
      /// 地址信息编码
      /// </summary>
      private string bAddress_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Code_IsChanged=false;
      /// <summary>
      /// 地址信息编码
      /// </summary>
      public string BAddress_Code
      {
         get{ return bAddress_Code; }
         set{ bAddress_Code = value; bAddress_Code_IsChanged=true; }
      }
      /// <summary>
      /// 地址信息编码
      /// </summary>
      public bool BAddress_Code_IsChanged
      {
         get{ return bAddress_Code_IsChanged; }
         set{ bAddress_Code_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据类型
      /// </summary>
      private string module_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Code_IsChanged=false;
      /// <summary>
      /// 关联单据类型
      /// </summary>
      public string Module_Code
      {
         get{ return module_Code; }
         set{ module_Code = value; module_Code_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据类型
      /// </summary>
      public bool Module_Code_IsChanged
      {
         get{ return module_Code_IsChanged; }
         set{ module_Code_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据编码
      /// </summary>
      private string record_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool record_ID_IsChanged=false;
      /// <summary>
      /// 关联单据编码
      /// </summary>
      public string Record_ID
      {
         get{ return record_ID; }
         set{ record_ID = value; record_ID_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据编码
      /// </summary>
      public bool Record_ID_IsChanged
      {
         get{ return record_ID_IsChanged; }
         set{ record_ID_IsChanged = value; }
      }
      /// <summary>
      /// 地址类型
      /// </summary>
      private string bAddress_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Type_IsChanged=false;
      /// <summary>
      /// 地址类型
      /// </summary>
      public string BAddress_Type
      {
         get{ return bAddress_Type; }
         set{ bAddress_Type = value; bAddress_Type_IsChanged=true; }
      }
      /// <summary>
      /// 地址类型
      /// </summary>
      public bool BAddress_Type_IsChanged
      {
         get{ return bAddress_Type_IsChanged; }
         set{ bAddress_Type_IsChanged = value; }
      }
      /// <summary>
      /// 地址名称
      /// </summary>
      private string bAddress_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Name_IsChanged=false;
      /// <summary>
      /// 地址名称
      /// </summary>
      public string BAddress_Name
      {
         get{ return bAddress_Name; }
         set{ bAddress_Name = value; bAddress_Name_IsChanged=true; }
      }
      /// <summary>
      /// 地址名称
      /// </summary>
      public bool BAddress_Name_IsChanged
      {
         get{ return bAddress_Name_IsChanged; }
         set{ bAddress_Name_IsChanged = value; }
      }
      /// <summary>
      /// 联系人
      /// </summary>
      private string bAddress_Contactor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Contactor_IsChanged=false;
      /// <summary>
      /// 联系人
      /// </summary>
      public string BAddress_Contactor
      {
         get{ return bAddress_Contactor; }
         set{ bAddress_Contactor = value; bAddress_Contactor_IsChanged=true; }
      }
      /// <summary>
      /// 联系人
      /// </summary>
      public bool BAddress_Contactor_IsChanged
      {
         get{ return bAddress_Contactor_IsChanged; }
         set{ bAddress_Contactor_IsChanged = value; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      private string bAddress_Mobile;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Mobile_IsChanged=false;
      /// <summary>
      /// 联系电话
      /// </summary>
      public string BAddress_Mobile
      {
         get{ return bAddress_Mobile; }
         set{ bAddress_Mobile = value; bAddress_Mobile_IsChanged=true; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      public bool BAddress_Mobile_IsChanged
      {
         get{ return bAddress_Mobile_IsChanged; }
         set{ bAddress_Mobile_IsChanged = value; }
      }
      /// <summary>
      /// 邮编
      /// </summary>
      private string bAddress_Zip;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Zip_IsChanged=false;
      /// <summary>
      /// 邮编
      /// </summary>
      public string BAddress_Zip
      {
         get{ return bAddress_Zip; }
         set{ bAddress_Zip = value; bAddress_Zip_IsChanged=true; }
      }
      /// <summary>
      /// 邮编
      /// </summary>
      public bool BAddress_Zip_IsChanged
      {
         get{ return bAddress_Zip_IsChanged; }
         set{ bAddress_Zip_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string bAddress_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bAddress_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string BAddress_Remark
      {
         get{ return bAddress_Remark; }
         set{ bAddress_Remark = value; bAddress_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool BAddress_Remark_IsChanged
      {
         get{ return bAddress_Remark_IsChanged; }
         set{ bAddress_Remark_IsChanged = value; }
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
   }
}
