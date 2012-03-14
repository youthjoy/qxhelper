using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 原料检测记录
   /// </summary>
   [Serializable]
   public partial class TC_RRecord
   {
      private decimal rMCheck_ID;
      private bool rMCheck_ID_IsChanged=false;
      public decimal RMCheck_ID
      {
         get{ return rMCheck_ID; }
         set{ rMCheck_ID = value; rMCheck_ID_IsChanged=true; }
      }
      public bool RMCheck_ID_IsChanged
      {
         get{ return rMCheck_ID_IsChanged; }
         set{ rMCheck_ID_IsChanged = value; }
      }
      private string tCRR_ID;
      private bool tCRR_ID_IsChanged=false;
      public string TCRR_ID
      {
         get{ return tCRR_ID; }
         set{ tCRR_ID = value; tCRR_ID_IsChanged=true; }
      }
      public bool TCRR_ID_IsChanged
      {
         get{ return tCRR_ID_IsChanged; }
         set{ tCRR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 检验批次号
      /// </summary>
      private string tCRR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_Code_IsChanged=false;
      /// <summary>
      /// 检验批次号
      /// </summary>
      public string TCRR_Code
      {
         get{ return tCRR_Code; }
         set{ tCRR_Code = value; tCRR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 检验批次号
      /// </summary>
      public bool TCRR_Code_IsChanged
      {
         get{ return tCRR_Code_IsChanged; }
         set{ tCRR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string tCRR_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_SName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string TCRR_SName
      {
         get{ return tCRR_SName; }
         set{ tCRR_SName = value; tCRR_SName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool TCRR_SName_IsChanged
      {
         get{ return tCRR_SName_IsChanged; }
         set{ tCRR_SName_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string tCRR_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string TCRR_SCode
      {
         get{ return tCRR_SCode; }
         set{ tCRR_SCode = value; tCRR_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool TCRR_SCode_IsChanged
      {
         get{ return tCRR_SCode_IsChanged; }
         set{ tCRR_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string tCRR_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string TCRR_MCode
      {
         get{ return tCRR_MCode; }
         set{ tCRR_MCode = value; tCRR_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool TCRR_MCode_IsChanged
      {
         get{ return tCRR_MCode_IsChanged; }
         set{ tCRR_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string tCRR_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string TCRR_MName
      {
         get{ return tCRR_MName; }
         set{ tCRR_MName = value; tCRR_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool TCRR_MName_IsChanged
      {
         get{ return tCRR_MName_IsChanged; }
         set{ tCRR_MName_IsChanged = value; }
      }
      /// <summary>
      /// 取样日期
      /// </summary>
      private DateTime tCRR_GDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_GDate_IsChanged=false;
      /// <summary>
      /// 取样日期
      /// </summary>
      public DateTime TCRR_GDate
      {
         get{ return tCRR_GDate; }
         set{ tCRR_GDate = value; tCRR_GDate_IsChanged=true; }
      }
      /// <summary>
      /// 取样日期
      /// </summary>
      public bool TCRR_GDate_IsChanged
      {
         get{ return tCRR_GDate_IsChanged; }
         set{ tCRR_GDate_IsChanged = value; }
      }
      /// <summary>
      /// 试验日期
      /// </summary>
      private DateTime tCRR_TDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_TDate_IsChanged=false;
      /// <summary>
      /// 试验日期
      /// </summary>
      public DateTime TCRR_TDate
      {
         get{ return tCRR_TDate; }
         set{ tCRR_TDate = value; tCRR_TDate_IsChanged=true; }
      }
      /// <summary>
      /// 试验日期
      /// </summary>
      public bool TCRR_TDate_IsChanged
      {
         get{ return tCRR_TDate_IsChanged; }
         set{ tCRR_TDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string tCRR_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string TCRR_Bak
      {
         get{ return tCRR_Bak; }
         set{ tCRR_Bak = value; tCRR_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool TCRR_Bak_IsChanged
      {
         get{ return tCRR_Bak_IsChanged; }
         set{ tCRR_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 检验员
      /// </summary>
      private string tCRR_TOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_TOwner_IsChanged=false;
      /// <summary>
      /// 检验员
      /// </summary>
      public string TCRR_TOwner
      {
         get{ return tCRR_TOwner; }
         set{ tCRR_TOwner = value; tCRR_TOwner_IsChanged=true; }
      }
      /// <summary>
      /// 检验员
      /// </summary>
      public bool TCRR_TOwner_IsChanged
      {
         get{ return tCRR_TOwner_IsChanged; }
         set{ tCRR_TOwner_IsChanged = value; }
      }
      /// <summary>
      /// 检验结论
      /// </summary>
      private string tCRR_TConclusion;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_TConclusion_IsChanged=false;
      /// <summary>
      /// 检验结论
      /// </summary>
      public string TCRR_TConclusion
      {
         get{ return tCRR_TConclusion; }
         set{ tCRR_TConclusion = value; tCRR_TConclusion_IsChanged=true; }
      }
      /// <summary>
      /// 检验结论
      /// </summary>
      public bool TCRR_TConclusion_IsChanged
      {
         get{ return tCRR_TConclusion_IsChanged; }
         set{ tCRR_TConclusion_IsChanged = value; }
      }
      /// <summary>
      /// 检验状态
      /// </summary>
      private string tCRR_TStatus;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_TStatus_IsChanged=false;
      /// <summary>
      /// 检验状态
      /// </summary>
      public string TCRR_TStatus
      {
         get{ return tCRR_TStatus; }
         set{ tCRR_TStatus = value; tCRR_TStatus_IsChanged=true; }
      }
      /// <summary>
      /// 检验状态
      /// </summary>
      public bool TCRR_TStatus_IsChanged
      {
         get{ return tCRR_TStatus_IsChanged; }
         set{ tCRR_TStatus_IsChanged = value; }
      }
      /// <summary>
      /// 取样单据类型
      /// </summary>
      private string tCRR_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_RefType_IsChanged=false;
      /// <summary>
      /// 取样单据类型
      /// </summary>
      public string TCRR_RefType
      {
         get{ return tCRR_RefType; }
         set{ tCRR_RefType = value; tCRR_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 取样单据类型
      /// </summary>
      public bool TCRR_RefType_IsChanged
      {
         get{ return tCRR_RefType_IsChanged; }
         set{ tCRR_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 取样单据号
      /// </summary>
      private string tCRR_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_RefCode_IsChanged=false;
      /// <summary>
      /// 取样单据号
      /// </summary>
      public string TCRR_RefCode
      {
         get{ return tCRR_RefCode; }
         set{ tCRR_RefCode = value; tCRR_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 取样单据号
      /// </summary>
      public bool TCRR_RefCode_IsChanged
      {
         get{ return tCRR_RefCode_IsChanged; }
         set{ tCRR_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 样品等级
      /// </summary>
      private string tCRR_Lev;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_Lev_IsChanged=false;
      /// <summary>
      /// 样品等级
      /// </summary>
      public string TCRR_Lev
      {
         get{ return tCRR_Lev; }
         set{ tCRR_Lev = value; tCRR_Lev_IsChanged=true; }
      }
      /// <summary>
      /// 样品等级
      /// </summary>
      public bool TCRR_Lev_IsChanged
      {
         get{ return tCRR_Lev_IsChanged; }
         set{ tCRR_Lev_IsChanged = value; }
      }
      /// <summary>
      /// 样品数量
      /// </summary>
      private string tCRR_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_Num_IsChanged=false;
      /// <summary>
      /// 样品数量
      /// </summary>
      public string TCRR_Num
      {
         get{ return tCRR_Num; }
         set{ tCRR_Num = value; tCRR_Num_IsChanged=true; }
      }
      /// <summary>
      /// 样品数量
      /// </summary>
      public bool TCRR_Num_IsChanged
      {
         get{ return tCRR_Num_IsChanged; }
         set{ tCRR_Num_IsChanged = value; }
      }
      /// <summary>
      /// 送样日期
      /// </summary>
      private DateTime tCRR_SDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_SDate_IsChanged=false;
      /// <summary>
      /// 送样日期
      /// </summary>
      public DateTime TCRR_SDate
      {
         get{ return tCRR_SDate; }
         set{ tCRR_SDate = value; tCRR_SDate_IsChanged=true; }
      }
      /// <summary>
      /// 送样日期
      /// </summary>
      public bool TCRR_SDate_IsChanged
      {
         get{ return tCRR_SDate_IsChanged; }
         set{ tCRR_SDate_IsChanged = value; }
      }
      /// <summary>
      /// 送样人
      /// </summary>
      private string tCRR_SOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_SOwner_IsChanged=false;
      /// <summary>
      /// 送样人
      /// </summary>
      public string TCRR_SOwner
      {
         get{ return tCRR_SOwner; }
         set{ tCRR_SOwner = value; tCRR_SOwner_IsChanged=true; }
      }
      /// <summary>
      /// 送样人
      /// </summary>
      public bool TCRR_SOwner_IsChanged
      {
         get{ return tCRR_SOwner_IsChanged; }
         set{ tCRR_SOwner_IsChanged = value; }
      }
      /// <summary>
      /// 报告依据
      /// </summary>
      private string tCRR_Base;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_Base_IsChanged=false;
      /// <summary>
      /// 报告依据
      /// </summary>
      public string TCRR_Base
      {
         get{ return tCRR_Base; }
         set{ tCRR_Base = value; tCRR_Base_IsChanged=true; }
      }
      /// <summary>
      /// 报告依据
      /// </summary>
      public bool TCRR_Base_IsChanged
      {
         get{ return tCRR_Base_IsChanged; }
         set{ tCRR_Base_IsChanged = value; }
      }
      /// <summary>
      /// 检验设备
      /// </summary>
      private string tCRR_Equ;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_Equ_IsChanged=false;
      /// <summary>
      /// 检验设备
      /// </summary>
      public string TCRR_Equ
      {
         get{ return tCRR_Equ; }
         set{ tCRR_Equ = value; tCRR_Equ_IsChanged=true; }
      }
      /// <summary>
      /// 检验设备
      /// </summary>
      public bool TCRR_Equ_IsChanged
      {
         get{ return tCRR_Equ_IsChanged; }
         set{ tCRR_Equ_IsChanged = value; }
      }
      /// <summary>
      /// 检验配置模板
      /// </summary>
      private string tCRR_TCCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRR_TCCode_IsChanged=false;
      /// <summary>
      /// 检验配置模板
      /// </summary>
      public string TCRR_TCCode
      {
         get{ return tCRR_TCCode; }
         set{ tCRR_TCCode = value; tCRR_TCCode_IsChanged=true; }
      }
      /// <summary>
      /// 检验配置模板
      /// </summary>
      public bool TCRR_TCCode_IsChanged
      {
         get{ return tCRR_TCCode_IsChanged; }
         set{ tCRR_TCCode_IsChanged = value; }
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
