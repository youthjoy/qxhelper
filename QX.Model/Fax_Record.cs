using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 传真登记信息
   /// </summary>
   [Serializable]
   public partial class Fax_Record
   {
      /// <summary>
      /// 传真登记信息ID
      /// </summary>
      private decimal fR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_ID_IsChanged=false;
      /// <summary>
      /// 传真登记信息ID
      /// </summary>
      public decimal FR_ID
      {
         get{ return fR_ID; }
         set{ fR_ID = value; fR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 传真登记信息ID
      /// </summary>
      public bool FR_ID_IsChanged
      {
         get{ return fR_ID_IsChanged; }
         set{ fR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 传真信息编码
      /// </summary>
      private string fR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Code_IsChanged=false;
      /// <summary>
      /// 传真信息编码
      /// </summary>
      public string FR_Code
      {
         get{ return fR_Code; }
         set{ fR_Code = value; fR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 传真信息编码
      /// </summary>
      public bool FR_Code_IsChanged
      {
         get{ return fR_Code_IsChanged; }
         set{ fR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 传真日期
      /// </summary>
      private DateTime fR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Date_IsChanged=false;
      /// <summary>
      /// 传真日期
      /// </summary>
      public DateTime FR_Date
      {
         get{ return fR_Date; }
         set{ fR_Date = value; fR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 传真日期
      /// </summary>
      public bool FR_Date_IsChanged
      {
         get{ return fR_Date_IsChanged; }
         set{ fR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 传真内容
      /// </summary>
      private string fR_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Content_IsChanged=false;
      /// <summary>
      /// 传真内容
      /// </summary>
      public string FR_Content
      {
         get{ return fR_Content; }
         set{ fR_Content = value; fR_Content_IsChanged=true; }
      }
      /// <summary>
      /// 传真内容
      /// </summary>
      public bool FR_Content_IsChanged
      {
         get{ return fR_Content_IsChanged; }
         set{ fR_Content_IsChanged = value; }
      }
      /// <summary>
      /// 传真类别
      /// </summary>
      private string fR_Category;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Category_IsChanged=false;
      /// <summary>
      /// 传真类别
      /// </summary>
      public string FR_Category
      {
         get{ return fR_Category; }
         set{ fR_Category = value; fR_Category_IsChanged=true; }
      }
      /// <summary>
      /// 传真类别
      /// </summary>
      public bool FR_Category_IsChanged
      {
         get{ return fR_Category_IsChanged; }
         set{ fR_Category_IsChanged = value; }
      }
      /// <summary>
      /// 传真数量
      /// </summary>
      private int fR_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Num_IsChanged=false;
      /// <summary>
      /// 传真数量
      /// </summary>
      public int FR_Num
      {
         get{ return fR_Num; }
         set{ fR_Num = value; fR_Num_IsChanged=true; }
      }
      /// <summary>
      /// 传真数量
      /// </summary>
      public bool FR_Num_IsChanged
      {
         get{ return fR_Num_IsChanged; }
         set{ fR_Num_IsChanged = value; }
      }
      /// <summary>
      /// 页数
      /// </summary>
      private int fR_PageNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_PageNum_IsChanged=false;
      /// <summary>
      /// 页数
      /// </summary>
      public int FR_PageNum
      {
         get{ return fR_PageNum; }
         set{ fR_PageNum = value; fR_PageNum_IsChanged=true; }
      }
      /// <summary>
      /// 页数
      /// </summary>
      public bool FR_PageNum_IsChanged
      {
         get{ return fR_PageNum_IsChanged; }
         set{ fR_PageNum_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal fR_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Amount_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal FR_Amount
      {
         get{ return fR_Amount; }
         set{ fR_Amount = value; fR_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool FR_Amount_IsChanged
      {
         get{ return fR_Amount_IsChanged; }
         set{ fR_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      private string fR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Operator_IsChanged=false;
      /// <summary>
      /// 经手人
      /// </summary>
      public string FR_Operator
      {
         get{ return fR_Operator; }
         set{ fR_Operator = value; fR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      public bool FR_Operator_IsChanged
      {
         get{ return fR_Operator_IsChanged; }
         set{ fR_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 经手时间
      /// </summary>
      private DateTime fR_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_OpDate_IsChanged=false;
      /// <summary>
      /// 经手时间
      /// </summary>
      public DateTime FR_OpDate
      {
         get{ return fR_OpDate; }
         set{ fR_OpDate = value; fR_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 经手时间
      /// </summary>
      public bool FR_OpDate_IsChanged
      {
         get{ return fR_OpDate_IsChanged; }
         set{ fR_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 经手人备注
      /// </summary>
      private string fR_OpRemark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_OpRemark_IsChanged=false;
      /// <summary>
      /// 经手人备注
      /// </summary>
      public string FR_OpRemark
      {
         get{ return fR_OpRemark; }
         set{ fR_OpRemark = value; fR_OpRemark_IsChanged=true; }
      }
      /// <summary>
      /// 经手人备注
      /// </summary>
      public bool FR_OpRemark_IsChanged
      {
         get{ return fR_OpRemark_IsChanged; }
         set{ fR_OpRemark_IsChanged = value; }
      }
      /// <summary>
      /// 移交公司
      /// </summary>
      private string fR_TranferCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_TranferCompany_IsChanged=false;
      /// <summary>
      /// 移交公司
      /// </summary>
      public string FR_TranferCompany
      {
         get{ return fR_TranferCompany; }
         set{ fR_TranferCompany = value; fR_TranferCompany_IsChanged=true; }
      }
      /// <summary>
      /// 移交公司
      /// </summary>
      public bool FR_TranferCompany_IsChanged
      {
         get{ return fR_TranferCompany_IsChanged; }
         set{ fR_TranferCompany_IsChanged = value; }
      }
      /// <summary>
      /// 移交部门
      /// </summary>
      private string fR_TranferDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_TranferDept_IsChanged=false;
      /// <summary>
      /// 移交部门
      /// </summary>
      public string FR_TranferDept
      {
         get{ return fR_TranferDept; }
         set{ fR_TranferDept = value; fR_TranferDept_IsChanged=true; }
      }
      /// <summary>
      /// 移交部门
      /// </summary>
      public bool FR_TranferDept_IsChanged
      {
         get{ return fR_TranferDept_IsChanged; }
         set{ fR_TranferDept_IsChanged = value; }
      }
      /// <summary>
      /// 移交人备注
      /// </summary>
      private string fR_TranferRemark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_TranferRemark_IsChanged=false;
      /// <summary>
      /// 移交人备注
      /// </summary>
      public string FR_TranferRemark
      {
         get{ return fR_TranferRemark; }
         set{ fR_TranferRemark = value; fR_TranferRemark_IsChanged=true; }
      }
      /// <summary>
      /// 移交人备注
      /// </summary>
      public bool FR_TranferRemark_IsChanged
      {
         get{ return fR_TranferRemark_IsChanged; }
         set{ fR_TranferRemark_IsChanged = value; }
      }
      /// <summary>
      /// 移交时间
      /// </summary>
      private string fR_TranferDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_TranferDate_IsChanged=false;
      /// <summary>
      /// 移交时间
      /// </summary>
      public string FR_TranferDate
      {
         get{ return fR_TranferDate; }
         set{ fR_TranferDate = value; fR_TranferDate_IsChanged=true; }
      }
      /// <summary>
      /// 移交时间
      /// </summary>
      public bool FR_TranferDate_IsChanged
      {
         get{ return fR_TranferDate_IsChanged; }
         set{ fR_TranferDate_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string fR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string FR_Company
      {
         get{ return fR_Company; }
         set{ fR_Company = value; fR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool FR_Company_IsChanged
      {
         get{ return fR_Company_IsChanged; }
         set{ fR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string fR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string FR_Dept
      {
         get{ return fR_Dept; }
         set{ fR_Dept = value; fR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool FR_Dept_IsChanged
      {
         get{ return fR_Dept_IsChanged; }
         set{ fR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 内部状态
      /// </summary>
      private string fR_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fR_Stat_IsChanged=false;
      /// <summary>
      /// 内部状态
      /// </summary>
      public string FR_Stat
      {
         get{ return fR_Stat; }
         set{ fR_Stat = value; fR_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 内部状态
      /// </summary>
      public bool FR_Stat_IsChanged
      {
         get{ return fR_Stat_IsChanged; }
         set{ fR_Stat_IsChanged = value; }
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
