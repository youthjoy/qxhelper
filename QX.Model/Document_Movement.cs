using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 档案移交记录
   /// </summary>
   [Serializable]
   public partial class Document_Movement
   {
      /// <summary>
      /// 档案移交ID
      /// </summary>
      private decimal mov_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_ID_IsChanged=false;
      /// <summary>
      /// 档案移交ID
      /// </summary>
      public decimal Mov_ID
      {
         get{ return mov_ID; }
         set{ mov_ID = value; mov_ID_IsChanged=true; }
      }
      /// <summary>
      /// 档案移交ID
      /// </summary>
      public bool Mov_ID_IsChanged
      {
         get{ return mov_ID_IsChanged; }
         set{ mov_ID_IsChanged = value; }
      }
      /// <summary>
      /// 档案移交编码
      /// </summary>
      private string mov_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_Code_IsChanged=false;
      /// <summary>
      /// 档案移交编码
      /// </summary>
      public string Mov_Code
      {
         get{ return mov_Code; }
         set{ mov_Code = value; mov_Code_IsChanged=true; }
      }
      /// <summary>
      /// 档案移交编码
      /// </summary>
      public bool Mov_Code_IsChanged
      {
         get{ return mov_Code_IsChanged; }
         set{ mov_Code_IsChanged = value; }
      }
      /// <summary>
      /// 档案编码
      /// </summary>
      private string mov_DocumentCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_DocumentCode_IsChanged=false;
      /// <summary>
      /// 档案编码
      /// </summary>
      public string Mov_DocumentCode
      {
         get{ return mov_DocumentCode; }
         set{ mov_DocumentCode = value; mov_DocumentCode_IsChanged=true; }
      }
      /// <summary>
      /// 档案编码
      /// </summary>
      public bool Mov_DocumentCode_IsChanged
      {
         get{ return mov_DocumentCode_IsChanged; }
         set{ mov_DocumentCode_IsChanged = value; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      private string mov_FileCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_FileCode_IsChanged=false;
      /// <summary>
      /// 档案文号
      /// </summary>
      public string Mov_FileCode
      {
         get{ return mov_FileCode; }
         set{ mov_FileCode = value; mov_FileCode_IsChanged=true; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      public bool Mov_FileCode_IsChanged
      {
         get{ return mov_FileCode_IsChanged; }
         set{ mov_FileCode_IsChanged = value; }
      }
      /// <summary>
      /// 档案文件名称
      /// </summary>
      private string mov_FileName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_FileName_IsChanged=false;
      /// <summary>
      /// 档案文件名称
      /// </summary>
      public string Mov_FileName
      {
         get{ return mov_FileName; }
         set{ mov_FileName = value; mov_FileName_IsChanged=true; }
      }
      /// <summary>
      /// 档案文件名称
      /// </summary>
      public bool Mov_FileName_IsChanged
      {
         get{ return mov_FileName_IsChanged; }
         set{ mov_FileName_IsChanged = value; }
      }
      /// <summary>
      /// 总经办经手人
      /// </summary>
      private string mov_GMOperator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_GMOperator_IsChanged=false;
      /// <summary>
      /// 总经办经手人
      /// </summary>
      public string Mov_GMOperator
      {
         get{ return mov_GMOperator; }
         set{ mov_GMOperator = value; mov_GMOperator_IsChanged=true; }
      }
      /// <summary>
      /// 总经办经手人
      /// </summary>
      public bool Mov_GMOperator_IsChanged
      {
         get{ return mov_GMOperator_IsChanged; }
         set{ mov_GMOperator_IsChanged = value; }
      }
      /// <summary>
      /// 总务部经手人
      /// </summary>
      private string mov_GDOperator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_GDOperator_IsChanged=false;
      /// <summary>
      /// 总务部经手人
      /// </summary>
      public string Mov_GDOperator
      {
         get{ return mov_GDOperator; }
         set{ mov_GDOperator = value; mov_GDOperator_IsChanged=true; }
      }
      /// <summary>
      /// 总务部经手人
      /// </summary>
      public bool Mov_GDOperator_IsChanged
      {
         get{ return mov_GDOperator_IsChanged; }
         set{ mov_GDOperator_IsChanged = value; }
      }
      /// <summary>
      /// 移交时间
      /// </summary>
      private DateTime mov_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_Date_IsChanged=false;
      /// <summary>
      /// 移交时间
      /// </summary>
      public DateTime Mov_Date
      {
         get{ return mov_Date; }
         set{ mov_Date = value; mov_Date_IsChanged=true; }
      }
      /// <summary>
      /// 移交时间
      /// </summary>
      public bool Mov_Date_IsChanged
      {
         get{ return mov_Date_IsChanged; }
         set{ mov_Date_IsChanged = value; }
      }
      /// <summary>
      /// 原存档公司
      /// </summary>
      private string mov_OldCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_OldCompany_IsChanged=false;
      /// <summary>
      /// 原存档公司
      /// </summary>
      public string Mov_OldCompany
      {
         get{ return mov_OldCompany; }
         set{ mov_OldCompany = value; mov_OldCompany_IsChanged=true; }
      }
      /// <summary>
      /// 原存档公司
      /// </summary>
      public bool Mov_OldCompany_IsChanged
      {
         get{ return mov_OldCompany_IsChanged; }
         set{ mov_OldCompany_IsChanged = value; }
      }
      /// <summary>
      /// 原存档部门
      /// </summary>
      private string mov_OldDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_OldDept_IsChanged=false;
      /// <summary>
      /// 原存档部门
      /// </summary>
      public string Mov_OldDept
      {
         get{ return mov_OldDept; }
         set{ mov_OldDept = value; mov_OldDept_IsChanged=true; }
      }
      /// <summary>
      /// 原存档部门
      /// </summary>
      public bool Mov_OldDept_IsChanged
      {
         get{ return mov_OldDept_IsChanged; }
         set{ mov_OldDept_IsChanged = value; }
      }
      /// <summary>
      /// 原存档负责人
      /// </summary>
      private string mov_OldResPerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_OldResPerson_IsChanged=false;
      /// <summary>
      /// 原存档负责人
      /// </summary>
      public string Mov_OldResPerson
      {
         get{ return mov_OldResPerson; }
         set{ mov_OldResPerson = value; mov_OldResPerson_IsChanged=true; }
      }
      /// <summary>
      /// 原存档负责人
      /// </summary>
      public bool Mov_OldResPerson_IsChanged
      {
         get{ return mov_OldResPerson_IsChanged; }
         set{ mov_OldResPerson_IsChanged = value; }
      }
      /// <summary>
      /// 新存档公司
      /// </summary>
      private string mov_NewCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_NewCompany_IsChanged=false;
      /// <summary>
      /// 新存档公司
      /// </summary>
      public string Mov_NewCompany
      {
         get{ return mov_NewCompany; }
         set{ mov_NewCompany = value; mov_NewCompany_IsChanged=true; }
      }
      /// <summary>
      /// 新存档公司
      /// </summary>
      public bool Mov_NewCompany_IsChanged
      {
         get{ return mov_NewCompany_IsChanged; }
         set{ mov_NewCompany_IsChanged = value; }
      }
      /// <summary>
      /// 新存档部门
      /// </summary>
      private string mov_NewDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_NewDept_IsChanged=false;
      /// <summary>
      /// 新存档部门
      /// </summary>
      public string Mov_NewDept
      {
         get{ return mov_NewDept; }
         set{ mov_NewDept = value; mov_NewDept_IsChanged=true; }
      }
      /// <summary>
      /// 新存档部门
      /// </summary>
      public bool Mov_NewDept_IsChanged
      {
         get{ return mov_NewDept_IsChanged; }
         set{ mov_NewDept_IsChanged = value; }
      }
      /// <summary>
      /// 新存档复制人
      /// </summary>
      private string mov_NewCopier;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_NewCopier_IsChanged=false;
      /// <summary>
      /// 新存档复制人
      /// </summary>
      public string Mov_NewCopier
      {
         get{ return mov_NewCopier; }
         set{ mov_NewCopier = value; mov_NewCopier_IsChanged=true; }
      }
      /// <summary>
      /// 新存档复制人
      /// </summary>
      public bool Mov_NewCopier_IsChanged
      {
         get{ return mov_NewCopier_IsChanged; }
         set{ mov_NewCopier_IsChanged = value; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      private int mov_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_Num_IsChanged=false;
      /// <summary>
      /// 份数
      /// </summary>
      public int Mov_Num
      {
         get{ return mov_Num; }
         set{ mov_Num = value; mov_Num_IsChanged=true; }
      }
      /// <summary>
      /// 份数
      /// </summary>
      public bool Mov_Num_IsChanged
      {
         get{ return mov_Num_IsChanged; }
         set{ mov_Num_IsChanged = value; }
      }
      /// <summary>
      /// 监交人
      /// </summary>
      private string mov_Superintendent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_Superintendent_IsChanged=false;
      /// <summary>
      /// 监交人
      /// </summary>
      public string Mov_Superintendent
      {
         get{ return mov_Superintendent; }
         set{ mov_Superintendent = value; mov_Superintendent_IsChanged=true; }
      }
      /// <summary>
      /// 监交人
      /// </summary>
      public bool Mov_Superintendent_IsChanged
      {
         get{ return mov_Superintendent_IsChanged; }
         set{ mov_Superintendent_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string mov_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_Operator_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string Mov_Operator
      {
         get{ return mov_Operator; }
         set{ mov_Operator = value; mov_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool Mov_Operator_IsChanged
      {
         get{ return mov_Operator_IsChanged; }
         set{ mov_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      private DateTime mov_OperateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mov_OperateDate_IsChanged=false;
      /// <summary>
      /// 操作时间
      /// </summary>
      public DateTime Mov_OperateDate
      {
         get{ return mov_OperateDate; }
         set{ mov_OperateDate = value; mov_OperateDate_IsChanged=true; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      public bool Mov_OperateDate_IsChanged
      {
         get{ return mov_OperateDate_IsChanged; }
         set{ mov_OperateDate_IsChanged = value; }
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
