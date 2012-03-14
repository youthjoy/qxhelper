using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PC_MRTemplate
   {
      private decimal pCMRT_ID;
      private bool pCMRT_ID_IsChanged=false;
      public decimal PCMRT_ID
      {
         get{ return pCMRT_ID; }
         set{ pCMRT_ID = value; pCMRT_ID_IsChanged=true; }
      }
      public bool PCMRT_ID_IsChanged
      {
         get{ return pCMRT_ID_IsChanged; }
         set{ pCMRT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 材料需求模板编码
      /// </summary>
      private string pCMRT_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCMRT_Code_IsChanged=false;
      /// <summary>
      /// 材料需求模板编码
      /// </summary>
      public string PCMRT_Code
      {
         get{ return pCMRT_Code; }
         set{ pCMRT_Code = value; pCMRT_Code_IsChanged=true; }
      }
      /// <summary>
      /// 材料需求模板编码
      /// </summary>
      public bool PCMRT_Code_IsChanged
      {
         get{ return pCMRT_Code_IsChanged; }
         set{ pCMRT_Code_IsChanged = value; }
      }
      /// <summary>
      /// 标识
      /// </summary>
      private string pCMRT_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCMRT_Name_IsChanged=false;
      /// <summary>
      /// 标识
      /// </summary>
      public string PCMRT_Name
      {
         get{ return pCMRT_Name; }
         set{ pCMRT_Name = value; pCMRT_Name_IsChanged=true; }
      }
      /// <summary>
      /// 标识
      /// </summary>
      public bool PCMRT_Name_IsChanged
      {
         get{ return pCMRT_Name_IsChanged; }
         set{ pCMRT_Name_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string pCMRT_LCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCMRT_LCode_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string PCMRT_LCode
      {
         get{ return pCMRT_LCode; }
         set{ pCMRT_LCode = value; pCMRT_LCode_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool PCMRT_LCode_IsChanged
      {
         get{ return pCMRT_LCode_IsChanged; }
         set{ pCMRT_LCode_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pCMRT_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCMRT_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PCMRT_Remark
      {
         get{ return pCMRT_Remark; }
         set{ pCMRT_Remark = value; pCMRT_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PCMRT_Remark_IsChanged
      {
         get{ return pCMRT_Remark_IsChanged; }
         set{ pCMRT_Remark_IsChanged = value; }
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
   }
}
