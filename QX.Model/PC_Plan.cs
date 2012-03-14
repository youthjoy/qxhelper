using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产计划
   /// </summary>
   [Serializable]
   public partial class PC_Plan
   {
      private decimal pCP_ID;
      private bool pCP_ID_IsChanged=false;
      public decimal PCP_ID
      {
         get{ return pCP_ID; }
         set{ pCP_ID = value; pCP_ID_IsChanged=true; }
      }
      public bool PCP_ID_IsChanged
      {
         get{ return pCP_ID_IsChanged; }
         set{ pCP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产计划编码
      /// </summary>
      private string pCP_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PCode_IsChanged=false;
      /// <summary>
      /// 生产计划编码
      /// </summary>
      public string PCP_PCode
      {
         get{ return pCP_PCode; }
         set{ pCP_PCode = value; pCP_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 生产计划编码
      /// </summary>
      public bool PCP_PCode_IsChanged
      {
         get{ return pCP_PCode_IsChanged; }
         set{ pCP_PCode_IsChanged = value; }
      }
      private string pCP_SCode;
      private bool pCP_SCode_IsChanged=false;
      public string PCP_SCode
      {
         get{ return pCP_SCode; }
         set{ pCP_SCode = value; pCP_SCode_IsChanged=true; }
      }
      public bool PCP_SCode_IsChanged
      {
         get{ return pCP_SCode_IsChanged; }
         set{ pCP_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 混凝土名称
      /// </summary>
      private string pCP_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Name_IsChanged=false;
      /// <summary>
      /// 混凝土名称
      /// </summary>
      public string PCP_Name
      {
         get{ return pCP_Name; }
         set{ pCP_Name = value; pCP_Name_IsChanged=true; }
      }
      /// <summary>
      /// 混凝土名称
      /// </summary>
      public bool PCP_Name_IsChanged
      {
         get{ return pCP_Name_IsChanged; }
         set{ pCP_Name_IsChanged = value; }
      }
      /// <summary>
      /// 参考客户计划编码
      /// </summary>
      private string pCP_CPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_CPCode_IsChanged=false;
      /// <summary>
      /// 参考客户计划编码
      /// </summary>
      public string PCP_CPCode
      {
         get{ return pCP_CPCode; }
         set{ pCP_CPCode = value; pCP_CPCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考客户计划编码
      /// </summary>
      public bool PCP_CPCode_IsChanged
      {
         get{ return pCP_CPCode_IsChanged; }
         set{ pCP_CPCode_IsChanged = value; }
      }
      /// <summary>
      /// 项目编码
      /// </summary>
      private string pCP_PRCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PRCode_IsChanged=false;
      /// <summary>
      /// 项目编码
      /// </summary>
      public string PCP_PRCode
      {
         get{ return pCP_PRCode; }
         set{ pCP_PRCode = value; pCP_PRCode_IsChanged=true; }
      }
      /// <summary>
      /// 项目编码
      /// </summary>
      public bool PCP_PRCode_IsChanged
      {
         get{ return pCP_PRCode_IsChanged; }
         set{ pCP_PRCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string pCP_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string PCP_CCode
      {
         get{ return pCP_CCode; }
         set{ pCP_CCode = value; pCP_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool PCP_CCode_IsChanged
      {
         get{ return pCP_CCode_IsChanged; }
         set{ pCP_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 浇筑部位
      /// </summary>
      private string pCP_Part;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Part_IsChanged=false;
      /// <summary>
      /// 浇筑部位
      /// </summary>
      public string PCP_Part
      {
         get{ return pCP_Part; }
         set{ pCP_Part = value; pCP_Part_IsChanged=true; }
      }
      /// <summary>
      /// 浇筑部位
      /// </summary>
      public bool PCP_Part_IsChanged
      {
         get{ return pCP_Part_IsChanged; }
         set{ pCP_Part_IsChanged = value; }
      }
      /// <summary>
      /// 坍落度
      /// </summary>
      private string pCP_Slump;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Slump_IsChanged=false;
      /// <summary>
      /// 坍落度
      /// </summary>
      public string PCP_Slump
      {
         get{ return pCP_Slump; }
         set{ pCP_Slump = value; pCP_Slump_IsChanged=true; }
      }
      /// <summary>
      /// 坍落度
      /// </summary>
      public bool PCP_Slump_IsChanged
      {
         get{ return pCP_Slump_IsChanged; }
         set{ pCP_Slump_IsChanged = value; }
      }
      /// <summary>
      /// 项目地址
      /// </summary>
      private string pCP_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Addr_IsChanged=false;
      /// <summary>
      /// 项目地址
      /// </summary>
      public string PCP_Addr
      {
         get{ return pCP_Addr; }
         set{ pCP_Addr = value; pCP_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 项目地址
      /// </summary>
      public bool PCP_Addr_IsChanged
      {
         get{ return pCP_Addr_IsChanged; }
         set{ pCP_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 布管标记
      /// </summary>
      private string pCP_IsPipe;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_IsPipe_IsChanged=false;
      /// <summary>
      /// 布管标记
      /// </summary>
      public string PCP_IsPipe
      {
         get{ return pCP_IsPipe; }
         set{ pCP_IsPipe = value; pCP_IsPipe_IsChanged=true; }
      }
      /// <summary>
      /// 布管标记
      /// </summary>
      public bool PCP_IsPipe_IsChanged
      {
         get{ return pCP_IsPipe_IsChanged; }
         set{ pCP_IsPipe_IsChanged = value; }
      }
      /// <summary>
      /// 产品编码
      /// </summary>
      private string pCP_PLCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PLCode_IsChanged=false;
      /// <summary>
      /// 产品编码
      /// </summary>
      public string PCP_PLCode
      {
         get{ return pCP_PLCode; }
         set{ pCP_PLCode = value; pCP_PLCode_IsChanged=true; }
      }
      /// <summary>
      /// 产品编码
      /// </summary>
      public bool PCP_PLCode_IsChanged
      {
         get{ return pCP_PLCode_IsChanged; }
         set{ pCP_PLCode_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string pCP_Leve;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Leve_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string PCP_Leve
      {
         get{ return pCP_Leve; }
         set{ pCP_Leve = value; pCP_Leve_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool PCP_Leve_IsChanged
      {
         get{ return pCP_Leve_IsChanged; }
         set{ pCP_Leve_IsChanged = value; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      private string pCP_Impervious;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Impervious_IsChanged=false;
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public string PCP_Impervious
      {
         get{ return pCP_Impervious; }
         set{ pCP_Impervious = value; pCP_Impervious_IsChanged=true; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public bool PCP_Impervious_IsChanged
      {
         get{ return pCP_Impervious_IsChanged; }
         set{ pCP_Impervious_IsChanged = value; }
      }
      private string pCP_SPC;
      private bool pCP_SPC_IsChanged=false;
      public string PCP_SPC
      {
         get{ return pCP_SPC; }
         set{ pCP_SPC = value; pCP_SPC_IsChanged=true; }
      }
      public bool PCP_SPC_IsChanged
      {
         get{ return pCP_SPC_IsChanged; }
         set{ pCP_SPC_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料1
      /// </summary>
      private string pCP_Special1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Special1_IsChanged=false;
      /// <summary>
      /// 特殊材料1
      /// </summary>
      public string PCP_Special1
      {
         get{ return pCP_Special1; }
         set{ pCP_Special1 = value; pCP_Special1_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料1
      /// </summary>
      public bool PCP_Special1_IsChanged
      {
         get{ return pCP_Special1_IsChanged; }
         set{ pCP_Special1_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料2
      /// </summary>
      private string pCP_Special2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Special2_IsChanged=false;
      /// <summary>
      /// 特殊材料2
      /// </summary>
      public string PCP_Special2
      {
         get{ return pCP_Special2; }
         set{ pCP_Special2 = value; pCP_Special2_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料2
      /// </summary>
      public bool PCP_Special2_IsChanged
      {
         get{ return pCP_Special2_IsChanged; }
         set{ pCP_Special2_IsChanged = value; }
      }
      private string pCP_Special3;
      private bool pCP_Special3_IsChanged=false;
      public string PCP_Special3
      {
         get{ return pCP_Special3; }
         set{ pCP_Special3 = value; pCP_Special3_IsChanged=true; }
      }
      public bool PCP_Special3_IsChanged
      {
         get{ return pCP_Special3_IsChanged; }
         set{ pCP_Special3_IsChanged = value; }
      }
      private string pCP_Special4;
      private bool pCP_Special4_IsChanged=false;
      public string PCP_Special4
      {
         get{ return pCP_Special4; }
         set{ pCP_Special4 = value; pCP_Special4_IsChanged=true; }
      }
      public bool PCP_Special4_IsChanged
      {
         get{ return pCP_Special4_IsChanged; }
         set{ pCP_Special4_IsChanged = value; }
      }
      private string pCP_Special5;
      private bool pCP_Special5_IsChanged=false;
      public string PCP_Special5
      {
         get{ return pCP_Special5; }
         set{ pCP_Special5 = value; pCP_Special5_IsChanged=true; }
      }
      public bool PCP_Special5_IsChanged
      {
         get{ return pCP_Special5_IsChanged; }
         set{ pCP_Special5_IsChanged = value; }
      }
      /// <summary>
      /// 计划开盘时间
      /// </summary>
      private DateTime pCP_PDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PDate_IsChanged=false;
      /// <summary>
      /// 计划开盘时间
      /// </summary>
      public DateTime PCP_PDate
      {
         get{ return pCP_PDate; }
         set{ pCP_PDate = value; pCP_PDate_IsChanged=true; }
      }
      /// <summary>
      /// 计划开盘时间
      /// </summary>
      public bool PCP_PDate_IsChanged
      {
         get{ return pCP_PDate_IsChanged; }
         set{ pCP_PDate_IsChanged = value; }
      }
      /// <summary>
      /// 实际开盘时间
      /// </summary>
      private DateTime pCP_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_RDate_IsChanged=false;
      /// <summary>
      /// 实际开盘时间
      /// </summary>
      public DateTime PCP_RDate
      {
         get{ return pCP_RDate; }
         set{ pCP_RDate = value; pCP_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 实际开盘时间
      /// </summary>
      public bool PCP_RDate_IsChanged
      {
         get{ return pCP_RDate_IsChanged; }
         set{ pCP_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 计划制定人
      /// </summary>
      private string pCP_POwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_POwner_IsChanged=false;
      /// <summary>
      /// 计划制定人
      /// </summary>
      public string PCP_POwner
      {
         get{ return pCP_POwner; }
         set{ pCP_POwner = value; pCP_POwner_IsChanged=true; }
      }
      /// <summary>
      /// 计划制定人
      /// </summary>
      public bool PCP_POwner_IsChanged
      {
         get{ return pCP_POwner_IsChanged; }
         set{ pCP_POwner_IsChanged = value; }
      }
      private string pCP_POwnerName;
      private bool pCP_POwnerName_IsChanged=false;
      public string PCP_POwnerName
      {
         get{ return pCP_POwnerName; }
         set{ pCP_POwnerName = value; pCP_POwnerName_IsChanged=true; }
      }
      public bool PCP_POwnerName_IsChanged
      {
         get{ return pCP_POwnerName_IsChanged; }
         set{ pCP_POwnerName_IsChanged = value; }
      }
      /// <summary>
      /// 计划制定时间
      /// </summary>
      private DateTime pCP_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Date_IsChanged=false;
      /// <summary>
      /// 计划制定时间
      /// </summary>
      public DateTime PCP_Date
      {
         get{ return pCP_Date; }
         set{ pCP_Date = value; pCP_Date_IsChanged=true; }
      }
      /// <summary>
      /// 计划制定时间
      /// </summary>
      public bool PCP_Date_IsChanged
      {
         get{ return pCP_Date_IsChanged; }
         set{ pCP_Date_IsChanged = value; }
      }
      /// <summary>
      /// 当前审批状态
      /// </summary>
      private string pCP_CureStep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_CureStep_IsChanged=false;
      /// <summary>
      /// 当前审批状态
      /// </summary>
      public string PCP_CureStep
      {
         get{ return pCP_CureStep; }
         set{ pCP_CureStep = value; pCP_CureStep_IsChanged=true; }
      }
      /// <summary>
      /// 当前审批状态
      /// </summary>
      public bool PCP_CureStep_IsChanged
      {
         get{ return pCP_CureStep_IsChanged; }
         set{ pCP_CureStep_IsChanged = value; }
      }
      /// <summary>
      /// 下一审批状态
      /// </summary>
      private string pCP_NextStep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_NextStep_IsChanged=false;
      /// <summary>
      /// 下一审批状态
      /// </summary>
      public string PCP_NextStep
      {
         get{ return pCP_NextStep; }
         set{ pCP_NextStep = value; pCP_NextStep_IsChanged=true; }
      }
      /// <summary>
      /// 下一审批状态
      /// </summary>
      public bool PCP_NextStep_IsChanged
      {
         get{ return pCP_NextStep_IsChanged; }
         set{ pCP_NextStep_IsChanged = value; }
      }
      /// <summary>
      /// 是否已制定配合比
      /// </summary>
      private int pCP_IsTech;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_IsTech_IsChanged=false;
      /// <summary>
      /// 是否已制定配合比
      /// </summary>
      public int PCP_IsTech
      {
         get{ return pCP_IsTech; }
         set{ pCP_IsTech = value; pCP_IsTech_IsChanged=true; }
      }
      /// <summary>
      /// 是否已制定配合比
      /// </summary>
      public bool PCP_IsTech_IsChanged
      {
         get{ return pCP_IsTech_IsChanged; }
         set{ pCP_IsTech_IsChanged = value; }
      }
      /// <summary>
      /// 是否开盘
      /// </summary>
      private int pCP_IsStart;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_IsStart_IsChanged=false;
      /// <summary>
      /// 是否开盘
      /// </summary>
      public int PCP_IsStart
      {
         get{ return pCP_IsStart; }
         set{ pCP_IsStart = value; pCP_IsStart_IsChanged=true; }
      }
      /// <summary>
      /// 是否开盘
      /// </summary>
      public bool PCP_IsStart_IsChanged
      {
         get{ return pCP_IsStart_IsChanged; }
         set{ pCP_IsStart_IsChanged = value; }
      }
      /// <summary>
      /// 工长人数
      /// </summary>
      private string pCP_PMNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PMNum_IsChanged=false;
      /// <summary>
      /// 工长人数
      /// </summary>
      public string PCP_PMNum
      {
         get{ return pCP_PMNum; }
         set{ pCP_PMNum = value; pCP_PMNum_IsChanged=true; }
      }
      /// <summary>
      /// 工长人数
      /// </summary>
      public bool PCP_PMNum_IsChanged
      {
         get{ return pCP_PMNum_IsChanged; }
         set{ pCP_PMNum_IsChanged = value; }
      }
      /// <summary>
      /// 泵工人数
      /// </summary>
      private string pCP_PUNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PUNum_IsChanged=false;
      /// <summary>
      /// 泵工人数
      /// </summary>
      public string PCP_PUNum
      {
         get{ return pCP_PUNum; }
         set{ pCP_PUNum = value; pCP_PUNum_IsChanged=true; }
      }
      /// <summary>
      /// 泵工人数
      /// </summary>
      public bool PCP_PUNum_IsChanged
      {
         get{ return pCP_PUNum_IsChanged; }
         set{ pCP_PUNum_IsChanged = value; }
      }
      /// <summary>
      /// 管工人数
      /// </summary>
      private string pCP_PINum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PINum_IsChanged=false;
      /// <summary>
      /// 管工人数
      /// </summary>
      public string PCP_PINum
      {
         get{ return pCP_PINum; }
         set{ pCP_PINum = value; pCP_PINum_IsChanged=true; }
      }
      /// <summary>
      /// 管工人数
      /// </summary>
      public bool PCP_PINum_IsChanged
      {
         get{ return pCP_PINum_IsChanged; }
         set{ pCP_PINum_IsChanged = value; }
      }
      /// <summary>
      /// 泵机数量
      /// </summary>
      private string pCP_PJNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PJNum_IsChanged=false;
      /// <summary>
      /// 泵机数量
      /// </summary>
      public string PCP_PJNum
      {
         get{ return pCP_PJNum; }
         set{ pCP_PJNum = value; pCP_PJNum_IsChanged=true; }
      }
      /// <summary>
      /// 泵机数量
      /// </summary>
      public bool PCP_PJNum_IsChanged
      {
         get{ return pCP_PJNum_IsChanged; }
         set{ pCP_PJNum_IsChanged = value; }
      }
      /// <summary>
      /// 罐车数量
      /// </summary>
      private int pCP_PTNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PTNum_IsChanged=false;
      /// <summary>
      /// 罐车数量
      /// </summary>
      public int PCP_PTNum
      {
         get{ return pCP_PTNum; }
         set{ pCP_PTNum = value; pCP_PTNum_IsChanged=true; }
      }
      /// <summary>
      /// 罐车数量
      /// </summary>
      public bool PCP_PTNum_IsChanged
      {
         get{ return pCP_PTNum_IsChanged; }
         set{ pCP_PTNum_IsChanged = value; }
      }
      /// <summary>
      /// 管件需求
      /// </summary>
      private string pCP_PWNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PWNum_IsChanged=false;
      /// <summary>
      /// 管件需求
      /// </summary>
      public string PCP_PWNum
      {
         get{ return pCP_PWNum; }
         set{ pCP_PWNum = value; pCP_PWNum_IsChanged=true; }
      }
      /// <summary>
      /// 管件需求
      /// </summary>
      public bool PCP_PWNum_IsChanged
      {
         get{ return pCP_PWNum_IsChanged; }
         set{ pCP_PWNum_IsChanged = value; }
      }
      /// <summary>
      /// 计划方量
      /// </summary>
      private decimal pCP_PPNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PPNum_IsChanged=false;
      /// <summary>
      /// 计划方量
      /// </summary>
      public decimal PCP_PPNum
      {
         get{ return pCP_PPNum; }
         set{ pCP_PPNum = value; pCP_PPNum_IsChanged=true; }
      }
      /// <summary>
      /// 计划方量
      /// </summary>
      public bool PCP_PPNum_IsChanged
      {
         get{ return pCP_PPNum_IsChanged; }
         set{ pCP_PPNum_IsChanged = value; }
      }
      /// <summary>
      /// 实际完成方量
      /// </summary>
      private decimal pCP_PRNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PRNum_IsChanged=false;
      /// <summary>
      /// 实际完成方量
      /// </summary>
      public decimal PCP_PRNum
      {
         get{ return pCP_PRNum; }
         set{ pCP_PRNum = value; pCP_PRNum_IsChanged=true; }
      }
      /// <summary>
      /// 实际完成方量
      /// </summary>
      public bool PCP_PRNum_IsChanged
      {
         get{ return pCP_PRNum_IsChanged; }
         set{ pCP_PRNum_IsChanged = value; }
      }
      /// <summary>
      /// 实际发车数量
      /// </summary>
      private int pCP_PTRNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PTRNum_IsChanged=false;
      /// <summary>
      /// 实际发车数量
      /// </summary>
      public int PCP_PTRNum
      {
         get{ return pCP_PTRNum; }
         set{ pCP_PTRNum = value; pCP_PTRNum_IsChanged=true; }
      }
      /// <summary>
      /// 实际发车数量
      /// </summary>
      public bool PCP_PTRNum_IsChanged
      {
         get{ return pCP_PTRNum_IsChanged; }
         set{ pCP_PTRNum_IsChanged = value; }
      }
      /// <summary>
      /// 返回方量
      /// </summary>
      private decimal pCP_PPRNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PPRNum_IsChanged=false;
      /// <summary>
      /// 返回方量
      /// </summary>
      public decimal PCP_PPRNum
      {
         get{ return pCP_PPRNum; }
         set{ pCP_PPRNum = value; pCP_PPRNum_IsChanged=true; }
      }
      /// <summary>
      /// 返回方量
      /// </summary>
      public bool PCP_PPRNum_IsChanged
      {
         get{ return pCP_PPRNum_IsChanged; }
         set{ pCP_PPRNum_IsChanged = value; }
      }
      /// <summary>
      /// 计划方量金额
      /// </summary>
      private decimal pCP_PPMNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PPMNum_IsChanged=false;
      /// <summary>
      /// 计划方量金额
      /// </summary>
      public decimal PCP_PPMNum
      {
         get{ return pCP_PPMNum; }
         set{ pCP_PPMNum = value; pCP_PPMNum_IsChanged=true; }
      }
      /// <summary>
      /// 计划方量金额
      /// </summary>
      public bool PCP_PPMNum_IsChanged
      {
         get{ return pCP_PPMNum_IsChanged; }
         set{ pCP_PPMNum_IsChanged = value; }
      }
      /// <summary>
      /// 计划配送费用
      /// </summary>
      private decimal pCP_PTMNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_PTMNum_IsChanged=false;
      /// <summary>
      /// 计划配送费用
      /// </summary>
      public decimal PCP_PTMNum
      {
         get{ return pCP_PTMNum; }
         set{ pCP_PTMNum = value; pCP_PTMNum_IsChanged=true; }
      }
      /// <summary>
      /// 计划配送费用
      /// </summary>
      public bool PCP_PTMNum_IsChanged
      {
         get{ return pCP_PTMNum_IsChanged; }
         set{ pCP_PTMNum_IsChanged = value; }
      }
      /// <summary>
      /// 配比类型
      /// </summary>
      private string pCP_TechType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_TechType_IsChanged=false;
      /// <summary>
      /// 配比类型
      /// </summary>
      public string PCP_TechType
      {
         get{ return pCP_TechType; }
         set{ pCP_TechType = value; pCP_TechType_IsChanged=true; }
      }
      /// <summary>
      /// 配比类型
      /// </summary>
      public bool PCP_TechType_IsChanged
      {
         get{ return pCP_TechType_IsChanged; }
         set{ pCP_TechType_IsChanged = value; }
      }
      /// <summary>
      /// 送货限载
      /// </summary>
      private decimal pCP_Limit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Limit_IsChanged=false;
      /// <summary>
      /// 送货限载
      /// </summary>
      public decimal PCP_Limit
      {
         get{ return pCP_Limit; }
         set{ pCP_Limit = value; pCP_Limit_IsChanged=true; }
      }
      /// <summary>
      /// 送货限载
      /// </summary>
      public bool PCP_Limit_IsChanged
      {
         get{ return pCP_Limit_IsChanged; }
         set{ pCP_Limit_IsChanged = value; }
      }
      /// <summary>
      /// 送货频率
      /// </summary>
      private int pCP_Frequence;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Frequence_IsChanged=false;
      /// <summary>
      /// 送货频率
      /// </summary>
      public int PCP_Frequence
      {
         get{ return pCP_Frequence; }
         set{ pCP_Frequence = value; pCP_Frequence_IsChanged=true; }
      }
      /// <summary>
      /// 送货频率
      /// </summary>
      public bool PCP_Frequence_IsChanged
      {
         get{ return pCP_Frequence_IsChanged; }
         set{ pCP_Frequence_IsChanged = value; }
      }
      /// <summary>
      /// 最后发车时间
      /// </summary>
      private DateTime pCP_LastDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_LastDate_IsChanged=false;
      /// <summary>
      /// 最后发车时间
      /// </summary>
      public DateTime PCP_LastDate
      {
         get{ return pCP_LastDate; }
         set{ pCP_LastDate = value; pCP_LastDate_IsChanged=true; }
      }
      /// <summary>
      /// 最后发车时间
      /// </summary>
      public bool PCP_LastDate_IsChanged
      {
         get{ return pCP_LastDate_IsChanged; }
         set{ pCP_LastDate_IsChanged = value; }
      }
      /// <summary>
      /// 最后发车小票
      /// </summary>
      private string pCP_LastNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_LastNo_IsChanged=false;
      /// <summary>
      /// 最后发车小票
      /// </summary>
      public string PCP_LastNo
      {
         get{ return pCP_LastNo; }
         set{ pCP_LastNo = value; pCP_LastNo_IsChanged=true; }
      }
      /// <summary>
      /// 最后发车小票
      /// </summary>
      public bool PCP_LastNo_IsChanged
      {
         get{ return pCP_LastNo_IsChanged; }
         set{ pCP_LastNo_IsChanged = value; }
      }
      /// <summary>
      /// 配送方式
      /// </summary>
      private string pCP_Transpot;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCP_Transpot_IsChanged=false;
      /// <summary>
      /// 配送方式
      /// </summary>
      public string PCP_Transpot
      {
         get{ return pCP_Transpot; }
         set{ pCP_Transpot = value; pCP_Transpot_IsChanged=true; }
      }
      /// <summary>
      /// 配送方式
      /// </summary>
      public bool PCP_Transpot_IsChanged
      {
         get{ return pCP_Transpot_IsChanged; }
         set{ pCP_Transpot_IsChanged = value; }
      }
      private int pCP_Order;
      private bool pCP_Order_IsChanged=false;
      public int PCP_Order
      {
         get{ return pCP_Order; }
         set{ pCP_Order = value; pCP_Order_IsChanged=true; }
      }
      public bool PCP_Order_IsChanged
      {
         get{ return pCP_Order_IsChanged; }
         set{ pCP_Order_IsChanged = value; }
      }
      private string pCP_DBack;
      private bool pCP_DBack_IsChanged=false;
      public string PCP_DBack
      {
         get{ return pCP_DBack; }
         set{ pCP_DBack = value; pCP_DBack_IsChanged=true; }
      }
      public bool PCP_DBack_IsChanged
      {
         get{ return pCP_DBack_IsChanged; }
         set{ pCP_DBack_IsChanged = value; }
      }
      private string pCP_Status;
      private bool pCP_Status_IsChanged=false;
      public string PCP_Status
      {
         get{ return pCP_Status; }
         set{ pCP_Status = value; pCP_Status_IsChanged=true; }
      }
      public bool PCP_Status_IsChanged
      {
         get{ return pCP_Status_IsChanged; }
         set{ pCP_Status_IsChanged = value; }
      }
      private string pCP_Bak;
      private bool pCP_Bak_IsChanged=false;
      public string PCP_Bak
      {
         get{ return pCP_Bak; }
         set{ pCP_Bak = value; pCP_Bak_IsChanged=true; }
      }
      public bool PCP_Bak_IsChanged
      {
         get{ return pCP_Bak_IsChanged; }
         set{ pCP_Bak_IsChanged = value; }
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
      private string pCP_Udef1;
      private bool pCP_Udef1_IsChanged=false;
      public string PCP_Udef1
      {
         get{ return pCP_Udef1; }
         set{ pCP_Udef1 = value; pCP_Udef1_IsChanged=true; }
      }
      public bool PCP_Udef1_IsChanged
      {
         get{ return pCP_Udef1_IsChanged; }
         set{ pCP_Udef1_IsChanged = value; }
      }
      private string pCP_Udef2;
      private bool pCP_Udef2_IsChanged=false;
      public string PCP_Udef2
      {
         get{ return pCP_Udef2; }
         set{ pCP_Udef2 = value; pCP_Udef2_IsChanged=true; }
      }
      public bool PCP_Udef2_IsChanged
      {
         get{ return pCP_Udef2_IsChanged; }
         set{ pCP_Udef2_IsChanged = value; }
      }
      private string pCP_Udef3;
      private bool pCP_Udef3_IsChanged=false;
      public string PCP_Udef3
      {
         get{ return pCP_Udef3; }
         set{ pCP_Udef3 = value; pCP_Udef3_IsChanged=true; }
      }
      public bool PCP_Udef3_IsChanged
      {
         get{ return pCP_Udef3_IsChanged; }
         set{ pCP_Udef3_IsChanged = value; }
      }
      private string pCP_Udef4;
      private bool pCP_Udef4_IsChanged=false;
      public string PCP_Udef4
      {
         get{ return pCP_Udef4; }
         set{ pCP_Udef4 = value; pCP_Udef4_IsChanged=true; }
      }
      public bool PCP_Udef4_IsChanged
      {
         get{ return pCP_Udef4_IsChanged; }
         set{ pCP_Udef4_IsChanged = value; }
      }
      private string pCP_Udef5;
      private bool pCP_Udef5_IsChanged=false;
      public string PCP_Udef5
      {
         get{ return pCP_Udef5; }
         set{ pCP_Udef5 = value; pCP_Udef5_IsChanged=true; }
      }
      public bool PCP_Udef5_IsChanged
      {
         get{ return pCP_Udef5_IsChanged; }
         set{ pCP_Udef5_IsChanged = value; }
      }
      private string pCP_Udef6;
      private bool pCP_Udef6_IsChanged=false;
      public string PCP_Udef6
      {
         get{ return pCP_Udef6; }
         set{ pCP_Udef6 = value; pCP_Udef6_IsChanged=true; }
      }
      public bool PCP_Udef6_IsChanged
      {
         get{ return pCP_Udef6_IsChanged; }
         set{ pCP_Udef6_IsChanged = value; }
      }
      private string pCP_Udef7;
      private bool pCP_Udef7_IsChanged=false;
      public string PCP_Udef7
      {
         get{ return pCP_Udef7; }
         set{ pCP_Udef7 = value; pCP_Udef7_IsChanged=true; }
      }
      public bool PCP_Udef7_IsChanged
      {
         get{ return pCP_Udef7_IsChanged; }
         set{ pCP_Udef7_IsChanged = value; }
      }
      private string auditCurAudit;
      private bool auditCurAudit_IsChanged=false;
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      private string auditStat;
      private bool auditStat_IsChanged=false;
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private decimal pCP_LNum;
      private bool pCP_LNum_IsChanged=false;
      public decimal PCP_LNum
      {
         get{ return pCP_LNum; }
         set{ pCP_LNum = value; pCP_LNum_IsChanged=true; }
      }
      public bool PCP_LNum_IsChanged
      {
         get{ return pCP_LNum_IsChanged; }
         set{ pCP_LNum_IsChanged = value; }
      }
      private decimal pCP_ANum;
      private bool pCP_ANum_IsChanged=false;
      public decimal PCP_ANum
      {
         get{ return pCP_ANum; }
         set{ pCP_ANum = value; pCP_ANum_IsChanged=true; }
      }
      public bool PCP_ANum_IsChanged
      {
         get{ return pCP_ANum_IsChanged; }
         set{ pCP_ANum_IsChanged = value; }
      }
      private decimal pCP_Price;
      private bool pCP_Price_IsChanged=false;
      public decimal PCP_Price
      {
         get{ return pCP_Price; }
         set{ pCP_Price = value; pCP_Price_IsChanged=true; }
      }
      public bool PCP_Price_IsChanged
      {
         get{ return pCP_Price_IsChanged; }
         set{ pCP_Price_IsChanged = value; }
      }
      private decimal pCP_Sum;
      private bool pCP_Sum_IsChanged=false;
      public decimal PCP_Sum
      {
         get{ return pCP_Sum; }
         set{ pCP_Sum = value; pCP_Sum_IsChanged=true; }
      }
      public bool PCP_Sum_IsChanged
      {
         get{ return pCP_Sum_IsChanged; }
         set{ pCP_Sum_IsChanged = value; }
      }
      private decimal pCP_TankerFee;
      private bool pCP_TankerFee_IsChanged=false;
      public decimal PCP_TankerFee
      {
         get{ return pCP_TankerFee; }
         set{ pCP_TankerFee = value; pCP_TankerFee_IsChanged=true; }
      }
      public bool PCP_TankerFee_IsChanged
      {
         get{ return pCP_TankerFee_IsChanged; }
         set{ pCP_TankerFee_IsChanged = value; }
      }
      private decimal pCP_PumpFee;
      private bool pCP_PumpFee_IsChanged=false;
      public decimal PCP_PumpFee
      {
         get{ return pCP_PumpFee; }
         set{ pCP_PumpFee = value; pCP_PumpFee_IsChanged=true; }
      }
      public bool PCP_PumpFee_IsChanged
      {
         get{ return pCP_PumpFee_IsChanged; }
         set{ pCP_PumpFee_IsChanged = value; }
      }
      private string pCP_Operator;
      private bool pCP_Operator_IsChanged=false;
      public string PCP_Operator
      {
         get{ return pCP_Operator; }
         set{ pCP_Operator = value; pCP_Operator_IsChanged=true; }
      }
      public bool PCP_Operator_IsChanged
      {
         get{ return pCP_Operator_IsChanged; }
         set{ pCP_Operator_IsChanged = value; }
      }
      private string pCP_Schdule;
      private bool pCP_Schdule_IsChanged=false;
      public string PCP_Schdule
      {
         get{ return pCP_Schdule; }
         set{ pCP_Schdule = value; pCP_Schdule_IsChanged=true; }
      }
      public bool PCP_Schdule_IsChanged
      {
         get{ return pCP_Schdule_IsChanged; }
         set{ pCP_Schdule_IsChanged = value; }
      }
      private string pCP_Station;
      private bool pCP_Station_IsChanged=false;
      public string PCP_Station
      {
         get{ return pCP_Station; }
         set{ pCP_Station = value; pCP_Station_IsChanged=true; }
      }
      public bool PCP_Station_IsChanged
      {
         get{ return pCP_Station_IsChanged; }
         set{ pCP_Station_IsChanged = value; }
      }
      private string pCP_StatonName;
      private bool pCP_StatonName_IsChanged=false;
      public string PCP_StatonName
      {
         get{ return pCP_StatonName; }
         set{ pCP_StatonName = value; pCP_StatonName_IsChanged=true; }
      }
      public bool PCP_StatonName_IsChanged
      {
         get{ return pCP_StatonName_IsChanged; }
         set{ pCP_StatonName_IsChanged = value; }
      }
   }
}
