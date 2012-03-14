using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PC_CPlan
   {
      private decimal pCCP_ID;
      private bool pCCP_ID_IsChanged=false;
      public decimal PCCP_ID
      {
         get{ return pCCP_ID; }
         set{ pCCP_ID = value; pCCP_ID_IsChanged=true; }
      }
      public bool PCCP_ID_IsChanged
      {
         get{ return pCCP_ID_IsChanged; }
         set{ pCCP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 客户计划编码
      /// </summary>
      private string pCCP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Code_IsChanged=false;
      /// <summary>
      /// 客户计划编码
      /// </summary>
      public string PCCP_Code
      {
         get{ return pCCP_Code; }
         set{ pCCP_Code = value; pCCP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 客户计划编码
      /// </summary>
      public bool PCCP_Code_IsChanged
      {
         get{ return pCCP_Code_IsChanged; }
         set{ pCCP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string pCCP_CustomerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_CustomerCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string PCCP_CustomerCode
      {
         get{ return pCCP_CustomerCode; }
         set{ pCCP_CustomerCode = value; pCCP_CustomerCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool PCCP_CustomerCode_IsChanged
      {
         get{ return pCCP_CustomerCode_IsChanged; }
         set{ pCCP_CustomerCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string pCCP_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_CName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string PCCP_CName
      {
         get{ return pCCP_CName; }
         set{ pCCP_CName = value; pCCP_CName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool PCCP_CName_IsChanged
      {
         get{ return pCCP_CName_IsChanged; }
         set{ pCCP_CName_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string pCCP_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_CCode_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string PCCP_CCode
      {
         get{ return pCCP_CCode; }
         set{ pCCP_CCode = value; pCCP_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool PCCP_CCode_IsChanged
      {
         get{ return pCCP_CCode_IsChanged; }
         set{ pCCP_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      private string pCCP_ProjectCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_ProjectCode_IsChanged=false;
      /// <summary>
      /// 工程编码
      /// </summary>
      public string PCCP_ProjectCode
      {
         get{ return pCCP_ProjectCode; }
         set{ pCCP_ProjectCode = value; pCCP_ProjectCode_IsChanged=true; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      public bool PCCP_ProjectCode_IsChanged
      {
         get{ return pCCP_ProjectCode_IsChanged; }
         set{ pCCP_ProjectCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程名称
      /// </summary>
      private string pCCP_ProjectName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_ProjectName_IsChanged=false;
      /// <summary>
      /// 工程名称
      /// </summary>
      public string PCCP_ProjectName
      {
         get{ return pCCP_ProjectName; }
         set{ pCCP_ProjectName = value; pCCP_ProjectName_IsChanged=true; }
      }
      /// <summary>
      /// 工程名称
      /// </summary>
      public bool PCCP_ProjectName_IsChanged
      {
         get{ return pCCP_ProjectName_IsChanged; }
         set{ pCCP_ProjectName_IsChanged = value; }
      }
      /// <summary>
      /// 工程地址
      /// </summary>
      private string pCCP_Address;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Address_IsChanged=false;
      /// <summary>
      /// 工程地址
      /// </summary>
      public string PCCP_Address
      {
         get{ return pCCP_Address; }
         set{ pCCP_Address = value; pCCP_Address_IsChanged=true; }
      }
      /// <summary>
      /// 工程地址
      /// </summary>
      public bool PCCP_Address_IsChanged
      {
         get{ return pCCP_Address_IsChanged; }
         set{ pCCP_Address_IsChanged = value; }
      }
      /// <summary>
      /// 浇筑部位
      /// </summary>
      private string pCCP_Part;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Part_IsChanged=false;
      /// <summary>
      /// 浇筑部位
      /// </summary>
      public string PCCP_Part
      {
         get{ return pCCP_Part; }
         set{ pCCP_Part = value; pCCP_Part_IsChanged=true; }
      }
      /// <summary>
      /// 浇筑部位
      /// </summary>
      public bool PCCP_Part_IsChanged
      {
         get{ return pCCP_Part_IsChanged; }
         set{ pCCP_Part_IsChanged = value; }
      }
      /// <summary>
      /// 产品名称
      /// </summary>
      private string pCCP_ProdName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_ProdName_IsChanged=false;
      /// <summary>
      /// 产品名称
      /// </summary>
      public string PCCP_ProdName
      {
         get{ return pCCP_ProdName; }
         set{ pCCP_ProdName = value; pCCP_ProdName_IsChanged=true; }
      }
      /// <summary>
      /// 产品名称
      /// </summary>
      public bool PCCP_ProdName_IsChanged
      {
         get{ return pCCP_ProdName_IsChanged; }
         set{ pCCP_ProdName_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string pCCP_Level;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Level_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string PCCP_Level
      {
         get{ return pCCP_Level; }
         set{ pCCP_Level = value; pCCP_Level_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool PCCP_Level_IsChanged
      {
         get{ return pCCP_Level_IsChanged; }
         set{ pCCP_Level_IsChanged = value; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      private string pCCP_Impervious;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Impervious_IsChanged=false;
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public string PCCP_Impervious
      {
         get{ return pCCP_Impervious; }
         set{ pCCP_Impervious = value; pCCP_Impervious_IsChanged=true; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public bool PCCP_Impervious_IsChanged
      {
         get{ return pCCP_Impervious_IsChanged; }
         set{ pCCP_Impervious_IsChanged = value; }
      }
      /// <summary>
      /// 工程计划方量
      /// </summary>
      private int pCCP_Volume;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Volume_IsChanged=false;
      /// <summary>
      /// 工程计划方量
      /// </summary>
      public int PCCP_Volume
      {
         get{ return pCCP_Volume; }
         set{ pCCP_Volume = value; pCCP_Volume_IsChanged=true; }
      }
      /// <summary>
      /// 工程计划方量
      /// </summary>
      public bool PCCP_Volume_IsChanged
      {
         get{ return pCCP_Volume_IsChanged; }
         set{ pCCP_Volume_IsChanged = value; }
      }
      /// <summary>
      /// 砼坍落度
      /// </summary>
      private string pCCP_Slump;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Slump_IsChanged=false;
      /// <summary>
      /// 砼坍落度
      /// </summary>
      public string PCCP_Slump
      {
         get{ return pCCP_Slump; }
         set{ pCCP_Slump = value; pCCP_Slump_IsChanged=true; }
      }
      /// <summary>
      /// 砼坍落度
      /// </summary>
      public bool PCCP_Slump_IsChanged
      {
         get{ return pCCP_Slump_IsChanged; }
         set{ pCCP_Slump_IsChanged = value; }
      }
      /// <summary>
      /// 计划提交日期
      /// </summary>
      private DateTime pCCP_SubmitDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_SubmitDate_IsChanged=false;
      /// <summary>
      /// 计划提交日期
      /// </summary>
      public DateTime PCCP_SubmitDate
      {
         get{ return pCCP_SubmitDate; }
         set{ pCCP_SubmitDate = value; pCCP_SubmitDate_IsChanged=true; }
      }
      /// <summary>
      /// 计划提交日期
      /// </summary>
      public bool PCCP_SubmitDate_IsChanged
      {
         get{ return pCCP_SubmitDate_IsChanged; }
         set{ pCCP_SubmitDate_IsChanged = value; }
      }
      /// <summary>
      /// 计划开盘时间
      /// </summary>
      private DateTime pCCP_BeginTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_BeginTime_IsChanged=false;
      /// <summary>
      /// 计划开盘时间
      /// </summary>
      public DateTime PCCP_BeginTime
      {
         get{ return pCCP_BeginTime; }
         set{ pCCP_BeginTime = value; pCCP_BeginTime_IsChanged=true; }
      }
      /// <summary>
      /// 计划开盘时间
      /// </summary>
      public bool PCCP_BeginTime_IsChanged
      {
         get{ return pCCP_BeginTime_IsChanged; }
         set{ pCCP_BeginTime_IsChanged = value; }
      }
      /// <summary>
      /// 抗渗材料
      /// </summary>
      private string pCCP_SPC;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_SPC_IsChanged=false;
      /// <summary>
      /// 抗渗材料
      /// </summary>
      public string PCCP_SPC
      {
         get{ return pCCP_SPC; }
         set{ pCCP_SPC = value; pCCP_SPC_IsChanged=true; }
      }
      /// <summary>
      /// 抗渗材料
      /// </summary>
      public bool PCCP_SPC_IsChanged
      {
         get{ return pCCP_SPC_IsChanged; }
         set{ pCCP_SPC_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料1
      /// </summary>
      private string pCCP_Request1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Request1_IsChanged=false;
      /// <summary>
      /// 特殊材料1
      /// </summary>
      public string PCCP_Request1
      {
         get{ return pCCP_Request1; }
         set{ pCCP_Request1 = value; pCCP_Request1_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料1
      /// </summary>
      public bool PCCP_Request1_IsChanged
      {
         get{ return pCCP_Request1_IsChanged; }
         set{ pCCP_Request1_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料2
      /// </summary>
      private string pCCP_Request2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Request2_IsChanged=false;
      /// <summary>
      /// 特殊材料2
      /// </summary>
      public string PCCP_Request2
      {
         get{ return pCCP_Request2; }
         set{ pCCP_Request2 = value; pCCP_Request2_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料2
      /// </summary>
      public bool PCCP_Request2_IsChanged
      {
         get{ return pCCP_Request2_IsChanged; }
         set{ pCCP_Request2_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料3
      /// </summary>
      private string pCCP_Request3;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Request3_IsChanged=false;
      /// <summary>
      /// 特殊材料3
      /// </summary>
      public string PCCP_Request3
      {
         get{ return pCCP_Request3; }
         set{ pCCP_Request3 = value; pCCP_Request3_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料3
      /// </summary>
      public bool PCCP_Request3_IsChanged
      {
         get{ return pCCP_Request3_IsChanged; }
         set{ pCCP_Request3_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料4
      /// </summary>
      private string pCCP_Request4;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Request4_IsChanged=false;
      /// <summary>
      /// 特殊材料4
      /// </summary>
      public string PCCP_Request4
      {
         get{ return pCCP_Request4; }
         set{ pCCP_Request4 = value; pCCP_Request4_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料4
      /// </summary>
      public bool PCCP_Request4_IsChanged
      {
         get{ return pCCP_Request4_IsChanged; }
         set{ pCCP_Request4_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料5
      /// </summary>
      private string pCCP_Request5;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Request5_IsChanged=false;
      /// <summary>
      /// 特殊材料5
      /// </summary>
      public string PCCP_Request5
      {
         get{ return pCCP_Request5; }
         set{ pCCP_Request5 = value; pCCP_Request5_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料5
      /// </summary>
      public bool PCCP_Request5_IsChanged
      {
         get{ return pCCP_Request5_IsChanged; }
         set{ pCCP_Request5_IsChanged = value; }
      }
      /// <summary>
      /// 配送方式
      /// </summary>
      private string pCCP_Transpot;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Transpot_IsChanged=false;
      /// <summary>
      /// 配送方式
      /// </summary>
      public string PCCP_Transpot
      {
         get{ return pCCP_Transpot; }
         set{ pCCP_Transpot = value; pCCP_Transpot_IsChanged=true; }
      }
      /// <summary>
      /// 配送方式
      /// </summary>
      public bool PCCP_Transpot_IsChanged
      {
         get{ return pCCP_Transpot_IsChanged; }
         set{ pCCP_Transpot_IsChanged = value; }
      }
      /// <summary>
      /// PCCP_Stat
      /// </summary>
      private string pCCP_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Stat_IsChanged=false;
      /// <summary>
      /// PCCP_Stat
      /// </summary>
      public string PCCP_Stat
      {
         get{ return pCCP_Stat; }
         set{ pCCP_Stat = value; pCCP_Stat_IsChanged=true; }
      }
      /// <summary>
      /// PCCP_Stat
      /// </summary>
      public bool PCCP_Stat_IsChanged
      {
         get{ return pCCP_Stat_IsChanged; }
         set{ pCCP_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 备注1
      /// </summary>
      private string pCCP_Remark1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Remark1_IsChanged=false;
      /// <summary>
      /// 备注1
      /// </summary>
      public string PCCP_Remark1
      {
         get{ return pCCP_Remark1; }
         set{ pCCP_Remark1 = value; pCCP_Remark1_IsChanged=true; }
      }
      /// <summary>
      /// 备注1
      /// </summary>
      public bool PCCP_Remark1_IsChanged
      {
         get{ return pCCP_Remark1_IsChanged; }
         set{ pCCP_Remark1_IsChanged = value; }
      }
      /// <summary>
      /// 备注2
      /// </summary>
      private string pCCP_Remark2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Remark2_IsChanged=false;
      /// <summary>
      /// 备注2
      /// </summary>
      public string PCCP_Remark2
      {
         get{ return pCCP_Remark2; }
         set{ pCCP_Remark2 = value; pCCP_Remark2_IsChanged=true; }
      }
      /// <summary>
      /// 备注2
      /// </summary>
      public bool PCCP_Remark2_IsChanged
      {
         get{ return pCCP_Remark2_IsChanged; }
         set{ pCCP_Remark2_IsChanged = value; }
      }
      private string pCCP_CurStep;
      private bool pCCP_CurStep_IsChanged=false;
      public string PCCP_CurStep
      {
         get{ return pCCP_CurStep; }
         set{ pCCP_CurStep = value; pCCP_CurStep_IsChanged=true; }
      }
      public bool PCCP_CurStep_IsChanged
      {
         get{ return pCCP_CurStep_IsChanged; }
         set{ pCCP_CurStep_IsChanged = value; }
      }
      private string pCCP_NextStep;
      private bool pCCP_NextStep_IsChanged=false;
      public string PCCP_NextStep
      {
         get{ return pCCP_NextStep; }
         set{ pCCP_NextStep = value; pCCP_NextStep_IsChanged=true; }
      }
      public bool PCCP_NextStep_IsChanged
      {
         get{ return pCCP_NextStep_IsChanged; }
         set{ pCCP_NextStep_IsChanged = value; }
      }
      /// <summary>
      /// 计划提交人
      /// </summary>
      private string pCCP_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Owner_IsChanged=false;
      /// <summary>
      /// 计划提交人
      /// </summary>
      public string PCCP_Owner
      {
         get{ return pCCP_Owner; }
         set{ pCCP_Owner = value; pCCP_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 计划提交人
      /// </summary>
      public bool PCCP_Owner_IsChanged
      {
         get{ return pCCP_Owner_IsChanged; }
         set{ pCCP_Owner_IsChanged = value; }
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
      /// <summary>
      /// 审核状态
      /// </summary>
      private string auditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      private string auditCurAudit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditCurAudit_IsChanged=false;
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      /// <summary>
      /// 上一审核人
      /// </summary>
      private string lastAuditor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lastAuditor_IsChanged=false;
      /// <summary>
      /// 上一审核人
      /// </summary>
      public string LastAuditor
      {
         get{ return lastAuditor; }
         set{ lastAuditor = value; lastAuditor_IsChanged=true; }
      }
      /// <summary>
      /// 上一审核人
      /// </summary>
      public bool LastAuditor_IsChanged
      {
         get{ return lastAuditor_IsChanged; }
         set{ lastAuditor_IsChanged = value; }
      }
      /// <summary>
      /// 上一审核时间
      /// </summary>
      private DateTime lastAuditDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lastAuditDate_IsChanged=false;
      /// <summary>
      /// 上一审核时间
      /// </summary>
      public DateTime LastAuditDate
      {
         get{ return lastAuditDate; }
         set{ lastAuditDate = value; lastAuditDate_IsChanged=true; }
      }
      /// <summary>
      /// 上一审核时间
      /// </summary>
      public bool LastAuditDate_IsChanged
      {
         get{ return lastAuditDate_IsChanged; }
         set{ lastAuditDate_IsChanged = value; }
      }
      /// <summary>
      /// 自定义1
      /// </summary>
      private string pCCP_Udef1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Udef1_IsChanged=false;
      /// <summary>
      /// 自定义1
      /// </summary>
      public string PCCP_Udef1
      {
         get{ return pCCP_Udef1; }
         set{ pCCP_Udef1 = value; pCCP_Udef1_IsChanged=true; }
      }
      /// <summary>
      /// 自定义1
      /// </summary>
      public bool PCCP_Udef1_IsChanged
      {
         get{ return pCCP_Udef1_IsChanged; }
         set{ pCCP_Udef1_IsChanged = value; }
      }
      /// <summary>
      /// 自定义2
      /// </summary>
      private string pCCP_Udef2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Udef2_IsChanged=false;
      /// <summary>
      /// 自定义2
      /// </summary>
      public string PCCP_Udef2
      {
         get{ return pCCP_Udef2; }
         set{ pCCP_Udef2 = value; pCCP_Udef2_IsChanged=true; }
      }
      /// <summary>
      /// 自定义2
      /// </summary>
      public bool PCCP_Udef2_IsChanged
      {
         get{ return pCCP_Udef2_IsChanged; }
         set{ pCCP_Udef2_IsChanged = value; }
      }
      /// <summary>
      /// 自定义3
      /// </summary>
      private string pCCP_Udef3;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Udef3_IsChanged=false;
      /// <summary>
      /// 自定义3
      /// </summary>
      public string PCCP_Udef3
      {
         get{ return pCCP_Udef3; }
         set{ pCCP_Udef3 = value; pCCP_Udef3_IsChanged=true; }
      }
      /// <summary>
      /// 自定义3
      /// </summary>
      public bool PCCP_Udef3_IsChanged
      {
         get{ return pCCP_Udef3_IsChanged; }
         set{ pCCP_Udef3_IsChanged = value; }
      }
      /// <summary>
      /// 自定义4
      /// </summary>
      private string pCCP_Udef4;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Udef4_IsChanged=false;
      /// <summary>
      /// 自定义4
      /// </summary>
      public string PCCP_Udef4
      {
         get{ return pCCP_Udef4; }
         set{ pCCP_Udef4 = value; pCCP_Udef4_IsChanged=true; }
      }
      /// <summary>
      /// 自定义4
      /// </summary>
      public bool PCCP_Udef4_IsChanged
      {
         get{ return pCCP_Udef4_IsChanged; }
         set{ pCCP_Udef4_IsChanged = value; }
      }
      /// <summary>
      /// 自定义5
      /// </summary>
      private string pCCP_Udef5;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCCP_Udef5_IsChanged=false;
      /// <summary>
      /// 自定义5
      /// </summary>
      public string PCCP_Udef5
      {
         get{ return pCCP_Udef5; }
         set{ pCCP_Udef5 = value; pCCP_Udef5_IsChanged=true; }
      }
      /// <summary>
      /// 自定义5
      /// </summary>
      public bool PCCP_Udef5_IsChanged
      {
         get{ return pCCP_Udef5_IsChanged; }
         set{ pCCP_Udef5_IsChanged = value; }
      }
   }
}
