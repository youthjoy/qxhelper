using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 交通事故记录表
   /// </summary>
   [Serializable]
   public partial class TrafficAccident_Record
   {
      /// <summary>
      /// 交通事故记录序号
      /// </summary>
      private decimal tAR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_ID_IsChanged=false;
      /// <summary>
      /// 交通事故记录序号
      /// </summary>
      public decimal TAR_ID
      {
         get{ return tAR_ID; }
         set{ tAR_ID = value; tAR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 交通事故记录序号
      /// </summary>
      public bool TAR_ID_IsChanged
      {
         get{ return tAR_ID_IsChanged; }
         set{ tAR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 交通事故记录编码
      /// </summary>
      private string tAR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Code_IsChanged=false;
      /// <summary>
      /// 交通事故记录编码
      /// </summary>
      public string TAR_Code
      {
         get{ return tAR_Code; }
         set{ tAR_Code = value; tAR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 交通事故记录编码
      /// </summary>
      public bool TAR_Code_IsChanged
      {
         get{ return tAR_Code_IsChanged; }
         set{ tAR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 交通事故时间
      /// </summary>
      private DateTime tAR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Date_IsChanged=false;
      /// <summary>
      /// 交通事故时间
      /// </summary>
      public DateTime TAR_Date
      {
         get{ return tAR_Date; }
         set{ tAR_Date = value; tAR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 交通事故时间
      /// </summary>
      public bool TAR_Date_IsChanged
      {
         get{ return tAR_Date_IsChanged; }
         set{ tAR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 交通事故地点
      /// </summary>
      private string tAR_Position;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Position_IsChanged=false;
      /// <summary>
      /// 交通事故地点
      /// </summary>
      public string TAR_Position
      {
         get{ return tAR_Position; }
         set{ tAR_Position = value; tAR_Position_IsChanged=true; }
      }
      /// <summary>
      /// 交通事故地点
      /// </summary>
      public bool TAR_Position_IsChanged
      {
         get{ return tAR_Position_IsChanged; }
         set{ tAR_Position_IsChanged = value; }
      }
      /// <summary>
      /// 交通事故驾驶员
      /// </summary>
      private string tAR_Pilot;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Pilot_IsChanged=false;
      /// <summary>
      /// 交通事故驾驶员
      /// </summary>
      public string TAR_Pilot
      {
         get{ return tAR_Pilot; }
         set{ tAR_Pilot = value; tAR_Pilot_IsChanged=true; }
      }
      /// <summary>
      /// 交通事故驾驶员
      /// </summary>
      public bool TAR_Pilot_IsChanged
      {
         get{ return tAR_Pilot_IsChanged; }
         set{ tAR_Pilot_IsChanged = value; }
      }
      /// <summary>
      /// 交通车牌号
      /// </summary>
      private string tAR_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 交通车牌号
      /// </summary>
      public string TAR_VehiclesNo
      {
         get{ return tAR_VehiclesNo; }
         set{ tAR_VehiclesNo = value; tAR_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 交通车牌号
      /// </summary>
      public bool TAR_VehiclesNo_IsChanged
      {
         get{ return tAR_VehiclesNo_IsChanged; }
         set{ tAR_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 车型
      /// </summary>
      private string tAR_Model;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Model_IsChanged=false;
      /// <summary>
      /// 车型
      /// </summary>
      public string TAR_Model
      {
         get{ return tAR_Model; }
         set{ tAR_Model = value; tAR_Model_IsChanged=true; }
      }
      /// <summary>
      /// 车型
      /// </summary>
      public bool TAR_Model_IsChanged
      {
         get{ return tAR_Model_IsChanged; }
         set{ tAR_Model_IsChanged = value; }
      }
      /// <summary>
      /// 简要经过
      /// </summary>
      private string tAR_Abstract;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Abstract_IsChanged=false;
      /// <summary>
      /// 简要经过
      /// </summary>
      public string TAR_Abstract
      {
         get{ return tAR_Abstract; }
         set{ tAR_Abstract = value; tAR_Abstract_IsChanged=true; }
      }
      /// <summary>
      /// 简要经过
      /// </summary>
      public bool TAR_Abstract_IsChanged
      {
         get{ return tAR_Abstract_IsChanged; }
         set{ tAR_Abstract_IsChanged = value; }
      }
      /// <summary>
      /// 报案时间
      /// </summary>
      private DateTime tAR_ReportDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_ReportDate_IsChanged=false;
      /// <summary>
      /// 报案时间
      /// </summary>
      public DateTime TAR_ReportDate
      {
         get{ return tAR_ReportDate; }
         set{ tAR_ReportDate = value; tAR_ReportDate_IsChanged=true; }
      }
      /// <summary>
      /// 报案时间
      /// </summary>
      public bool TAR_ReportDate_IsChanged
      {
         get{ return tAR_ReportDate_IsChanged; }
         set{ tAR_ReportDate_IsChanged = value; }
      }
      /// <summary>
      /// 投保公司
      /// </summary>
      private string tAR_InsuranceCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_InsuranceCompany_IsChanged=false;
      /// <summary>
      /// 投保公司
      /// </summary>
      public string TAR_InsuranceCompany
      {
         get{ return tAR_InsuranceCompany; }
         set{ tAR_InsuranceCompany = value; tAR_InsuranceCompany_IsChanged=true; }
      }
      /// <summary>
      /// 投保公司
      /// </summary>
      public bool TAR_InsuranceCompany_IsChanged
      {
         get{ return tAR_InsuranceCompany_IsChanged; }
         set{ tAR_InsuranceCompany_IsChanged = value; }
      }
      /// <summary>
      /// 保险公司是否到场
      /// </summary>
      private string tAR_IsInsuranceCome;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_IsInsuranceCome_IsChanged=false;
      /// <summary>
      /// 保险公司是否到场
      /// </summary>
      public string TAR_IsInsuranceCome
      {
         get{ return tAR_IsInsuranceCome; }
         set{ tAR_IsInsuranceCome = value; tAR_IsInsuranceCome_IsChanged=true; }
      }
      /// <summary>
      /// 保险公司是否到场
      /// </summary>
      public bool TAR_IsInsuranceCome_IsChanged
      {
         get{ return tAR_IsInsuranceCome_IsChanged; }
         set{ tAR_IsInsuranceCome_IsChanged = value; }
      }
      /// <summary>
      /// 交警是否到场
      /// </summary>
      private string tAR_IsPoliceCome;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_IsPoliceCome_IsChanged=false;
      /// <summary>
      /// 交警是否到场
      /// </summary>
      public string TAR_IsPoliceCome
      {
         get{ return tAR_IsPoliceCome; }
         set{ tAR_IsPoliceCome = value; tAR_IsPoliceCome_IsChanged=true; }
      }
      /// <summary>
      /// 交警是否到场
      /// </summary>
      public bool TAR_IsPoliceCome_IsChanged
      {
         get{ return tAR_IsPoliceCome_IsChanged; }
         set{ tAR_IsPoliceCome_IsChanged = value; }
      }
      /// <summary>
      /// 理赔手续上交时间
      /// </summary>
      private DateTime tAR_ProceduresUpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_ProceduresUpDate_IsChanged=false;
      /// <summary>
      /// 理赔手续上交时间
      /// </summary>
      public DateTime TAR_ProceduresUpDate
      {
         get{ return tAR_ProceduresUpDate; }
         set{ tAR_ProceduresUpDate = value; tAR_ProceduresUpDate_IsChanged=true; }
      }
      /// <summary>
      /// 理赔手续上交时间
      /// </summary>
      public bool TAR_ProceduresUpDate_IsChanged
      {
         get{ return tAR_ProceduresUpDate_IsChanged; }
         set{ tAR_ProceduresUpDate_IsChanged = value; }
      }
      /// <summary>
      /// 目前支付金额
      /// </summary>
      private decimal tAR_CurrentPay;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_CurrentPay_IsChanged=false;
      /// <summary>
      /// 目前支付金额
      /// </summary>
      public decimal TAR_CurrentPay
      {
         get{ return tAR_CurrentPay; }
         set{ tAR_CurrentPay = value; tAR_CurrentPay_IsChanged=true; }
      }
      /// <summary>
      /// 目前支付金额
      /// </summary>
      public bool TAR_CurrentPay_IsChanged
      {
         get{ return tAR_CurrentPay_IsChanged; }
         set{ tAR_CurrentPay_IsChanged = value; }
      }
      /// <summary>
      /// 报账人
      /// </summary>
      private string tAR_Reimbursementor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Reimbursementor_IsChanged=false;
      /// <summary>
      /// 报账人
      /// </summary>
      public string TAR_Reimbursementor
      {
         get{ return tAR_Reimbursementor; }
         set{ tAR_Reimbursementor = value; tAR_Reimbursementor_IsChanged=true; }
      }
      /// <summary>
      /// 报账人
      /// </summary>
      public bool TAR_Reimbursementor_IsChanged
      {
         get{ return tAR_Reimbursementor_IsChanged; }
         set{ tAR_Reimbursementor_IsChanged = value; }
      }
      /// <summary>
      /// 保险公司金额
      /// </summary>
      private decimal tAR_InsuranceMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_InsuranceMoney_IsChanged=false;
      /// <summary>
      /// 保险公司金额
      /// </summary>
      public decimal TAR_InsuranceMoney
      {
         get{ return tAR_InsuranceMoney; }
         set{ tAR_InsuranceMoney = value; tAR_InsuranceMoney_IsChanged=true; }
      }
      /// <summary>
      /// 保险公司金额
      /// </summary>
      public bool TAR_InsuranceMoney_IsChanged
      {
         get{ return tAR_InsuranceMoney_IsChanged; }
         set{ tAR_InsuranceMoney_IsChanged = value; }
      }
      /// <summary>
      /// 从保险公司获赔金额
      /// </summary>
      private decimal tAR_ActualMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_ActualMoney_IsChanged=false;
      /// <summary>
      /// 从保险公司获赔金额
      /// </summary>
      public decimal TAR_ActualMoney
      {
         get{ return tAR_ActualMoney; }
         set{ tAR_ActualMoney = value; tAR_ActualMoney_IsChanged=true; }
      }
      /// <summary>
      /// 从保险公司获赔金额
      /// </summary>
      public bool TAR_ActualMoney_IsChanged
      {
         get{ return tAR_ActualMoney_IsChanged; }
         set{ tAR_ActualMoney_IsChanged = value; }
      }
      /// <summary>
      /// 公司损失金额
      /// </summary>
      private decimal tAR_CompanyLoss;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_CompanyLoss_IsChanged=false;
      /// <summary>
      /// 公司损失金额
      /// </summary>
      public decimal TAR_CompanyLoss
      {
         get{ return tAR_CompanyLoss; }
         set{ tAR_CompanyLoss = value; tAR_CompanyLoss_IsChanged=true; }
      }
      /// <summary>
      /// 公司损失金额
      /// </summary>
      public bool TAR_CompanyLoss_IsChanged
      {
         get{ return tAR_CompanyLoss_IsChanged; }
         set{ tAR_CompanyLoss_IsChanged = value; }
      }
      /// <summary>
      /// 修理厂
      /// </summary>
      private string tAR_RepairFactory;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_RepairFactory_IsChanged=false;
      /// <summary>
      /// 修理厂
      /// </summary>
      public string TAR_RepairFactory
      {
         get{ return tAR_RepairFactory; }
         set{ tAR_RepairFactory = value; tAR_RepairFactory_IsChanged=true; }
      }
      /// <summary>
      /// 修理厂
      /// </summary>
      public bool TAR_RepairFactory_IsChanged
      {
         get{ return tAR_RepairFactory_IsChanged; }
         set{ tAR_RepairFactory_IsChanged = value; }
      }
      /// <summary>
      /// 个人处罚
      /// </summary>
      private string tAR_Punish;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Punish_IsChanged=false;
      /// <summary>
      /// 个人处罚
      /// </summary>
      public string TAR_Punish
      {
         get{ return tAR_Punish; }
         set{ tAR_Punish = value; tAR_Punish_IsChanged=true; }
      }
      /// <summary>
      /// 个人处罚
      /// </summary>
      public bool TAR_Punish_IsChanged
      {
         get{ return tAR_Punish_IsChanged; }
         set{ tAR_Punish_IsChanged = value; }
      }
      /// <summary>
      /// 人伤情况
      /// </summary>
      private string tAR_InjureSituation;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_InjureSituation_IsChanged=false;
      /// <summary>
      /// 人伤情况
      /// </summary>
      public string TAR_InjureSituation
      {
         get{ return tAR_InjureSituation; }
         set{ tAR_InjureSituation = value; tAR_InjureSituation_IsChanged=true; }
      }
      /// <summary>
      /// 人伤情况
      /// </summary>
      public bool TAR_InjureSituation_IsChanged
      {
         get{ return tAR_InjureSituation_IsChanged; }
         set{ tAR_InjureSituation_IsChanged = value; }
      }
      /// <summary>
      /// 结案情况
      /// </summary>
      private string tAR_HandleResult;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_HandleResult_IsChanged=false;
      /// <summary>
      /// 结案情况
      /// </summary>
      public string TAR_HandleResult
      {
         get{ return tAR_HandleResult; }
         set{ tAR_HandleResult = value; tAR_HandleResult_IsChanged=true; }
      }
      /// <summary>
      /// 结案情况
      /// </summary>
      public bool TAR_HandleResult_IsChanged
      {
         get{ return tAR_HandleResult_IsChanged; }
         set{ tAR_HandleResult_IsChanged = value; }
      }
      /// <summary>
      /// 责任人处理情况
      /// </summary>
      private string tAR_ResponsibleResult;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_ResponsibleResult_IsChanged=false;
      /// <summary>
      /// 责任人处理情况
      /// </summary>
      public string TAR_ResponsibleResult
      {
         get{ return tAR_ResponsibleResult; }
         set{ tAR_ResponsibleResult = value; tAR_ResponsibleResult_IsChanged=true; }
      }
      /// <summary>
      /// 责任人处理情况
      /// </summary>
      public bool TAR_ResponsibleResult_IsChanged
      {
         get{ return tAR_ResponsibleResult_IsChanged; }
         set{ tAR_ResponsibleResult_IsChanged = value; }
      }
      /// <summary>
      /// 事故处理报告
      /// </summary>
      private string tAR_AccidentResult;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_AccidentResult_IsChanged=false;
      /// <summary>
      /// 事故处理报告
      /// </summary>
      public string TAR_AccidentResult
      {
         get{ return tAR_AccidentResult; }
         set{ tAR_AccidentResult = value; tAR_AccidentResult_IsChanged=true; }
      }
      /// <summary>
      /// 事故处理报告
      /// </summary>
      public bool TAR_AccidentResult_IsChanged
      {
         get{ return tAR_AccidentResult_IsChanged; }
         set{ tAR_AccidentResult_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string tAR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tAR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string TAR_Remark
      {
         get{ return tAR_Remark; }
         set{ tAR_Remark = value; tAR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool TAR_Remark_IsChanged
      {
         get{ return tAR_Remark_IsChanged; }
         set{ tAR_Remark_IsChanged = value; }
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
