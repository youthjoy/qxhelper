using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 工程部位
   /// </summary>
   [Serializable]
   public partial class SD_ProjectParts
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private decimal sDPP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPP_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public decimal SDPP_ID
      {
         get{ return sDPP_ID; }
         set{ sDPP_ID = value; sDPP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool SDPP_ID_IsChanged
      {
         get{ return sDPP_ID_IsChanged; }
         set{ sDPP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 编码
      /// </summary>
      private string sDPP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPP_Code_IsChanged=false;
      /// <summary>
      /// 编码
      /// </summary>
      public string SDPP_Code
      {
         get{ return sDPP_Code; }
         set{ sDPP_Code = value; sDPP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 编码
      /// </summary>
      public bool SDPP_Code_IsChanged
      {
         get{ return sDPP_Code_IsChanged; }
         set{ sDPP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      private string sDPP_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPP_PCode_IsChanged=false;
      /// <summary>
      /// 工程编码
      /// </summary>
      public string SDPP_PCode
      {
         get{ return sDPP_PCode; }
         set{ sDPP_PCode = value; sDPP_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      public bool SDPP_PCode_IsChanged
      {
         get{ return sDPP_PCode_IsChanged; }
         set{ sDPP_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 部位名称
      /// </summary>
      private string sDPP_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPP_Name_IsChanged=false;
      /// <summary>
      /// 部位名称
      /// </summary>
      public string SDPP_Name
      {
         get{ return sDPP_Name; }
         set{ sDPP_Name = value; sDPP_Name_IsChanged=true; }
      }
      /// <summary>
      /// 部位名称
      /// </summary>
      public bool SDPP_Name_IsChanged
      {
         get{ return sDPP_Name_IsChanged; }
         set{ sDPP_Name_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDPP_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPP_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDPP_Bak
      {
         get{ return sDPP_Bak; }
         set{ sDPP_Bak = value; sDPP_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDPP_Bak_IsChanged
      {
         get{ return sDPP_Bak_IsChanged; }
         set{ sDPP_Bak_IsChanged = value; }
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
