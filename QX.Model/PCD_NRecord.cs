using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 发货记录
   /// </summary>
   [Serializable]
   public partial class PCD_NRecord
   {
      private decimal pCDN_ID;
      private bool pCDN_ID_IsChanged=false;
      public decimal PCDN_ID
      {
         get{ return pCDN_ID; }
         set{ pCDN_ID = value; pCDN_ID_IsChanged=true; }
      }
      public bool PCDN_ID_IsChanged
      {
         get{ return pCDN_ID_IsChanged; }
         set{ pCDN_ID_IsChanged = value; }
      }
      /// <summary>
      /// 发货单号码
      /// </summary>
      private string pCDN_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_Code_IsChanged=false;
      /// <summary>
      /// 发货单号码
      /// </summary>
      public string PCDN_Code
      {
         get{ return pCDN_Code; }
         set{ pCDN_Code = value; pCDN_Code_IsChanged=true; }
      }
      /// <summary>
      /// 发货单号码
      /// </summary>
      public bool PCDN_Code_IsChanged
      {
         get{ return pCDN_Code_IsChanged; }
         set{ pCDN_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string pCDN_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string PCDN_CCode
      {
         get{ return pCDN_CCode; }
         set{ pCDN_CCode = value; pCDN_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool PCDN_CCode_IsChanged
      {
         get{ return pCDN_CCode_IsChanged; }
         set{ pCDN_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      private string pCDN_PRCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PRCode_IsChanged=false;
      /// <summary>
      /// 工程编码
      /// </summary>
      public string PCDN_PRCode
      {
         get{ return pCDN_PRCode; }
         set{ pCDN_PRCode = value; pCDN_PRCode_IsChanged=true; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      public bool PCDN_PRCode_IsChanged
      {
         get{ return pCDN_PRCode_IsChanged; }
         set{ pCDN_PRCode_IsChanged = value; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      private string pCDN_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PCode_IsChanged=false;
      /// <summary>
      /// 计划编码
      /// </summary>
      public string PCDN_PCode
      {
         get{ return pCDN_PCode; }
         set{ pCDN_PCode = value; pCDN_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      public bool PCDN_PCode_IsChanged
      {
         get{ return pCDN_PCode_IsChanged; }
         set{ pCDN_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string pCDN_PDCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PDCode_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string PCDN_PDCode
      {
         get{ return pCDN_PDCode; }
         set{ pCDN_PDCode = value; pCDN_PDCode_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool PCDN_PDCode_IsChanged
      {
         get{ return pCDN_PDCode_IsChanged; }
         set{ pCDN_PDCode_IsChanged = value; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      private string pCDN_PSCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PSCode_IsChanged=false;
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public string PCDN_PSCode
      {
         get{ return pCDN_PSCode; }
         set{ pCDN_PSCode = value; pCDN_PSCode_IsChanged=true; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public bool PCDN_PSCode_IsChanged
      {
         get{ return pCDN_PSCode_IsChanged; }
         set{ pCDN_PSCode_IsChanged = value; }
      }
      /// <summary>
      /// 浇注部位
      /// </summary>
      private string pCDN_Part;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_Part_IsChanged=false;
      /// <summary>
      /// 浇注部位
      /// </summary>
      public string PCDN_Part
      {
         get{ return pCDN_Part; }
         set{ pCDN_Part = value; pCDN_Part_IsChanged=true; }
      }
      /// <summary>
      /// 浇注部位
      /// </summary>
      public bool PCDN_Part_IsChanged
      {
         get{ return pCDN_Part_IsChanged; }
         set{ pCDN_Part_IsChanged = value; }
      }
      /// <summary>
      /// 坍落度
      /// </summary>
      private string pCDN_Slump;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_Slump_IsChanged=false;
      /// <summary>
      /// 坍落度
      /// </summary>
      public string PCDN_Slump
      {
         get{ return pCDN_Slump; }
         set{ pCDN_Slump = value; pCDN_Slump_IsChanged=true; }
      }
      /// <summary>
      /// 坍落度
      /// </summary>
      public bool PCDN_Slump_IsChanged
      {
         get{ return pCDN_Slump_IsChanged; }
         set{ pCDN_Slump_IsChanged = value; }
      }
      /// <summary>
      /// 特殊物料1
      /// </summary>
      private string pCDN_Spec1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_Spec1_IsChanged=false;
      /// <summary>
      /// 特殊物料1
      /// </summary>
      public string PCDN_Spec1
      {
         get{ return pCDN_Spec1; }
         set{ pCDN_Spec1 = value; pCDN_Spec1_IsChanged=true; }
      }
      /// <summary>
      /// 特殊物料1
      /// </summary>
      public bool PCDN_Spec1_IsChanged
      {
         get{ return pCDN_Spec1_IsChanged; }
         set{ pCDN_Spec1_IsChanged = value; }
      }
      /// <summary>
      /// 特殊物料2
      /// </summary>
      private string pCDN_Spec2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_Spec2_IsChanged=false;
      /// <summary>
      /// 特殊物料2
      /// </summary>
      public string PCDN_Spec2
      {
         get{ return pCDN_Spec2; }
         set{ pCDN_Spec2 = value; pCDN_Spec2_IsChanged=true; }
      }
      /// <summary>
      /// 特殊物料2
      /// </summary>
      public bool PCDN_Spec2_IsChanged
      {
         get{ return pCDN_Spec2_IsChanged; }
         set{ pCDN_Spec2_IsChanged = value; }
      }
      /// <summary>
      /// 配送方式
      /// </summary>
      private string pCDN_TType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TType_IsChanged=false;
      /// <summary>
      /// 配送方式
      /// </summary>
      public string PCDN_TType
      {
         get{ return pCDN_TType; }
         set{ pCDN_TType = value; pCDN_TType_IsChanged=true; }
      }
      /// <summary>
      /// 配送方式
      /// </summary>
      public bool PCDN_TType_IsChanged
      {
         get{ return pCDN_TType_IsChanged; }
         set{ pCDN_TType_IsChanged = value; }
      }
      /// <summary>
      /// 配送设备
      /// </summary>
      private string pCDN_TEqu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TEqu_IsChanged=false;
      /// <summary>
      /// 配送设备
      /// </summary>
      public string PCDN_TEqu
      {
         get{ return pCDN_TEqu; }
         set{ pCDN_TEqu = value; pCDN_TEqu_IsChanged=true; }
      }
      /// <summary>
      /// 配送设备
      /// </summary>
      public bool PCDN_TEqu_IsChanged
      {
         get{ return pCDN_TEqu_IsChanged; }
         set{ pCDN_TEqu_IsChanged = value; }
      }
      /// <summary>
      /// 调度员
      /// </summary>
      private string pCDN_SOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_SOwner_IsChanged=false;
      /// <summary>
      /// 调度员
      /// </summary>
      public string PCDN_SOwner
      {
         get{ return pCDN_SOwner; }
         set{ pCDN_SOwner = value; pCDN_SOwner_IsChanged=true; }
      }
      /// <summary>
      /// 调度员
      /// </summary>
      public bool PCDN_SOwner_IsChanged
      {
         get{ return pCDN_SOwner_IsChanged; }
         set{ pCDN_SOwner_IsChanged = value; }
      }
      /// <summary>
      /// 调度时间
      /// </summary>
      private DateTime pCDN_SDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_SDate_IsChanged=false;
      /// <summary>
      /// 调度时间
      /// </summary>
      public DateTime PCDN_SDate
      {
         get{ return pCDN_SDate; }
         set{ pCDN_SDate = value; pCDN_SDate_IsChanged=true; }
      }
      /// <summary>
      /// 调度时间
      /// </summary>
      public bool PCDN_SDate_IsChanged
      {
         get{ return pCDN_SDate_IsChanged; }
         set{ pCDN_SDate_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌站
      /// </summary>
      private string pCDN_TBSta;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TBSta_IsChanged=false;
      /// <summary>
      /// 搅拌站
      /// </summary>
      public string PCDN_TBSta
      {
         get{ return pCDN_TBSta; }
         set{ pCDN_TBSta = value; pCDN_TBSta_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌站
      /// </summary>
      public bool PCDN_TBSta_IsChanged
      {
         get{ return pCDN_TBSta_IsChanged; }
         set{ pCDN_TBSta_IsChanged = value; }
      }
      /// <summary>
      /// 生产线
      /// </summary>
      private string pCDN_TBLine;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TBLine_IsChanged=false;
      /// <summary>
      /// 生产线
      /// </summary>
      public string PCDN_TBLine
      {
         get{ return pCDN_TBLine; }
         set{ pCDN_TBLine = value; pCDN_TBLine_IsChanged=true; }
      }
      /// <summary>
      /// 生产线
      /// </summary>
      public bool PCDN_TBLine_IsChanged
      {
         get{ return pCDN_TBLine_IsChanged; }
         set{ pCDN_TBLine_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌员
      /// </summary>
      private string pCDN_OOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_OOwner_IsChanged=false;
      /// <summary>
      /// 搅拌员
      /// </summary>
      public string PCDN_OOwner
      {
         get{ return pCDN_OOwner; }
         set{ pCDN_OOwner = value; pCDN_OOwner_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌员
      /// </summary>
      public bool PCDN_OOwner_IsChanged
      {
         get{ return pCDN_OOwner_IsChanged; }
         set{ pCDN_OOwner_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌时间
      /// </summary>
      private DateTime pCDN_ODate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_ODate_IsChanged=false;
      /// <summary>
      /// 搅拌时间
      /// </summary>
      public DateTime PCDN_ODate
      {
         get{ return pCDN_ODate; }
         set{ pCDN_ODate = value; pCDN_ODate_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌时间
      /// </summary>
      public bool PCDN_ODate_IsChanged
      {
         get{ return pCDN_ODate_IsChanged; }
         set{ pCDN_ODate_IsChanged = value; }
      }
      private string pCDN_ForeMan;
      private bool pCDN_ForeMan_IsChanged=false;
      public string PCDN_ForeMan
      {
         get{ return pCDN_ForeMan; }
         set{ pCDN_ForeMan = value; pCDN_ForeMan_IsChanged=true; }
      }
      public bool PCDN_ForeMan_IsChanged
      {
         get{ return pCDN_ForeMan_IsChanged; }
         set{ pCDN_ForeMan_IsChanged = value; }
      }
      /// <summary>
      /// 计划限载方量
      /// </summary>
      private decimal pCDN_PPLimit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PPLimit_IsChanged=false;
      /// <summary>
      /// 计划限载方量
      /// </summary>
      public decimal PCDN_PPLimit
      {
         get{ return pCDN_PPLimit; }
         set{ pCDN_PPLimit = value; pCDN_PPLimit_IsChanged=true; }
      }
      /// <summary>
      /// 计划限载方量
      /// </summary>
      public bool PCDN_PPLimit_IsChanged
      {
         get{ return pCDN_PPLimit_IsChanged; }
         set{ pCDN_PPLimit_IsChanged = value; }
      }
      /// <summary>
      /// 回站处理类型
      /// </summary>
      private string pCDN_DIType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_DIType_IsChanged=false;
      /// <summary>
      /// 回站处理类型
      /// </summary>
      public string PCDN_DIType
      {
         get{ return pCDN_DIType; }
         set{ pCDN_DIType = value; pCDN_DIType_IsChanged=true; }
      }
      /// <summary>
      /// 回站处理类型
      /// </summary>
      public bool PCDN_DIType_IsChanged
      {
         get{ return pCDN_DIType_IsChanged; }
         set{ pCDN_DIType_IsChanged = value; }
      }
      /// <summary>
      /// 分料方量
      /// </summary>
      private decimal pCDN_DINum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_DINum_IsChanged=false;
      /// <summary>
      /// 分料方量
      /// </summary>
      public decimal PCDN_DINum
      {
         get{ return pCDN_DINum; }
         set{ pCDN_DINum = value; pCDN_DINum_IsChanged=true; }
      }
      /// <summary>
      /// 分料方量
      /// </summary>
      public bool PCDN_DINum_IsChanged
      {
         get{ return pCDN_DINum_IsChanged; }
         set{ pCDN_DINum_IsChanged = value; }
      }
      /// <summary>
      /// 拌台生产方量
      /// </summary>
      private decimal pCDN_PNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PNum_IsChanged=false;
      /// <summary>
      /// 拌台生产方量
      /// </summary>
      public decimal PCDN_PNum
      {
         get{ return pCDN_PNum; }
         set{ pCDN_PNum = value; pCDN_PNum_IsChanged=true; }
      }
      /// <summary>
      /// 拌台生产方量
      /// </summary>
      public bool PCDN_PNum_IsChanged
      {
         get{ return pCDN_PNum_IsChanged; }
         set{ pCDN_PNum_IsChanged = value; }
      }
      /// <summary>
      /// 本车方量
      /// </summary>
      private decimal pCDN_PCNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PCNum_IsChanged=false;
      /// <summary>
      /// 本车方量
      /// </summary>
      public decimal PCDN_PCNum
      {
         get{ return pCDN_PCNum; }
         set{ pCDN_PCNum = value; pCDN_PCNum_IsChanged=true; }
      }
      /// <summary>
      /// 本车方量
      /// </summary>
      public bool PCDN_PCNum_IsChanged
      {
         get{ return pCDN_PCNum_IsChanged; }
         set{ pCDN_PCNum_IsChanged = value; }
      }
      /// <summary>
      /// 本车车次
      /// </summary>
      private int pCDN_PTOrd;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PTOrd_IsChanged=false;
      /// <summary>
      /// 本车车次
      /// </summary>
      public int PCDN_PTOrd
      {
         get{ return pCDN_PTOrd; }
         set{ pCDN_PTOrd = value; pCDN_PTOrd_IsChanged=true; }
      }
      /// <summary>
      /// 本车车次
      /// </summary>
      public bool PCDN_PTOrd_IsChanged
      {
         get{ return pCDN_PTOrd_IsChanged; }
         set{ pCDN_PTOrd_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      private string pCDN_PCDrv;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PCDrv_IsChanged=false;
      /// <summary>
      /// 驾驶员
      /// </summary>
      public string PCDN_PCDrv
      {
         get{ return pCDN_PCDrv; }
         set{ pCDN_PCDrv = value; pCDN_PCDrv_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      public bool PCDN_PCDrv_IsChanged
      {
         get{ return pCDN_PCDrv_IsChanged; }
         set{ pCDN_PCDrv_IsChanged = value; }
      }
      private string pCDN_Comp;
      private bool pCDN_Comp_IsChanged=false;
      public string PCDN_Comp
      {
         get{ return pCDN_Comp; }
         set{ pCDN_Comp = value; pCDN_Comp_IsChanged=true; }
      }
      public bool PCDN_Comp_IsChanged
      {
         get{ return pCDN_Comp_IsChanged; }
         set{ pCDN_Comp_IsChanged = value; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      private string pCDN_PCCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PCCode_IsChanged=false;
      /// <summary>
      /// 车辆编码
      /// </summary>
      public string PCDN_PCCode
      {
         get{ return pCDN_PCCode; }
         set{ pCDN_PCCode = value; pCDN_PCCode_IsChanged=true; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      public bool PCDN_PCCode_IsChanged
      {
         get{ return pCDN_PCCode_IsChanged; }
         set{ pCDN_PCCode_IsChanged = value; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      private string pCDN_PCNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PCNo_IsChanged=false;
      /// <summary>
      /// 车牌号
      /// </summary>
      public string PCDN_PCNo
      {
         get{ return pCDN_PCNo; }
         set{ pCDN_PCNo = value; pCDN_PCNo_IsChanged=true; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      public bool PCDN_PCNo_IsChanged
      {
         get{ return pCDN_PCNo_IsChanged; }
         set{ pCDN_PCNo_IsChanged = value; }
      }
      /// <summary>
      /// 发货时间
      /// </summary>
      private DateTime pCDN_DDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_DDate_IsChanged=false;
      /// <summary>
      /// 发货时间
      /// </summary>
      public DateTime PCDN_DDate
      {
         get{ return pCDN_DDate; }
         set{ pCDN_DDate = value; pCDN_DDate_IsChanged=true; }
      }
      /// <summary>
      /// 发货时间
      /// </summary>
      public bool PCDN_DDate_IsChanged
      {
         get{ return pCDN_DDate_IsChanged; }
         set{ pCDN_DDate_IsChanged = value; }
      }
      /// <summary>
      /// 到场时间
      /// </summary>
      private DateTime pCDN_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_RDate_IsChanged=false;
      /// <summary>
      /// 到场时间
      /// </summary>
      public DateTime PCDN_RDate
      {
         get{ return pCDN_RDate; }
         set{ pCDN_RDate = value; pCDN_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 到场时间
      /// </summary>
      public bool PCDN_RDate_IsChanged
      {
         get{ return pCDN_RDate_IsChanged; }
         set{ pCDN_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 开始浇注时间
      /// </summary>
      private DateTime pCDN_JBegin;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_JBegin_IsChanged=false;
      /// <summary>
      /// 开始浇注时间
      /// </summary>
      public DateTime PCDN_JBegin
      {
         get{ return pCDN_JBegin; }
         set{ pCDN_JBegin = value; pCDN_JBegin_IsChanged=true; }
      }
      /// <summary>
      /// 开始浇注时间
      /// </summary>
      public bool PCDN_JBegin_IsChanged
      {
         get{ return pCDN_JBegin_IsChanged; }
         set{ pCDN_JBegin_IsChanged = value; }
      }
      /// <summary>
      /// 结束浇注时间
      /// </summary>
      private DateTime pCDN_JEnd;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_JEnd_IsChanged=false;
      /// <summary>
      /// 结束浇注时间
      /// </summary>
      public DateTime PCDN_JEnd
      {
         get{ return pCDN_JEnd; }
         set{ pCDN_JEnd = value; pCDN_JEnd_IsChanged=true; }
      }
      /// <summary>
      /// 结束浇注时间
      /// </summary>
      public bool PCDN_JEnd_IsChanged
      {
         get{ return pCDN_JEnd_IsChanged; }
         set{ pCDN_JEnd_IsChanged = value; }
      }
      /// <summary>
      /// 离场时间
      /// </summary>
      private DateTime pCDN_LDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_LDate_IsChanged=false;
      /// <summary>
      /// 离场时间
      /// </summary>
      public DateTime PCDN_LDate
      {
         get{ return pCDN_LDate; }
         set{ pCDN_LDate = value; pCDN_LDate_IsChanged=true; }
      }
      /// <summary>
      /// 离场时间
      /// </summary>
      public bool PCDN_LDate_IsChanged
      {
         get{ return pCDN_LDate_IsChanged; }
         set{ pCDN_LDate_IsChanged = value; }
      }
      /// <summary>
      /// 回站时间
      /// </summary>
      private DateTime pCDN_BDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_BDate_IsChanged=false;
      /// <summary>
      /// 回站时间
      /// </summary>
      public DateTime PCDN_BDate
      {
         get{ return pCDN_BDate; }
         set{ pCDN_BDate = value; pCDN_BDate_IsChanged=true; }
      }
      /// <summary>
      /// 回站时间
      /// </summary>
      public bool PCDN_BDate_IsChanged
      {
         get{ return pCDN_BDate_IsChanged; }
         set{ pCDN_BDate_IsChanged = value; }
      }
      /// <summary>
      /// 计划方量
      /// </summary>
      private decimal pCDN_PPNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PPNum_IsChanged=false;
      /// <summary>
      /// 计划方量
      /// </summary>
      public decimal PCDN_PPNum
      {
         get{ return pCDN_PPNum; }
         set{ pCDN_PPNum = value; pCDN_PPNum_IsChanged=true; }
      }
      /// <summary>
      /// 计划方量
      /// </summary>
      public bool PCDN_PPNum_IsChanged
      {
         get{ return pCDN_PPNum_IsChanged; }
         set{ pCDN_PPNum_IsChanged = value; }
      }
      /// <summary>
      /// 累计发货
      /// </summary>
      private decimal pCDN_TDNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TDNum_IsChanged=false;
      /// <summary>
      /// 累计发货
      /// </summary>
      public decimal PCDN_TDNum
      {
         get{ return pCDN_TDNum; }
         set{ pCDN_TDNum = value; pCDN_TDNum_IsChanged=true; }
      }
      /// <summary>
      /// 累计发货
      /// </summary>
      public bool PCDN_TDNum_IsChanged
      {
         get{ return pCDN_TDNum_IsChanged; }
         set{ pCDN_TDNum_IsChanged = value; }
      }
      /// <summary>
      /// 累计车数
      /// </summary>
      private int pCDN_TTNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TTNum_IsChanged=false;
      /// <summary>
      /// 累计车数
      /// </summary>
      public int PCDN_TTNum
      {
         get{ return pCDN_TTNum; }
         set{ pCDN_TTNum = value; pCDN_TTNum_IsChanged=true; }
      }
      /// <summary>
      /// 累计车数
      /// </summary>
      public bool PCDN_TTNum_IsChanged
      {
         get{ return pCDN_TTNum_IsChanged; }
         set{ pCDN_TTNum_IsChanged = value; }
      }
      /// <summary>
      /// 返料方量
      /// </summary>
      private decimal pCDN_RTNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_RTNum_IsChanged=false;
      /// <summary>
      /// 返料方量
      /// </summary>
      public decimal PCDN_RTNum
      {
         get{ return pCDN_RTNum; }
         set{ pCDN_RTNum = value; pCDN_RTNum_IsChanged=true; }
      }
      /// <summary>
      /// 返料方量
      /// </summary>
      public bool PCDN_RTNum_IsChanged
      {
         get{ return pCDN_RTNum_IsChanged; }
         set{ pCDN_RTNum_IsChanged = value; }
      }
      /// <summary>
      /// 签收方量
      /// </summary>
      private decimal pCDN_CTNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_CTNum_IsChanged=false;
      /// <summary>
      /// 签收方量
      /// </summary>
      public decimal PCDN_CTNum
      {
         get{ return pCDN_CTNum; }
         set{ pCDN_CTNum = value; pCDN_CTNum_IsChanged=true; }
      }
      /// <summary>
      /// 签收方量
      /// </summary>
      public bool PCDN_CTNum_IsChanged
      {
         get{ return pCDN_CTNum_IsChanged; }
         set{ pCDN_CTNum_IsChanged = value; }
      }
      /// <summary>
      /// 实际使用方量
      /// </summary>
      private decimal pCDN_RRNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_RRNum_IsChanged=false;
      /// <summary>
      /// 实际使用方量
      /// </summary>
      public decimal PCDN_RRNum
      {
         get{ return pCDN_RRNum; }
         set{ pCDN_RRNum = value; pCDN_RRNum_IsChanged=true; }
      }
      /// <summary>
      /// 实际使用方量
      /// </summary>
      public bool PCDN_RRNum_IsChanged
      {
         get{ return pCDN_RRNum_IsChanged; }
         set{ pCDN_RRNum_IsChanged = value; }
      }
      /// <summary>
      /// 小票收益方量
      /// </summary>
      private decimal pCDN_MoreNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_MoreNum_IsChanged=false;
      /// <summary>
      /// 小票收益方量
      /// </summary>
      public decimal PCDN_MoreNum
      {
         get{ return pCDN_MoreNum; }
         set{ pCDN_MoreNum = value; pCDN_MoreNum_IsChanged=true; }
      }
      /// <summary>
      /// 小票收益方量
      /// </summary>
      public bool PCDN_MoreNum_IsChanged
      {
         get{ return pCDN_MoreNum_IsChanged; }
         set{ pCDN_MoreNum_IsChanged = value; }
      }
      /// <summary>
      /// 计划余量
      /// </summary>
      private decimal pCDN_PRNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_PRNum_IsChanged=false;
      /// <summary>
      /// 计划余量
      /// </summary>
      public decimal PCDN_PRNum
      {
         get{ return pCDN_PRNum; }
         set{ pCDN_PRNum = value; pCDN_PRNum_IsChanged=true; }
      }
      /// <summary>
      /// 计划余量
      /// </summary>
      public bool PCDN_PRNum_IsChanged
      {
         get{ return pCDN_PRNum_IsChanged; }
         set{ pCDN_PRNum_IsChanged = value; }
      }
      /// <summary>
      /// 本车回站状态
      /// </summary>
      private string pCDN_BStatus;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_BStatus_IsChanged=false;
      /// <summary>
      /// 本车回站状态
      /// </summary>
      public string PCDN_BStatus
      {
         get{ return pCDN_BStatus; }
         set{ pCDN_BStatus = value; pCDN_BStatus_IsChanged=true; }
      }
      /// <summary>
      /// 本车回站状态
      /// </summary>
      public bool PCDN_BStatus_IsChanged
      {
         get{ return pCDN_BStatus_IsChanged; }
         set{ pCDN_BStatus_IsChanged = value; }
      }
      /// <summary>
      /// 本车返料方量
      /// </summary>
      private decimal pCDN_TRNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TRNum_IsChanged=false;
      /// <summary>
      /// 本车返料方量
      /// </summary>
      public decimal PCDN_TRNum
      {
         get{ return pCDN_TRNum; }
         set{ pCDN_TRNum = value; pCDN_TRNum_IsChanged=true; }
      }
      /// <summary>
      /// 本车返料方量
      /// </summary>
      public bool PCDN_TRNum_IsChanged
      {
         get{ return pCDN_TRNum_IsChanged; }
         set{ pCDN_TRNum_IsChanged = value; }
      }
      /// <summary>
      /// 本车报废方量
      /// </summary>
      private decimal pCDN_TBNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TBNum_IsChanged=false;
      /// <summary>
      /// 本车报废方量
      /// </summary>
      public decimal PCDN_TBNum
      {
         get{ return pCDN_TBNum; }
         set{ pCDN_TBNum = value; pCDN_TBNum_IsChanged=true; }
      }
      /// <summary>
      /// 本车报废方量
      /// </summary>
      public bool PCDN_TBNum_IsChanged
      {
         get{ return pCDN_TBNum_IsChanged; }
         set{ pCDN_TBNum_IsChanged = value; }
      }
      /// <summary>
      /// 回站备注
      /// </summary>
      private string pCDN_TBBak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_TBBak_IsChanged=false;
      /// <summary>
      /// 回站备注
      /// </summary>
      public string PCDN_TBBak
      {
         get{ return pCDN_TBBak; }
         set{ pCDN_TBBak = value; pCDN_TBBak_IsChanged=true; }
      }
      /// <summary>
      /// 回站备注
      /// </summary>
      public bool PCDN_TBBak_IsChanged
      {
         get{ return pCDN_TBBak_IsChanged; }
         set{ pCDN_TBBak_IsChanged = value; }
      }
      /// <summary>
      /// 发货状态
      /// </summary>
      private string pCDN_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDN_Stat_IsChanged=false;
      /// <summary>
      /// 发货状态
      /// </summary>
      public string PCDN_Stat
      {
         get{ return pCDN_Stat; }
         set{ pCDN_Stat = value; pCDN_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 发货状态
      /// </summary>
      public bool PCDN_Stat_IsChanged
      {
         get{ return pCDN_Stat_IsChanged; }
         set{ pCDN_Stat_IsChanged = value; }
      }
      private string pCDN_iType;
      private bool pCDN_iType_IsChanged=false;
      public string PCDN_iType
      {
         get{ return pCDN_iType; }
         set{ pCDN_iType = value; pCDN_iType_IsChanged=true; }
      }
      public bool PCDN_iType_IsChanged
      {
         get{ return pCDN_iType_IsChanged; }
         set{ pCDN_iType_IsChanged = value; }
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
      private string pCDN_SourceCode;
      private bool pCDN_SourceCode_IsChanged=false;
      public string PCDN_SourceCode
      {
         get{ return pCDN_SourceCode; }
         set{ pCDN_SourceCode = value; pCDN_SourceCode_IsChanged=true; }
      }
      public bool PCDN_SourceCode_IsChanged
      {
         get{ return pCDN_SourceCode_IsChanged; }
         set{ pCDN_SourceCode_IsChanged = value; }
      }
   }
}
