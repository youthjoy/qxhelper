using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class TC_RTItem
   {
      private decimal tCRTI_ID;
      private bool tCRTI_ID_IsChanged=false;
      public decimal TCRTI_ID
      {
         get{ return tCRTI_ID; }
         set{ tCRTI_ID = value; tCRTI_ID_IsChanged=true; }
      }
      public bool TCRTI_ID_IsChanged
      {
         get{ return tCRTI_ID_IsChanged; }
         set{ tCRTI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板明细编码
      /// </summary>
      private string tCRTI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Code_IsChanged=false;
      /// <summary>
      /// 检测模板明细编码
      /// </summary>
      public string TCRTI_Code
      {
         get{ return tCRTI_Code; }
         set{ tCRTI_Code = value; tCRTI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板明细编码
      /// </summary>
      public bool TCRTI_Code_IsChanged
      {
         get{ return tCRTI_Code_IsChanged; }
         set{ tCRTI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板编码
      /// </summary>
      private string tCRTI_TCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_TCode_IsChanged=false;
      /// <summary>
      /// 检测模板编码
      /// </summary>
      public string TCRTI_TCode
      {
         get{ return tCRTI_TCode; }
         set{ tCRTI_TCode = value; tCRTI_TCode_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板编码
      /// </summary>
      public bool TCRTI_TCode_IsChanged
      {
         get{ return tCRTI_TCode_IsChanged; }
         set{ tCRTI_TCode_IsChanged = value; }
      }
      /// <summary>
      /// 明细父编码
      /// </summary>
      private string tCRTI_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_PCode_IsChanged=false;
      /// <summary>
      /// 明细父编码
      /// </summary>
      public string TCRTI_PCode
      {
         get{ return tCRTI_PCode; }
         set{ tCRTI_PCode = value; tCRTI_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 明细父编码
      /// </summary>
      public bool TCRTI_PCode_IsChanged
      {
         get{ return tCRTI_PCode_IsChanged; }
         set{ tCRTI_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 检测参数名称
      /// </summary>
      private string tCRTI_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Name_IsChanged=false;
      /// <summary>
      /// 检测参数名称
      /// </summary>
      public string TCRTI_Name
      {
         get{ return tCRTI_Name; }
         set{ tCRTI_Name = value; tCRTI_Name_IsChanged=true; }
      }
      /// <summary>
      /// 检测参数名称
      /// </summary>
      public bool TCRTI_Name_IsChanged
      {
         get{ return tCRTI_Name_IsChanged; }
         set{ tCRTI_Name_IsChanged = value; }
      }
      /// <summary>
      /// 检测参数最大值
      /// </summary>
      private decimal tCRTI_Max;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Max_IsChanged=false;
      /// <summary>
      /// 检测参数最大值
      /// </summary>
      public decimal TCRTI_Max
      {
         get{ return tCRTI_Max; }
         set{ tCRTI_Max = value; tCRTI_Max_IsChanged=true; }
      }
      /// <summary>
      /// 检测参数最大值
      /// </summary>
      public bool TCRTI_Max_IsChanged
      {
         get{ return tCRTI_Max_IsChanged; }
         set{ tCRTI_Max_IsChanged = value; }
      }
      /// <summary>
      /// 检测参数最小值
      /// </summary>
      private decimal tCRTI_Min;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Min_IsChanged=false;
      /// <summary>
      /// 检测参数最小值
      /// </summary>
      public decimal TCRTI_Min
      {
         get{ return tCRTI_Min; }
         set{ tCRTI_Min = value; tCRTI_Min_IsChanged=true; }
      }
      /// <summary>
      /// 检测参数最小值
      /// </summary>
      public bool TCRTI_Min_IsChanged
      {
         get{ return tCRTI_Min_IsChanged; }
         set{ tCRTI_Min_IsChanged = value; }
      }
      /// <summary>
      /// 检测指标
      /// </summary>
      private string tCRTI_Standard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Standard_IsChanged=false;
      /// <summary>
      /// 检测指标
      /// </summary>
      public string TCRTI_Standard
      {
         get{ return tCRTI_Standard; }
         set{ tCRTI_Standard = value; tCRTI_Standard_IsChanged=true; }
      }
      /// <summary>
      /// 检测指标
      /// </summary>
      public bool TCRTI_Standard_IsChanged
      {
         get{ return tCRTI_Standard_IsChanged; }
         set{ tCRTI_Standard_IsChanged = value; }
      }
      /// <summary>
      /// 检测参数参考值
      /// </summary>
      private decimal tCRTI_RefVal;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_RefVal_IsChanged=false;
      /// <summary>
      /// 检测参数参考值
      /// </summary>
      public decimal TCRTI_RefVal
      {
         get{ return tCRTI_RefVal; }
         set{ tCRTI_RefVal = value; tCRTI_RefVal_IsChanged=true; }
      }
      /// <summary>
      /// 检测参数参考值
      /// </summary>
      public bool TCRTI_RefVal_IsChanged
      {
         get{ return tCRTI_RefVal_IsChanged; }
         set{ tCRTI_RefVal_IsChanged = value; }
      }
      private string tCRTI_TypeName;
      private bool tCRTI_TypeName_IsChanged=false;
      public string TCRTI_TypeName
      {
         get{ return tCRTI_TypeName; }
         set{ tCRTI_TypeName = value; tCRTI_TypeName_IsChanged=true; }
      }
      public bool TCRTI_TypeName_IsChanged
      {
         get{ return tCRTI_TypeName_IsChanged; }
         set{ tCRTI_TypeName_IsChanged = value; }
      }
      /// <summary>
      /// 模板明细类型
      /// </summary>
      private string tCRTI_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Type_IsChanged=false;
      /// <summary>
      /// 模板明细类型
      /// </summary>
      public string TCRTI_Type
      {
         get{ return tCRTI_Type; }
         set{ tCRTI_Type = value; tCRTI_Type_IsChanged=true; }
      }
      /// <summary>
      /// 模板明细类型
      /// </summary>
      public bool TCRTI_Type_IsChanged
      {
         get{ return tCRTI_Type_IsChanged; }
         set{ tCRTI_Type_IsChanged = value; }
      }
      /// <summary>
      /// 模板明细 参考关键字
      /// </summary>
      private string tCRTI_DictKey;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_DictKey_IsChanged=false;
      /// <summary>
      /// 模板明细 参考关键字
      /// </summary>
      public string TCRTI_DictKey
      {
         get{ return tCRTI_DictKey; }
         set{ tCRTI_DictKey = value; tCRTI_DictKey_IsChanged=true; }
      }
      /// <summary>
      /// 模板明细 参考关键字
      /// </summary>
      public bool TCRTI_DictKey_IsChanged
      {
         get{ return tCRTI_DictKey_IsChanged; }
         set{ tCRTI_DictKey_IsChanged = value; }
      }
      /// <summary>
      /// 模板明细状态
      /// </summary>
      private string tCRTI_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRTI_Stat_IsChanged=false;
      /// <summary>
      /// 模板明细状态
      /// </summary>
      public string TCRTI_Stat
      {
         get{ return tCRTI_Stat; }
         set{ tCRTI_Stat = value; tCRTI_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 模板明细状态
      /// </summary>
      public bool TCRTI_Stat_IsChanged
      {
         get{ return tCRTI_Stat_IsChanged; }
         set{ tCRTI_Stat_IsChanged = value; }
      }
      private int tCRTI_Order;
      private bool tCRTI_Order_IsChanged=false;
      public int TCRTI_Order
      {
         get{ return tCRTI_Order; }
         set{ tCRTI_Order = value; tCRTI_Order_IsChanged=true; }
      }
      public bool TCRTI_Order_IsChanged
      {
         get{ return tCRTI_Order_IsChanged; }
         set{ tCRTI_Order_IsChanged = value; }
      }
      private string tCRTI_Remark;
      private bool tCRTI_Remark_IsChanged=false;
      public string TCRTI_Remark
      {
         get{ return tCRTI_Remark; }
         set{ tCRTI_Remark = value; tCRTI_Remark_IsChanged=true; }
      }
      public bool TCRTI_Remark_IsChanged
      {
         get{ return tCRTI_Remark_IsChanged; }
         set{ tCRTI_Remark_IsChanged = value; }
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
