using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 异常记录
   /// </summary>
   [Serializable]
   public partial class PCD_DRecord
   {
      private decimal pCCD_ID;
      private bool pCCD_ID_IsChanged=false;
      public decimal PCCD_ID
      {
         get{ return pCCD_ID; }
         set{ pCCD_ID = value; pCCD_ID_IsChanged=true; }
      }
      public bool PCCD_ID_IsChanged
      {
         get{ return pCCD_ID_IsChanged; }
         set{ pCCD_ID_IsChanged = value; }
      }
      /// <summary>
      /// 异常编码
      /// </summary>
      private string pCCD_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_Code_IsChanged=false;
      /// <summary>
      /// 异常编码
      /// </summary>
      public string PCCD_Code
      {
         get{ return pCCD_Code; }
         set{ pCCD_Code = value; pCCD_Code_IsChanged=true; }
      }
      /// <summary>
      /// 异常编码
      /// </summary>
      public bool PCCD_Code_IsChanged
      {
         get{ return pCCD_Code_IsChanged; }
         set{ pCCD_Code_IsChanged = value; }
      }
      /// <summary>
      /// 异常类型
      /// </summary>
      private string pCCD_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_Type_IsChanged=false;
      /// <summary>
      /// 异常类型
      /// </summary>
      public string PCCD_Type
      {
         get{ return pCCD_Type; }
         set{ pCCD_Type = value; pCCD_Type_IsChanged=true; }
      }
      /// <summary>
      /// 异常类型
      /// </summary>
      public bool PCCD_Type_IsChanged
      {
         get{ return pCCD_Type_IsChanged; }
         set{ pCCD_Type_IsChanged = value; }
      }
      /// <summary>
      /// 小票号
      /// </summary>
      private string pCCD_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_RCode_IsChanged=false;
      /// <summary>
      /// 小票号
      /// </summary>
      public string PCCD_RCode
      {
         get{ return pCCD_RCode; }
         set{ pCCD_RCode = value; pCCD_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 小票号
      /// </summary>
      public bool PCCD_RCode_IsChanged
      {
         get{ return pCCD_RCode_IsChanged; }
         set{ pCCD_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      private string pCCD_PRCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_PRCode_IsChanged=false;
      /// <summary>
      /// 工程编码
      /// </summary>
      public string PCCD_PRCode
      {
         get{ return pCCD_PRCode; }
         set{ pCCD_PRCode = value; pCCD_PRCode_IsChanged=true; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      public bool PCCD_PRCode_IsChanged
      {
         get{ return pCCD_PRCode_IsChanged; }
         set{ pCCD_PRCode_IsChanged = value; }
      }
      /// <summary>
      /// 生产计划
      /// </summary>
      private string pCCD_PPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_PPCode_IsChanged=false;
      /// <summary>
      /// 生产计划
      /// </summary>
      public string PCCD_PPCode
      {
         get{ return pCCD_PPCode; }
         set{ pCCD_PPCode = value; pCCD_PPCode_IsChanged=true; }
      }
      /// <summary>
      /// 生产计划
      /// </summary>
      public bool PCCD_PPCode_IsChanged
      {
         get{ return pCCD_PPCode_IsChanged; }
         set{ pCCD_PPCode_IsChanged = value; }
      }
      /// <summary>
      /// 车号
      /// </summary>
      private string pCCD_PTCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_PTCode_IsChanged=false;
      /// <summary>
      /// 车号
      /// </summary>
      public string PCCD_PTCode
      {
         get{ return pCCD_PTCode; }
         set{ pCCD_PTCode = value; pCCD_PTCode_IsChanged=true; }
      }
      /// <summary>
      /// 车号
      /// </summary>
      public bool PCCD_PTCode_IsChanged
      {
         get{ return pCCD_PTCode_IsChanged; }
         set{ pCCD_PTCode_IsChanged = value; }
      }
      /// <summary>
      /// 原方量
      /// </summary>
      private decimal pCCD_PTNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_PTNum_IsChanged=false;
      /// <summary>
      /// 原方量
      /// </summary>
      public decimal PCCD_PTNum
      {
         get{ return pCCD_PTNum; }
         set{ pCCD_PTNum = value; pCCD_PTNum_IsChanged=true; }
      }
      /// <summary>
      /// 原方量
      /// </summary>
      public bool PCCD_PTNum_IsChanged
      {
         get{ return pCCD_PTNum_IsChanged; }
         set{ pCCD_PTNum_IsChanged = value; }
      }
      private string pCCD_PNTCode;
      private bool pCCD_PNTCode_IsChanged=false;
      public string PCCD_PNTCode
      {
         get{ return pCCD_PNTCode; }
         set{ pCCD_PNTCode = value; pCCD_PNTCode_IsChanged=true; }
      }
      public bool PCCD_PNTCode_IsChanged
      {
         get{ return pCCD_PNTCode_IsChanged; }
         set{ pCCD_PNTCode_IsChanged = value; }
      }
      /// <summary>
      /// 分车小票编码
      /// </summary>
      private string pCCD_NCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_NCode_IsChanged=false;
      /// <summary>
      /// 分车小票编码
      /// </summary>
      public string PCCD_NCode
      {
         get{ return pCCD_NCode; }
         set{ pCCD_NCode = value; pCCD_NCode_IsChanged=true; }
      }
      /// <summary>
      /// 分车小票编码
      /// </summary>
      public bool PCCD_NCode_IsChanged
      {
         get{ return pCCD_NCode_IsChanged; }
         set{ pCCD_NCode_IsChanged = value; }
      }
      /// <summary>
      /// 分车号
      /// </summary>
      private string pCCD_NTCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_NTCode_IsChanged=false;
      /// <summary>
      /// 分车号
      /// </summary>
      public string PCCD_NTCode
      {
         get{ return pCCD_NTCode; }
         set{ pCCD_NTCode = value; pCCD_NTCode_IsChanged=true; }
      }
      /// <summary>
      /// 分车号
      /// </summary>
      public bool PCCD_NTCode_IsChanged
      {
         get{ return pCCD_NTCode_IsChanged; }
         set{ pCCD_NTCode_IsChanged = value; }
      }
      /// <summary>
      /// 分车方量
      /// </summary>
      private decimal pCCD_NTNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_NTNum_IsChanged=false;
      /// <summary>
      /// 分车方量
      /// </summary>
      public decimal PCCD_NTNum
      {
         get{ return pCCD_NTNum; }
         set{ pCCD_NTNum = value; pCCD_NTNum_IsChanged=true; }
      }
      /// <summary>
      /// 分车方量
      /// </summary>
      public bool PCCD_NTNum_IsChanged
      {
         get{ return pCCD_NTNum_IsChanged; }
         set{ pCCD_NTNum_IsChanged = value; }
      }
      /// <summary>
      /// 分车计划
      /// </summary>
      private string pCCD_NPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_NPCode_IsChanged=false;
      /// <summary>
      /// 分车计划
      /// </summary>
      public string PCCD_NPCode
      {
         get{ return pCCD_NPCode; }
         set{ pCCD_NPCode = value; pCCD_NPCode_IsChanged=true; }
      }
      /// <summary>
      /// 分车计划
      /// </summary>
      public bool PCCD_NPCode_IsChanged
      {
         get{ return pCCD_NPCode_IsChanged; }
         set{ pCCD_NPCode_IsChanged = value; }
      }
      /// <summary>
      /// 分车工程
      /// </summary>
      private string pCCD_NRCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_NRCode_IsChanged=false;
      /// <summary>
      /// 分车工程
      /// </summary>
      public string PCCD_NRCode
      {
         get{ return pCCD_NRCode; }
         set{ pCCD_NRCode = value; pCCD_NRCode_IsChanged=true; }
      }
      /// <summary>
      /// 分车工程
      /// </summary>
      public bool PCCD_NRCode_IsChanged
      {
         get{ return pCCD_NRCode_IsChanged; }
         set{ pCCD_NRCode_IsChanged = value; }
      }
      /// <summary>
      /// 是否已处理
      /// </summary>
      private string pCCD_IsHandle;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_IsHandle_IsChanged=false;
      /// <summary>
      /// 是否已处理
      /// </summary>
      public string PCCD_IsHandle
      {
         get{ return pCCD_IsHandle; }
         set{ pCCD_IsHandle = value; pCCD_IsHandle_IsChanged=true; }
      }
      /// <summary>
      /// 是否已处理
      /// </summary>
      public bool PCCD_IsHandle_IsChanged
      {
         get{ return pCCD_IsHandle_IsChanged; }
         set{ pCCD_IsHandle_IsChanged = value; }
      }
      /// <summary>
      /// 是否外部车辆
      /// </summary>
      private int pCCD_IsOut;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_IsOut_IsChanged=false;
      /// <summary>
      /// 是否外部车辆
      /// </summary>
      public int PCCD_IsOut
      {
         get{ return pCCD_IsOut; }
         set{ pCCD_IsOut = value; pCCD_IsOut_IsChanged=true; }
      }
      /// <summary>
      /// 是否外部车辆
      /// </summary>
      public bool PCCD_IsOut_IsChanged
      {
         get{ return pCCD_IsOut_IsChanged; }
         set{ pCCD_IsOut_IsChanged = value; }
      }
      /// <summary>
      /// 质检员
      /// </summary>
      private string pCCD_Tester;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_Tester_IsChanged=false;
      /// <summary>
      /// 质检员
      /// </summary>
      public string PCCD_Tester
      {
         get{ return pCCD_Tester; }
         set{ pCCD_Tester = value; pCCD_Tester_IsChanged=true; }
      }
      /// <summary>
      /// 质检员
      /// </summary>
      public bool PCCD_Tester_IsChanged
      {
         get{ return pCCD_Tester_IsChanged; }
         set{ pCCD_Tester_IsChanged = value; }
      }
      /// <summary>
      /// 质检时间
      /// </summary>
      private DateTime pCCD_TestDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_TestDate_IsChanged=false;
      /// <summary>
      /// 质检时间
      /// </summary>
      public DateTime PCCD_TestDate
      {
         get{ return pCCD_TestDate; }
         set{ pCCD_TestDate = value; pCCD_TestDate_IsChanged=true; }
      }
      /// <summary>
      /// 质检时间
      /// </summary>
      public bool PCCD_TestDate_IsChanged
      {
         get{ return pCCD_TestDate_IsChanged; }
         set{ pCCD_TestDate_IsChanged = value; }
      }
      /// <summary>
      /// 质检员意见
      /// </summary>
      private string pCCD_TestAdvice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_TestAdvice_IsChanged=false;
      /// <summary>
      /// 质检员意见
      /// </summary>
      public string PCCD_TestAdvice
      {
         get{ return pCCD_TestAdvice; }
         set{ pCCD_TestAdvice = value; pCCD_TestAdvice_IsChanged=true; }
      }
      /// <summary>
      /// 质检员意见
      /// </summary>
      public bool PCCD_TestAdvice_IsChanged
      {
         get{ return pCCD_TestAdvice_IsChanged; }
         set{ pCCD_TestAdvice_IsChanged = value; }
      }
      /// <summary>
      /// 异常处理类型
      /// </summary>
      private string pCCD_HType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_HType_IsChanged=false;
      /// <summary>
      /// 异常处理类型
      /// </summary>
      public string PCCD_HType
      {
         get{ return pCCD_HType; }
         set{ pCCD_HType = value; pCCD_HType_IsChanged=true; }
      }
      /// <summary>
      /// 异常处理类型
      /// </summary>
      public bool PCCD_HType_IsChanged
      {
         get{ return pCCD_HType_IsChanged; }
         set{ pCCD_HType_IsChanged = value; }
      }
      /// <summary>
      /// 异常说明
      /// </summary>
      private string pCCD_ERemark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCD_ERemark_IsChanged=false;
      /// <summary>
      /// 异常说明
      /// </summary>
      public string PCCD_ERemark
      {
         get{ return pCCD_ERemark; }
         set{ pCCD_ERemark = value; pCCD_ERemark_IsChanged=true; }
      }
      /// <summary>
      /// 异常说明
      /// </summary>
      public bool PCCD_ERemark_IsChanged
      {
         get{ return pCCD_ERemark_IsChanged; }
         set{ pCCD_ERemark_IsChanged = value; }
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
