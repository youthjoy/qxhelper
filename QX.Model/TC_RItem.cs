using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 原料检验参数
   /// </summary>
   [Serializable]
   public partial class TC_RItem
   {
      private decimal rMCD_ID;
      private bool rMCD_ID_IsChanged=false;
      public decimal RMCD_ID
      {
         get{ return rMCD_ID; }
         set{ rMCD_ID = value; rMCD_ID_IsChanged=true; }
      }
      public bool RMCD_ID_IsChanged
      {
         get{ return rMCD_ID_IsChanged; }
         set{ rMCD_ID_IsChanged = value; }
      }
      private string rMCD_Code;
      private bool rMCD_Code_IsChanged=false;
      public string RMCD_Code
      {
         get{ return rMCD_Code; }
         set{ rMCD_Code = value; rMCD_Code_IsChanged=true; }
      }
      public bool RMCD_Code_IsChanged
      {
         get{ return rMCD_Code_IsChanged; }
         set{ rMCD_Code_IsChanged = value; }
      }
      /// <summary>
      /// 检验批次号
      /// </summary>
      private string rMCD_RMCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_RMCode_IsChanged=false;
      /// <summary>
      /// 检验批次号
      /// </summary>
      public string RMCD_RMCode
      {
         get{ return rMCD_RMCode; }
         set{ rMCD_RMCode = value; rMCD_RMCode_IsChanged=true; }
      }
      /// <summary>
      /// 检验批次号
      /// </summary>
      public bool RMCD_RMCode_IsChanged
      {
         get{ return rMCD_RMCode_IsChanged; }
         set{ rMCD_RMCode_IsChanged = value; }
      }
      /// <summary>
      /// 检验项目次序
      /// </summary>
      private string rMCD_ItemValue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_ItemValue_IsChanged=false;
      /// <summary>
      /// 检验项目次序
      /// </summary>
      public string RMCD_ItemValue
      {
         get{ return rMCD_ItemValue; }
         set{ rMCD_ItemValue = value; rMCD_ItemValue_IsChanged=true; }
      }
      /// <summary>
      /// 检验项目次序
      /// </summary>
      public bool RMCD_ItemValue_IsChanged
      {
         get{ return rMCD_ItemValue_IsChanged; }
         set{ rMCD_ItemValue_IsChanged = value; }
      }
      /// <summary>
      /// 检验项目编码
      /// </summary>
      private string rMCD_ItemName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_ItemName_IsChanged=false;
      /// <summary>
      /// 检验项目编码
      /// </summary>
      public string RMCD_ItemName
      {
         get{ return rMCD_ItemName; }
         set{ rMCD_ItemName = value; rMCD_ItemName_IsChanged=true; }
      }
      /// <summary>
      /// 检验项目编码
      /// </summary>
      public bool RMCD_ItemName_IsChanged
      {
         get{ return rMCD_ItemName_IsChanged; }
         set{ rMCD_ItemName_IsChanged = value; }
      }
      /// <summary>
      /// 检验项目名称
      /// </summary>
      private string rMCD_ItemCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_ItemCode_IsChanged=false;
      /// <summary>
      /// 检验项目名称
      /// </summary>
      public string RMCD_ItemCode
      {
         get{ return rMCD_ItemCode; }
         set{ rMCD_ItemCode = value; rMCD_ItemCode_IsChanged=true; }
      }
      /// <summary>
      /// 检验项目名称
      /// </summary>
      public bool RMCD_ItemCode_IsChanged
      {
         get{ return rMCD_ItemCode_IsChanged; }
         set{ rMCD_ItemCode_IsChanged = value; }
      }
      /// <summary>
      /// 检验项目值
      /// </summary>
      private string rMCD_Result;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_Result_IsChanged=false;
      /// <summary>
      /// 检验项目值
      /// </summary>
      public string RMCD_Result
      {
         get{ return rMCD_Result; }
         set{ rMCD_Result = value; rMCD_Result_IsChanged=true; }
      }
      /// <summary>
      /// 检验项目值
      /// </summary>
      public bool RMCD_Result_IsChanged
      {
         get{ return rMCD_Result_IsChanged; }
         set{ rMCD_Result_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string rMCD_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string RMCD_Remark
      {
         get{ return rMCD_Remark; }
         set{ rMCD_Remark = value; rMCD_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool RMCD_Remark_IsChanged
      {
         get{ return rMCD_Remark_IsChanged; }
         set{ rMCD_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 检验校正值
      /// </summary>
      private string rMCD_XValue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_XValue_IsChanged=false;
      /// <summary>
      /// 检验校正值
      /// </summary>
      public string RMCD_XValue
      {
         get{ return rMCD_XValue; }
         set{ rMCD_XValue = value; rMCD_XValue_IsChanged=true; }
      }
      /// <summary>
      /// 检验校正值
      /// </summary>
      public bool RMCD_XValue_IsChanged
      {
         get{ return rMCD_XValue_IsChanged; }
         set{ rMCD_XValue_IsChanged = value; }
      }
      /// <summary>
      /// 检测依据
      /// </summary>
      private string rMCD_Base;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_Base_IsChanged=false;
      /// <summary>
      /// 检测依据
      /// </summary>
      public string RMCD_Base
      {
         get{ return rMCD_Base; }
         set{ rMCD_Base = value; rMCD_Base_IsChanged=true; }
      }
      /// <summary>
      /// 检测依据
      /// </summary>
      public bool RMCD_Base_IsChanged
      {
         get{ return rMCD_Base_IsChanged; }
         set{ rMCD_Base_IsChanged = value; }
      }
      /// <summary>
      /// 技术指标
      /// </summary>
      private string rMCD_RefValue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_RefValue_IsChanged=false;
      /// <summary>
      /// 技术指标
      /// </summary>
      public string RMCD_RefValue
      {
         get{ return rMCD_RefValue; }
         set{ rMCD_RefValue = value; rMCD_RefValue_IsChanged=true; }
      }
      /// <summary>
      /// 技术指标
      /// </summary>
      public bool RMCD_RefValue_IsChanged
      {
         get{ return rMCD_RefValue_IsChanged; }
         set{ rMCD_RefValue_IsChanged = value; }
      }
      /// <summary>
      /// 结论
      /// </summary>
      private string rMCD_Conclusion;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rMCD_Conclusion_IsChanged=false;
      /// <summary>
      /// 结论
      /// </summary>
      public string RMCD_Conclusion
      {
         get{ return rMCD_Conclusion; }
         set{ rMCD_Conclusion = value; rMCD_Conclusion_IsChanged=true; }
      }
      /// <summary>
      /// 结论
      /// </summary>
      public bool RMCD_Conclusion_IsChanged
      {
         get{ return rMCD_Conclusion_IsChanged; }
         set{ rMCD_Conclusion_IsChanged = value; }
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
