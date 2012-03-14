using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 印章使用记录
   /// </summary>
   [Serializable]
   public partial class GM_SealRecord
   {
      /// <summary>
      /// 印章使用记录序号
      /// </summary>
      private decimal gMSR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_ID_IsChanged=false;
      /// <summary>
      /// 印章使用记录序号
      /// </summary>
      public decimal GMSR_ID
      {
         get{ return gMSR_ID; }
         set{ gMSR_ID = value; gMSR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 印章使用记录序号
      /// </summary>
      public bool GMSR_ID_IsChanged
      {
         get{ return gMSR_ID_IsChanged; }
         set{ gMSR_ID_IsChanged = value; }
      }
      private string gMSR_Code;
      private bool gMSR_Code_IsChanged=false;
      public string GMSR_Code
      {
         get{ return gMSR_Code; }
         set{ gMSR_Code = value; gMSR_Code_IsChanged=true; }
      }
      public bool GMSR_Code_IsChanged
      {
         get{ return gMSR_Code_IsChanged; }
         set{ gMSR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 印章编码
      /// </summary>
      private string gMSR_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_SCode_IsChanged=false;
      /// <summary>
      /// 印章编码
      /// </summary>
      public string GMSR_SCode
      {
         get{ return gMSR_SCode; }
         set{ gMSR_SCode = value; gMSR_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 印章编码
      /// </summary>
      public bool GMSR_SCode_IsChanged
      {
         get{ return gMSR_SCode_IsChanged; }
         set{ gMSR_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 印章名称
      /// </summary>
      private string gMSR_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_SName_IsChanged=false;
      /// <summary>
      /// 印章名称
      /// </summary>
      public string GMSR_SName
      {
         get{ return gMSR_SName; }
         set{ gMSR_SName = value; gMSR_SName_IsChanged=true; }
      }
      /// <summary>
      /// 印章名称
      /// </summary>
      public bool GMSR_SName_IsChanged
      {
         get{ return gMSR_SName_IsChanged; }
         set{ gMSR_SName_IsChanged = value; }
      }
      /// <summary>
      /// 使用时间
      /// </summary>
      private DateTime gMSR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_Date_IsChanged=false;
      /// <summary>
      /// 使用时间
      /// </summary>
      public DateTime GMSR_Date
      {
         get{ return gMSR_Date; }
         set{ gMSR_Date = value; gMSR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 使用时间
      /// </summary>
      public bool GMSR_Date_IsChanged
      {
         get{ return gMSR_Date_IsChanged; }
         set{ gMSR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 用途
      /// </summary>
      private string gMSR_Function;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_Function_IsChanged=false;
      /// <summary>
      /// 用途
      /// </summary>
      public string GMSR_Function
      {
         get{ return gMSR_Function; }
         set{ gMSR_Function = value; gMSR_Function_IsChanged=true; }
      }
      /// <summary>
      /// 用途
      /// </summary>
      public bool GMSR_Function_IsChanged
      {
         get{ return gMSR_Function_IsChanged; }
         set{ gMSR_Function_IsChanged = value; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      private int gMSR_Copy;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_Copy_IsChanged=false;
      /// <summary>
      /// 份数
      /// </summary>
      public int GMSR_Copy
      {
         get{ return gMSR_Copy; }
         set{ gMSR_Copy = value; gMSR_Copy_IsChanged=true; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      public bool GMSR_Copy_IsChanged
      {
         get{ return gMSR_Copy_IsChanged; }
         set{ gMSR_Copy_IsChanged = value; }
      }
      /// <summary>
      /// 用印人
      /// </summary>
      private string gMSR_Employee;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_Employee_IsChanged=false;
      /// <summary>
      /// 用印人
      /// </summary>
      public string GMSR_Employee
      {
         get{ return gMSR_Employee; }
         set{ gMSR_Employee = value; gMSR_Employee_IsChanged=true; }
      }
      /// <summary>
      /// 用印人
      /// </summary>
      public bool GMSR_Employee_IsChanged
      {
         get{ return gMSR_Employee_IsChanged; }
         set{ gMSR_Employee_IsChanged = value; }
      }
      /// <summary>
      /// 审批人
      /// </summary>
      private string gMSR_Approve;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_Approve_IsChanged=false;
      /// <summary>
      /// 审批人
      /// </summary>
      public string GMSR_Approve
      {
         get{ return gMSR_Approve; }
         set{ gMSR_Approve = value; gMSR_Approve_IsChanged=true; }
      }
      /// <summary>
      /// 审批人
      /// </summary>
      public bool GMSR_Approve_IsChanged
      {
         get{ return gMSR_Approve_IsChanged; }
         set{ gMSR_Approve_IsChanged = value; }
      }
      /// <summary>
      /// 归还时间
      /// </summary>
      private DateTime gMSR_RDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_RDate_IsChanged=false;
      /// <summary>
      /// 归还时间
      /// </summary>
      public DateTime GMSR_RDate
      {
         get{ return gMSR_RDate; }
         set{ gMSR_RDate = value; gMSR_RDate_IsChanged=true; }
      }
      /// <summary>
      /// 归还时间
      /// </summary>
      public bool GMSR_RDate_IsChanged
      {
         get{ return gMSR_RDate_IsChanged; }
         set{ gMSR_RDate_IsChanged = value; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      private string gMSR_UCat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_UCat_IsChanged=false;
      /// <summary>
      /// 使用类型
      /// </summary>
      public string GMSR_UCat
      {
         get{ return gMSR_UCat; }
         set{ gMSR_UCat = value; gMSR_UCat_IsChanged=true; }
      }
      /// <summary>
      /// 使用类型
      /// </summary>
      public bool GMSR_UCat_IsChanged
      {
         get{ return gMSR_UCat_IsChanged; }
         set{ gMSR_UCat_IsChanged = value; }
      }
      private string gMSR_Company;
      private bool gMSR_Company_IsChanged=false;
      public string GMSR_Company
      {
         get{ return gMSR_Company; }
         set{ gMSR_Company = value; gMSR_Company_IsChanged=true; }
      }
      public bool GMSR_Company_IsChanged
      {
         get{ return gMSR_Company_IsChanged; }
         set{ gMSR_Company_IsChanged = value; }
      }
      private string gMSR_Dept;
      private bool gMSR_Dept_IsChanged=false;
      public string GMSR_Dept
      {
         get{ return gMSR_Dept; }
         set{ gMSR_Dept = value; gMSR_Dept_IsChanged=true; }
      }
      public bool GMSR_Dept_IsChanged
      {
         get{ return gMSR_Dept_IsChanged; }
         set{ gMSR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string gMSR_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSR_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string GMSR_Bak
      {
         get{ return gMSR_Bak; }
         set{ gMSR_Bak = value; gMSR_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool GMSR_Bak_IsChanged
      {
         get{ return gMSR_Bak_IsChanged; }
         set{ gMSR_Bak_IsChanged = value; }
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
