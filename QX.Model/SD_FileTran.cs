using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 合同资料交接
   /// </summary>
   [Serializable]
   public partial class SD_FileTran
   {
      /// <summary>
      /// 合同资料交接序号
      /// </summary>
      private decimal sDF_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_ID_IsChanged=false;
      /// <summary>
      /// 合同资料交接序号
      /// </summary>
      public decimal SDF_ID
      {
         get{ return sDF_ID; }
         set{ sDF_ID = value; sDF_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同资料交接序号
      /// </summary>
      public bool SDF_ID_IsChanged
      {
         get{ return sDF_ID_IsChanged; }
         set{ sDF_ID_IsChanged = value; }
      }
      /// <summary>
      /// 合同资料交接编码
      /// </summary>
      private string sDF_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_Code_IsChanged=false;
      /// <summary>
      /// 合同资料交接编码
      /// </summary>
      public string SDF_Code
      {
         get{ return sDF_Code; }
         set{ sDF_Code = value; sDF_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同资料交接编码
      /// </summary>
      public bool SDF_Code_IsChanged
      {
         get{ return sDF_Code_IsChanged; }
         set{ sDF_Code_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string sDF_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_CCode_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string SDF_CCode
      {
         get{ return sDF_CCode; }
         set{ sDF_CCode = value; sDF_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool SDF_CCode_IsChanged
      {
         get{ return sDF_CCode_IsChanged; }
         set{ sDF_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDF_BCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_BCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDF_BCode
      {
         get{ return sDF_BCode; }
         set{ sDF_BCode = value; sDF_BCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDF_BCode_IsChanged
      {
         get{ return sDF_BCode_IsChanged; }
         set{ sDF_BCode_IsChanged = value; }
      }
      /// <summary>
      /// 交接人
      /// </summary>
      private string sDF_BContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_BContact_IsChanged=false;
      /// <summary>
      /// 交接人
      /// </summary>
      public string SDF_BContact
      {
         get{ return sDF_BContact; }
         set{ sDF_BContact = value; sDF_BContact_IsChanged=true; }
      }
      /// <summary>
      /// 交接人
      /// </summary>
      public bool SDF_BContact_IsChanged
      {
         get{ return sDF_BContact_IsChanged; }
         set{ sDF_BContact_IsChanged = value; }
      }
      /// <summary>
      /// 交接状态
      /// </summary>
      private string sDF_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_Status_IsChanged=false;
      /// <summary>
      /// 交接状态
      /// </summary>
      public string SDF_Status
      {
         get{ return sDF_Status; }
         set{ sDF_Status = value; sDF_Status_IsChanged=true; }
      }
      /// <summary>
      /// 交接状态
      /// </summary>
      public bool SDF_Status_IsChanged
      {
         get{ return sDF_Status_IsChanged; }
         set{ sDF_Status_IsChanged = value; }
      }
      /// <summary>
      /// 资料类别
      /// </summary>
      private string sDF_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_Type_IsChanged=false;
      /// <summary>
      /// 资料类别
      /// </summary>
      public string SDF_Type
      {
         get{ return sDF_Type; }
         set{ sDF_Type = value; sDF_Type_IsChanged=true; }
      }
      /// <summary>
      /// 资料类别
      /// </summary>
      public bool SDF_Type_IsChanged
      {
         get{ return sDF_Type_IsChanged; }
         set{ sDF_Type_IsChanged = value; }
      }
      /// <summary>
      /// 资料名称
      /// </summary>
      private string sDF_FileName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_FileName_IsChanged=false;
      /// <summary>
      /// 资料名称
      /// </summary>
      public string SDF_FileName
      {
         get{ return sDF_FileName; }
         set{ sDF_FileName = value; sDF_FileName_IsChanged=true; }
      }
      /// <summary>
      /// 资料名称
      /// </summary>
      public bool SDF_FileName_IsChanged
      {
         get{ return sDF_FileName_IsChanged; }
         set{ sDF_FileName_IsChanged = value; }
      }
      /// <summary>
      /// 资料描述
      /// </summary>
      private string sDF_Description;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_Description_IsChanged=false;
      /// <summary>
      /// 资料描述
      /// </summary>
      public string SDF_Description
      {
         get{ return sDF_Description; }
         set{ sDF_Description = value; sDF_Description_IsChanged=true; }
      }
      /// <summary>
      /// 资料描述
      /// </summary>
      public bool SDF_Description_IsChanged
      {
         get{ return sDF_Description_IsChanged; }
         set{ sDF_Description_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDF_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDF_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDF_Bak
      {
         get{ return sDF_Bak; }
         set{ sDF_Bak = value; sDF_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDF_Bak_IsChanged
      {
         get{ return sDF_Bak_IsChanged; }
         set{ sDF_Bak_IsChanged = value; }
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
