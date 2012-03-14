using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class TC_EItem
   {
      /// <summary>
      /// 设备检查明细序号
      /// </summary>
      private decimal tCEI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_ID_IsChanged=false;
      /// <summary>
      /// 设备检查明细序号
      /// </summary>
      public decimal TCEI_ID
      {
         get{ return tCEI_ID; }
         set{ tCEI_ID = value; tCEI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 设备检查明细序号
      /// </summary>
      public bool TCEI_ID_IsChanged
      {
         get{ return tCEI_ID_IsChanged; }
         set{ tCEI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 设备检查明细编码
      /// </summary>
      private string tCEI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_Code_IsChanged=false;
      /// <summary>
      /// 设备检查明细编码
      /// </summary>
      public string TCEI_Code
      {
         get{ return tCEI_Code; }
         set{ tCEI_Code = value; tCEI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 设备检查明细编码
      /// </summary>
      public bool TCEI_Code_IsChanged
      {
         get{ return tCEI_Code_IsChanged; }
         set{ tCEI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 设备检查主表编码
      /// </summary>
      private string tCEI_MainCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_MainCode_IsChanged=false;
      /// <summary>
      /// 设备检查主表编码
      /// </summary>
      public string TCEI_MainCode
      {
         get{ return tCEI_MainCode; }
         set{ tCEI_MainCode = value; tCEI_MainCode_IsChanged=true; }
      }
      /// <summary>
      /// 设备检查主表编码
      /// </summary>
      public bool TCEI_MainCode_IsChanged
      {
         get{ return tCEI_MainCode_IsChanged; }
         set{ tCEI_MainCode_IsChanged = value; }
      }
      /// <summary>
      /// 检测项目编码
      /// </summary>
      private string tCEI_ICode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_ICode_IsChanged=false;
      /// <summary>
      /// 检测项目编码
      /// </summary>
      public string TCEI_ICode
      {
         get{ return tCEI_ICode; }
         set{ tCEI_ICode = value; tCEI_ICode_IsChanged=true; }
      }
      /// <summary>
      /// 检测项目编码
      /// </summary>
      public bool TCEI_ICode_IsChanged
      {
         get{ return tCEI_ICode_IsChanged; }
         set{ tCEI_ICode_IsChanged = value; }
      }
      /// <summary>
      /// 检测项目名称
      /// </summary>
      private string tCEI_IName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_IName_IsChanged=false;
      /// <summary>
      /// 检测项目名称
      /// </summary>
      public string TCEI_IName
      {
         get{ return tCEI_IName; }
         set{ tCEI_IName = value; tCEI_IName_IsChanged=true; }
      }
      /// <summary>
      /// 检测项目名称
      /// </summary>
      public bool TCEI_IName_IsChanged
      {
         get{ return tCEI_IName_IsChanged; }
         set{ tCEI_IName_IsChanged = value; }
      }
      /// <summary>
      /// 检测项目结果值
      /// </summary>
      private string tCEI_IValue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_IValue_IsChanged=false;
      /// <summary>
      /// 检测项目结果值
      /// </summary>
      public string TCEI_IValue
      {
         get{ return tCEI_IValue; }
         set{ tCEI_IValue = value; tCEI_IValue_IsChanged=true; }
      }
      /// <summary>
      /// 检测项目结果值
      /// </summary>
      public bool TCEI_IValue_IsChanged
      {
         get{ return tCEI_IValue_IsChanged; }
         set{ tCEI_IValue_IsChanged = value; }
      }
      /// <summary>
      /// 检测项目修正值
      /// </summary>
      private string tCEI_MVal;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_MVal_IsChanged=false;
      /// <summary>
      /// 检测项目修正值
      /// </summary>
      public string TCEI_MVal
      {
         get{ return tCEI_MVal; }
         set{ tCEI_MVal = value; tCEI_MVal_IsChanged=true; }
      }
      /// <summary>
      /// 检测项目修正值
      /// </summary>
      public bool TCEI_MVal_IsChanged
      {
         get{ return tCEI_MVal_IsChanged; }
         set{ tCEI_MVal_IsChanged = value; }
      }
      /// <summary>
      /// 技术指标
      /// </summary>
      private string tCEI_RefVal;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_RefVal_IsChanged=false;
      /// <summary>
      /// 技术指标
      /// </summary>
      public string TCEI_RefVal
      {
         get{ return tCEI_RefVal; }
         set{ tCEI_RefVal = value; tCEI_RefVal_IsChanged=true; }
      }
      /// <summary>
      /// 技术指标
      /// </summary>
      public bool TCEI_RefVal_IsChanged
      {
         get{ return tCEI_RefVal_IsChanged; }
         set{ tCEI_RefVal_IsChanged = value; }
      }
      /// <summary>
      /// 检测依据
      /// </summary>
      private string tCEI_Base;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_Base_IsChanged=false;
      /// <summary>
      /// 检测依据
      /// </summary>
      public string TCEI_Base
      {
         get{ return tCEI_Base; }
         set{ tCEI_Base = value; tCEI_Base_IsChanged=true; }
      }
      /// <summary>
      /// 检测依据
      /// </summary>
      public bool TCEI_Base_IsChanged
      {
         get{ return tCEI_Base_IsChanged; }
         set{ tCEI_Base_IsChanged = value; }
      }
      /// <summary>
      /// 结论
      /// </summary>
      private string tCEI_Conclusion;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCEI_Conclusion_IsChanged=false;
      /// <summary>
      /// 结论
      /// </summary>
      public string TCEI_Conclusion
      {
         get{ return tCEI_Conclusion; }
         set{ tCEI_Conclusion = value; tCEI_Conclusion_IsChanged=true; }
      }
      /// <summary>
      /// 结论
      /// </summary>
      public bool TCEI_Conclusion_IsChanged
      {
         get{ return tCEI_Conclusion_IsChanged; }
         set{ tCEI_Conclusion_IsChanged = value; }
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
