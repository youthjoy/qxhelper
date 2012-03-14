using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 部门人员关系表
   /// </summary>
   [Serializable]
   public partial class DeptEmployee
   {
      /// <summary>
      /// 部门人员关系序号
      /// </summary>
      private decimal dE_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dE_ID_IsChanged=false;
      /// <summary>
      /// 部门人员关系序号
      /// </summary>
      public decimal DE_ID
      {
         get{ return dE_ID; }
         set{ dE_ID = value; dE_ID_IsChanged=true; }
      }
      /// <summary>
      /// 部门人员关系序号
      /// </summary>
      public bool DE_ID_IsChanged
      {
         get{ return dE_ID_IsChanged; }
         set{ dE_ID_IsChanged = value; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      private string dE_Dept_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dE_Dept_Code_IsChanged=false;
      /// <summary>
      /// 部门编码
      /// </summary>
      public string DE_Dept_Code
      {
         get{ return dE_Dept_Code; }
         set{ dE_Dept_Code = value; dE_Dept_Code_IsChanged=true; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      public bool DE_Dept_Code_IsChanged
      {
         get{ return dE_Dept_Code_IsChanged; }
         set{ dE_Dept_Code_IsChanged = value; }
      }
      /// <summary>
      /// 人员编码
      /// </summary>
      private string dE_Empoyee_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dE_Empoyee_Code_IsChanged=false;
      /// <summary>
      /// 人员编码
      /// </summary>
      public string DE_Empoyee_Code
      {
         get{ return dE_Empoyee_Code; }
         set{ dE_Empoyee_Code = value; dE_Empoyee_Code_IsChanged=true; }
      }
      /// <summary>
      /// 人员编码
      /// </summary>
      public bool DE_Empoyee_Code_IsChanged
      {
         get{ return dE_Empoyee_Code_IsChanged; }
         set{ dE_Empoyee_Code_IsChanged = value; }
      }
      /// <summary>
      /// 关系类型
      /// </summary>
      private string dE_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dE_Type_IsChanged=false;
      /// <summary>
      /// 关系类型
      /// </summary>
      public string DE_Type
      {
         get{ return dE_Type; }
         set{ dE_Type = value; dE_Type_IsChanged=true; }
      }
      /// <summary>
      /// 关系类型
      /// </summary>
      public bool DE_Type_IsChanged
      {
         get{ return dE_Type_IsChanged; }
         set{ dE_Type_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
