using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 外联协调信息
   /// </summary>
   [Serializable]
   public partial class Outreach_Coordination
   {
      /// <summary>
      /// 外联协调序号
      /// </summary>
      private decimal oC_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_ID_IsChanged=false;
      /// <summary>
      /// 外联协调序号
      /// </summary>
      public decimal OC_ID
      {
         get{ return oC_ID; }
         set{ oC_ID = value; oC_ID_IsChanged=true; }
      }
      /// <summary>
      /// 外联协调序号
      /// </summary>
      public bool OC_ID_IsChanged
      {
         get{ return oC_ID_IsChanged; }
         set{ oC_ID_IsChanged = value; }
      }
      /// <summary>
      /// 外联协调编码
      /// </summary>
      private string oC_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Code_IsChanged=false;
      /// <summary>
      /// 外联协调编码
      /// </summary>
      public string OC_Code
      {
         get{ return oC_Code; }
         set{ oC_Code = value; oC_Code_IsChanged=true; }
      }
      /// <summary>
      /// 外联协调编码
      /// </summary>
      public bool OC_Code_IsChanged
      {
         get{ return oC_Code_IsChanged; }
         set{ oC_Code_IsChanged = value; }
      }
      /// <summary>
      /// 外联单位编码
      /// </summary>
      private string oC_OutretachCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_OutretachCode_IsChanged=false;
      /// <summary>
      /// 外联单位编码
      /// </summary>
      public string OC_OutretachCode
      {
         get{ return oC_OutretachCode; }
         set{ oC_OutretachCode = value; oC_OutretachCode_IsChanged=true; }
      }
      /// <summary>
      /// 外联单位编码
      /// </summary>
      public bool OC_OutretachCode_IsChanged
      {
         get{ return oC_OutretachCode_IsChanged; }
         set{ oC_OutretachCode_IsChanged = value; }
      }
      /// <summary>
      /// 单位名称
      /// </summary>
      private string oC_OutreachName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_OutreachName_IsChanged=false;
      /// <summary>
      /// 单位名称
      /// </summary>
      public string OC_OutreachName
      {
         get{ return oC_OutreachName; }
         set{ oC_OutreachName = value; oC_OutreachName_IsChanged=true; }
      }
      /// <summary>
      /// 单位名称
      /// </summary>
      public bool OC_OutreachName_IsChanged
      {
         get{ return oC_OutreachName_IsChanged; }
         set{ oC_OutreachName_IsChanged = value; }
      }
      /// <summary>
      /// 协调类型
      /// </summary>
      private string oC_CoordinationType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_CoordinationType_IsChanged=false;
      /// <summary>
      /// 协调类型
      /// </summary>
      public string OC_CoordinationType
      {
         get{ return oC_CoordinationType; }
         set{ oC_CoordinationType = value; oC_CoordinationType_IsChanged=true; }
      }
      /// <summary>
      /// 协调类型
      /// </summary>
      public bool OC_CoordinationType_IsChanged
      {
         get{ return oC_CoordinationType_IsChanged; }
         set{ oC_CoordinationType_IsChanged = value; }
      }
      /// <summary>
      /// 主要联系人
      /// </summary>
      private string oC_MainContactor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_MainContactor_IsChanged=false;
      /// <summary>
      /// 主要联系人
      /// </summary>
      public string OC_MainContactor
      {
         get{ return oC_MainContactor; }
         set{ oC_MainContactor = value; oC_MainContactor_IsChanged=true; }
      }
      /// <summary>
      /// 主要联系人
      /// </summary>
      public bool OC_MainContactor_IsChanged
      {
         get{ return oC_MainContactor_IsChanged; }
         set{ oC_MainContactor_IsChanged = value; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      private string oC_Telephone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Telephone_IsChanged=false;
      /// <summary>
      /// 联系电话
      /// </summary>
      public string OC_Telephone
      {
         get{ return oC_Telephone; }
         set{ oC_Telephone = value; oC_Telephone_IsChanged=true; }
      }
      /// <summary>
      /// 联系电话
      /// </summary>
      public bool OC_Telephone_IsChanged
      {
         get{ return oC_Telephone_IsChanged; }
         set{ oC_Telephone_IsChanged = value; }
      }
      /// <summary>
      /// 协调内容
      /// </summary>
      private string oC_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Content_IsChanged=false;
      /// <summary>
      /// 协调内容
      /// </summary>
      public string OC_Content
      {
         get{ return oC_Content; }
         set{ oC_Content = value; oC_Content_IsChanged=true; }
      }
      /// <summary>
      /// 协调内容
      /// </summary>
      public bool OC_Content_IsChanged
      {
         get{ return oC_Content_IsChanged; }
         set{ oC_Content_IsChanged = value; }
      }
      /// <summary>
      /// 协调结果
      /// </summary>
      private string oC_Result;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Result_IsChanged=false;
      /// <summary>
      /// 协调结果
      /// </summary>
      public string OC_Result
      {
         get{ return oC_Result; }
         set{ oC_Result = value; oC_Result_IsChanged=true; }
      }
      /// <summary>
      /// 协调结果
      /// </summary>
      public bool OC_Result_IsChanged
      {
         get{ return oC_Result_IsChanged; }
         set{ oC_Result_IsChanged = value; }
      }
      /// <summary>
      /// 结果类型
      /// </summary>
      private string oC_ResultType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_ResultType_IsChanged=false;
      /// <summary>
      /// 结果类型
      /// </summary>
      public string OC_ResultType
      {
         get{ return oC_ResultType; }
         set{ oC_ResultType = value; oC_ResultType_IsChanged=true; }
      }
      /// <summary>
      /// 结果类型
      /// </summary>
      public bool OC_ResultType_IsChanged
      {
         get{ return oC_ResultType_IsChanged; }
         set{ oC_ResultType_IsChanged = value; }
      }
      /// <summary>
      /// 协调费用
      /// </summary>
      private decimal oC_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Cost_IsChanged=false;
      /// <summary>
      /// 协调费用
      /// </summary>
      public decimal OC_Cost
      {
         get{ return oC_Cost; }
         set{ oC_Cost = value; oC_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 协调费用
      /// </summary>
      public bool OC_Cost_IsChanged
      {
         get{ return oC_Cost_IsChanged; }
         set{ oC_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string oC_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string OC_Remark
      {
         get{ return oC_Remark; }
         set{ oC_Remark = value; oC_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool OC_Remark_IsChanged
      {
         get{ return oC_Remark_IsChanged; }
         set{ oC_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 附件
      /// </summary>
      private string oC_Attachment;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Attachment_IsChanged=false;
      /// <summary>
      /// 附件
      /// </summary>
      public string OC_Attachment
      {
         get{ return oC_Attachment; }
         set{ oC_Attachment = value; oC_Attachment_IsChanged=true; }
      }
      /// <summary>
      /// 附件
      /// </summary>
      public bool OC_Attachment_IsChanged
      {
         get{ return oC_Attachment_IsChanged; }
         set{ oC_Attachment_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string oC_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string OC_Company
      {
         get{ return oC_Company; }
         set{ oC_Company = value; oC_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool OC_Company_IsChanged
      {
         get{ return oC_Company_IsChanged; }
         set{ oC_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string oC_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string OC_Dept
      {
         get{ return oC_Dept; }
         set{ oC_Dept = value; oC_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool OC_Dept_IsChanged
      {
         get{ return oC_Dept_IsChanged; }
         set{ oC_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 内部类型(协调、关怀)
      /// </summary>
      private string oC_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool oC_iType_IsChanged=false;
      /// <summary>
      /// 内部类型(协调、关怀)
      /// </summary>
      public string OC_iType
      {
         get{ return oC_iType; }
         set{ oC_iType = value; oC_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类型(协调、关怀)
      /// </summary>
      public bool OC_iType_IsChanged
      {
         get{ return oC_iType_IsChanged; }
         set{ oC_iType_IsChanged = value; }
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
